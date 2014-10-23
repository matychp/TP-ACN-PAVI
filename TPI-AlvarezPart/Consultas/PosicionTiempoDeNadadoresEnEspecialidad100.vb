Public Class frm_PosicionTiempoNadadores

    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub PosicionTiempoDeNadadoresEnEspecialidad100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Especialidad' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadTableAdapter.Fill(Me.TPIPAVIDataSet.Especialidad)
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.TPIPAVIDataSet.Nadadores)
        cmb_especialidad.SelectedValue = -1
        cmb_nadador.SelectedValue = -1
        Me.rp_nadPosTiempo.RefreshReport()
    End Sub

    Private Sub PosicionTiempoDeNadador100_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
        Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub resultado(ByVal especialidad As Integer, ByVal nadador As Integer)
        Dim txt_sql As String
        Dim tabla As New Data.DataTable
        Dim tablaAux As New Data.DataTable
        If cmb_nadador.SelectedIndex < 0 Then
            txt_sql = " Select Nadadores.Apellido , Inscriptos.Posicion, Inscriptos.Tiempo, Especialidad.Descripcion "
            txt_sql &= " From Inscriptos INNER JOIN Nadadores ON Inscriptos.CodNad = Nadadores.CodNad "
            txt_sql &= " INNER JOIN Especialidad ON Especialidad.CodEspe = Inscriptos.CodEspe"
            txt_sql &= " Where Inscriptos.CodEspe = " & especialidad
        Else
            txt_sql = " Select Nadadores.Apellido, Inscriptos.Posicion, Inscriptos.Tiempo, Especialidad.Descripcion "
            txt_sql &= " From Inscriptos INNER JOIN Nadadores ON Inscriptos.CodNad = Nadadores.CodNad "
            txt_sql &= " INNER JOIN Especialidad ON Especialidad.CodEspe = Inscriptos.CodEspe"
            txt_sql &= " Where Inscriptos.CodEspe = " & especialidad & "AND Nadadores.CodNad = " & nadador
        End If

        tabla = acceso.ejecutar(txt_sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado coincidencias con la busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DSPosTiempoNad1BindingSource.DataSource = tablaAux
        Else
            Me.DSPosTiempoNad1BindingSource.DataSource = tabla
        End If

        cmb_especialidad.SelectedIndex = -1
        cmb_nadador.SelectedIndex = -1
        Me.rp_nadPosTiempo.RefreshReport()
    End Sub

    Private Sub resultado()
        Dim txt_sql As String
        Dim tabla As Data.DataTable = New Data.DataTable
        Dim tablaAux As Data.DataTable = New Data.DataTable

        txt_sql = " select Nadadores.Apellido, Inscriptos.Posicion, Inscriptos.Tiempo, Especialidad.Descripcion "
        txt_sql &= " from Inscriptos INNER JOIN Nadadores ON Inscriptos.CodNad = Nadadores.CodNad  "
        txt_sql &= " INNER JOIN Especialidad ON Especialidad.CodEspe = Inscriptos.CodEspe"
        txt_sql &= " where Especialidad.Descripcion LIKE '100 mts. Libre'" 'No se el contenido de la BD, asi que '100 mts. Libres' hay que verlo si esta igual...

        tabla = acceso.ejecutar(txt_sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se han encontrado coincidencias con la busqueda.", "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DSPosTiempoNad1BindingSource.DataSource = tablaAux
        Else
            'Me.grd_dgvTiempoPosNad.DataSource = tabla
            Me.DSPosTiempoNad1BindingSource.DataSource = tabla
        End If

        cmb_nadador.SelectedIndex = -1
        cmb_especialidad.SelectedIndex = -1
        Me.rp_nadPosTiempo.RefreshReport()
    End Sub


    Private Function validar() As Boolean

        Dim tablaAux As Data.DataTable = New Data.DataTable

        If Me.cmb_especialidad.SelectedIndex = -1 Then
            MessageBox.Show("Debe ingresar una Especialidad para realizar la consulta.", "¡Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_especialidad.Focus()
            DSPosTiempoNad1BindingSource.DataSource = tablaAux
            Return False
        End If

        Return True

    End Function

    Private Sub cmd_ejecutarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_consultaPerso.Click

        If Me.validar() = True Then
            Dim esp As Integer = cmb_especialidad.SelectedValue
            Dim nad As Integer = cmb_nadador.SelectedValue
            Me.resultado(esp, nad)
        End If

    End Sub

    Private Sub cmd_ejecutarConsulta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ejecutarConsulta.Click
        Me.resultado()
    End Sub

    Private Sub cmd_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_help.Click
        Dim mensaje As String
        mensaje = "Para consultar el Tiempo y Posición que tienen los Nadadores en la Especialidad 100 metros libres seleccione Ejecutar Consulta Esttándar, sino, " & vbCrLf
        mensaje &= "si quiere consultar para Nadadores de una determinada Especialidad, seleccione la Especialidad Y/O Nadador y finalmente presione Ejecutar Consulta Personalizada. "
        MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class