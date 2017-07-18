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

            Using conexionDB As New OleDbConnection(cadena_conexion)

                Try
                    conexionDB.Open()

                    For Each empleado As Empleado In arrayEmpleados

                        Dim comando As OleDbCommand = New OleDbCommand(consultaSQL, conexionDB)

                        comando.AñadirParametro("@nombre", empleado.nombre)
                        comando.AñadirParametro("@apellidos", empleado.apellidos)
                        comando.AñadirParametro("@genero", empleado.genero, , DbType.Int32)
                        comando.AñadirParametro("@categoria", empleado.categoria, , DbType.Int32)
                        comando.AñadirParametro("@retribucionFija", empleado.retribucionFija, , DbType.Single)

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

    End Class

End Namespace
