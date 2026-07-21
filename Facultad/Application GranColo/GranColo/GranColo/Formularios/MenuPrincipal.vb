Public Class MenuPrincipal
    Private Sub JugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugadoresToolStripMenuItem.Click
        Dim abmJugadores As New ABM_Jugadores
        abmJugadores.Show()

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim abmUsuarios As New ABM_Usuarios
        abmUsuarios.Show()

    End Sub

    Private Sub ClubesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClubesToolStripMenuItem.Click
        Dim abmClubes As New ABM_Clubes
        abmClubes.show()
    End Sub

    Private Sub TorneosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TorneosToolStripMenuItem.Click
        Dim abmTorneos As New ABM_Torneos
        abmTorneos.Show()
    End Sub

    Private Sub PosicionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PosicionesToolStripMenuItem.Click
        Dim abmPosiciones As New ABM_Posiciones
        abmPosiciones.Show()

    End Sub

    Private Sub FechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasToolStripMenuItem.Click
        Dim abmFechas As New ABM_Fechas
        abmFechas.Show()
    End Sub

    Private Sub EquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquiposToolStripMenuItem.Click
        Dim abmEquipos As New ABM_Equipos
        abmEquipos.Show()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click
        Dim abmEstados As New ABM_Estados
        abmEstados.Show()
    End Sub

    Private Sub PartidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartidosToolStripMenuItem.Click
        Dim abmPartidos As New ABM_Partidos
        abmPartidos.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub RegistrarEstadoDeJugadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEstadoDeJugadorToolStripMenuItem.Click
        Dim proRegistrarJugador As New PRO_RegistrarEstadoJugador
        proRegistrarJugador.Show()
    End Sub

    Private Sub CargarPuntajeAJugadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarPuntajeAJugadorToolStripMenuItem.Click

    End Sub
End Class
