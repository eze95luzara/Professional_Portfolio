<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Preguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Preguntas))
        Me.Cmd_Opcion1 = New System.Windows.Forms.Button()
        Me.Cmd_Opcion2 = New System.Windows.Forms.Button()
        Me.Cmd_Opcion3 = New System.Windows.Forms.Button()
        Me.Cmd_Opcion4 = New System.Windows.Forms.Button()
        Me.mask_Pregunta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_Preg = New System.Windows.Forms.Label()
        Me.LinkSiguiente = New System.Windows.Forms.LinkLabel()
        Me.lbl_Preguntas = New System.Windows.Forms.Label()
        Me.lbl_Cuestionario = New System.Windows.Forms.Label()
        Me.lbl_Consigna = New System.Windows.Forms.Label()
        Me.LinkConsigna = New System.Windows.Forms.LinkLabel()
        Me.Lbl_Pregunta = New System.Windows.Forms.Label()
        Me.lbl_Cuest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cmd_Opcion1
        '
        Me.Cmd_Opcion1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion1.Location = New System.Drawing.Point(34, 269)
        Me.Cmd_Opcion1.Name = "Cmd_Opcion1"
        Me.Cmd_Opcion1.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion1.TabIndex = 0
        Me.Cmd_Opcion1.Text = "Button1"
        Me.Cmd_Opcion1.UseVisualStyleBackColor = True
        '
        'Cmd_Opcion2
        '
        Me.Cmd_Opcion2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion2.Location = New System.Drawing.Point(207, 269)
        Me.Cmd_Opcion2.Name = "Cmd_Opcion2"
        Me.Cmd_Opcion2.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion2.TabIndex = 1
        Me.Cmd_Opcion2.Text = "Button2"
        Me.Cmd_Opcion2.UseVisualStyleBackColor = True
        '
        'Cmd_Opcion3
        '
        Me.Cmd_Opcion3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion3.Location = New System.Drawing.Point(405, 269)
        Me.Cmd_Opcion3.Name = "Cmd_Opcion3"
        Me.Cmd_Opcion3.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion3.TabIndex = 2
        Me.Cmd_Opcion3.Text = "Button3"
        Me.Cmd_Opcion3.UseVisualStyleBackColor = True
        '
        'Cmd_Opcion4
        '
        Me.Cmd_Opcion4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Opcion4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Opcion4.Location = New System.Drawing.Point(587, 269)
        Me.Cmd_Opcion4.Name = "Cmd_Opcion4"
        Me.Cmd_Opcion4.Size = New System.Drawing.Size(90, 90)
        Me.Cmd_Opcion4.TabIndex = 3
        Me.Cmd_Opcion4.Text = "Button4"
        Me.Cmd_Opcion4.UseVisualStyleBackColor = True
        '
        'mask_Pregunta
        '
        Me.mask_Pregunta.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mask_Pregunta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mask_Pregunta.Location = New System.Drawing.Point(644, 38)
        Me.mask_Pregunta.Mask = "00"
        Me.mask_Pregunta.Name = "mask_Pregunta"
        Me.mask_Pregunta.Size = New System.Drawing.Size(28, 26)
        Me.mask_Pregunta.TabIndex = 4
        '
        'lbl_Preg
        '
        Me.lbl_Preg.AutoSize = True
        Me.lbl_Preg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Preg.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Preg.Location = New System.Drawing.Point(678, 41)
        Me.lbl_Preg.Name = "lbl_Preg"
        Me.lbl_Preg.Size = New System.Drawing.Size(36, 19)
        Me.lbl_Preg.TabIndex = 5
        Me.lbl_Preg.Text = "/10"
        '
        'LinkSiguiente
        '
        Me.LinkSiguiente.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkSiguiente.AutoSize = True
        Me.LinkSiguiente.BackColor = System.Drawing.Color.Transparent
        Me.LinkSiguiente.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSiguiente.LinkColor = System.Drawing.Color.Red
        Me.LinkSiguiente.Location = New System.Drawing.Point(246, 382)
        Me.LinkSiguiente.Name = "LinkSiguiente"
        Me.LinkSiguiente.Size = New System.Drawing.Size(232, 20)
        Me.LinkSiguiente.TabIndex = 6
        Me.LinkSiguiente.TabStop = True
        Me.LinkSiguiente.Text = "Pasar a Siguiente Pregunta"
        '
        'lbl_Preguntas
        '
        Me.lbl_Preguntas.AutoSize = True
        Me.lbl_Preguntas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Preguntas.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Preguntas.Location = New System.Drawing.Point(547, 41)
        Me.lbl_Preguntas.Name = "lbl_Preguntas"
        Me.lbl_Preguntas.Size = New System.Drawing.Size(91, 19)
        Me.lbl_Preguntas.TabIndex = 7
        Me.lbl_Preguntas.Text = "Pregunta:"
        '
        'lbl_Cuestionario
        '
        Me.lbl_Cuestionario.AutoSize = True
        Me.lbl_Cuestionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cuestionario.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuestionario.Location = New System.Drawing.Point(12, 41)
        Me.lbl_Cuestionario.Name = "lbl_Cuestionario"
        Me.lbl_Cuestionario.Size = New System.Drawing.Size(122, 19)
        Me.lbl_Cuestionario.TabIndex = 8
        Me.lbl_Cuestionario.Text = "Cuestionario:"
        '
        'lbl_Consigna
        '
        Me.lbl_Consigna.AutoSize = True
        Me.lbl_Consigna.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Consigna.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Consigna.Location = New System.Drawing.Point(33, 477)
        Me.lbl_Consigna.Name = "lbl_Consigna"
        Me.lbl_Consigna.Size = New System.Drawing.Size(387, 20)
        Me.lbl_Consigna.TabIndex = 9
        Me.lbl_Consigna.Text = "Si desear Repasar este tema, puede entrar a:"
        '
        'LinkConsigna
        '
        Me.LinkConsigna.AutoSize = True
        Me.LinkConsigna.BackColor = System.Drawing.Color.Transparent
        Me.LinkConsigna.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkConsigna.Location = New System.Drawing.Point(433, 477)
        Me.LinkConsigna.Name = "LinkConsigna"
        Me.LinkConsigna.Size = New System.Drawing.Size(279, 20)
        Me.LinkConsigna.TabIndex = 10
        Me.LinkConsigna.TabStop = True
        Me.LinkConsigna.Text = "matematicasonline.es/fracciones"
        '
        'Lbl_Pregunta
        '
        Me.Lbl_Pregunta.AutoSize = True
        Me.Lbl_Pregunta.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Pregunta.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pregunta.Location = New System.Drawing.Point(203, 147)
        Me.Lbl_Pregunta.Name = "Lbl_Pregunta"
        Me.Lbl_Pregunta.Size = New System.Drawing.Size(146, 20)
        Me.Lbl_Pregunta.TabIndex = 11
        Me.Lbl_Pregunta.Text = "PREGUNTA AQUI"
        '
        'lbl_Cuest
        '
        Me.lbl_Cuest.AutoSize = True
        Me.lbl_Cuest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cuest.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuest.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Cuest.Location = New System.Drawing.Point(140, 40)
        Me.lbl_Cuest.Name = "lbl_Cuest"
        Me.lbl_Cuest.Size = New System.Drawing.Size(91, 20)
        Me.lbl_Cuest.TabIndex = 26
        Me.lbl_Cuest.Text = "nomCuest"
        '
        'Frm_Preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(733, 511)
        Me.Controls.Add(Me.lbl_Cuest)
        Me.Controls.Add(Me.Lbl_Pregunta)
        Me.Controls.Add(Me.LinkConsigna)
        Me.Controls.Add(Me.lbl_Consigna)
        Me.Controls.Add(Me.lbl_Cuestionario)
        Me.Controls.Add(Me.lbl_Preguntas)
        Me.Controls.Add(Me.LinkSiguiente)
        Me.Controls.Add(Me.lbl_Preg)
        Me.Controls.Add(Me.mask_Pregunta)
        Me.Controls.Add(Me.Cmd_Opcion4)
        Me.Controls.Add(Me.Cmd_Opcion3)
        Me.Controls.Add(Me.Cmd_Opcion2)
        Me.Controls.Add(Me.Cmd_Opcion1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Preguntas"
        Me.Text = " RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_Opcion1 As Button
    Friend WithEvents Cmd_Opcion2 As Button
    Friend WithEvents Cmd_Opcion3 As Button
    Friend WithEvents Cmd_Opcion4 As Button
    Friend WithEvents mask_Pregunta As MaskedTextBox
    Friend WithEvents lbl_Preg As Label
    Friend WithEvents LinkSiguiente As LinkLabel
    Friend WithEvents lbl_Preguntas As Label
    Friend WithEvents lbl_Cuestionario As Label
    Friend WithEvents lbl_Consigna As Label
    Friend WithEvents LinkConsigna As LinkLabel
    Friend WithEvents Lbl_Pregunta As Label
    Friend WithEvents lbl_Cuest As Label
End Class
