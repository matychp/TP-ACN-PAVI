﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EstTorneosAño
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Estadistica1 = New TPI_PAVI.Estadistica1()
        Me.dtEstadisticasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Estadistica1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEstadisticasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.dtEstadisticasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI_PAVI.estadisticaTorAño.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(473, 326)
        Me.ReportViewer1.TabIndex = 0
        '
        'Estadistica1
        '
        Me.Estadistica1.DataSetName = "Estadistica1"
        Me.Estadistica1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtEstadisticasBindingSource
        '
        Me.dtEstadisticasBindingSource.DataMember = "dtEstadisticas"
        Me.dtEstadisticasBindingSource.DataSource = Me.Estadistica1
        '
        'frm_EstTorneosAño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 353)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_EstTorneosAño"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadísticas Torneos en cada Año"
        CType(Me.Estadistica1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEstadisticasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtEstadisticasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Estadistica1 As TPI_PAVI.Estadistica1
End Class
