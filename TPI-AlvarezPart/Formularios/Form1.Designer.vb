<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ABMEspecialidad
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
        Me.EspecialidadTableAdapter1 = New TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter()
        Me.Lbl_Especialidad = New System.Windows.Forms.Label()
        Me.lbl_TiempoRecord = New System.Windows.Forms.Label()
        Me.msk_TiempoRecord = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NombreEspecialidad = New System.Windows.Forms.TextBox()
        Me.lbl_CodEspecialidad = New System.Windows.Forms.Label()
        Me.txt_CodigoEspecialidad = New System.Windows.Forms.TextBox()
        Me.grd_ListaEspecialidades = New System.Windows.Forms.DataGridView()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        CType(Me.grd_ListaEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EspecialidadTableAdapter1
        '
        Me.EspecialidadTableAdapter1.ClearBeforeFill = True
        '
        'Lbl_Especialidad
        '
        Me.Lbl_Especialidad.AutoSize = True
        Me.Lbl_Especialidad.Location = New System.Drawing.Point(8, 51)
        Me.Lbl_Especialidad.Name = "Lbl_Especialidad"
        Me.Lbl_Especialidad.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_Especialidad.TabIndex = 9
        Me.Lbl_Especialidad.Text = "Nombre Especialidad"
        '
        'lbl_TiempoRecord
        '
        Me.lbl_TiempoRecord.AutoSize = True
        Me.lbl_TiempoRecord.Location = New System.Drawing.Point(35, 80)
        Me.lbl_TiempoRecord.Name = "lbl_TiempoRecord"
        Me.lbl_TiempoRecord.Size = New System.Drawing.Size(80, 13)
        Me.lbl_TiempoRecord.TabIndex = 10
        Me.lbl_TiempoRecord.Text = "Tiempo Record"
        '
        'msk_TiempoRecord
        '
        Me.msk_TiempoRecord.Location = New System.Drawing.Point(125, 76)
        Me.msk_TiempoRecord.Mask = "00:00:00,00"
        Me.msk_TiempoRecord.Name = "msk_TiempoRecord"
        Me.msk_TiempoRecord.Size = New System.Drawing.Size(75, 20)
        Me.msk_TiempoRecord.TabIndex = 2
        '
        'txt_NombreEspecialidad
        '
        Me.txt_NombreEspecialidad.Location = New System.Drawing.Point(125, 48)
        Me.txt_NombreEspecialidad.Name = "txt_NombreEspecialidad"
        Me.txt_NombreEspecialidad.Size = New System.Drawing.Size(159, 20)
        Me.txt_NombreEspecialidad.TabIndex = 1
        '
        'lbl_CodEspecialidad
        '
        Me.lbl_CodEspecialidad.AutoSize = True
        Me.lbl_CodEspecialidad.Location = New System.Drawing.Point(12, 22)
        Me.lbl_CodEspecialidad.Name = "lbl_CodEspecialidad"
        Me.lbl_CodEspecialidad.Size = New System.Drawing.Size(103, 13)
        Me.lbl_CodEspecialidad.TabIndex = 8
        Me.lbl_CodEspecialidad.Text = "Codigo Especialidad"
        '
        'txt_CodigoEspecialidad
        '
        Me.txt_CodigoEspecialidad.Location = New System.Drawing.Point(125, 20)
        Me.txt_CodigoEspecialidad.Name = "txt_CodigoEspecialidad"
        Me.txt_CodigoEspecialidad.Size = New System.Drawing.Size(48, 20)
        Me.txt_CodigoEspecialidad.TabIndex = 0
        '
        'grd_ListaEspecialidades
        '
        Me.grd_ListaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_ListaEspecialidades.Location = New System.Drawing.Point(15, 120)
        Me.grd_ListaEspecialidades.Name = "grd_ListaEspecialidades"
        Me.grd_ListaEspecialidades.Size = New System.Drawing.Size(397, 150)
        Me.grd_ListaEspecialidades.TabIndex = 3
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(104, 286)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_eliminar.TabIndex = 5
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(15, 286)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(83, 31)
        Me.cmd_nuevo.TabIndex = 4
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(329, 286)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_cancelar.TabIndex = 7
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(240, 286)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_guardar.TabIndex = 6
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'Form_ABMEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 325)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.grd_ListaEspecialidades)
        Me.Controls.Add(Me.txt_CodigoEspecialidad)
        Me.Controls.Add(Me.lbl_CodEspecialidad)
        Me.Controls.Add(Me.txt_NombreEspecialidad)
        Me.Controls.Add(Me.msk_TiempoRecord)
        Me.Controls.Add(Me.lbl_TiempoRecord)
        Me.Controls.Add(Me.Lbl_Especialidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form_ABMEspecialidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Especialidades"
        CType(Me.grd_ListaEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EspecialidadTableAdapter1 As TPI_PAVI.TPIPAVIDataSetTableAdapters.EspecialidadTableAdapter
    Friend WithEvents Lbl_Especialidad As System.Windows.Forms.Label
    Friend WithEvents lbl_TiempoRecord As System.Windows.Forms.Label
    Friend WithEvents msk_TiempoRecord As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_NombreEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodEspecialidad As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents grd_ListaEspecialidades As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
End Class
