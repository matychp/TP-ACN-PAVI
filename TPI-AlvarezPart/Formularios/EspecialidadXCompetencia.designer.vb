<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EspecialidadXCompetencia
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
        Me.txt_especialidad = New System.Windows.Forms.Label()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.grd_DGVTorneosxAño = New System.Windows.Forms.DataGridView()
        Me.txt_torneo = New System.Windows.Forms.Label()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.grd_DGVEspecialidadXCompetencia = New System.Windows.Forms.DataGridView()
        Me.txt_especialdiadXCompetencia = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.Label()
        Me.msk_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.EspecialidadTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_DGVTorneosxAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_DGVEspecialidadXCompetencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_especialidad
        '
        Me.txt_especialidad.AutoSize = True
        Me.txt_especialidad.Location = New System.Drawing.Point(14, 16)
        Me.txt_especialidad.Name = "txt_especialidad"
        Me.txt_especialidad.Size = New System.Drawing.Size(67, 13)
        Me.txt_especialidad.TabIndex = 0
        Me.txt_especialidad.Text = "Especialidad"
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.DataSource = Me.EspecialidadBindingSource
        Me.cmb_especialidad.DisplayMember = "Descripcion"
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(87, 13)
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
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd_DGVTorneosxAño
        '
        Me.grd_DGVTorneosxAño.AllowUserToAddRows = False
        Me.grd_DGVTorneosxAño.AllowUserToDeleteRows = False
        Me.grd_DGVTorneosxAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_DGVTorneosxAño.Location = New System.Drawing.Point(87, 41)
        Me.grd_DGVTorneosxAño.Name = "grd_DGVTorneosxAño"
        Me.grd_DGVTorneosxAño.ReadOnly = True
        Me.grd_DGVTorneosxAño.Size = New System.Drawing.Size(193, 107)
        Me.grd_DGVTorneosxAño.TabIndex = 2
        '
        'txt_torneo
        '
        Me.txt_torneo.AutoSize = True
        Me.txt_torneo.Location = New System.Drawing.Point(14, 41)
        Me.txt_torneo.Name = "txt_torneo"
        Me.txt_torneo.Size = New System.Drawing.Size(69, 13)
        Me.txt_torneo.TabIndex = 3
        Me.txt_torneo.Text = "Competencia"
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(17, 381)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 4
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(98, 381)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_eliminar.TabIndex = 4
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(351, 381)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 4
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(432, 381)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'grd_DGVEspecialidadXCompetencia
        '
        Me.grd_DGVEspecialidadXCompetencia.AllowUserToAddRows = False
        Me.grd_DGVEspecialidadXCompetencia.AllowUserToDeleteRows = False
        Me.grd_DGVEspecialidadXCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_DGVEspecialidadXCompetencia.Location = New System.Drawing.Point(17, 214)
        Me.grd_DGVEspecialidadXCompetencia.Name = "grd_DGVEspecialidadXCompetencia"
        Me.grd_DGVEspecialidadXCompetencia.ReadOnly = True
        Me.grd_DGVEspecialidadXCompetencia.Size = New System.Drawing.Size(490, 150)
        Me.grd_DGVEspecialidadXCompetencia.TabIndex = 2
        '
        'txt_especialdiadXCompetencia
        '
        Me.txt_especialdiadXCompetencia.AutoSize = True
        Me.txt_especialdiadXCompetencia.Location = New System.Drawing.Point(17, 180)
        Me.txt_especialdiadXCompetencia.Name = "txt_especialdiadXCompetencia"
        Me.txt_especialdiadXCompetencia.Size = New System.Drawing.Size(150, 13)
        Me.txt_especialdiadXCompetencia.TabIndex = 5
        Me.txt_especialdiadXCompetencia.Text = "Especialidad por Competencia"
        '
        'txt_fecha
        '
        Me.txt_fecha.AutoSize = True
        Me.txt_fecha.Location = New System.Drawing.Point(316, 40)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(37, 13)
        Me.txt_fecha.TabIndex = 6
        Me.txt_fecha.Text = "Fecha"
        '
        'msk_fecha
        '
        Me.msk_fecha.Location = New System.Drawing.Point(359, 37)
        Me.msk_fecha.Mask = "00/00/0000"
        Me.msk_fecha.Name = "msk_fecha"
        Me.msk_fecha.Size = New System.Drawing.Size(67, 20)
        Me.msk_fecha.TabIndex = 7
        Me.msk_fecha.ValidatingType = GetType(Date)
        '
        'EspecialidadTableAdapter
        '
        Me.EspecialidadTableAdapter.ClearBeforeFill = True
        '
        'frm_EspecialidadXCompetencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 420)
        Me.Controls.Add(Me.msk_fecha)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_especialdiadXCompetencia)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.txt_torneo)
        Me.Controls.Add(Me.grd_DGVEspecialidadXCompetencia)
        Me.Controls.Add(Me.grd_DGVTorneosxAño)
        Me.Controls.Add(Me.cmb_especialidad)
        Me.Controls.Add(Me.txt_especialidad)
        Me.Name = "frm_EspecialidadXCompetencia"
        Me.Text = "EspecialidadXCompetencia"
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_DGVTorneosxAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_DGVEspecialidadXCompetencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_especialidad As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents grd_DGVTorneosxAño As System.Windows.Forms.DataGridView
    Friend WithEvents txt_torneo As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents grd_DGVEspecialidadXCompetencia As System.Windows.Forms.DataGridView
    Friend WithEvents txt_especialdiadXCompetencia As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.Label
    Friend WithEvents msk_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
End Class
