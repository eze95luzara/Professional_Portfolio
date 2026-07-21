Public Class ABM_Estados
    Enum estado
        insertar
        modificar
    End Enum

    Dim acceso As New AccesoDatos
    Dim condicionEstado As estado = estado.insertar

    Private Sub ABM_Estados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Function calcularId() As Integer
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim acceso As New AccesoDatos


        sql = "SELECT id"
        sql &= " FROM Estados"
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
        Dim sql As String

        sql = "SELECT * FROM Estados"

        grid_Estados.DataSource = acceso.leerTablaSQL(sql)
        grid_Estados.Columns(0).HeaderText = "ID"
        grid_Estados.Columns(1).HeaderText = "Nombre"
        grid_Estados.Columns(2).HeaderText = "Descripción"

        grid_Estados.AutoResizeColumns()
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
            MessageBox.Show("Falta ingresar NOMBRE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Nombre.Focus()
            Return False
        End If

        If txt_Descripcion.Text = "" Then
            MessageBox.Show("Falta ingresar DESCRIPCIÓN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Descripcion.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub insertar()
        Dim sql As String

        sql = "INSERT INTO Estados (id, nombre, descripcion)"
        sql &= " VALUES (" & calcularId()
        sql &= ", '" & txt_Nombre.Text & "'"
        sql &= ", '" & txt_Descripcion.Text & "')"

        acceso.modificarTabla(sql)
        MessageBox.Show("Estado registrado exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub modificar()
        Dim sql As String

        sql = "UPDATE Estados"
        sql &= " SET nombre = '" & txt_Nombre.Text & "'"
        sql &= ", descripcion = '" & txt_Descripcion.Text & "'"
        sql &= " WHERE id = " & grid_Estados.CurrentRow.Cells(0).Value

        acceso.modificarTabla(sql)
        MessageBox.Show("Estado modificado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles cmd_Eliminar.Click
        If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) _
            = DialogResult.OK Then

            Dim sql As String
            sql = "SELECT 1 FROM Estados E JOIN Jugadores J ON E.id = J.idEstado"
            sql &= " WHERE E.id = " & grid_Estados.CurrentRow.Cells(0).Value

            If acceso.leerTablaSQL(sql).Rows.Count() > 0 Then
                If MessageBox.Show("Existen jugadores con este estado asignado. Si lo elimina, los jugadores quedarán sin estado asignado, ¿está seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) _
                   = DialogResult.OK Then
                    sql = "DELETE FROM Estados"
                    sql &= " WHERE id = " & grid_Estados.CurrentRow.Cells(0).Value

                    acceso.modificarTabla(sql)
                    MessageBox.Show("Estado eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
            Else
                sql = "DELETE FROM Estados"
                sql &= " WHERE id = " & grid_Estados.CurrentRow.Cells(0).Value

                acceso.modificarTabla(sql)
                MessageBox.Show("Estado eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
        cargarGrilla()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        condicionEstado = estado.insertar
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
    End Sub

    Private Sub grid_Estados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Estados.CellContentDoubleClick
        condicionEstado = estado.modificar

        txt_Nombre.Text = grid_Estados.CurrentRow.Cells(1).Value
        txt_Descripcion.Text = grid_Estados.CurrentRow.Cells(2).Value

    End Sub

    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub


End Class