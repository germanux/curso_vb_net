<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Lista
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
        Me.SuspendLayout()
        '
        'lstListaEmpleados
        '
        Me.lstListaEmpleados.FormattingEnabled = True
        Me.lstListaEmpleados.ItemHeight = 20
        Me.lstListaEmpleados.Location = New System.Drawing.Point(43, 204)
        Me.lstListaEmpleados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstListaEmpleados.Name = "lstListaEmpleados"
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
        'Form_Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 406)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNombre)
        Me.Controls.Add(Me.lstListaEmpleados)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Lista"
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
End Class
