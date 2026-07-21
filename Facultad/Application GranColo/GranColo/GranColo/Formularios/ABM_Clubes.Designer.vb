<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Clubes
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
        Me.lbl_NombreClub = New System.Windows.Forms.Label()
        Me.lbl_Aforo = New System.Windows.Forms.Label()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.lbl_NombreEstadio = New System.Windows.Forms.Label()
        Me.lbl_FechaFundacion = New System.Windows.Forms.Label()
        Me.txt_NombreClub = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.txt_NombreEstadio = New System.Windows.Forms.TextBox()
        Me.dtp_FechaFundacion = New System.Windows.Forms.DateTimePicker()
        Me.grid_Club = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreClub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFundacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEstadio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aforo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.txt_Aforo = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        CType(Me.grid_Club, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NombreClub
        '
        Me.lbl_NombreClub.AutoSize = True
        Me.lbl_NombreClub.Location = New System.Drawing.Point(47, 39)
        Me.lbl_NombreClub.Name = "lbl_NombreClub"
        Me.lbl_NombreClub.Size = New System.Drawing.Size(85, 13)
        Me.lbl_NombreClub.TabIndex = 0
        Me.lbl_NombreClub.Text = "Nombre del Club"
        '
        'lbl_Aforo
        '
        Me.lbl_Aforo.AutoSize = True
        Me.lbl_Aforo.Location = New System.Drawing.Point(100, 155)
        Me.lbl_Aforo.Name = "lbl_Aforo"
        Me.lbl_Aforo.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Aforo.TabIndex = 1
        Me.lbl_Aforo.Text = "Aforo"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(80, 128)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Direccion.TabIndex = 2
        Me.lbl_Direccion.Text = "Dirección"
        '
        'lbl_NombreEstadio
        '
        Me.lbl_NombreEstadio.AutoSize = True
        Me.lbl_NombreEstadio.Location = New System.Drawing.Point(33, 98)
        Me.lbl_NombreEstadio.Name = "lbl_NombreEstadio"
        Me.lbl_NombreEstadio.Size = New System.Drawing.Size(99, 13)
        Me.lbl_NombreEstadio.TabIndex = 3
        Me.lbl_NombreEstadio.Text = "Nombre del Estadio"
        '
        'lbl_FechaFundacion
        '
        Me.lbl_FechaFundacion.AutoSize = True
        Me.lbl_FechaFundacion.Location = New System.Drawing.Point(27, 71)
        Me.lbl_FechaFundacion.Name = "lbl_FechaFundacion"
        Me.lbl_FechaFundacion.Size = New System.Drawing.Size(105, 13)
        Me.lbl_FechaFundacion.TabIndex = 4
        Me.lbl_FechaFundacion.Text = "Fecha de Fundación"
        '
        'txt_NombreClub
        '
        Me.txt_NombreClub.Location = New System.Drawing.Point(144, 38)
        Me.txt_NombreClub.Name = "txt_NombreClub"
        Me.txt_NombreClub.Size = New System.Drawing.Size(177, 20)
        Me.txt_NombreClub.TabIndex = 0
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(144, 125)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(177, 20)
        Me.txt_Direccion.TabIndex = 3
        '
        'txt_NombreEstadio
        '
        Me.txt_NombreEstadio.Location = New System.Drawing.Point(144, 95)
        Me.txt_NombreEstadio.Name = "txt_NombreEstadio"
        Me.txt_NombreEstadio.Size = New System.Drawing.Size(237, 20)
        Me.txt_NombreEstadio.TabIndex = 2
        '
        'dtp_FechaFundacion
        '
        Me.dtp_FechaFundacion.Location = New System.Drawing.Point(144, 65)
        Me.dtp_FechaFundacion.Name = "dtp_FechaFundacion"
        Me.dtp_FechaFundacion.Size = New System.Drawing.Size(237, 20)
        Me.dtp_FechaFundacion.TabIndex = 1
        '
        'grid_Club
        '
        Me.grid_Club.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Club.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombreClub, Me.fechaFundacion, Me.nombreEstadio, Me.direccion, Me.aforo})
        Me.grid_Club.Location = New System.Drawing.Point(40, 212)
        Me.grid_Club.Name = "grid_Club"
        Me.grid_Club.Size = New System.Drawing.Size(669, 178)
        Me.grid_Club.TabIndex = 9
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Width = 25
        '
        'nombreClub
        '
        Me.nombreClub.HeaderText = "Nombre del Club"
        Me.nombreClub.Name = "nombreClub"
        Me.nombreClub.Width = 125
        '
        'fechaFundacion
        '
        Me.fechaFundacion.HeaderText = "Fecha de Fundación"
        Me.fechaFundacion.Name = "fechaFundacion"
        Me.fechaFundacion.Width = 115
        '
        'nombreEstadio
        '
        Me.nombreEstadio.HeaderText = "Nombre del Estadio"
        Me.nombreEstadio.Name = "nombreEstadio"
        Me.nombreEstadio.Width = 125
        '
        'direccion
        '
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 185
        '
        'aforo
        '
        Me.aforo.HeaderText = "Aforo"
        Me.aforo.Name = "aforo"
        Me.aforo.Width = 75
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(40, 404)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 5
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(634, 404)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancelar.TabIndex = 8
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(553, 404)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 7
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'txt_Aforo
        '
        Me.txt_Aforo.Location = New System.Drawing.Point(144, 152)
        Me.txt_Aforo.Mask = "9999999999"
        Me.txt_Aforo.Name = "txt_Aforo"
        Me.txt_Aforo.Size = New System.Drawing.Size(69, 20)
        Me.txt_Aforo.TabIndex = 4
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Location = New System.Drawing.Point(121, 404)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Eliminar.TabIndex = 6
        Me.cmd_Eliminar.Text = "Eliminar"
        Me.cmd_Eliminar.UseVisualStyleBackColor = True
        '
        'ABM_Clubes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 439)
        Me.Controls.Add(Me.cmd_Eliminar)
        Me.Controls.Add(Me.txt_Aforo)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.grid_Club)
        Me.Controls.Add(Me.dtp_FechaFundacion)
        Me.Controls.Add(Me.txt_NombreEstadio)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.txt_NombreClub)
        Me.Controls.Add(Me.lbl_FechaFundacion)
        Me.Controls.Add(Me.lbl_NombreEstadio)
        Me.Controls.Add(Me.lbl_Direccion)
        Me.Controls.Add(Me.lbl_Aforo)
        Me.Controls.Add(Me.lbl_NombreClub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ABM_Clubes"
        Me.Text = "ABM Clubes"
        CType(Me.grid_Club, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NombreClub As System.Windows.Forms.Label
    Friend WithEvents lbl_Aforo As System.Windows.Forms.Label
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreEstadio As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaFundacion As System.Windows.Forms.Label
    Friend WithEvents txt_NombreClub As System.Windows.Forms.TextBox
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombreEstadio As System.Windows.Forms.TextBox
    Friend WithEvents dtp_FechaFundacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents grid_Club As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_Guardar As System.Windows.Forms.Button
    Friend WithEvents txt_Aforo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreClub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaFundacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreEstadio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aforo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_Eliminar As System.Windows.Forms.Button

End Class
