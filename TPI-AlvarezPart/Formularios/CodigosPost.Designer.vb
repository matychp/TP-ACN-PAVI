<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ABMCodigosPost
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
        Me.dgv_CodPos = New System.Windows.Forms.DataGridView()
        Me.CodposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigosPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.CodigosPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.msk_CodPos = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_numCodPos = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.CodigosPostTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.CodigosPostTableAdapter()
        Me.CodigosPostBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv_CodPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosPostBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_CodPos
        '
        Me.dgv_CodPos.AllowUserToAddRows = False
        Me.dgv_CodPos.AllowUserToDeleteRows = False
        Me.dgv_CodPos.AutoGenerateColumns = False
        Me.dgv_CodPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CodPos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodposDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgv_CodPos.DataSource = Me.CodigosPostBindingSource2
        Me.dgv_CodPos.Location = New System.Drawing.Point(12, 38)
        Me.dgv_CodPos.Name = "dgv_CodPos"
        Me.dgv_CodPos.ReadOnly = True
        Me.dgv_CodPos.Size = New System.Drawing.Size(404, 222)
        Me.dgv_CodPos.TabIndex = 5
        '
        'CodposDataGridViewTextBoxColumn
        '
        Me.CodposDataGridViewTextBoxColumn.DataPropertyName = "Codpos"
        Me.CodposDataGridViewTextBoxColumn.HeaderText = "Codpos"
        Me.CodposDataGridViewTextBoxColumn.Name = "CodposDataGridViewTextBoxColumn"
        Me.CodposDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
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
        'msk_CodPos
        '
        Me.msk_CodPos.Location = New System.Drawing.Point(90, 12)
        Me.msk_CodPos.Mask = "9999"
        Me.msk_CodPos.Name = "msk_CodPos"
        Me.msk_CodPos.Size = New System.Drawing.Size(32, 20)
        Me.msk_CodPos.TabIndex = 0
        '
        'lbl_numCodPos
        '
        Me.lbl_numCodPos.AutoSize = True
        Me.lbl_numCodPos.Location = New System.Drawing.Point(9, 15)
        Me.lbl_numCodPos.Name = "lbl_numCodPos"
        Me.lbl_numCodPos.Size = New System.Drawing.Size(75, 13)
        Me.lbl_numCodPos.TabIndex = 27
        Me.lbl_numCodPos.Text = "Codigo Postal:"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(333, 266)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(244, 266)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_guardar.TabIndex = 3
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 266)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(83, 31)
        Me.cmd_nuevo.TabIndex = 1
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(101, 266)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_eliminar.TabIndex = 2
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'CodigosPostTableAdapter
        '
        Me.CodigosPostTableAdapter.ClearBeforeFill = True
        '
        'CodigosPostBindingSource2
        '
        Me.CodigosPostBindingSource2.DataMember = "CodigosPost"
        Me.CodigosPostBindingSource2.DataSource = Me.TPIPAVIDataSet
        '
        'Form_ABMCodigosPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 309)
        Me.Controls.Add(Me.dgv_CodPos)
        Me.Controls.Add(Me.msk_CodPos)
        Me.Controls.Add(Me.lbl_numCodPos)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_ABMCodigosPost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Codigos Postales"
        CType(Me.dgv_CodPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosPostBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_CodPos As System.Windows.Forms.DataGridView
    Friend WithEvents msk_CodPos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_numCodPos As System.Windows.Forms.Label
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents CodigosPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.CodigosPostTableAdapter
    Friend WithEvents CodposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigosPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CodigosPostBindingSource2 As System.Windows.Forms.BindingSource
End Class
