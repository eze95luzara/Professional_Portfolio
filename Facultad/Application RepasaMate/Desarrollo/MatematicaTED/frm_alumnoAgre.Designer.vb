<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alumnoAgre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alumnoAgre))
        Me.Cmd_Volver = New System.Windows.Forms.Button()
        Me.Cmd_Agregar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_Legajo = New System.Windows.Forms.TextBox()
        Me.lbl_Legajo = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_curso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cmd_Volver
        '
        Me.Cmd_Volver.Location = New System.Drawing.Point(46, 265)
        Me.Cmd_Volver.Name = "Cmd_Volver"
        Me.Cmd_Volver.Size = New System.Drawing.Size(101, 61)
        Me.Cmd_Volver.TabIndex = 0
        Me.Cmd_Volver.Text = "Volver"
        Me.Cmd_Volver.UseVisualStyleBackColor = True
        '
        'Cmd_Agregar
        '
        Me.Cmd_Agregar.Location = New System.Drawing.Point(322, 265)
        Me.Cmd_Agregar.Name = "Cmd_Agregar"
        Me.Cmd_Agregar.Size = New System.Drawing.Size(101, 61)
        Me.Cmd_Agregar.TabIndex = 1
        Me.Cmd_Agregar.Text = "Agregar"
        Me.Cmd_Agregar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(185, 170)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(212, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(185, 123)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(212, 20)
        Me.txt_apellido.TabIndex = 3
        '
        'txt_Legajo
        '
        Me.txt_Legajo.Location = New System.Drawing.Point(185, 71)
        Me.txt_Legajo.Name = "txt_Legajo"
        Me.txt_Legajo.Size = New System.Drawing.Size(212, 20)
        Me.txt_Legajo.TabIndex = 4
        '
        'lbl_Legajo
        '
        Me.lbl_Legajo.AutoSize = True
        Me.lbl_Legajo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Legajo.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Legajo.Location = New System.Drawing.Point(90, 71)
        Me.lbl_Legajo.Name = "lbl_Legajo"
        Me.lbl_Legajo.Size = New System.Drawing.Size(71, 20)
        Me.lbl_Legajo.TabIndex = 5
        Me.lbl_Legajo.Text = "Legajo:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(85, 170)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(79, 20)
        Me.lbl_Nombre.TabIndex = 6
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Apellido.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellido.Location = New System.Drawing.Point(85, 123)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(82, 20)
        Me.lbl_Apellido.TabIndex = 7
        Me.lbl_Apellido.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(147, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingreso de alumnos"
        '
        'txt_curso
        '
        Me.txt_curso.Location = New System.Drawing.Point(185, 218)
        Me.txt_curso.Name = "txt_curso"
        Me.txt_curso.Size = New System.Drawing.Size(212, 20)
        Me.txt_curso.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Curso:"
        '
        'frm_alumnoAgre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(485, 338)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_curso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_Legajo)
        Me.Controls.Add(Me.txt_Legajo)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Cmd_Agregar)
        Me.Controls.Add(Me.Cmd_Volver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_alumnoAgre"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_Volver As Button
    Friend WithEvents Cmd_Agregar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_Legajo As TextBox
    Friend WithEvents lbl_Legajo As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_Apellido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_curso As TextBox
    Friend WithEvents Label2 As Label
End Class
