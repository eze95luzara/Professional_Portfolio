Public Class ComboBoxV1
    Inherits ComboBox 'Extends ComboBox

    Dim nombreTabla As String = ""
    Dim pk As String = ""
    Dim descripcion As String = ""


    Public Property _nombreTabla As String
        Get
            Return nombreTabla

        End Get
        Set(value As String)

            nombreTabla = value

        End Set
    End Property

    Public Property _pk As String
        Get
            Return pk
        End Get
        Set(value As String)
            pk = value
        End Set
    End Property

    Public Property _descripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property



    Public Sub cargar()
        Dim tabla As New DataTable
        Dim acceso As New AccesoDatos

        tabla = acceso.leerTabla(nombreTabla)
        Me.DisplayMember = descripcion
        Me.ValueMember = pk
        Me.DataSource = tabla
        Me.SelectedIndex = -1

    End Sub

    Public Sub cargar(ByRef tabla As DataTable)

        Dim acceso As New AccesoDatos

        Me.DisplayMember = descripcion
        Me.ValueMember = pk
        Me.DataSource = tabla
        Me.SelectedIndex = -1
    End Sub

End Class