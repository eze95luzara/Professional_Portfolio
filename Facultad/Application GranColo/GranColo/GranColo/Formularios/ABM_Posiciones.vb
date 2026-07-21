Public Class ABM_Posiciones
    Enum estado
        insertar
        modificar
    End Enum

    Dim condicionEstado As estado = estado.insertar

    Private Sub ABM_Posiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        Dim acceso As New AccesoDatos
        Dim sql As String = ""

        sql = "SELECT * FROM Posiciones"

        grid_Posiciones.DataSource = acceso.leerTablaSQL(sql)

        grid_Posiciones.Columns(0).HeaderText = "Id"
        grid_Posiciones.Columns(1).HeaderText = "Nombre"
        grid_Posiciones.Columns(2).HeaderText = "Descripcion"

        grid_Posiciones.AutoResizeColumns()
    End Sub

    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Me.Close()
    End Sub

    Private Function validar() As Boolean


        If txt_Nombre.Text = "" Then
            MessageBox.Show("Falta ingresar Nombre de la Posición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Nombre.Focus()
            Return False
        End If

        If txt_Descripcion.Text = "" Then
            MessageBox.Show("Falta ingresar Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Descripcion.Focus()
            Return False
        End If

        Return True
    End Function



    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
        condicionEstado = estado.insertar
    End Sub

    Private Sub cmd_Borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        If MessageBox.Show("¿Está seguro que desea eliminar la posición?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim acceso As New AccesoDatos
            Dim sql As String

            sql = "DELETE FROM Posiciones"
            sql &= " WHERE id LIKE '" & grid_Posiciones.CurrentRow.Cells(0).Value & "'"

            acceso.modificarTabla(sql)

            MessageBox.Show("Posicion eliminada correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargarGrilla()

        End If
    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        If validar() Then
            If condicionEstado = estado.modificar Then
                modificar()
                MessageBox.Show("Posición modificada exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                insertar()
                MessageBox.Show("Posición registrada exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
        cargarGrilla()
    End Sub
    Private Sub modificar()
        Dim acceso As New AccesoDatos
        Dim sql As String

        sql = "UPDATE Posiciones"
        sql &= " SET nombre = '" & txt_Nombre.Text & "'"
        sql &= ", Descripcion = '" & txt_Descripcion.Text & "'"
        acceso.modificarTabla(sql)
    End Sub
    Private Sub insertar()
        Dim acceso As New AccesoDatos
        Dim sql As String

        sql = "INSERT INTO Posiciones(id, nombre, descripcion)"
        sql &= " VALUES (" & calcularId()
        sql &= ", '" & txt_Nombre.Text & "'"
        sql &= ", '" & txt_Descripcion.Text & "'" & ")"

        acceso.modificarTabla(sql)
    End Sub

    'CAMBIAR LA SENTENCIA SQL POR LA TABLA QUE HAGA FALTA

    Private Function calcularId() As Integer
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim acceso As New AccesoDatos


        sql = "SELECT P.id "
        sql &= "FROM Posiciones P "
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

    Private Sub grid_Posiciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Posiciones.CellContentDoubleClick
        condicionEstado = estado.modificar

        Dim acceso As New AccesoDatos
        Dim sql As String
        Dim tabla As New DataTable


        sql = "SELECT * FROM Posiciones"
        sql &= " WHERE id = " & grid_Posiciones.CurrentRow.Cells(0).Value

        tabla = acceso.leerTablaSQL(sql)


        txt_Nombre.Text = tabla.Rows(0)(1)
        txt_Descripcion.Text = tabla.Rows(0)(2)

    End Sub
End Class
