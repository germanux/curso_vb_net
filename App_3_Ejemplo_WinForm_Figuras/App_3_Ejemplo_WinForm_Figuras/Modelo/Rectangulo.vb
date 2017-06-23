Public Class Rectangulo
    Inherits Figura

    Public alto As Single
    Public ancho As Single

    Public Sub New(alto As Single, ancho As Single)
        Me.alto = alto
        Me.ancho = ancho
    End Sub
    Public Overrides Function CalcularArea() As Single
        _area = alto * ancho
        Return _area
    End Function
    Public Overrides Function CalcularPerimetro() As Single
        _perimetro = alto * 2 + ancho * 2
        Return _perimetro
    End Function
    Public Overrides Sub Mostrar()
        Console.WriteLine("Ancho:     " & ancho &
                          ", Alto:      " & alto)
        Console.WriteLine("Area:      " & CalcularArea())
        Console.WriteLine("Perimetro: " & CalcularPerimetro())
    End Sub
End Class
