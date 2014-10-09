<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NadadoresXEspecialidad
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
        Me.cmb_nadador = New System.Windows.Forms.ComboBox()
        Me.NadadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grd_DGVNadxEspe = New System.Windows.Forms.DataGridView()
        Me.NadaXEspeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadaXEspeTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadaXEspeTableAdapter()
        Me.TPIPAVIDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NadadoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.grd_dgvnxe = New System.Windows.Forms.DataGridView()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_DGVNadxEspe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadaXEspeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_dgvnxe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_nadador
        '
        Me.cmb_nadador.DataSource = Me.NadadoresBindingSource
        Me.cmb_nadador.DisplayMember = "Apellido"
        Me.cmb_nadador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nadador.FormattingEnabled = True
        Me.cmb_nadador.Location = New System.Drawing.Point(116, 12)
        Me.cmb_nadador.Name = "cmb_nadador"
        Me.cmb_nadador.Size = New System.Drawing.Size(121, 21)
        Me.cmb_nadador.TabIndex = 0
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
        'cmb_especialidad
        '
        Me.cmb_especialidad.DataSource = Me.EspecialidadBindingSource
        Me.cmb_especialidad.DisplayMember = "Descripcion"
        Me.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(116, 53)
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
        'grd_DGVNadxEspe
        '
        Me.grd_DGVNadxEspe.AllowUserToAddRows = False
        Me.grd_DGVNadxEspe.AllowUserToDeleteRows = False
        Me.grd_DGVNadxEspe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_DGVNadxEspe.Location = New System.Drawing.Point(13, 108)
        Me.grd_DGVNadxEspe.Name = "grd_DGVNadxEspe"
        Me.grd_DGVNadxEspe.ReadOnly = True
        Me.grd_DGVNadxEspe.Size = New System.Drawing.Size(358, 196)
        Me.grd_DGVNadxEspe.TabIndex = 2
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
        'TPIPAVIDataSetBindingSource
        '
        Me.TPIPAVIDataSetBindingSource.DataSource = Me.TPIPAVIDataSet
        Me.TPIPAVIDataSetBindingSource.Position = 0
        '
        'EspecialidadTableAdapter
        '
        Me.EspecialidadTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Especialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nadador"
        '
        'NadadoresTableAdapter
        '
        Me.NadadoresTableAdapter.ClearBeforeFill = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(13, 318)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 3
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(94, 318)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_eliminar.TabIndex = 4
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(215, 318)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 5
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(296, 317)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 6
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'grd_dgvnxe
        '
        Me.grd_dgvnxe.AllowUserToAddRows = False
        Me.grd_dgvnxe.AllowUserToDeleteRows = False
        Me.grd_dgvnxe.AutoGenerateColumns = False
        Me.grd_dgvnxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvnxe.DataSource = Me.NadaXEspeBindingSource
        Me.grd_dgvnxe.Location = New System.Drawing.Point(13, 108)
        Me.grd_dgvnxe.Name = "grd_dgvnxe"
        Me.grd_dgvnxe.ReadOnly = True
        Me.grd_dgvnxe.Size = New System.Drawing.Size(358, 196)
        Me.grd_dgvnxe.TabIndex = 1
        '
        'frm_NadadoresXEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 353)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_DGVNadxEspe)
        Me.Controls.Add(Me.cmb_especialidad)
        Me.Controls.Add(Me.cmb_nadador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_NadadoresXEspecialidad"
        Me.Text = "NadadoresXEspecialidad"
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_DGVNadxEspe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadaXEspeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_dgvnxe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_nadador As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents grd_DGVNadxEspe As System.Windows.Forms.DataGridView
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents NadaXEspeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadaXEspeTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadaXEspeTableAdapter
    Friend WithEvents TPIPAVIDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NadadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents grd_dgvnxe As System.Windows.Forms.DataGridView
End Class
