Public Class frm_cursos

    Dim frm As New frm_alumnoAgre

    Private Sub tp1_Click(sender As Object, e As EventArgs) Handles tp1.Click

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub

    Private Sub cmd_EliminarAlu_Click(sender As Object, e As EventArgs) Handles cmd_EliminarAlu.Click
        MessageBox.Show("El alumno se elimino exitosamente del curso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmd_AgregarAlu1_Click(sender As Object, e As EventArgs) Handles cmd_AgregarAlu1.Click
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub frm_cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tp2_Click(sender As Object, e As EventArgs) Handles tp2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_Legajo.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class