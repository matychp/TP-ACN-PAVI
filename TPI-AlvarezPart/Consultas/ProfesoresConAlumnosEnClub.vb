Public Class frm_ProfesoresConAlumnosEnClub


    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub ProfesoresConAlumnosEnClub_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
 Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ProfesoresConAlumnosEnClub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.TPIPAVIDataSet.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)
        cmb_club.SelectedIndex = -1
        cmb_nadador.SelectedIndex = -1

        Me.ReportViewer1.RefreshReport()
    End Sub

    'Private Sub resultado()
    '    Dim txt_sql As String
    '    Dim tabla As Data.DataTable
    '    txt_sql = " Select Profesores.Apellido, Nadadores.Apellido, Clubes.Nombre  "
    '    txt_sql &= " From Nadadores INNER JOIN Profesores ON Nadadores.CodProf = Profesores.CodProf "
    '    txt_sql &= " INNER JOIN Clubes ON Clubes.CodClub = Nadadores.CodClub "
    '    txt_sql &= " Where  "
    '    tabla = acceso.ejecutar(txt_sql)
    '    If tabla.Rows.Count = 0 Then
    '        MessageBox.Show("No se han encontrado coincidencias con la busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    Else
    '        Me.grd_dgvProAlClub.DataSource = tabla
    '    End If

    'End Sub

    Private Sub resultado(ByVal club As Integer, ByVal nadador As Integer)
        Dim txt_sql As String
        Dim tabla As Data.DataTable = New Data.DataTable
        Dim tablaAux As Data.DataTable = New Data.DataTable
        If cmb_nadador.SelectedIndex < 0 Then
            txt_sql = " Select Profesores.Apellido AS 'Profesor', Nadadores.Apellido AS 'Nadador', Clubes.Nombre AS 'Club'  "
            txt_sql &= " From Nadadores INNER JOIN Profesores ON Nadadores.CodProf = Profesores.CodProf "
            txt_sql &= " INNER JOIN Clubes ON Clubes.CodClub = Nadadores.CodClub "
            txt_sql &= " Where Nadadores.CodClub = " & club
        Else
            txt_sql = " Select Profesores.Apellido AS 'Profesor', Nadadores.Apellido AS 'Nadador', Clubes.Nombre AS 'Club'  "
            txt_sql &= " From Nadadores INNER JOIN Profesores ON Nadadores.CodProf = Profesores.CodProf "
            txt_sql &= " INNER JOIN Clubes ON Clubes.CodClub = Nadadores.CodClub "
            txt_sql &= " Where Nadadores.CodClub = " & club & " AND Nadadores.CodNad = " & nadador
        End If

        tabla = acceso.ejecutar(txt_sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado coincidencias con la busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dt_ProfAlClubBindingSource.DataSource = tablaAux
        Else

            Me.dt_ProfAlClubBindingSource.DataSource = tabla
        End If
        ReportViewer1.RefreshReport()
        cmb_club.SelectedIndex = -1
        cmb_nadador.SelectedIndex = -1
    End Sub

    Private Function validar() As Boolean
        Dim tablaAux As Data.DataTable = New Data.DataTable
        If Me.cmb_club.SelectedIndex = -1 Then
            MessageBox.Show("Debe ingresar un club para realizar la consulta", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_club.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub cmd_ejecutarConsulta_Click(sender As System.Object, e As System.EventArgs) Handles cmd_consultaPerso.Click

        If Me.validar() = True Then
            Dim clu As Integer = cmb_club.SelectedValue
            Dim nad As Integer = cmb_nadador.SelectedValue
            Me.resultado(clu, nad)
        End If

    End Sub

    Private Sub cmd_help_Click(sender As System.Object, e As System.EventArgs) Handles cmd_help.Click
        Dim mensaje As String
        mensaje = "Para consultar los profesores que tienen alumnos en un determinado club seleccione el club " & vbCrLf
        mensaje &= " Y/O el alumno y finalmente presione Ejecutar Consulta Personalizada "
        MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



End Class