<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cuestionario
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ley de Signos    ", "adadsada"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Precedencia       ", "10 Preguntas", "Habilitado a: 1°A, 1°B, 1°C"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Fracciones        "}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cuestionario))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_HabilitarCues = New System.Windows.Forms.Button()
        Me.cmd_EliminarCues = New System.Windows.Forms.Button()
        Me.cmd_AgregarCues = New System.Windows.Forms.Button()
        Me.cmd_ModificarCues = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbl_CursosAsignados = New System.Windows.Forms.Label()
        Me.lbl_CantPreg = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_CantPreg = New System.Windows.Forms.TextBox()
        Me.txt_cursosAsignados = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(517, 107)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(154, 143)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'Col1
        '
        Me.Col1.Text = "EEEE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuestionarios"
        '
        'cmd_HabilitarCues
        '
        Me.cmd_HabilitarCues.Location = New System.Drawing.Point(581, 308)
        Me.cmd_HabilitarCues.Name = "cmd_HabilitarCues"
        Me.cmd_HabilitarCues.Size = New System.Drawing.Size(152, 61)
        Me.cmd_HabilitarCues.TabIndex = 27
        Me.cmd_HabilitarCues.Text = "Habilitar Cuestionario"
        Me.cmd_HabilitarCues.UseVisualStyleBackColor = True
        '
        'cmd_EliminarCues
        '
        Me.cmd_EliminarCues.Location = New System.Drawing.Point(214, 308)
        Me.cmd_EliminarCues.Name = "cmd_EliminarCues"
        Me.cmd_EliminarCues.Size = New System.Drawing.Size(152, 61)
        Me.cmd_EliminarCues.TabIndex = 26
        Me.cmd_EliminarCues.Text = "Eliminar Cuestionario"
        Me.cmd_EliminarCues.UseVisualStyleBackColor = True
        '
        'cmd_AgregarCues
        '
        Me.cmd_AgregarCues.Location = New System.Drawing.Point(35, 308)
        Me.cmd_AgregarCues.Name = "cmd_AgregarCues"
        Me.cmd_AgregarCues.Size = New System.Drawing.Size(152, 61)
        Me.cmd_AgregarCues.TabIndex = 25
        Me.cmd_AgregarCues.Text = "Agregar Cuestionario"
        Me.cmd_AgregarCues.UseVisualStyleBackColor = True
        '
        'cmd_ModificarCues
        '
        Me.cmd_ModificarCues.Location = New System.Drawing.Point(392, 308)
        Me.cmd_ModificarCues.Name = "cmd_ModificarCues"
        Me.cmd_ModificarCues.Size = New System.Drawing.Size(152, 61)
        Me.cmd_ModificarCues.TabIndex = 24
        Me.cmd_ModificarCues.Text = "Modificar Cuestionario"
        Me.cmd_ModificarCues.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(654, 107)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 143)
        Me.VScrollBar1.TabIndex = 28
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(29, 32)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(68, 19)
        Me.LinkLabel1.TabIndex = 29
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "VOLVER"
        '
        'lbl_CursosAsignados
        '
        Me.lbl_CursosAsignados.AutoSize = True
        Me.lbl_CursosAsignados.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CursosAsignados.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CursosAsignados.Location = New System.Drawing.Point(42, 228)
        Me.lbl_CursosAsignados.Name = "lbl_CursosAsignados"
        Me.lbl_CursosAsignados.Size = New System.Drawing.Size(233, 20)
        Me.lbl_CursosAsignados.TabIndex = 30
        Me.lbl_CursosAsignados.Text = "Habilitado para los Cursos:"
        '
        'lbl_CantPreg
        '
        Me.lbl_CantPreg.AutoSize = True
        Me.lbl_CantPreg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CantPreg.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantPreg.Location = New System.Drawing.Point(133, 187)
        Me.lbl_CantPreg.Name = "lbl_CantPreg"
        Me.lbl_CantPreg.Size = New System.Drawing.Size(142, 20)
        Me.lbl_CantPreg.TabIndex = 31
        Me.lbl_CantPreg.Text = "Cant Preguntas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(133, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Cuestionario Seleccionado:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(196, 151)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(79, 20)
        Me.lbl_Nombre.TabIndex = 33
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(279, 151)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 34
        Me.txt_Nombre.Text = "Ley De Signos"
        '
        'txt_CantPreg
        '
        Me.txt_CantPreg.Location = New System.Drawing.Point(281, 189)
        Me.txt_CantPreg.Name = "txt_CantPreg"
        Me.txt_CantPreg.Size = New System.Drawing.Size(100, 20)
        Me.txt_CantPreg.TabIndex = 35
        Me.txt_CantPreg.Text = "10"
        '
        'txt_cursosAsignados
        '
        Me.txt_cursosAsignados.Location = New System.Drawing.Point(281, 230)
        Me.txt_cursosAsignados.Name = "txt_cursosAsignados"
        Me.txt_cursosAsignados.Size = New System.Drawing.Size(100, 20)
        Me.txt_cursosAsignados.TabIndex = 36
        Me.txt_cursosAsignados.Text = "1°A, 1°B, 1°C"
        '
        'frm_cuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(763, 381)
        Me.Controls.Add(Me.txt_cursosAsignados)
        Me.Controls.Add(Me.txt_CantPreg)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_CantPreg)
        Me.Controls.Add(Me.lbl_CursosAsignados)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.cmd_HabilitarCues)
        Me.Controls.Add(Me.cmd_EliminarCues)
        Me.Controls.Add(Me.cmd_AgregarCues)
        Me.Controls.Add(Me.cmd_ModificarCues)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cuestionario"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_HabilitarCues As Button
    Friend WithEvents cmd_EliminarCues As Button
    Friend WithEvents cmd_AgregarCues As Button
    Friend WithEvents cmd_ModificarCues As Button
    Friend WithEvents Col1 As ColumnHeader
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbl_CursosAsignados As Label
    Friend WithEvents lbl_CantPreg As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_CantPreg As TextBox
    Friend WithEvents txt_cursosAsignados As TextBox
End Class
