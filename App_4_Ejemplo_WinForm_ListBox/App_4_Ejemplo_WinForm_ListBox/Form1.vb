Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("longitud de texto multilena: " & TextBox1.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & TextBox2.TextLength.ToString())
    End Sub

    Private Sub TextBox1_2_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        lblLongitudes.Text = "longitud de texto multilena: " & TextBox1.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & TextBox2.TextLength.ToString()
    End Sub
End Class
