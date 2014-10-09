Public Class frm_TorneosXAño
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim code, codn As String
    Dim accion As estado = estado.insertar
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub TorneosXAño_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.TORNEOS' Puede moverla o quitarla según sea necesario.
        Me.TORNEOSTableAdapter.Fill(Me.TPIPAVIDataSet.TORNEOS)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)


        cmb_club.Enabled = False
        cmb_torneo.Enabled = False
        msk_anio.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        Me.carga_grilla()
    End Sub
    Private Sub TorneosXAño_acceso_datos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
        Windows.Forms.DialogResult.OK Then
            cancelar()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cmd_cancelar.Enabled = True
        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = False

        cmb_club.Enabled = True
        cmb_torneo.Enabled = True
        msk_anio.Enabled = True
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.insertar
    End Sub

    Private Sub grd_ListaTorneos_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_DGVTorneosxAño.CellContentDoubleClick
        Dim txt_sql As String
        Dim tabla As Data.DataTable
        Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value
        Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
        Dim club As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Club").Value

        txt_sql = "SELECT TorneosXAño.CodTorneo, TorneosXAño.Año, TorneosXAño.CodClub " 'Club no lo considero, no es parte de la PK...
        txt_sql &= "FROM TORNEOS INNER JOIN"
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo INNER JOIN Clubes ON TorneosXAño.CodClub = Clubes.CodClub "
        txt_sql &= " WHERE (TorneosXAño.Año = '" & anio & "') AND (TORNEOS.Descrip = '" & torneo & "') AND (Clubes.Nombre = '" & club & "')"

        tabla = acceso.ejecutar(txt_sql)

        cmb_torneo.SelectedValue = tabla.Rows(0)("CodTorneo")
        cmb_club.SelectedValue = tabla.Rows(0)("CodClub")
        msk_anio.Text = tabla.Rows(0)("Año")

        cmb_club.Enabled = True
        'cmb_torneo.Enabled = True
        '   msk_anio.Enabled = True

        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.cmd_eliminar.Enabled = False

        Me.accion = estado.modificar

    End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into TorneosXAño "
        cmd &= "(CodTorneo, Año, CodClub) "
        cmd &= " values('" & Me.cmb_torneo.SelectedValue & "'"
        cmd &= ", '" & Me.msk_anio.Text & "', '" & cmb_club.SelectedValue & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click

        If MessageBox.Show("¿Está seguro que desea borrar ese registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            Dim txt_sql As String
            Dim tabla As Data.DataTable
            Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
            Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value

            txt_sql = "SELECT TorneosXAño.CodTorneo, TorneosXAño.Año "
            txt_sql &= "FROM  TORNEOS INNER JOIN"
            txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo "
            txt_sql &= " WHERE (TORNEOS.Descrip = '" & torneo & "') AND (TorneosXAño.Año = '" & anio & "')"

            tabla = acceso.ejecutar(txt_sql)
            code = tabla.Rows(0)("CodTorneo")
            codn = tabla.Rows(0)("Año")

            Dim txt_del As String = ""

            txt_del = "delete from TorneosXAño where (CodTorneo = " & code & ") AND (Año = " & codn & ") "

            acceso.ejecutarNonConsulta(txt_del)

            Me.carga_grilla()

        End If
    End Sub

    Private Sub carga_grilla()

        Dim txt_sql As String = ""

        txt_sql = "SELECT TORNEOS.Descrip AS 'Torneo', Clubes.Nombre AS 'Club', TorneosXAño.Año "
        txt_sql &= "FROM TORNEOS INNER JOIN"
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo INNER JOIN Clubes ON Clubes.CodClub = TorneosXAño.CodClub"
        grd_DGVTorneosxAño.DataSource = acceso.ejecutar(txt_sql)

    End Sub

    Private Function modificar() As termino

        Dim cmd As String = ""

        cmd = "Update TorneosXAño "
        cmd &= " Set CodClub = '" & cmb_club.SelectedValue & "'"
        cmd &= " where (CodTorneo = " & code & ") AND (Año = " & codn & ") "

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As DataTable

        consulta = "select * from TorneosXAño "
        consulta &= " where (CodTorneo = " & cmb_torneo.SelectedValue & ") AND (Año = " & msk_anio.Text & ") "

        tabla = acceso.ejecutar(consulta)

        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If

    End Function

    Private Function validar() As Boolean
        'Dim anioValor As Integer = CInt(msk_anio.Text)
        'Dim anioActual As Integer = Year(Today)
        If cmb_club.SelectedIndex < 0 Then
            MsgBox(" Debe seleccionar un Club.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_club.Focus()
            Return False
        End If

        If cmb_torneo.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un Torneo.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_torneo.Focus()
            Return False
        End If

        If msk_anio.Text = "" Then
            MsgBox("Debe ingresar un Año válido y mayor o igual que el actual.", MsgBoxStyle.Critical, "¡Importante!")
            Me.msk_anio.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click

        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("La inserción se realizo exitosamente.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya esta cargada una combinación con ese Año y Torneo.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Me.modificar()
                MessageBox.Show("La modificación se realizo exitosamente.", _
                                "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.carga_grilla()

        End If

        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False

        cmb_club.SelectedIndex = -1
        cmb_torneo.SelectedIndex = -1
        msk_anio.Text = ""

        cmb_club.Enabled = False
        cmb_torneo.Enabled = False
        msk_anio.Enabled = False

        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True

    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click

        If MessageBox.Show("¿Está seguro que desea cancelar este registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If

    End Sub

    Private Sub cancelar()

        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False

        cmb_club.SelectedIndex = -1
        cmb_torneo.SelectedIndex = -1
        msk_anio.Text = ""

        cmb_club.Enabled = False
        cmb_torneo.Enabled = False
        msk_anio.Enabled = False

        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True

    End Sub

End Class