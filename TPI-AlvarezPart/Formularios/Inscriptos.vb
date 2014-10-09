Public Class frm_Inscriptos
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim codT, codN, codE, year As String
    Dim accion As estado = estado.insertar
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}


    Private Sub Inscriptos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grd_DGVTorneosxAño.Enabled = False
        grd_DGVNadxEspe.Enabled = False
        msk_posicion.Enabled = False
        msk_tiempo.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        Me.carga_grilla_Inscriptos()
        Me.carga_grilla_nadaXEspe()
        Me.carga_grilla_TorneosXAño()
      
    End Sub

    Private Sub carga_grilla_TorneosXAño()

        Dim txt_sql As String = ""

        txt_sql = "SELECT TORNEOS.Descrip AS 'Torneo', TorneosXAño.Año as 'Año', Clubes.Nombre AS 'Club' "
        txt_sql &= "FROM TORNEOS INNER JOIN"
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo INNER JOIN Clubes ON Clubes.CodClub = TorneosXAño.CodClub"
        grd_DGVTorneosxAño.DataSource = acceso.ejecutar(txt_sql)

    End Sub

    Private Sub carga_grilla_Inscriptos()
        Dim txt_sql As String = ""

        txt_sql = "SELECT         TORNEOS.Descrip AS 'Torneo', TorneosXAño.Año, Nadadores.Apellido AS 'Nadador', Especialidad.Descripcion AS 'Especialidad', Inscriptos.Posicion, Inscriptos.Tiempo "
        txt_sql &= "FROM            Inscriptos INNER JOIN"
        txt_sql &= " NadaXEspe ON Inscriptos.CodNad = NadaXEspe.CodNad AND Inscriptos.CodEspe = NadaXEspe.CodEspe INNER JOIN"
        txt_sql &= "     Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad INNER JOIN "
        txt_sql &= " Especialidad ON NadaXEspe.CodEspe = Especialidad.CodEspe INNER JOIN"
        txt_sql &= " TorneosXAño ON Inscriptos.CodTorneo = TorneosXAño.CodTorneo AND Inscriptos.Año = TorneosXAño.Año INNER JOIN"
        txt_sql &= " TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo"
        grd_dgvInscriptos.DataSource = acceso.ejecutar(txt_sql)
    End Sub

    Private Sub carga_grilla_nadaXEspe()

        Dim txt_sql As String = ""

        txt_sql = "SELECT Nadadores.Apellido AS 'Nadador', Especialidad.Descripcion AS 'Especialidad' "
        txt_sql &= "FROM  Especialidad INNER JOIN"
        txt_sql &= " NadaXEspe ON Especialidad.CodEspe = NadaXEspe.CodEspe INNER JOIN Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad"
        grd_DGVNadxEspe.DataSource = acceso.ejecutar(txt_sql)

    End Sub



    Private Sub frm_Inscriptos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
        cmd_eliminar.Enabled = False

        grd_DGVTorneosxAño.Enabled = True
        grd_DGVNadxEspe.Enabled = True
        msk_posicion.Enabled = True
        msk_tiempo.Enabled = True
      
        Me.accion = estado.insertar
    End Sub

    Private Sub cancelar()
        msk_posicion.Text = ""
        msk_tiempo.Text = ""
        msk_posicion.Enabled = False
        msk_tiempo.Enabled = False
        grd_DGVTorneosxAño.Enabled = False
        grd_DGVNadxEspe.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmd_cancelar.Enabled = False
        Me.cmd_guardar.Enabled = False
    End Sub

    Private Sub grd_dgvInscriptos_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_dgvInscriptos.CellContentDoubleClick
        Dim txt_sql As String
        Dim tabla As Data.DataTable
        Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value
        Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
        Dim nadador As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Nadador").Value
        Dim especialidad As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Especialidad").Value

        txt_sql = " SELECT Inscriptos.* "
        txt_sql &= "FROM            Inscriptos INNER JOIN"
        txt_sql &= "   NadaXEspe ON Inscriptos.CodNad = NadaXEspe.CodNad AND Inscriptos.CodEspe = NadaXEspe.CodEspe INNER JOIN"
        txt_sql &= "    Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad INNER JOIN"
        txt_sql &= "  Especialidad ON NadaXEspe.CodEspe = Especialidad.CodEspe INNER JOIN"
        txt_sql &= "    TorneosXAño ON Inscriptos.CodTorneo = TorneosXAño.CodTorneo AND Inscriptos.Año = TorneosXAño.Año INNER JOIN"
        txt_sql &= "   TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo "
        txt_sql &= " WHERE Nadadores.Apellido = '" & nadador & "' AND TORNEOS.Descrip = '" & torneo & "' AND TorneosXAño.Año = '" & anio & "' AND Especialidad.Descripcion = '" & especialidad & "'"
        tabla = acceso.ejecutar(txt_sql)
        codT = tabla.Rows(0)("CodTorneo")
        codE = tabla.Rows(0)("CodEspe")
        codN = tabla.Rows(0)("CodNad")
        year = tabla.Rows(0)("Año")

        msk_posicion.Text = grd_dgvInscriptos.CurrentRow.Cells("Posicion").Value
        msk_tiempo.Text = grd_dgvInscriptos.CurrentRow.Cells("Tiempo").Value

        msk_posicion.Enabled = True
        msk_tiempo.Enabled = True

        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.cmd_eliminar.Enabled = False

        Me.accion = estado.modificar
    End Sub


    Private Function modificar() As termino

        Dim cmd As String = ""

        cmd = "Update Inscriptos "
        cmd &= " Set Posicion = '" & msk_posicion.Text & "', Tiempo = '" & msk_tiempo.Text & "'"
        cmd &= " where (CodTorneo = '" & codT & "') AND (Año = '" & year & "') AND (CodNad = '" & codN & "') AND (CodEspe = '" & codE & "')"

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function


    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click

        If MessageBox.Show("¿Está seguro que desea borrar ese registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String
            Dim tabla As Data.DataTable
            Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value
            Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
            Dim nadador As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Nadador").Value
            Dim especialidad As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Especialidad").Value

            txt_sql = " SELECT Inscriptos.* "
            txt_sql &= "FROM            Inscriptos INNER JOIN"
            txt_sql &= "   NadaXEspe ON Inscriptos.CodNad = NadaXEspe.CodNad AND Inscriptos.CodEspe = NadaXEspe.CodEspe INNER JOIN"
            txt_sql &= "    Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad INNER JOIN"
            txt_sql &= "  Especialidad ON NadaXEspe.CodEspe = Especialidad.CodEspe INNER JOIN"
            txt_sql &= "    TorneosXAño ON Inscriptos.CodTorneo = TorneosXAño.CodTorneo AND Inscriptos.Año = TorneosXAño.Año INNER JOIN"
            txt_sql &= "   TORNEOS ON TorneosXAño.CodTorneo = TORNEOS.CodTorneo "
            txt_sql &= " WHERE Nadadores.Apellido = '" & nadador & "' AND TORNEOS.Descrip = '" & torneo & "' AND TorneosXAño.Año = '" & anio & "' AND Especialidad.Descripcion = '" & especialidad & "'"
            tabla = acceso.ejecutar(txt_sql)
            codT = tabla.Rows(0)("CodTorneo")
            codE = tabla.Rows(0)("CodEspe")
            codN = tabla.Rows(0)("CodNad")
            year = tabla.Rows(0)("Año")


            Dim txt_del As String = ""

            txt_del = "delete from TorneosXAño where (CodTorneo = '" & codT & "') AND (Año = '" & year & "') AND (CodNad = '" & codN & "') AND (CodEspe = '" & codE & "')"

            acceso.ejecutarNonConsulta(txt_del)

            Me.carga_grilla_Inscriptos()

        End If
    End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        Dim txt_sql As String
        Dim tablaTXA As Data.DataTable
        Dim torneo As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Torneo").Value
        Dim anio As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Año").Value
        Dim club As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Club").Value

        Dim txt_sql2 As String
        Dim tablaNXE As Data.DataTable
        Dim especialidad As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Especialidad").Value
        Dim nadador As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Nadador").Value

        txt_sql2 = "SELECT NadaXEspe.CodNad, NadaXEspe.CodEspe "
        txt_sql2 &= " FROM  Especialidad INNER JOIN "
        txt_sql2 &= " NadaXEspe ON Especialidad.CodEspe = NadaXEspe.CodEspe INNER JOIN Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad "
        txt_sql2 &= " WHERE (Nadadores.Apellido = '" & nadador & "') AND (Especialidad.Descripcion = '" & especialidad & "')"
        tablaNXE = acceso.ejecutar(txt_sql2)



        txt_sql = "SELECT TorneosXAño.CodTorneo, TorneosXAño.Año"
        txt_sql &= " FROM TORNEOS INNER JOIN "
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo INNER JOIN Clubes ON TorneosXAño.CodClub = Clubes.CodClub "
        txt_sql &= " WHERE (TorneosXAño.Año = '" & anio & "') AND (TORNEOS.Descrip = '" & torneo & "') AND (Clubes.Nombre = '" & club & "')"
        tablaTXA = acceso.ejecutar(txt_sql)

        cmd = "insert into Inscriptos "
        cmd &= "(CodTorneo, Año, CodNad, CodEspe, Posicion, Tiempo) "
        cmd &= " values('" & tablaTXA.Rows(0)("CodTorneo") & "'"
        cmd &= ", '" & tablaTXA.Rows(0)("Año") & "', '" & tablaNXE.Rows(0)("CodNad") & "', '" & tablaNXE.Rows(0)("CodEspe") & "', '" & msk_posicion.Text & "', '" & msk_tiempo.Text & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function


    Private Function validar() As Boolean
   

        If msk_posicion.Text = "" Then
            MsgBox("Debe ingresar una posición válida.", MsgBoxStyle.Critical, "¡Importante!")
            Me.msk_posicion.Focus()
            Return False
        End If
        If msk_tiempo.Text = "" Then
            MsgBox("Debe ingresar un tiempo válido.", MsgBoxStyle.Critical, "¡Importante!")
            Me.msk_tiempo.Focus()
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
        Dim club As String = Me.grd_DGVTorneosxAño.CurrentRow.Cells("Club").Value

        Dim txt_sql2 As String
        Dim tablaNXE As Data.DataTable
        Dim especialidad As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Especialidad").Value
        Dim nadador As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Nadador").Value

        txt_sql2 = "SELECT NadaXEspe.CodNad, NadaXEspe.CodEspe "
        txt_sql2 &= " FROM  Especialidad INNER JOIN"
        txt_sql2 &= " NadaXEspe ON Especialidad.CodEspe = NadaXEspe.CodEspe INNER JOIN Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad "
        txt_sql2 &= " WHERE (Nadadores.Apellido = '" & nadador & "') AND (Especialidad.Descripcion = '" & especialidad & "')"
        tablaNXE = acceso.ejecutar(txt_sql2)



        txt_sql = "SELECT TorneosXAño.CodTorneo, TorneosXAño.Año"
        txt_sql &= " FROM TORNEOS INNER JOIN"
        txt_sql &= " TorneosXAño ON TORNEOS.CodTorneo = TorneosXAño.CodTorneo INNER JOIN Clubes ON TorneosXAño.CodClub = Clubes.CodClub "
        txt_sql &= " WHERE (TorneosXAño.Año = '" & anio & "') AND (TORNEOS.Descrip = '" & torneo & "') AND (Clubes.Nombre = '" & club & "')"
        tablaTXA = acceso.ejecutar(txt_sql)


        consulta = "select * from Inscriptos "
        consulta &= " where (CodTorneo = '" & tablaTXA.Rows(0)("CodTorneo") & "') AND (Año = '" & tablaTXA.Rows(0)("Año") & "') AND (CodNad = '" & tablaNXE.Rows(0)("CodNad") & "') AND (CodEspe = '" & tablaNXE.Rows(0)("CodEspe") & "')"

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
                    MessageBox.Show("Ya esta cargada una inscripción con esa combinación", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Me.modificar()
                MessageBox.Show("La modificación se realizo exitosamente.", _
                                "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            Me.carga_grilla_Inscriptos()

        End If

        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False

        msk_posicion.Text = ""
        msk_tiempo.Text = ""

        grd_DGVTorneosxAño.Enabled = False
        grd_DGVNadxEspe.Enabled = False
        msk_posicion.Enabled = False
        msk_tiempo.Enabled = False

        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True

    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click

        If MessageBox.Show("¿Está seguro que desea cancelar este registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If

    End Sub



End Class