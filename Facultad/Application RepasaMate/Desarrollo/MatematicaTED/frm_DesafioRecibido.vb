Public Class frm_DesafioRecibidos

    Dim cuestionario As String
    Dim user As String
    Dim alumno As String

    Friend Sub obtenerUsuario(ByVal usuario As String)
        user = usuario
    End Sub


    Private Sub cmd_Volver_Click(sender As Object, e As EventArgs) Handles cmd_Volver.Click
        Me.Hide()
    End Sub



    Private Sub frm_DesafioRecibidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_Comenzar_Click(sender As Object, e As EventArgs) Handles cmd_Comenzar.Click

        alumno = lbl_Emi.Text
        cuestionario = lbl_Cuest.Text

        Dim frm As New Frm_PreguntasDsf
        frm.asignarCuestionario(cuestionario)
        frm.guardarUsuarios(user, alumno)
        frm.Show()
        Me.Hide()
    End Sub

End Class