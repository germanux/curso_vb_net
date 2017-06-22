Module Ejemplo_AreaCirculo
    Sub Main()
        Dim radio, area As Single
        Dim contador, numeroCirculos As Integer

        Console.Write("Numero Circulos? ")
        numeroCirculos = Console.ReadLine

        For contador = 1 To numeroCirculos
            Console.Write("Introduzca radio: ")
            radio = Console.ReadLine
            area = Math.PI * radio ^ 2 'Math.Pow(radio, 2) 

            Console.WriteLine("posicion = " & contador & "/" & numeroCirculos & ", radio = " & radio &
                                ", area = " & area)
            Select Case area
                Case < 10
                    Console.WriteLine("Pequeño circulo")
                Case 10 To 100
                    Console.WriteLine("Mediano circulo")
                Case > 100
                    Console.WriteLine("Gran circulo")
                Case Else
                    Console.WriteLine("Es negativo, no vale")
            End Select
        Next
        Console.Read()
    End Sub
End Module
