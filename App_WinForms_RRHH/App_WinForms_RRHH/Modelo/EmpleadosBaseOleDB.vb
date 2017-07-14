Namespace Modelo
    Public Class EmpleadosBaseOleDB
        Inherits EmpleadosBaseImportador

        Public Overrides Function Exportar(arrayEmpleados() As Empleado) As Boolean
            Throw New NotImplementedException()
        End Function

        Public Overrides Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace
