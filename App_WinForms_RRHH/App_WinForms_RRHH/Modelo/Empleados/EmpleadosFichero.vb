Namespace Modelo
    Class EmpleadosFichero
        Inherits EmpleadosBaseImportador

        Public Overrides Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean
            ' Declarar variables:
            '   arrayRegistros de tipo cadena
            Dim arrayRegistros() As String
            Dim valorRegistro As String = ""
            Dim empleado As Empleado = New Empleado()
            Dim textoFichero As String

            Try
                If My.Computer.FileSystem.FileExists(NombreFichero) Then
                    '   leer todo el fichero y asignar a textoFichero
                    textoFichero = My.Computer.FileSystem.ReadAllText(NombreFichero)

                    '   asignar a arrayRegistros el textoFichero separado con Split
                    arrayRegistros = textoFichero.Split(vbCr.ToCharArray()(0))
                    ' Bucle Para numeroRegistro desde 0 hasta ultimo elemento de arrayRegistros
                    For i = 0 To arrayRegistros.Length - 1
                        arrayRegistros(i) = arrayRegistros(i).Replace(vbLf, "")
                        '   llamar metodo RellenarConRegistro de empleado pasando como parametro el elemento...
                        '   ...del arrayRegistros(numeroRegistro)
                        Dim siSeHaRellenadoEmpleado = empleado.RellenarConRegistro(arrayRegistros(i))
                        If siSeHaRellenadoEmpleado Then
                            '   Redimensionar arrayEmpleados
                            ReDim Preserve arrayEmpleados(i)
                            '   Añadir empleado al final de arrayEmpleados
                            arrayEmpleados(i) = empleado
                        End If
                        ' Fin bucle
                    Next
                    Return True
                Else
                    MessageBox.Show("No se encuentra el fichero.")
                    Console.WriteLine("No se encuentra el fichero. Ponga un fichero en  C:\Users\sinensia100\" & NombreFichero)
                End If
            Catch ex As IndexOutOfRangeException
                Console.WriteLine("Hay mas elementos de los permitidos")
                Console.WriteLine(ex.Message)
                Console.WriteLine(ex.StackTrace)

            Catch ex As System.IO.FileNotFoundException
                Console.WriteLine("No se encuentra el fichero. Ponga un fichero en  C:\Users\sinensia100\" & NombreFichero)
            Catch ex As Exception
                Console.WriteLine("Excepción de cualquier tipo")
            End Try
            Return False
        End Function
        ' Graba un arrray de empleados en un fichero CSV y devuelve true si se ha grabado
        ' o devuelve false si ha habido un fallo de escritura
        Public Overrides Function Exportar(arrayEmpleados() As Empleado) As Boolean

            Dim fichero As System.IO.StreamWriter
            fichero = My.Computer.FileSystem.OpenTextFileWriter(NombreFichero, False)

            For i = 0 To arrayEmpleados.Length - 1 Step 1
                fichero.WriteLine(arrayEmpleados(i).nombre & "," &
                                  arrayEmpleados(i).apellidos & "," &
                                  arrayEmpleados(i).genero & "," &
                                  arrayEmpleados(i).categoria & "," &
                                  arrayEmpleados(i).retribucionFija)
            Next
            fichero.Close()
            Return True
        End Function

    End Class
End Namespace
