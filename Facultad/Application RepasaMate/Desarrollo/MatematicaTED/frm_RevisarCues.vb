Public Class frm_RevisarCues
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.matematicasonline.es/segundoeso/mat2eso5.html")
    End Sub

    Friend Sub mostrarResultado(ByVal resultado As Integer)
        lbl_NotaFin.Text = "Nota Final: " & resultado
        lbl_PregCorr.Text = "Preguntas Correctas: " & resultado & " de 10"
    End Sub

    Private Sub cmd_Volver_Click(sender As Object, e As EventArgs) Handles cmd_Volver.Click
        Dim frm As New frm_verCues
        Me.Hide()
        frm.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class