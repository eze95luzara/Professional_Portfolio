<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_docente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_docente))
        Me.lbl_NomUser = New System.Windows.Forms.Label()
        Me.cmd_Estadisticas = New System.Windows.Forms.Button()
        Me.cmd_preguntas = New System.Windows.Forms.Button()
        Me.cmd_CerrSes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Cursos = New System.Windows.Forms.Button()
        Me.cmd_Cuestionario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_NomUser
        '
        Me.lbl_NomUser.AutoSize = True
        Me.lbl_NomUser.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NomUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_NomUser.Location = New System.Drawing.Point(437, 49)
        Me.lbl_NomUser.Name = "lbl_NomUser"
        Me.lbl_NomUser.Size = New System.Drawing.Size(109, 19)
        Me.lbl_NomUser.TabIndex = 21
        Me.lbl_NomUser.Text = "nomUsuario"
        '
        'cmd_Estadisticas
        '
        Me.cmd_Estadisticas.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Estadisticas.Location = New System.Drawing.Point(142, 355)
        Me.cmd_Estadisticas.Name = "cmd_Estadisticas"
        Me.cmd_Estadisticas.Size = New System.Drawing.Size(404, 61)
        Me.cmd_Estadisticas.TabIndex = 20
        Me.cmd_Estadisticas.Text = "Estadisticas"
        Me.cmd_Estadisticas.UseVisualStyleBackColor = True
        '
        'cmd_preguntas
        '
        Me.cmd_preguntas.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_preguntas.Location = New System.Drawing.Point(142, 202)
        Me.cmd_preguntas.Name = "cmd_preguntas"
        Me.cmd_preguntas.Size = New System.Drawing.Size(404, 61)
        Me.cmd_preguntas.TabIndex = 19
        Me.cmd_preguntas.Text = "Preguntas (Modificar)"
        Me.cmd_preguntas.UseVisualStyleBackColor = True
        '
        'cmd_CerrSes
        '
        Me.cmd_CerrSes.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CerrSes.Location = New System.Drawing.Point(142, 435)
        Me.cmd_CerrSes.Name = "cmd_CerrSes"
        Me.cmd_CerrSes.Size = New System.Drawing.Size(404, 61)
        Me.cmd_CerrSes.TabIndex = 17
        Me.cmd_CerrSes.Text = "Cerrar Sesion"
        Me.cmd_CerrSes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Menu Principal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(138, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Bienvenido Docente"
        '
        'cmd_Cursos
        '
        Me.cmd_Cursos.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cursos.Location = New System.Drawing.Point(142, 278)
        Me.cmd_Cursos.Name = "cmd_Cursos"
        Me.cmd_Cursos.Size = New System.Drawing.Size(404, 61)
        Me.cmd_Cursos.TabIndex = 22
        Me.cmd_Cursos.Text = "Manejo De Cursos"
        Me.cmd_Cursos.UseVisualStyleBackColor = True
        '
        'cmd_Cuestionario
        '
        Me.cmd_Cuestionario.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cuestionario.Location = New System.Drawing.Point(142, 125)
        Me.cmd_Cuestionario.Name = "cmd_Cuestionario"
        Me.cmd_Cuestionario.Size = New System.Drawing.Size(404, 61)
        Me.cmd_Cuestionario.TabIndex = 23
        Me.cmd_Cuestionario.Text = "Cuestionarios (Modificar)"
        Me.cmd_Cuestionario.UseVisualStyleBackColor = True
        '
        'frm_docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(684, 519)
        Me.Controls.Add(Me.cmd_Cuestionario)
        Me.Controls.Add(Me.cmd_Cursos)
        Me.Controls.Add(Me.lbl_NomUser)
        Me.Controls.Add(Me.cmd_Estadisticas)
        Me.Controls.Add(Me.cmd_preguntas)
        Me.Controls.Add(Me.cmd_CerrSes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_docente"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NomUser As System.Windows.Forms.Label
    Friend WithEvents cmd_Estadisticas As System.Windows.Forms.Button
    Friend WithEvents cmd_preguntas As System.Windows.Forms.Button
    Friend WithEvents cmd_CerrSes As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Cursos As Button
    Friend WithEvents cmd_Cuestionario As Button
End Class
