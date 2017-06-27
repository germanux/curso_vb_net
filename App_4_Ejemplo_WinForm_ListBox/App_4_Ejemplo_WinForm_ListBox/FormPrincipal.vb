Public Class FormPrincipal
    Private miFormComboListas As FormComboListas
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miFormComboListas = New FormComboListas()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("longitud de texto multilena: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & txtDiezCaracteres.TextLength.ToString())
    End Sub
    Private Sub TextBox1_2_TextChanged(sender As Object, e As EventArgs) Handles txtMultilinea.TextChanged, txtDiezCaracteres.TextChanged
        lblLongitudes.Text = "longitud de texto multilena: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & txtDiezCaracteres.TextLength.ToString()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstListaDatos.Items.Add(txtMultilinea.Text)
    End Sub
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        lstListaDatos.Items.Add(txtDiezCaracteres.Text)
        txtDiezCaracteres.Clear()
    End Sub
    Private Sub btnEliminarDeLista_Click(sender As Object, e As EventArgs) Handles btnEliminarDeLista.Click
        lstListaDatos.Items.RemoveAt(lstListaDatos.SelectedIndex)
    End Sub
    Private Sub lstListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListaDatos.SelectedIndexChanged

        btnEliminarDeLista.Enabled = (lstListaDatos.SelectedIndex >= 0)
    End Sub
    Private Sub btnAbrirForm_Click(sender As Object, e As EventArgs) Handles btnAbrirForm.Click
        If miFormComboListas Is Nothing Or miFormComboListas.IsDisposed Then
            miFormComboListas = New FormComboListas()
        End If
        miFormComboListas.Show()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        miFormComboListas.Hide()  'nuevoFormComboListas.Close()
    End Sub
End Class
