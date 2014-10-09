<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Inscriptos
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
        Me.grd_dgvInscriptos = New System.Windows.Forms.DataGridView()
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.TorneosXAñoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TorneosXAñoTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.TorneosXAñoTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_DGVTorneosxAño = New System.Windows.Forms.DataGridView()
        Me.grd_DGVNadxEspe = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.msk_tiempo = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.msk_posicion = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        CType(Me.grd_dgvInscriptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorneosXAñoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_DGVTorneosxAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_DGVNadxEspe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_dgvInscriptos
        '
        Me.grd_dgvInscriptos.AllowUserToAddRows = False
        Me.grd_dgvInscriptos.AllowUserToDeleteRows = False
        Me.grd_dgvInscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvInscriptos.Location = New System.Drawing.Point(16, 241)
        Me.grd_dgvInscriptos.Name = "grd_dgvInscriptos"
        Me.grd_dgvInscriptos.ReadOnly = True
        Me.grd_dgvInscriptos.Size = New System.Drawing.Size(703, 182)
        Me.grd_dgvInscriptos.TabIndex = 0
        '
        'TPIPAVIDataSet
        '
        Me.TPIPAVIDataSet.DataSetName = "TPIPAVIDataSet"
        Me.TPIPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TorneosXAñoBindingSource
        '
        Me.TorneosXAñoBindingSource.DataMember = "TorneosXAño"
        Me.TorneosXAñoBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'TorneosXAñoTableAdapter
        '
        Me.TorneosXAñoTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Torneo X Año"
        '
        'grd_DGVTorneosxAño
        '
        Me.grd_DGVTorneosxAño.AllowUserToAddRows = False
        Me.grd_DGVTorneosxAño.AllowUserToDeleteRows = False
        Me.grd_DGVTorneosxAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_DGVTorneosxAño.Location = New System.Drawing.Point(54, 25)
        Me.grd_DGVTorneosxAño.Name = "grd_DGVTorneosxAño"
        Me.grd_DGVTorneosxAño.ReadOnly = True
        Me.grd_DGVTorneosxAño.Size = New System.Drawing.Size(240, 150)
        Me.grd_DGVTorneosxAño.TabIndex = 3
        '
        'grd_DGVNadxEspe
        '
        Me.grd_DGVNadxEspe.AllowUserToAddRows = False
        Me.grd_DGVNadxEspe.AllowUserToDeleteRows = False
        Me.grd_DGVNadxEspe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_DGVNadxEspe.Location = New System.Drawing.Point(472, 25)
        Me.grd_DGVNadxEspe.Name = "grd_DGVNadxEspe"
        Me.grd_DGVNadxEspe.ReadOnly = True
        Me.grd_DGVNadxEspe.Size = New System.Drawing.Size(240, 150)
        Me.grd_DGVNadxEspe.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(398, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nadadores X Especialidad"
        '
        'msk_tiempo
        '
        Me.msk_tiempo.Location = New System.Drawing.Point(475, 190)
        Me.msk_tiempo.Mask = "99:99.99"
        Me.msk_tiempo.Name = "msk_tiempo"
        Me.msk_tiempo.Size = New System.Drawing.Size(50, 20)
        Me.msk_tiempo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tiempo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Posición"
        '
        'msk_posicion
        '
        Me.msk_posicion.Location = New System.Drawing.Point(105, 186)
        Me.msk_posicion.Mask = "999"
        Me.msk_posicion.Name = "msk_posicion"
        Me.msk_posicion.Size = New System.Drawing.Size(26, 20)
        Me.msk_posicion.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Grilla de Inscriptos"
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(16, 432)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 9
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(105, 432)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_eliminar.TabIndex = 9
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(556, 432)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 9
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(637, 432)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 9
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'frm_Inscriptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 467)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.msk_posicion)
        Me.Controls.Add(Me.msk_tiempo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grd_DGVNadxEspe)
        Me.Controls.Add(Me.grd_DGVTorneosxAño)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_dgvInscriptos)
        Me.Name = "frm_Inscriptos"
        Me.Text = "Inscriptos"
        CType(Me.grd_dgvInscriptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorneosXAñoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_DGVTorneosxAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_DGVNadxEspe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_dgvInscriptos As System.Windows.Forms.DataGridView
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents TorneosXAñoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TorneosXAñoTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.TorneosXAñoTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grd_DGVTorneosxAño As System.Windows.Forms.DataGridView
    Friend WithEvents grd_DGVNadxEspe As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents msk_tiempo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents msk_posicion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
End Class
