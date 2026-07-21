<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_opcion1 = New System.Windows.Forms.TextBox()
        Me.txt_opcion2 = New System.Windows.Forms.TextBox()
        Me.txt_opcion3 = New System.Windows.Forms.TextBox()
        Me.txt_opcion4 = New System.Windows.Forms.TextBox()
        Me.rnd_button1 = New System.Windows.Forms.RadioButton()
        Me.rnd_button2 = New System.Windows.Forms.RadioButton()
        Me.rnd_button3 = New System.Windows.Forms.RadioButton()
        Me.rnd_button4 = New System.Windows.Forms.RadioButton()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.txt_pregunta = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la pregunta deseada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese las opciones (marque la correcta):"
        '
        'txt_opcion1
        '
        Me.txt_opcion1.Location = New System.Drawing.Point(168, 220)
        Me.txt_opcion1.Name = "txt_opcion1"
        Me.txt_opcion1.Size = New System.Drawing.Size(173, 20)
        Me.txt_opcion1.TabIndex = 3
        '
        'txt_opcion2
        '
        Me.txt_opcion2.Location = New System.Drawing.Point(168, 262)
        Me.txt_opcion2.Name = "txt_opcion2"
        Me.txt_opcion2.Size = New System.Drawing.Size(173, 20)
        Me.txt_opcion2.TabIndex = 4
        '
        'txt_opcion3
        '
        Me.txt_opcion3.Location = New System.Drawing.Point(168, 304)
        Me.txt_opcion3.Name = "txt_opcion3"
        Me.txt_opcion3.Size = New System.Drawing.Size(173, 20)
        Me.txt_opcion3.TabIndex = 5
        '
        'txt_opcion4
        '
        Me.txt_opcion4.Location = New System.Drawing.Point(168, 347)
        Me.txt_opcion4.Name = "txt_opcion4"
        Me.txt_opcion4.Size = New System.Drawing.Size(173, 20)
        Me.txt_opcion4.TabIndex = 6
        '
        'rnd_button1
        '
        Me.rnd_button1.AutoSize = True
        Me.rnd_button1.BackColor = System.Drawing.Color.Transparent
        Me.rnd_button1.Location = New System.Drawing.Point(371, 223)
        Me.rnd_button1.Name = "rnd_button1"
        Me.rnd_button1.Size = New System.Drawing.Size(14, 13)
        Me.rnd_button1.TabIndex = 7
        Me.rnd_button1.TabStop = True
        Me.rnd_button1.UseVisualStyleBackColor = False
        '
        'rnd_button2
        '
        Me.rnd_button2.AutoSize = True
        Me.rnd_button2.BackColor = System.Drawing.Color.Transparent
        Me.rnd_button2.Location = New System.Drawing.Point(371, 263)
        Me.rnd_button2.Name = "rnd_button2"
        Me.rnd_button2.Size = New System.Drawing.Size(14, 13)
        Me.rnd_button2.TabIndex = 8
        Me.rnd_button2.TabStop = True
        Me.rnd_button2.UseVisualStyleBackColor = False
        '
        'rnd_button3
        '
        Me.rnd_button3.AutoSize = True
        Me.rnd_button3.BackColor = System.Drawing.Color.Transparent
        Me.rnd_button3.Location = New System.Drawing.Point(371, 304)
        Me.rnd_button3.Name = "rnd_button3"
        Me.rnd_button3.Size = New System.Drawing.Size(14, 13)
        Me.rnd_button3.TabIndex = 9
        Me.rnd_button3.TabStop = True
        Me.rnd_button3.UseVisualStyleBackColor = False
        '
        'rnd_button4
        '
        Me.rnd_button4.AutoSize = True
        Me.rnd_button4.BackColor = System.Drawing.Color.Transparent
        Me.rnd_button4.Location = New System.Drawing.Point(371, 348)
        Me.rnd_button4.Name = "rnd_button4"
        Me.rnd_button4.Size = New System.Drawing.Size(14, 13)
        Me.rnd_button4.TabIndex = 10
        Me.rnd_button4.TabStop = True
        Me.rnd_button4.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(451, 224)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 58)
        Me.btn_guardar.TabIndex = 11
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(451, 311)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 56)
        Me.btn_volver.TabIndex = 12
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'txt_pregunta
        '
        Me.txt_pregunta.Location = New System.Drawing.Point(64, 53)
        Me.txt_pregunta.Name = "txt_pregunta"
        Me.txt_pregunta.Size = New System.Drawing.Size(462, 96)
        Me.txt_pregunta.TabIndex = 13
        Me.txt_pregunta.Text = "Por favor, recuerde que debe ser una pregunta que tenga como respuesta a una expr" & _
    "esion numerica, entera o decimal"
        '
        'frm_editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(587, 425)
        Me.Controls.Add(Me.txt_pregunta)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.rnd_button4)
        Me.Controls.Add(Me.rnd_button3)
        Me.Controls.Add(Me.rnd_button2)
        Me.Controls.Add(Me.rnd_button1)
        Me.Controls.Add(Me.txt_opcion4)
        Me.Controls.Add(Me.txt_opcion3)
        Me.Controls.Add(Me.txt_opcion2)
        Me.Controls.Add(Me.txt_opcion1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_editor"
        Me.Text = "Matemática TED"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_opcion1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_opcion2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_opcion3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_opcion4 As System.Windows.Forms.TextBox
    Friend WithEvents rnd_button1 As System.Windows.Forms.RadioButton
    Friend WithEvents rnd_button2 As System.Windows.Forms.RadioButton
    Friend WithEvents rnd_button3 As System.Windows.Forms.RadioButton
    Friend WithEvents rnd_button4 As System.Windows.Forms.RadioButton
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents txt_pregunta As System.Windows.Forms.RichTextBox
End Class
