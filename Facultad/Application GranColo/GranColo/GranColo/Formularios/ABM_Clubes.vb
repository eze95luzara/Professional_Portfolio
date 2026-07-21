Public Class ABM_Clubes
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=JUAMPI;Integrated Security=SSPI;Initial Catalog=GranColo"
    Enum estado
        modificar
        insertar
    End Enum

    Dim condicion_estado As estado = estado.insertar
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_Grilla()
    End Sub

    Private Function calcularId() As Integer
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim acceso As New AccesoDatos


        sql = "SELECT C.id "
        sql &= "FROM Clubes C "
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

    Private Sub cargar_Grilla()
        Dim acceso As New AccesoDatos
        Dim tabla As New Data.DataTable

        tabla = acceso.leerTabla("Clubes")

        Me.grid_Club.Rows.Clear()

        Dim i As Integer = 0
        For i = 0 To tabla.Rows.Count() - 1
            grid_Club.Rows.Add()
            grid_Club.Rows(i).Cells(0).Value = tabla.Rows(i)("id")
            grid_Club.Rows(i).Cells(1).Value = tabla.Rows(i)("nombre")
            grid_Club.Rows(i).Cells(2).Value = tabla.Rows(i)("fechaFundacion")
            grid_Club.Rows(i).Cells(3).Value = tabla.Rows(i)("nombreEstadio")
            grid_Club.Rows(i).Cells(4).Value = tabla.Rows(i)("direccion")
            grid_Club.Rows(i).Cells(5).Value = tabla.Rows(i)("aforo")
        Next
        grid_Club.AutoResizeColumns()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        txt_NombreClub.Text = ""
        txt_NombreEstadio.Text = ""
        dtp_FechaFundacion.Value = Date.Now
        txt_Direccion.Text = ""
        txt_Aforo.Text = ""

        condicion_estado = estado.insertar


    End Sub

    Private Sub cmd_Cancelar_Click(sender As Object, e As EventArgs) Handles cmd_Cancelar.Click
        Close()
    End Sub

    Private Sub cmd_Guardar_Click(sender As Object, e As EventArgs) Handles cmd_Guardar.Click

        If validar() = True Then

            Dim acceso As New AccesoDatos

            Dim sql As String = ""

            Dim operacion As String = "modificado"

            If condicion_estado = estado.insertar Then
                sql = "INSERT INTO Clubes"
                sql &= " (id, nombre, fechaFundacion, nombreEstadio, direccion, aforo)"
                sql &= " values(" & Me.calcularId() & ", '" & Me.txt_NombreClub.Text & "', CONVERT(date, '" & Me.dtp_FechaFundacion.Value.ToString("dd/MM/yyyy") & "', 103)"
                sql &= ", '" & Me.txt_NombreEstadio.Text & "', '" & Me.txt_Direccion.Text & "', " & Me.txt_Aforo.Text & ")"
                operacion = "guardado"
            Else
                sql = "UPDATE Clubes "
                sql &= "SET nombre = '" & Me.txt_NombreClub.Text & "', fechaFundacion = "
                sql &= "CONVERT(date, '" & Me.dtp_FechaFundacion.Value.ToString("dd/MM/yyyy") & "', 103) " & ", nombreEstadio = '"
                sql &= Me.txt_NombreEstadio.Text & "', direccion = '" & Me.txt_Direccion.Text & "', aforo = '" & Me.txt_Aforo.Text & "' "
                sql &= "WHERE id = " & Me.grid_Club.CurrentRow.Cells(0).Value

            End If

            acceso.modificarTabla(sql)
            MessageBox.Show("Club " & operacion & " exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.cargar_Grilla()
            condicion_estado = estado.insertar
        End If


    End Sub

    Private Function validar() As Boolean

        If txt_NombreClub.Text = "" Then
            MessageBox.Show("Falta ingresar NOMBRE DEL CLUB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_NombreClub.Focus()
            Return False
        End If

        Dim fecha As Date
        fecha = Me.dtp_FechaFundacion.Value
        Dim fechaActual As Date = Today
        If fecha.CompareTo(fechaActual) > 0 Then
            MessageBox.Show("La FECHA DE FUNDACIÓN del club no puede ser mayor a la fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txt_NombreEstadio.Text = "" Then
            MessageBox.Show("Falta ingresar NOMBRE DEL ESTADIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_NombreEstadio.Focus()
            Return False
        End If

        If txt_Direccion.Text = "" Then
            MessageBox.Show("Falta ingresar DIRECCIÓN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Direccion.Focus()
            Return False
        End If

        If txt_Aforo.Text = "" Then
            MessageBox.Show("Falta ingresar AFORO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Aforo.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles cmd_Eliminar.Click
        If MessageBox.Show("¿Está seguro que desea borrar el registro?", "Atención" _
                        , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                        = DialogResult.OK Then

            Dim acceso As New AccesoDatos

            If tieneJugadores(Me.grid_Club.CurrentRow.Cells(0).Value) Then
                Dim sql As String = ""

                sql = "DELETE FROM Clubes"
                sql &= " WHERE id = " & Me.grid_Club.CurrentRow.Cells(0).Value

                acceso.modificarTabla(sql)
                MessageBox.Show("Club eliminado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cargar_Grilla()
            End If

        End If
    End Sub

    Private Function tieneJugadores(ByVal club As Integer) As Boolean
        Dim acceso As New AccesoDatos
        Dim sql As String = ""
        Dim tabla As New DataTable


        sql = "SELECT 1 FROM Jugadores"
        sql &= " WHERE idClub = " & club

        tabla = acceso.leerTablaSQL(sql)
        'Esta condición, si es true, entonces tiene jugadores, y alerta
        If tabla.Rows.Count > 0 Then
            If MessageBox.Show("El club elegido tiene jugadores. Si lo elimina," _
                           & " los jugadores quedarán sin un club asignado. ¿Está seguro?" _
                           , "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) _
                           = DialogResult.OK Then
                Return True
            Else
                'Si no eligió OK, entonces no quiere eliminar, y devuelve falso
                Return False
            End If
        End If
        'Si el club no tiene jugadores, elimina
        Return True


    End Function

    Private Sub grid_Club_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Club.CellDoubleClick
        condicion_estado = estado.modificar

        txt_NombreClub.Text = grid_Club.CurrentRow.Cells(1).Value
        dtp_FechaFundacion.Value = grid_Club.CurrentRow.Cells(2).Value
        txt_NombreEstadio.Text = grid_Club.CurrentRow.Cells(3).Value
        txt_Direccion.Text = grid_Club.CurrentRow.Cells(4).Value
        txt_Aforo.Text = grid_Club.CurrentRow.Cells(5).Value

    End Sub

    Private Sub grid_Club_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_Club.CellContentClick

    End Sub
End Class
