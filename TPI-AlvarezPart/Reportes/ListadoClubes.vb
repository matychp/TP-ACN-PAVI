Public Class frm_ListadoClubes

    Private Sub ListadoClubes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class