Public Class frm_TorneoRealizadosEnElAñoEnUnClub

    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub TorneoRealizadosEnElAñoEnUnClub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)
        Me.cmb_club.SelectedIndex = -1
        Me.tt_consultaestandar.SetToolTip(cmd_ejecutarConsulta, "Consulta el Torneo realizado en un Club en el año actual")
        Me.tt_consultapersonal.SetToolTip(cmd_ejecutarConsultaPerso, "Consulta el Torneo realizado en un Club" & vbCrLf & " con el o los parámetros ingresados arriba (el Año es obligatorio)")

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub resultado()
        Dim txt_sql As String
        Dim tabla As Data.DataTable
        txt_sql = " Select TORNEOS.Descrip AS 'Torneo' , TorneosXAño.Año, Clubes.Nombre AS 'Club' "
        txt_sql &= " From TORNEOS INNER JOIN TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo "
        txt_sql &= " INNER JOIN Clubes ON TorneosXAño.CodClub = Clubes.CodClub "
        txt_sql &= " Where TorneosXAño.Año = Year(GETDATE()) "
        tabla = acceso.ejecutar(txt_sql)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado coincidencias con la busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.dt_torneosAñoBindingSource.DataSource = tabla
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub resultado(ByVal year As Integer, ByVal club As Integer)
        Dim txt_sql As String
        Dim tabla As Data.DataTable = New Data.DataTable
        Dim tablaAux As Data.DataTable = New Data.DataTable
        If cmb_club.SelectedIndex < 0 Then
            txt_sql = " Select TORNEOS.Descrip AS 'Torneo' , TorneosXAño.Año, Clubes.Nombre AS 'Club' "
            txt_sql &= " From TORNEOS INNER JOIN TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo "
            txt_sql &= " INNER JOIN Clubes ON TorneosXAño.CodClub = Clubes.CodClub "
            txt_sql &= " Where TorneosXAño.Año = " & year
        Else
            txt_sql = " Select TORNEOS.Descrip AS 'Torneo' , TorneosXAño.Año, Clubes.Nombre AS 'Club' "
            txt_sql &= " From TORNEOS INNER JOIN TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo "
            txt_sql &= " INNER JOIN Clubes ON TorneosXAño.CodClub = Clubes.CodClub "
            txt_sql &= " Where TorneosXAño.Año = " & year & " AND TorneosXAño.CodClub = " & club
        End If

        tabla = acceso.ejecutar(txt_sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado coincidencias con la busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dt_torneosAñoBindingSource.DataSource = tablaAux
        Else

            Me.dt_torneosAñoBindingSource.DataSource = tabla
        End If
        Me.ReportViewer1.RefreshReport()
        msk_anio.Text = ""
        cmb_club.SelectedIndex = -1
    End Sub

    Private Function validar() As Boolean
        Dim tablaAux As Data.DataTable = New Data.DataTable
        If Me.msk_anio.Text = "" Then
            MessageBox.Show("Debe ingresar el año a consultar para la Consulta Personalizada", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.msk_anio.Focus()
            Me.dt_torneosAñoBindingSource.DataSource = tablaAux
            Return False
        End If
        Return True
    End Function

    Private Sub cmd_ejecutarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ejecutarConsultaPerso.Click

        If Me.validar() = True Then
            Dim year As Integer = Me.msk_anio.Text
            Dim club As Integer = cmb_club.SelectedValue
            Me.resultado(year, club)
        End If

    End Sub

    Private Sub cmd_ejecutarConsulta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ejecutarConsulta.Click
        Me.resultado()
    End Sub

    Private Sub frm_TorneoXClub_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
     Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cmd_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_help.Click
        Dim mensaje As String
        mensaje = "Para consultar la Competencia realizada en un club del año actual presione Consulta Estándar" & vbCrLf
        mensaje &= "Para consultar con Parámetros ingrese un Año Y/O un Club y presione "
        mensaje &= "Consulta Personalizada"
        MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class