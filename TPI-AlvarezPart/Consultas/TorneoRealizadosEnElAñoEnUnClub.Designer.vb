<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TorneoRealizadosEnElAñoEnUnClub
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grd_dgvconsultaTorneoXClub = New System.Windows.Forms.DataGridView()
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.ClubesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msk_anio = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_ejecutarConsulta = New System.Windows.Forms.Button()
        Me.cmd_ejecutarConsultaPerso = New System.Windows.Forms.Button()
        Me.cmd_help = New System.Windows.Forms.Button()
        Me.tt_consultaestandar = New System.Windows.Forms.ToolTip(Me.components)
        Me.tt_consultapersonal = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClubesTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter()
        CType(Me.grd_dgvconsultaTorneoXClub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Resultado de la consulta:"
        '
        'grd_dgvconsultaTorneoXClub
        '
        Me.grd_dgvconsultaTorneoXClub.AllowUserToAddRows = False
        Me.grd_dgvconsultaTorneoXClub.AllowUserToDeleteRows = False
        Me.grd_dgvconsultaTorneoXClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvconsultaTorneoXClub.Enabled = False
        Me.grd_dgvconsultaTorneoXClub.Location = New System.Drawing.Point(12, 111)
        Me.grd_dgvconsultaTorneoXClub.Name = "grd_dgvconsultaTorneoXClub"
        Me.grd_dgvconsultaTorneoXClub.ReadOnly = True
        Me.grd_dgvconsultaTorneoXClub.Size = New System.Drawing.Size(454, 173)
        Me.grd_dgvconsultaTorneoXClub.TabIndex = 4
        '
        'cmb_club
        '
        Me.cmb_club.DataSource = Me.ClubesBindingSource
        Me.cmb_club.DisplayMember = "Nombre"
        Me.cmb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(198, 14)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(121, 21)
        Me.cmb_club.TabIndex = 8
        Me.cmb_club.ValueMember = "CodClub"
        '
        'ClubesBindingSource
        '
        Me.ClubesBindingSource.DataMember = "Clubes"
        Me.ClubesBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Club:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Año: "
        '
        'msk_anio
        '
        Me.msk_anio.BeepOnError = True
        Me.msk_anio.Location = New System.Drawing.Point(62, 15)
        Me.msk_anio.Mask = "9999"
        Me.msk_anio.Name = "msk_anio"
        Me.msk_anio.Size = New System.Drawing.Size(31, 20)
        Me.msk_anio.TabIndex = 5
        '
        'cmd_ejecutarConsulta
        '
        Me.cmd_ejecutarConsulta.Location = New System.Drawing.Point(13, 300)
        Me.cmd_ejecutarConsulta.Name = "cmd_ejecutarConsulta"
        Me.cmd_ejecutarConsulta.Size = New System.Drawing.Size(107, 38)
        Me.cmd_ejecutarConsulta.TabIndex = 10
        Me.cmd_ejecutarConsulta.Text = "Ejecutar Consulta Estándar"
        Me.cmd_ejecutarConsulta.UseVisualStyleBackColor = True
        '
        'cmd_ejecutarConsultaPerso
        '
        Me.cmd_ejecutarConsultaPerso.Location = New System.Drawing.Point(192, 300)
        Me.cmd_ejecutarConsultaPerso.Name = "cmd_ejecutarConsultaPerso"
        Me.cmd_ejecutarConsultaPerso.Size = New System.Drawing.Size(156, 38)
        Me.cmd_ejecutarConsultaPerso.TabIndex = 11
        Me.cmd_ejecutarConsultaPerso.Text = "Ejecutar Consulta Personalizada"
        Me.cmd_ejecutarConsultaPerso.UseVisualStyleBackColor = True
        '
        'cmd_help
        '
        Me.cmd_help.Location = New System.Drawing.Point(420, 300)
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(47, 38)
        Me.cmd_help.TabIndex = 9
        Me.cmd_help.Text = "Help"
        Me.cmd_help.UseVisualStyleBackColor = True
        '
        'ClubesTableAdapter
        '
        Me.ClubesTableAdapter.ClearBeforeFill = True
        '
        'TorneoRealizadosEnElAñoEnUnClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 372)
        Me.Controls.Add(Me.cmd_ejecutarConsulta)
        Me.Controls.Add(Me.cmd_ejecutarConsultaPerso)
        Me.Controls.Add(Me.cmd_help)
        Me.Controls.Add(Me.cmb_club)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msk_anio)
        Me.Controls.Add(Me.grd_dgvconsultaTorneoXClub)
        Me.Controls.Add(Me.Label3)
        Me.Name = "TorneoRealizadosEnElAñoEnUnClub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Torneo en un Club"
        CType(Me.grd_dgvconsultaTorneoXClub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grd_dgvconsultaTorneoXClub As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents msk_anio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_ejecutarConsulta As System.Windows.Forms.Button
    Friend WithEvents cmd_ejecutarConsultaPerso As System.Windows.Forms.Button
    Friend WithEvents cmd_help As System.Windows.Forms.Button
    Friend WithEvents tt_consultaestandar As System.Windows.Forms.ToolTip
    Friend WithEvents tt_consultapersonal As System.Windows.Forms.ToolTip
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents ClubesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter
End Class
