Imports App_WinForms_RRHH.Modelo
Public Class Form_baja

    Private frmLista As New Form_Lista

    Public Sub AlActivarseFormulario(sender As Object, e As EventArgs) Handles Me.Activated
        Me.MdiParent.Text = "Baja empleado"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.MdiParent.Text = "Aplicación empleados"
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        EmpleadosCRUD.Eliminar(frmLista.listaEmpleados)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'frmLista.MdiParent = Me.MdiParent
        frmLista.ShowDialog(Me)
        lstEmpleados.Items.Clear()
        lstEmpleados.Items.AddRange(frmLista.lstListaEmpleados.Items)
    End Sub
End Class