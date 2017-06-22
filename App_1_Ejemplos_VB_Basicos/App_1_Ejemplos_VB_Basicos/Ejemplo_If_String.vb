Module Ejemplo_If_String

    Sub Main()
        Dim numClientes As Integer = 98
        Dim etiqueta As Integer = If(numClientes <= 100,
        "Menos de 100 clientes", "Al menos 100 clientes")
        'Muestra "Menos de 100 clientes" 
        Console.WriteLine(etiqueta)

        numClientes = 120
        etiqueta = If(numClientes <= 100, "Menos de 100 clientes",
        "Al menos 100 clientes")

        'Muestra "Al menos 100 clientes" 
        Console.WriteLine(etiqueta)

        System.Console.Read()
    End Sub

End Module
