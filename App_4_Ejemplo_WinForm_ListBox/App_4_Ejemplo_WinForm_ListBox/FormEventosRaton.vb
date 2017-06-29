Public Class FormEventosRaton

    Private Sub AlPulsarRaton(sender As Object, e As MouseEventArgs) _
        Handles Me.MouseDown, Me.MouseMove
        Dim nuevoBoton As New Button
        nuevoBoton.Size = New Size(20, 20)
        nuevoBoton.Text = "X"

        nuevoBoton.Parent = Me
        nuevoBoton.Location = e.Location

    End Sub

End Class