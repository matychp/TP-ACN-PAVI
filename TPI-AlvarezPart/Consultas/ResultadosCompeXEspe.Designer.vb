﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ResultadosCompeXEspe
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
        Me.grd_dgvconsultaComXEspe = New System.Windows.Forms.DataGridView()
        Me.msk_anio = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.EspecialidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.EspecialidadTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        Me.cmd_help = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_ejecutarConsultaPerso = New System.Windows.Forms.Button()
        Me.cmd_ejecutarConsulta = New System.Windows.Forms.Button()
        Me.tt_consultaestandar = New System.Windows.Forms.ToolTip(Me.components)
        Me.tt_consultapersonal = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.grd_dgvconsultaComXEspe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_dgvconsultaComXEspe
        '
        Me.grd_dgvconsultaComXEspe.AllowUserToAddRows = False
        Me.grd_dgvconsultaComXEspe.AllowUserToDeleteRows = False
        Me.grd_dgvconsultaComXEspe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvconsultaComXEspe.Enabled = False
        Me.grd_dgvconsultaComXEspe.Location = New System.Drawing.Point(12, 111)
        Me.grd_dgvconsultaComXEspe.Name = "grd_dgvconsultaComXEspe"
        Me.grd_dgvconsultaComXEspe.ReadOnly = True
        Me.grd_dgvconsultaComXEspe.Size = New System.Drawing.Size(454, 173)
        Me.grd_dgvconsultaComXEspe.TabIndex = 0
        '
        'msk_anio
        '
        Me.msk_anio.BeepOnError = True
        Me.msk_anio.Location = New System.Drawing.Point(62, 15)
        Me.msk_anio.Mask = "9999"
        Me.msk_anio.Name = "msk_anio"
        Me.msk_anio.Size = New System.Drawing.Size(31, 20)
        Me.msk_anio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Año: "
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.DataSource = Me.EspecialidadBindingSource
        Me.cmb_especialidad.DisplayMember = "Descripcion"
        Me.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(198, 15)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_especialidad.TabIndex = 3
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
        'EspecialidadTableAdapter
        '
        Me.EspecialidadTableAdapter.ClearBeforeFill = True
        '
        'cmd_help
        '
        Me.cmd_help.Location = New System.Drawing.Point(419, 299)
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(47, 38)
        Me.cmd_help.TabIndex = 4
        Me.cmd_help.Text = "Help"
        Me.cmd_help.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Especialidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultado de la consulta:"
        '
        'cmd_ejecutarConsultaPerso
        '
        Me.cmd_ejecutarConsultaPerso.Location = New System.Drawing.Point(194, 299)
        Me.cmd_ejecutarConsultaPerso.Name = "cmd_ejecutarConsultaPerso"
        Me.cmd_ejecutarConsultaPerso.Size = New System.Drawing.Size(156, 38)
        Me.cmd_ejecutarConsultaPerso.TabIndex = 5
        Me.cmd_ejecutarConsultaPerso.Text = "Ejecutar Consulta Personalizada"
        Me.cmd_ejecutarConsultaPerso.UseVisualStyleBackColor = True
        '
        'cmd_ejecutarConsulta
        '
        Me.cmd_ejecutarConsulta.Location = New System.Drawing.Point(12, 299)
        Me.cmd_ejecutarConsulta.Name = "cmd_ejecutarConsulta"
        Me.cmd_ejecutarConsulta.Size = New System.Drawing.Size(107, 38)
        Me.cmd_ejecutarConsulta.TabIndex = 5
        Me.cmd_ejecutarConsulta.Text = "Ejecutar Consulta Estándar"
        Me.cmd_ejecutarConsulta.UseVisualStyleBackColor = True
        '
        'frm_ResultadosCompeXEspe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 368)
        Me.Controls.Add(Me.cmd_ejecutarConsulta)
        Me.Controls.Add(Me.cmd_ejecutarConsultaPerso)
        Me.Controls.Add(Me.cmd_help)
        Me.Controls.Add(Me.cmb_especialidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msk_anio)
        Me.Controls.Add(Me.grd_dgvconsultaComXEspe)
        Me.Name = "frm_ResultadosCompeXEspe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Competencia por Especialidad"
        CType(Me.grd_dgvconsultaComXEspe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_dgvconsultaComXEspe As System.Windows.Forms.DataGridView
    Friend WithEvents msk_anio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents EspecialidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspecialidadTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
    Friend WithEvents cmd_help As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_ejecutarConsultaPerso As System.Windows.Forms.Button
    Friend WithEvents cmd_ejecutarConsulta As System.Windows.Forms.Button
    Friend WithEvents tt_consultaestandar As System.Windows.Forms.ToolTip
    Friend WithEvents tt_consultapersonal As System.Windows.Forms.ToolTip
End Class
