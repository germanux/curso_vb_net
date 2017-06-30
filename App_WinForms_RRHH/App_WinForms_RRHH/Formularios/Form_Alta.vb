Imports App_WinForms_RRHH.Modelo

Public Class Form_Alta
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' TODO: Impedir duplicados
        ' TODO: Hacer las validaciones
        If txtNombre.Text = "" Then
            MessageBox.Show("Introduzca un nombre")
            Return
        End If
        Try
            Dim nuevoEmpleado As Empleado = New Empleado()

            ' Asignamos valores
            nuevoEmpleado.nombre = txtNombre.Text
            nuevoEmpleado.apellidos = txtApellidos.Text
            nuevoEmpleado.genero = cmbGenero.SelectedIndex + 1
            nuevoEmpleado.categoria = domCategoria.SelectedIndex + 1
            nuevoEmpleado.retribucionFija = numRetribucion.Value

            EmpleadosCRUD.Crear(nuevoEmpleado)

            Me.Close()
            MessageBox.Show("Empleado creado: " & nuevoEmpleado.ToString())
        Catch ex As Exception
            MessageBox.Show("Error al guardar")
        End Try
    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) _
        Handles txtNombre.TextChanged, txtApellidos.TextChanged,
        cmbGenero.SelectedValueChanged, domCategoria.SelectedItemChanged,
        numRetribucion.ValueChanged

        btnGuardar.Enabled = txtNombre.Text <> "" _
            And txtApellidos.Text <> "" _
            And cmbGenero.SelectedIndex >= 0 _
            And domCategoria.SelectedIndex >= 0 _
            And numRetribucion.Value > 0

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtApellidos.Clear()
        txtNombre.Clear()
        cmbGenero.SelectedIndex = -1
        domCategoria.Text = ""
        domCategoria.SelectedIndex = -1
        numRetribucion.Value = 0
    End Sub

End Class