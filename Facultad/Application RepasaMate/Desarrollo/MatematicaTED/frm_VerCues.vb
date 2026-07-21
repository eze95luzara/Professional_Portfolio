Public Class frm_verCues
    Private Sub frm_verCues_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub cmd_Volver_Click(sender As Object, e As EventArgs) Handles cmd_Volver.Click
        Me.Hide()
    End Sub

    Private Sub cmd_Confirmar_Click(sender As Object, e As EventArgs) Handles cmd_RealizarCues.Click
        Dim frm As New Frm_Categoria
        Me.Hide()
        frm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_RevisarCues.Click
        Dim frm As New frm_RevisarCues
        Me.Hide()
        frm.Show()

    End Sub

End Class