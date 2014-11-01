Public Class frm_ListadoEspecialidades

    Private Sub ListadoEspecialidades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.TPIPAVIDataSet.Especialidad)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frm_ListadoEspecialidades_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
    Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class