Module Ejemplo_IfNulo
    Sub Main()
        Dim ciudad As String
        Dim etiqueta As String = If(ciudad, "indefinida")

        'Muestra "indefinida" 
        Console.WriteLine(etiqueta)

        ciudad = "VALENCIA"
        etiqueta = If(ciudad, "indefinida")

        'Muestra "VALENCIA" 
        Console.WriteLine(etiqueta)
        System.Console.Read()
    End Sub
End Module
