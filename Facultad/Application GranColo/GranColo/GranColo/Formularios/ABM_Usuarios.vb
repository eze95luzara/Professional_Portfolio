Public Class ABM_Usuarios
    Enum estado
        insertar
        modificar
    End Enum

    Dim condicionEstado As estado = estado.insertar

    Private Sub ABM_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_HinchaClub.cargar()
        cmb_TipoDocumento.cargar()
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        Dim acceso As New AccesoDatos
        Dim sql As String = ""

        sql = "SELECT U.nombreUsuario, U.contraseña, U.nombre, U.apellido, U.nroDoc, TD.nombre, U.mail, C.nombre"
        sql &= " FROM Usuarios U JOIN TiposDocumento TD ON U.tipoDoc = TD.id"
        sql &= " LEFT JOIN Clubes C ON U.clubHincha = C.id"

        grid_Usuarios.DataSource = acceso.leerTablaSQL(sql)

        grid_Usuarios.Columns(0).HeaderText = "Nombre de Usuario"
        grid_Usuarios.Columns(1).HeaderText = "Contraseña"
        grid_Usuarios.Columns(2).HeaderText = "Nombre"
        grid_Usuarios.Columns(3).HeaderText = "Apellido"
        grid_Usuarios.Columns(4).HeaderText = "Número de Documento"
        grid_Usuarios.Columns(5).HeaderText = "Tipo de Documento"
        grid_Usuarios.Columns(6).HeaderText = "Dirección de correo electrónico"
        grid_Usuarios.Columns(7).HeaderText = "Hincha de club"

        grid_Usuarios.AutoResizeColumns()

    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click

        txt_NombreUsuario.Enabled = True
        txt_NombreUsuario.Text = ""
        txt_Apellido.Text = ""
        txt_Contraseña.Text = ""
        txt_Email.Text = ""
        txt_Nombre.Text = ""
        txt_NroDocumento.Text = ""
        cmb_HinchaClub.SelectedIndex = -1
        cmb_TipoDocumento.SelectedIndex = -1

        condicionEstado = estado.insertar

    End Sub

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles cmd_Eliminar.Click
        If MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim acceso As New AccesoDatos
            Dim sql As String

            sql = "DELETE FROM Usuarios"
            sql &= " WHERE nombreUsuario LIKE '" & grid_Usuarios.CurrentRow.Cells(0).Value & "'"

            acceso.modificarTabla(sql)

            MessageBox.Show("Usuario eliminado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargarGrilla()

        End If
    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        If validar() Then
            If condicionEstado = estado.modificar Then
                modificar()
                MessageBox.Show("Usuario modificado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If validarExistencia() Then
                    insertar()
                    MessageBox.Show("Usuario registrado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        End If
        cargarGrilla()

    End Sub

    Private Sub insertar()
        Dim acceso As New AccesoDatos
        Dim sql As String

        sql = "INSERT INTO Usuarios(nombreUsuario, contraseña, nombre, apellido, nroDoc, tipoDoc, mail, clubHincha)"
        sql &= " VALUES ('" & txt_NombreUsuario.Text & "'"
        sql &= ", '" & txt_Contraseña.Text & "'"
        sql &= ", '" & txt_Nombre.Text & "'"
        sql &= ", '" & txt_Apellido.Text & "'"
        sql &= ", '" & txt_NroDocumento.Text & "'"
        sql &= ", " & cmb_TipoDocumento.SelectedValue
        sql &= ", '" & txt_Email.Text & "'"
        sql &= ", " & cmb_HinchaClub.SelectedValue & ")"

        acceso.modificarTabla(sql)
    End Sub

    Private Sub modificar()
        Dim acceso As New AccesoDatos
        Dim sql As String

        sql = "UPDATE Usuarios"
        sql &= " SET contraseña = '" & txt_Contraseña.Text & "'"
        sql &= ", nombre = '" & txt_Nombre.Text & "'"
        sql &= ", apellido = '" & txt_Apellido.Text & "'"
        sql &= ", nroDoc = '" & txt_NroDocumento.Text & "'"
        sql &= ", tipoDoc = " & cmb_TipoDocumento.SelectedValue
        sql &= ", mail = '" & txt_Email.Text & "'"
        sql &= ", clubHincha = " & cmb_HinchaClub.SelectedValue
        sql &= " WHERE nombreUsuario LIKE '" & txt_NombreUsuario.Text & "'"
        acceso.modificarTabla(sql)
    End Sub

    Private Function validar() As Boolean

        If txt_NombreUsuario.Text = "" Then
            MessageBox.Show("Falta ingresar NOMBRE DE USUARIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_NombreUsuario.Focus()
            Return False
        End If

        If txt_Contraseña.Text = "" Then
            MessageBox.Show("Falta ingresar CONTRASEÑA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Contraseña.Focus()
            Return False
        End If

        If txt_Nombre.Text = "" Then
            MessageBox.Show("Falta ingresar NOMBRE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Nombre.Focus()
            Return False
        End If

        If txt_Apellido.Text = "" Then
            MessageBox.Show("Falta ingresar APELLIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Apellido.Focus()
            Return False
        End If

        If txt_NroDocumento.Text = "" Then
            MessageBox.Show("Falta ingresar NÚMERO DE DOCUMENTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_NroDocumento.Focus()
            Return False
        End If

        If cmb_TipoDocumento.SelectedIndex = -1 Then
            MessageBox.Show("Falta ingresar TIPO DE DOCUMENTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_TipoDocumento.Focus()
            Return False
        End If

        If txt_Email.Text = "" Then
            MessageBox.Show("Falta ingresar DIRECCIÓN DE CORREO ELECTRÓNICO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Email.Focus()
            Return False
        End If

        If cmb_HinchaClub.SelectedIndex = -1 Then
            MessageBox.Show("Falta ingresar HINCHA DEL CLUB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_HinchaClub.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function validarExistencia() As Boolean
        Dim acceso As New AccesoDatos
        Dim sql As String = ""
        Dim tabla As New DataTable



        sql = "SELECT * FROM Usuarios"
        sql &= " WHERE nombreUsuario LIKE '" & txt_NombreUsuario.Text & "'"

        tabla = acceso.leerTablaSQL(sql)
        If tabla.Rows.Count = 0 Then
            Return True
        End If

        MessageBox.Show("Ya existe el nombre de usuario especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False

    End Function

    Private Sub grid_Usuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Usuarios.CellContentDoubleClick
        condicionEstado = estado.modificar

        Dim acceso As New AccesoDatos
        Dim sql As String
        Dim tabla As New DataTable


        sql = "SELECT * FROM Usuarios"
        sql &= " WHERE nombreUsuario LIKE '" & grid_Usuarios.CurrentRow.Cells(0).Value & "'"

        tabla = acceso.leerTablaSQL(sql)

        txt_NombreUsuario.Enabled = False
        txt_NombreUsuario.Text = grid_Usuarios.CurrentRow.Cells(0).Value
        txt_Contraseña.Text = tabla.Rows(0)(1)
        txt_Apellido.Text = tabla.Rows(0)(2)
        txt_Nombre.Text = tabla.Rows(0)(3)
        cmb_TipoDocumento.SelectedValue = tabla.Rows(0)(5)
        txt_NroDocumento.Text = tabla.Rows(0)(4)
        txt_Email.Text = tabla.Rows(0)(6)
        cmb_HinchaClub.SelectedValue = tabla.Rows(0)(7)


    End Sub

    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub
End Class