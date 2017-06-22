Module Ejemplo_EdadSelect
    Sub Main()
        Dim edad As Integer
        Dim personas As Integer

        For personas = 1 To 10
            Console.Write("Introduzca edad: ")
            edad = Console.ReadLine
            Console.WriteLine("personas = " & personas & ", edad = " & edad)
            Select Case edad
     'Esta primera etiqueta gestiona los valores inferiores a 18  
                Case < 18
                    Console.WriteLine("Todavía algo joven...")
     'Esta etiqueta gestiona el caso en que la variable edad vale 18  
                Case 18
                    Console.WriteLine("¡Por fin adulto!")
     'Esta etiqueta gestiona el caso en que la variable edad vale 19 o 20 
                Case 19, 20, 21
                    Console.WriteLine("Termina la universidad, empieza la vida activa")
     'Esta etiqueta gestiona los valores comprendidos entre 21 y 65  
                Case 22 To 65
                    Console.WriteLine("¡Todavía {0} años hasta la jubilación!", 65 - edad)
     'Esta etiqueta gestiona los valores superiores a 65  
                Case > 65
                    Console.WriteLine("¡Aprovechemos la jubilación!")
            End Select
        Next
        Console.Read()
    End Sub
End Module
