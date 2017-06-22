Module Ejemplo_EdadIf
    Sub Main()
        Dim Edad As Integer ' numero entero

        Edad = 10
        ' "Niño": cuando es menor de 12
        ' "Adolescente": hasta los 17
        ' Si tiene 18, "por fin adulto"
        ' Si tien4e 19 y 20, "universitario"
        ' "Adulto": hasta los 65
        ' "Aprovechemos la jubilacion": Apartir de 65: 

        Dim texto As String

        If Edad < 12 Then
            texto = "Es niño"
        ElseIf Edad <= 17 Then
            texto = "Adolescente"
        ElseIf Edad = 18 Then
            texto = "por fin adulto"
        ElseIf Edad = 19 Or Edad = 20 Or Edad = 21 Then
            texto = "universitario"
        ElseIf Edad >= 21 And Edad <= 65 Then
            texto = "adulto"
        Else
            texto = "aprovechando la jubilación"
        End If

        Console.WriteLine(texto)

        Console.Read()
    End Sub
End Module
