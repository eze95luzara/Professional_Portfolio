Public Class Frm_Preguntas

    Dim consulta As New consulta
    Dim datosPreg As New Data.DataTable
    Dim datosResCorrecta As New Data.DataTable
    Dim datosRes As New Data.DataTable

    Dim preguntas As String
    Dim idPregunta As String
    Dim resC As String

    Dim lineaActual As Integer = 0
    Dim maskPregunta As Integer = 1
    Dim numError As Integer = 0
    Dim resultado As Integer = 0

    Dim frm As New frm_RevisarCues

    Private Sub Frm_Preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim pregunta As String = "select idPregunta, pregunta from Pregunta where idPregunta in (select top 10 idPregunta from Pregunta order by newid())"

        datosPreg = consulta.Consulta(pregunta)

        Me.siguiente()



    End Sub

    Friend Sub agregarNomCuestionario(ByVal nomCuestionario As String)

        lbl_Cuest.Text = nomCuestionario
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


        Randomize()
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
            numError = 0
            resultado += 1
            If maskPregunta = 11 Then
                MessageBox.Show("HAS FINALIZADO EL CUESTIONARIO", "¡¡Felicidades!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                frm.mostrarResultado(resultado)
                frm.Show()
                Me.Hide()

            Else
                Me.siguiente()
            End If

        Else

            MessageBox.Show("¡¡EQUIVOCADO!!", "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            numError += 1

            If numError = 3 Then

                MessageBox.Show("PARECE QUE TIENES PROBLEMAS PARA RESOLVER EL EJERCICIO, SI QUIERES VER EN QUE TE EQUIVOCAS ENTRA AL LINK DE ABAJO", "Consejo", MessageBoxButtons.OK, MessageBoxIcon.Question)
                numError = 0
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

    Private Sub LinkSiguiente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSiguiente.LinkClicked
        Me.siguiente()
    End Sub

    Private Sub LinkConsigna_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkConsigna.LinkClicked
        Process.Start("https://www.matematicasonline.es/segundoeso/mat2eso5.html")
    End Sub
End Class