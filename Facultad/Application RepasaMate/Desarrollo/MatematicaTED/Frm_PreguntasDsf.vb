Public Class Frm_PreguntasDsf

    Dim consulta As New consulta
    Dim datosPreg As New Data.DataTable
    Dim datosResCorrecta As New Data.DataTable
    Dim datosRes As New Data.DataTable

    Dim preguntas As String
    Dim idPregunta As String
    Dim resC As String

    Dim user As String
    Dim alu As String

    Dim lineaActual As Integer = 0
    Dim maskPregunta As Integer = 1
    Dim resultado As Integer = 0

    Dim frm As New frm_DesafioFIn

    Friend Sub guardarUsuarios(ByVal usuario As String, ByVal alumno As String)
        user = usuario
        alu = alumno
    End Sub

    Friend Sub asignarCuestionario(ByVal cuestionario As String)
        lbl_Cuest.Text = cuestionario
    End Sub

    Private Sub Frm_PreguntasDsf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pregunta As String = "select idPregunta, pregunta from Pregunta where idPregunta in (select top 10 idPregunta from Pregunta order by newid())"
        datosPreg = consulta.Consulta(pregunta)
        Me.siguiente()
    End Sub

    Private Sub siguiente()

        mask_Pregunta.Text = maskPregunta

        preguntas = datosPreg.Rows(lineaActual).Item(1).ToString
        idPregunta = datosPreg.Rows(lineaActual).Item(0).ToString

        Lbl_Pregunta.Text = preguntas

        Dim respuestaCorrecta As String = "select R.respuesta from Respuesta R JOIN RespuestaCorrecta RC ON R.idRespuesta=RC.idRespuesta where RC.idPregunta=" & idPregunta

        datosResCorrecta = consulta.Consulta(respuestaCorrecta)
        resC = datosResCorrecta.Rows(0).Item(0).ToString


        Dim res1 As String
        Dim res2 As String
        Dim res3 As String
        Dim respuesta As String = "select respuesta from Respuesta where idRespuesta in (select top 3 idRespuesta from Respuesta order by newid())"

        datosRes = consulta.Consulta(respuesta)
        res1 = datosRes.Rows(0).Item(0).ToString
        res2 = datosRes.Rows(1).Item(0).ToString
        res3 = datosRes.Rows(2).Item(0).ToString


        'Dim A As Integer = (Rnd() * 4) + 1
        'Dim B As Integer = (Rnd() * 4) + 1
        'Dim C As Integer = (Rnd() * 4) + 1
        'Dim D As Integer = (Rnd() * 4) + 1

        'If A = 1 Then
        '    Cmd_Opcion1.Text = resC
        'End If
        'If A = 2 Then
        '    Cmd_Opcion2.Text = resC
        'End If
        'If A = 3 Then
        '    Cmd_Opcion3.Text = resC
        'End If
        'If A = 4 Then
        '    Cmd_Opcion4.Text = resC
        'End If


        'If B = 1 Then
        '    Cmd_Opcion1.Text = res1
        'End If
        'If B = 2 Then
        '    Cmd_Opcion2.Text = res1
        'End If
        'If B = 3 Then
        '    Cmd_Opcion3.Text = res1
        'End If
        'If B = 4 Then
        '    Cmd_Opcion4.Text = res1
        'End If


        'If C = 1 Then
        '    Cmd_Opcion1.Text = res2
        'End If
        'If C = 2 Then
        '    Cmd_Opcion2.Text = res2
        'End If
        'If C = 3 Then
        '    Cmd_Opcion3.Text = res2
        'End If
        'If C = 4 Then
        '    Cmd_Opcion4.Text = res2
        'End If


        'If D = 1 Then
        '    Cmd_Opcion1.Text = res3
        'End If
        'If D = 2 Then
        '    Cmd_Opcion2.Text = res3
        'End If
        'If D = 3 Then
        '    Cmd_Opcion3.Text = res3
        'End If
        'If D = 4 Then
        '    Cmd_Opcion4.Text = res3
        'End If



        Cmd_Opcion1.Text = resC
        Cmd_Opcion2.Text = res1
        Cmd_Opcion3.Text = res2
        Cmd_Opcion4.Text = res3

        lineaActual += 1
        maskPregunta += 1
    End Sub


    Private Sub validar(ByVal textoBoton As String)

        If textoBoton = resC Then
            MessageBox.Show("¡¡BIEN HECHO!!", "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            resultado += 1

            If maskPregunta = 11 Then

                MessageBox.Show("HAS FINALIZADO EL CUESTIONARIO", "¡¡Felicidades!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                frm.mostrarResultado(resultado)
                frm.pasarUsuarios(user, alu)
                frm.Show()
                Me.Hide()
            Else
                Me.siguiente()
            End If

        Else
            MessageBox.Show("¡¡EQUIVOCADO!!", "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)


            If maskPregunta = 11 Then

                MessageBox.Show("HAS FINALIZADO EL CUESTIONARIO", "¡¡Felicidades!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                frm.mostrarResultado(resultado)
                frm.pasarUsuarios(user, alu)
                frm.Show()
                Me.Hide()
            Else
                Me.siguiente()
            End If

        End If


    End Sub

    Private Sub Cmd_Opcion1_Click(sender As Object, e As EventArgs) Handles Cmd_Opcion1.Click
        Me.validar(Me.Cmd_Opcion1.Text)
    End Sub

    Private Sub Cmd_Opcion2_Click(sender As Object, e As EventArgs) Handles Cmd_Opcion2.Click
        Me.validar(Me.Cmd_Opcion2.Text)
    End Sub

    Private Sub Cmd_Opcion3_Click(sender As Object, e As EventArgs) Handles Cmd_Opcion3.Click
        Me.validar(Me.Cmd_Opcion3.Text)
    End Sub

    Private Sub Cmd_Opcion4_Click(sender As Object, e As EventArgs) Handles Cmd_Opcion4.Click
        Me.validar(Me.Cmd_Opcion4.Text)
    End Sub

    Private Sub LinkSiguiente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.siguiente()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cmd_Opcion3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_Cuest_Click(sender As Object, e As EventArgs) Handles lbl_Cuest.Click

    End Sub
End Class