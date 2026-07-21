<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_desafio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_desafio))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_Mensaje = New System.Windows.Forms.TextBox()
        Me.lbl_SelecCues = New System.Windows.Forms.Label()
        Me.lbl_SelecAlu = New System.Windows.Forms.Label()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.cmb_Alumnos = New System.Windows.Forms.ComboBox()
        Me.cmd_Confirmar = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.cmb_Cuestionario = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(204, 47)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(71, 19)
        Me.lbl_titulo.TabIndex = 15
        Me.lbl_titulo.Text = "Desafio"
        '
        'txt_Mensaje
        '
        Me.txt_Mensaje.Location = New System.Drawing.Point(161, 200)
        Me.txt_Mensaje.Name = "txt_Mensaje"
        Me.txt_Mensaje.Size = New System.Drawing.Size(276, 20)
        Me.txt_Mensaje.TabIndex = 16
        '
        'lbl_SelecCues
        '
        Me.lbl_SelecCues.AutoSize = True
        Me.lbl_SelecCues.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SelecCues.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SelecCues.Location = New System.Drawing.Point(72, 119)
        Me.lbl_SelecCues.Name = "lbl_SelecCues"
        Me.lbl_SelecCues.Size = New System.Drawing.Size(203, 19)
        Me.lbl_SelecCues.TabIndex = 17
        Me.lbl_SelecCues.Text = "Seleccionar Cuestionario: "
        '
        'lbl_SelecAlu
        '
        Me.lbl_SelecAlu.AutoSize = True
        Me.lbl_SelecAlu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SelecAlu.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SelecAlu.Location = New System.Drawing.Point(72, 157)
        Me.lbl_SelecAlu.Name = "lbl_SelecAlu"
        Me.lbl_SelecAlu.Size = New System.Drawing.Size(166, 19)
        Me.lbl_SelecAlu.TabIndex = 18
        Me.lbl_SelecAlu.Text = "Seleccionar Alumno: "
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Mensaje.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mensaje.Location = New System.Drawing.Point(72, 199)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(83, 19)
        Me.lbl_Mensaje.TabIndex = 19
        Me.lbl_Mensaje.Text = "Mensaje: "
        '
        'cmb_Alumnos
        '
        Me.cmb_Alumnos.FormattingEnabled = True
        Me.cmb_Alumnos.Location = New System.Drawing.Point(244, 158)
        Me.cmb_Alumnos.Name = "cmb_Alumnos"
        Me.cmb_Alumnos.Size = New System.Drawing.Size(193, 21)
        Me.cmb_Alumnos.TabIndex = 23
        '
        'cmd_Confirmar
        '
        Me.cmd_Confirmar.Location = New System.Drawing.Point(368, 300)
        Me.cmd_Confirmar.Name = "cmd_Confirmar"
        Me.cmd_Confirmar.Size = New System.Drawing.Size(111, 48)
        Me.cmd_Confirmar.TabIndex = 24
        Me.cmd_Confirmar.Text = "Confirmar"
        Me.cmd_Confirmar.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(24, 300)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(111, 48)
        Me.cmd_Volver.TabIndex = 25
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'cmb_Cuestionario
        '
        Me.cmb_Cuestionario.FormattingEnabled = True
        Me.cmb_Cuestionario.Location = New System.Drawing.Point(281, 120)
        Me.cmb_Cuestionario.Name = "cmb_Cuestionario"
        Me.cmb_Cuestionario.Size = New System.Drawing.Size(156, 21)
        Me.cmb_Cuestionario.TabIndex = 26
        '
        'frm_desafio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(511, 383)
        Me.Controls.Add(Me.cmb_Cuestionario)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_Confirmar)
        Me.Controls.Add(Me.cmb_Alumnos)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.lbl_SelecAlu)
        Me.Controls.Add(Me.lbl_SelecCues)
        Me.Controls.Add(Me.txt_Mensaje)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_desafio"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents txt_Mensaje As TextBox
    Friend WithEvents lbl_SelecCues As Label
    Friend WithEvents lbl_SelecAlu As Label
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents cmb_Alumnos As ComboBox
    Friend WithEvents cmd_Confirmar As Button
    Friend WithEvents cmd_Volver As Button
    Friend WithEvents cmb_Cuestionario As ComboBox
End Class
