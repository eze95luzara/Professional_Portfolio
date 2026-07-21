Public Class frm_editor

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        MessageBox.Show("Se agrego correctamente la pregunta con las respuestas", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim obj As Object
        Dim tipo As String = ""

        For Each obj In Me.Controls

            tipo = obj.GetType.Name

            If tipo = "TextBox" Then
                obj.Text = ""
            End If

            If tipo = "RichTextBox" Then
                obj.Text = "Por favor, recuerde que debe ser una pregunta que tenga como respuesta a una expresion numerica, entera o decimal"
            End If

            If tipo = "RadioButton" Then
                obj.Checked = False
            End If
        Next

    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
    End Sub
End Class