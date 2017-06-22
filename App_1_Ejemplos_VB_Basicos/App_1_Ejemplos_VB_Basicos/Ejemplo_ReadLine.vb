Module Ejemplo_ReadLine

    Sub Main()

        Console.WriteLine("Escribe un numero")
        Dim numero As Integer


        For numero = 1 To 10
            ' Do Until Not (numero > 0 And numero < 10)
            ' While numero > 0 And numero < 10    ' DO LOOP

            numero = Console.ReadLine

            Dim i As Integer = 1
            Do
                ' For i As Integer = 1 To 10   ' WHILE
                Console.WriteLine(numero & " x " & i & " = " & numero * i)
                i = i + 1
            Loop Until i = 10
        Next
        Console.ReadLine()
    End Sub
End Module
