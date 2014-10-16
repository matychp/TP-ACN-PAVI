Public Class frm_ListadoEspecialidades

    Private Sub ListadoEspecialidades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.TPIPAVIDataSet.Especialidad)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class