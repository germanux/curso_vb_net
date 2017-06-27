Public Class FormComboListas
    Private Sub FormComboListas_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        For i = 0 To My.Application.OpenForms.Count - 1
            Label1.Text += My.Application.OpenForms.Item(i).Text & vbCrLf
        Next
    End Sub
End Class