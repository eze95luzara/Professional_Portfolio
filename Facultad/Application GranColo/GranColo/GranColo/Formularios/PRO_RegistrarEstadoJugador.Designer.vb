<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRO_RegistrarEstadoJugador
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
        Me.lbl_NombreJugador = New System.Windows.Forms.Label()
        Me.lbl_ApellidoJugador = New System.Windows.Forms.Label()
        Me.lbl_NroDocumento = New System.Windows.Forms.Label()
        Me.lbl_TipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_Club = New System.Windows.Forms.Label()
        Me.lbl_Posicion = New System.Windows.Forms.Label()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.txt_NombreJugador = New System.Windows.Forms.TextBox()
        Me.txt_ApellidoJugador = New System.Windows.Forms.TextBox()
        Me.txt_NroDocumento = New System.Windows.Forms.TextBox()
        Me.txt_TipoDocumento = New System.Windows.Forms.TextBox()
        Me.txt_Posicion = New System.Windows.Forms.TextBox()
        Me.grid_Jugadores = New System.Windows.Forms.DataGridView()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.cmb_Estado = New GranColo.ComboBoxV1()
        Me.cmb_Club = New GranColo.ComboBoxV1()
        CType(Me.grid_Jugadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NombreJugador
        '
        Me.lbl_NombreJugador.AutoSize = True
        Me.lbl_NombreJugador.Location = New System.Drawing.Point(26, 42)
        Me.lbl_NombreJugador.Name = "lbl_NombreJugador"
        Me.lbl_NombreJugador.Size = New System.Drawing.Size(102, 13)
        Me.lbl_NombreJugador.TabIndex = 0
        Me.lbl_NombreJugador.Text = "Nombre del Jugador"
        '
        'lbl_ApellidoJugador
        '
        Me.lbl_ApellidoJugador.AutoSize = True
        Me.lbl_ApellidoJugador.Location = New System.Drawing.Point(26, 68)
        Me.lbl_ApellidoJugador.Name = "lbl_ApellidoJugador"
        Me.lbl_ApellidoJugador.Size = New System.Drawing.Size(102, 13)
        Me.lbl_ApellidoJugador.TabIndex = 1
        Me.lbl_ApellidoJugador.Text = "Apellido del Jugador"
        '
        'lbl_NroDocumento
        '
        Me.lbl_NroDocumento.AutoSize = True
        Me.lbl_NroDocumento.Location = New System.Drawing.Point(11, 94)
        Me.lbl_NroDocumento.Name = "lbl_NroDocumento"
        Me.lbl_NroDocumento.Size = New System.Drawing.Size(117, 13)
        Me.lbl_NroDocumento.TabIndex = 2
        Me.lbl_NroDocumento.Text = "Número de Documento"
        '
        'lbl_TipoDocumento
        '
        Me.lbl_TipoDocumento.AutoSize = True
        Me.lbl_TipoDocumento.Location = New System.Drawing.Point(27, 120)
        Me.lbl_TipoDocumento.Name = "lbl_TipoDocumento"
        Me.lbl_TipoDocumento.Size = New System.Drawing.Size(101, 13)
        Me.lbl_TipoDocumento.TabIndex = 3
        Me.lbl_TipoDocumento.Text = "Tipo de Documento"
        '
        'lbl_Club
        '
        Me.lbl_Club.AutoSize = True
        Me.lbl_Club.Location = New System.Drawing.Point(100, 19)
        Me.lbl_Club.Name = "lbl_Club"
        Me.lbl_Club.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Club.TabIndex = 4
        Me.lbl_Club.Text = "Club"
        '
        'lbl_Posicion
        '
        Me.lbl_Posicion.AutoSize = True
        Me.lbl_Posicion.Location = New System.Drawing.Point(81, 146)
        Me.lbl_Posicion.Name = "lbl_Posicion"
        Me.lbl_Posicion.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Posicion.TabIndex = 5
        Me.lbl_Posicion.Text = "Posición"
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(88, 171)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Estado.TabIndex = 6
        Me.lbl_Estado.Text = "Estado"
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Location = New System.Drawing.Point(322, 10)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Buscar.TabIndex = 8
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'txt_NombreJugador
        '
        Me.txt_NombreJugador.Enabled = False
        Me.txt_NombreJugador.Location = New System.Drawing.Point(134, 39)
        Me.txt_NombreJugador.Name = "txt_NombreJugador"
        Me.txt_NombreJugador.Size = New System.Drawing.Size(182, 20)
        Me.txt_NombreJugador.TabIndex = 9
        '
        'txt_ApellidoJugador
        '
        Me.txt_ApellidoJugador.Enabled = False
        Me.txt_ApellidoJugador.Location = New System.Drawing.Point(134, 66)
        Me.txt_ApellidoJugador.Name = "txt_ApellidoJugador"
        Me.txt_ApellidoJugador.Size = New System.Drawing.Size(182, 20)
        Me.txt_ApellidoJugador.TabIndex = 10
        '
        'txt_NroDocumento
        '
        Me.txt_NroDocumento.Enabled = False
        Me.txt_NroDocumento.Location = New System.Drawing.Point(134, 91)
        Me.txt_NroDocumento.Name = "txt_NroDocumento"
        Me.txt_NroDocumento.Size = New System.Drawing.Size(65, 20)
        Me.txt_NroDocumento.TabIndex = 11
        '
        'txt_TipoDocumento
        '
        Me.txt_TipoDocumento.Enabled = False
        Me.txt_TipoDocumento.Location = New System.Drawing.Point(134, 117)
        Me.txt_TipoDocumento.Name = "txt_TipoDocumento"
        Me.txt_TipoDocumento.Size = New System.Drawing.Size(86, 20)
        Me.txt_TipoDocumento.TabIndex = 12
        '
        'txt_Posicion
        '
        Me.txt_Posicion.Enabled = False
        Me.txt_Posicion.Location = New System.Drawing.Point(134, 143)
        Me.txt_Posicion.Name = "txt_Posicion"
        Me.txt_Posicion.Size = New System.Drawing.Size(86, 20)
        Me.txt_Posicion.TabIndex = 13
        '
        'grid_Jugadores
        '
        Me.grid_Jugadores.AllowUserToAddRows = False
        Me.grid_Jugadores.AllowUserToDeleteRows = False
        Me.grid_Jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Jugadores.Location = New System.Drawing.Point(12, 195)
        Me.grid_Jugadores.Name = "grid_Jugadores"
        Me.grid_Jugadores.ReadOnly = True
        Me.grid_Jugadores.Size = New System.Drawing.Size(460, 181)
        Me.grid_Jugadores.TabIndex = 15
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(316, 381)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 16
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(397, 381)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancelar.TabIndex = 17
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Location = New System.Drawing.Point(12, 382)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Limpiar.TabIndex = 18
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'cmb_Estado
        '
        Me.cmb_Estado._descripcion = "descripcion"
        Me.cmb_Estado._nombreTabla = "Estados"
        Me.cmb_Estado._pk = "id"
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(134, 169)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(122, 21)
        Me.cmb_Estado.TabIndex = 20
        '
        'cmb_Club
        '
        Me.cmb_Club._descripcion = "nombre"
        Me.cmb_Club._nombreTabla = "Clubes"
        Me.cmb_Club._pk = "id"
        Me.cmb_Club.FormattingEnabled = True
        Me.cmb_Club.Location = New System.Drawing.Point(134, 12)
        Me.cmb_Club.Name = "cmb_Club"
        Me.cmb_Club.Size = New System.Drawing.Size(182, 21)
        Me.cmb_Club.TabIndex = 19
        '
        'PRO_RegistrarEstadoJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 413)
        Me.Controls.Add(Me.cmb_Estado)
        Me.Controls.Add(Me.cmb_Club)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.grid_Jugadores)
        Me.Controls.Add(Me.txt_Posicion)
        Me.Controls.Add(Me.txt_TipoDocumento)
        Me.Controls.Add(Me.txt_NroDocumento)
        Me.Controls.Add(Me.txt_ApellidoJugador)
        Me.Controls.Add(Me.txt_NombreJugador)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.lbl_Estado)
        Me.Controls.Add(Me.lbl_Posicion)
        Me.Controls.Add(Me.lbl_Club)
        Me.Controls.Add(Me.lbl_TipoDocumento)
        Me.Controls.Add(Me.lbl_NroDocumento)
        Me.Controls.Add(Me.lbl_ApellidoJugador)
        Me.Controls.Add(Me.lbl_NombreJugador)
        Me.Name = "PRO_RegistrarEstadoJugador"
        Me.Text = "PRO_RegistrarEstadoJugador"
        CType(Me.grid_Jugadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_NombreJugador As Label
    Friend WithEvents lbl_ApellidoJugador As Label
    Friend WithEvents lbl_NroDocumento As Label
    Friend WithEvents lbl_TipoDocumento As Label
    Friend WithEvents lbl_Club As Label
    Friend WithEvents lbl_Posicion As Label
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents txt_NombreJugador As TextBox
    Friend WithEvents txt_ApellidoJugador As TextBox
    Friend WithEvents txt_NroDocumento As TextBox
    Friend WithEvents txt_TipoDocumento As TextBox
    Friend WithEvents txt_Posicion As TextBox
    Friend WithEvents grid_Jugadores As DataGridView
    Friend WithEvents cmd_Guardar As Button
    Friend WithEvents cmd_Cancelar As Button
    Friend WithEvents cmd_Limpiar As Button
    Friend WithEvents cmb_Club As ComboBoxV1
    Friend WithEvents cmb_Estado As ComboBoxV1
End Class
