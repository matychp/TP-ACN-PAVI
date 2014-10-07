Public Class Form_ABMCodigosPost
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim cod As String
    Dim accion As estado = estado.insertar
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub frm_ABMCodigosPost_acceso_datos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
        Windows.Forms.DialogResult.OK Then
            cancelar()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String = ""
            txt_sql = "delete from CodigosPost where Codpos = " & Me.dgv_CodPos.CurrentRow.Cells("CodposDataGridViewTextBoxColumn").Value
            acceso.ejecutarNonConsulta(txt_sql)
            Me.carga_grilla()
        End If
    End Sub
    Private Sub carga_grilla()

        Dim txt_sql As String = ""

        txt_sql = " SELECT  CodigosPost.Codpos, CodigosPost.Nombre "
        txt_sql += " FROM CodigosPost "
        dgv_CodPos.DataSource = acceso.ejecutar(txt_sql)
    End Sub
    Private Function modificar() As termino
        Dim cmd As String = ""
        cmd = "Update CodigosPost "
        cmd &= " Set Nombre = '" & Me.msk_CodPos.Text & "'"
        cmd &= " where Codpos = '" & cod & "'"
        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function
    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from CodigosPost "
        consulta &= " where Nombre = " & Me.msk_CodPos.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function
    Private Function validar() As Boolean
        If Me.msk_CodPos.Text = "" Then
            MsgBox("El Numero de Codigo Postal no puede estar vacio.", MsgBoxStyle.Critical, "¡Importante!")
            Me.msk_CodPos.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("La insersión se realizo exitosamente.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya esta cargado un Codigo Postal con ese codigo!", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Me.modificar()
                MessageBox.Show("La modificación se realizo exitosamente.", _
                                "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            Me.carga_grilla()



            MessageBox.Show("Se grabó exitosamente", "Importante", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        Me.msk_CodPos.Text = ""
        Me.msk_CodPos.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Está seguro que desea cancelar este registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If
    End Sub

    Private Sub Form_ABMCodigosPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CodigosPostTableAdapter.Fill(Me.TPIPAVIDataSet.CodigosPost)
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = False
            End If
        Next
        msk_CodPos.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
    End Sub

    Private Sub dgv_CodPos_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_CodPos.CellContentDoubleClick
        cod = Me.dgv_CodPos.CurrentRow.Cells("CodposDataGridViewTextBoxColumn").Value
        Dim consulta As String = "select * from CodigosPost where Codpos = " & cod
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)
        msk_CodPos.Text = tabla.Rows(0)("Nombre")

        msk_CodPos.Enabled = True
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.modificar
    End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into CodigosPost "
        cmd &= "(Nombre) "
        cmd &= " values('" & Me.msk_CodPos.Text & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cmd_cancelar.Enabled = True
        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = False


        msk_CodPos.Enabled = True
        msk_CodPos.Focus()
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.insertar
    End Sub

    Private Sub cancelar()
        Me.msk_CodPos.Text = ""
        Me.msk_CodPos.Enabled = False
        Me.cmd_cancelar.Enabled = False
        Me.cmd_guardar.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub


End Class