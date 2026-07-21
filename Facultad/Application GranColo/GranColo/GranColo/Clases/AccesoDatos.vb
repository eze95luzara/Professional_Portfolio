Public Class AccesoDatos

    Dim cadenaConexion As String = "Provider=SQLNCLI11;Data Source=WINUSER-PC;Integrated Security=SSPI;Initial Catalog=GranColo"
    Dim conexion As Object
    Dim cmd As Object
    Dim nombreTabla As String = ""

    'Propiedades públicas: permiten el acceso a las variables internas privadas de la clase (Getters y Setters)
    Public Property _cadenaConexion As String
        Get
            Return cadenaConexion
        End Get
        Set(ByVal value As String)
            cadenaConexion = value
        End Set
    End Property

    Public Property _nombreTabla As String
        Get
            Return nombreTabla
        End Get
        Set(value As String)
            nombreTabla = value
        End Set
    End Property

    Public Function consulta(ByVal sql As String) As DataTable
        Return ejecutarLeer(sql)
    End Function

    Public Function leerTabla() As DataTable
        Return ejecutarLeer("SELECT * FROM " & Me.nombreTabla)
    End Function

    'Sobrecarga del método leerTabla
    Public Function leerTabla(ByVal tabla As String) As DataTable
        Return ejecutarLeer("SELECT * FROM " & tabla)
    End Function

    Public Function leerTablaSQL(ByVal sql As String) As DataTable
        Return ejecutarLeer(sql)
    End Function

    Public Sub modificarTabla(ByVal sql As String)
        ejecutarModificar(sql)
    End Sub

    Private Function ejecutarLeer(ByRef sql As String) As DataTable
        Dim tabla As New DataTable

        Me.conectar()
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader)

        Me.cerrar()

        Return tabla
    End Function

    Private Sub ejecutarModificar(ByRef sql As String)
        Dim tabla As New DataTable

        Me.conectar()
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()


        Me.cerrar()

    End Sub

    Private Sub cerrar()
        Me.conexion.close()

    End Sub

    Private Sub conectar()
        conexion = New OleDb.OleDbConnection
        cmd = New OleDb.OleDbCommand
        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

    End Sub

End Class
