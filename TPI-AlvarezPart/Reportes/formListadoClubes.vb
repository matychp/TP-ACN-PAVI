Public Class frm_ListadoClubes

    Private Sub ListadoClubes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frm_ListadoClubes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
    Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class