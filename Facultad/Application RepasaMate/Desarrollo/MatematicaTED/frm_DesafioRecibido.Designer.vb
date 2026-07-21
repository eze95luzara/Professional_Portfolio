<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DesafioRecibidos
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Vega, Rodrigo      "}, -1, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), Nothing)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Diaz, Luca            "}, -1, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), Nothing)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Castillo, michel     "}, -1, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), Nothing)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DesafioRecibidos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Emisor = New System.Windows.Forms.Label()
        Me.lbl_Cuestionario = New System.Windows.Forms.Label()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.lbl_Msj = New System.Windows.Forms.Label()
        Me.lbl_Emi = New System.Windows.Forms.Label()
        Me.lbl_Cuest = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.cmd_Comenzar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(221, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bandeja de Desafios"
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(67, 352)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(101, 61)
        Me.cmd_Volver.TabIndex = 1
        Me.cmd_Volver.Text = "volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(36, 146)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(172, 156)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(347, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desafio Seleccionado:"
        '
        'lbl_Emisor
        '
        Me.lbl_Emisor.AutoSize = True
        Me.lbl_Emisor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Emisor.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emisor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Emisor.Location = New System.Drawing.Point(295, 170)
        Me.lbl_Emisor.Name = "lbl_Emisor"
        Me.lbl_Emisor.Size = New System.Drawing.Size(124, 20)
        Me.lbl_Emisor.TabIndex = 4
        Me.lbl_Emisor.Text = "Enviado por:"
        '
        'lbl_Cuestionario
        '
        Me.lbl_Cuestionario.AutoSize = True
        Me.lbl_Cuestionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cuestionario.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuestionario.Location = New System.Drawing.Point(295, 199)
        Me.lbl_Cuestionario.Name = "lbl_Cuestionario"
        Me.lbl_Cuestionario.Size = New System.Drawing.Size(206, 20)
        Me.lbl_Cuestionario.TabIndex = 5
        Me.lbl_Cuestionario.Text = "Cuestionario Elegido:"
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Mensaje.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mensaje.Location = New System.Drawing.Point(295, 234)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(92, 20)
        Me.lbl_Mensaje.TabIndex = 6
        Me.lbl_Mensaje.Text = "Mensaje:"
        '
        'lbl_Msj
        '
        Me.lbl_Msj.AutoSize = True
        Me.lbl_Msj.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Msj.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msj.Location = New System.Drawing.Point(296, 264)
        Me.lbl_Msj.Name = "lbl_Msj"
        Me.lbl_Msj.Size = New System.Drawing.Size(466, 20)
        Me.lbl_Msj.TabIndex = 7
        Me.lbl_Msj.Text = "Hola! Necesito ponerme a prueba con este cuestionario"
        '
        'lbl_Emi
        '
        Me.lbl_Emi.AutoSize = True
        Me.lbl_Emi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Emi.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Emi.Location = New System.Drawing.Point(425, 170)
        Me.lbl_Emi.Name = "lbl_Emi"
        Me.lbl_Emi.Size = New System.Drawing.Size(105, 20)
        Me.lbl_Emi.TabIndex = 8
        Me.lbl_Emi.Text = "rodrigovega"
        '
        'lbl_Cuest
        '
        Me.lbl_Cuest.AutoSize = True
        Me.lbl_Cuest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cuest.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuest.Location = New System.Drawing.Point(500, 199)
        Me.lbl_Cuest.Name = "lbl_Cuest"
        Me.lbl_Cuest.Size = New System.Drawing.Size(123, 20)
        Me.lbl_Cuest.TabIndex = 9
        Me.lbl_Cuest.Text = "Ley de Signos"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(187, 146)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 138)
        Me.VScrollBar1.TabIndex = 10
        '
        'cmd_Comenzar
        '
        Me.cmd_Comenzar.Location = New System.Drawing.Point(608, 352)
        Me.cmd_Comenzar.Name = "cmd_Comenzar"
        Me.cmd_Comenzar.Size = New System.Drawing.Size(101, 61)
        Me.cmd_Comenzar.TabIndex = 11
        Me.cmd_Comenzar.Text = "Comenzar"
        Me.cmd_Comenzar.UseVisualStyleBackColor = True
        '
        'frm_DesafioRecibidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(774, 454)
        Me.Controls.Add(Me.cmd_Comenzar)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.lbl_Cuest)
        Me.Controls.Add(Me.lbl_Emi)
        Me.Controls.Add(Me.lbl_Msj)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.lbl_Cuestionario)
        Me.Controls.Add(Me.lbl_Emisor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_DesafioRecibidos"
        Me.Text = "RepasaMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_Volver As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Emisor As Label
    Friend WithEvents lbl_Cuestionario As Label
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents lbl_Msj As Label
    Friend WithEvents lbl_Emi As Label
    Friend WithEvents lbl_Cuest As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents cmd_Comenzar As Button
End Class
