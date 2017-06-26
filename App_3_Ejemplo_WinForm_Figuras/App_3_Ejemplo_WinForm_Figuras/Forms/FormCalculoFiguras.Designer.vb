<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculoFiguras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCirculo = New System.Windows.Forms.RadioButton()
        Me.radRectangulo = New System.Windows.Forms.RadioButton()
        Me.grupoRectangulo = New System.Windows.Forms.GroupBox()
        Me.numAlto = New System.Windows.Forms.NumericUpDown()
        Me.numAncho = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numPerimetro = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numArea = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grupoCirculo = New System.Windows.Forms.GroupBox()
        Me.numRadio = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grupoResultado = New System.Windows.Forms.GroupBox()
        Me.tabCalculoFiguras = New System.Windows.Forms.TabControl()
        Me.PestañaRectangulo = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numAlto2 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numResultadoRectangulo = New System.Windows.Forms.NumericUpDown()
        Me.numAncho2 = New System.Windows.Forms.NumericUpDown()
        Me.cbxTipoCalculoRectangulo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PestañaCirculo = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numResultadoCirculo = New System.Windows.Forms.NumericUpDown()
        Me.numRadio2 = New System.Windows.Forms.NumericUpDown()
        Me.cbxTipoCalculoCirculo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grupoRectangulo.SuspendLayout()
        CType(Me.numAlto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAncho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPerimetro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoCirculo.SuspendLayout()
        CType(Me.numRadio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoResultado.SuspendLayout()
        Me.tabCalculoFiguras.SuspendLayout()
        Me.PestañaRectangulo.SuspendLayout()
        CType(Me.numAlto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numResultadoRectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAncho2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PestañaCirculo.SuspendLayout()
        CType(Me.numResultadoCirculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRadio2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCirculo)
        Me.GroupBox1.Controls.Add(Me.radRectangulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una figura"
        '
        'radCirculo
        '
        Me.radCirculo.AutoSize = True
        Me.radCirculo.Location = New System.Drawing.Point(7, 57)
        Me.radCirculo.Name = "radCirculo"
        Me.radCirculo.Size = New System.Drawing.Size(83, 24)
        Me.radCirculo.TabIndex = 2
        Me.radCirculo.TabStop = True
        Me.radCirculo.Text = "Circulos"
        Me.radCirculo.UseVisualStyleBackColor = True
        '
        'radRectangulo
        '
        Me.radRectangulo.AutoSize = True
        Me.radRectangulo.Checked = True
        Me.radRectangulo.Location = New System.Drawing.Point(7, 26)
        Me.radRectangulo.Name = "radRectangulo"
        Me.radRectangulo.Size = New System.Drawing.Size(117, 24)
        Me.radRectangulo.TabIndex = 1
        Me.radRectangulo.TabStop = True
        Me.radRectangulo.Text = "Rectangulos"
        Me.radRectangulo.UseVisualStyleBackColor = True
        '
        'grupoRectangulo
        '
        Me.grupoRectangulo.Controls.Add(Me.numAlto)
        Me.grupoRectangulo.Controls.Add(Me.numAncho)
        Me.grupoRectangulo.Controls.Add(Me.Label2)
        Me.grupoRectangulo.Controls.Add(Me.Label1)
        Me.grupoRectangulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoRectangulo.Location = New System.Drawing.Point(12, 128)
        Me.grupoRectangulo.Name = "grupoRectangulo"
        Me.grupoRectangulo.Size = New System.Drawing.Size(271, 103)
        Me.grupoRectangulo.TabIndex = 1
        Me.grupoRectangulo.TabStop = False
        Me.grupoRectangulo.Text = "Rectangulo:"
        '
        'numAlto
        '
        Me.numAlto.DecimalPlaces = 2
        Me.numAlto.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numAlto.Location = New System.Drawing.Point(134, 64)
        Me.numAlto.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numAlto.Name = "numAlto"
        Me.numAlto.Size = New System.Drawing.Size(120, 26)
        Me.numAlto.TabIndex = 5
        '
        'numAncho
        '
        Me.numAncho.DecimalPlaces = 2
        Me.numAncho.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numAncho.Location = New System.Drawing.Point(134, 29)
        Me.numAncho.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numAncho.Name = "numAncho"
        Me.numAncho.Size = New System.Drawing.Size(120, 26)
        Me.numAncho.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ancho:"
        '
        'numPerimetro
        '
        Me.numPerimetro.DecimalPlaces = 2
        Me.numPerimetro.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numPerimetro.Location = New System.Drawing.Point(133, 59)
        Me.numPerimetro.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numPerimetro.Name = "numPerimetro"
        Me.numPerimetro.ReadOnly = True
        Me.numPerimetro.Size = New System.Drawing.Size(120, 26)
        Me.numPerimetro.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Perímetro"
        '
        'numArea
        '
        Me.numArea.DecimalPlaces = 2
        Me.numArea.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numArea.Location = New System.Drawing.Point(133, 25)
        Me.numArea.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numArea.Name = "numArea"
        Me.numArea.ReadOnly = True
        Me.numArea.Size = New System.Drawing.Size(120, 26)
        Me.numArea.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Area:"
        '
        'grupoCirculo
        '
        Me.grupoCirculo.Controls.Add(Me.numRadio)
        Me.grupoCirculo.Controls.Add(Me.Label8)
        Me.grupoCirculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoCirculo.Location = New System.Drawing.Point(12, 124)
        Me.grupoCirculo.Name = "grupoCirculo"
        Me.grupoCirculo.Size = New System.Drawing.Size(271, 107)
        Me.grupoCirculo.TabIndex = 3
        Me.grupoCirculo.TabStop = False
        Me.grupoCirculo.Text = "Circulo:"
        Me.grupoCirculo.Visible = False
        '
        'numRadio
        '
        Me.numRadio.DecimalPlaces = 2
        Me.numRadio.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRadio.Location = New System.Drawing.Point(134, 29)
        Me.numRadio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numRadio.Name = "numRadio"
        Me.numRadio.Size = New System.Drawing.Size(120, 26)
        Me.numRadio.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Radio:"
        '
        'grupoResultado
        '
        Me.grupoResultado.Controls.Add(Me.numArea)
        Me.grupoResultado.Controls.Add(Me.Label3)
        Me.grupoResultado.Controls.Add(Me.numPerimetro)
        Me.grupoResultado.Controls.Add(Me.Label4)
        Me.grupoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoResultado.Location = New System.Drawing.Point(13, 238)
        Me.grupoResultado.Name = "grupoResultado"
        Me.grupoResultado.Size = New System.Drawing.Size(270, 94)
        Me.grupoResultado.TabIndex = 14
        Me.grupoResultado.TabStop = False
        Me.grupoResultado.Text = "Resultados"
        '
        'tabCalculoFiguras
        '
        Me.tabCalculoFiguras.Controls.Add(Me.PestañaRectangulo)
        Me.tabCalculoFiguras.Controls.Add(Me.PestañaCirculo)
        Me.tabCalculoFiguras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCalculoFiguras.Location = New System.Drawing.Point(309, 13)
        Me.tabCalculoFiguras.Name = "tabCalculoFiguras"
        Me.tabCalculoFiguras.SelectedIndex = 0
        Me.tabCalculoFiguras.Size = New System.Drawing.Size(337, 190)
        Me.tabCalculoFiguras.TabIndex = 5
        '
        'PestañaRectangulo
        '
        Me.PestañaRectangulo.Controls.Add(Me.Label10)
        Me.PestañaRectangulo.Controls.Add(Me.Label9)
        Me.PestañaRectangulo.Controls.Add(Me.numAlto2)
        Me.PestañaRectangulo.Controls.Add(Me.Label7)
        Me.PestañaRectangulo.Controls.Add(Me.numResultadoRectangulo)
        Me.PestañaRectangulo.Controls.Add(Me.numAncho2)
        Me.PestañaRectangulo.Controls.Add(Me.cbxTipoCalculoRectangulo)
        Me.PestañaRectangulo.Controls.Add(Me.Label6)
        Me.PestañaRectangulo.Location = New System.Drawing.Point(4, 29)
        Me.PestañaRectangulo.Name = "PestañaRectangulo"
        Me.PestañaRectangulo.Padding = New System.Windows.Forms.Padding(3)
        Me.PestañaRectangulo.Size = New System.Drawing.Size(329, 157)
        Me.PestañaRectangulo.TabIndex = 3
        Me.PestañaRectangulo.Text = "Rectangulo"
        Me.PestañaRectangulo.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Resultado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Tipo calculo:"
        '
        'numAlto2
        '
        Me.numAlto2.DecimalPlaces = 2
        Me.numAlto2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numAlto2.Location = New System.Drawing.Point(113, 47)
        Me.numAlto2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numAlto2.Name = "numAlto2"
        Me.numAlto2.Size = New System.Drawing.Size(200, 26)
        Me.numAlto2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Alto:"
        '
        'numResultadoRectangulo
        '
        Me.numResultadoRectangulo.DecimalPlaces = 2
        Me.numResultadoRectangulo.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numResultadoRectangulo.Location = New System.Drawing.Point(112, 117)
        Me.numResultadoRectangulo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numResultadoRectangulo.Name = "numResultadoRectangulo"
        Me.numResultadoRectangulo.ReadOnly = True
        Me.numResultadoRectangulo.Size = New System.Drawing.Size(201, 26)
        Me.numResultadoRectangulo.TabIndex = 29
        '
        'numAncho2
        '
        Me.numAncho2.DecimalPlaces = 2
        Me.numAncho2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numAncho2.Location = New System.Drawing.Point(113, 11)
        Me.numAncho2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numAncho2.Name = "numAncho2"
        Me.numAncho2.Size = New System.Drawing.Size(200, 26)
        Me.numAncho2.TabIndex = 6
        '
        'cbxTipoCalculoRectangulo
        '
        Me.cbxTipoCalculoRectangulo.FormattingEnabled = True
        Me.cbxTipoCalculoRectangulo.Items.AddRange(New Object() {"Calcular Area", "Calcular Perimetro"})
        Me.cbxTipoCalculoRectangulo.Location = New System.Drawing.Point(112, 82)
        Me.cbxTipoCalculoRectangulo.Name = "cbxTipoCalculoRectangulo"
        Me.cbxTipoCalculoRectangulo.Size = New System.Drawing.Size(201, 28)
        Me.cbxTipoCalculoRectangulo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Ancho:"
        '
        'PestañaCirculo
        '
        Me.PestañaCirculo.Controls.Add(Me.Label11)
        Me.PestañaCirculo.Controls.Add(Me.Label12)
        Me.PestañaCirculo.Controls.Add(Me.numResultadoCirculo)
        Me.PestañaCirculo.Controls.Add(Me.numRadio2)
        Me.PestañaCirculo.Controls.Add(Me.cbxTipoCalculoCirculo)
        Me.PestañaCirculo.Controls.Add(Me.Label5)
        Me.PestañaCirculo.Location = New System.Drawing.Point(4, 29)
        Me.PestañaCirculo.Name = "PestañaCirculo"
        Me.PestañaCirculo.Size = New System.Drawing.Size(329, 157)
        Me.PestañaCirculo.TabIndex = 4
        Me.PestañaCirculo.Text = "Circulo"
        Me.PestañaCirculo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Resultado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Tipo calculo:"
        '
        'numResultadoCirculo
        '
        Me.numResultadoCirculo.DecimalPlaces = 2
        Me.numResultadoCirculo.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numResultadoCirculo.Location = New System.Drawing.Point(111, 97)
        Me.numResultadoCirculo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numResultadoCirculo.Name = "numResultadoCirculo"
        Me.numResultadoCirculo.ReadOnly = True
        Me.numResultadoCirculo.Size = New System.Drawing.Size(201, 26)
        Me.numResultadoCirculo.TabIndex = 25
        '
        'numRadio2
        '
        Me.numRadio2.DecimalPlaces = 2
        Me.numRadio2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numRadio2.Location = New System.Drawing.Point(112, 14)
        Me.numRadio2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numRadio2.Name = "numRadio2"
        Me.numRadio2.Size = New System.Drawing.Size(200, 26)
        Me.numRadio2.TabIndex = 9
        '
        'cbxTipoCalculoCirculo
        '
        Me.cbxTipoCalculoCirculo.FormattingEnabled = True
        Me.cbxTipoCalculoCirculo.Items.AddRange(New Object() {"Calcular Area", "Calcular Perimetro"})
        Me.cbxTipoCalculoCirculo.Location = New System.Drawing.Point(111, 55)
        Me.cbxTipoCalculoCirculo.Name = "cbxTipoCalculoCirculo"
        Me.cbxTipoCalculoCirculo.Size = New System.Drawing.Size(201, 28)
        Me.cbxTipoCalculoCirculo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Radio"
        '
        'FormCalculoFiguras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 343)
        Me.Controls.Add(Me.tabCalculoFiguras)
        Me.Controls.Add(Me.grupoResultado)
        Me.Controls.Add(Me.grupoCirculo)
        Me.Controls.Add(Me.grupoRectangulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCalculoFiguras"
        Me.Text = "Calculo de areas y perimetros figuras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grupoRectangulo.ResumeLayout(False)
        Me.grupoRectangulo.PerformLayout()
        CType(Me.numAlto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAncho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPerimetro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoCirculo.ResumeLayout(False)
        Me.grupoCirculo.PerformLayout()
        CType(Me.numRadio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoResultado.ResumeLayout(False)
        Me.grupoResultado.PerformLayout()
        Me.tabCalculoFiguras.ResumeLayout(False)
        Me.PestañaRectangulo.ResumeLayout(False)
        Me.PestañaRectangulo.PerformLayout()
        CType(Me.numAlto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numResultadoRectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAncho2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PestañaCirculo.ResumeLayout(False)
        Me.PestañaCirculo.PerformLayout()
        CType(Me.numResultadoCirculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRadio2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radCirculo As RadioButton
    Friend WithEvents radRectangulo As RadioButton
    Friend WithEvents grupoRectangulo As GroupBox
    Friend WithEvents numAlto As NumericUpDown
    Friend WithEvents numAncho As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numPerimetro As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numArea As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents grupoCirculo As GroupBox
    Friend WithEvents numRadio As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents grupoResultado As GroupBox
    Friend WithEvents tabCalculoFiguras As TabControl
    Friend WithEvents PestañaRectangulo As TabPage
    Friend WithEvents PestañaCirculo As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents numAlto2 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents numResultadoRectangulo As NumericUpDown
    Friend WithEvents numAncho2 As NumericUpDown
    Friend WithEvents cbxTipoCalculoRectangulo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents numResultadoCirculo As NumericUpDown
    Friend WithEvents numRadio2 As NumericUpDown
    Friend WithEvents cbxTipoCalculoCirculo As ComboBox
    Friend WithEvents Label5 As Label
End Class
