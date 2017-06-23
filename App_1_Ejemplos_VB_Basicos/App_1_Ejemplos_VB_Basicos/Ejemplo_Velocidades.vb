Module Ejemplo_Velocidades
    Sub Main()
        Dim arcoiris() As String = New String() {"rojo", "verde", "azul", "amarillo"}

        For Each color As String In arcoiris
            Console.WriteLine("Toca el color " & color)
        Next
        Console.Read()


        ' opcion se refiere a la ubicacion
        Dim opcion As Char

        Do ' Bucle hasta que se introduzca una S

            ' Mostrar el menú entero 
            Console.WriteLine("Opciones: " + vbCrLf & " (E)uropa" + vbCrLf &
                              " (U)SA" + vbCrLf & " (M)ar" + vbCrLf & " (S)alir")

            'Pedir una tecla, un único caracter 
            opcion = Console.ReadKey().KeyChar
            ' Solo entra si no se pulsa una S
            If opcion <> "s" And opcion <> "S" Then
                Dim velocidades() As Single = {1, 2, 5, 10, 50}

                ' Recorremos el array de velocidades
                For Each velocidad As Integer In velocidades
                    Select Case opcion
                        Case "E", "e"
                            Console.WriteLine("Km/h " & velocidad * 3.6)
                        Case "U", "u"
                            Console.WriteLine("Millas " & velocidad * 4)
                        Case "M", "m"
                            Console.WriteLine("Nudos " & velocidad * 5)
                    End Select
                Next
            End If
        Loop Until opcion = "s" Or opcion = "S"
    End Sub
End Module
