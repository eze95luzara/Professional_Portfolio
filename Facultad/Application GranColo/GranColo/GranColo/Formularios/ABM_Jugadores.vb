Public Class ABM_Jugadores
    Enum state
        insertar
        modificar
    End Enum

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=WINUSER-PC;Integrated Security=SSPI;Initial Catalog=GranColo"
    Dim condicionEstado As state = state.insertar


    Private Sub ABM_Jugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Estado.cargar()
        cmb_NombreClub.cargar()
        cmb_Posicion.cargar()
        cmb_TipoDocumento.cargar()
        cargarGrilla()

    End Sub

    Private Sub cargarGrilla()

        Dim acceso As New AccesoDatos

        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT TD.nombre, J.nroDoc, J.apellido, J.nombre, C.nombre, P.nombre, E.nombre " _
             & "FROM Jugadores J JOIN TiposDocumento TD ON J.tipoDoc = TD.id " _
             & "LEFT JOIN Clubes C ON J.idClub = C.id " _
             & "LEFT JOIN Posiciones P ON J.idPosicion = P.id " _
             & "LEFT JOIN Estados E ON J.idEstado = E.id"

        grid_Jugadores.DataSource = acceso.leerTablaSQL(sql)

        grid_Jugadores.Columns(0).HeaderText = "Tipo de Documento"
        grid_Jugadores.Columns(1).HeaderText = "Número de Documento"
        grid_Jugadores.Columns(2).HeaderText = "Apellido"
        grid_Jugadores.Columns(3).HeaderText = "Nombre"
        grid_Jugadores.Columns(4).HeaderText = "Nombre del Club"
        grid_Jugadores.Columns(5).HeaderText = "Posición"
        grid_Jugadores.Columns(6).HeaderText = "Estado"

        grid_Jugadores.AutoResizeColumns()

    End Sub

    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click

        If validar() = True Then
            Dim acceso As New AccesoDatos
            Dim sql As String = ""

            Dim operacion As String = "modificado"

            If condicionEstado = state.insertar Then
                sql = insertar()
                operacion = "guardado"
            Else
                sql = modificar()
            End If

            acceso.modificarTabla(sql)

            MessageBox.Show("Jugador " + operacion + " exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cargarGrilla()
        End If


    End Sub

    Private Function validar() As Boolean

        If cmb_TipoDocumento.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir TIPO DE DOCUMENTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_TipoDocumento.Focus()
            Return False
        End If

        If txt_Documento.Text = "" Then
            MessageBox.Show("Falta ingresar DOCUMENTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Documento.Focus()
            Return False
        End If

        If txt_Apellido.Text = "" Then
            MessageBox.Show("Falta ingresar APELLIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Apellido.Focus()
            Return False
        End If

        If txt_Nombre.Text = "" Then
            MessageBox.Show("Falta ingresar NOMBRE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Nombre.Focus()
            Return False
        End If

        If cmb_NombreClub.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir NOMBRE DEL CLUB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_NombreClub.Focus()
            Return False
        End If

        If cmb_Posicion.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir POSICIÓN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Posicion.Focus()
            Return False
        End If

        If cmb_Estado.SelectedIndex = -1 Then
            MessageBox.Show("Falta elegir ESTADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Estado.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function insertar() As String

        Dim sql As String

        sql = "INSERT INTO Jugadores(nroDoc, tipoDoc, idClub, nombre, apellido, idPosicion, idEstado)" _
             & " VALUES (" & txt_Documento.Text _
             & ", " & cmb_TipoDocumento.SelectedValue _
             & ", " & cmb_NombreClub.SelectedValue _
             & ", '" & txt_Nombre.Text & "' " _
             & ", '" & txt_Apellido.Text & "' " _
             & ", " & cmb_Posicion.SelectedValue _
             & ", " & cmb_Estado.SelectedValue & ")"

        Return sql

    End Function

    Private Function modificar() As String
        Dim sql As String

        sql = "UPDATE Jugadores " _
            & "SET idClub = " & cmb_NombreClub.SelectedValue _
            & ", nombre = '" & txt_Nombre.Text & "'" _
            & ", apellido = '" & txt_Apellido.Text & "'" _
            & ", idPosicion = " & cmb_Posicion.SelectedValue _
            & ", idEstado = " & cmb_Estado.SelectedValue _
            & " WHERE nroDoc = " & txt_Documento.Text _
            & " AND tipoDoc = " & cmb_TipoDocumento.SelectedValue
        Return sql
    End Function

    Private Sub grid_Jugadores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Jugadores.CellContentDoubleClick

        Dim acceso As New AccesoDatos
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT TD.id, J.nroDoc, J.apellido, J.nombre, C.id, P.id, E.id "
        sql &= "FROM Jugadores J JOIN TiposDocumento TD ON J.tipoDoc = TD.id "
        sql &= "JOIN Clubes C ON J.idClub = C.id "
        sql &= "JOIN Posiciones P ON J.idPosicion = P.id "
        sql &= "JOIN Estados E ON J.idEstado = E.id "
        sql &= "WHERE TD.nombre = '" & grid_Jugadores.CurrentRow.Cells(0).Value & "'"
        sql &= " AND J.nroDoc = " & grid_Jugadores.CurrentRow.Cells(1).Value



        tabla = acceso.leerTablaSQL(sql)

        If tabla.Rows.Count() = 0 Then 'Se borró la tabla antes de que pudiera cargarla en "tabla"
            MessageBox.Show("La tabla fue borrada")
            Exit Sub
        End If

        'Debería devolver 1 sola fila, entonces Rows(0) devuelve la primer fila

        Me.cmb_TipoDocumento.SelectedValue = tabla.Rows(0)(0)
        Me.txt_Documento.Text = tabla.Rows(0)(1)
        Me.txt_Apellido.Text = tabla.Rows(0)(2)
        Me.txt_Nombre.Text = tabla.Rows(0)(3)
        Me.cmb_NombreClub.SelectedValue = tabla.Rows(0)(4)
        Me.cmb_Posicion.SelectedValue = tabla.Rows(0)(5)
        Me.cmb_Estado.SelectedValue = tabla.Rows(0)(6)


        'No se debería poder modificar la clave primaria
        Me.txt_Documento.Enabled = False
        Me.cmb_TipoDocumento.Enabled = False

        condicionEstado = state.modificar


    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Esta seguro que desea borrar un registro", "Atención" _
                        , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                        = DialogResult.OK Then

            Dim acceso As New AccesoDatos
            Dim sql As String = ""

            sql = "DELETE Jugadores" _
                & " WHERE tipoDoc = (SELECT id FROM TiposDocumento WHERE nombre = '" & Me.grid_Jugadores.CurrentRow.Cells(0).Value & "')" _
                & " AND nroDoc = " & Me.grid_Jugadores.CurrentRow.Cells(1).Value

            acceso.modificarTabla(sql)
            MessageBox.Show("Jugador eliminado correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.cargarGrilla()
        End If
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        txt_Apellido.Text = ""
        txt_Documento.Text = ""
        txt_Nombre.Text = ""
        cmb_Estado.SelectedIndex = -1
        cmb_NombreClub.SelectedIndex = -1
        cmb_Posicion.SelectedIndex = -1
        cmb_TipoDocumento.SelectedIndex = -1

        cmb_TipoDocumento.Enabled = True
        txt_Documento.Enabled = True
        condicionEstado = state.insertar
    End Sub
End Class
