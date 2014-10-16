Public Class frm_ListadoProfesores

    Private Sub ListadoProfesores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.TPIPAVIDataSet.Profesores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class