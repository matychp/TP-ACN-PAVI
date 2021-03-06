﻿Public Class MenuOpciones

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
        cmd_Inscriptos.Visible = cambiarBoolean(cmd_Inscriptos.Visible)
        cmd_ProfXClub.Visible = cambiarBoolean(cmd_ProfXClub.Visible)
        cmd_espeXCompe.Visible = cambiarBoolean(cmd_espeXCompe.Visible)
        cmd_ProfesoresClubAl.Visible = cambiarBoolean(cmd_ProfesoresClubAl.Visible)
        cmd_posicionTiempoNad.Visible = cambiarBoolean(cmd_posicionTiempoNad.Visible)
        cmd_torPorAñoClub.Visible = cambiarBoolean(cmd_torPorAñoClub.Visible)
        cmd_consultaespeXcompe.Visible = cambiarBoolean(cmd_consultaespeXcompe.Visible)
        cmd_listnadadores.Visible = cambiarBoolean(cmd_listnadadores.Visible)
        cmd_listadoClubes.Visible = cambiarBoolean(cmd_listadoClubes.Visible)
        cmd_listadoEspecialidades.Visible = cambiarBoolean(cmd_listadoEspecialidades.Visible)
        cmd_listadoProfesores.Visible = cambiarBoolean(cmd_listadoProfesores.Visible)
        cmd_frm_EstTorneosAño.Visible = cambiarBoolean(cmd_frm_EstTorneosAño.Visible)
        cmd_estadisticaProfeClub.Visible = cambiarBoolean(cmd_estadisticaProfeClub.Visible)
        'Me.cambiarEstadoBotones()
    End Sub

    Private Sub cmd_profesores_Click(sender As System.Object, e As System.EventArgs) Handles cmd_profesores.Click
        form_ABMProfesor.ShowDialog()
    End Sub

    Private Sub cmd_procesos_Click(sender As System.Object, e As System.EventArgs) Handles cmd_procesos.Click

        cmd_nadXespe.Visible = cambiarBoolean(cmd_nadXespe.Visible)
        cmd_profXespe.Visible = cambiarBoolean(cmd_profXespe.Visible)
        cmd_TorneosXAño.Visible = cambiarBoolean(cmd_TorneosXAño.Visible)
        cmd_Inscriptos.Visible = cambiarBoolean(cmd_Inscriptos.Visible)
        cmd_ProfXClub.Visible = cambiarBoolean(cmd_ProfXClub.Visible)
        cmd_espeXCompe.Visible = cambiarBoolean(cmd_espeXCompe.Visible)
    End Sub

    Private Sub cmd_listconsul_click(sender As System.Object, e As System.EventArgs) Handles cmd_listconsultas.Click
        cmd_ProfesoresClubAl.Visible = cambiarBoolean(cmd_ProfesoresClubAl.Visible)
        cmd_posicionTiempoNad.Visible = cambiarBoolean(cmd_posicionTiempoNad.Visible)
        cmd_torPorAñoClub.Visible = cambiarBoolean(cmd_torPorAñoClub.Visible)
        cmd_consultaespeXcompe.Visible = cambiarBoolean(cmd_consultaespeXcompe.Visible)
        cmd_listnadadores.Visible = cambiarBoolean(cmd_listnadadores.Visible)
        cmd_listadoClubes.Visible = cambiarBoolean(cmd_listadoClubes.Visible)
        cmd_listadoEspecialidades.Visible = cambiarBoolean(cmd_listadoEspecialidades.Visible)
        cmd_listadoProfesores.Visible = cambiarBoolean(cmd_listadoProfesores.Visible)
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

    Private Sub cmd_Inscriptos_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Inscriptos.Click
        frm_Inscriptos.ShowDialog()
    End Sub

    Private Sub cmd_ProfXClub_Click(sender As System.Object, e As System.EventArgs) Handles cmd_ProfXClub.Click
        frm_ProfesorXClub.ShowDialog()
    End Sub

    Private Sub cmd_espeXCompe_Click(sender As System.Object, e As System.EventArgs) Handles cmd_espeXCompe.Click
        frm_EspecialidadXCompetencia.ShowDialog()
    End Sub

    Private Sub cmd_consultaEXC_click(sender As System.Object, e As System.EventArgs) Handles cmd_consultaespeXcompe.Click
        frm_ResultadosCompeXEspe.ShowDialog()
    End Sub

    Private Sub cmd_ProfesoresClubAl_Click(sender As System.Object, e As System.EventArgs) Handles cmd_ProfesoresClubAl.Click
        frm_ProfesoresConAlumnosEnClub.ShowDialog()
    End Sub

    Private Sub cmd_torPorAñoClub_Click(sender As System.Object, e As System.EventArgs) Handles cmd_torPorAñoClub.Click
        frm_TorneoRealizadosEnElAñoEnUnClub.ShowDialog()
    End Sub

    Private Sub cmd_posicionTiempoNad_Click(sender As System.Object, e As System.EventArgs) Handles cmd_posicionTiempoNad.Click
        frm_PosicionTiempoNadadores.ShowDialog()
    End Sub

    Private Sub cmd_listnadadores_Click(sender As System.Object, e As System.EventArgs) Handles cmd_listnadadores.Click
        frm_ListadoNadadores.ShowDialog()
    End Sub

    Private Sub cmd_listadoClubes_Click(sender As System.Object, e As System.EventArgs) Handles cmd_listadoClubes.Click
        frm_ListadoClubes.ShowDialog()
    End Sub

    Private Sub cmd_listadoProfesores_Click(sender As System.Object, e As System.EventArgs) Handles cmd_listadoProfesores.Click
        frm_ListadoProfesores.ShowDialog()
    End Sub

    Private Sub cmd_listadoEspecialidades_Click(sender As System.Object, e As System.EventArgs) Handles cmd_listadoEspecialidades.Click
        frm_ListadoEspecialidades.ShowDialog()
    End Sub

    Private Sub cmd_frm_EstTorneosAño_Click(sender As System.Object, e As System.EventArgs) Handles cmd_frm_EstTorneosAño.Click
        frm_EstTorneosAño.ShowDialog()
    End Sub

    Private Sub cmd_estadisticaProfeClub_Click(sender As System.Object, e As System.EventArgs) Handles cmd_estadisticaProfeClub.Click
        frm_EstProfClub.ShowDialog()
    End Sub

    Private Sub cmd_estadisticas_Click(sender As System.Object, e As System.EventArgs) Handles cmd_estadisticas.Click

        cmd_frm_EstTorneosAño.Visible = cambiarBoolean(cmd_frm_EstTorneosAño.Visible)
        cmd_estadisticaProfeClub.Visible = cambiarBoolean(cmd_estadisticaProfeClub.Visible)
    End Sub
End Class