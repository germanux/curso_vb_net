Imports System.Data.OleDb

Namespace Modelo
    Public Class EmpleadosAccess
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
        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar

            Dim cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, NombreFichero)
            ' Despues del nombre del fichero, o antes, separado por punto y coma, usuario y password
            'TODO: Añadir      ";User Id=admin;Password=Contraseña_1234"

            Using conexionDB As New OleDbConnection(cadena_conexion)

                Try
                    conexionDB.Open()

                    For Each empleado As Empleado In arrayEmpleados
                        ' INSERT INTO empleado (Nombre, Apellidos, Genero) VALUES ('Juan', 'Lopez', 2)

                        Dim sql As String
                        sql = "INSERT INTO empleado ( Nombre, Apellidos, Genero, Categoria, " _
                            & "Retribucion_Fija ) VALUES ( '" _
                            & empleado.nombre & "', '" & empleado.apellidos & "', " _
                            & empleado.genero & ", " & empleado.categoria & ", " _
                            & empleado.retribucionFija & " ) "

                        Console.WriteLine(sql)
                        Dim comando As OleDbCommand = New OleDbCommand(sql, conexionDB)

                        comando.ExecuteNonQuery()
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error al exportar Access " & ex.Message)
                    Return False
                End Try
                conexionDB.Close() ' Es redundante con Using...
                conexionDB.Dispose()
            End Using
            Return True
        End Function
        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar

            Dim listaEmpleados As New List(Of Empleado)

            Dim cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, NombreFichero)

            Console.WriteLine("Cadena de conexión: {0}", cadena_conexion)

            Using conexionDB As New OleDbConnection(cadena_conexion)

                Dim consultaSQL = "SELECT Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado  ORDER BY Nombre, Apellidos ASC; "

                Dim comando As New OleDbCommand(consultaSQL, conexionDB)

                Try
                    conexionDB.Open()
                    Dim dataReader As OleDbDataReader = comando.ExecuteReader()
                    ' dataReader.NextResult()
                    ' dataReader.Re
                    Do While dataReader.Read()
                        Dim nuevoEmpleado As New Empleado()
                        nuevoEmpleado.nombre = dataReader(0)
                        nuevoEmpleado.apellidos = dataReader(1)
                        nuevoEmpleado.genero = dataReader(2)
                        nuevoEmpleado.categoria = dataReader(3)
                        nuevoEmpleado.retribucionFija = dataReader(4)

                        listaEmpleados.Add(nuevoEmpleado)
                    Loop
                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al importar " & ex.Message)
                End Try

            End Using

            arrayEmpleados = listaEmpleados.ToArray()
            Return True
        End Function
        Public Shared Function CrearCadenaConexion(proveedor As String, fuente_datos As String) As String
            Dim constructor As New OleDbConnectionStringBuilder()
            constructor.Provider = proveedor
            constructor.DataSource = fuente_datos
            Return constructor.ConnectionString
        End Function
    End Class

End Namespace
