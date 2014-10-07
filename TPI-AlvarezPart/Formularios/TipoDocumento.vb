Public Class frm_abmTipoDocumento
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim tipodoc As String
    Dim accion As estado = estado.insertar
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub form_ABMProfesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.TiposDoc' Puede moverla o quitarla según sea necesario.
        Me.TiposDocTableAdapter.Fill(Me.TPIPAVIDataSet.TiposDoc)

        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = False
            End If
        Next
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
    End Sub

    Private Sub form_abmTipoDoc_acceso_datos_formClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir?", _
                           "¡Importante!", _
                            MessageBoxButtons.OKCancel, _
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            cancelar()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function validar() As Boolean
        If txt_nombre.Text = "" Then
            MsgBox("El Nombre no puede estar vacío.", MsgBoxStyle.Critical, "¡Importante!")
            Me.txt_nombre.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable

        consulta = "select * from TiposDoc"
        consulta &= " where Nombre = '" & Me.txt_nombre.Text & "'"

        tabla = acceso.ejecutar(consulta)

        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function insertar() As termino
        Dim cmd As String

        cmd = "insert into TiposDoc ("
        cmd &= "Nombre)"
        cmd &= " values ('" & Me.txt_nombre.Text & "')"

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function

    Private Function modificar() As termino
        Dim cmd As String = ""
        cmd = "Update TiposDoc  "
        cmd &= " Set Nombre = '" & txt_nombre.Text & "'"
        cmd &= " where TipoDoc = '" & tipodoc & "'"

        'Se podria poner un label en pantalla, cosa que vaya incrementando... y el where entonces quedaria: where TipoDoc = lbl_indiceTipoDoc.text. Pero me huele a parche :( 
        'Ademas el problema de un contador es que pierde el conteo en cada inicio del programa, se reinicia...

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function

    Private Sub carga_grilla()

        Dim txt_sql As String = ""

        txt_sql = "SELECT TiposDoc.TipoDoc, TiposDoc.Nombre"
        txt_sql += " FROM TiposDoc"

        grd_tipoDoc.DataSource = acceso.ejecutar(txt_sql)

    End Sub

    Private Sub grd_tipoDoc_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_tipoDoc.CellContentDoubleClick
        tipodoc = Me.grd_tipoDoc.CurrentRow.Cells("TipoDocDataGridViewTextBoxColumn").Value
        Dim consulta As String = "select * from TiposDoc where TipoDoc = '" & tipodoc & "'"
        Dim tabla As New Data.DataTable

        tabla = acceso.ejecutar(consulta)
        txt_nombre.Text = tabla.Rows(0)("Nombre")
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = True
            End If
        Next

        cmd_nuevo.Enabled = False
        cmd_eliminar.Enabled = False
        cmd_guardar.Enabled = True
        cmd_cancelar.Enabled = True

        Me.accion = estado.modificar

    End Sub

    Private Sub grd_tipoDoc_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_tipoDoc.CellContentClick
        Me.cmd_eliminar.Enabled = True
    End Sub

    'Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   Try
    '      Me.TiposDocTableAdapter.FillBy(Me.TPIPAVIDataSet.TiposDoc)
    ' Catch ex As System.Exception
    '    System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try


    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click

        cmd_cancelar.Enabled = True
        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = False

        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = True
                objeto.Text = ""
            End If
        Next

        Me.cmd_eliminar.Enabled = False
        Me.txt_nombre.Focus()
        Me.accion = estado.insertar

    End Sub

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("La insersión se realizo exitosamente.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya esta cargado el Tipo de Documento.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
                objeto.Enabled = False
            End If

        Next

        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("¿Está seguro que desea borrar ese registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String = "delete from TiposDoc where TipoDoc = " & Me.grd_tipoDoc.CurrentRow.Cells("TipoDocDataGridViewTextBoxColumn").Value
            acceso.ejecutarNonConsulta(txt_sql)
            Me.carga_grilla()
        End If
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar este registro?", "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If
    End Sub

    Private Sub cancelar()
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
                objeto.Enabled = False
            End If
        Next
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub
End Class