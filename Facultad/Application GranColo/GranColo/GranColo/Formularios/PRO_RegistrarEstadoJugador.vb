Public Class PRO_RegistrarEstadoJugador
    Enum seleccionado
        si
        no
    End Enum

    Dim acceso As New AccesoDatos
    Dim estado As String
    Dim selec As seleccionado = seleccionado.no



    Private Sub PRO_RegistrarEstadoJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Club.cargar()
        cmb_Estado.cargar()

    End Sub

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        If cmb_Club.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir CLUB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Club.Focus()
            Exit Sub
        End If

        cargarGrilla()


    End Sub

    Private Sub cargarGrilla()
        Dim sql As String
        sql &= "SELECT J.nroDoc, T.nombre, J.nombre, J.apellido, P.nombre, E.descripcion"
        sql &= " FROM Jugadores J JOIN Estados E ON J.idEstado = E.id"
        sql &= " JOIN Posiciones P ON J.idPosicion = P.id "
        sql &= " JOIN Clubes C ON J.idClub = C.id"
        sql &= " JOIN TiposDocumento T ON J.tipoDoc = T.id"
        sql &= " WHERE C.id = " & cmb_Club.SelectedValue

        grid_Jugadores.DataSource = acceso.leerTablaSQL(sql)
        grid_Jugadores.Columns(0).HeaderText = "Número de Documento"
        grid_Jugadores.Columns(1).HeaderText = "Tipo de Documento"
        grid_Jugadores.Columns(2).HeaderText = "Nombre"
        grid_Jugadores.Columns(3).HeaderText = "Apellido"
        grid_Jugadores.Columns(4).HeaderText = "Posición"
        grid_Jugadores.Columns(5).HeaderText = "Estado"
        grid_Jugadores.AutoResizeColumns()
    End Sub

    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub

    Private Sub grid_Jugadores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Jugadores.CellContentDoubleClick

        txt_NroDocumento.Text = grid_Jugadores.CurrentRow.Cells(0).Value
        txt_TipoDocumento.Text = grid_Jugadores.CurrentRow.Cells(1).Value
        txt_NombreJugador.Text = grid_Jugadores.CurrentRow.Cells(2).Value
        txt_ApellidoJugador.Text = grid_Jugadores.CurrentRow.Cells(3).Value
        txt_Posicion.Text = grid_Jugadores.CurrentRow.Cells(4).Value
        estado = grid_Jugadores.CurrentRow.Cells(5).Value
        selec = seleccionado.si

    End Sub

    Private Sub cmd_Limpiar_Click(sender As Object, e As EventArgs) Handles cmd_Limpiar.Click
        txt_NombreJugador.Text = ""
        txt_ApellidoJugador.Text = ""
        txt_NroDocumento.Text = ""
        txt_TipoDocumento.Text = ""
        txt_Posicion.Text = ""
        cmb_Club.SelectedIndex = -1
        cmb_Estado.SelectedIndex = -1
        cmb_Club.Focus()
        selec = seleccionado.no
        grid_Jugadores.DataSource = New DataTable
    End Sub


    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        If cmb_Club.SelectedIndex = -1 Then
            MessageBox.Show("Falta seleccionar un Club para modificar el estado de un jugador del mismo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Club.Focus()
            Exit Sub
        End If

        If cmb_Estado.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir ESTADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Estado.Focus()
            Exit Sub
        End If
        If selec = seleccionado.no Then
            MessageBox.Show("Falta elegir JUGADOR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sql As String = ""
        sql &= "SELECT descripcion"
        sql &= " FROM Estados"
        sql &= " WHERE id = " & cmb_Estado.SelectedValue

        Dim tabla As New DataTable
        tabla = acceso.leerTablaSQL(sql)

        If tabla.Rows(0)(0) = estado Then
            MessageBox.Show("El Jugador ya se encuentra en el estado seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Estado.Focus()
            Exit Sub
        End If

        sql = ""
        sql &= "SELECT id"
        sql &= " FROM TiposDocumento"
        sql &= " WHERE nombre LIKE '" & txt_TipoDocumento.Text & "'"

        tabla = acceso.leerTablaSQL(sql)

        sql = ""
        sql &= "UPDATE Jugadores"
        sql &= " SET idEstado = " & cmb_Estado.SelectedValue
        sql &= " WHERE nroDoc = " & txt_NroDocumento.Text & " AND tipoDoc = " & tabla.Rows(0)(0)

        acceso.modificarTabla(sql)
        MessageBox.Show("Estado modificado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cargarGrilla()

    End Sub
End Class