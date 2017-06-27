<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.txtMultilinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiezCaracteres = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLongitudes = New System.Windows.Forms.Label()
        Me.lstListaDatos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnEliminarDeLista = New System.Windows.Forms.Button()
        Me.btnAbrirForm = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMultilinea
        '
        Me.txtMultilinea.Location = New System.Drawing.Point(18, 45)
        Me.txtMultilinea.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMultilinea.Multiline = True
        Me.txtMultilinea.Name = "txtMultilinea"
        Me.txtMultilinea.Size = New System.Drawing.Size(314, 121)
        Me.txtMultilinea.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TextoMultilinea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Texto con longiud maxima de 10 caracteres"
        '
        'txtDiezCaracteres
        '
        Me.txtDiezCaracteres.Location = New System.Drawing.Point(18, 207)
        Me.txtDiezCaracteres.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiezCaracteres.MaxLength = 10
        Me.txtDiezCaracteres.Name = "txtDiezCaracteres"
        Me.txtDiezCaracteres.Size = New System.Drawing.Size(314, 26)
        Me.txtDiezCaracteres.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 243)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Mostrar longitud"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Longitudes:"
        '
        'lblLongitudes
        '
        Me.lblLongitudes.AutoSize = True
        Me.lblLongitudes.Location = New System.Drawing.Point(22, 319)
        Me.lblLongitudes.Name = "lblLongitudes"
        Me.lblLongitudes.Size = New System.Drawing.Size(88, 20)
        Me.lblLongitudes.TabIndex = 6
        Me.lblLongitudes.Text = "Longitudes"
        '
        'lstListaDatos
        '
        Me.lstListaDatos.FormattingEnabled = True
        Me.lstListaDatos.ItemHeight = 20
        Me.lstListaDatos.Items.AddRange(New Object() {"Perro", "Gato", "Murciégalo", "Ratón"})
        Me.lstListaDatos.Location = New System.Drawing.Point(417, 45)
        Me.lstListaDatos.Name = "lstListaDatos"
        Me.lstListaDatos.Size = New System.Drawing.Size(245, 184)
        Me.lstListaDatos.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lista de datos:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(339, 45)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 31)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAdd2
        '
        Me.btnAdd2.Location = New System.Drawing.Point(339, 202)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(71, 31)
        Me.btnAdd2.TabIndex = 10
        Me.btnAdd2.Text = "Añadir"
        Me.btnAdd2.UseVisualStyleBackColor = True
        '
        'btnEliminarDeLista
        '
        Me.btnEliminarDeLista.Enabled = False
        Me.btnEliminarDeLista.Location = New System.Drawing.Point(587, 236)
        Me.btnEliminarDeLista.Name = "btnEliminarDeLista"
        Me.btnEliminarDeLista.Size = New System.Drawing.Size(75, 42)
        Me.btnEliminarDeLista.TabIndex = 11
        Me.btnEliminarDeLista.Text = "Eliminar"
        Me.btnEliminarDeLista.UseVisualStyleBackColor = True
        '
        'btnAbrirForm
        '
        Me.btnAbrirForm.Location = New System.Drawing.Point(417, 319)
        Me.btnAbrirForm.Name = "btnAbrirForm"
        Me.btnAbrirForm.Size = New System.Drawing.Size(196, 37)
        Me.btnAbrirForm.TabIndex = 12
        Me.btnAbrirForm.Text = "Abrir Form Combo Listas"
        Me.btnAbrirForm.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(621, 319)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(41, 37)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 359)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAbrirForm)
        Me.Controls.Add(Me.btnEliminarDeLista)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstListaDatos)
        Me.Controls.Add(Me.lblLongitudes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDiezCaracteres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMultilinea)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMultilinea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiezCaracteres As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLongitudes As Label
    Friend WithEvents lstListaDatos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents btnEliminarDeLista As Button
    Friend WithEvents btnAbrirForm As Button
    Friend WithEvents btnCerrar As Button
End Class
