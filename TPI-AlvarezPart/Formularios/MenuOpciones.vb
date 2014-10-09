Public Class MenuOpciones

    Private Sub MenuOpciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmd_clubafiliado.Visible = cambiarBoolean(cmd_clubafiliado.Visible)
        cmd_codpostal.Visible = cambiarBoolean(cmd_codpostal.Visible)
        cmd_especialidades.Visible = cambiarBoolean(cmd_especialidades.Visible)
        cmd_nadadores.Visible = cambiarBoolean(cmd_nadadores.Visible)
        cmd_profesores.Visible = cambiarBoolean(cmd_profesores.Visible)
        cmd_tipodocumento.Visible = cambiarBoolean(cmd_tipodocumento.Visible)
        cmd_torneos.Visible = cambiarBoolean(cmd_torneos.Visible)
        cmd_nadXespe.Visible = cambiarBoolean(cmd_nadXespe.Visible)
        cmd_profXespe.Visible = cambiarBoolean(cmd_profXespe.Visible)
        cmd_TorneosXAño.Visible = cambiarBoolean(cmd_TorneosXAño.Visible)
        'Me.cambiarEstadoBotones()
    End Sub

    Private Sub cmd_profesores_Click(sender As System.Object, e As System.EventArgs) Handles cmd_profesores.Click
        form_ABMProfesor.ShowDialog()
    End Sub

    Private Sub cmd_procesos_Click(sender As System.Object, e As System.EventArgs) Handles cmd_procesos.Click

        cmd_nadXespe.Visible = cambiarBoolean(cmd_nadXespe.Visible)
        cmd_profXespe.Visible = cambiarBoolean(cmd_profXespe.Visible)
        cmd_TorneosXAño.Visible = cambiarBoolean(cmd_TorneosXAño.Visible)
    End Sub

    Private Sub cambiarColorBoton(sender As System.Object, e As System.EventArgs) Handles cmd_abm.Click, cmd_listconsultas.Click, cmd_estadisticas.Click _
                                            , cmd_procesos.Click
        If sender.BackColor = Color.GreenYellow Then
            sender.BackColor = Color.White
        Else
            sender.BackColor = Color.GreenYellow
        End If
    End Sub


    Private Function cambiarBoolean(ByVal var As Boolean)
        If var = True Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmd_abm_Click(sender As System.Object, e As System.EventArgs) Handles cmd_abm.Click
        'Me.cambiarEstadoBotones()
        cmd_clubafiliado.Visible = cambiarBoolean(cmd_clubafiliado.Visible)
        cmd_codpostal.Visible = cambiarBoolean(cmd_codpostal.Visible)
        cmd_especialidades.Visible = cambiarBoolean(cmd_especialidades.Visible)
        cmd_nadadores.Visible = cambiarBoolean(cmd_nadadores.Visible)
        cmd_profesores.Visible = cambiarBoolean(cmd_profesores.Visible)
        cmd_tipodocumento.Visible = cambiarBoolean(cmd_tipodocumento.Visible)
        cmd_torneos.Visible = cambiarBoolean(cmd_torneos.Visible)
       
    End Sub


    Private Sub MenuOpciones_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea Salir?", "¡Importante!", _
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
       Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cmd_nadadores_Click(sender As System.Object, e As System.EventArgs) Handles cmd_nadadores.Click
        frm_ABMnadadores.ShowDialog()
    End Sub

    Private Sub cmd_especialidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_especialidades.Click
        Form_ABMEspecialidad.ShowDialog()
    End Sub
    Private Sub cmd_tipoDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tipodocumento.Click
        frm_abmTipoDocumento.ShowDialog()
    End Sub

    Private Sub cmd_clubafiliado_Click(sender As System.Object, e As System.EventArgs) Handles cmd_clubafiliado.Click
        frm_ClubAfiliado.ShowDialog()
    End Sub

    Private Sub cmd_torneos_Click(sender As System.Object, e As System.EventArgs) Handles cmd_torneos.Click
        frm_ABMTorneos.ShowDialog()
    End Sub

    Private Sub cmd_codpostal_Click(sender As System.Object, e As System.EventArgs) Handles cmd_codpostal.Click
        Form_ABMCodigosPost.ShowDialog()
    End Sub

    Private Sub cmd_nadXespe_Click(sender As System.Object, e As System.EventArgs) Handles cmd_nadXespe.Click
        frm_NadadoresXEspecialidad.ShowDialog()
    End Sub

    Private Sub cmd_profXespe_click(sender As System.Object, e As System.EventArgs) Handles cmd_profXespe.Click
        frm_ProfesorXEspecialidad.ShowDialog()
    End Sub

    Private Sub cmd_TorneosXAño_Click(sender As System.Object, e As System.EventArgs) Handles cmd_TorneosXAño.Click
        frm_TorneosXAño.ShowDialog()
    End Sub
End Class