﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListadoEspecialidades
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
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EspecialidadTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EspecialidadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI_PAVI.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(465, 356)
        Me.ReportViewer1.TabIndex = 0
        '
        'EspecialidadTableAdapter
        '
        Me.EspecialidadTableAdapter.ClearBeforeFill = True
        '
        'frm_ListadoEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 381)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_ListadoEspecialidades"
        Me.Text = "ListadoEspecialidades"
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents EspecialidadTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
End Class
