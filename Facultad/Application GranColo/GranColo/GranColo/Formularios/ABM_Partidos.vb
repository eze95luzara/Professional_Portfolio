Public Class ABM_Partidos
    Enum estado
        insertar
        modificar
    End Enum

    Dim condicionEstado As estado = estado.insertar
    Dim acceso As New AccesoDatos

    Private Sub ABM_Partidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Torneo.cargar()
        cargarGrilla()
        cargarCombo()
    End Sub

    Private Function calcularId() As Integer
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim acceso As New AccesoDatos


        sql = "SELECT id "
        sql &= "FROM Partidos "
        tabla = acceso.leerTablaSQL(sql)
        If tabla.Rows.Count() = 0 Then
            Return 1
        End If
        For i = 0 To tabla.Rows.Count() - 1

            If tabla.Rows(i)(0) = i + 1 Then
            Else
                Return i + 1
            End If

        Next
        Return tabla.Rows.Count() + 1
    End Function

    Private Sub cargarGrilla()
        Dim sql As String = ""

        sql = "SELECT P.id, P.nroFecha, T.nombre, P.fecha, P.horario "
        sql &= "FROM Partidos P JOIN Torneos T ON P.idTorneo = T.id"

        grid_Partidos.DataSource = acceso.leerTablaSQL(sql)

        grid_Partidos.Columns(0).HeaderText = "ID Partido"
        grid_Partidos.Columns(1).HeaderText = "Fecha"
        grid_Partidos.Columns(2).HeaderText = "Nombre del Torneo"
        grid_Partidos.Columns(3).HeaderText = "Fecha del Partido"
        grid_Partidos.Columns(4).HeaderText = "Horario"

        grid_Partidos.AutoResizeColumns()




    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        If validar() Then
            If condicionEstado = estado.insertar Then
                insertar()
            Else
                modificar()
            End If

        End If

        cargarGrilla()

    End Sub

    Private Sub insertar()

        Dim sql As String

        sql = "INSERT INTO Partidos(id, nroFecha, idTorneo, fecha, horario)"
        sql &= " VALUES(" & calcularId()
        sql &= ", " & cmb_FechaTorneo.SelectedValue
        sql &= ", " & cmb_Torneo.SelectedValue
        sql &= ", CONVERT(date, '" & dtp_Fecha.Value.ToString("dd/MM/yyyy") & "', 103)"
        sql &= ", CONVERT(time, '" & cmb_Horario.SelectedValue & ":00', 108)"

        acceso.modificarTabla(sql)
        MessageBox.Show("Partido registrado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub modificar()
        Dim sql As String

        sql = "UPDATE Partidos"
        sql &= " SET nroFecha = " & cmb_FechaTorneo.SelectedValue
        sql &= ", idTorneo = " & cmb_Torneo.SelectedValue
        sql &= ", fecha = CONVERT(date, '" & dtp_Fecha.Value.ToString("dd/MM/yyyy") & "', 103)"
        sql &= ", horario = CONVERT(time, '" & cmb_Horario.SelectedValue & ":00', 108)"
        sql &= " WHERE id = " & grid_Partidos.CurrentRow.Cells(0).Value

        acceso.modificarTabla(sql)
        MessageBox.Show("Partido modificado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Function validar() As Boolean

        If cmb_Torneo.SelectedIndex = -1 Then
            MessageBox.Show("Falta seleccionar el NOMBRE DEL TORNEO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Torneo.Focus()
            Return False
        End If

        If cmb_FechaTorneo.SelectedIndex = -1 Then
            MessageBox.Show("Falta ingresar la FECHA DEL TORNEO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_FechaTorneo.Focus()
            Return False
        End If

        If cmb_Horario.SelectedIndex = -1 Then
            MessageBox.Show("Falta ingresar el HORARIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Horario.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cargarCombo()
        cmb_Horario.Items.Add("00:00")
        cmb_Horario.Items.Add("00:30")
        cmb_Horario.Items.Add("01:00")
        cmb_Horario.Items.Add("01:30")
        cmb_Horario.Items.Add("02:00")
        cmb_Horario.Items.Add("02:30")
        cmb_Horario.Items.Add("03:00")
        cmb_Horario.Items.Add("03:30")
        cmb_Horario.Items.Add("04:00")
        cmb_Horario.Items.Add("04:30")
        cmb_Horario.Items.Add("05:00")
        cmb_Horario.Items.Add("05:30")
        cmb_Horario.Items.Add("06:00")
        cmb_Horario.Items.Add("06:30")
        cmb_Horario.Items.Add("07:00")
        cmb_Horario.Items.Add("07:30")
        cmb_Horario.Items.Add("08:00")
        cmb_Horario.Items.Add("08:30")
        cmb_Horario.Items.Add("09:00")
        cmb_Horario.Items.Add("09:30")
        cmb_Horario.Items.Add("10:00")
        cmb_Horario.Items.Add("10:30")
        cmb_Horario.Items.Add("11:00")
        cmb_Horario.Items.Add("11:30")
        cmb_Horario.Items.Add("12:00")
        cmb_Horario.Items.Add("12:30")
        cmb_Horario.Items.Add("13:00")
        cmb_Horario.Items.Add("13:30")
        cmb_Horario.Items.Add("14:00")
        cmb_Horario.Items.Add("14:30")
        cmb_Horario.Items.Add("15:00")
        cmb_Horario.Items.Add("15:30")
        cmb_Horario.Items.Add("16:00")
        cmb_Horario.Items.Add("16:30")
        cmb_Horario.Items.Add("17:00")
        cmb_Horario.Items.Add("17:30")
        cmb_Horario.Items.Add("18:00")
        cmb_Horario.Items.Add("18:30")
        cmb_Horario.Items.Add("19:00")
        cmb_Horario.Items.Add("19:30")
        cmb_Horario.Items.Add("20:00")
        cmb_Horario.Items.Add("20:30")
        cmb_Horario.Items.Add("21:00")
        cmb_Horario.Items.Add("21:30")
        cmb_Horario.Items.Add("22:00")
        cmb_Horario.Items.Add("22:30")
        cmb_Horario.Items.Add("23:00")
        cmb_Horario.Items.Add("23:30")

        cmb_Horario.SelectedIndex = -1
    End Sub



    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        condicionEstado = estado.insertar

        cmb_FechaTorneo.SelectedIndex = -1
        cmb_Horario.SelectedIndex = -1
        cmb_Torneo.SelectedIndex = -1
        dtp_Fecha.Value = Date.Today

    End Sub

    Private Sub grid_Partidos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Partidos.CellContentDoubleClick
        condicionEstado = estado.modificar

        cmb_FechaTorneo.SelectedValue = grid_Partidos.CurrentRow.Cells(1).Value
        cmb_Torneo.SelectedValue = grid_Partidos.CurrentRow.Cells(2).Value
        dtp_Fecha.Value = grid_Partidos.CurrentRow.Cells(3).Value
        cmb_Horario.SelectedValue = grid_Partidos.CurrentRow.Cells(4).Value
    End Sub

    Private Sub cmd_Borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        If MessageBox.Show("¿Está seguro que desea borrar el registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) _
            = DialogResult.OK Then
            Dim sql As String

            sql = "DELETE FROM Partidos WHERE id = " & grid_Partidos.CurrentRow.Cells(0).Value
            acceso.modificarTabla(sql)
            MessageBox.Show("Partido eliminado correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargarGrilla()

        End If
    End Sub

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        Dim sql As String
        Dim tabla As New DataTable


        sql = "SELECT F.nro"
        sql &= " FROM Fechas F JOIN Torneos T ON F.idTorneo = T.id"
        sql &= " WHERE T.id = " & cmb_Torneo.SelectedValue

        tabla = acceso.leerTablaSQL(sql)

        cmb_FechaTorneo.DataSource = tabla
        cmb_FechaTorneo.cargar(tabla)



    End Sub
End Class
