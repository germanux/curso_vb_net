Namespace Modelo
    Public MustInherit Class EmpleadosBaseImportador
        Implements IPersistenciaEmpleados

        Private _nombreFichero As String
        Public Property NombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Return _nombreFichero
            End Get
            Set(value As String)
                If (value = "") Then
                    MessageBox.Show("No se ha establecido el nombre del fichero")
                Else
                    _nombreFichero = value
                End If
            End Set
        End Property
        Public MustOverride Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar

        Public MustOverride Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar

    End Class
End Namespace
