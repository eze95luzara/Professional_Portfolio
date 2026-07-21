Public Class Frm_Categoria
    Private Sub Frm_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Dim consulta As New consulta

    Private Sub Cmd_Volver_Click(sender As Object, e As EventArgs) Handles Cmd_Volver.Click
        Dim frm As New frm_verCues
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub Cmd_Seguir_Click(sender As Object, e As EventArgs) Handles Cmd_Seguir.Click
        Dim frm As New Frm_Preguntas
        frm.agregarNomCuestionario(Grid_Categoria.CurrentRow.Cells(2).Value)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub cargarGrilla()

        Dim consulta As New consulta
        Dim datosUser As New Data.DataTable
        Dim pregunta As String = "select * from Categoria"
        datosUser = consulta.Consulta(pregunta)

        Me.Grid_Categoria.Rows.Clear()

        Dim i As Integer = 0
        For i = 0 To datosUser.Rows.Count() - 1
            Grid_Categoria.Rows.Add()
            Grid_Categoria.Rows(i).Cells("Col_IdC").Value = datosUser.Rows(i)("idCategoria")
            Grid_Categoria.Rows(i).Cells("Col_Nombre").Value = datosUser.Rows(i)("nombreCateoria")
            Grid_Categoria.Rows(i).Cells("Col_Desc").Value = datosUser.Rows(i)("descripcion")
        Next

        Grid_Categoria.AutoResizeColumns()

    End Sub

    Private Sub Grid_Categoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Categoria.CellContentClick
        Me.Cmd_Seguir.Enabled = False
    End Sub


    Private Sub frm_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
        Me.Cmd_Seguir.Enabled = False
    End Sub

    Private Sub Grid_Categoria_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Categoria.CellContentDoubleClick
        Me.Cmd_Seguir.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
