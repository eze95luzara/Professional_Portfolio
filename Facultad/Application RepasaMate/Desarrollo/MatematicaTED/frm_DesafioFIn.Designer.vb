<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DesafioFIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DesafioFIn))
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_alumno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkConsigna = New System.Windows.Forms.LinkLabel()
        Me.lbl_Consigna = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_ganador = New System.Windows.Forms.Label()
        Me.cmd_Finalizar = New System.Windows.Forms.Button()
        Me.lbl_Resultado1 = New System.Windows.Forms.Label()
        Me.lbl_Resultado = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_Usuario.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_Usuario.Location = New System.Drawing.Point(62, 184)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(105, 20)
        Me.lbl_Usuario.TabIndex = 0
        Me.lbl_Usuario.Text = "ezeluzara:"
        '
        'lbl_alumno
        '
        Me.lbl_alumno.AutoSize = True
        Me.lbl_alumno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_alumno.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_alumno.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alumno.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_alumno.Location = New System.Drawing.Point(62, 145)
        Me.lbl_alumno.Name = "lbl_alumno"
        Me.lbl_alumno.Size = New System.Drawing.Size(102, 20)
        Me.lbl_alumno.TabIndex = 1
        Me.lbl_alumno.Text = "lucasdiaz:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(221, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultados del Desafio: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(371, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "de 10 Preguntas respondidas correctamente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(214, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(371, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "de 10 Preguntas respondidas correctamente"
        '
        'LinkConsigna
        '
        Me.LinkConsigna.AutoSize = True
        Me.LinkConsigna.BackColor = System.Drawing.Color.Transparent
        Me.LinkConsigna.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkConsigna.Location = New System.Drawing.Point(405, 550)
        Me.LinkConsigna.Name = "LinkConsigna"
        Me.LinkConsigna.Size = New System.Drawing.Size(279, 20)
        Me.LinkConsigna.TabIndex = 24
        Me.LinkConsigna.TabStop = True
        Me.LinkConsigna.Text = "matematicasonline.es/fracciones"
        '
        'lbl_Consigna
        '
        Me.lbl_Consigna.AutoSize = True
        Me.lbl_Consigna.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Consigna.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Consigna.Location = New System.Drawing.Point(12, 550)
        Me.lbl_Consigna.Name = "lbl_Consigna"
        Me.lbl_Consigna.Size = New System.Drawing.Size(387, 20)
        Me.lbl_Consigna.TabIndex = 23
        Me.lbl_Consigna.Text = "Si desear Repasar este tema, puede entrar a:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'lbl_ganador
        '
        Me.lbl_ganador.AutoSize = True
        Me.lbl_ganador.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ganador.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ganador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_ganador.Location = New System.Drawing.Point(341, 331)
        Me.lbl_ganador.Name = "lbl_ganador"
        Me.lbl_ganador.Size = New System.Drawing.Size(271, 20)
        Me.lbl_ganador.TabIndex = 26
        Me.lbl_ganador.Text = "¡¡¡Felicitaciones ezeluzara!!!"
        '
        'cmd_Finalizar
        '
        Me.cmd_Finalizar.Location = New System.Drawing.Point(288, 459)
        Me.cmd_Finalizar.Name = "cmd_Finalizar"
        Me.cmd_Finalizar.Size = New System.Drawing.Size(111, 48)
        Me.cmd_Finalizar.TabIndex = 27
        Me.cmd_Finalizar.Text = "Finalizar"
        Me.cmd_Finalizar.UseVisualStyleBackColor = True
        '
        'lbl_Resultado1
        '
        Me.lbl_Resultado1.AutoSize = True
        Me.lbl_Resultado1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Resultado1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Resultado1.Location = New System.Drawing.Point(185, 145)
        Me.lbl_Resultado1.Name = "lbl_Resultado1"
        Me.lbl_Resultado1.Size = New System.Drawing.Size(20, 20)
        Me.lbl_Resultado1.TabIndex = 28
        Me.lbl_Resultado1.Text = "0"
        '
        'lbl_Resultado
        '
        Me.lbl_Resultado.AutoSize = True
        Me.lbl_Resultado.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Resultado.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Resultado.Location = New System.Drawing.Point(188, 184)
        Me.lbl_Resultado.Name = "lbl_Resultado"
        Me.lbl_Resultado.Size = New System.Drawing.Size(17, 20)
        Me.lbl_Resultado.TabIndex = 30
        Me.lbl_Resultado.Text = "-"
        '
        'frm_DesafioFIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(691, 589)
        Me.Controls.Add(Me.lbl_Resultado)
        Me.Controls.Add(Me.lbl_Resultado1)
        Me.Controls.Add(Me.cmd_Finalizar)
        Me.Controls.Add(Me.lbl_ganador)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkConsigna)
        Me.Controls.Add(Me.lbl_Consigna)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_alumno)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_DesafioFIn"
        Me.Text = "RepasaMate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_alumno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkConsigna As LinkLabel
    Friend WithEvents lbl_Consigna As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_ganador As Label
    Friend WithEvents cmd_Finalizar As Button
    Friend WithEvents lbl_Resultado1 As Label
    Friend WithEvents lbl_Resultado As Label
End Class
