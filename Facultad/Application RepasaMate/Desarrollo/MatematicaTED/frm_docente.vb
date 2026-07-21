Public Class frm_docente

    Friend Sub mostrarNomUsuario(ByVal nombreUsuario As String)
        Me.lbl_NomUser.Text = nombreUsuario
    End Sub

    Private Sub cmd_Estadisticas_Click(sender As Object, e As EventArgs) Handles cmd_Estadisticas.Click
        'Dim frm As New frm_estDocente
        'frm.Show()
    End Sub

    Private Sub cmd_preguntas_Click(sender As Object, e As EventArgs) Handles cmd_preguntas.Click
        Dim frm As New frm_editor
        frm.Show()
    End Sub

    Private Sub cmd_Cuestionario_Click(sender As Object, e As EventArgs) Handles cmd_Cuestionario.Click
        Dim frm As New frm_cuestionario
        frm.Show()
    End Sub

    Private Sub cmd_Cursos_Click(sender As Object, e As EventArgs) Handles cmd_Cursos.Click
        Dim frm As New frm_cursos
        frm.Show()
    End Sub

    Private Sub cmd_CerrSes_Click(sender As Object, e As EventArgs) Handles cmd_CerrSes.Click
        Dim frm As New frm_login
        frm.Show()
        Me.Hide()
    End Sub

End Class