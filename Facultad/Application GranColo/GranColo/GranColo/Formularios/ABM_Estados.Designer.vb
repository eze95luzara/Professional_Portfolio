<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Estados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.MaskedTextBox()
        Me.grid_Estados = New System.Windows.Forms.DataGridView()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        CType(Me.grid_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(103, 62)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(195, 20)
        Me.txt_Descripcion.TabIndex = 1
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(103, 36)
        Me.txt_Nombre.Mask = "LLL"
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_Nombre.Size = New System.Drawing.Size(33, 20)
        Me.txt_Nombre.TabIndex = 0
        '
        'grid_Estados
        '
        Me.grid_Estados.AllowUserToAddRows = False
        Me.grid_Estados.AllowUserToDeleteRows = False
        Me.grid_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Estados.Location = New System.Drawing.Point(12, 104)
        Me.grid_Estados.Name = "grid_Estados"
        Me.grid_Estados.ReadOnly = True
        Me.grid_Estados.Size = New System.Drawing.Size(383, 172)
        Me.grid_Estados.TabIndex = 6
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(13, 287)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 2
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Location = New System.Drawing.Point(94, 287)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Eliminar.TabIndex = 3
        Me.cmd_Eliminar.Text = "Eliminar"
        Me.cmd_Eliminar.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Location = New System.Drawing.Point(239, 287)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Guardar.TabIndex = 4
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(320, 287)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancelar.TabIndex = 5
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'ABM_Estados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 323)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.cmd_Eliminar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.grid_Estados)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Descripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Estados"
        Me.Text = "ABM Estados"
        CType(Me.grid_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Descripcion As TextBox
    Friend WithEvents txt_Nombre As MaskedTextBox
    Friend WithEvents grid_Estados As DataGridView
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Eliminar As Button
    Friend WithEvents cmd_Guardar As Button
    Friend WithEvents cmd_Cancelar As Button
End Class
