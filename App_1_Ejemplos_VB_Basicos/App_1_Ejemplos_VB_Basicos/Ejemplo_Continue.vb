Module Ejemplo_Continue
    Sub Main()
        Console.WriteLine("Empezando")
        For i = 0 To 20
            Console.WriteLine("Inicio del bucle ")
            If i = 5 Then

                Console.WriteLine("Si el valor es igual a 5")

                Continue For

                Console.WriteLine("Si el valor es igual a 5 segunda parte")
            End If

            Console.WriteLine("Procesamientos específicos para los números diferentes a 5 ")
            'Procesamientos específicos para los números diferentes a 5 
        Next
        Console.WriteLine("Fin de bucle")

        Console.Read()
    End Sub
End Module
