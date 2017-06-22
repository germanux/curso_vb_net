Module EjemploArcoTangente
    Sub Main()
        Dim x, y As Single
        Dim truncado, redondeado As Integer

        Console.Write("X? ")
        x = Console.ReadLine
        Console.Write("Y? ")
        y = Console.ReadLine

        Console.WriteLine("Arcotan = " & Math.Atan2(y, x))

        truncado = Math.Floor(Math.Atan2(y, x))
        Console.WriteLine("Arcotan truncado = " & truncado)
        redondeado = Math.Round(Math.Atan2(y, x))
        Console.WriteLine("Arcotan redondeado = " & redondeado)

        Console.Read()
    End Sub
End Module
