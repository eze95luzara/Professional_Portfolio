Public Class llenado
    Dim conexion As New Data.OleDb.OleDbConnection
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim CadenaConexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-7HFAD6L\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=RepasaMate"

    Dim tabla As String = ""

    Public Sub New()

    End Sub

    Public Property StringConexion() As String
        Get
            Return Me.CadenaConexion
        End Get
        Set(value As String)
            Me.cadenaConexion = value
        End Set
    End Property

    Public Property Table() As String
        Get
            Return Me.tabla
        End Get
        Set(value As String)
            Me.tabla = value
        End Set
    End Property

    Public Sub New(ByVal cadenaConexion As String)
        Me.stringConexion = cadenaConexion
    End Sub

    Public Sub New(ByVal cadenaConexion As String, ByVal nombreTabla As String)
        Me.stringConexion = cadenaConexion
        Me.tabla = nombreTabla
    End Sub

    Public Sub Conectar()
        Me.conexion.ConnectionString = Me.stringConexion
        Me.conexion.Open()
        Me.cmd.Connection = conexion
        Me.cmd.CommandType = CommandType.Text
    End Sub

    Public Function leoTabla() As Data.DataTable
        Return Me.Consulta("select * from " & Me.tabla)
    End Function

    Public Function Consulta(ByVal comando As String) As Data.DataTable
        Dim tab As New Data.DataTable
        Me.Conectar()
        Me.cmd.CommandText = comando
        tab.Load(Me.cmd.ExecuteReader)
        Me.conexion.Close()
        Return tab
    End Function

    Public Function leoTabla(ByVal columnas As String) As Data.DataTable
        Return Me.Consulta("select " + columnas + " from " & Me.tabla)
    End Function

    Public Function leoTabla(ByVal columnas As String, ByVal nombreTabla As String) As Data.DataTable
        Return Me.Consulta("select " + columnas + " from " + nombreTabla)
    End Function

    'Tambien borra e inserta
    Public Function ModificarTabla(ByVal comando As String) As Boolean
        Me.Conectar()
        Me.cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        Me.conexion.Close()
        Return True
    End Function

    Public Sub llenarCombo(ByVal combo As ComboBox, nombreColumna As String, nombreTabla As String)
        Dim tab As Data.DataTable = leoTabla(nombreColumna, nombreTabla)
        For i As Integer = 0 To tab.Rows.Count - 1
            combo.Items.Add(tab.Rows(i)(0))
        Next
    End Sub

    Public Sub llenarCombo(ByVal combo As ComboBox, nombreColumna As String, nombreTabla As String, condicion As String)
        Dim comando As String = "select " + nombreColumna + " from " + nombreTabla + " " + condicion
        Dim tab As Data.DataTable = Consulta(comando)
        For i As Integer = 0 To tab.Rows.Count - 1
            combo.Items.Add(tab.Rows(i)(0))
        Next
    End Sub
End Class
