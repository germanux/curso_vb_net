
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
            MessageBox.Show("Importar " & NombreFichero)
            Throw New NotImplementedException()
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