<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnDividir = New System.Windows.Forms.Button()
        Me.BtnMultiplicar = New System.Windows.Forms.Button()
        Me.BtnRestar = New System.Windows.Forms.Button()
        Me.BtnSumar = New System.Windows.Forms.Button()
        Me.BtnResultado = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBorrar.Location = New System.Drawing.Point(62, 234)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(258, 64)
        Me.BtnBorrar.TabIndex = 0
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnDividir
        '
        Me.BtnDividir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDividir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnDividir.Location = New System.Drawing.Point(385, 234)
        Me.BtnDividir.Name = "BtnDividir"
        Me.BtnDividir.Size = New System.Drawing.Size(75, 64)
        Me.BtnDividir.TabIndex = 1
        Me.BtnDividir.Text = "/"
        Me.BtnDividir.UseVisualStyleBackColor = False
        '
        'BtnMultiplicar
        '
        Me.BtnMultiplicar.Location = New System.Drawing.Point(385, 321)
        Me.BtnMultiplicar.Name = "BtnMultiplicar"
        Me.BtnMultiplicar.Size = New System.Drawing.Size(75, 64)
        Me.BtnMultiplicar.TabIndex = 2
        Me.BtnMultiplicar.Text = "X"
        Me.BtnMultiplicar.UseVisualStyleBackColor = True
        '
        'BtnRestar
        '
        Me.BtnRestar.Location = New System.Drawing.Point(385, 409)
        Me.BtnRestar.Name = "BtnRestar"
        Me.BtnRestar.Size = New System.Drawing.Size(75, 64)
        Me.BtnRestar.TabIndex = 3
        Me.BtnRestar.Text = "-"
        Me.BtnRestar.UseVisualStyleBackColor = True
        '
        'BtnSumar
        '
        Me.BtnSumar.Location = New System.Drawing.Point(385, 501)
        Me.BtnSumar.Name = "BtnSumar"
        Me.BtnSumar.Size = New System.Drawing.Size(75, 64)
        Me.BtnSumar.TabIndex = 4
        Me.BtnSumar.Text = "+"
        Me.BtnSumar.UseVisualStyleBackColor = True
        '
        'BtnResultado
        '
        Me.BtnResultado.Location = New System.Drawing.Point(274, 599)
        Me.BtnResultado.Name = "BtnResultado"
        Me.BtnResultado.Size = New System.Drawing.Size(186, 64)
        Me.BtnResultado.TabIndex = 5
        Me.BtnResultado.Text = "="
        Me.BtnResultado.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(110, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 118)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Btn7
        '
        Me.Btn7.Location = New System.Drawing.Point(62, 321)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(75, 64)
        Me.Btn7.TabIndex = 7
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Location = New System.Drawing.Point(173, 321)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(75, 64)
        Me.Btn8.TabIndex = 8
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Location = New System.Drawing.Point(285, 321)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(75, 64)
        Me.Btn9.TabIndex = 9
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(62, 409)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 64)
        Me.Btn4.TabIndex = 10
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(173, 409)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(75, 64)
        Me.Btn5.TabIndex = 11
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Location = New System.Drawing.Point(285, 409)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(75, 64)
        Me.Btn6.TabIndex = 12
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(62, 501)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 64)
        Me.Btn1.TabIndex = 13
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(173, 501)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 64)
        Me.Btn2.TabIndex = 14
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(285, 501)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 64)
        Me.Btn3.TabIndex = 15
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Location = New System.Drawing.Point(62, 599)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(175, 64)
        Me.Btn0.TabIndex = 16
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(74, 166)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(369, 51)
        Me.txtDisplay.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(531, 703)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnResultado)
        Me.Controls.Add(Me.BtnSumar)
        Me.Controls.Add(Me.BtnRestar)
        Me.Controls.Add(Me.BtnMultiplicar)
        Me.Controls.Add(Me.BtnDividir)
        Me.Controls.Add(Me.BtnBorrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "EVA1_FranciscoVillar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnDividir As Button
    Friend WithEvents BtnMultiplicar As Button
    Friend WithEvents BtnRestar As Button
    Friend WithEvents BtnSumar As Button
    Friend WithEvents BtnResultado As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents txtDisplay As TextBox
End Class
