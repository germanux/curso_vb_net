Imports App_WinForms_RRHH.Modelo

Public Class Form_Lista
    Public listaEmpleados As List(Of Empleado)
    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        BuscarEmpleado()
    End Sub
    Private Sub cmbNombre_TextChanged(sender As Object, e As EventArgs) _
        Handles cmbNombre.TextChanged, cmbApellidos.TextChanged
        BuscarEmpleado()
    End Sub
    Private Sub BuscarEmpleado()
        lstListaEmpleados.Items.Clear()
        listaEmpleados = EmpleadosCRUD.BuscarEmpleados(cmbNombre.Text, cmbApellidos.Text)

        For Each empleado As Empleado In listaEmpleados
            lstListaEmpleados.Items.Add(empleado.nombre & " " & empleado.apellidos)
        Next
    End Sub
End Class