<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Busqueda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstListaEmpleados = New System.Windows.Forms.ListBox()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbApellidos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnModificacion = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstListaEmpleados
        '
        Me.lstListaEmpleados.FormattingEnabled = True
        Me.lstListaEmpleados.ItemHeight = 20
        Me.lstListaEmpleados.Location = New System.Drawing.Point(43, 204)
        Me.lstListaEmpleados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstListaEmpleados.Name = "lstListaEmpleados"
        Me.lstListaEmpleados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstListaEmpleados.Size = New System.Drawing.Size(357, 184)
        Me.lstListaEmpleados.TabIndex = 0
        '
        'cmbNombre
        '
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(175, 62)
        Me.cmbNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(225, 28)
        Me.cmbNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Introduzca el empleado a buscar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos:"
        '
        'cmbApellidos
        '
        Me.cmbApellidos.FormattingEnabled = True
        Me.cmbApellidos.Location = New System.Drawing.Point(175, 102)
        Me.cmbApellidos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbApellidos.Name = "cmbApellidos"
        Me.cmbApellidos.Size = New System.Drawing.Size(225, 28)
        Me.cmbApellidos.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Empleados encontrados:"
        '
        'btnBaja
        '
        Me.btnBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.ForeColor = System.Drawing.Color.Red
        Me.btnBaja.Location = New System.Drawing.Point(259, 396)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(70, 39)
        Me.btnBaja.TabIndex = 7
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(43, 396)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(93, 39)
        Me.btnAlta.TabIndex = 8
        Me.btnAlta.Text = "Alta..."
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnModificacion
        '
        Me.btnModificacion.Location = New System.Drawing.Point(142, 397)
        Me.btnModificacion.Name = "btnModificacion"
        Me.btnModificacion.Size = New System.Drawing.Size(100, 37)
        Me.btnModificacion.TabIndex = 9
        Me.btnModificacion.Text = "Modificar..."
        Me.btnModificacion.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(335, 397)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(65, 38)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form_Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 445)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnModificacion)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNombre)
        Me.Controls.Add(Me.lstListaEmpleados)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Busqueda"
        Me.Text = "Listar empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstListaEmpleados As ListBox
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbApellidos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnModificacion As Button
    Friend WithEvents btnCerrar As Button
End Class
