<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMnadadores
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
        Me.cmb_codpostal = New System.Windows.Forms.ComboBox()
        Me.CodigosPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.CodigosPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.msk_nrodoc = New System.Windows.Forms.MaskedTextBox()
        Me.grd_dgvNadador = New System.Windows.Forms.DataGridView()
        Me.NadadoresBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_tipodoc = New System.Windows.Forms.ComboBox()
        Me.TiposDocBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_nrocalle = New System.Windows.Forms.TextBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.ProfesoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClubesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NadadoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter()
        Me.ProfesoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfesoresTableAdapter()
        Me.CodigosPostTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.CodigosPostTableAdapter()
        Me.ClubesTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter()
        Me.TiposDocTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.TiposDocTableAdapter()
        Me.NadadoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadaXEspeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadaXEspeTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadaXEspeTableAdapter()
        Me.NadadoresBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.ClubesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClubesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClubesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClubesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_profesor = New System.Windows.Forms.ComboBox()
        Me.ProfesoresBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClubesBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClubesBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClubesBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CodigosPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_dgvNadador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadaXEspeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_codpostal
        '
        Me.cmb_codpostal.DataSource = Me.CodigosPostBindingSource1
        Me.cmb_codpostal.DisplayMember = "Nombre"
        Me.cmb_codpostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_codpostal.FormattingEnabled = True
        Me.cmb_codpostal.Location = New System.Drawing.Point(507, 77)
        Me.cmb_codpostal.Name = "cmb_codpostal"
        Me.cmb_codpostal.Size = New System.Drawing.Size(92, 21)
        Me.cmb_codpostal.TabIndex = 6
        Me.cmb_codpostal.ValueMember = "Codpos"
        '
        'CodigosPostBindingSource1
        '
        Me.CodigosPostBindingSource1.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource1.DataSource = Me.TPIPAVIDataSet
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigosPostBindingSource
        '
        Me.CodigosPostBindingSource.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'msk_nrodoc
        '
        Me.msk_nrodoc.Location = New System.Drawing.Point(253, 73)
        Me.msk_nrodoc.Mask = "99999999"
        Me.msk_nrodoc.Name = "msk_nrodoc"
        Me.msk_nrodoc.Size = New System.Drawing.Size(60, 20)
        Me.msk_nrodoc.TabIndex = 3
        '
        'grd_dgvNadador
        '
        Me.grd_dgvNadador.AllowUserToAddRows = False
        Me.grd_dgvNadador.AllowUserToDeleteRows = False
        Me.grd_dgvNadador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvNadador.Location = New System.Drawing.Point(22, 165)
        Me.grd_dgvNadador.Name = "grd_dgvNadador"
        Me.grd_dgvNadador.ReadOnly = True
        Me.grd_dgvNadador.Size = New System.Drawing.Size(745, 254)
        Me.grd_dgvNadador.TabIndex = 13
        '
        'NadadoresBindingSource7
        '
        Me.NadadoresBindingSource7.DataMember = "Nadadores"
        Me.NadadoresBindingSource7.DataSource = Me.TPIPAVIDataSet
        '
        'NadadoresBindingSource6
        '
        Me.NadadoresBindingSource6.DataMember = "Nadadores"
        Me.NadadoresBindingSource6.DataSource = Me.TPIPAVIDataSet
        '
        'NadadoresBindingSource5
        '
        Me.NadadoresBindingSource5.DataMember = "Nadadores"
        Me.NadadoresBindingSource5.DataSource = Me.TPIPAVIDataSet
        '
        'NadadoresBindingSource3
        '
        Me.NadadoresBindingSource3.DataMember = "Nadadores"
        Me.NadadoresBindingSource3.DataSource = Me.TPIPAVIDataSet
        '
        'NadadoresBindingSource
        '
        Me.NadadoresBindingSource.DataMember = "Nadadores"
        Me.NadadoresBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Número:"
        '
        'cmb_tipodoc
        '
        Me.cmb_tipodoc.DataSource = Me.TiposDocBindingSource2
        Me.cmb_tipodoc.DisplayMember = "Nombre"
        Me.cmb_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipodoc.FormattingEnabled = True
        Me.cmb_tipodoc.Location = New System.Drawing.Point(131, 72)
        Me.cmb_tipodoc.Name = "cmb_tipodoc"
        Me.cmb_tipodoc.Size = New System.Drawing.Size(63, 21)
        Me.cmb_tipodoc.TabIndex = 2
        Me.cmb_tipodoc.ValueMember = "TipoDoc"
        '
        'TiposDocBindingSource1
        '
        Me.TiposDocBindingSource1.DataMember = "TiposDoc"
        Me.TiposDocBindingSource1.DataSource = Me.TPIPAVIDataSet
        '
        'TiposDocBindingSource
        '
        Me.TiposDocBindingSource.DataMember = "TiposDoc"
        Me.TiposDocBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(383, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Domicilio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Calle:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Número:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(426, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Código Postal:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(465, 25)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(134, 20)
        Me.txt_calle.TabIndex = 4
        '
        'txt_nrocalle
        '
        Me.txt_nrocalle.Location = New System.Drawing.Point(479, 51)
        Me.txt_nrocalle.Name = "txt_nrocalle"
        Me.txt_nrocalle.Size = New System.Drawing.Size(120, 20)
        Me.txt_nrocalle.TabIndex = 5
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(22, 425)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(83, 31)
        Me.cmd_nuevo.TabIndex = 9
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(111, 425)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_eliminar.TabIndex = 10
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(595, 425)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_guardar.TabIndex = 11
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(684, 425)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_cancelar.TabIndex = 12
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'ProfesoresBindingSource1
        '
        Me.ProfesoresBindingSource1.DataMember = "Profesores"
        Me.ProfesoresBindingSource1.DataSource = Me.TPIPAVIDataSet
        '
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "Profesores"
        Me.ProfesoresBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'ClubesBindingSource
        '
        Me.ClubesBindingSource.DataMember = "Clubes"
        Me.ClubesBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.TPI_PAVI.My.Resources.Resources.ico_n_natacion
        Me.PictureBox1.Location = New System.Drawing.Point(617, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'NadadoresTableAdapter
        '
        Me.NadadoresTableAdapter.ClearBeforeFill = True
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'CodigosPostTableAdapter
        '
        Me.CodigosPostTableAdapter.ClearBeforeFill = True
        '
        'ClubesTableAdapter
        '
        Me.ClubesTableAdapter.ClearBeforeFill = True
        '
        'TiposDocTableAdapter
        '
        Me.TiposDocTableAdapter.ClearBeforeFill = True
        '
        'NadadoresBindingSource1
        '
        Me.NadadoresBindingSource1.DataMember = "Nadadores"
        Me.NadadoresBindingSource1.DataSource = Me.TPIPAVIDataSet
        '
        'NadadoresBindingSource2
        '
        Me.NadadoresBindingSource2.DataMember = "Nadadores"
        Me.NadadoresBindingSource2.DataSource = Me.TPIPAVIDataSet
        '
        'NadaXEspeBindingSource
        '
        Me.NadaXEspeBindingSource.DataMember = "NadaXEspe"
        Me.NadaXEspeBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'NadaXEspeTableAdapter
        '
        Me.NadaXEspeTableAdapter.ClearBeforeFill = True
        '
        'NadadoresBindingSource4
        '
        Me.NadadoresBindingSource4.DataMember = "Nadadores"
        Me.NadadoresBindingSource4.DataSource = Me.TPIPAVIDataSet
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Club:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Profesor:"
        '
        'cmb_club
        '
        Me.cmb_club.DataSource = Me.ClubesBindingSource7
        Me.cmb_club.DisplayMember = "Nombre"
        Me.cmb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(63, 138)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(250, 21)
        Me.cmb_club.TabIndex = 7
        Me.cmb_club.ValueMember = "CodClub"
        '
        'ClubesBindingSource4
        '
        Me.ClubesBindingSource4.DataMember = "Clubes"
        Me.ClubesBindingSource4.DataSource = Me.TPIPAVIDataSet
        '
        'ClubesBindingSource3
        '
        Me.ClubesBindingSource3.DataMember = "Clubes"
        Me.ClubesBindingSource3.DataSource = Me.TPIPAVIDataSet
        '
        'ClubesBindingSource2
        '
        Me.ClubesBindingSource2.DataMember = "Clubes"
        Me.ClubesBindingSource2.DataSource = Me.TPIPAVIDataSet
        '
        'ClubesBindingSource1
        '
        Me.ClubesBindingSource1.DataMember = "Clubes"
        Me.ClubesBindingSource1.DataSource = Me.TPIPAVIDataSet
        '
        'cmb_profesor
        '
        Me.cmb_profesor.DataSource = Me.ProfesoresBindingSource6
        Me.cmb_profesor.DisplayMember = "Apellido"
        Me.cmb_profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_profesor.FormattingEnabled = True
        Me.cmb_profesor.Location = New System.Drawing.Point(438, 138)
        Me.cmb_profesor.Name = "cmb_profesor"
        Me.cmb_profesor.Size = New System.Drawing.Size(161, 21)
        Me.cmb_profesor.TabIndex = 8
        Me.cmb_profesor.ValueMember = "CodProf"
        '
        'ProfesoresBindingSource3
        '
        Me.ProfesoresBindingSource3.DataMember = "Profesores"
        Me.ProfesoresBindingSource3.DataSource = Me.TPIPAVIDataSet
        '
        'ProfesoresBindingSource2
        '
        Me.ProfesoresBindingSource2.DataMember = "Profesores"
        Me.ProfesoresBindingSource2.DataSource = Me.TPIPAVIDataSet
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(80, 42)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(233, 20)
        Me.txt_nombres.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(80, 12)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(233, 20)
        Me.txt_apellido.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Apellido: "
        '
        'ClubesBindingSource5
        '
        Me.ClubesBindingSource5.DataMember = "Clubes"
        Me.ClubesBindingSource5.DataSource = Me.TPIPAVIDataSet
        '
        'ClubesBindingSource6
        '
        Me.ClubesBindingSource6.DataMember = "Clubes"
        Me.ClubesBindingSource6.DataSource = Me.TPIPAVIDataSet
        '
        'ProfesoresBindingSource4
        '
        Me.ProfesoresBindingSource4.DataMember = "Profesores"
        Me.ProfesoresBindingSource4.DataSource = Me.TPIPAVIDataSet
        '
        'TiposDocBindingSource2
        '
        Me.TiposDocBindingSource2.DataMember = "TiposDoc"
        Me.TiposDocBindingSource2.DataSource = Me.TPIPAVIDataSet
        '
        'TiposDocBindingSource3
        '
        Me.TiposDocBindingSource3.DataMember = "TiposDoc"
        Me.TiposDocBindingSource3.DataSource = Me.TPIPAVIDataSet
        '
        'ProfesoresBindingSource5
        '
        Me.ProfesoresBindingSource5.DataMember = "Profesores"
        Me.ProfesoresBindingSource5.DataSource = Me.TPIPAVIDataSet
        '
        'ClubesBindingSource7
        '
        Me.ClubesBindingSource7.DataMember = "Clubes"
        Me.ClubesBindingSource7.DataSource = Me.TPIPAVIDataSet
        '
        'ProfesoresBindingSource6
        '
        Me.ProfesoresBindingSource6.DataMember = "Profesores"
        Me.ProfesoresBindingSource6.DataSource = Me.TPIPAVIDataSet
        '
        'frm_ABMnadadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 472)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_club)
        Me.Controls.Add(Me.cmb_profesor)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grd_dgvNadador)
        Me.Controls.Add(Me.msk_nrodoc)
        Me.Controls.Add(Me.txt_nrocalle)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.cmb_tipodoc)
        Me.Controls.Add(Me.cmb_codpostal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_ABMnadadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nadadores"
        CType(Me.CodigosPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_dgvNadador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadaXEspeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_codpostal As System.Windows.Forms.ComboBox
    Friend WithEvents msk_nrodoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grd_dgvNadador As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_nrocalle As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents NadadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter
    Friend WithEvents ProfesoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfesoresTableAdapter
    Friend WithEvents ProfesoresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.CodigosPostTableAdapter
    Friend WithEvents ClubesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter
    Friend WithEvents TiposDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.TiposDocTableAdapter
    Friend WithEvents NadadoresBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents NadaXEspeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadaXEspeTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadaXEspeTableAdapter
    Friend WithEvents NadadoresBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodigosPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource6 As System.Windows.Forms.BindingSource
End Class
