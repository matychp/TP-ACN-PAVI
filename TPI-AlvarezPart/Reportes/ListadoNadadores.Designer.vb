<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListadoNadadores
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
        Me.NadadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NadadoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter()
        Me._cmd_calcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._txt_inicial = New System.Windows.Forms.MaskedTextBox()
        Me._txt_final = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_todos = New System.Windows.Forms.Button()
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NadadoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI_PAVI.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(578, 319)
        Me.ReportViewer1.TabIndex = 4
        '
        'NadadoresTableAdapter
        '
        Me.NadadoresTableAdapter.ClearBeforeFill = True
        '
        '_cmd_calcular
        '
        Me._cmd_calcular.Location = New System.Drawing.Point(254, 343)
        Me._cmd_calcular.Name = "_cmd_calcular"
        Me._cmd_calcular.Size = New System.Drawing.Size(75, 23)
        Me._cmd_calcular.TabIndex = 2
        Me._cmd_calcular.Text = "Calcular"
        Me._cmd_calcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Inicial"
        '
        '_txt_inicial
        '
        Me._txt_inicial.Location = New System.Drawing.Point(54, 344)
        Me._txt_inicial.Mask = "9999"
        Me._txt_inicial.Name = "_txt_inicial"
        Me._txt_inicial.Size = New System.Drawing.Size(31, 20)
        Me._txt_inicial.TabIndex = 0
        '
        '_txt_final
        '
        Me._txt_final.Location = New System.Drawing.Point(165, 345)
        Me._txt_final.Mask = "9999"
        Me._txt_final.Name = "_txt_final"
        Me._txt_final.Size = New System.Drawing.Size(31, 20)
        Me._txt_final.TabIndex = 1
        '
        'cmd_todos
        '
        Me.cmd_todos.Location = New System.Drawing.Point(515, 343)
        Me.cmd_todos.Name = "cmd_todos"
        Me.cmd_todos.Size = New System.Drawing.Size(75, 23)
        Me.cmd_todos.TabIndex = 3
        Me.cmd_todos.Text = "Ver Todos"
        Me.cmd_todos.UseVisualStyleBackColor = True
        '
        'frm_ListadoNadadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 387)
        Me.Controls.Add(Me.cmd_todos)
        Me.Controls.Add(Me._txt_final)
        Me.Controls.Add(Me._txt_inicial)
        Me.Controls.Add(Me._cmd_calcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_ListadoNadadores"
        Me.Text = "ListadoNadadores"
        CType(Me.NadadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NadadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents NadadoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.NadadoresTableAdapter
    Friend WithEvents _cmd_calcular As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents _txt_inicial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents _txt_final As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_todos As System.Windows.Forms.Button
End Class
