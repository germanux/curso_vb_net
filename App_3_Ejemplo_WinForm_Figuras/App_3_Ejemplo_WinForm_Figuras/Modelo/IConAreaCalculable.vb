Public Interface IConAreaCalculable
    ' Nueva propiedad de solo lectura
    ' que obligue a implementar una propiedad Area (como resultado)
    ReadOnly Property Area() As Single
    Function CalcularArea() As Single ' Renombrar/refactorizar a calcula area
End Interface
Public Interface IConPerimetroCalculable
    ReadOnly Property Perimetro() As Single
    Function CalcularPerimetro() As Single ' Renombrar/refactorizar a calcula area
End Interface

Public Interface ICalculable
    Inherits IConAreaCalculable, IConPerimetroCalculable

End Interface
