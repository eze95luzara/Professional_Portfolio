Public Class ABM_Torneos
    Enum estado
        insertar
        modificar
    End Enum

    Dim acceso As New AccesoDatos
    Dim condicionEstado As estado = estado.insertar

    Private Sub ABM_Torneos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()

    End Sub

    Private Sub cargarGrilla()
        grid_Torneos.DataSource = acceso.leerTabla("Torneos")

        grid_Torneos.Columns(0).HeaderText = "ID"
        grid_Torneos.Columns(1).HeaderText = "Fecha Inicio"
        grid_Torneos.Columns(2).HeaderText = "Fecha Fin"
        grid_Torneos.Columns(3).HeaderText = "Nombre"

        grid_Torneos.AutoResizeColumns()
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

    Private Function validar() As Boolean
        If txt_Nombre.Text = "" Then
            MessageBox.Show("Falta ingresar NOMBRE DEL TORNEO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Nombre.Focus()
        End If

        If dtp_FechaDesde.Value > dtp_FechaHasta.Value Then
            MessageBox.Show("La FECHA DE INICIO no puede ser mayor a la FECHA DE FIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtp_FechaDesde.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub insertar()
        Dim sql As String

        sql = "INSERT INTO Torneos(id, fechaDesdeTorneo, fechaHastaTorneo, nombre)"
        sql &= " VALUES (" & calcularId()
        sql &= ", CONVERT(date, '" & dtp_FechaDesde.Value.ToString("dd/MM/yyyy") & "', 103)"
        sql &= ", CONVERT(date, '" & dtp_FechaHasta.Value.ToString("dd/MM/yyyy") & "', 103)"
        sql &= ", '" & txt_Nombre.Text & "')"

        acceso.modificarTabla(sql)
        MessageBox.Show("Torneo guardado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub modificar()
        Dim sql As String

        sql = "UPDATE Torneos"
        sql &= " SET fechaDesdeTorneo = " & "CONVERT(Date, '" & dtp_FechaDesde.Value.ToString("dd/MM/yyyy") & "', 103)"
        sql &= ", fechaHastaTorneo = " & "CONVERT(Date, '" & dtp_FechaHasta.Value.ToString("dd/MM/yyyy") & "', 103)"
        sql &= ", nombre = '" & txt_Nombre.Text & "'"
        'Esto podría dar problemas si el usuario elige otro casillero luego de elegir el que quiere modificar
        sql &= " WHERE id = " & grid_Torneos.CurrentRow.Cells(0).Value

        acceso.modificarTabla(sql)
        MessageBox.Show("Torneo modificado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles cmd_Eliminar.Click


        If MessageBox.Show("¿Está seguro que desea eliminar el Torneo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) _
            = DialogResult.OK Then
            Dim sql As String
            Dim tabla As New DataTable
            sql = "SELECT 1 FROM Torneos T JOIN Fechas F ON F.idTorneo = T.id"

            tabla = acceso.leerTablaSQL(sql)

            If tabla.Rows.Count() > 0 Then

                If MessageBox.Show("El torneo contiene fechas asignadas. Si elimina el torneo, todas las fechas también se eliminarán, ¿está seguro?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) _
                    = DialogResult.OK Then

                    sql = "DELETE FROM Torneos"
                    sql &= " WHERE id = " & grid_Torneos.CurrentRow.Cells(0).Value
                    acceso.modificarTabla(sql)
                    MessageBox.Show("Torneo eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                sql = "DELETE FROM Torneos"
                sql &= " WHERE id = " & grid_Torneos.CurrentRow.Cells(0).Value
                acceso.modificarTabla(sql)
                MessageBox.Show("Torneo eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
        cargarGrilla()

    End Sub

    Private Function calcularId() As Integer
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim acceso As New AccesoDatos


        sql = "SELECT id "
        sql &= "FROM Torneos"
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

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        condicionEstado = estado.insertar
        txt_Nombre.Text = ""
        dtp_FechaDesde.Value = Date.Today
        dtp_FechaHasta.Value = Date.Today
    End Sub

    Private Sub grid_Torneos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Torneos.CellContentDoubleClick
        condicionEstado = estado.modificar
        txt_Nombre.Text = grid_Torneos.CurrentRow.Cells(3).Value
        dtp_FechaDesde.Value = grid_Torneos.CurrentRow.Cells(1).Value
        dtp_FechaHasta.Value = grid_Torneos.CurrentRow.Cells(2).Value
    End Sub

    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub


End Class