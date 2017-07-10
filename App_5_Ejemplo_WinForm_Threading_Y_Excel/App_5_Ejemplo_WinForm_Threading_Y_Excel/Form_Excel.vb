Public Class Form_Excel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Lector As New LectorExcel

        Label1.Text = LectorExcel.DameValorCelda(
            TextBox1.Text,
            TextBox2.Text,
            TextBox3.Text,
            NumericUpDown1.Value)
    End Sub

    Private Sub Form_Excel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = "C:\Ejemplo_Caso_programacion_excel.xlsx"
        TextBox2.Text = "Datos"
        TextBox3.Text = "E"
        TextBox4.Text = "C:\Users\sinensia100\Documents\Ejemplo_1.xlsx"
        NumericUpDown1.Value = 4
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EscritorExcel.NuevoExcelFijo(TextBox4.Text)
    End Sub
End Class