Public Class frm_NadadoresXEspecialidad

 

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
  

    Private Sub NadadoresXEspecialidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.TPIPAVIDataSet.Nadadores)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.TPIPAVIDataSet.Especialidad)
       
        cmb_especialidad.Enabled = False
        cmb_nadador.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        Me.carga_grilla()
    End Sub
    Private Sub NadadoresXEspe_acceso_datos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

        cmb_especialidad.Enabled = True
        cmb_nadador.Enabled = True
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.insertar
    End Sub

    

    'Private Sub grd_ListaEspecialidades_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_DGVNadxEspe.CellContentDoubleClick
    '    Dim txt_sql As String
    '    Dim tabla As Data.DataTable
    '    Dim especialidad As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Especialidad").Value
    '    Dim nadador As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Nadador").Value
    '    txt_sql = "SELECT NadaXEspe.CodNad, NadaXEspe.CodEspe "
    '    txt_sql &= "FROM  Especialidad INNER JOIN"
    '    txt_sql &= " NadaXEspe ON Especialidad.CodEspe = NadaXEspe.CodEspe INNER JOIN Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad "
    '    txt_sql &= " WHERE (Nadadores.Apellido = '" & nadador & "') AND (Especialidad.Descripcion = '" & especialidad & "')"
    '    tabla = acceso.ejecutar(txt_sql)

    '    cmb_especialidad.SelectedValue = tabla.Rows(0)("CodEspe")
    '    cmb_nadador.SelectedValue = tabla.Rows(0)("CodNad")

    '    cmb_nadador.Enabled = True
    '    cmb_especialidad.Enabled = True
    '    Me.cmd_cancelar.Enabled = True
    '    Me.cmd_guardar.Enabled = True
    '    Me.cmd_nuevo.Enabled = False
    '    Me.cmd_eliminar.Enabled = False
    '    Me.accion = estado.modificar
    'End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into NadaXEspe "
        cmd &= "(CodNad, CodEspe) "
        cmd &= " values('" & Me.cmb_nadador.SelectedValue & "'"
        cmd &= ", '" & Me.cmb_especialidad.SelectedValue & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String
            Dim tabla As Data.DataTable
            Dim especialidad As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Especialidad").Value
            Dim nadador As String = Me.grd_DGVNadxEspe.CurrentRow.Cells("Nadador").Value
            txt_sql = "SELECT NadaXEspe.CodNad, NadaXEspe.CodEspe "
            txt_sql &= "FROM  Especialidad INNER JOIN"
            txt_sql &= " NadaXEspe ON Especialidad.CodEspe = NadaXEspe.CodEspe INNER JOIN Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad "
            txt_sql &= " WHERE (Nadadores.Apellido = '" & nadador & "') AND (Especialidad.Descripcion = '" & especialidad & "')"
            tabla = acceso.ejecutar(txt_sql)
            code = tabla.Rows(0)("CodEspe")
            codn = tabla.Rows(0)("CodNad")
            Dim txt_del As String = ""
            txt_del = "delete from NadaXEspe where  (CodEspe = " & code & ") AND (CodNad = " & codn & ") "
            acceso.ejecutarNonConsulta(txt_del)
            Me.carga_grilla()
        End If
    End Sub

    Private Sub carga_grilla()

        Dim txt_sql As String = ""

        txt_sql = "SELECT Nadadores.Apellido AS 'Nadador', Especialidad.Descripcion AS 'Especialidad' "
        txt_sql &= "FROM  Especialidad INNER JOIN"
        txt_sql &= " NadaXEspe ON Especialidad.CodEspe = NadaXEspe.CodEspe INNER JOIN Nadadores ON NadaXEspe.CodNad = Nadadores.CodNad"
        grd_DGVNadxEspe.DataSource = acceso.ejecutar(txt_sql)

    End Sub

    'Private Function modificar() As termino
    '    Dim cmd As String = ""
    '    cmd = "Update NadaXEspe "
    '    cmd &= " Set CodNad = '" & cmb_nadador.SelectedValue & "'"
    '    cmd &= ", CodEspe = '" & cmb_especialidad.SelectedValue & "'"
    '    cmd &= " where (CodEspe = " & code & ") AND (CodNad = " & codn & ") "
    '    acceso.ejecutarNonConsulta(cmd)

    '    Return termino.aprobado

    'End Function
    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from NadaXEspe "
        consulta &= " where (CodEspe = " & cmb_especialidad.SelectedValue & ") AND (CodNad = " & cmb_nadador.SelectedValue & ") "
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function
    Private Function validar() As Boolean
        If cmb_especialidad.SelectedIndex < 0 Then
            MsgBox(" Debe seleccionar una especialidad.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_especialidad.Focus()
            Return False
        End If

        If cmb_nadador.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un nadador.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_nadador.Focus()
            Return False 'Aca te falta el return false hijo mio
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
                    MessageBox.Show("Ya esta cargada una combinación con ese Nadador y Especialidad", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Me.carga_grilla()

        End If
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        cmb_especialidad.SelectedIndex = -1
        cmb_nadador.SelectedIndex = -1
        cmb_nadador.Enabled = False
        cmb_especialidad.Enabled = False
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
        cmb_especialidad.SelectedIndex = -1
        cmb_nadador.SelectedIndex = -1
        cmb_nadador.Enabled = False
        cmb_especialidad.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

  
End Class