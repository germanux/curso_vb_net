Public Class Circulo
    Inherits Figura

    Public Delegate Sub CuandoSeCalculaArea(texto As String)

    Public radio As Single
    Private funCuandoSeCalArea As CuandoSeCalculaArea

    Public Sub New(radio As Single, funCSCA As CuandoSeCalculaArea)
        Me.radio = radio
        Me.funCuandoSeCalArea = funCSCA
    End Sub
    Public Overrides Function CalcularArea() As Single
        _area = CType(radio * radio * Math.PI, Single)
        If funCuandoSeCalArea <> Nothing Then
            Me.funCuandoSeCalArea("UN CIRCULO")
        End If
        Return _area
    End Function
    Public Overrides Function CalcularPerimetro() As Single
        _perimetro = radio * 2 * CSng(Math.PI)
        Return _perimetro
    End Function
    Public Overrides Sub Mostrar()
        Dim variableCualquieraLocal As String = "Un texto"

        Console.WriteLine("Radio:     " & radio)
        Console.WriteLine(", Area:      " & CalcularArea())
        Console.WriteLine("Perimetro: " & CalcularPerimetro())
    End Sub
End Class
