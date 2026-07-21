<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Partidos
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
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.grid_Partidos = New System.Windows.Forms.DataGridView()
        Me.cmb_Horario = New System.Windows.Forms.ComboBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Horario = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Torneo = New System.Windows.Forms.Label()
        Me.lbl_FechaTorneo = New System.Windows.Forms.Label()
        Me.cmb_FechaTorneo = New GranColo.ComboBoxV1()
        Me.cmb_Torneo = New GranColo.ComboBoxV1()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        CType(Me.grid_Partidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(463, 327)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancelar.TabIndex = 7
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(382, 327)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 6
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(93, 327)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 5
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(12, 327)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 4
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'grid_Partidos
        '
        Me.grid_Partidos.AllowUserToAddRows = False
        Me.grid_Partidos.AllowUserToDeleteRows = False
        Me.grid_Partidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Partidos.Location = New System.Drawing.Point(12, 135)
        Me.grid_Partidos.Name = "grid_Partidos"
        Me.grid_Partidos.ReadOnly = True
        Me.grid_Partidos.Size = New System.Drawing.Size(526, 174)
        Me.grid_Partidos.TabIndex = 8
        '
        'cmb_Horario
        '
        Me.cmb_Horario.FormattingEnabled = True
        Me.cmb_Horario.Location = New System.Drawing.Point(138, 108)
        Me.cmb_Horario.Name = "cmb_Horario"
        Me.cmb_Horario.Size = New System.Drawing.Size(87, 21)
        Me.cmb_Horario.TabIndex = 3
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Location = New System.Drawing.Point(138, 78)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(219, 20)
        Me.dtp_Fecha.TabIndex = 2
        '
        'lbl_Horario
        '
        Me.lbl_Horario.AutoSize = True
        Me.lbl_Horario.Location = New System.Drawing.Point(91, 111)
        Me.lbl_Horario.Name = "lbl_Horario"
        Me.lbl_Horario.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Horario.TabIndex = 16
        Me.lbl_Horario.Text = "Horario"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(95, 84)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "Fecha"
        '
        'lbl_Torneo
        '
        Me.lbl_Torneo.AutoSize = True
        Me.lbl_Torneo.Location = New System.Drawing.Point(90, 26)
        Me.lbl_Torneo.Name = "lbl_Torneo"
        Me.lbl_Torneo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Torneo.TabIndex = 14
        Me.lbl_Torneo.Text = "Torneo"
        '
        'lbl_FechaTorneo
        '
        Me.lbl_FechaTorneo.AutoSize = True
        Me.lbl_FechaTorneo.Location = New System.Drawing.Point(41, 54)
        Me.lbl_FechaTorneo.Name = "lbl_FechaTorneo"
        Me.lbl_FechaTorneo.Size = New System.Drawing.Size(91, 13)
        Me.lbl_FechaTorneo.TabIndex = 13
        Me.lbl_FechaTorneo.Text = "Fecha del Torneo"
        '
        'cmb_FechaTorneo
        '
        Me.cmb_FechaTorneo._descripcion = "nro"
        Me.cmb_FechaTorneo._nombreTabla = "Fechas"
        Me.cmb_FechaTorneo._pk = "nro"
        Me.cmb_FechaTorneo.FormattingEnabled = True
        Me.cmb_FechaTorneo.Location = New System.Drawing.Point(138, 51)
        Me.cmb_FechaTorneo.Name = "cmb_FechaTorneo"
        Me.cmb_FechaTorneo.Size = New System.Drawing.Size(51, 21)
        Me.cmb_FechaTorneo.TabIndex = 1
        '
        'cmb_Torneo
        '
        Me.cmb_Torneo._descripcion = "nombre"
        Me.cmb_Torneo._nombreTabla = "Torneos"
        Me.cmb_Torneo._pk = "id"
        Me.cmb_Torneo.FormattingEnabled = True
        Me.cmb_Torneo.Location = New System.Drawing.Point(138, 26)
        Me.cmb_Torneo.Name = "cmb_Torneo"
        Me.cmb_Torneo.Size = New System.Drawing.Size(283, 21)
        Me.cmb_Torneo.TabIndex = 0
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Location = New System.Drawing.Point(427, 26)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Buscar.TabIndex = 17
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'ABM_Partidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 361)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.cmb_FechaTorneo)
        Me.Controls.Add(Me.cmb_Torneo)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.grid_Partidos)
        Me.Controls.Add(Me.cmb_Horario)
        Me.Controls.Add(Me.dtp_Fecha)
        Me.Controls.Add(Me.lbl_Horario)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Torneo)
        Me.Controls.Add(Me.lbl_FechaTorneo)
        Me.Name = "ABM_Partidos"
        Me.Text = "ABM Partidos"
        CType(Me.grid_Partidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Cancelar As Button
    Friend WithEvents cmd_Guardar As Button
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents grid_Partidos As DataGridView
    Friend WithEvents cmb_Horario As ComboBox
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents lbl_Horario As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Torneo As Label
    Friend WithEvents lbl_FechaTorneo As Label
    Friend WithEvents cmb_Torneo As ComboBoxV1
    Friend WithEvents cmb_FechaTorneo As ComboBoxV1
    Friend WithEvents cmd_Buscar As Button
End Class
