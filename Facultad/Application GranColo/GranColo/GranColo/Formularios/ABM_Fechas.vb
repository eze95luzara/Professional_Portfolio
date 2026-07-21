Public Class ABM_Fechas

    Enum Estado
        insertar
        modificar
    End Enum

    Enum existencia_analizada
        existe
        noexiste
    End Enum

    Dim condicion_estado As Estado = Estado.insertar
    Dim acceso As New AccesoDatos



    Private Sub ABM_Fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cargarCombo(cmb_Torneo, "Torneos", "nombre", "id")
        Me.cmb_Torneo.SelectedIndex = -1
        Me.dtp_Desde.Value = Date.Today


    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT T.nombre, F.nro, F.fechaInicio FROM Fechas F JOIN Torneos T ON F.idTorneo = T.id"
        sql &= " WHERE T.id = " & Me.cmb_Torneo.SelectedValue.ToString

        Me.grid_Datos.Rows.Clear()
        tabla = acceso.leerTablaSQL(sql)

        Dim i As Integer = 0
        For i = 0 To tabla.Rows.Count() - 1


            Me.grid_Datos.Rows.Add()

            Me.grid_Datos.Rows(i).Cells("col_Torneo").Value = tabla.Rows(i)("nombre")
            Me.grid_Datos.Rows(i).Cells("col_NroFecha").Value = tabla.Rows(i)("nro")
            Me.grid_Datos.Rows(i).Cells("col_FechaInicio").Value = tabla.Rows(i)("fechaInicio")

        Next

        grid_Datos.AutoResizeColumns()

    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click

        Me.condicion_estado = Estado.insertar

        Dim obj As Object
        Dim tipo As String = ""

        For Each obj In Me.Controls
            tipo = obj.GetType.Name

            If tipo = "TextBox" Then
                obj.Text = ""
            End If

            If tipo = "DateTimePicker" Then
                obj.Value = Date.Today
            End If

            If tipo = "ComboBox" Then
                obj.SelectedIndex = -1
            End If

            Me.cmb_Torneo.Enabled = True

        Next
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByVal nombreTabla As String, ByVal nombreTorneo As String, ByVal idTorneo As String)

        combo.DataSource = acceso.leerTabla(nombreTabla)
        combo.DisplayMember = nombreTorneo
        combo.ValueMember = idTorneo


    End Sub

    Private Function calcularId() As Integer
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim acceso As New AccesoDatos


        sql = "SELECT F.nro"
        sql &= " FROM Fechas F JOIN Torneos T ON F.idTorneo = T.id"
        sql &= " WHERE idTorneo = " & cmb_Torneo.SelectedValue
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

    Private Function validar() As Boolean


        If Me.cmb_Torneo.SelectedIndex = -1 Then
            MessageBox.Show("Falta ingresar TORNEO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.cmb_Torneo.Focus()
            Return False
        End If

        Dim sql As String
        sql = "SELECT F.fechaInicio"
        sql &= " FROM FECHAS F JOIN Torneos T ON F.idTorneo = T.id"
        sql &= " WHERE T.nombre LIKE '" & cmb_Torneo.SelectedValue & "'"
        Dim acceso As New AccesoDatos
        Dim tabla As New DataTable
        tabla = acceso.leerTablaSQL(sql)

        Dim fechaTabla As New Date
        If tabla.Rows.Count() > 0 Then
            For i = 0 To tabla.Rows.Count()
                fechaTabla = tabla.Rows(i)("fechaInicio")
                If fechaTabla = dtp_Desde.Value Then
                    MessageBox.Show("La fecha ingresada ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dtp_Desde.Focus()
                    Return False
                End If
            Next
        End If

        sql = "SELECT T.fechaDesdeTorneo, T.fechaHastaTorneo"
        sql &= " FROM Torneos T"
        sql &= " WHERE T.id = " & cmb_Torneo.SelectedValue
        tabla = acceso.leerTablaSQL(sql)


        fechaTabla = tabla.Rows(0)("fechaDesdeTorneo")
        If dtp_Desde.Value < fechaTabla Then
            MessageBox.Show("La fecha de inicio de la FECHA no puede ser anterior a la fecha de inicio del Torneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtp_Desde.Focus()
            Return False
        End If

        fechaTabla = tabla.Rows(0)("fechaHastaTorneo")
        If dtp_Desde.Value > fechaTabla Then
            MessageBox.Show("La fecha de inicio de la FECHA no puede ser posterior a la fecha de fin del Torneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtp_Desde.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click
        If Me.validar() = True Then
            If condicion_estado = Estado.insertar Then
                Me.insertar()
            Else
                Me.modificar()
            End If
        End If

        Me.cmb_Torneo.Enabled = True

    End Sub
    Private Sub modificar()

        Dim sql As String = ""

        sql = "UPDATE Fechas SET fechaHasta = CONVERT (date, '" & Me.dtp_Desde.Value.ToString("dd/MM/yyyy") & "', 103)"
        sql &= " WHERE nro = " & grid_Datos.CurrentRow.Cells("col_fechaInicio").Value & " AND idTorneo = " & Me.cmb_Torneo.SelectedValue.ToString()

        acceso.modificarTabla(sql)

        MessageBox.Show("Torneo modificado exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

        condicion_estado = Estado.insertar

        Me.cargar_grilla()
        Me.cmb_Torneo.Enabled = True
    End Sub
    Private Sub insertar()

        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim sqlTorneo As String = ""


        sqlTorneo = "SELECT * FROM Torneos WHERE id = " & Me.cmb_Torneo.SelectedValue.ToString()


        If acceso.leerTablaSQL(sqlTorneo).Rows.Count() = 1 Then

            sql = "INSERT INTO Fechas (nro, idTorneo, fechaInicio) "
            sql &= "VALUES (" & calcularId() & ", " & Me.cmb_Torneo.SelectedValue.ToString()
            sql &= ", CONVERT (date, '" & Me.dtp_Desde.Value.ToString("dd/MM/yyyy") & "', 103) )"

            acceso.modificarTabla(sql)

            MessageBox.Show("Se grabó exitosamente", "Noticia", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.cargar_grilla()

        Else
            MessageBox.Show("No se puede guardar fecha porque el torneo no existe")

        End If



    End Sub

    Private Sub grid_Datos_CellDoubleClick(bsender As Object, e As DataGridViewCellEventArgs) Handles grid_Datos.CellDoubleClick

        condicion_estado = Estado.modificar
        Dim sqlTorneo As String = ""
        Dim sql As String = ""
        Dim tabla As New DataTable

        sqlTorneo = "SELECT * FROM Torneos WHERE nombre LIKE '" & Me.grid_Datos.CurrentRow.Cells(0).Value & "'"

        sql = "SELECT * FROM Fechas "
        sql &= " WHERE nro = " & Me.grid_Datos.CurrentRow.Cells(1).Value
        sql &= " AND idTorneo = " & acceso.leerTablaSQL(sqlTorneo).Rows(0)("id")

        tabla = acceso.leerTablaSQL(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Se Ha Borrado La Fecha", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If


        Me.cmb_Torneo.SelectedValue = tabla.Rows(0)("idTorneo")
        Me.dtp_Desde.Value = tabla.Rows(0)("fechaInicio")

        Me.cmb_Torneo.Enabled = False
    End Sub

    Private Sub cmd_Cancelar_Click(ByVal byVasender As Object, ByVal e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub

    Private Sub cmd_Borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        If MessageBox.Show("¿Esta seguro que borrar este registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            Dim sqlt As String = ""
            Dim sql As String = ""

            sqlt = "SELECT * FROM Torneos WHERE nombre LIKE '" & Me.grid_Datos.CurrentRow.Cells(0).Value & "'"

            sql = "DELETE FROM Fechas"
            sql &= " WHERE nro = " & Me.grid_Datos.CurrentRow.Cells(1).Value
            sql &= " AND idTorneo = " & acceso.leerTablaSQL(sqlt).Rows(0)("id")


            acceso.modificarTabla(sql)

            Me.cargar_grilla()

            MessageBox.Show("Torneo eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.cmb_Torneo.Enabled = True
        End If
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.cmb_Torneo.Enabled = True
        Me.cargar_grilla()
    End Sub


End Class
