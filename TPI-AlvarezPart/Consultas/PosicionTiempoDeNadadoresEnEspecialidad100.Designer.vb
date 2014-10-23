<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PosicionTiempoNadadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DSPosTiempoNad1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPosTiempoNad1 = New TPI_PAVI.DSPosTiempoNad()
        Me.cmd_ejecutarConsulta = New System.Windows.Forms.Button()
        Me.cmb_nadador = New System.Windows.Forms.ComboBox()
        Me.NadadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmd_consultaPerso = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_help = New System.Windows.Forms.Button()
        Me.NadadoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter()
        Me.EspecialidadTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        Me.rp_nadPosTiempo = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DSPosTiempoNad1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPosTiempoNad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DSPosTiempoNad1BindingSource
        '
        Me.DSPosTiempoNad1BindingSource.DataSource = Me.DSPosTiempoNad1
        Me.DSPosTiempoNad1BindingSource.Position = 0
        '
        'DSPosTiempoNad1
        '
        Me.DSPosTiempoNad1.DataSetName = "DSPosTiempoNad"
        Me.DSPosTiempoNad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmd_ejecutarConsulta
        '
        Me.cmd_ejecutarConsulta.Location = New System.Drawing.Point(12, 284)
        Me.cmd_ejecutarConsulta.Name = "cmd_ejecutarConsulta"
        Me.cmd_ejecutarConsulta.Size = New System.Drawing.Size(126, 41)
        Me.cmd_ejecutarConsulta.TabIndex = 0
        Me.cmd_ejecutarConsulta.Text = "Ejecutar Consulta Estándar"
        Me.cmd_ejecutarConsulta.UseVisualStyleBackColor = True
        '
        'cmb_nadador
        '
        Me.cmb_nadador.DataSource = Me.NadadoresBindingSource
        Me.cmb_nadador.DisplayMember = "Apellido"
        Me.cmb_nadador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nadador.FormattingEnabled = True
        Me.cmb_nadador.Location = New System.Drawing.Point(85, 16)
        Me.cmb_nadador.Name = "cmb_nadador"
        Me.cmb_nadador.Size = New System.Drawing.Size(121, 21)
        Me.cmb_nadador.TabIndex = 1
        Me.cmb_nadador.ValueMember = "CodNad"
        '
        'NadadoresBindingSource
        '
        Me.NadadoresBindingSource.DataMember = "Nadadores"
        Me.NadadoresBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nadador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Especialidad:"
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.DataSource = Me.EspecialidadBindingSource
        Me.cmb_especialidad.DisplayMember = "Descripcion"
        Me.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(85, 49)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_especialidad.TabIndex = 1
        Me.cmb_especialidad.ValueMember = "CodEspe"
        '
        'EspecialidadBindingSource
        '
        Me.EspecialidadBindingSource.DataMember = "Especialidad"
        Me.EspecialidadBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'cmd_consultaPerso
        '
        Me.cmd_consultaPerso.Location = New System.Drawing.Point(144, 284)
        Me.cmd_consultaPerso.Name = "cmd_consultaPerso"
        Me.cmd_consultaPerso.Size = New System.Drawing.Size(126, 41)
        Me.cmd_consultaPerso.TabIndex = 0
        Me.cmd_consultaPerso.Text = "Ejecutar Consulta Personalizada"
        Me.cmd_consultaPerso.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado de la consulta:"
        '
        'cmd_help
        '
        Me.cmd_help.BackgroundImage = Global.TPI_PAVI.My.Resources.Resources.help1
        Me.cmd_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_help.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_help.Location = New System.Drawing.Point(411, 284)
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(50, 41)
        Me.cmd_help.TabIndex = 0
        Me.cmd_help.UseVisualStyleBackColor = True
        '
        'NadadoresTableAdapter
        '
        Me.NadadoresTableAdapter.ClearBeforeFill = True
        '
        'EspecialidadTableAdapter
        '
        Me.EspecialidadTableAdapter.ClearBeforeFill = True
        '
        'rp_nadPosTiempo
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DSPosTiempoNad1BindingSource
        Me.rp_nadPosTiempo.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rp_nadPosTiempo.LocalReport.ReportEmbeddedResource = "TPI_PAVI.posTiempoNad.rdlc"
        Me.rp_nadPosTiempo.Location = New System.Drawing.Point(12, 112)
        Me.rp_nadPosTiempo.Name = "rp_nadPosTiempo"
        Me.rp_nadPosTiempo.Size = New System.Drawing.Size(449, 166)
        Me.rp_nadPosTiempo.TabIndex = 7
        '
        'frm_PosicionTiempoNadadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 333)
        Me.Controls.Add(Me.rp_nadPosTiempo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_especialidad)
        Me.Controls.Add(Me.cmb_nadador)
        Me.Controls.Add(Me.cmd_help)
        Me.Controls.Add(Me.cmd_consultaPerso)
        Me.Controls.Add(Me.cmd_ejecutarConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_PosicionTiempoNadadores"
        Me.Text = "Posicion y Tiempo de Nadadores"
        CType(Me.DSPosTiempoNad1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPosTiempoNad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_ejecutarConsulta As System.Windows.Forms.Button
    Friend WithEvents cmb_nadador As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_consultaPerso As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_help As System.Windows.Forms.Button
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents NadadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
    Friend WithEvents rp_nadPosTiempo As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DSPosTiempoNad1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSPosTiempoNad1 As TPI_PAVI.DSPosTiempoNad
End Class
