Public Class frm_alumnoAgre
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged

    End Sub

    Private Sub lbl_Nombre_Click(sender As Object, e As EventArgs) Handles lbl_Nombre.Click

    End Sub

    Private Sub lbl_Legajo_Click(sender As Object, e As EventArgs) Handles lbl_Legajo.Click

    End Sub

    Private Sub txt_Legajo_TextChanged(sender As Object, e As EventArgs) Handles txt_Legajo.TextChanged

    End Sub

    Private Sub lbl_Apellido_Click(sender As Object, e As EventArgs) Handles lbl_Apellido.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Cmd_Volver_Click(sender As Object, e As EventArgs) Handles Cmd_Volver.Click
        Dim frm As New frm_cursos
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub Cmd_Agregar_Click(sender As Object, e As EventArgs) Handles Cmd_Agregar.Click


        If validar() = True Then

            MessageBox.Show("El Alumno se agrego exitosamente al Curso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_Legajo.Text = " "
            txt_apellido.Text = " "
            txt_nombre.Text = " "
            txt_curso.Text = " "

        End If



    End Sub

    Private Function validar() As Boolean


        If txt_Legajo.Text = "" Then
            MessageBox.Show("Falta Ingresar el legajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Legajo.Focus()
            Return False
        End If


        If txt_nombre.Text = "" Then
            MessageBox.Show("Falta Ingresar el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nombre.Focus()
            Return False
        End If


        If txt_apellido.Text = "" Then
            MessageBox.Show("Falta Ingresar el apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_apellido.Focus()
            Return False
        End If


        If txt_curso.Text = "" Then
            MessageBox.Show("Falta Ingresar el curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_curso.Focus()
            Return False
        End If

        Return True

    End Function
End Class