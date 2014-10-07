Public Class form_ABMProfesor
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim accion As estado = estado.insertar
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}
    
    Private Sub frm_abmProfesores_acceso_datos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
        Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function validar() As Boolean
        If Me.txt_apellido.Text = "" Then
            MsgBox("El apellido no puede estar vacio.", MsgBoxStyle.Critical, "¡Importante!")
            Me.txt_apellido.Focus()
            Return False
        End If

        If Me.txt_nombres.Text = "" Then
            MsgBox("El nombre no puede estar vacio.", MsgBoxStyle.Critical, "¡Importante!")
            Me.txt_nombres.Focus()
            Return False
        End If

        If Me.cmb_tipodoc.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un elemento de la lista.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_tipodoc.Focus()
            Return False
        End If

        If Me.msk_nrodoc.Text = "" Then
            MsgBox("El Número de Documento esta vacio, debe completar el campo.", MsgBoxStyle.Critical, "¡Importante!")
            Me.msk_nrodoc.Focus()
            Return False
        End If


        If Me.txt_calle.Text = "" Then
            MsgBox("La Calle esta vacio, debe completar el campo.", MsgBoxStyle.Critical, "¡Importante!")
            Me.txt_calle.Focus()
            Return False
        End If


        If Me.txt_nrocalle.Text = "" Then
            MsgBox("El Número de Calle esta vacio, debe completar el campo.", MsgBoxStyle.Critical, "¡Importante!")
            Me.txt_nrocalle.Focus()
            Return False
        End If

        If Me.cmb_codpostal.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un elemento de la lista.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_tipodoc.Focus()
            Return False
        End If


        Return True
    End Function

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from Profesores"
        consulta &= " where TipoDoc = " & Me.cmb_tipodoc.SelectedValue
        consulta &= " and NroDoc = " & Me.msk_nrodoc.Text
        tabla = acceso.ejecutar(consulta)

        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function


    Private Sub carga_combo(ByRef combo As ComboBox, _
                           ByVal datos As Data.DataTable, _
                           ByVal pk As String, ByVal descripcion As String)

        combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub cmd_nuevoProfesor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click

        cmd_cancelar.Enabled = True
        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = False

        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = True
                objeto.Text = ""
            End If
            If TypeOf objeto Is ComboBox Then
                Dim actual As ComboBox = objeto
                actual.Enabled = True
                actual.SelectedIndex = -1
            End If
        Next
        Me.cmd_eliminar.Enabled = False
        Me.msk_nrodoc.Enabled = True
        Me.txt_apellido.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub cmd_guardarProfesor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("La insersión se realizo exitosamente.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya esta cargada una persona con ese documento", _
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
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
                objeto.Enabled = False
            End If
            If TypeOf objeto Is ComboBox Then
                Dim actual As ComboBox = objeto
                actual.SelectedIndex = -1
                objeto.Enabled = False
            End If
        Next
        Me.msk_nrodoc.Text = ""
        Me.msk_nrodoc.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into Profesores ("
        cmd &= "Apellido, Nombre, Calle, Numero, CodPos, TipoDoc, NroDoc)"
        cmd &= " values ('" & Me.txt_apellido.Text & "', "
        cmd &= "'" & Me.txt_nombres.Text & "'"
        cmd &= ",'" & Me.txt_calle.Text & "'"
        cmd &= ",'" & Me.txt_nrocalle.Text & "'"
        cmd &= ",'" & Me.cmb_codpostal.SelectedValue & "'"
        cmd &= ",'" & Me.cmb_tipodoc.SelectedValue & "'"
        cmd &= ",'" & Me.msk_nrodoc.Text & "')"

        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado

    End Function

    Private Function modificar() As termino
        Dim cmd As String = ""
        cmd = "Update Profesores  "
        cmd &= "Set Apellido = '" & Me.txt_apellido.Text & "', "
        cmd &= "Nombre = '" & Me.txt_nombres.Text & "'"
        cmd &= ", TipoDoc = '" & Me.cmb_tipodoc.SelectedValue
        ' cmd &= ", nroDoc = " & Me.msk_nrodoc.Text & "'" //UN NUMERO DE DOCUMENTO NO PUEDE SER MODIFICADO
        cmd &= "', Calle = '" & Me.txt_calle.Text & "'"
        cmd &= ", Numero = '" & Me.txt_nrocalle.Text & "'"
        cmd &= ", CodPos = '" & Me.cmb_codpostal.SelectedValue
        cmd &= "' where NroDoc = '" & Me.msk_nrodoc.Text & "'"

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function

    Private Sub cmd_cancelarProfesor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Está seguro que desea cancelar este registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            cmd_cancelar.Enabled = False
            cmd_guardar.Enabled = False
            For Each objeto As System.Windows.Forms.Control In Me.Controls
                If TypeOf objeto Is TextBox Then
                    objeto.Text = ""
                    objeto.Enabled = False
                End If
                If TypeOf objeto Is ComboBox Then
                    Dim actual As ComboBox = objeto
                    actual.SelectedIndex = -1
                    objeto.Enabled = False
                End If
            Next
            Me.msk_nrodoc.Text = ""
            Me.msk_nrodoc.Enabled = False
        End If
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

    Private Sub carga_grilla()

   
        Dim txt_sql As String = ""
        Dim tabla As Data.DataTable
        txt_sql = " SELECT  Profesores.CodProf, Profesores.Nombre, Profesores.Apellido, Profesores.Calle, Profesores.Numero, CodigosPost.Nombre AS 'Codigo Postal',"
        txt_sql &= " TiposDoc.Nombre AS 'Tipo Documento', Profesores.NroDoc"
        txt_sql &= " FROM (Profesores LEFT JOIN TiposDoc ON Profesores.TipoDoc = TiposDoc.TipoDoc) "
        txt_sql &= "LEFT JOIN CodigosPost ON Profesores.CodPos = CodigosPost.CodPos"


        tabla = acceso.ejecutar(txt_sql)
        grd_dgvProfesor.DataSource = tabla


    End Sub

  

    Private Sub cmd_eliminarProfesor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            Dim txt_sql As String = ""
            txt_sql = "delete from Profesores where NroDoc = " & Me.grd_dgvProfesor.CurrentRow.Cells("NroDoc").Value
            acceso.ejecutarNonConsulta(txt_sql)


        End If
    End Sub

    Private Sub form_ABMProfesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet1.CodigosPost' Puede moverla o quitarla según sea necesario.
        Me.CodigosPostTableAdapter.Fill(Me.TPIPAVIDataSet1.CodigosPost)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.TiposDoc' Puede moverla o quitarla según sea necesario.
        Me.TiposDocTableAdapter.Fill(Me.TPIPAVIDataSet1.TiposDoc)
  
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = False
            End If
            If TypeOf objeto Is ComboBox Then
                objeto.Enabled = False
            End If
        Next
        msk_nrodoc.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        Me.carga_grilla()
    End Sub

    Private Sub grd_dgvProfesor_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_dgvProfesor.CellContentDoubleClick
        Dim doc As String = Me.grd_dgvProfesor.CurrentRow.Cells("NroDoc").Value
        Dim consulta As String = "select * from profesores where NroDoc = " & doc
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)
        msk_nrodoc.Text = tabla.Rows(0)("NroDoc")
        txt_apellido.Text = tabla.Rows(0)("Apellido")
        txt_nombres.Text = tabla.Rows(0)("Nombre")
        cmb_tipodoc.SelectedValue = tabla.Rows(0)("TipoDoc")
        txt_calle.Text = tabla.Rows(0)("Calle")
        txt_nrocalle.Text = tabla.Rows(0)("Numero")
        cmb_codpostal.SelectedValue = tabla.Rows(0)("CodPos")
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = True
            End If
            If TypeOf objeto Is ComboBox Then
                objeto.Enabled = True
            End If
        Next
        cmd_nuevo.Enabled = False
        cmd_eliminar.Enabled = False
        cmd_guardar.Enabled = True
        cmd_cancelar.Enabled = True

        Me.msk_nrodoc.Enabled = False

        Me.accion = estado.modificar
    End Sub

    Private Sub grd_dgvProfesor_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_dgvProfesor.CellContentClick
        Me.cmd_eliminar.Enabled = True
    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.TiposDocTableAdapter.FillBy(Me.TPIPAVIDataSet.TiposDoc)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class
