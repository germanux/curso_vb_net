Imports App_WinForms_RRHH.Modelo

Public Class Form_Alta
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' TODO: Impedir duplicados
        ' TODO: Hacer las validaciones
        ' TOPO: Formulario por encima TopMost
        ' TODO: Métodos         CenterToScreen()        y        CenterToParent()
        ' TODO: Propiedades       ControlBox aximizeBox MinimizeBox, HelpButton, Propiedad         FormBorderStyle        .

        If txtNombre.Text = "" Then
            MessageBox.Show("Introduzca un nombre")
            Return
        End If
        Try
            Dim nuevoEmpleado As Empleado = New Empleado()

            ' Asignamos valores
            nuevoEmpleado.nombre = txtNombre.Text
            nuevoEmpleado.apellidos = txtApellidos.Text
            nuevoEmpleado.genero = CType(cmbGenero.SelectedIndex + 1, TipoGenero)
            nuevoEmpleado.categoria = CType(domCategoria.SelectedIndex + 1, TipoCategoria)
            nuevoEmpleado.retribucionFija = numRetribucion.Value

            CType(Me.MdiParent, MDI_Principal).empleadosCRUD.Crear(nuevoEmpleado)

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

    Public Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated
        Me.MdiParent.Text = "Alta empleado"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate

        Me.MdiParent.Text = "Aplicación empleados"
    End Sub

End Class