<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alumno))
        Me.lbl_NomUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Estadisticas = New System.Windows.Forms.Button()
        Me.cmd_Desafio = New System.Windows.Forms.Button()
        Me.cmd_Cuestionario = New System.Windows.Forms.Button()
        Me.cmd_CerrSes = New System.Windows.Forms.Button()
        Me.cmd_Bandeja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_NomUser
        '
        Me.lbl_NomUser.AutoSize = True
        Me.lbl_NomUser.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NomUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_NomUser.Location = New System.Drawing.Point(433, 31)
        Me.lbl_NomUser.Name = "lbl_NomUser"
        Me.lbl_NomUser.Size = New System.Drawing.Size(109, 19)
        Me.lbl_NomUser.TabIndex = 15
        Me.lbl_NomUser.Text = "nomUsuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Menu Principal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(122, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bienvenido Alumno"
        '
        'cmd_Estadisticas
        '
        Me.cmd_Estadisticas.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Estadisticas.Location = New System.Drawing.Point(126, 348)
        Me.cmd_Estadisticas.Name = "cmd_Estadisticas"
        Me.cmd_Estadisticas.Size = New System.Drawing.Size(416, 61)
        Me.cmd_Estadisticas.TabIndex = 12
        Me.cmd_Estadisticas.Text = "Estadisticas"
        Me.cmd_Estadisticas.UseVisualStyleBackColor = True
        '
        'cmd_Desafio
        '
        Me.cmd_Desafio.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Desafio.Location = New System.Drawing.Point(126, 193)
        Me.cmd_Desafio.Name = "cmd_Desafio"
        Me.cmd_Desafio.Size = New System.Drawing.Size(416, 61)
        Me.cmd_Desafio.TabIndex = 11
        Me.cmd_Desafio.Text = "Desafio"
        Me.cmd_Desafio.UseVisualStyleBackColor = True
        '
        'cmd_Cuestionario
        '
        Me.cmd_Cuestionario.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cuestionario.Location = New System.Drawing.Point(126, 111)
        Me.cmd_Cuestionario.Name = "cmd_Cuestionario"
        Me.cmd_Cuestionario.Size = New System.Drawing.Size(416, 61)
        Me.cmd_Cuestionario.TabIndex = 10
        Me.cmd_Cuestionario.Text = "Cuestionario"
        Me.cmd_Cuestionario.UseVisualStyleBackColor = True
        '
        'cmd_CerrSes
        '
        Me.cmd_CerrSes.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CerrSes.Location = New System.Drawing.Point(126, 424)
        Me.cmd_CerrSes.Name = "cmd_CerrSes"
        Me.cmd_CerrSes.Size = New System.Drawing.Size(416, 61)
        Me.cmd_CerrSes.TabIndex = 9
        Me.cmd_CerrSes.Text = "Cerrar Sesion"
        Me.cmd_CerrSes.UseVisualStyleBackColor = True
        '
        'cmd_Bandeja
        '
        Me.cmd_Bandeja.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Bandeja.Location = New System.Drawing.Point(126, 271)
        Me.cmd_Bandeja.Name = "cmd_Bandeja"
        Me.cmd_Bandeja.Size = New System.Drawing.Size(416, 61)
        Me.cmd_Bandeja.TabIndex = 16
        Me.cmd_Bandeja.Text = "Bandeja de Desafios"
        Me.cmd_Bandeja.UseVisualStyleBackColor = True
        '
        'frm_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(671, 533)
        Me.Controls.Add(Me.cmd_Bandeja)
        Me.Controls.Add(Me.lbl_NomUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_Estadisticas)
        Me.Controls.Add(Me.cmd_Desafio)
        Me.Controls.Add(Me.cmd_Cuestionario)
        Me.Controls.Add(Me.cmd_CerrSes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_alumno"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NomUser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Estadisticas As System.Windows.Forms.Button
    Friend WithEvents cmd_Desafio As System.Windows.Forms.Button
    Friend WithEvents cmd_Cuestionario As System.Windows.Forms.Button
    Friend WithEvents cmd_CerrSes As System.Windows.Forms.Button
    Friend WithEvents cmd_Bandeja As Button
End Class
