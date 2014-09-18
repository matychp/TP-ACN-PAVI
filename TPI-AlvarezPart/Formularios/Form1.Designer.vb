<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ABMEspecialidad
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
        Me.EspecialidadTableAdapter1 = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        Me.Lbl_Especialidad = New System.Windows.Forms.Label()
        Me.lbl_TiempoRecord = New System.Windows.Forms.Label()
        Me.msk_TiempoRecord = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NombreEspecialidad = New System.Windows.Forms.TextBox()
        Me.grd_ListaEspecialidades = New System.Windows.Forms.DataGridView()
        Me.CodEspeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoRecordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_ListaEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EspecialidadTableAdapter1
        '
        Me.EspecialidadTableAdapter1.ClearBeforeFill = True
        '
        'Lbl_Especialidad
        '
        Me.Lbl_Especialidad.AutoSize = True
        Me.Lbl_Especialidad.Location = New System.Drawing.Point(8, 12)
        Me.Lbl_Especialidad.Name = "Lbl_Especialidad"
        Me.Lbl_Especialidad.Size = New System.Drawing.Size(110, 13)
        Me.Lbl_Especialidad.TabIndex = 9
        Me.Lbl_Especialidad.Text = "Nombre Especialidad:"
        '
        'lbl_TiempoRecord
        '
        Me.lbl_TiempoRecord.AutoSize = True
        Me.lbl_TiempoRecord.Location = New System.Drawing.Point(35, 67)
        Me.lbl_TiempoRecord.Name = "lbl_TiempoRecord"
        Me.lbl_TiempoRecord.Size = New System.Drawing.Size(83, 13)
        Me.lbl_TiempoRecord.TabIndex = 10
        Me.lbl_TiempoRecord.Text = "Tiempo Record:"
        '
        'msk_TiempoRecord
        '
        Me.msk_TiempoRecord.Location = New System.Drawing.Point(125, 64)
        Me.msk_TiempoRecord.Mask = "00:00,00"
        Me.msk_TiempoRecord.Name = "msk_TiempoRecord"
        Me.msk_TiempoRecord.Size = New System.Drawing.Size(48, 20)
        Me.msk_TiempoRecord.TabIndex = 2
        '
        'txt_NombreEspecialidad
        '
        Me.txt_NombreEspecialidad.Location = New System.Drawing.Point(125, 9)
        Me.txt_NombreEspecialidad.Name = "txt_NombreEspecialidad"
        Me.txt_NombreEspecialidad.Size = New System.Drawing.Size(159, 20)
        Me.txt_NombreEspecialidad.TabIndex = 1
        '
        'grd_ListaEspecialidades
        '
        Me.grd_ListaEspecialidades.AllowUserToAddRows = False
        Me.grd_ListaEspecialidades.AllowUserToDeleteRows = False
        Me.grd_ListaEspecialidades.AutoGenerateColumns = False
        Me.grd_ListaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_ListaEspecialidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodEspeDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.TiempoRecordDataGridViewTextBoxColumn})
        Me.grd_ListaEspecialidades.DataSource = Me.EspecialidadBindingSource1
        Me.grd_ListaEspecialidades.Location = New System.Drawing.Point(15, 90)
        Me.grd_ListaEspecialidades.Name = "grd_ListaEspecialidades"
        Me.grd_ListaEspecialidades.ReadOnly = True
        Me.grd_ListaEspecialidades.Size = New System.Drawing.Size(397, 180)
        Me.grd_ListaEspecialidades.TabIndex = 3
        '
        'CodEspeDataGridViewTextBoxColumn
        '
        Me.CodEspeDataGridViewTextBoxColumn.DataPropertyName = "CodEspe"
        Me.CodEspeDataGridViewTextBoxColumn.HeaderText = "CodEspe"
        Me.CodEspeDataGridViewTextBoxColumn.Name = "CodEspeDataGridViewTextBoxColumn"
        Me.CodEspeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TiempoRecordDataGridViewTextBoxColumn
        '
        Me.TiempoRecordDataGridViewTextBoxColumn.DataPropertyName = "TiempoRecord"
        Me.TiempoRecordDataGridViewTextBoxColumn.HeaderText = "TiempoRecord"
        Me.TiempoRecordDataGridViewTextBoxColumn.Name = "TiempoRecordDataGridViewTextBoxColumn"
        Me.TiempoRecordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EspecialidadBindingSource1
        '
        Me.EspecialidadBindingSource1.DataMember = "Especialidad"
        Me.EspecialidadBindingSource1.DataSource = Me.TPIPAVIDataSet
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EspecialidadBindingSource
        '
        Me.EspecialidadBindingSource.DataMember = "Especialidad"
        Me.EspecialidadBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(104, 286)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_eliminar.TabIndex = 5
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(15, 286)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(83, 31)
        Me.cmd_nuevo.TabIndex = 4
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(329, 286)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_cancelar.TabIndex = 7
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(240, 286)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_guardar.TabIndex = 6
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TPI_PAVI.My.Resources.Resources.ico_n_natacion
        Me.PictureBox1.Location = New System.Drawing.Point(337, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Form_ABMEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 325)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.grd_ListaEspecialidades)
        Me.Controls.Add(Me.txt_NombreEspecialidad)
        Me.Controls.Add(Me.msk_TiempoRecord)
        Me.Controls.Add(Me.lbl_TiempoRecord)
        Me.Controls.Add(Me.Lbl_Especialidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_ABMEspecialidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Especialidades"
        CType(Me.grd_ListaEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EspecialidadTableAdapter1 As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
    Friend WithEvents Lbl_Especialidad As System.Windows.Forms.Label
    Friend WithEvents lbl_TiempoRecord As System.Windows.Forms.Label
    Friend WithEvents msk_TiempoRecord As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_NombreEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents grd_ListaEspecialidades As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents CodEspeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoRecordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
