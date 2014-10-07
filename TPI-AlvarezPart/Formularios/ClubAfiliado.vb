Public Class frm_ClubAfiliado
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim codClub As Integer
    Dim accion As estado = estado.insertar
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub ClubAfiliado_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
       MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
       Windows.Forms.DialogResult.OK Then
            cancelar()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ClubAfiliado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Clubes' Puede moverla o quitarla según sea necesario.
        Me.ClubesTableAdapter.Fill(Me.TPIPAVIDataSet.Clubes)
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Enabled = False
            End If
        Next
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
    End Sub

    Private Function validar() As Boolean
        If Me.txt_nombre.Text = "" Then
            MsgBox("El nombre del club no puede estar vacio", MsgBoxStyle.Critical, "¡Importante!")
            Me.txt_nombre.Focus()
            Return False
        End If
        If Me.txt_calle.Text = "" Then
            MsgBox("La calle del club no puede estar vacia", MsgBoxStyle.Critical, "¡Importante!")
            Return False
        End If
        If Me.txt_nroCalle.Text = "" Then
            MsgBox("El número de calle del club no puede estar vacio", MsgBoxStyle.Critical, "¡Importante!")
            Return False
        End If
        Return True
    End Function

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select * from Clubes "
        consulta &= " where Nombre = '" & Me.txt_nombre.Text & "'"
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Sub cmd_nuevoClub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click

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

    Private Sub cmd_guardarCLub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("La insersión se realizo exitosamente.", _
                                    "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya esta cargado un club con el mismo nombre", _
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
        Next
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub

    Private Function insertar() As termino
        Dim cmd As String = ""
        cmd = "insert into Clubes ("
        cmd &= "Nombre, Calle, Numero)"
        cmd &= " values ('" & Me.txt_nombre.Text & "', "
        cmd &= "'" & Me.txt_calle.Text & "'"
        cmd &= ",'" & Me.txt_nroCalle.Text & "')"

        acceso.ejecutarNonConsulta(cmd)
        Return termino.aprobado

    End Function

    Private Function modificar() As termino
        Dim cmd As String = ""
        cmd = "Update Clubes  "
        cmd &= "Set Nombre = '" & Me.txt_nombre.Text & "', "
        cmd &= "Calle = '" & Me.txt_calle.Text & "'"
        cmd &= ", Numero = '" & Me.txt_nroCalle.Text & "'"
        cmd &= " where CodClub = '" & codClub & "'"

        acceso.ejecutarNonConsulta(cmd)

        Return termino.aprobado

    End Function

    Private Sub carga_grilla()

        Dim txt_sql As String = ""

        txt_sql = " SELECT  Clubes.CodClub, Clubes.Nombre, Clubes.Numero, Clubes.Calle"
        txt_sql += " FROM Clubes "
        grd_dgvClubes.DataSource = acceso.ejecutar(txt_sql)
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Está seguro que desea cancelar este registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            cancelar()
        End If
    End Sub

    Private Sub grd_dgvClubes_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_dgvClubes.CellContentDoubleClick
        codClub = Me.grd_dgvClubes.CurrentRow.Cells("CodClubDataGridViewTextBoxColumn").Value
        Dim consulta As String = "select * from Clubes where CodClub = " & codClub
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)
        txt_nombre.Text = tabla.Rows(0)("Nombre")
        txt_calle.Text = tabla.Rows(0)("Calle")
        txt_nroCalle.Text = tabla.Rows(0)("Numero")

        Me.txt_nombre.Enabled = True
        Me.txt_calle.Enabled = True
        Me.txt_nroCalle.Enabled = True

        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevo.Enabled = False
        Me.cmd_eliminar.Enabled = False

        Me.accion = estado.modificar
    End Sub

    Private Sub grd_dgvClubes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_dgvClubes.CellContentClick
        Me.cmd_eliminar.Enabled = True
    End Sub

    Private Sub cmd_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Dim txt_sql As String = ""
            txt_sql = "delete from Clubes where CodClub = " & Me.grd_dgvClubes.CurrentRow.Cells("CodClubDataGridViewTextBoxColumn").Value
            acceso.ejecutarNonConsulta(txt_sql)
            Me.carga_grilla()
        End If
    End Sub

    Private Sub cancelar()
        Me.txt_nombre.Text = ""
        Me.txt_calle.Text = ""
        Me.txt_nroCalle.Text = ""
        Me.txt_nombre.Enabled = False
        Me.txt_calle.Enabled = False
        Me.txt_nroCalle.Enabled = False
        Me.cmd_cancelar.Enabled = False
        Me.cmd_guardar.Enabled = False
        Me.cmd_eliminar.Enabled = True
        Me.cmd_nuevo.Enabled = True
    End Sub
End Class