Public Class frm_ListadoNadadores
    Dim cadena As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPIPAVI;Integrated Security=True"
    Dim acceso As New accesoBD With {._cadenaConexion = cadena, _
                                     ._tipoBaseDatos = accesoBD.BaseDatos.SqlServer}

    Private Sub ListadoNadadores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TPIPAVIDataSet.Nadadores' Puede moverla o quitarla según sea necesario.
        Me.NadadoresTableAdapter.Fill(Me.TPIPAVIDataSet.Nadadores)
        Me.ToolTip1.SetToolTip(_cmd_calcular, "Ingrese un intervalo de Codigos de Nadador para filtrar en ese intervalo")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ProfesoresConAlumnosEnClub_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "¡Importante!", _
 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
 Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub _cmd_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmd_calcular.Click
        Dim sql As String = ""
        If Me._txt_inicial.Text = "" Then
            MessageBox.Show("Debe ingresar un valor INICIAL para el intervalo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me._txt_inicial.Focus()
            Return
        End If
        If Me._txt_final.Text = "" Then
            MessageBox.Show("Debe ingresar un valor FINAL para el intervalo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me._txt_final.Focus()
            Return
        End If
        Dim tabla As Data.DataTable
      
            sql = "Select * from Nadadores "
            sql &= " where CodNad between " & Me._txt_inicial.Text
            sql &= " and " & Me._txt_final.Text
            tabla = acceso.ejecutar(sql)
            Me.NadadoresBindingSource.DataSource = tabla

        Me._txt_final.Text = ""
        Me._txt_inicial.Text = ""
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub cmd_todos_Click(sender As System.Object, e As System.EventArgs) Handles cmd_todos.Click
        Dim sql As String = ""
        Dim tabla As Data.DataTable
        Sql = "select * from Nadadores"
        tabla = acceso.ejecutar(Sql)
        Me.NadadoresBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class