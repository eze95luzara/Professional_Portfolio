Public Class frm_login
    Dim consulta As New consulta
    Dim usuario As String
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Function validar() As Boolean
        Dim datosUser As New Data.DataTable
        Dim contraseña As String

        txt_usuario.BackColor = Color.FromArgb(255, 192, 128)
        txt_contraseña.BackColor = Color.FromArgb(255, 192, 128)
        Try
            Dim comando As String = "select nombreUsuario, contraseña from Usuario where nombreUsuario = '" + txt_usuario.Text + "'"
            datosUser = consulta.Consulta(comando)
            contraseña = datosUser.Rows(0).Item(1).ToString
            usuario = datosUser.Rows(0).Item(0).ToString

            If txt_usuario.Text <> usuario Then
                MessageBox.Show("Usuario erroneo", "Intente de nuevo")
                txt_usuario.BackColor = Color.OrangeRed
                txt_usuario.Clear()
                Return False
            End If
           
            If txt_contraseña.Text <> contraseña Then
                MessageBox.Show("Contraseña equivocada", "Intente de nuevo")
                txt_contraseña.BackColor = Color.Salmon
                txt_contraseña.Clear()
                Return False
            Else
                MessageBox.Show("Exito", "Bienvenido")
                txt_usuario.BackColor = Color.FromArgb(255, 192, 128)
                txt_contraseña.BackColor = Color.FromArgb(255, 192, 128)
                txt_usuario.Text = ""
                txt_contraseña.Text = ""
                Return True
            End If
        Catch ex As Exception
        End Try
        txt_usuario.BackColor = Color.Salmon
        Return False
    End Function

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click


        Dim datosUser As New Data.DataTable
        Dim rols As Integer
        Dim rol As String = "select idRol from Usuario where nombreUsuario = '" + txt_usuario.Text + "'"

        If validar() = True Then
            datosUser = consulta.Consulta(rol)
            rols = datosUser.Rows(0).Item(0).ToString

            If rols = 1 Then
                Dim frm As New frm_docente
                frm.mostrarNomUsuario(usuario)
                frm.Show()
                Me.Hide()
            End If

            If rols = 2 Then
                Dim frm As New frm_alumno
                frm.mostrarNomUsuario(usuario)
                frm.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_fecha.Text = Date.Today.Day.ToString + "/" + Date.Today.Month.ToString + "/" + Date.Today.Year.ToString
    End Sub

End Class

