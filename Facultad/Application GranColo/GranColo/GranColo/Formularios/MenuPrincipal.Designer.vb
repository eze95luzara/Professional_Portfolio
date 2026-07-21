<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.menu_MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClubesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TorneosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarPuntajeAJugadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarEstadoDeJugadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarJugadorEnEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferirJugadorAUnClubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MejoresEquiposDeUnaFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MejoresEquiposDeUnTorneoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugadoresSuspendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugadoresLesionadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugadoresQueSuperanLaMediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntajePromedioDeUnaFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntajePromedioDeUnTorneoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorcentajeDeJugadoresSuspendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorcentajeDeJugadoresLesionadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menu_MenuPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu_MenuPrincipal
        '
        Me.menu_MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.EstadísticasToolStripMenuItem})
        Me.menu_MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menu_MenuPrincipal.Name = "menu_MenuPrincipal"
        Me.menu_MenuPrincipal.Size = New System.Drawing.Size(570, 24)
        Me.menu_MenuPrincipal.TabIndex = 0
        Me.menu_MenuPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMOToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ABMOToolStripMenuItem
        '
        Me.ABMOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClubesToolStripMenuItem, Me.JugadoresToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.PosicionesToolStripMenuItem, Me.FechasToolStripMenuItem, Me.PartidosToolStripMenuItem, Me.EstadosToolStripMenuItem, Me.TorneosToolStripMenuItem})
        Me.ABMOToolStripMenuItem.Name = "ABMOToolStripMenuItem"
        Me.ABMOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ABMOToolStripMenuItem.Text = "ABM"
        '
        'ClubesToolStripMenuItem
        '
        Me.ClubesToolStripMenuItem.Name = "ClubesToolStripMenuItem"
        Me.ClubesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClubesToolStripMenuItem.Text = "Clubes"
        '
        'JugadoresToolStripMenuItem
        '
        Me.JugadoresToolStripMenuItem.Name = "JugadoresToolStripMenuItem"
        Me.JugadoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JugadoresToolStripMenuItem.Text = "Jugadores"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'PosicionesToolStripMenuItem
        '
        Me.PosicionesToolStripMenuItem.Name = "PosicionesToolStripMenuItem"
        Me.PosicionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PosicionesToolStripMenuItem.Text = "Posiciones"
        '
        'FechasToolStripMenuItem
        '
        Me.FechasToolStripMenuItem.Name = "FechasToolStripMenuItem"
        Me.FechasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FechasToolStripMenuItem.Text = "Fechas"
        '
        'PartidosToolStripMenuItem
        '
        Me.PartidosToolStripMenuItem.Name = "PartidosToolStripMenuItem"
        Me.PartidosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PartidosToolStripMenuItem.Text = "Partidos"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'TorneosToolStripMenuItem
        '
        Me.TorneosToolStripMenuItem.Name = "TorneosToolStripMenuItem"
        Me.TorneosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TorneosToolStripMenuItem.Text = "Torneos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarPuntajeAJugadorToolStripMenuItem, Me.RegistrarEstadoDeJugadorToolStripMenuItem, Me.RegistrarJugadorEnEquipoToolStripMenuItem, Me.TransferirJugadorAUnClubToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'CargarPuntajeAJugadorToolStripMenuItem
        '
        Me.CargarPuntajeAJugadorToolStripMenuItem.Name = "CargarPuntajeAJugadorToolStripMenuItem"
        Me.CargarPuntajeAJugadorToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.CargarPuntajeAJugadorToolStripMenuItem.Text = "Cargar puntaje a jugadores de un club"
        '
        'RegistrarEstadoDeJugadorToolStripMenuItem
        '
        Me.RegistrarEstadoDeJugadorToolStripMenuItem.Name = "RegistrarEstadoDeJugadorToolStripMenuItem"
        Me.RegistrarEstadoDeJugadorToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.RegistrarEstadoDeJugadorToolStripMenuItem.Text = "Registrar estado de jugador"
        '
        'RegistrarJugadorEnEquipoToolStripMenuItem
        '
        Me.RegistrarJugadorEnEquipoToolStripMenuItem.Name = "RegistrarJugadorEnEquipoToolStripMenuItem"
        Me.RegistrarJugadorEnEquipoToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.RegistrarJugadorEnEquipoToolStripMenuItem.Text = "Registrar jugadores en equipo"
        '
        'TransferirJugadorAUnClubToolStripMenuItem
        '
        Me.TransferirJugadorAUnClubToolStripMenuItem.Name = "TransferirJugadorAUnClubToolStripMenuItem"
        Me.TransferirJugadorAUnClubToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.TransferirJugadorAUnClubToolStripMenuItem.Text = "Transferir jugador a un club"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MejoresEquiposDeUnaFechaToolStripMenuItem, Me.MejoresEquiposDeUnTorneoToolStripMenuItem, Me.JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem, Me.JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem, Me.JugadoresSuspendidosToolStripMenuItem, Me.JugadoresLesionadosToolStripMenuItem, Me.JugadoresQueSuperanLaMediaToolStripMenuItem, Me.PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MejoresEquiposDeUnaFechaToolStripMenuItem
        '
        Me.MejoresEquiposDeUnaFechaToolStripMenuItem.Name = "MejoresEquiposDeUnaFechaToolStripMenuItem"
        Me.MejoresEquiposDeUnaFechaToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.MejoresEquiposDeUnaFechaToolStripMenuItem.Text = "Mejores equipos de una fecha"
        '
        'MejoresEquiposDeUnTorneoToolStripMenuItem
        '
        Me.MejoresEquiposDeUnTorneoToolStripMenuItem.Name = "MejoresEquiposDeUnTorneoToolStripMenuItem"
        Me.MejoresEquiposDeUnTorneoToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.MejoresEquiposDeUnTorneoToolStripMenuItem.Text = "Mejores equipos de un torneo"
        '
        'JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem
        '
        Me.JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem.Name = "JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem"
        Me.JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem.Text = "Jugadores con mayor puntaje de una fecha"
        '
        'JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem
        '
        Me.JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem.Name = "JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem"
        Me.JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem.Text = "Jugadores con mayor puntaje de un torneo"
        '
        'JugadoresSuspendidosToolStripMenuItem
        '
        Me.JugadoresSuspendidosToolStripMenuItem.Name = "JugadoresSuspendidosToolStripMenuItem"
        Me.JugadoresSuspendidosToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.JugadoresSuspendidosToolStripMenuItem.Text = "Jugadores suspendidos"
        '
        'JugadoresLesionadosToolStripMenuItem
        '
        Me.JugadoresLesionadosToolStripMenuItem.Name = "JugadoresLesionadosToolStripMenuItem"
        Me.JugadoresLesionadosToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.JugadoresLesionadosToolStripMenuItem.Text = "Jugadores lesionados"
        '
        'JugadoresQueSuperanLaMediaToolStripMenuItem
        '
        Me.JugadoresQueSuperanLaMediaToolStripMenuItem.Name = "JugadoresQueSuperanLaMediaToolStripMenuItem"
        Me.JugadoresQueSuperanLaMediaToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.JugadoresQueSuperanLaMediaToolStripMenuItem.Text = "jugadores que superan la media"
        '
        'PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem
        '
        Me.PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem.Name = "PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem"
        Me.PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem.Text = "Puntaje de jugadores de un equipo en una fecha"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem, Me.PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem, Me.PuntajePromedioDeUnaFechaToolStripMenuItem, Me.PuntajePromedioDeUnTorneoToolStripMenuItem, Me.PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem, Me.PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem, Me.PorcentajeDeJugadoresSuspendidosToolStripMenuItem, Me.PorcentajeDeJugadoresLesionadosToolStripMenuItem})
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem
        '
        Me.PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem.Name = "PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem"
        Me.PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem.Text = "Puntaje promedio de un equipo por fecha"
        '
        'PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem
        '
        Me.PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem.Name = "PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem"
        Me.PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem.Text = "Puntaje promedio de un equipo por torneo"
        '
        'PuntajePromedioDeUnaFechaToolStripMenuItem
        '
        Me.PuntajePromedioDeUnaFechaToolStripMenuItem.Name = "PuntajePromedioDeUnaFechaToolStripMenuItem"
        Me.PuntajePromedioDeUnaFechaToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PuntajePromedioDeUnaFechaToolStripMenuItem.Text = "Puntaje promedio de una fecha"
        '
        'PuntajePromedioDeUnTorneoToolStripMenuItem
        '
        Me.PuntajePromedioDeUnTorneoToolStripMenuItem.Name = "PuntajePromedioDeUnTorneoToolStripMenuItem"
        Me.PuntajePromedioDeUnTorneoToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PuntajePromedioDeUnTorneoToolStripMenuItem.Text = "Puntaje promedio de un torneo"
        '
        'PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem
        '
        Me.PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem.Name = "PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem"
        Me.PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem.Text = "Puntaje promedio de un jugador por torneo"
        '
        'PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem
        '
        Me.PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem.Name = "PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem"
        Me.PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem.Text = "Puntaje promedio de un jugador en el torneo actual"
        '
        'PorcentajeDeJugadoresSuspendidosToolStripMenuItem
        '
        Me.PorcentajeDeJugadoresSuspendidosToolStripMenuItem.Name = "PorcentajeDeJugadoresSuspendidosToolStripMenuItem"
        Me.PorcentajeDeJugadoresSuspendidosToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PorcentajeDeJugadoresSuspendidosToolStripMenuItem.Text = "Porcentaje de jugadores suspendidos"
        '
        'PorcentajeDeJugadoresLesionadosToolStripMenuItem
        '
        Me.PorcentajeDeJugadoresLesionadosToolStripMenuItem.Name = "PorcentajeDeJugadoresLesionadosToolStripMenuItem"
        Me.PorcentajeDeJugadoresLesionadosToolStripMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PorcentajeDeJugadoresLesionadosToolStripMenuItem.Text = "Porcentaje de jugadores lesionados"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(79, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(386, 228)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 257)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.menu_MenuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.menu_MenuPrincipal
        Me.Name = "MenuPrincipal"
        Me.Text = "Gran Colo - Menú Principal"
        Me.menu_MenuPrincipal.ResumeLayout(False)
        Me.menu_MenuPrincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_MenuPrincipal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClubesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PosicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TorneosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarPuntajeAJugadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarEstadoDeJugadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarJugadorEnEquipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferirJugadorAUnClubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejoresEquiposDeUnaFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejoresEquiposDeUnTorneoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresConMayorPuntajeDeUnaFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresConMayorPuntajeDeUnTorneoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresSuspendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresLesionadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresQueSuperanLaMediaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntajeDeJugadoresDeUnEquipoEnUnaFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntajePromedioDeUnEquipoPorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntajePromedioDeUnEquipoPorTorneoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntajePromedioDeUnaFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntajePromedioDeUnTorneoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntajePromedioDeUnJugadorPorTorneoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntajePromedioDeUnJugadorEnUnTorneoHastaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorcentajeDeJugadoresSuspendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorcentajeDeJugadoresLesionadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
