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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.NadaXEspeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadaXEspeTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadaXEspeTableAdapter()
        Me.CodNadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodEspeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPIPAVIDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NadadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NadadoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadaXEspeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.NadadoresBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(116, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "CodNad"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.EspecialidadBindingSource
        Me.ComboBox2.DisplayMember = "Descripcion"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(116, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 0
        Me.ComboBox2.ValueMember = "CodEspe"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodNadDataGridViewTextBoxColumn, Me.CodEspeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NadaXEspeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(358, 196)
        Me.DataGridView1.TabIndex = 1
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CodNadDataGridViewTextBoxColumn
        '
        Me.CodNadDataGridViewTextBoxColumn.DataPropertyName = "CodNad"
        Me.CodNadDataGridViewTextBoxColumn.HeaderText = "CodNad"
        Me.CodNadDataGridViewTextBoxColumn.Name = "CodNadDataGridViewTextBoxColumn"
        Me.CodNadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodEspeDataGridViewTextBoxColumn
        '
        Me.CodEspeDataGridViewTextBoxColumn.DataPropertyName = "CodEspe"
        Me.CodEspeDataGridViewTextBoxColumn.HeaderText = "CodEspe"
        Me.CodEspeDataGridViewTextBoxColumn.Name = "CodEspeDataGridViewTextBoxColumn"
        Me.CodEspeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TPIPAVIDataSetBindingSource
        '
        Me.TPIPAVIDataSetBindingSource.DataSource = Me.TPIPAVIDataSet
        Me.TPIPAVIDataSetBindingSource.Position = 0
        '
        'EspecialidadBindingSource
        '
        Me.EspecialidadBindingSource.DataMember = "Especialidad"
        Me.EspecialidadBindingSource.DataSource = Me.TPIPAVIDataSet
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
        'NadadoresBindingSource
        '
        Me.NadadoresBindingSource.DataMember = "Nadadores"
        Me.NadadoresBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'NadadoresTableAdapter
        '
        Me.NadadoresTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(195, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(296, 310)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frm_NadadoresXEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 353)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frm_NadadoresXEspecialidad"
        Me.Text = "NadadoresXEspecialidad"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadaXEspeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents NadaXEspeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadaXEspeTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadaXEspeTableAdapter
    Friend WithEvents TPIPAVIDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodNadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodEspeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NadadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NadadoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
