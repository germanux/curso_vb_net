Namespace Modelo

    Public Delegate Sub TipoDelAvisarEnModificacion(estado As Boolean)

    Public Interface IEmpleadosCRUD
        ReadOnly Property Cantidad As Integer
        Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion)
        Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados)
        Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados)
        Sub Crear(nuevoEmpleado As Empleado)
        Function BuscarEmpleados(nombre As String, apellido As String) As List(Of Empleado)
        Sub Actualizar(empleado As Empleado, empleadoModif As Empleado)
        Sub Eliminar(empleado As Empleado)
        Sub Eliminar(empleados As List(Of Empleado))
    End Interface
End Namespace
