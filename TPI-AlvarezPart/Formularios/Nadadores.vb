Public Class frm_ABMnadadores
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

    Private Sub frm_abmNadadores_acceso_datos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
        Windows.Forms.DialogResult.OK Then
            cancelar()
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

        If Me.cmb_profesor.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un elemento de la lista.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_tipodoc.Focus()
            Return False
        End If

        If Me.cmb_club.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un elemento de la lista.", MsgBoxStyle.Critical, "¡Importante!")
            Me.cmb_tipodoc.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from Nadadores"
        consulta &= " where TipoDoc = " & Me.cmb_tipodoc.SelectedValue
        consulta &= " and NroDoc = " & Me.msk_nrodoc.Text
        tabla = acceso.ejecutar(consulta)

        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Sub cmd_nuevoNadadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click

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

    Private Sub cmd_guardarNadador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
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

        Me.carga_grilla()
    End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into Nadadores ("
        cmd &= "Apellido,  Nombre, TipoDoc, NroDoc, Calle, Numero, CodPos, CodProf, CodClub)"
        cmd &= " values ('" & Me.txt_apellido.Text & "'"
        cmd &= ", '" & Me.txt_nombres.Text & "'"
        cmd &= ",'" & Me.cmb_tipodoc.SelectedValue & "'"
        cmd &= ",'" & Me.msk_nrodoc.Text & "'"
        cmd &= ",'" & Me.txt_calle.Text & "'"
        cmd &= ",'" & Me.txt_nrocalle.Text & "'"
        cmd &= ",'" & Me.cmb_codpostal.SelectedValue & "'"
        cmd &= ",'" & Me.cmb_profesor.SelectedValue & "'"
        cmd &= ",'" & Me.cmb_club.SelectedValue & "')"
        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado

    End Function
    'NRO CALLE CAMBIAAR
    Private Function modificar() As termino
        Dim cmd As String = ""
        cmd = "Update Nadadores "
        cmd &= "Set Nombre = '" & Me.txt_nombres.Text & "'"
        cmd &= ", Apellido = '" & Me.txt_apellido.Text & "'"
        cmd &= ", TipoDoc = '" & Me.cmb_tipodoc.SelectedValue & "'"
        ' cmd &= ", nroDoc = " & Me.msk_nrodoc.Text & "'" //UN NUMERO DE DOCUMENTO NO PUEDE SER MODIFICADO
        cmd &= ", Calle = '" & Me.txt_calle.Text & "'"
        cmd &= ", Numero = '" & Me.txt_nrocalle.Text & "'"
        cmd &= ", CodPos = '" & Me.cmb_codpostal.SelectedValue & "'"
        cmd &= ", CodProf = '" & Me.cmb_profesor.SelectedValue & "'"
        cmd &= ", CodClub = '" & Me.cmb_club.SelectedValue & "'"
        cmd &= " where NroDoc = " & Me.msk_nrodoc.Text

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function

    Private Sub cmd_cancelarNadador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Está seguro que desea cancelar este registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If
    End Sub

    Private Sub carga_grilla()

        Dim txt_sql As String = ""


        txt_sql = "SELECT        Nadadores.CodNad, Nadadores.Nombre, Nadadores.Apellido, Nadadores.Calle, Nadadores.Numero, Nadadores.NroDoc, Clubes.Nombre AS Club, Profesores.Apellido AS Profesor, TiposDoc.Nombre AS TipoDoc, "
        txt_sql &= " CodigosPost.Nombre AS CodPost "
        txt_sql &= " FROM Nadadores INNER JOIN "
        txt_sql &= " TiposDoc ON Nadadores.TipoDoc = TiposDoc.TipoDoc INNER JOIN"
        txt_sql &= "  Profesores ON Nadadores.CodProf = Profesores.CodProf AND TiposDoc.TipoDoc = Profesores.TipoDoc INNER JOIN"
        txt_sql &= " Clubes ON Nadadores.CodClub = Clubes.CodClub INNER JOIN"
        txt_sql &= "  CodigosPost ON Nadadores.CodPos = CodigosPost.Codpos AND Profesores.CodPos = CodigosPost.Codpos"

        grd_dgvNadador.DataSource = acceso.ejecutar(txt_sql)


        '    Dim count As Integer = 0
        '   For count = 0 To tabla.Rows.Count - 1
        'Me.grd_dgvProfesor.Rows.Add(tabla.Rows(count)("apellido"), _
        '                  tabla.Rows(count)("nombres"), tabla.Rows(count)("tipodoc"), tabla.Rows(count)("nrodoc"), tabla.Rows(count)("calle") _
        '                 , tabla.Rows(count)("nrocalle"), tabla.Rows(count)("cp"))

        'Next
    End Sub

    Private Sub cmd_eliminarNadador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String = ""
            txt_sql = "delete from Nadadores where NroDoc = " & Me.grd_dgvNadador.CurrentRow.Cells("NroDoc").Value
            acceso.ejecutarNonConsulta(txt_sql)
            Me.carga_grilla()
        End If
    End Sub

    Private Sub form_ABMNadadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.NadaXEspe' Puede moverla o quitarla según sea necesario.
        Me.NadaXEspeTableAdapter.Fill(Me.TPIPAVIDataSet.NadaXEspe)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.TiposDoc' Puede moverla o quitarla según sea necesario.
        Me.TiposDocTableAdapter.Fill(Me.TPIPAVIDataSet.TiposDoc)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.CodigosPost' Puede moverla o quitarla según sea necesario.
        Me.CodigosPostTableAdapter.Fill(Me.TPIPAVIDataSet.CodigosPost)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me.TPIPAVIDataSet.Profesores)

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

    Private Sub grd_dgvNadadores_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_dgvNadador.CellContentDoubleClick
        Dim doc As String = Me.grd_dgvNadador.CurrentRow.Cells("NroDoc").Value
        Dim consulta As String = "select * from Nadadores where NroDoc = " & doc
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)
        txt_apellido.Text = tabla.Rows(0)("Apellido")
        txt_nombres.Text = tabla.Rows(0)("Nombre")
        cmb_tipodoc.SelectedValue = tabla.Rows(0)("TipoDoc")
        txt_calle.Text = tabla.Rows(0)("Calle")
        txt_nrocalle.Text = tabla.Rows(0)("Numero")
        cmb_codpostal.SelectedValue = tabla.Rows(0)("CodPos")
        cmb_profesor.SelectedValue = tabla.Rows(0)("CodProf")
        cmb_club.SelectedValue = tabla.Rows(0)("CodClub")
        msk_nrodoc.Text = tabla.Rows(0)("NroDoc")
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
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.accion = estado.modificar
    End Sub

    Private Sub cancelar()
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
    End Sub
  
End Class