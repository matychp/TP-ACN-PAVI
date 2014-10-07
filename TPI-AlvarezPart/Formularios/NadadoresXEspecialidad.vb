Public Class frm_NadadoresXEspecialidad

    Private Sub NadadoresXEspecialidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.TPIPAVIDataSet.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.TPIPAVIDataSet.Especialidad)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.NadaXEspe' Puede moverla o quitarla según sea necesario.
        Me.NadaXEspeTableAdapter.Fill(Me.TPIPAVIDataSet.NadaXEspe)

    End Sub
End Class