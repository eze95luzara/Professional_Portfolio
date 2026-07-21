<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PreguntasDsf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PreguntasDsf))
        Me.Lbl_Pregunta = New System.Windows.Forms.Label()
        Me.lbl_Cuestionario = New System.Windows.Forms.Label()
        Me.lbl_Preguntas = New System.Windows.Forms.Label()
        Me.lbl_Preg = New System.Windows.Forms.Label()
        Me.mask_Pregunta = New System.Windows.Forms.MaskedTextBox()
        Me.Cmd_Opcion4 = New System.Windows.Forms.Button()
        Me.Cmd_Opcion3 = New System.Windows.Forms.Button()
        Me.Cmd_Opcion2 = New System.Windows.Forms.Button()
        Me.Cmd_Opcion1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbl_Cuest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Pregunta
        '
        Me.Lbl_Pregunta.AutoSize = True
        Me.Lbl_Pregunta.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Pregunta.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pregunta.Location = New System.Drawing.Point(196, 145)
        Me.Lbl_Pregunta.Name = "Lbl_Pregunta"
        Me.Lbl_Pregunta.Size = New System.Drawing.Size(146, 20)
        Me.Lbl_Pregunta.TabIndex = 23
        Me.Lbl_Pregunta.Text = "PREGUNTA AQUI"
        '
        'lbl_Cuestionario
        '
        Me.lbl_Cuestionario.AutoSize = True
        Me.lbl_Cuestionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cuestionario.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuestionario.Location = New System.Drawing.Point(12, 30)
        Me.lbl_Cuestionario.Name = "lbl_Cuestionario"
        Me.lbl_Cuestionario.Size = New System.Drawing.Size(122, 19)
        Me.lbl_Cuestionario.TabIndex = 20
        Me.lbl_Cuestionario.Text = "Cuestionario:"
        '
        'lbl_Preguntas
        '
        Me.lbl_Preguntas.AutoSize = True
        Me.lbl_Preguntas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Preguntas.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Preguntas.Location = New System.Drawing.Point(483, 30)
        Me.lbl_Preguntas.Name = "lbl_Preguntas"
        Me.lbl_Preguntas.Size = New System.Drawing.Size(91, 19)
        Me.lbl_Preguntas.TabIndex = 19
        Me.lbl_Preguntas.Text = "Pregunta:"
        '
        'lbl_Preg
        '
        Me.lbl_Preg.AutoSize = True
        Me.lbl_Preg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Preg.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Preg.Location = New System.Drawing.Point(614, 30)
        Me.lbl_Preg.Name = "lbl_Preg"
        Me.lbl_Preg.Size = New System.Drawing.Size(36, 19)
        Me.lbl_Preg.TabIndex = 17
        Me.lbl_Preg.Text = "/10"
        '
        'mask_Pregunta
        '
        Me.mask_Pregunta.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mask_Pregunta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mask_Pregunta.Location = New System.Drawing.Point(580, 27)
        Me.mask_Pregunta.Mask = "00"
        Me.mask_Pregunta.Name = "mask_Pregunta"
        Me.mask_Pregunta.Size = New System.Drawing.Size(28, 26)
        Me.mask_Pregunta.TabIndex = 16
        '
        'Cmd_Opcion4
        '
        Me.Cmd_Opcion4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion4.Location = New System.Drawing.Point(553, 249)
        Me.Cmd_Opcion4.Name = "Cmd_Opcion4"
        Me.Cmd_Opcion4.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion4.TabIndex = 15
        Me.Cmd_Opcion4.Text = "Button4"
        Me.Cmd_Opcion4.UseVisualStyleBackColor = True
        '
        'Cmd_Opcion3
        '
        Me.Cmd_Opcion3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion3.Location = New System.Drawing.Point(381, 249)
        Me.Cmd_Opcion3.Name = "Cmd_Opcion3"
        Me.Cmd_Opcion3.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion3.TabIndex = 14
        Me.Cmd_Opcion3.Text = "Button3"
        Me.Cmd_Opcion3.UseVisualStyleBackColor = True
        '
        'Cmd_Opcion2
        '
        Me.Cmd_Opcion2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion2.Location = New System.Drawing.Point(200, 249)
        Me.Cmd_Opcion2.Name = "Cmd_Opcion2"
        Me.Cmd_Opcion2.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion2.TabIndex = 13
        Me.Cmd_Opcion2.Text = "Button2"
        Me.Cmd_Opcion2.UseVisualStyleBackColor = True
        '
        'Cmd_Opcion1
        '
        Me.Cmd_Opcion1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion1.Location = New System.Drawing.Point(27, 249)
        Me.Cmd_Opcion1.Name = "Cmd_Opcion1"
        Me.Cmd_Opcion1.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion1.TabIndex = 12
        Me.Cmd_Opcion1.Text = "Button1"
        Me.Cmd_Opcion1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(292, 380)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 20)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Rendirse"
        '
        'lbl_Cuest
        '
        Me.lbl_Cuest.AutoSize = True
        Me.lbl_Cuest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cuest.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuest.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Cuest.Location = New System.Drawing.Point(140, 29)
        Me.lbl_Cuest.Name = "lbl_Cuest"
        Me.lbl_Cuest.Size = New System.Drawing.Size(91, 20)
        Me.lbl_Cuest.TabIndex = 25
        Me.lbl_Cuest.Text = "nomCuest"
        '
        'Frm_PreguntasDsf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(662, 409)
        Me.Controls.Add(Me.lbl_Cuest)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Lbl_Pregunta)
        Me.Controls.Add(Me.lbl_Cuestionario)
        Me.Controls.Add(Me.lbl_Preguntas)
        Me.Controls.Add(Me.lbl_Preg)
        Me.Controls.Add(Me.mask_Pregunta)
        Me.Controls.Add(Me.Cmd_Opcion4)
        Me.Controls.Add(Me.Cmd_Opcion3)
        Me.Controls.Add(Me.Cmd_Opcion2)
        Me.Controls.Add(Me.Cmd_Opcion1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_PreguntasDsf"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Pregunta As Label
    Friend WithEvents lbl_Cuestionario As Label
    Friend WithEvents lbl_Preguntas As Label
    Friend WithEvents lbl_Preg As Label
    Friend WithEvents mask_Pregunta As MaskedTextBox
    Friend WithEvents Cmd_Opcion4 As Button
    Friend WithEvents Cmd_Opcion3 As Button
    Friend WithEvents Cmd_Opcion2 As Button
    Friend WithEvents Cmd_Opcion1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbl_Cuest As Label
End Class
