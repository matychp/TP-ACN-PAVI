<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_NadadoresPorProfesores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ds_NadadoresPorProfesores = New TPI_PAVI.ds_NadadoresPorProfesores()
        Me.dt_NadadoresPorProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ds_NadadoresPorProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_NadadoresPorProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.dt_NadadoresPorProfesoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI_PAVI.estadisticaNadadoresPorProfesores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(817, 529)
        Me.ReportViewer1.TabIndex = 0
        '
        'ds_NadadoresPorProfesores
        '
        Me.ds_NadadoresPorProfesores.DataSetName = "ds_NadadoresPorProfesores"
        Me.ds_NadadoresPorProfesores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dt_NadadoresPorProfesoresBindingSource
        '
        Me.dt_NadadoresPorProfesoresBindingSource.DataMember = "dt_NadadoresPorProfesores"
        Me.dt_NadadoresPorProfesoresBindingSource.DataSource = Me.ds_NadadoresPorProfesores
        '
        'form_NadadoresPorProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "form_NadadoresPorProfesores"
        Me.Text = "form_NadadoresPorProfesores"
        CType(Me.ds_NadadoresPorProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_NadadoresPorProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dt_NadadoresPorProfesoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ds_NadadoresPorProfesores As TPI_PAVI.ds_NadadoresPorProfesores
End Class
