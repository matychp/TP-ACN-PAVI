Public Class Form_ABMEspecialidad
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
    'Private Function Get_last_CodEspe()
    '    Dim consulta As String = "Select MAX(CodEspe) From Especialidad"
    '    codEspecialidad = acceso.ejecutar(consulta)
    '    Return codEspecialidad
    'End Function
    Private Sub frm_ABMEspecialidad_acceso_datos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

        txt_NombreEspecialidad.Enabled = True
        msk_TiempoRecord.Enabled = True
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.insertar
    End Sub

    Private Sub Form_ABMEspecialidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EspecialidadTableAdapter1.Fill(Me.TPIPAVIDataSet.Especialidad)
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = False
            End If
        Next
        msk_TiempoRecord.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
    End Sub

    Private Sub grd_ListaEspecialidades_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_ListaEspecialidades.CellContentDoubleClick
        cod = Me.grd_ListaEspecialidades.CurrentRow.Cells("CodEspeDataGridViewTextBoxColumn").Value
        Dim consulta As String = "select * from Especialidad where CodEspe = " & cod
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)
        txt_NombreEspecialidad.Text = tabla.Rows(0)("Descripcion")
        msk_TiempoRecord.Text = tabla.Rows(0)("TiempoRecord")

        txt_NombreEspecialidad.Enabled = True
        Me.msk_TiempoRecord.Enabled = True
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.cmd_eliminar.Enabled = False
        Me.accion = estado.modificar
    End Sub
    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into Especialidad "
        cmd &= "(Descripcion, TiempoRecord) "
        cmd &= " values('" & Me.txt_NombreEspecialidad.Text & "'"
        cmd &= ", '" & Me.msk_TiempoRecord.Text & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado
    End Function

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String = ""
            txt_sql = "delete from Espcialidad where CodEspe = " & Me.grd_ListaEspecialidades.CurrentRow.Cells("CodEspeDataGridViewTextBoxColumn").Value
            acceso.ejecutarNonConsulta(txt_sql)
            Me.carga_grilla()
        End If
    End Sub
    Private Sub carga_grilla()

        Dim txt_sql As String = ""

        txt_sql = " SELECT  Especialidad.CodEspe, Especialidad.Descripcion, Especialidad.TiempoRecord"
        txt_sql += " FROM Especialidad "
        grd_ListaEspecialidades.DataSource = acceso.ejecutar(txt_sql)
    End Sub
    Private Function modificar() As termino
        Dim cmd As String = ""
        cmd = "Update Especialidad "
        cmd &= " Set Descripcion = '" & Me.txt_NombreEspecialidad.Text & "'"
        cmd &= ", TiempoRecord = '" & Me.msk_TiempoRecord.Text & "'"
        cmd &= " where CodEspe = '" & cod & "'"
        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function
    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from Especialidad "
        consulta &= " where Descripcion = '" & Me.txt_NombreEspecialidad.Text & "'"
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function
    Private Function validar() As Boolean
        If Me.txt_NombreEspecialidad.Text = "" Then
            MsgBox("El Nombre de la Especialidad no puede estar vacio.", MsgBoxStyle.Critical, "¡Importante!")
            Me.txt_NombreEspecialidad.Focus()
            Return False
        End If

        If Me.msk_TiempoRecord.Text = "" Then
            If MessageBox.Show("¿Está seguro que no desea ingresar ningún Tiempo Record?", "¡Importante!", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
         Windows.Forms.DialogResult.Yes Then
                Return True
            Else
                Me.msk_TiempoRecord.Focus()
            End If
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
                    MessageBox.Show("Ya esta cargada una especialidad con ese nombre", _
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
        Me.msk_TiempoRecord.Text = ""
        Me.txt_NombreEspecialidad.Text = ""
        Me.msk_TiempoRecord.Enabled = False
        Me.txt_NombreEspecialidad.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Está seguro que desea cancelar este registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If
    End Sub

    Private Sub cancelar()
        Me.txt_NombreEspecialidad.Text = ""
        Me.msk_TiempoRecord.Text = ""
        Me.msk_TiempoRecord.Enabled = False
        Me.cmd_cancelar.Enabled = False
        Me.cmd_guardar.Enabled = False
        Me.txt_NombreEspecialidad.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

End Class