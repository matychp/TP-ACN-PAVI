<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ABMProfesor
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
        Me.lbl_numeroCalleProfesor = New System.Windows.Forms.Label()
        Me.lbl_calleProfesor = New System.Windows.Forms.Label()
        Me.lbl_codPostalProfesor = New System.Windows.Forms.Label()
        Me.cmb_codpostal = New System.Windows.Forms.ComboBox()
        Me.CodigosPostBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet1 = New TPI_PAVI.TPIPAVIDataSet()
        Me.CodigosPostBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigosPostBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigosPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigosPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_nrocalle = New System.Windows.Forms.TextBox()
        Me.grd_dgvProfesor = New System.Windows.Forms.DataGridView()
        Me.ProfesoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msk_nrodoc = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_tipodoc = New System.Windows.Forms.ComboBox()
        Me.TiposDocBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lbl_domicilio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TPIPAVIDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfesoresTableAdapter()
        Me.TiposDocTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.TiposDocTableAdapter()
        Me.CodigosPostTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.CodigosPostTableAdapter()
        Me.ProfesoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_nombresProfesor = New System.Windows.Forms.Label()
        Me.lbl_apellidoProfesor = New System.Windows.Forms.Label()
        CType(Me.CodigosPostBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_dgvProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_numeroCalleProfesor
        '
        Me.lbl_numeroCalleProfesor.AutoSize = True
        Me.lbl_numeroCalleProfesor.Location = New System.Drawing.Point(451, 55)
        Me.lbl_numeroCalleProfesor.Name = "lbl_numeroCalleProfesor"
        Me.lbl_numeroCalleProfesor.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numeroCalleProfesor.TabIndex = 2
        Me.lbl_numeroCalleProfesor.Text = "Numero:"
        '
        'lbl_calleProfesor
        '
        Me.lbl_calleProfesor.AutoSize = True
        Me.lbl_calleProfesor.Location = New System.Drawing.Point(451, 29)
        Me.lbl_calleProfesor.Name = "lbl_calleProfesor"
        Me.lbl_calleProfesor.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calleProfesor.TabIndex = 2
        Me.lbl_calleProfesor.Text = "Calle:"
        '
        'lbl_codPostalProfesor
        '
        Me.lbl_codPostalProfesor.AutoSize = True
        Me.lbl_codPostalProfesor.Location = New System.Drawing.Point(451, 81)
        Me.lbl_codPostalProfesor.Name = "lbl_codPostalProfesor"
        Me.lbl_codPostalProfesor.Size = New System.Drawing.Size(75, 13)
        Me.lbl_codPostalProfesor.TabIndex = 3
        Me.lbl_codPostalProfesor.Text = "Codigo Postal:"
        '
        'cmb_codpostal
        '
        Me.cmb_codpostal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CodigosPostBindingSource4, "Codpos", True))
        Me.cmb_codpostal.DataSource = Me.CodigosPostBindingSource3
        Me.cmb_codpostal.DisplayMember = "Nombre"
        Me.cmb_codpostal.FormattingEnabled = True
        Me.cmb_codpostal.Location = New System.Drawing.Point(532, 78)
        Me.cmb_codpostal.Name = "cmb_codpostal"
        Me.cmb_codpostal.Size = New System.Drawing.Size(85, 21)
        Me.cmb_codpostal.TabIndex = 6
        Me.cmb_codpostal.ValueMember = "Codpos"
        '
        'CodigosPostBindingSource4
        '
        Me.CodigosPostBindingSource4.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource4.DataSource = Me.TPIPAVIDataSet1
        '
        'TPIPAVIDataSet1
        '
        Me.TPIPAVIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigosPostBindingSource3
        '
        Me.CodigosPostBindingSource3.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource3.DataSource = Me.TPIPAVIDataSet1
        '
        'CodigosPostBindingSource2
        '
        Me.CodigosPostBindingSource2.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource2.DataSource = Me.TPIPAVIDataSet1
        '
        'CodigosPostBindingSource1
        '
        Me.CodigosPostBindingSource1.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource1.DataSource = Me.TPIPAVIDataSet1
        '
        'CodigosPostBindingSource
        '
        Me.CodigosPostBindingSource.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource.DataSource = Me.TPIPAVIDataSet1
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(490, 26)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(127, 20)
        Me.txt_calle.TabIndex = 4
        '
        'txt_nrocalle
        '
        Me.txt_nrocalle.Location = New System.Drawing.Point(504, 52)
        Me.txt_nrocalle.Name = "txt_nrocalle"
        Me.txt_nrocalle.Size = New System.Drawing.Size(113, 20)
        Me.txt_nrocalle.TabIndex = 5
        '
        'grd_dgvProfesor
        '
        Me.grd_dgvProfesor.AllowUserToAddRows = False
        Me.grd_dgvProfesor.AllowUserToDeleteRows = False
        Me.grd_dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvProfesor.Location = New System.Drawing.Point(22, 133)
        Me.grd_dgvProfesor.Name = "grd_dgvProfesor"
        Me.grd_dgvProfesor.ReadOnly = True
        Me.grd_dgvProfesor.Size = New System.Drawing.Size(745, 286)
        Me.grd_dgvProfesor.TabIndex = 11
        '
        'ProfesoresBindingSource2
        '
        Me.ProfesoresBindingSource2.DataMember = "Profesores"
        Me.ProfesoresBindingSource2.DataSource = Me.TPIPAVIDataSet1
        '
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "Profesores"
        Me.ProfesoresBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(22, 425)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(83, 31)
        Me.cmd_nuevo.TabIndex = 7
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(576, 425)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_guardar.TabIndex = 9
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(681, 425)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_cancelar.TabIndex = 10
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(126, 425)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_eliminar.TabIndex = 8
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero:"
        '
        'msk_nrodoc
        '
        Me.msk_nrodoc.Location = New System.Drawing.Point(251, 90)
        Me.msk_nrodoc.Mask = "99999999"
        Me.msk_nrodoc.Name = "msk_nrodoc"
        Me.msk_nrodoc.Size = New System.Drawing.Size(56, 20)
        Me.msk_nrodoc.TabIndex = 3
        '
        'cmb_tipodoc
        '
        Me.cmb_tipodoc.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TiposDocBindingSource5, "TipoDoc", True))
        Me.cmb_tipodoc.DataSource = Me.TiposDocBindingSource4
        Me.cmb_tipodoc.DisplayMember = "Nombre"
        Me.cmb_tipodoc.FormattingEnabled = True
        Me.cmb_tipodoc.Location = New System.Drawing.Point(123, 90)
        Me.cmb_tipodoc.Name = "cmb_tipodoc"
        Me.cmb_tipodoc.Size = New System.Drawing.Size(50, 21)
        Me.cmb_tipodoc.TabIndex = 2
        Me.cmb_tipodoc.ValueMember = "TipoDoc"
        '
        'TiposDocBindingSource5
        '
        Me.TiposDocBindingSource5.DataMember = "TiposDoc"
        Me.TiposDocBindingSource5.DataSource = Me.TPIPAVIDataSet1
        '
        'TiposDocBindingSource4
        '
        Me.TiposDocBindingSource4.DataMember = "TiposDoc"
        Me.TiposDocBindingSource4.DataSource = Me.TPIPAVIDataSet1
        '
        'TiposDocBindingSource3
        '
        Me.TiposDocBindingSource3.DataMember = "TiposDoc"
        Me.TiposDocBindingSource3.DataSource = Me.TPIPAVIDataSet1
        '
        'TiposDocBindingSource2
        '
        Me.TiposDocBindingSource2.DataMember = "TiposDoc"
        Me.TiposDocBindingSource2.DataSource = Me.TPIPAVIDataSet1
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
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(86, 94)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(31, 13)
        Me.lbl_tipoDoc.TabIndex = 1
        Me.lbl_tipoDoc.Text = "Tipo:"
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(27, 81)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(62, 13)
        Me.lbl_documento.TabIndex = 16
        Me.lbl_documento.Text = "Documento"
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(409, 15)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_domicilio.TabIndex = 16
        Me.lbl_domicilio.Text = "Domicilio"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.TPI_PAVI.My.Resources.Resources.ico_n_natacion
        Me.PictureBox1.Location = New System.Drawing.Point(644, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'TPIPAVIDataSetBindingSource
        '
        Me.TPIPAVIDataSetBindingSource.DataSource = Me.TPIPAVIDataSet
        Me.TPIPAVIDataSetBindingSource.Position = 0
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'TiposDocTableAdapter
        '
        Me.TiposDocTableAdapter.ClearBeforeFill = True
        '
        'CodigosPostTableAdapter
        '
        Me.CodigosPostTableAdapter.ClearBeforeFill = True
        '
        'ProfesoresBindingSource1
        '
        Me.ProfesoresBindingSource1.DataMember = "Profesores"
        Me.ProfesoresBindingSource1.DataSource = Me.TPIPAVIDataSet1
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(80, 41)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(241, 20)
        Me.txt_nombres.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(78, 12)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(243, 20)
        Me.txt_apellido.TabIndex = 0
        '
        'lbl_nombresProfesor
        '
        Me.lbl_nombresProfesor.AutoSize = True
        Me.lbl_nombresProfesor.Location = New System.Drawing.Point(27, 44)
        Me.lbl_nombresProfesor.Name = "lbl_nombresProfesor"
        Me.lbl_nombresProfesor.Size = New System.Drawing.Size(52, 13)
        Me.lbl_nombresProfesor.TabIndex = 19
        Me.lbl_nombresProfesor.Text = "Nombres:"
        '
        'lbl_apellidoProfesor
        '
        Me.lbl_apellidoProfesor.AutoSize = True
        Me.lbl_apellidoProfesor.Location = New System.Drawing.Point(27, 15)
        Me.lbl_apellidoProfesor.Name = "lbl_apellidoProfesor"
        Me.lbl_apellidoProfesor.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellidoProfesor.TabIndex = 18
        Me.lbl_apellidoProfesor.Text = "Apellido:"
        '
        'form_ABMProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 476)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.lbl_nombresProfesor)
        Me.Controls.Add(Me.lbl_apellidoProfesor)
        Me.Controls.Add(Me.lbl_domicilio)
        Me.Controls.Add(Me.lbl_documento)
        Me.Controls.Add(Me.msk_nrodoc)
        Me.Controls.Add(Me.lbl_tipoDoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_calleProfesor)
        Me.Controls.Add(Me.cmb_tipodoc)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.lbl_numeroCalleProfesor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_nrocalle)
        Me.Controls.Add(Me.cmb_codpostal)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.lbl_codPostalProfesor)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grd_dgvProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "form_ABMProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Profesores"
        CType(Me.CodigosPostBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_dgvProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_numeroCalleProfesor As System.Windows.Forms.Label
    Friend WithEvents lbl_calleProfesor As System.Windows.Forms.Label
    Friend WithEvents lbl_codPostalProfesor As System.Windows.Forms.Label
    Friend WithEvents cmb_codpostal As System.Windows.Forms.ComboBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_nrocalle As System.Windows.Forms.TextBox
    Friend WithEvents grd_dgvProfesor As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents msk_nrodoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents TPIPAVIDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents ProfesoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfesoresTableAdapter
    Friend WithEvents TiposDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.TiposDocTableAdapter
    Friend WithEvents TiposDocBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TPIPAVIDataSet1 As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents CodigosPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.CodigosPostTableAdapter
    Friend WithEvents CodigosPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombresProfesor As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoProfesor As System.Windows.Forms.Label
    Friend WithEvents CodigosPostBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocBindingSource4 As System.Windows.Forms.BindingSource

End Class
