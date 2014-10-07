Public Class accesoBD
        Enum BaseDatos
            Oledb
            OledbOracle
            OledbSqlServer
            SqlServer
            Oracle
    End Enum
    Enum estadoProceso
        proceso_ok
        proceso_error
    End Enum
        Dim CadenaConexion As String = ""
        Dim conexion As Object
        Dim cmd As Object
    Dim tipoBaseDatos As BaseDatos
    Dim estadoTransaccion As estadoProceso = estadoProceso.proceso_ok
    Dim transaccion As New Object


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
        conexion.ConnectionString = Me.CadenaConexion
        Try
            conexion.Open()
        Catch e As Exception
            MessageBox.Show(e.Message, "Error de Conexion:")
            Exit Sub
        End Try

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        transaccion = conexion.BeginTransaction()
        cmd.Transaction = transaccion
    End Sub

    Public Function ejecutar(ByVal sql As String) As Data.DataTable
        Me.conectar()
        Dim tabla As New Data.DataTable
        Me.cmd.CommandText = sql
        Try
            tabla.Load(Me.cmd.ExecuteReader())
        Catch e As Exception
            MessageBox.Show(e.Message, "Error en consulta.")
            estadoTransaccion = estadoProceso.proceso_error
        End Try

        desconectar()
        Return tabla
    End Function

    Public Sub ejecutarNonConsulta(ByVal sql As String)
        Me.conectar()
        Me.cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch e As Exception
            MessageBox.Show(e.Message, "Error al intentar modificar la base de datos:")
            estadoTransaccion = estadoProceso.proceso_error
        End Try

        desconectar()
    End Sub

    Public Sub desconectar()
        If estadoTransaccion = estadoProceso.proceso_ok Then
            transaccion.Commit()
            conexion.Close()
        Else
            transaccion.Rollback()
            conexion.Close()
        End If
    End Sub
    End Class

