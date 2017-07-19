Imports System.Data.OleDb
Imports System.Data.Common

Namespace Modelo
    Public Class EmpleadosDataSetCRUD
        Implements IEmpleadosCRUD

        Private cadena_conexion As String
        Public avisarEnModicacion As TipoDelAvisarEnModificacion
        Private adaptadorBD As OleDbDataAdapter
        Private dataSet As DataSet
        Private tablaEmpleados As DataTable

        Public Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Restaurar

            cadena_conexion = CrearCadenaConexion(PROVEEDOR_ACCESS, persistenciaEmpleados.nombreFichero)
            adaptadorBD = New OleDbDataAdapter()
            dataSet = New DataSet()
            Dim consultaSQL = "SELECT Id, Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado  ORDER BY Nombre, Apellidos ASC; "
            Dim comandoSelect = ComandoConConexion(cadena_conexion, consultaSQL)
            adaptadorBD.SelectCommand = comandoSelect
            Dim numFilas As Integer = adaptadorBD.Fill(dataSet, "TablaEmpleados")
            MessageBox.Show("Numero de filas: " & numFilas &
                            ", número de columnas: " & dataSet.Tables("TablaEmpleados").Columns.Count)
            comandoSelect.Cerrar()
        End Sub

        Public Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Grabar
            persistenciaEmpleados.Exportar(BuscarEmpleados("", "").ToArray())
            avisarEnModicacion(True)
        End Sub


        Public ReadOnly Property Cantidad As Integer Implements IEmpleadosCRUD.Cantidad
            Get
                Throw New NotImplementedException()
            End Get
        End Property

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

        Public Function BuscarEmpleados(nombre As String, apellido As String) As List(Of Empleado) Implements IEmpleadosCRUD.BuscarEmpleados
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
