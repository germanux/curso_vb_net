Imports System.Data.OleDb

Namespace Modelo
    Public Class EmpleadosAccessCRUD
        Implements IEmpleadosCRUD

        Private cadena_conexion As String
        Public avisarEnModicacion As TipoDelAvisarEnModificacion

        ' NO
        Public ReadOnly Property Cantidad As Integer Implements IEmpleadosCRUD.Cantidad
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        '?
        Public Sub Actualizar(empleado As Empleado, empleadoModif As Empleado) Implements IEmpleadosCRUD.Actualizar
            Throw New NotImplementedException()
        End Sub
        Public Sub Crear(nuevoEmpleado As Empleado) Implements IEmpleadosCRUD.Crear
            Throw New NotImplementedException()
        End Sub
        Public Sub Eliminar(empleados As List(Of Empleado)) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub
        Public Sub Eliminar(empleado As Empleado) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub
        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IEmpleadosCRUD.EstablecerAvisarEnModificacion
            avisarEnModicacion = funcionDelegada
        End Sub
        Public Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Grabar
            Throw New NotImplementedException()
        End Sub
        ' SI
        Public Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Restaurar
            cadena_conexion = EmpleadosBaseOleDB.CrearCadenaConexion(PROVEEDOR_ACCESS, persistenciaEmpleados.nombreFichero)
        End Sub
        Public Function BuscarEmpleados(nombre As String, apellido As String) As List(Of Empleado) Implements IEmpleadosCRUD.BuscarEmpleados

            Dim consultaSQL = "SELECT Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado  ORDER BY Nombre, Apellidos ASC; "
            BuscarEmpleados = New List(Of Empleado)
            Using conexionDB As New OleDbConnection(cadena_conexion)
                Dim comando As New OleDbCommand(consultaSQL, conexionDB)
                Try
                    conexionDB.Open()
                    Dim dataReader As OleDbDataReader = comando.ExecuteReader()
                    Do While dataReader.Read()
                        Dim nuevoEmpleado As New Empleado()
                        nuevoEmpleado.nombre = CType(dataReader(0), String)
                        nuevoEmpleado.apellidos = dataReader.GetString(1)
                        nuevoEmpleado.genero = CType(dataReader(2), TipoGenero)
                        nuevoEmpleado.categoria = CType(dataReader(3), TipoCategoria)
                        nuevoEmpleado.retribucionFija = CType(dataReader(4), Single)

                        BuscarEmpleados.Add(nuevoEmpleado)
                    Loop
                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al importar " & ex.Message)
                End Try

            End Using
        End Function
    End Class
End Namespace
