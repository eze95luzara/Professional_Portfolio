<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Torneos
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
        Me.lbl_NombreTorneo = New System.Windows.Forms.Label()
        Me.lbl_FechaDesde = New System.Windows.Forms.Label()
        Me.lbl_FechaHasta = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.grid_Torneos = New System.Windows.Forms.DataGridView()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        CType(Me.grid_Torneos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NombreTorneo
        '
        Me.lbl_NombreTorneo.AutoSize = True
        Me.lbl_NombreTorneo.Location = New System.Drawing.Point(53, 35)
        Me.lbl_NombreTorneo.Name = "lbl_NombreTorneo"
        Me.lbl_NombreTorneo.Size = New System.Drawing.Size(98, 13)
        Me.lbl_NombreTorneo.TabIndex = 0
        Me.lbl_NombreTorneo.Text = "Nombre del Torneo"
        '
        'lbl_FechaDesde
        '
        Me.lbl_FechaDesde.AutoSize = True
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(71, 64)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lbl_FechaDesde.TabIndex = 1
        Me.lbl_FechaDesde.Text = "Fecha de Inicio"
        '
        'lbl_FechaHasta
        '
        Me.lbl_FechaHasta.AutoSize = True
        Me.lbl_FechaHasta.Location = New System.Drawing.Point(82, 90)
        Me.lbl_FechaHasta.Name = "lbl_FechaHasta"
        Me.lbl_FechaHasta.Size = New System.Drawing.Size(69, 13)
        Me.lbl_FechaHasta.TabIndex = 2
        Me.lbl_FechaHasta.Text = "Fecha de Fin"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(157, 32)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(300, 20)
        Me.txt_Nombre.TabIndex = 3
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(157, 58)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(218, 20)
        Me.dtp_FechaDesde.TabIndex = 4
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(157, 84)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(218, 20)
        Me.dtp_FechaHasta.TabIndex = 5
        '
        'grid_Torneos
        '
        Me.grid_Torneos.AllowUserToAddRows = False
        Me.grid_Torneos.AllowUserToDeleteRows = False
        Me.grid_Torneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Torneos.Location = New System.Drawing.Point(12, 127)
        Me.grid_Torneos.Name = "grid_Torneos"
        Me.grid_Torneos.ReadOnly = True
        Me.grid_Torneos.Size = New System.Drawing.Size(458, 155)
        Me.grid_Torneos.TabIndex = 6
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(12, 288)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 7
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Location = New System.Drawing.Point(93, 288)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Eliminar.TabIndex = 8
        Me.cmd_Eliminar.Text = "Eliminar"
        Me.cmd_Eliminar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(395, 288)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancelar.TabIndex = 9
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(314, 288)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 10
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'ABM_Torneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 323)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Eliminar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.grid_Torneos)
        Me.Controls.Add(Me.dtp_FechaHasta)
        Me.Controls.Add(Me.dtp_FechaDesde)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_FechaHasta)
        Me.Controls.Add(Me.lbl_FechaDesde)
        Me.Controls.Add(Me.lbl_NombreTorneo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ABM_Torneos"
        Me.Text = "ABM Torneos"
        CType(Me.grid_Torneos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_NombreTorneo As Label
    Friend WithEvents lbl_FechaDesde As Label
    Friend WithEvents lbl_FechaHasta As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents dtp_FechaDesde As DateTimePicker
    Friend WithEvents dtp_FechaHasta As DateTimePicker
    Friend WithEvents grid_Torneos As DataGridView
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Eliminar As Button
    Friend WithEvents cmd_Cancelar As Button
    Friend WithEvents cmd_Guardar As Button
End Class
