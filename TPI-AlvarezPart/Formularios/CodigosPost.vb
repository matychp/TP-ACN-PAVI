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

    Private Sub frm_ABMCodigosPost_acceso_datos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
        Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click

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
        cmd &= " Set Nombre = '" & Me.txt_nombreCodPos.Text & "'"
        cmd &= " where Codpos = '" & cod & "'"
        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function
    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from CodigosPost "
        consulta &= " where Codpos = " & Me.msk_CodPos.Text
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

        If Me.txt_nombreCodPos.Text = "" Then
            If MessageBox.Show("¿Está seguro que no desea ingresar ninguna Ciudad o Zona de Codigo Postal?", "¡Importante!", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
         Windows.Forms.DialogResult.Yes Then
                Return True
            Else
                Me.txt_nombreCodPos.Focus()
            End If
        End If
        Return True
    End Function

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click

    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click

    End Sub


    Private Sub Form_ABMCodigosPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.CodigosPostTableAdapter1.Fill(Me.TPIPAVIDataSet.CodigosPost)
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = False
            End If
        Next
        msk_CodPos.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
    End Sub

    Private Sub dgv_CodPos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_CodPos.CellContentClick

    End Sub
    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into CodigosPost "
        cmd &= "(Codpos, Nombre) "
        cmd &= " values('" & Me.msk_CodPos.Text & "'"
        cmd &= ", '" & Me.txt_nombreCodPos.Text & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click

    End Sub

    Private Sub CodigosPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cod = Me.dgv_CodPos.CurrentRow.Cells("CodposDataGridViewTextBoxColumn").Value
        Dim consulta As String = "select * from CodigosPost where Codpos = " & cod
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)
        txt_nombreCodPos.Text = tabla.Rows(0)("Codpos")
        msk_CodPos.Text = tabla.Rows(0)("Nombre")

        txt_nombreCodPos.Enabled = True
        Me.msk_CodPos.Enabled = True
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.modificar
    End Sub
End Class