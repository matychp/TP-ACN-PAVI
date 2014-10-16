<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProfesoresConAlumnosEnClub
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
        Me.grd_dgvProAlClub = New System.Windows.Forms.DataGridView()
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.ClubesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.ClubesTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_nadador = New System.Windows.Forms.ComboBox()
        Me.NadadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_consultaPerso = New System.Windows.Forms.Button()
        Me.cmd_help = New System.Windows.Forms.Button()
        CType(Me.grd_dgvProAlClub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_dgvProAlClub
        '
        Me.grd_dgvProAlClub.AllowUserToAddRows = False
        Me.grd_dgvProAlClub.AllowUserToDeleteRows = False
        Me.grd_dgvProAlClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvProAlClub.Location = New System.Drawing.Point(12, 161)
        Me.grd_dgvProAlClub.Name = "grd_dgvProAlClub"
        Me.grd_dgvProAlClub.ReadOnly = True
        Me.grd_dgvProAlClub.Size = New System.Drawing.Size(416, 133)
        Me.grd_dgvProAlClub.TabIndex = 0
        '
        'cmb_club
        '
        Me.cmb_club.DataSource = Me.ClubesBindingSource
        Me.cmb_club.DisplayMember = "Nombre"
        Me.cmb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(70, 22)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(121, 21)
        Me.cmb_club.TabIndex = 1
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
        'ClubesTableAdapter
        '
        Me.ClubesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Club:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nadador:"
        '
        'cmb_nadador
        '
        Me.cmb_nadador.DataSource = Me.NadadoresBindingSource
        Me.cmb_nadador.DisplayMember = "Apellido"
        Me.cmb_nadador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nadador.FormattingEnabled = True
        Me.cmb_nadador.Location = New System.Drawing.Point(70, 64)
        Me.cmb_nadador.Name = "cmb_nadador"
        Me.cmb_nadador.Size = New System.Drawing.Size(121, 21)
        Me.cmb_nadador.TabIndex = 4
        Me.cmb_nadador.ValueMember = "CodNad"
        '
        'NadadoresBindingSource
        '
        Me.NadadoresBindingSource.DataMember = "Nadadores"
        Me.NadadoresBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'NadadoresTableAdapter
        '
        Me.NadadoresTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado de la consulta:"
        '
        'cmd_consultaPerso
        '
        Me.cmd_consultaPerso.Location = New System.Drawing.Point(16, 327)
        Me.cmd_consultaPerso.Name = "cmd_consultaPerso"
        Me.cmd_consultaPerso.Size = New System.Drawing.Size(169, 36)
        Me.cmd_consultaPerso.TabIndex = 6
        Me.cmd_consultaPerso.Text = "Ejecutar Consulta Personalizada"
        Me.cmd_consultaPerso.UseVisualStyleBackColor = True
        '
        'cmd_help
        '
        Me.cmd_help.BackgroundImage = Global.TPI_PAVI.My.Resources.Resources.help1
        Me.cmd_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_help.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_help.Location = New System.Drawing.Point(381, 329)
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(47, 36)
        Me.cmd_help.TabIndex = 8
        Me.cmd_help.UseVisualStyleBackColor = True
        '
        'frm_ProfesoresConAlumnosEnClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 375)
        Me.Controls.Add(Me.cmd_help)
        Me.Controls.Add(Me.cmd_consultaPerso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_nadador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_club)
        Me.Controls.Add(Me.grd_dgvProAlClub)
        Me.Name = "frm_ProfesoresConAlumnosEnClub"
        Me.Text = "ProfesoresConAlumnosEnClub"
        CType(Me.grd_dgvProAlClub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_dgvProAlClub As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents ClubesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_nadador As System.Windows.Forms.ComboBox
    Friend WithEvents NadadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_consultaPerso As System.Windows.Forms.Button
    Friend WithEvents cmd_help As System.Windows.Forms.Button
End Class
