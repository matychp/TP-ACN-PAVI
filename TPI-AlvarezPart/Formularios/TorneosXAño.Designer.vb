<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TorneosXAño
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
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.cmb_torneo = New System.Windows.Forms.ComboBox()
        Me.msk_anio = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grd_DGVTorneosxAño = New System.Windows.Forms.DataGridView()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.ClubesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClubesTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter()
        Me.TORNEOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORNEOSTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.TORNEOSTableAdapter()
        CType(Me.grd_DGVTorneosxAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORNEOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_club
        '
        Me.cmb_club.DataSource = Me.ClubesBindingSource
        Me.cmb_club.DisplayMember = "Nombre"
        Me.cmb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(64, 36)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(134, 21)
        Me.cmb_club.TabIndex = 0
        Me.cmb_club.ValueMember = "CodClub"
        '
        'cmb_torneo
        '
        Me.cmb_torneo.DataSource = Me.TORNEOSBindingSource
        Me.cmb_torneo.DisplayMember = "Descrip"
        Me.cmb_torneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_torneo.FormattingEnabled = True
        Me.cmb_torneo.Location = New System.Drawing.Point(77, 6)
        Me.cmb_torneo.Name = "cmb_torneo"
        Me.cmb_torneo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_torneo.TabIndex = 0
        Me.cmb_torneo.ValueMember = "CodTorneo"
        '
        'msk_anio
        '
        Me.msk_anio.Location = New System.Drawing.Point(62, 66)
        Me.msk_anio.Mask = "9999"
        Me.msk_anio.Name = "msk_anio"
        Me.msk_anio.Size = New System.Drawing.Size(33, 20)
        Me.msk_anio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Club:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Torneo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Año:"
        '
        'grd_DGVTorneosxAño
        '
        Me.grd_DGVTorneosxAño.AllowUserToAddRows = False
        Me.grd_DGVTorneosxAño.AllowUserToDeleteRows = False
        Me.grd_DGVTorneosxAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_DGVTorneosxAño.Location = New System.Drawing.Point(12, 92)
        Me.grd_DGVTorneosxAño.Name = "grd_DGVTorneosxAño"
        Me.grd_DGVTorneosxAño.ReadOnly = True
        Me.grd_DGVTorneosxAño.Size = New System.Drawing.Size(318, 176)
        Me.grd_DGVTorneosxAño.TabIndex = 3
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 274)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 4
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(93, 273)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_eliminar.TabIndex = 4
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(174, 273)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 4
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(255, 273)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClubesBindingSource
        '
        Me.ClubesBindingSource.DataMember = "Clubes"
        Me.ClubesBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'ClubesTableAdapter
        '
        Me.ClubesTableAdapter.ClearBeforeFill = True
        '
        'TORNEOSBindingSource
        '
        Me.TORNEOSBindingSource.DataMember = "TORNEOS"
        Me.TORNEOSBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'TORNEOSTableAdapter
        '
        Me.TORNEOSTableAdapter.ClearBeforeFill = True
        '
        'frm_TorneosXAño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 308)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grd_DGVTorneosxAño)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msk_anio)
        Me.Controls.Add(Me.cmb_torneo)
        Me.Controls.Add(Me.cmb_club)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_TorneosXAño"
        Me.Text = "TorneosXAño"
        CType(Me.grd_DGVTorneosxAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORNEOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents msk_anio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grd_DGVTorneosxAño As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_torneo As System.Windows.Forms.ComboBox
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents ClubesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter
    Friend WithEvents TORNEOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TORNEOSTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.TORNEOSTableAdapter
End Class
