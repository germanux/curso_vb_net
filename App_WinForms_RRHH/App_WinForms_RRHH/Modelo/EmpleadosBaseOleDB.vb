Imports System.Data.OleDb

Namespace Modelo
    Public Class EmpleadosBaseOleDB
        Inherits EmpleadosBaseImportador

        Protected cadena_conexion As String
        Protected consultaSQL As String

        Public Overrides Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean

            Dim listaEmpleados As New List(Of Empleado)

            Using conexionDB As New OleDbConnection(cadena_conexion)

                Dim comando As New OleDbCommand(consultaSQL, conexionDB)

                Try
                    conexionDB.Open()
                    Dim dataReader As OleDbDataReader = comando.ExecuteReader()
                    ' dataReader.NextResult()
                    ' dataReader.Re
                    Do While dataReader.Read()
                        Dim nuevoEmpleado As New Empleado()
                        nuevoEmpleado.nombre = CType(dataReader(0), String)
                        nuevoEmpleado.apellidos = dataReader.GetString(1)
                        nuevoEmpleado.genero = CType(dataReader(2), TipoGenero)
                        nuevoEmpleado.categoria = CType(dataReader(3), TipoCategoria)
                        nuevoEmpleado.retribucionFija = CType(dataReader(4), Single)

                        listaEmpleados.Add(nuevoEmpleado)
                    Loop
                    dataReader.Close()

                    MessageBox.Show("Se han importado " & listaEmpleados.Count & " empleados.")

                Catch ex As Exception
                    MessageBox.Show("Error al importar " & ex.Message)
                End Try

            End Using

            arrayEmpleados = listaEmpleados.ToArray()
            Return True
        End Function
        Public Overrides Function Exportar(arrayEmpleados() As Empleado) As Boolean

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
                            & "Retribucion_Fija ) VALUES (@nombre, @apellidos, @genero, @categoria, @retribucionFija )"

                        ''" _
                        '& empleado.nombre & "', '" & empleado.apellidos & "', " _
                        '& empleado.genero & ", " & empleado.categoria & ", " _
                        '& empleado.retribucionFija & " ) "

                        Console.WriteLine(sql)
                        Dim comando As OleDbCommand = New OleDbCommand(sql, conexionDB)

                        Dim paramNombre As OleDbParameter = New OleDbParameter("@nombre", empleado.nombre)
                        paramNombre.Direction = ParameterDirection.Input
                        paramNombre.DbType = DbType.String
                        paramNombre.Size = 30

                        Dim paramApellidos As OleDbParameter = New OleDbParameter("@apellidos", empleado.apellidos)
                        paramApellidos.Direction = ParameterDirection.Input
                        paramApellidos.DbType = DbType.String
                        paramApellidos.Size = 30

                        Dim paramgenero As OleDbParameter = New OleDbParameter("@genero", empleado.genero)
                        paramgenero.Direction = ParameterDirection.Input
                        paramgenero.DbType = DbType.Int32
                        paramgenero.Size = 30

                        Dim paramcategoria As OleDbParameter = New OleDbParameter("@categoria", empleado.categoria)
                        paramcategoria.Direction = ParameterDirection.Input
                        paramcategoria.DbType = DbType.Int32
                        paramcategoria.Size = 30

                        Dim paramretribucionFija As OleDbParameter = New OleDbParameter("@retribucionFija", empleado.retribucionFija)
                        paramretribucionFija.Direction = ParameterDirection.Input
                        paramretribucionFija.DbType = DbType.Single
                        paramretribucionFija.Size = 30

                        comando.Parameters.Add(paramNombre)
                        comando.Parameters.Add(paramApellidos)
                        comando.Parameters.Add(paramgenero)
                        comando.Parameters.Add(paramcategoria)
                        comando.Parameters.Add(paramretribucionFija)

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

        Public Shared Function CrearCadenaConexion(proveedor As String, fuente_datos As String) As String
            Dim constructor As New OleDbConnectionStringBuilder()
            constructor.Provider = proveedor
            constructor.DataSource = fuente_datos
            Return constructor.ConnectionString
        End Function
    End Class

End Namespace
