<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Categoria))
        Me.Cmd_Volver = New System.Windows.Forms.Button()
        Me.Cmd_Seguir = New System.Windows.Forms.Button()
        Me.Grid_Categoria = New System.Windows.Forms.DataGridView()
        Me.Col_IdC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Grid_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmd_Volver
        '
        Me.Cmd_Volver.Location = New System.Drawing.Point(48, 335)
        Me.Cmd_Volver.Name = "Cmd_Volver"
        Me.Cmd_Volver.Size = New System.Drawing.Size(101, 61)
        Me.Cmd_Volver.TabIndex = 29
        Me.Cmd_Volver.Text = "Volver"
        Me.Cmd_Volver.UseVisualStyleBackColor = True
        '
        'Cmd_Seguir
        '
        Me.Cmd_Seguir.Location = New System.Drawing.Point(333, 335)
        Me.Cmd_Seguir.Name = "Cmd_Seguir"
        Me.Cmd_Seguir.Size = New System.Drawing.Size(101, 61)
        Me.Cmd_Seguir.TabIndex = 28
        Me.Cmd_Seguir.Text = "Seguir"
        Me.Cmd_Seguir.UseVisualStyleBackColor = True
        '
        'Grid_Categoria
        '
        Me.Grid_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Categoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_IdC, Me.Col_Nombre, Me.Col_Desc})
        Me.Grid_Categoria.Location = New System.Drawing.Point(26, 94)
        Me.Grid_Categoria.Name = "Grid_Categoria"
        Me.Grid_Categoria.Size = New System.Drawing.Size(432, 215)
        Me.Grid_Categoria.TabIndex = 30
        '
        'Col_IdC
        '
        Me.Col_IdC.HeaderText = "Id Cuestionario"
        Me.Col_IdC.Name = "Col_IdC"
        '
        'Col_Nombre
        '
        Me.Col_Nombre.HeaderText = "Nombre Cuestionario"
        Me.Col_Nombre.Name = "Col_Nombre"
        '
        'Col_Desc
        '
        Me.Col_Desc.HeaderText = "Descripcion"
        Me.Col_Desc.Name = "Col_Desc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Eliga un Cuestionario: "
        '
        'Frm_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(488, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grid_Categoria)
        Me.Controls.Add(Me.Cmd_Volver)
        Me.Controls.Add(Me.Cmd_Seguir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Categoria"
        Me.Text = "RepasaMate"
        CType(Me.Grid_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_Volver As Button
    Friend WithEvents Cmd_Seguir As Button
    Friend WithEvents Grid_Categoria As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Col_IdC As DataGridViewTextBoxColumn
    Friend WithEvents Col_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Col_Desc As DataGridViewTextBoxColumn
End Class
