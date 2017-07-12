Namespace Modelo
    Public Class EmpleadosGenerador
        Implements IPersistenciaEmpleados
        Public Property nombreFichero As String Implements IPersistenciaEmpleados.nombreFichero
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property
        Public Function Exportar(arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Exportar
            Throw New NotImplementedException()
        End Function
        Public Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean Implements IPersistenciaEmpleados.Importar

            ReDim arrayEmpleados(10000)

            For num = 0 To 10000
                Dim nuevoEmp As New Empleado()

                nuevoEmp.nombre = dameNombreAleatorio()
                nuevoEmp.apellidos = dameApellidoAleatorio() & " " & dameApellidoAleatorio()
                nuevoEmp.genero = Rnd() * 3 + 1
                nuevoEmp.categoria = Rnd() * 3 + 1
                nuevoEmp.retribucionFija = CInt(Rnd() * 20) * 1000 + 15000

                arrayEmpleados(num) = nuevoEmp
            Next
        End Function
        Function dameNombreAleatorio() As String
            Dim nombres() = New String() {"Juan", "Pepe", "Pedro", "Oscar", "Fernando", "Sergi", "J.C.", "Nicolas", "Victor", "Miguel Angel", "German", "Ana", "Maria"}
            Return nombres(Rnd() * (nombres.Length - 1))
        End Function
        Function dameApellidoAleatorio() As String
            Dim apellidos() = New String() {"Lopez", "Rodriguez", "Perez", "Valera", "Martinez", "Calizo", "Hernandez", "Caballero", "Puertas", "Del Bosque"}
            Return apellidos(Rnd() * (apellidos.Length - 1))
        End Function
    End Class
End Namespace
