Namespace Modelo

    ' CRUD
    ' Create, Read, Update, Delete
    ' Crear, Leer, Actualizar, Eliminar
    Module EmpleadosCRUD
        Private listaEmpleados() As Empleado

        Public Sub Restaurar()
            listaEmpleados = New Empleado() {}
            EmpleadosFichero.LeerFichero(listaEmpleados, "personal.csv")
        End Sub
        Sub Crear(nuevoEmpleado As Empleado)
            ' Redimensionar el array
            ReDim Preserve listaEmpleados(listaEmpleados.Length)
            ' Asignamos nuevo empleado
            listaEmpleados(listaEmpleados.Length - 1) = nuevoEmpleado
            EmpleadosFichero.GrabarFichero(listaEmpleados, "personal.csv")
        End Sub
        Function Cantidad() As Integer
            Return listaEmpleados.Length
        End Function
        Function Leer(indice As Integer) As Empleado
            Return listaEmpleados(indice)
        End Function
        Function BuscarPorCampoEmpleado(valor As String) As Integer
            Dim indiceEmpleado As Integer
            indiceEmpleado = BuscarPorCampoEmpleado(valor, TipoCampoEmpleado.Nombre)
            Return indiceEmpleado
        End Function
        Function BuscarPorCampoEmpleado(valor As String, Optional campo As TipoCampoEmpleado = TipoCampoEmpleado.Nombre) As Integer
            For index = 0 To listaEmpleados.Length - 1
                Select Case campo
                    Case TipoCampoEmpleado.Nombre
                        If listaEmpleados(index).nombre = valor Then
                            Return index
                        End If
                    Case TipoCampoEmpleado.Apellidos
                        If listaEmpleados(index).apellidos = valor Then
                            Return index
                        End If
                End Select
            Next
            Return -1
        End Function
        Sub Actualizar(indice As Integer, empleado As Empleado)
            listaEmpleados(indice) = empleado
            EmpleadosFichero.GrabarFichero(listaEmpleados, "personal.csv")
        End Sub
        ' Para eliminar
        ' 1 2 3 4 5 6 7 8 9 10
        ' posicion:
        ' 0 1 2 3 4
        Sub Eliminar(indice As Integer)
            Array.Copy(listaEmpleados, indice + 1, listaEmpleados, indice, listaEmpleados.Length - 1 - indice)
            Array.Resize(listaEmpleados, listaEmpleados.Length - 1)
            EmpleadosFichero.GrabarFichero(listaEmpleados, "personal.csv")
        End Sub
    End Module
End Namespace