Public Class frm_alumno

    Dim user As String

    Friend Sub mostrarNomUsuario(ByVal nombreUsuario As String)
        Me.lbl_NomUser.Text = nombreUsuario
        user = nombreUsuario
    End Sub


    Private Sub cmd_Cuestionario_Click(sender As Object, e As EventArgs) Handles cmd_Cuestionario.Click
        Dim frm As New frm_verCues
        frm.Show()
    End Sub

    Private Sub cmd_Desafio_Click(sender As Object, e As EventArgs) Handles cmd_Desafio.Click
        Dim frm As New frm_desafio
        frm.obtenerUsusario(user)
        frm.Show()
    End Sub

    Private Sub cmd_Estadisticas_Click(sender As Object, e As EventArgs) Handles cmd_Estadisticas.Click
        '    Dim frm As New frm_estAlumno
        '    frm.Show()
    End Sub

    Private Sub cmd_CerrSes_Click(sender As Object, e As EventArgs) Handles cmd_CerrSes.Click
        Dim frm As New frm_login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Bandeja_Click(sender As Object, e As EventArgs) Handles cmd_Bandeja.Click
        Dim frm As New frm_DesafioRecibidos
        frm.obtenerUsuario(user)
        frm.Show()
    End Sub
End Class