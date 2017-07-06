Namespace Modelo

    ' CRUD
    ' Create, Read, Update, Delete
    ' Crear, Leer, Actualizar, Eliminar
    Module EmpleadosCRUD
        'Private listaEmpleados() As Empleado
        Private listaEmpleados As List(Of Empleado)

        Public Sub Restaurar()
            listaEmpleados = New List(Of Empleado)()
            ' EmpleadosFichero.LeerFichero(listaEmpleados.ToArray())
            Dim arrayEmpleados() As Empleado
            arrayEmpleados = listaEmpleados.ToArray()
            EmpleadosFichero.LeerFichero(arrayEmpleados)
            listaEmpleados = arrayEmpleados.ToList()
        End Sub
        Public Sub Grabar()
            EmpleadosFichero.GrabarFichero(listaEmpleados.ToArray())
        End Sub
        Sub Crear(nuevoEmpleado As Empleado)
            ' Asignamos nuevo empleado
            listaEmpleados.Add(nuevoEmpleado)
        End Sub
        Function Cantidad() As Integer
            Return listaEmpleados.Count
        End Function
        'Function Leer(indice As Integer) As Empleado
        '    Return listaEmpleados(indice)
        'End Function
        Function BuscarEmpleados(nombre As String, apellido As String) As List(Of Empleado)
            nombre = nombre.ToUpper()
            apellido = apellido.ToUpper()
            BuscarEmpleados = New List(Of Empleado)()

            For index = 0 To listaEmpleados.Count - 1
                Dim encontradoNombre As Boolean = False
                Dim encontradoApellido As Boolean = False
                If nombre = "" Or
                    (nombre <> "" And listaEmpleados(index).nombre.ToUpper().Contains(nombre)) Then
                    encontradoNombre = True
                End If
                If apellido = "" Or
                    (apellido <> "" And listaEmpleados(index).apellidos.ToUpper().Contains(apellido)) Then
                    encontradoApellido = True
                End If
                If encontradoApellido And encontradoNombre Then
                    BuscarEmpleados.Add(listaEmpleados(index))
                End If
            Next
        End Function
        Sub Actualizar(indice As Integer, empleado As Empleado)
            listaEmpleados(indice) = empleado
        End Sub
        Sub Actualizar(empleado As Empleado, empleadoModif As Empleado)
            Dim i = listaEmpleados.IndexOf(empleado)
            listaEmpleados.Item(i) = empleadoModif
        End Sub
        '' Para eliminar
        '' 1 2 3 4 5 6 7 8 9 10
        '' posicion:
        '' 0 1 2 3 4
        Sub Eliminar(indice As Integer)
            listaEmpleados.RemoveAt(indice)
        End Sub
        Sub Eliminar(empleado As Empleado)
            listaEmpleados.Remove(empleado)
        End Sub
        Sub Eliminar(empleados As List(Of Empleado))
            For Each empleado In empleados
                Eliminar(empleado)
            Next
        End Sub
    End Module
End Namespace