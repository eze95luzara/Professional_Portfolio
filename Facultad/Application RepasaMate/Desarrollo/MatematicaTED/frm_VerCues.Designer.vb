<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_verCues
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ley de Signos              ", "adadsada"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Precedencia                ", "10 Preguntas", "Habilitado a: 1°A, 1°B, 1°C"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Fracciones                 "}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ejercicios Combinados  "}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_verCues))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.cmd_RealizarCues = New System.Windows.Forms.Button()
        Me.cmd_RevisarCues = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_Tiutlo = New System.Windows.Forms.Label()
        Me.lbl_CantPreguntas = New System.Windows.Forms.Label()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.lbl_Est = New System.Windows.Forms.Label()
        Me.lbl_CantPreg = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Nom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(167, 48)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(157, 19)
        Me.lbl_titulo.TabIndex = 16
        Me.lbl_titulo.Text = "Ver Cuestionarios"
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(41, 311)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(111, 48)
        Me.cmd_Volver.TabIndex = 27
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'cmd_RealizarCues
        '
        Me.cmd_RealizarCues.Location = New System.Drawing.Point(223, 311)
        Me.cmd_RealizarCues.Name = "cmd_RealizarCues"
        Me.cmd_RealizarCues.Size = New System.Drawing.Size(111, 48)
        Me.cmd_RealizarCues.TabIndex = 26
        Me.cmd_RealizarCues.Text = "Realizar Cuestionario"
        Me.cmd_RealizarCues.UseVisualStyleBackColor = True
        '
        'cmd_RevisarCues
        '
        Me.cmd_RevisarCues.Location = New System.Drawing.Point(391, 311)
        Me.cmd_RevisarCues.Name = "cmd_RevisarCues"
        Me.cmd_RevisarCues.Size = New System.Drawing.Size(111, 48)
        Me.cmd_RevisarCues.TabIndex = 28
        Me.cmd_RevisarCues.Text = "Revisar Cuestionario"
        Me.cmd_RevisarCues.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListView1.Location = New System.Drawing.Point(25, 99)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(215, 149)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'Col1
        '
        Me.Col1.Text = "EEEE"
        '
        'lbl_Tiutlo
        '
        Me.lbl_Tiutlo.AutoSize = True
        Me.lbl_Tiutlo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tiutlo.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tiutlo.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Tiutlo.Location = New System.Drawing.Point(284, 99)
        Me.lbl_Tiutlo.Name = "lbl_Tiutlo"
        Me.lbl_Tiutlo.Size = New System.Drawing.Size(257, 20)
        Me.lbl_Tiutlo.TabIndex = 31
        Me.lbl_Tiutlo.Text = "Cuestionario Seleccionado:"
        '
        'lbl_CantPreguntas
        '
        Me.lbl_CantPreguntas.AutoSize = True
        Me.lbl_CantPreguntas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CantPreguntas.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantPreguntas.Location = New System.Drawing.Point(264, 171)
        Me.lbl_CantPreguntas.Name = "lbl_CantPreguntas"
        Me.lbl_CantPreguntas.Size = New System.Drawing.Size(157, 20)
        Me.lbl_CantPreguntas.TabIndex = 32
        Me.lbl_CantPreguntas.Text = "Cant Preguntas:"
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Estado.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Estado.Location = New System.Drawing.Point(264, 200)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(79, 20)
        Me.lbl_Estado.TabIndex = 33
        Me.lbl_Estado.Text = "Estado:"
        '
        'lbl_Est
        '
        Me.lbl_Est.AutoSize = True
        Me.lbl_Est.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Est.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Est.Location = New System.Drawing.Point(349, 200)
        Me.lbl_Est.Name = "lbl_Est"
        Me.lbl_Est.Size = New System.Drawing.Size(201, 20)
        Me.lbl_Est.TabIndex = 35
        Me.lbl_Est.Text = "No Ha Sido Respondido"
        '
        'lbl_CantPreg
        '
        Me.lbl_CantPreg.AutoSize = True
        Me.lbl_CantPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CantPreg.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantPreg.Location = New System.Drawing.Point(427, 171)
        Me.lbl_CantPreg.Name = "lbl_CantPreg"
        Me.lbl_CantPreg.Size = New System.Drawing.Size(29, 20)
        Me.lbl_CantPreg.TabIndex = 36
        Me.lbl_CantPreg.Text = "10"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(223, 99)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 149)
        Me.VScrollBar1.TabIndex = 37
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(264, 146)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(86, 20)
        Me.lbl_Nombre.TabIndex = 38
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_Nom
        '
        Me.lbl_Nom.AutoSize = True
        Me.lbl_Nom.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nom.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nom.Location = New System.Drawing.Point(349, 146)
        Me.lbl_Nom.Name = "lbl_Nom"
        Me.lbl_Nom.Size = New System.Drawing.Size(125, 20)
        Me.lbl_Nom.TabIndex = 39
        Me.lbl_Nom.Text = "Ley De Signos"
        '
        'frm_verCues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(574, 379)
        Me.Controls.Add(Me.lbl_Nom)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.lbl_CantPreg)
        Me.Controls.Add(Me.lbl_Est)
        Me.Controls.Add(Me.lbl_Estado)
        Me.Controls.Add(Me.lbl_CantPreguntas)
        Me.Controls.Add(Me.lbl_Tiutlo)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cmd_RevisarCues)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_RealizarCues)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_verCues"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents cmd_Volver As Button
    Friend WithEvents cmd_RealizarCues As Button
    Friend WithEvents cmd_RevisarCues As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Col1 As ColumnHeader
    Friend WithEvents lbl_Tiutlo As Label
    Friend WithEvents lbl_CantPreguntas As Label
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents lbl_Est As Label
    Friend WithEvents lbl_CantPreg As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_Nom As Label
End Class
