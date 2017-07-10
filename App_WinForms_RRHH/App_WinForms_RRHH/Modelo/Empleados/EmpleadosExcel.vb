Namespace Modelo
    Public Class EmpleadosExcel
        Implements IPersistenciaEmpleados
        Private _nombreFichero As String
        Private Property NombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Return _nombreFichero
            End Get
            Set(value As String)
                If (_nombreFichero = "") Then
                    Throw New Exception("No se ha establido el nombre del fichero")
                Else
                    _nombreFichero = value
                End If
            End Set
        End Property

        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Throw New NotImplementedException()
        End Function

        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace