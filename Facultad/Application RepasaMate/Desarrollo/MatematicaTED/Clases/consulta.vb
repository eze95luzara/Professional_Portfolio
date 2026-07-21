Public Class consulta
    Dim conexion As New Data.OleDb.OleDbConnection
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim cadenaConexion As String

    Public Sub New()
        cadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-7HFAD6L\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=RepasaMate"
    End Sub

    Public Sub New(ByVal conexionstring1)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim CadenaConexion As String = conexionstring1
    End Sub

    Public Sub Conectar()
        Me.conexion.ConnectionString = Me.cadenaConexion
        Me.conexion.Open()
        Me.cmd.Connection = conexion
        Me.cmd.CommandType = CommandType.Text
    End Sub

    Public Function Modificacion(ByVal comando As String) As Boolean
        Me.Conectar()
        Me.cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        Me.conexion.Close()
        Return True
    End Function

    Public Function Consulta(ByVal comando As String) As Data.DataTable
        Dim tab As New Data.DataTable
        Me.Conectar()
        Me.cmd.CommandText = comando
        tab.Load(Me.cmd.ExecuteReader)
        Me.conexion.Close()
        Return tab
    End Function

End Class
