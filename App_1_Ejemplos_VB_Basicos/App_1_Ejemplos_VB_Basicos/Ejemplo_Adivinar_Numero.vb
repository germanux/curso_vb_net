Module Ejemplo_Adivinar_Numero
    Sub Main()
        Dim numero_a_adivinar As Integer = 27
        Dim numeroUsuario
        Dim intentos As Integer = 5

        Do
            Console.WriteLine("Introcuzca numero ruleta")
            numeroUsuario = Console.ReadLine()
            If numeroUsuario < numero_a_adivinar Then
                Console.WriteLine("Fallo, el numero a adivinar es mayor")
                intentos = intentos - 1
            ElseIf numeroUsuario > numero_a_adivinar Then
                Console.WriteLine("Fallo, el numero a adivinar es menor")
                intentos = intentos - 1
            Else
                Console.WriteLine("Acertaste!!")
            End If
        Loop While numeroUsuario <> numero_a_adivinar And intentos > 0
        Console.WriteLine("Fin loteria")
        Console.ReadLine()
    End Sub
End Module
