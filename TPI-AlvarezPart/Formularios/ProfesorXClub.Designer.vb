<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProfesorXClub
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
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_club = New System.Windows.Forms.ComboBox()
        Me.ClubesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSet = New TPI_PAVI.TPIPAVIDataSet()
        Me.ClubesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_profesor = New System.Windows.Forms.ComboBox()
        Me.ProfesoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfXClubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfXClubTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfXClubTableAdapter()
        Me.TableAdapterManager = New TPI_PAVI.TPIPAVIDataSetTableAdapters.TableAdapterManager()
        Me.ClubesTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter()
        Me.ProfesoresTableAdapter = New TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfesoresTableAdapter()
        Me.grd_DGVProfXClub = New System.Windows.Forms.DataGridView()
        Me.TPIPAVIDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPIPAVIDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ClubesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfXClubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_DGVProfXClub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPIPAVIDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(293, 325)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 18
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(212, 325)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 17
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(93, 325)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_eliminar.TabIndex = 20
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 325)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 19
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Profesor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Club"
        '
        'cmb_club
        '
        Me.cmb_club.DataSource = Me.ClubesBindingSource1
        Me.cmb_club.DisplayMember = "Nombre"
        Me.cmb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_club.FormattingEnabled = True
        Me.cmb_club.Location = New System.Drawing.Point(83, 49)
        Me.cmb_club.Name = "cmb_club"
        Me.cmb_club.Size = New System.Drawing.Size(121, 21)
        Me.cmb_club.TabIndex = 13
        Me.cmb_club.ValueMember = "CodClub"
        '
        'ClubesBindingSource1
        '
        Me.ClubesBindingSource1.DataMember = "Clubes"
        Me.ClubesBindingSource1.DataSource = Me.TPIPAVIDataSet
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
        'cmb_profesor
        '
        Me.cmb_profesor.DataSource = Me.ProfesoresBindingSource1
        Me.cmb_profesor.DisplayMember = "Apellido"
        Me.cmb_profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_profesor.FormattingEnabled = True
        Me.cmb_profesor.Location = New System.Drawing.Point(83, 18)
        Me.cmb_profesor.Name = "cmb_profesor"
        Me.cmb_profesor.Size = New System.Drawing.Size(121, 21)
        Me.cmb_profesor.TabIndex = 14
        Me.cmb_profesor.ValueMember = "CodProf"
        '
        'ProfesoresBindingSource1
        '
        Me.ProfesoresBindingSource1.DataMember = "Profesores"
        Me.ProfesoresBindingSource1.DataSource = Me.TPIPAVIDataSet
        '
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "Profesores"
        Me.ProfesoresBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'ProfXClubBindingSource
        '
        Me.ProfXClubBindingSource.DataMember = "ProfXClub"
        Me.ProfXClubBindingSource.DataSource = Me.TPIPAVIDataSet
        '
        'ProfXClubTableAdapter
        '
        Me.ProfXClubTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClubesTableAdapter = Me.ClubesTableAdapter
        Me.TableAdapterManager.CodigosPostTableAdapter = Nothing
        Me.TableAdapterManager.EspecialidadTableAdapter = Nothing
        Me.TableAdapterManager.EspecXCompetTableAdapter = Nothing
        Me.TableAdapterManager.InscriptosTableAdapter = Nothing
        Me.TableAdapterManager.NadadoresTableAdapter = Nothing
        Me.TableAdapterManager.NadaXEspeTableAdapter = Nothing
        Me.TableAdapterManager.ProfesoresTableAdapter = Me.ProfesoresTableAdapter
        Me.TableAdapterManager.ProfXClubTableAdapter = Me.ProfXClubTableAdapter
        Me.TableAdapterManager.ProfXEspecTableAdapter = Nothing
        Me.TableAdapterManager.TiposDocTableAdapter = Nothing
        Me.TableAdapterManager.TORNEOSTableAdapter = Nothing
        Me.TableAdapterManager.TorneosXAñoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TPI_PAVI.TPIPAVIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClubesTableAdapter
        '
        Me.ClubesTableAdapter.ClearBeforeFill = True
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'grd_DGVProfXClub
        '
        Me.grd_DGVProfXClub.AllowUserToAddRows = False
        Me.grd_DGVProfXClub.AllowUserToDeleteRows = False
        Me.grd_DGVProfXClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_DGVProfXClub.Location = New System.Drawing.Point(12, 90)
        Me.grd_DGVProfXClub.Name = "grd_DGVProfXClub"
        Me.grd_DGVProfXClub.ReadOnly = True
        Me.grd_DGVProfXClub.Size = New System.Drawing.Size(356, 220)
        Me.grd_DGVProfXClub.TabIndex = 21
        '
        'TPIPAVIDataSetBindingSource
        '
        Me.TPIPAVIDataSetBindingSource.DataSource = Me.TPIPAVIDataSet
        Me.TPIPAVIDataSetBindingSource.Position = 0
        '
        'TPIPAVIDataSetBindingSource1
        '
        Me.TPIPAVIDataSetBindingSource1.DataSource = Me.TPIPAVIDataSet
        Me.TPIPAVIDataSetBindingSource1.Position = 0
        '
        'frm_ProfesorXClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 360)
        Me.Controls.Add(Me.grd_DGVProfXClub)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_club)
        Me.Controls.Add(Me.cmb_profesor)
        Me.Name = "frm_ProfesorXClub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfesorXClub"
        CType(Me.ClubesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClubesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfXClubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_DGVProfXClub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPIPAVIDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_club As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents TPIPAVIDataSet As TPI_PAVI.TPIPAVIDataSet
    Friend WithEvents ProfXClubBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfXClubTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfXClubTableAdapter
    Friend WithEvents TableAdapterManager As TPI_PAVI.TPIPAVIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfesoresTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ProfesoresTableAdapter
    Friend WithEvents grd_DGVProfXClub As System.Windows.Forms.DataGridView
    Friend WithEvents TPIPAVIDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPIPAVIDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesTableAdapter As TPI_PAVI.TPIPAVIDataSetTableAdapters.ClubesTableAdapter
    Friend WithEvents ClubesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClubesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresBindingSource1 As System.Windows.Forms.BindingSource
End Class
