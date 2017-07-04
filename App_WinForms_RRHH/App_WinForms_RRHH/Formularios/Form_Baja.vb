Public Class Form_baja

    Public Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated

        Me.MdiParent.Text = "Baja empleado"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate

        Me.MdiParent.Text = "Aplicación empleados"
    End Sub
End Class