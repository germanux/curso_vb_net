
Imports System.Data.OleDb

Namespace Modelo
    Public Class EmpleadosExcel
        Implements IPersistenciaEmpleados
        Private _nombreFichero As String
        Public Property NombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Return _nombreFichero
            End Get
            Set(value As String)
                If (value = "") Then
                    Throw New Exception("No se ha establido el nombre del fichero")
                Else
                    _nombreFichero = value
                End If
            End Set
        End Property

        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar
            Dim listaEmpleados As New List(Of Empleado)
            Dim fila As Integer = 2
            Dim valorNombre As String = DameValorCelda(NombreFichero, "Hoja1", "A", fila)

            While valorNombre <> ""

                ' AQUI NUEVO EMPLEADO, RELLENARLO CON VALORES, Y A LA LISTA
                Dim nuevoEmpleado As Empleado
                nuevoEmpleado.nombre = valorNombre
                nuevoEmpleado.apellidos = DameValorCelda(NombreFichero, "Hoja1", "B", fila)
                nuevoEmpleado.genero = CInt(DameValorCelda(NombreFichero, "Hoja1", "C", fila))
                nuevoEmpleado.categoria = CInt(DameValorCelda(NombreFichero, "Hoja1", "D", fila))
                nuevoEmpleado.retribucionFija = CSng(DameValorCelda(NombreFichero, "Hoja1", "E", fila))
                listaEmpleados.Add(nuevoEmpleado)
                fila = fila + 1
                valorNombre = DameValorCelda(NombreFichero, "Hoja1", "A", fila)
            End While

            arrayEmpleados = listaEmpleados.ToArray()
            Return True
        End Function
        Public Shared Function DameValorCelda(
               nombreFichero As String,
               hoja As String,
               columna As String,
               fila As Integer) As String

            If (Not (IO.File.Exists(nombreFichero))) Then
                Throw New IO.FileNotFoundException("No existe el archivo de Excel indicado")
            End If
            If (String.IsNullOrEmpty(hoja) OrElse
            String.IsNullOrEmpty(columna) OrElse
           fila < 1 OrElse fila > 65536) Then
                Throw New ArgumentException("Argumentos/valores no válidos")
            End If
            Dim cadena_conexion = EmpleadosAccess.CrearCadenaConexion(PROVEEDOR_EXCEL, nombreFichero) _
                & PROPIEDADES_EXCEL
            ' Configurar la conexión
            Using conex As New OleDbConnection(cadena_conexion)
                ' Creamos un objeto Command
                Dim cmd As OleDbCommand = conex.CreateCommand()
                Dim celda As String = columna & fila
                ' Formatear la consulta SQL
                cmd.CommandText = String.Format(
                "SELECT F1 FROM [{0}${1}:{2}]", hoja, celda, celda)

                ' Abrir la consexion
                conex.Open()
                ' Ejecutar la consulta SQL
                Dim valor As Object
                Try
                    valor = cmd.ExecuteScalar()
                Catch ex As Exception
                    valor = ""
                End Try
                ' Devolver el valor convertido a String
                Return Convert.ToString(valor)
            End Using
        End Function

        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar

            Dim oExcel As Object
            Dim oLibro As Object
            Dim oHoja As Object
            Try
                ' Creamos un objeto cuyo contenido es una instancia de Excel
                oExcel = CreateObject("Excel.Application")
                ' Comenzar nuevo libro de Excel
                oLibro = oExcel.Workbooks.Add
                oHoja = oLibro.Worksheets(1)

                Dim ArrayDatos(arrayEmpleados.Count, 4) As String
                Dim r As Integer
                For r = 0 To arrayEmpleados.Count - 1
                    ArrayDatos(r, 0) = arrayEmpleados(r).nombre
                    ArrayDatos(r, 1) = arrayEmpleados(r).apellidos
                    ArrayDatos(r, 2) = arrayEmpleados(r).genero
                    ArrayDatos(r, 3) = arrayEmpleados(r).categoria
                    ArrayDatos(r, 4) = arrayEmpleados(r).retribucionFija
                Next
                oHoja.Range("A1:E1").Value = New String() {"NOMBRE", "APELLIDOS", "GENERO", "CATEGORIA", "RETRIBUCIÓN FIJA"}
                oHoja.Range("A2").Resize(arrayEmpleados.Length, 5).Value = ArrayDatos

                ' Guardar el libro y salir de Excel
                oLibro.SaveAs(NombreFichero)
                oExcel.Quit()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.ToString())
                Return False
            End Try
            Return True
        End Function

    End Class

End Namespace