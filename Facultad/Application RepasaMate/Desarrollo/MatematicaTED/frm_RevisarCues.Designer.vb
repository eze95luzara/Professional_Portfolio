<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RevisarCues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RevisarCues))
        Me.lbl_NotaFin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_PregCorr = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NotaFin
        '
        Me.lbl_NotaFin.AutoSize = True
        Me.lbl_NotaFin.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NotaFin.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NotaFin.Location = New System.Drawing.Point(417, 274)
        Me.lbl_NotaFin.Name = "lbl_NotaFin"
        Me.lbl_NotaFin.Size = New System.Drawing.Size(116, 20)
        Me.lbl_NotaFin.TabIndex = 0
        Me.lbl_NotaFin.Text = "Nota Final: 8"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(292, 499)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(388, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Si deseas repasar este tema puedes entrar a:"
        '
        'lbl_PregCorr
        '
        Me.lbl_PregCorr.AutoSize = True
        Me.lbl_PregCorr.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PregCorr.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PregCorr.Location = New System.Drawing.Point(351, 238)
        Me.lbl_PregCorr.Name = "lbl_PregCorr"
        Me.lbl_PregCorr.Size = New System.Drawing.Size(249, 20)
        Me.lbl_PregCorr.TabIndex = 4
        Me.lbl_PregCorr.Text = "Preguntas Correctas: 8 de 10"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(268, 45)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(215, 19)
        Me.lbl_titulo.TabIndex = 5
        Me.lbl_titulo.Text = "Revision de Cuestionario"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(340, 519)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(279, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "matematicasonline.es/fracciones"
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(421, 592)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(111, 48)
        Me.cmd_Volver.TabIndex = 28
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 569)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'frm_RevisarCues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(731, 677)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_PregCorr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_NotaFin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_RevisarCues"
        Me.Text = "RepasaMate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_NotaFin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_PregCorr As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cmd_Volver As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
