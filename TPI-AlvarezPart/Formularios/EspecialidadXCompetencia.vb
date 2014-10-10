Public Class frm_EspecialidadXCompetencia


    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim code, codn, codT, Year As String
    Dim accion As estado = estado.insertar
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}


    Private Sub carga_grilla_TorneosXAño()

        Dim txt_sql As String = ""

        txt_sql = "SELECT TORNEOS.Descrip AS 'Torneo', TorneosXAño.Año as 'Año', Clubes.Nombre AS 'Club' "
        txt_sql &= "FROM TORNEOS INNER JOIN"
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo INNER JOIN Clubes ON Clubes.CodClub = TorneosXAño.CodClub"
        grd_DGVTorneosxAño.DataSource = acceso.ejecutar(txt_sql)
    End Sub

    Private Sub cargar_grilla_EspecialidadXCompetencia()

        Dim txt_sql As String = ""

        txt_sql = "SELECT TORNEOS.Descrip AS 'Torneo', TORNEOSXAÑO.Año as 'Año', Especialidad.Descripcion AS 'Especialidad', EspecXCompet.Fecha "
        txt_sql &= "FROM TorneosXAño INNER JOIN"
        txt_sql &= " EspecXCompet ON TorneosXAño.CodTorneo = EspecXCompet.CodTorneo AND TorneosXAño.Año = EspecXCompet.Año INNER JOIN ESPECIALIDAD ON EspecXCompet.CodEspe = Especialidad.CodEspe "
        txt_sql &= " INNER JOIN TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo"
        grd_DGVEspecialidadXCompetencia.DataSource = acceso.ejecutar(txt_sql)

    End Sub

    Private Sub frm_EspecialidadXTorneo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
     Windows.Forms.DialogResult.OK Then
            cancelar()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click

        If MessageBox.Show("¿Está seguro que desea cancelar este registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If

    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cmd_cancelar.Enabled = True
        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = False
        cmd_eliminar.Enabled = False
        cmb_especialidad.Enabled = True
        Me.msk_fecha.Enabled = True
        grd_DGVTorneosxAño.Enabled = True

        Me.accion = estado.insertar
    End Sub

    Private Sub grd_dgvEspecialidadXCompetencia_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_DGVEspecialidadXCompetencia.CellContentDoubleClick
        Dim txt_sql As String
        Dim tabla As Data.DataTable
        Dim torneo As String = Me.grd_DGVEspecialidadXCompetencia.CurrentRow.Cells("Torneo").Value
        Dim anio As String = Me.grd_DGVEspecialidadXCompetencia.CurrentRow.Cells("Año").Value
        Dim especialidad As String = Me.grd_DGVEspecialidadXCompetencia.CurrentRow.Cells("Especialidad").Value
        Dim fecha As String = Me.grd_DGVEspecialidadXCompetencia.CurrentRow.Cells("Fecha").Value

        txt_sql = "SELECT EspecXCompet.* "
        txt_sql &= "FROM TorneosXAño INNER JOIN"
        txt_sql &= " EspecXCompet ON TorneosXAño.CodTorneo = EspecXCompet.CodTorneo AND TorneosXAño.Año = EspecXCompet.Año INNER JOIN Especialidad ON EspecXCompet.CodEspe = Especialidad.CodEspe"
        txt_sql &= " INNER JOIN TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo"
        txt_sql &= " WHERE TORNEOS.Descrip = '" & torneo & "' AND TorneosXAño.Año = '" & anio & "' AND Especialidad.Descripcion = '" & especialidad & "'"
        tabla = acceso.ejecutar(txt_sql)
        codT = tabla.Rows(0)("CodTorneo")
        code = tabla.Rows(0)("CodEspe")
        Year = tabla.Rows(0)("Año")

        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.cmd_eliminar.Enabled = False

        Me.accion = estado.modificar
    End Sub

    Private Function modificar() As termino

        Dim cmd As String = ""

        cmd = "Update EspecXCompet "
        cmd &= " Set Fecha = '" & Me.msk_fecha.Text & "'"
        cmd &= " where (CodTorneo = '" & codT & "') AND (Año = '" & Year & "') AND (CodEspe = '" & code & "')"

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click

        If MessageBox.Show("¿Está seguro que desea borrar ese registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String
            Dim tabla As Data.DataTable
            Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value
            Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
            Dim especialidad As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Especialidad").Value

            txt_sql = "SELECT EspecXCompet.* "
            txt_sql &= "FROM TorneosXAño INNER JOIN"
            txt_sql &= " EspecXCompet ON TorneosXAño.CodTorneo = EspecXCompet.CodTorneo AND TorneosXAño.Año = EspecXCompet.Año INNER JOIN Especialidad ON EspecXCompet.CodEspe = Especialidad.CodEspe"
            txt_sql &= " INNER JOIN TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo"
            txt_sql &= " WHERE TORNEOS.Descrip = '" & torneo & "' AND TorneosXAño.Año = '" & anio & "' AND Especialidad.Descripcion = '" & especialidad & "'"
            tabla = acceso.ejecutar(txt_sql)
            codT = tabla.Rows(0)("CodTorneo")
            codE = tabla.Rows(0)("CodEspe")
            year = tabla.Rows(0)("Año")


            Dim txt_del As String = ""

            txt_del = "delete from EspecXCompet where (CodTorneo = '" & codT & "') AND (Año = '" & Year & "') AND (CodEspe = '" & code & "')"

            acceso.ejecutarNonConsulta(txt_del)

            Me.cargar_grilla_EspecialidadXCompetencia()

        End If
    End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        Dim txt_sql As String
        Dim tablaTXA As Data.DataTable
        Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value
        Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
        Dim especialidad As String = Me.cmb_especialidad.SelectedValue

        txt_sql = "SELECT TorneosXAño.CodTorneo, TorneosXAño.Año"
        txt_sql &= " FROM TORNEOS INNER JOIN "
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo "
        txt_sql &= " WHERE (TorneosXAño.Año = '" & anio & "') AND (TORNEOS.Descrip = '" & torneo & "') "
        tablaTXA = acceso.ejecutar(txt_sql)

        cmd = "insert into EspecXCompet "
        cmd &= "(CodTorneo, Año, CodEspe, Fecha) "
        cmd &= " values('" & tablaTXA.Rows(0)("CodTorneo") & "'"
        cmd &= ", '" & tablaTXA.Rows(0)("Año") & "', '" & especialidad & "', '" & msk_fecha.Text & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function

    Private Function validar() As Boolean

        If Me.cmb_especialidad.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un elemento de la lista.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_especialidad.Focus()
            Return False
        End If

        If msk_fecha.Text = "" Then
            MsgBox("Debe ingresar una fecha válida.", MsgBoxStyle.Critical, "¡Importante!")
            Me.msk_fecha.Focus()
            Return False
        End If

        If grd_DGVTorneosxAño.CurrentRow.Cells.Count = 0 Then
            MsgBox("Debe seleccionar un elemento de la grilla de Torneos.", MsgBoxStyle.Critical, "¡Importante!")
            Me.grd_DGVTorneosxAño.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As DataTable
        Dim txt_sql As String
        Dim tablaTXA As Data.DataTable
        Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value
        Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
        Dim especialidad As String = Me.cmb_especialidad.SelectedValue
        
        txt_sql = "SELECT TorneosXAño.CodTorneo, TorneosXAño.Año"
        txt_sql &= " FROM TORNEOS INNER JOIN"
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo "
        txt_sql &= " WHERE (TorneosXAño.Año = '" & anio & "') AND (TORNEOS.Descrip = '" & torneo & "')"
        tablaTXA = acceso.ejecutar(txt_sql)


        consulta = "select * from EspecXCompet "
        consulta &= " where (CodTorneo = '" & tablaTXA.Rows(0)("CodTorneo") & "') AND (Año = '" & tablaTXA.Rows(0)("Año") & "') AND (CodEspe = '" & Me.cmb_especialidad.SelectedValue & "')"

        tabla = acceso.ejecutar(consulta)

        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If

    End Function

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click

        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("La inserción se realizo exitosamente.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya esta cargada una combinación con esa Especialidad y ese Torneo.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Me.modificar()
                MessageBox.Show("La modificación se realizo exitosamente.", _
                                "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.cargar_grilla_EspecialidadXCompetencia()

        End If

        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        cmb_especialidad.Enabled = False
        grd_DGVTorneosxAño.Enabled = False
        msk_fecha.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True

    End Sub

    Private Sub cancelar()
        Me.cmb_especialidad.Enabled = False
        grd_DGVTorneosxAño.Enabled = False
        Me.msk_fecha.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmd_cancelar.Enabled = False
        Me.cmd_guardar.Enabled = False
    End Sub


    Private Sub frm_EspecialidadXCompetencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.TPIPAVIDataSet.Especialidad)
        grd_DGVTorneosxAño.Enabled = False
        msk_fecha.Enabled = False
        cmb_especialidad.Enabled = False

        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        Me.carga_grilla_TorneosXAño()
        Me.cargar_grilla_EspecialidadXCompetencia()
    End Sub
End Class