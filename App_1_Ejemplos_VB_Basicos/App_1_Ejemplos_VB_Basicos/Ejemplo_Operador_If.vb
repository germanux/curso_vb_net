Module Ejemplo_Operador_If
    Sub Main()
        Const OPERADOR As Char = "/"c
        Dim operador1 As Single = 5
        Dim operador2 As Single = 2
        Dim resultado As Single
        Dim operadorValido As Boolean = True

        resultado = If(OPERADOR = "+",
                operador1 + operador2,
                If(OPERADOR = "*",
                    operador1 * operador2,
                    If(OPERADOR = "/",
                        operador1 / operador2,
                        If(OPERADOR = "-",
                            operador1 - operador2,
                            0)
                    )))

        If OPERADOR = "+" Then
            resultado = operador1 + operador2
        ElseIf OPERADOR = "*" Then
            resultado = operador1 * operador2
        ElseIf OPERADOR = "/" Then
            resultado = If(operador2 = 0, 0, operador1 / operador2)
            operadorValido = (operador2 <> 0)
        ElseIf OPERADOR = "-" Then
            resultado = operador1 - operador2
        Else
            operadorValido = False
        End If

        If Not operadorValido Then
            Console.WriteLine("El operador no es valido")
        Else
            Console.WriteLine("El resultado de " & operador1 & " " & OPERADOR & " " & operador2 & " = " & resultado)
        End If
        System.Console.Read()
    End Sub
End Module
