<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Jugadores
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
        Me.lbl_TipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_Documento = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_NombreClub = New System.Windows.Forms.Label()
        Me.lbl_Posicion = New System.Windows.Forms.Label()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.txt_Documento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.grid_Jugadores = New System.Windows.Forms.DataGridView()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmb_Estado = New GranColo.ComboBoxV1()
        Me.cmb_Posicion = New GranColo.ComboBoxV1()
        Me.cmb_NombreClub = New GranColo.ComboBoxV1()
        Me.cmb_TipoDocumento = New GranColo.ComboBoxV1()
        CType(Me.grid_Jugadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TipoDocumento
        '
        Me.lbl_TipoDocumento.AutoSize = True
        Me.lbl_TipoDocumento.Location = New System.Drawing.Point(35, 33)
        Me.lbl_TipoDocumento.Name = "lbl_TipoDocumento"
        Me.lbl_TipoDocumento.Size = New System.Drawing.Size(101, 13)
        Me.lbl_TipoDocumento.TabIndex = 0
        Me.lbl_TipoDocumento.Text = "Tipo de Documento"
        '
        'lbl_Documento
        '
        Me.lbl_Documento.AutoSize = True
        Me.lbl_Documento.Location = New System.Drawing.Point(74, 60)
        Me.lbl_Documento.Name = "lbl_Documento"
        Me.lbl_Documento.Size = New System.Drawing.Size(62, 13)
        Me.lbl_Documento.TabIndex = 1
        Me.lbl_Documento.Text = "Documento"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(92, 86)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Apellido.TabIndex = 2
        Me.lbl_Apellido.Text = "Apellido"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(92, 112)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_NombreClub
        '
        Me.lbl_NombreClub.AutoSize = True
        Me.lbl_NombreClub.Location = New System.Drawing.Point(51, 138)
        Me.lbl_NombreClub.Name = "lbl_NombreClub"
        Me.lbl_NombreClub.Size = New System.Drawing.Size(85, 13)
        Me.lbl_NombreClub.TabIndex = 4
        Me.lbl_NombreClub.Text = "Nombre del Club"
        '
        'lbl_Posicion
        '
        Me.lbl_Posicion.AutoSize = True
        Me.lbl_Posicion.Location = New System.Drawing.Point(89, 165)
        Me.lbl_Posicion.Name = "lbl_Posicion"
        Me.lbl_Posicion.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Posicion.TabIndex = 5
        Me.lbl_Posicion.Text = "Posición"
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(96, 192)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Estado.TabIndex = 6
        Me.lbl_Estado.Text = "Estado"
        '
        'txt_Documento
        '
        Me.txt_Documento.Location = New System.Drawing.Point(142, 57)
        Me.txt_Documento.Mask = "99999999"
        Me.txt_Documento.Name = "txt_Documento"
        Me.txt_Documento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_Documento.Size = New System.Drawing.Size(57, 20)
        Me.txt_Documento.TabIndex = 1
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(142, 83)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(225, 20)
        Me.txt_Apellido.TabIndex = 2
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(142, 109)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(225, 20)
        Me.txt_Nombre.TabIndex = 3
        '
        'grid_Jugadores
        '
        Me.grid_Jugadores.AllowUserToAddRows = False
        Me.grid_Jugadores.AllowUserToDeleteRows = False
        Me.grid_Jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Jugadores.Location = New System.Drawing.Point(12, 231)
        Me.grid_Jugadores.Name = "grid_Jugadores"
        Me.grid_Jugadores.ReadOnly = True
        Me.grid_Jugadores.Size = New System.Drawing.Size(610, 198)
        Me.grid_Jugadores.TabIndex = 11
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(12, 435)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(81, 23)
        Me.cmd_Nuevo.TabIndex = 7
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(454, 435)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(81, 23)
        Me.cmd_Guardar.TabIndex = 9
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(541, 435)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(81, 23)
        Me.cmd_Cancelar.TabIndex = 10
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(99, 436)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(87, 22)
        Me.cmd_eliminar.TabIndex = 8
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmb_Estado
        '
        Me.cmb_Estado._descripcion = "nombre"
        Me.cmb_Estado._nombreTabla = "Estados"
        Me.cmb_Estado._pk = "id"
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(142, 189)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(57, 21)
        Me.cmb_Estado.TabIndex = 6
        '
        'cmb_Posicion
        '
        Me.cmb_Posicion._descripcion = "nombre"
        Me.cmb_Posicion._nombreTabla = "Posiciones"
        Me.cmb_Posicion._pk = "id"
        Me.cmb_Posicion.FormattingEnabled = True
        Me.cmb_Posicion.Location = New System.Drawing.Point(142, 162)
        Me.cmb_Posicion.Name = "cmb_Posicion"
        Me.cmb_Posicion.Size = New System.Drawing.Size(57, 21)
        Me.cmb_Posicion.TabIndex = 5
        '
        'cmb_NombreClub
        '
        Me.cmb_NombreClub._descripcion = "nombre"
        Me.cmb_NombreClub._nombreTabla = "Clubes"
        Me.cmb_NombreClub._pk = "id"
        Me.cmb_NombreClub.FormattingEnabled = True
        Me.cmb_NombreClub.Location = New System.Drawing.Point(142, 135)
        Me.cmb_NombreClub.Name = "cmb_NombreClub"
        Me.cmb_NombreClub.Size = New System.Drawing.Size(163, 21)
        Me.cmb_NombreClub.TabIndex = 4
        '
        'cmb_TipoDocumento
        '
        Me.cmb_TipoDocumento._descripcion = "nombre"
        Me.cmb_TipoDocumento._nombreTabla = "TiposDocumento"
        Me.cmb_TipoDocumento._pk = "id"
        Me.cmb_TipoDocumento.FormattingEnabled = True
        Me.cmb_TipoDocumento.Location = New System.Drawing.Point(142, 30)
        Me.cmb_TipoDocumento.Name = "cmb_TipoDocumento"
        Me.cmb_TipoDocumento.Size = New System.Drawing.Size(82, 21)
        Me.cmb_TipoDocumento.TabIndex = 0
        '
        'ABM_Jugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 470)
        Me.Controls.Add(Me.cmb_Estado)
        Me.Controls.Add(Me.cmb_Posicion)
        Me.Controls.Add(Me.cmb_NombreClub)
        Me.Controls.Add(Me.cmb_TipoDocumento)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.grid_Jugadores)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_Documento)
        Me.Controls.Add(Me.lbl_Estado)
        Me.Controls.Add(Me.lbl_Posicion)
        Me.Controls.Add(Me.lbl_NombreClub)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.lbl_Documento)
        Me.Controls.Add(Me.lbl_TipoDocumento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ABM_Jugadores"
        Me.Text = "ABM Jugadores"
        CType(Me.grid_Jugadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_TipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_Documento As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreClub As System.Windows.Forms.Label
    Friend WithEvents lbl_Posicion As System.Windows.Forms.Label
    Friend WithEvents lbl_Estado As System.Windows.Forms.Label
    Friend WithEvents txt_Documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents grid_Jugadores As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmb_TipoDocumento As ComboBoxV1
    Friend WithEvents cmb_NombreClub As ComboBoxV1
    Friend WithEvents cmb_Posicion As ComboBoxV1
    Friend WithEvents cmb_Estado As ComboBoxV1
End Class
