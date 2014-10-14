Public Class frm_ResultadosCompeXEspe

    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub ResultadosCompeXEspe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.TPIPAVIDataSet.Especialidad)
        Me.cmb_especialidad.SelectedIndex = -1
        Me.tt_consultaestandar.SetToolTip(cmd_ejecutarConsulta, "Consulta la Competencia por Especialidad del año actual")
        Me.tt_consultapersonal.SetToolTip(cmd_ejecutarConsultaPerso, "Consulta la Competencia por Especialidad" & vbCrLf & " con el o los parámetros ingresados arriba (el Año es obligatorio)")
    End Sub

    Private Sub resultado()
        Dim txt_sql As String
        Dim tabla As Data.DataTable
        txt_sql = " Select TORNEOS.Descrip AS 'Torneo' , Especialidad.Descripcion AS 'Especialidad', EspecXCompet.Año, EspecXCompet.Fecha  "
        txt_sql &= " From EspecXCompet INNER JOIN Especialidad ON EspecXCompet.CodEspe = Especialidad.CodEspe "
        txt_sql &= " INNER JOIN TorneosXAño ON EspecXCompet.Año = TorneosXAño.Año AND EspecXCompet.CodTorneo = TorneosXAño.CodTorneo "
        txt_sql &= " INNER JOIN TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo "
        txt_sql &= " Where EspecXCompet.Año = Year(GETDATE()) "
        tabla = acceso.ejecutar(txt_sql)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado coincidencias con la busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.grd_dgvconsultaComXEspe.DataSource = tabla
        End If

    End Sub

    Private Sub resultado(ByVal year As Integer, ByVal especialidad As Integer)
        Dim txt_sql As String
        Dim tabla As Data.DataTable = New Data.DataTable
        Dim tablaAux As Data.DataTable = New Data.DataTable
        If cmb_especialidad.SelectedIndex < 0 Then
            txt_sql = " Select TORNEOS.Descrip AS 'Torneo' , Especialidad.Descripcion AS 'Especialidad', EspecXCompet.Año, EspecXCompet.Fecha  "
            txt_sql &= " From EspecXCompet INNER JOIN Especialidad ON EspecXCompet.CodEspe = Especialidad.CodEspe "
            txt_sql &= " INNER JOIN TorneosXAño ON EspecXCompet.Año = TorneosXAño.Año AND EspecXCompet.CodTorneo = TorneosXAño.CodTorneo "
            txt_sql &= " INNER JOIN TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo "
            txt_sql &= " Where EspecXCompet.Año = " & year
        Else
            txt_sql = " Select TORNEOS.Descrip AS 'Torneo' , Especialidad.Descripcion AS 'Especialidad', EspecXCompet.Año, EspecXCompet.Fecha  "
            txt_sql &= " From EspecXCompet INNER JOIN Especialidad ON EspecXCompet.CodEspe = Especialidad.CodEspe "
            txt_sql &= " INNER JOIN TorneosXAño ON EspecXCompet.Año = TorneosXAño.Año AND EspecXCompet.CodTorneo = TorneosXAño.CodTorneo "
            txt_sql &= " INNER JOIN TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo "
            txt_sql &= " Where EspecXCompet.Año = " & year & " AND EspecXCompet.CodEspe = " & especialidad
        End If
    
        tabla = acceso.ejecutar(txt_sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado coincidencias con la busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.grd_dgvconsultaComXEspe.DataSource = tablaAux
        Else

            Me.grd_dgvconsultaComXEspe.DataSource = tabla
        End If

        msk_anio.Text = ""
        cmb_especialidad.SelectedIndex = -1
    End Sub

    Private Function validar() As Boolean
        Dim tablaAux As Data.DataTable = New Data.DataTable
        If Me.msk_anio.Text = "" Then
            MessageBox.Show("Debe ingresar el año a consultar para la Consulta Personalizada", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.msk_anio.Focus()
            Me.grd_dgvconsultaComXEspe.DataSource = tablaAux
            Return False
        End If
        Return True
    End Function

    Private Sub cmd_ejecutarConsulta_Click(sender As System.Object, e As System.EventArgs) Handles cmd_ejecutarConsultaPerso.Click

        If Me.validar() = True Then
            Dim year As Integer = Me.msk_anio.Text
            Dim espe As Integer = cmb_especialidad.SelectedValue
            Me.resultado(year, espe)
        End If
   
    End Sub


    Private Sub cmd_ejecutarConsulta_Click_1(sender As System.Object, e As System.EventArgs) Handles cmd_ejecutarConsulta.Click
        Me.resultado()
    End Sub

    Private Sub frm_EspecialidadXTorneo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
     Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub



    Private Sub cmd_help_Click(sender As System.Object, e As System.EventArgs) Handles cmd_help.Click
        Dim mensaje As String
        mensaje = "Para consultar la Competencia por Especialidad del año actual presione Consulta Estándar" & vbCrLf
        mensaje &= "Para consultar con Parámetros ingrese un Año Y/O una Especialidad y presione "
        mensaje &= "Consulta Personalizada"
        MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

 
End Class