Public Class FormComboListas
    Private Sub FormComboListas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i = 0 To My.Application.OpenForms.Count - 1
        '    Label1.Text += My.Application.OpenForms.Item(i).Text & vbCrLf
        'Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        cmbTextos.Items.Add(txtTexto.Text)
        cmbTextos.SelectedItem = txtTexto.Text
        txtTexto.Clear()
        txtTexto.Focus()
    End Sub
    Private Sub btnPasar_Click(sender As Object, e As EventArgs) Handles btnPasar.Click
        If chkListTextos.Items.Count < TrackBar1.Value Then
            If cmbTextos.SelectedItem IsNot Nothing Then
                chkListTextos.Items.Add(cmbTextos.SelectedItem)
                cmbTextos.Items.Remove(cmbTextos.SelectedItem)
                If cmbTextos.Items.Count > 0 Then
                    cmbTextos.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        While chkListTextos.CheckedItems.Count > 0
            cmbTextos.Items.Add(chkListTextos.CheckedItems.Item(0))
            chkListTextos.Items.Remove(chkListTextos.CheckedItems.Item(0))
        End While
    End Sub
End Class