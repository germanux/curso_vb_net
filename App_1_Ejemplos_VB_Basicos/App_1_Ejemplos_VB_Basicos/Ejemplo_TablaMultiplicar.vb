Module Ejemplo_TablaMultiplicar
    Sub Main()
        Console.WriteLine("Escribe un numero")
        Dim numero As Integer
        Do
            numero = Console.ReadLine
            ' While numero > 0 And numero < 10    ' DO LOOP

            Dim i As Integer = 1
            Do While i <= 10
                ' For i As Integer = 1 To 10   ' WHILE
                Console.WriteLine(numero & " x " & i & " = " & numero * i)
                i = i + 1
            Loop
        Loop While numero > 0 And numero < 10
        Console.ReadLine()
    End Sub
End Module
