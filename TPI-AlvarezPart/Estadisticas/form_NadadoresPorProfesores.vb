Public Class form_NadadoresPorProfesores

    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}
    Private Sub form_NadadoresPorProfesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarReporte()
    End Sub
    Private Sub cargarReporte()
        Dim sql As String = ""

        sql &= "SELECT CodNad, Nadadores.Nombre, CodProf, Profesores.Nombre FROM Nadadores "
        sql &= "INNER JOIN Profesores ON Profesores.CodProf = Nadadores.CodProf GROUP BY Profesores.CodProf;"

        Me.dt_NadadoresPorProfesoresBindingSource.DataSource = acceso.ejecutar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class