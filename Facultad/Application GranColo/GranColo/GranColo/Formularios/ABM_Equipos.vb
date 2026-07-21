Public Class ABM_Equipos
    Dim acceso As New AccesoDatos
    Enum estado
        modificar
        insertar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_Grilla()
    End Sub

    Private Sub cargar_Grilla()
        Dim tabla As New Data.DataTable

        tabla = acceso.leerTabla("Equipos")

        Me.grid_Equipos.Rows.Clear()

        Dim i As Integer = 0
        For i = 0 To tabla.Rows.Count() - 1
            grid_Equipos.Rows.Add()
            grid_Equipos.Rows(i).Cells(0).Value = tabla.Rows(i)(0)
            grid_Equipos.Rows(i).Cells(1).Value = tabla.Rows(i)(1)
            grid_Equipos.Rows(i).Cells(2).Value = tabla.Rows(i)(2)
            grid_Equipos.Rows(i).Cells(3).Value = tabla.Rows(i)(3)
        Next

    End Sub


    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        txt_NombreEquipo.Enabled = True
        txt_NombreEquipo.Text = ""
        txt_Lema.Text = ""
        txt_Color.Text = ""
        txt_Usuario.Text = ""
        condicion_estado = estado.insertar
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        If validarCampoBlanco() And validarFK() Then
            If condicion_estado = estado.insertar Then
                If validarExistencia() Then
                    Me.insertar()
                End If

            Else
                Me.modificar()

            End If
        End If
        Me.cargar_Grilla()
        condicion_estado = estado.insertar
    End Sub

    Private Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Equipos"
        sql &= " (nombre, lema, color, nombreUsuario)"
        sql &= " values('" & Me.txt_NombreEquipo.Text & "', '" & Me.txt_Lema.Text & "', '"
        sql &= Me.txt_Color.Text & "', '" & Me.txt_Usuario.Text & "')"
        acceso.modificarTabla(sql)
    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql = "UPDATE Equipos "
        sql &= "SET lema = '"
        sql &= Me.txt_Lema.Text & "', color = '" & Me.txt_Color.Text & "', nombreUsuario = '" & Me.txt_Usuario.Text & "'"
        sql &= " WHERE nombre LIKE '" & Me.txt_NombreEquipo.Text & "'"

        acceso.modificarTabla(sql)
    End Sub


    Private Sub btn_Borrar_Click(sender As Object, e As EventArgs) Handles btn_Borrar.Click
        If MessageBox.Show("¿Esta seguro que desea borrar un registro?", "Atención" _
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                = DialogResult.OK Then

            Dim sql As String = ""

            sql = "DELETE Equipos"
            sql &= " WHERE nombre LIKE '" & Me.grid_Equipos.CurrentRow.Cells(0).Value & "'"


            acceso.modificarTabla(sql)
            Me.cargar_Grilla()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Close()
    End Sub


    Private Function validarCampoBlanco() As Boolean

        If txt_NombreEquipo.Text = "" Then
            MessageBox.Show("Falta ingresar NOMBRE del equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_NombreEquipo.Focus()
            Return False
        End If

        If txt_Lema.Text = "" Then
            MessageBox.Show("Falta ingresar el LEMA del equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Lema.Focus()
            Return False
        End If

        If txt_Color.Text = "" Then
            MessageBox.Show("Falta ingresar el COLOR del equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Lema.Focus()
            Return False
        End If

        If txt_Usuario.Text = "" Then
            MessageBox.Show("Falta ingresar el USUARIO del equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Usuario.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function validarExistencia() As Boolean
        Dim acceso As New AccesoDatos
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Equipos"
        sql &= " WHERE nombre LIKE '" & txt_NombreEquipo.Text & "'"

        tabla = acceso.leerTablaSQL(sql)
        If tabla.Rows.Count = 0 Then
            Return True
        End If

        MessageBox.Show("Ya existe el nombre de equipo especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False

    End Function

    Private Function validarFK() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql = "SELECT 1 FROM Usuarios U WHERE U.nombreUsuario LIKE '" & Me.txt_Usuario.Text & "'"
        tabla = acceso.leerTablaSQL(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No existe el nombre de usuario especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        Else
            Return True

        End If


    End Function


    Private Sub grid_Equipos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Equipos.CellDoubleClick
        condicion_estado = estado.modificar
        Dim acceso As New AccesoDatos
        Dim sql As String
        Dim tabla As New DataTable


        sql = "SELECT * FROM Equipos"
        sql &= " WHERE nombre LIKE '" & grid_Equipos.CurrentRow.Cells(0).Value & "'"

        tabla = acceso.leerTablaSQL(sql)

        txt_NombreEquipo.Enabled = False
        txt_NombreEquipo.Text = grid_Equipos.CurrentRow.Cells(0).Value
        txt_Lema.Text = tabla.Rows(0)(1)
        txt_Color.Text = tabla.Rows(0)(2)
        txt_Usuario.Text = tabla.Rows(0)(3)

    End Sub
End Class
