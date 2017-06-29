<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComboListas
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
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbTextos = New System.Windows.Forms.ComboBox()
        Me.btnPasar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.chkListTextos = New System.Windows.Forms.CheckedListBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(20, 51)
        Me.txtTexto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(320, 26)
        Me.txtTexto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Texto a añadir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(230, 91)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 35)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbTextos
        '
        Me.cmbTextos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTextos.FormattingEnabled = True
        Me.cmbTextos.Location = New System.Drawing.Point(20, 142)
        Me.cmbTextos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTextos.Name = "cmbTextos"
        Me.cmbTextos.Size = New System.Drawing.Size(320, 28)
        Me.cmbTextos.TabIndex = 2
        '
        'btnPasar
        '
        Me.btnPasar.Location = New System.Drawing.Point(363, 142)
        Me.btnPasar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPasar.Name = "btnPasar"
        Me.btnPasar.Size = New System.Drawing.Size(112, 35)
        Me.btnPasar.TabIndex = 3
        Me.btnPasar.Text = "Pasar"
        Me.btnPasar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(363, 188)
        Me.btnQuitar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(112, 35)
        Me.btnQuitar.TabIndex = 4
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'chkListTextos
        '
        Me.chkListTextos.FormattingEnabled = True
        Me.chkListTextos.Location = New System.Drawing.Point(482, 51)
        Me.chkListTextos.Name = "chkListTextos"
        Me.chkListTextos.Size = New System.Drawing.Size(224, 172)
        Me.chkListTextos.TabIndex = 5
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 2
        Me.TrackBar1.Location = New System.Drawing.Point(712, 51)
        Me.TrackBar1.Maximum = 8
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 172)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.TickFrequency = 2
        Me.TrackBar1.Value = 2
        '
        'FormComboListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 253)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.chkListTextos)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnPasar)
        Me.Controls.Add(Me.cmbTextos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTexto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormComboListas"
        Me.Text = "FormComboListas"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTexto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbTextos As ComboBox
    Private WithEvents btnPasar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents chkListTextos As CheckedListBox
    Friend WithEvents TrackBar1 As TrackBar
End Class
