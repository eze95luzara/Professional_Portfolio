<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Fechas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_Torneo = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.grid_Datos = New System.Windows.Forms.DataGridView()
        Me.col_Torneo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_NroFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.cmb_Torneo = New System.Windows.Forms.ComboBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        CType(Me.grid_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Torneo
        '
        Me.lbl_Torneo.AutoSize = True
        Me.lbl_Torneo.Location = New System.Drawing.Point(131, 32)
        Me.lbl_Torneo.Name = "lbl_Torneo"
        Me.lbl_Torneo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Torneo.TabIndex = 1
        Me.lbl_Torneo.Text = "Torneo"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(34, 56)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(138, 13)
        Me.lbl_Hasta.TabIndex = 3
        Me.lbl_Hasta.Text = "Fecha de inicio de la Fecha"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Location = New System.Drawing.Point(178, 56)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(210, 20)
        Me.dtp_Desde.TabIndex = 9
        '
        'grid_Datos
        '
        Me.grid_Datos.AllowUserToAddRows = False
        Me.grid_Datos.AllowUserToDeleteRows = False
        Me.grid_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Torneo, Me.col_NroFecha, Me.col_FechaInicio})
        Me.grid_Datos.Location = New System.Drawing.Point(12, 100)
        Me.grid_Datos.Name = "grid_Datos"
        Me.grid_Datos.ReadOnly = True
        Me.grid_Datos.Size = New System.Drawing.Size(629, 234)
        Me.grid_Datos.TabIndex = 10
        '
        'col_Torneo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_Torneo.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_Torneo.HeaderText = "Nombre Torneo"
        Me.col_Torneo.Name = "col_Torneo"
        Me.col_Torneo.ReadOnly = True
        Me.col_Torneo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Torneo.Width = 150
        '
        'col_NroFecha
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_NroFecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_NroFecha.HeaderText = "Numero de Fecha"
        Me.col_NroFecha.Name = "col_NroFecha"
        Me.col_NroFecha.ReadOnly = True
        Me.col_NroFecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_NroFecha.Width = 150
        '
        'col_FechaInicio
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_FechaInicio.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_FechaInicio.HeaderText = "Fecha de Inicio"
        Me.col_FechaInicio.Name = "col_FechaInicio"
        Me.col_FechaInicio.ReadOnly = True
        Me.col_FechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_FechaInicio.Width = 150
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(12, 340)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 25)
        Me.cmd_Nuevo.TabIndex = 11
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(469, 340)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 25)
        Me.cmd_Guardar.TabIndex = 12
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(566, 340)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 25)
        Me.cmd_Cancelar.TabIndex = 13
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(107, 342)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 14
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'cmb_Torneo
        '
        Me.cmb_Torneo.FormattingEnabled = True
        Me.cmb_Torneo.Location = New System.Drawing.Point(178, 29)
        Me.cmb_Torneo.Name = "cmb_Torneo"
        Me.cmb_Torneo.Size = New System.Drawing.Size(340, 21)
        Me.cmb_Torneo.TabIndex = 15
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(524, 27)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 16
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'ABM_Fechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 378)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmb_Torneo)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.grid_Datos)
        Me.Controls.Add(Me.dtp_Desde)
        Me.Controls.Add(Me.lbl_Hasta)
        Me.Controls.Add(Me.lbl_Torneo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ABM_Fechas"
        Me.Text = "ABM Fechas"
        CType(Me.grid_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Torneo As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents grid_Datos As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents cmb_Torneo As ComboBox
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents col_Torneo As DataGridViewTextBoxColumn
    Friend WithEvents col_NroFecha As DataGridViewTextBoxColumn
    Friend WithEvents col_FechaInicio As DataGridViewTextBoxColumn
End Class
