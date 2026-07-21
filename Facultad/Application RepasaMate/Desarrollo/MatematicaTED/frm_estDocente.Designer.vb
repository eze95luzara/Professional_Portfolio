<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estDocente))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.prBar_Linea1 = New System.Windows.Forms.ProgressBar()
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.tp3 = New System.Windows.Forms.TabPage()
        Me.tp4 = New System.Windows.Forms.TabPage()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp1)
        Me.TabControl1.Controls.Add(Me.tp2)
        Me.TabControl1.Controls.Add(Me.tp3)
        Me.TabControl1.Controls.Add(Me.tp4)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(631, 274)
        Me.TabControl1.TabIndex = 0
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.ProgressBar1)
        Me.tp1.Controls.Add(Me.prBar_Linea1)
        Me.tp1.Location = New System.Drawing.Point(4, 22)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tp1.Size = New System.Drawing.Size(623, 248)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "Todos"
        Me.tp1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(218, 141)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'prBar_Linea1
        '
        Me.prBar_Linea1.Location = New System.Drawing.Point(218, 110)
        Me.prBar_Linea1.Name = "prBar_Linea1"
        Me.prBar_Linea1.Size = New System.Drawing.Size(140, 24)
        Me.prBar_Linea1.TabIndex = 0
        '
        'tp2
        '
        Me.tp2.Location = New System.Drawing.Point(4, 22)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(3)
        Me.tp2.Size = New System.Drawing.Size(623, 248)
        Me.tp2.TabIndex = 1
        Me.tp2.Text = "Ley de Signos"
        Me.tp2.UseVisualStyleBackColor = True
        '
        'tp3
        '
        Me.tp3.Location = New System.Drawing.Point(4, 22)
        Me.tp3.Name = "tp3"
        Me.tp3.Padding = New System.Windows.Forms.Padding(3)
        Me.tp3.Size = New System.Drawing.Size(623, 248)
        Me.tp3.TabIndex = 2
        Me.tp3.Text = "Preceendencia"
        Me.tp3.UseVisualStyleBackColor = True
        '
        'tp4
        '
        Me.tp4.Location = New System.Drawing.Point(4, 22)
        Me.tp4.Name = "tp4"
        Me.tp4.Size = New System.Drawing.Size(623, 248)
        Me.tp4.TabIndex = 3
        Me.tp4.Text = "Fracciones"
        Me.tp4.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(42, 354)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Volver.TabIndex = 1
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frm_estDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(630, 408)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_estDocente"
        Me.Text = "RepasaMate"
        Me.TabControl1.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tp1 As TabPage
    Friend WithEvents tp2 As TabPage
    Friend WithEvents tp3 As TabPage
    Friend WithEvents tp4 As TabPage
    Friend WithEvents cmd_Volver As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents prBar_Linea1 As ProgressBar
End Class
