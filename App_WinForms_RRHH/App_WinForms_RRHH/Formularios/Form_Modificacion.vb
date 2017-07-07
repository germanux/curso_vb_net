Imports App_WinForms_RRHH.Modelo

Public Class Form_Modificacion
    Private _empleado, _empleadoModif As Empleado

    Public Property Empleado As Empleado
        Get
            Return _empleado
        End Get
        Set(value As Empleado)
            _empleado = value
        End Set
    End Property
    Public Property EmpleadoModif As Empleado
        Get
            Return _empleadoModif
        End Get
        Set(value As Empleado)
            _empleadoModif = value
        End Set
    End Property
    Private Sub Form_Modificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = Empleado.nombre
        txtApellidos.Text = Empleado.apellidos
        cmbGenero.SelectedIndex = Empleado.genero - 1
        domCategoria.SelectedIndex = Empleado.categoria - 1
        numRetribucion.Value = CType(Empleado.retribucionFija, Decimal)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre.Text = "" Then
            MessageBox.Show("Introduzca un nombre")
            Return
        End If
        Try
            _empleadoModif = New Empleado()
            ' Asignamos valores
            _empleadoModif.nombre = txtNombre.Text
            _empleadoModif.apellidos = txtApellidos.Text
            _empleadoModif.genero = CType(cmbGenero.SelectedIndex + 1, TipoGenero)
            _empleadoModif.categoria = CType(domCategoria.SelectedIndex + 1, TipoCategoria)
            _empleadoModif.retribucionFija = numRetribucion.Value

            EmpleadosCRUD.Actualizar(Empleado, EmpleadoModif)

            Me.Close()
            MessageBox.Show("Empleado modificado: " & Empleado.ToString())
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
        Me.MdiParent.Text = "Modificacion empleado"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate

        Me.MdiParent.Text = "Aplicación empleados"
    End Sub
End Class