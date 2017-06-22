Module Ejemplo_Booleanos
    Sub Main()
        Dim resultadoBool As Boolean

        resultadoBool = (5 > 3) And (9 = 8) And (Not (4 = 4))

        resultadoBool = False And False 'False
        resultadoBool = True And False 'False
        resultadoBool = False And True 'False
        resultadoBool = True And True 'True

        resultadoBool = False Or False 'False
        resultadoBool = True Or False 'True
        resultadoBool = False Or True 'True
        resultadoBool = True Or True 'True
    End Sub
End Module
