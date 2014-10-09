Public Class ProfesorXClub
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


    Private Sub ProfesorXClub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.TPIPAVIDataSet.Profesores)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.ProfXClub' Puede moverla o quitarla según sea necesario.
        Me.ProfXClubTableAdapter.Fill(Me.TPIPAVIDataSet.ProfXClub)

        cmb_club.Enabled = False
        cmb_profesor.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        Me.carga_grilla()

    End Sub

    Private Sub ProfXClubBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProfXClubBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TPIPAVIDataSet)

    End Sub

    Private Sub ProfesorXClub_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
        cmb_profesor.Enabled = True
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.insertar
    End Sub

    'Private Sub grd_DGVProfXClub_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_DGVProfXClub.CellContentClick
    '    Dim txt_sql As String
    '    Dim tabla As Data.DataTable
    '    Dim profesor As String = Me.grd_DGVProfXClub.CurrentRow.Cells("Profesor").Value
    '    Dim club As String = Me.grd_DGVProfXClub.CurrentRow.Cells("Club").Value


    '    txt_sql = "SELECT ProfXClub.CodProf, ProfXClub.CodClub " 'Club no lo considero, no es parte de la PK...
    '    txt_sql &= "FROM Profesores INNER JOIN"
    '    txt_sql &= " ProfXClub ON Profesores.CodProf = ProfXClub.CodTorneo INNER JOIN Clubes ON ProfXClub.CodClub = Clubes.CodClub "
    '    txt_sql &= " WHERE (Profesores.Apellido = '" & profesor & "') AND (Clubes.Nombre = '" & club & "')"

    '    tabla = acceso.ejecutar(txt_sql)

    '    cmb_profesor.SelectedValue = tabla.Rows(0)("CodProf")
    '    cmb_club.SelectedValue = tabla.Rows(0)("CodClub")

    '    Me.cmd_cancelar.Enabled = True
    '    Me.cmd_guardar.Enabled = True
    '    Me.cmd_nuevo.Enabled = False
    '    Me.cmd_eliminar.Enabled = False

    '    Me.accion = estado.modificar

    'End Sub
    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into ProfXClub "
        cmd &= "(CodProf, CodClub) "
        cmd &= " values('" & Me.cmb_profesor.SelectedValue & "'"
        cmd &= ", '" & Me.cmb_club.SelectedValue & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function
   Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            Dim txt_sql As String
            Dim tabla As Data.DataTable
            Dim club As String = Me.grd_DGVProfXClub.CurrentRow.Cells("Club").Value
            Dim profesor As String = Me.grd_DGVProfXClub.CurrentRow.Cells("Profesor").Value

            txt_sql = "SELECT ProfXClub.CodProf, ProfXClub.CodClub "
            txt_sql &= "FROM  Clubes INNER JOIN"
            txt_sql &= " ProfXClub ON Clubes.CodClub = ProfXClub.CodClub INNER JOIN Profesores ON ProfXClub.CodProf = Profesores.CodProf "
            txt_sql &= " WHERE (Profesores.Apellido = '" & profesor & "') AND (Clubes.Nombre = '" & club & "')"
            tabla = acceso.ejecutar(txt_sql)

            code = tabla.Rows(0)("CodClub")
            codn = tabla.Rows(0)("CodProf")

            Dim txt_del As String = ""
            txt_del = "delete from ProfXClub where  (CodClub = " & code & ") AND (CodProf = " & codn & ") "
            acceso.ejecutarNonConsulta(txt_del)
            Me.carga_grilla()
        End If
    End Sub
    Private Sub carga_grilla()

        Dim txt_sql As String = ""

        txt_sql = "SELECT Profesores.Apellido AS 'Profesor', Clubes.Nombre AS 'Nombre' "
        txt_sql &= "FROM  Clubes INNER JOIN"
        txt_sql &= " ProfXClub ON Clubes.CodClub = ProfXClub.CodClub INNER JOIN Profesores ON ProfXClub.CodProf = Profesores.CodProf "
        grd_DGVProfXClub.DataSource = acceso.ejecutar(txt_sql)

    End Sub
    'Private Function modificar() As termino
    '    Dim cmd As String = ""
    '    cmd = "Update ProfXCLub "
    '    cmd &= " Set CodProf = '" & cmb_profesor.SelectedValue & "'"
    '    cmd &= ", CodClub = '" & cmb_club.SelectedValue & "'"
    '    cmd &= " where (CodClub = " & code & ") AND (CodProf = " & codn & ") "
    '    acceso.ejecutarNonConsulta(cmd)

    '    Return termino.aprobado

    'End Function
    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from ProfXClub "
        consulta &= " where (CodClub = " & cmb_club.SelectedValue & ") AND (CodProf = " & cmb_profesor.SelectedValue & ") "
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function
    Private Function validar() As Boolean
        If cmb_club.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar una Club.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_club.Focus()
            Return False
        End If

        If cmb_profesor.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un Profesor.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_profesor.Focus()
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
                    MessageBox.Show("Ya esta cargada una combinación con ese Profesor y Club.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            End If
            Me.carga_grilla()

        End If
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        cmb_club.SelectedIndex = -1
        cmb_profesor.SelectedIndex = -1
        cmb_profesor.Enabled = False
        cmb_club.Enabled = False
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
        cmb_profesor.SelectedIndex = -1
        cmb_profesor.Enabled = False
        cmb_club.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

End Class