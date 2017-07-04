<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_baja
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
        Me.btnDarDeBaja = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lstEmpleados = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarDeBaja.ForeColor = System.Drawing.Color.Red
        Me.btnDarDeBaja.Location = New System.Drawing.Point(215, 181)
        Me.btnDarDeBaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Size = New System.Drawing.Size(112, 35)
        Me.btnDarDeBaja.TabIndex = 1
        Me.btnDarDeBaja.Text = "Dar de Baja"
        Me.btnDarDeBaja.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(23, 179)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(121, 33)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lstEmpleados
        '
        Me.lstEmpleados.FormattingEnabled = True
        Me.lstEmpleados.ItemHeight = 20
        Me.lstEmpleados.Location = New System.Drawing.Point(23, 49)
        Me.lstEmpleados.Name = "lstEmpleados"
        Me.lstEmpleados.Size = New System.Drawing.Size(304, 124)
        Me.lstEmpleados.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Empleados a dar de baja:"
        '
        'Form_baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 248)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEmpleados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnDarDeBaja)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_baja"
        Me.Text = "Baja de empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDarDeBaja As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lstEmpleados As ListBox
    Friend WithEvents Label1 As Label
End Class
