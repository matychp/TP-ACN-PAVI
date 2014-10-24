Public Class frm_EstProfClub
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}
    Private Sub EstProfClub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.cargarDatosEstadistica()
    End Sub

    Private Sub frm_TorneoXClub_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
     Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cargarDatosEstadistica()
        Dim sql As String = ""
        sql &= " SELECT        COUNT(ProfXClub.CodProf) AS 'cantProfes', Clubes.Nombre AS 'Club'"
        sql &= " FROM            Clubes INNER JOIN"
        sql &= "                 ProfXClub ON Clubes.CodClub = ProfXClub.CodClub"
        sql &= " GROUP BY ProfXClub.CodClub, Clubes.Nombre"
        DataTable1BindingSource.DataSource = acceso.ejecutar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class