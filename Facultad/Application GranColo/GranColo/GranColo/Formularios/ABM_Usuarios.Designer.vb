<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABM_Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_NombreUsuario = New System.Windows.Forms.TextBox()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Contraseña = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NroDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_NombreUsuario = New System.Windows.Forms.Label()
        Me.lbl_Contraseña = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.lbl_TipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_NroDocumento = New System.Windows.Forms.Label()
        Me.lbl_HinchaClub = New System.Windows.Forms.Label()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.grid_Usuarios = New System.Windows.Forms.DataGridView()
        Me.cmb_HinchaClub = New GranColo.ComboBoxV1()
        Me.cmb_TipoDocumento = New GranColo.ComboBoxV1()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        CType(Me.grid_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_NombreUsuario
        '
        Me.txt_NombreUsuario.Location = New System.Drawing.Point(184, 36)
        Me.txt_NombreUsuario.Name = "txt_NombreUsuario"
        Me.txt_NombreUsuario.Size = New System.Drawing.Size(186, 20)
        Me.txt_NombreUsuario.TabIndex = 0
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(184, 114)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(186, 20)
        Me.txt_Apellido.TabIndex = 3
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(184, 192)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(186, 20)
        Me.txt_Email.TabIndex = 6
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(184, 88)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(186, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(184, 62)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_Contraseña.Size = New System.Drawing.Size(186, 20)
        Me.txt_Contraseña.TabIndex = 1
        '
        'txt_NroDocumento
        '
        Me.txt_NroDocumento.Location = New System.Drawing.Point(184, 166)
        Me.txt_NroDocumento.Mask = "999999999"
        Me.txt_NroDocumento.Name = "txt_NroDocumento"
        Me.txt_NroDocumento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_NroDocumento.Size = New System.Drawing.Size(60, 20)
        Me.txt_NroDocumento.TabIndex = 5
        '
        'lbl_NombreUsuario
        '
        Me.lbl_NombreUsuario.AutoSize = True
        Me.lbl_NombreUsuario.Location = New System.Drawing.Point(80, 39)
        Me.lbl_NombreUsuario.Name = "lbl_NombreUsuario"
        Me.lbl_NombreUsuario.Size = New System.Drawing.Size(98, 13)
        Me.lbl_NombreUsuario.TabIndex = 8
        Me.lbl_NombreUsuario.Text = "Nombre de Usuario"
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Location = New System.Drawing.Point(117, 65)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Contraseña.TabIndex = 9
        Me.lbl_Contraseña.Text = "Contraseña"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(134, 91)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 10
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(134, 117)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Apellido.TabIndex = 11
        Me.lbl_Apellido.Text = "Apellido"
        '
        'lbl_TipoDocumento
        '
        Me.lbl_TipoDocumento.AutoSize = True
        Me.lbl_TipoDocumento.Location = New System.Drawing.Point(77, 143)
        Me.lbl_TipoDocumento.Name = "lbl_TipoDocumento"
        Me.lbl_TipoDocumento.Size = New System.Drawing.Size(101, 13)
        Me.lbl_TipoDocumento.TabIndex = 12
        Me.lbl_TipoDocumento.Text = "Tipo de Documento"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(23, 195)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(155, 13)
        Me.lbl_Email.TabIndex = 13
        Me.lbl_Email.Text = "Dirección de correo electrónico"
        '
        'lbl_NroDocumento
        '
        Me.lbl_NroDocumento.AutoSize = True
        Me.lbl_NroDocumento.Location = New System.Drawing.Point(61, 169)
        Me.lbl_NroDocumento.Name = "lbl_NroDocumento"
        Me.lbl_NroDocumento.Size = New System.Drawing.Size(117, 13)
        Me.lbl_NroDocumento.TabIndex = 14
        Me.lbl_NroDocumento.Text = "Número de Documento"
        '
        'lbl_HinchaClub
        '
        Me.lbl_HinchaClub.AutoSize = True
        Me.lbl_HinchaClub.Location = New System.Drawing.Point(97, 221)
        Me.lbl_HinchaClub.Name = "lbl_HinchaClub"
        Me.lbl_HinchaClub.Size = New System.Drawing.Size(81, 13)
        Me.lbl_HinchaClub.TabIndex = 15
        Me.lbl_HinchaClub.Text = "Hincha del club"
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(12, 421)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 8
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Location = New System.Drawing.Point(93, 421)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Eliminar.TabIndex = 9
        Me.cmd_Eliminar.Text = "Eliminar"
        Me.cmd_Eliminar.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(408, 419)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 10
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'grid_Usuarios
        '
        Me.grid_Usuarios.AllowUserToAddRows = False
        Me.grid_Usuarios.AllowUserToDeleteRows = False
        Me.grid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Usuarios.Location = New System.Drawing.Point(12, 257)
        Me.grid_Usuarios.Name = "grid_Usuarios"
        Me.grid_Usuarios.ReadOnly = True
        Me.grid_Usuarios.Size = New System.Drawing.Size(552, 158)
        Me.grid_Usuarios.TabIndex = 11
        '
        'cmb_HinchaClub
        '
        Me.cmb_HinchaClub._descripcion = "nombre"
        Me.cmb_HinchaClub._nombreTabla = "Clubes"
        Me.cmb_HinchaClub._pk = "id"
        Me.cmb_HinchaClub.FormattingEnabled = True
        Me.cmb_HinchaClub.Location = New System.Drawing.Point(184, 218)
        Me.cmb_HinchaClub.Name = "cmb_HinchaClub"
        Me.cmb_HinchaClub.Size = New System.Drawing.Size(121, 21)
        Me.cmb_HinchaClub.TabIndex = 7
        '
        'cmb_TipoDocumento
        '
        Me.cmb_TipoDocumento._descripcion = "nombre"
        Me.cmb_TipoDocumento._nombreTabla = "TiposDocumento"
        Me.cmb_TipoDocumento._pk = "id"
        Me.cmb_TipoDocumento.FormattingEnabled = True
        Me.cmb_TipoDocumento.Location = New System.Drawing.Point(184, 140)
        Me.cmb_TipoDocumento.Name = "cmb_TipoDocumento"
        Me.cmb_TipoDocumento.Size = New System.Drawing.Size(73, 21)
        Me.cmb_TipoDocumento.TabIndex = 4
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(489, 419)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancelar.TabIndex = 16
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'ABM_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 454)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.grid_Usuarios)
        Me.Controls.Add(Me.cmb_HinchaClub)
        Me.Controls.Add(Me.cmb_TipoDocumento)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.cmd_Eliminar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.lbl_HinchaClub)
        Me.Controls.Add(Me.lbl_NroDocumento)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_TipoDocumento)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_Contraseña)
        Me.Controls.Add(Me.lbl_NombreUsuario)
        Me.Controls.Add(Me.txt_NroDocumento)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_NombreUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ABM_Usuarios"
        Me.Text = "ABM Usuarios"
        CType(Me.grid_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_NombreUsuario As TextBox
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Contraseña As MaskedTextBox
    Friend WithEvents txt_NroDocumento As MaskedTextBox
    Friend WithEvents lbl_NombreUsuario As Label
    Friend WithEvents lbl_Contraseña As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_Apellido As Label
    Friend WithEvents lbl_TipoDocumento As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_NroDocumento As Label
    Friend WithEvents lbl_HinchaClub As Label
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Eliminar As Button
    Friend WithEvents cmd_Guardar As Button
    Friend WithEvents cmb_TipoDocumento As ComboBoxV1
    Friend WithEvents cmb_HinchaClub As ComboBoxV1
    Friend WithEvents grid_Usuarios As DataGridView
    Friend WithEvents cmd_Cancelar As Button
End Class
