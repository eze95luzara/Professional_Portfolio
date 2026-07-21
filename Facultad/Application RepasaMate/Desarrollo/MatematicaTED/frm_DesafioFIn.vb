Public Class frm_DesafioFIn

    Dim resultadoAlu As Integer
    Dim resultadoUser As Integer

    Friend Sub pasarUsuarios(ByVal usuario As String, ByVal alumno As String)

        resultadoAlu = (Rnd() * 10) + 1

        lbl_Usuario.Text = usuario & ":"
        lbl_alumno.Text = alumno & ":"

        lbl_Resultado1.Text = resultadoAlu

        If resultadoUser > resultadoAlu Then
            lbl_ganador.Text = "¡¡¡Felicitaciones " & usuario & "!!!"
        Else
            lbl_ganador.Text = "¡¡¡Felicitaciones " & alumno & "!!!"
        End If

    End Sub

    Private Sub cmd_Finalizar_Click(sender As Object, e As EventArgs) Handles cmd_Finalizar.Click
        Me.Hide()
    End Sub

    Friend Sub mostrarResultado(ByVal resultado As Integer)
        lbl_Resultado.Text = resultado
        resultadoUser = resultado
    End Sub

    Private Sub LinkConsigna_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkConsigna.LinkClicked
        Process.Start("https://www.matematicasonline.es/segundoeso/mat2eso5.html")
    End Sub

End Class