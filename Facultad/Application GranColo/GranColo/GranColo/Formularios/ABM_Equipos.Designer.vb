<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Equipos
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
        Me.lbl_NombreEquipo = New System.Windows.Forms.Label()
        Me.lbl_Lema = New System.Windows.Forms.Label()
        Me.lbl_Color = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.txt_NombreEquipo = New System.Windows.Forms.TextBox()
        Me.txt_Lema = New System.Windows.Forms.RichTextBox()
        Me.txt_Color = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.grid_Equipos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        CType(Me.grid_Equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NombreEquipo
        '
        Me.lbl_NombreEquipo.AutoSize = True
        Me.lbl_NombreEquipo.Location = New System.Drawing.Point(97, 39)
        Me.lbl_NombreEquipo.Name = "lbl_NombreEquipo"
        Me.lbl_NombreEquipo.Size = New System.Drawing.Size(44, 13)
        Me.lbl_NombreEquipo.TabIndex = 0
        Me.lbl_NombreEquipo.Text = "Nombre"
        '
        'lbl_Lema
        '
        Me.lbl_Lema.AutoSize = True
        Me.lbl_Lema.Location = New System.Drawing.Point(108, 65)
        Me.lbl_Lema.Name = "lbl_Lema"
        Me.lbl_Lema.Size = New System.Drawing.Size(33, 13)
        Me.lbl_Lema.TabIndex = 1
        Me.lbl_Lema.Text = "Lema"
        '
        'lbl_Color
        '
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Location = New System.Drawing.Point(110, 125)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Color.TabIndex = 2
        Me.lbl_Color.Text = "Color"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(98, 151)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 3
        Me.lbl_Usuario.Text = "Usuario"
        '
        'txt_NombreEquipo
        '
        Me.txt_NombreEquipo.Location = New System.Drawing.Point(158, 39)
        Me.txt_NombreEquipo.Name = "txt_NombreEquipo"
        Me.txt_NombreEquipo.Size = New System.Drawing.Size(282, 20)
        Me.txt_NombreEquipo.TabIndex = 4
        '
        'txt_Lema
        '
        Me.txt_Lema.Location = New System.Drawing.Point(158, 65)
        Me.txt_Lema.Name = "txt_Lema"
        Me.txt_Lema.Size = New System.Drawing.Size(282, 54)
        Me.txt_Lema.TabIndex = 5
        Me.txt_Lema.Text = ""
        '
        'txt_Color
        '
        Me.txt_Color.Location = New System.Drawing.Point(158, 125)
        Me.txt_Color.Name = "txt_Color"
        Me.txt_Color.Size = New System.Drawing.Size(282, 20)
        Me.txt_Color.TabIndex = 6
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(158, 151)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(282, 20)
        Me.txt_Usuario.TabIndex = 7
        '
        'grid_Equipos
        '
        Me.grid_Equipos.AllowUserToAddRows = False
        Me.grid_Equipos.AllowUserToDeleteRows = False
        Me.grid_Equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.lema, Me.color, Me.usuario})
        Me.grid_Equipos.Location = New System.Drawing.Point(12, 189)
        Me.grid_Equipos.Name = "grid_Equipos"
        Me.grid_Equipos.ReadOnly = True
        Me.grid_Equipos.Size = New System.Drawing.Size(581, 157)
        Me.grid_Equipos.TabIndex = 8
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "nombreEquipo"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'lema
        '
        Me.lema.HeaderText = "Lema"
        Me.lema.Name = "lema"
        Me.lema.ReadOnly = True
        Me.lema.Width = 200
        '
        'color
        '
        Me.color.HeaderText = "Color"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Width = 85
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Location = New System.Drawing.Point(12, 363)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Nuevo.TabIndex = 9
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(437, 363)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 10
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(518, 363)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Location = New System.Drawing.Point(93, 363)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Borrar.TabIndex = 12
        Me.btn_Borrar.Text = "Borrar"
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'ABM_Equipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 398)
        Me.Controls.Add(Me.btn_Borrar)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.grid_Equipos)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.txt_Color)
        Me.Controls.Add(Me.txt_Lema)
        Me.Controls.Add(Me.txt_NombreEquipo)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_Color)
        Me.Controls.Add(Me.lbl_Lema)
        Me.Controls.Add(Me.lbl_NombreEquipo)
        Me.Name = "ABM_Equipos"
        Me.Text = "ABM Equipos"
        CType(Me.grid_Equipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_NombreEquipo As Label
    Friend WithEvents lbl_Lema As Label
    Friend WithEvents lbl_Color As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents txt_NombreEquipo As TextBox
    Friend WithEvents txt_Lema As RichTextBox
    Friend WithEvents txt_Color As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents grid_Equipos As DataGridView
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Borrar As Button
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents lema As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
End Class
