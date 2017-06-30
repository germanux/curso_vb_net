Public Class FormEventosRaton

    Private nuevoBoton As Button
    Private listaBotones As List(Of Button)

    Private Sub FormEventosRaton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaBotones = New List(Of Button)()
    End Sub
    Private Sub PictureBox1_OnMouseDown(sender As Object, e As MouseEventArgs) _
        Handles PictureBox1.MouseDown
        nuevoBoton = New Button()
        nuevoBoton.Size = New Size(30, 30)
        nuevoBoton.Text = "X"
        nuevoBoton.Parent = Me
        nuevoBoton.Location = e.Location + PictureBox1.Location
        nuevoBoton.BringToFront()

        AddHandler PictureBox1.MouseMove, AddressOf PictureBox1_OnMouseMove
    End Sub
    Private Sub PictureBox1_OnMouseMove(sender As Object, e As MouseEventArgs) _
        ' Handles Me.MouseMove
        'If Not nuevoBoton Is Nothing Then
        nuevoBoton.Location = e.Location + PictureBox1.Location
        'End If
    End Sub
    Private Sub PictureBox1_OnMouseUp(sender As Object, e As MouseEventArgs) _
        Handles PictureBox1.MouseUp

        RemoveHandler PictureBox1.MouseMove, AddressOf PictureBox1_OnMouseMove
        'cambiar a negrita la fuente
        nuevoBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ' Añadirlo a una lista (List) de botones
        listaBotones.Add(nuevoBoton)
        ' Mostrar en una etiqueta el numero de botones creados
        lblNumBtn.Text = "Nº botones: " & listaBotones.Count

        'nuevoBoton = Nothing
    End Sub
    Private Sub PictureBox1_OnMouseLeave(sender As Object, e As EventArgs) _
        Handles PictureBox1.MouseLeave, PictureBox1.MouseEnter

        'MessageBox.Show("Entrando o saliendo")
    End Sub


End Class