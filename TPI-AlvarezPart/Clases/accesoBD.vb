Public Class accesoBD
        Enum BaseDatos
            Oledb
            OledbOracle
            OledbSqlServer
            SqlServer
            Oracle
        End Enum
        Dim CadenaConexion As String = ""
        Dim conexion As Object
        Dim cmd As Object
        Dim tipoBaseDatos As BaseDatos

        Public WriteOnly Property _cadenaConexion As String
            Set(value As String)
                CadenaConexion = value
            End Set
        End Property

        Public Property _tipoBaseDatos As BaseDatos
            Get
                Return tipoBaseDatos
            End Get
            Set(value As BaseDatos)
                tipoBaseDatos = value
            End Set
        End Property

        Public Sub New()
                    Me.conexion = New Data.SqlClient.SqlConnection()
                    Me.cmd = New Data.SqlClient.SqlCommand()
        End Sub

        Private Sub conectar()
        ' Dim conexion As New Data.SqlClient.SqlConnection
        ' Dim cmd As New Data.SqlClient.SqlCommand
        conexion.ConnectionString = Me.CadenaConexion
        Try
            conexion.Open()
        Catch e As Exception
            MessageBox.Show(e.Message, "Error de Conexion:")
            Exit Sub
        End Try

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
    End Sub

    Public Function ejecutar(ByVal sql As String) As Data.DataTable
        Me.conectar()
        Dim tabla As New Data.DataTable
        Me.cmd.CommandText = sql
        Try
            tabla.Load(Me.cmd.ExecuteReader())
        Catch e As Exception
            MessageBox.Show(e.Message, "Error en consulta.")
        End Try

        conexion.Close()
        Return tabla
    End Function

    Public Sub ejecutarNonConsulta(ByVal sql As String)
        Me.conectar()
        Me.cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch e As Exception
            MessageBox.Show(e.Message, "Error al intentar modificar la base de datos:")
        End Try

        conexion.Close()
    End Sub
    End Class

