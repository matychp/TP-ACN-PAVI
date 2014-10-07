Public Class MenuOpciones
    Dim menuAbierto As Boolean = False

    Private Sub MenuOpciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmd_clubafiliado.Visible = False
        cmd_codpostal.Visible = False
        cmd_especialidades.Visible = False
        cmd_nadadores.Visible = False
        cmd_profesores.Visible = False
        cmd_tipodocumento.Visible = False
        cmd_torneos.Visible = False
    End Sub

    Private Sub cmd_profesores_Click(sender As System.Object, e As System.EventArgs) Handles cmd_profesores.Click
        form_ABMProfesor.ShowDialog()
    End Sub

    Private Sub cambiarColorBoton(sender As System.Object, e As System.EventArgs) Handles cmd_abm.Click, cmd_listconsultas.Click, cmd_estadisticas.Click _
                                            , cmd_procesos.Click
        If sender.BackColor = Color.GreenYellow Then
            sender.BackColor = Color.White
        Else
            sender.BackColor = Color.GreenYellow
        End If
    End Sub
    Private Sub cmd_abm_Click(sender As System.Object, e As System.EventArgs) Handles cmd_abm.Click


        If menuAbierto = False Then
            cmd_clubafiliado.Visible = True
            cmd_codpostal.Visible = True
            cmd_especialidades.Visible = True
            cmd_nadadores.Visible = True
            cmd_profesores.Visible = True
            cmd_tipodocumento.Visible = True
            cmd_torneos.Visible = True
            menuAbierto = True
        Else
            cmd_clubafiliado.Visible = False
            cmd_codpostal.Visible = False
            cmd_especialidades.Visible = False
            cmd_nadadores.Visible = False
            cmd_profesores.Visible = False
            cmd_tipodocumento.Visible = False
            cmd_torneos.Visible = False
            menuAbierto = False
        End If
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_NadadoresXEspecialidad.ShowDialog()
    End Sub
End Class