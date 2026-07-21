Public Class frm_desafio

    Dim user As String
    Dim cuestionario As String
    Dim consulta As New consulta
    Dim alumno As String

    Private Sub cmd_Volver_Click(sender As Object, e As EventArgs) Handles cmd_Volver.Click
        Me.Hide()
    End Sub

    Private Function validar() As Boolean

        If cmb_Cuestionario.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir algun CUESTIONARIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cmb_Alumnos.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir al ALUMNO con que hara el desafio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef nombreTabla As String, ByRef nro As String, ByRef descripcion As String)

        Dim sql As String = "select * from " & nombreTabla

        combo.DataSource = consulta.Consulta(sql)
        combo.DisplayMember = descripcion
        combo.ValueMember = nro
        combo.SelectedIndex = -1
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef nro As String, ByRef descripcion As String)

        Dim sql As String = "select idUsuario, nombreUsuario from Usuario where idRol = 2"

        combo.DataSource = consulta.Consulta(sql)
        combo.DisplayMember = descripcion
        combo.ValueMember = nro
        combo.SelectedIndex = -1
    End Sub

    Private Sub cmd_Confirmar_Click(sender As Object, e As EventArgs) Handles cmd_Confirmar.Click
        Dim frm As New Frm_PreguntasDsf
        Dim sql As String
        Dim tabla As New DataTable

        If validar() = True Then

            sql = "select descripcion from Categoria where idCategoria = " & cmb_Cuestionario.SelectedValue
            tabla = consulta.Consulta(sql)
            cuestionario = tabla.Rows(0)(0)

            sql = "select nombreUsuario from Usuario where idUsuario = " & cmb_Alumnos.SelectedValue
            tabla = consulta.Consulta(sql)
            alumno = tabla.Rows(0)(0)


            frm.asignarCuestionario(cuestionario)
            frm.guardarUsuarios(user, alumno)
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Friend Sub obtenerUsusario(ByVal usuario As String)
        user = usuario
    End Sub

    Private Sub frm_desafio_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarCombo(cmb_Cuestionario, "Categoria", "idCategoria", "descripcion")
        cargarCombo(cmb_Alumnos, "idUsuario", "nombreUsuario")
    End Sub
End Class