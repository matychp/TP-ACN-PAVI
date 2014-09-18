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
        Me.dgv_CodPos = New System.Windows.Forms.DataGridView()
        Me.msk_CodPos = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombreCodPos = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_numCodPos = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        CType(Me.dgv_CodPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_CodPos
        '
        Me.dgv_CodPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CodPos.Location = New System.Drawing.Point(17, 86)
        Me.dgv_CodPos.Name = "dgv_CodPos"
        Me.dgv_CodPos.Size = New System.Drawing.Size(404, 190)
        Me.dgv_CodPos.TabIndex = 31
        '
        'msk_CodPos
        '
        Me.msk_CodPos.Location = New System.Drawing.Point(91, 9)
        Me.msk_CodPos.Mask = "9999"
        Me.msk_CodPos.Name = "msk_CodPos"
        Me.msk_CodPos.Size = New System.Drawing.Size(31, 20)
        Me.msk_CodPos.TabIndex = 30
        '
        'txt_nombreCodPos
        '
        Me.txt_nombreCodPos.Location = New System.Drawing.Point(91, 41)
        Me.txt_nombreCodPos.Name = "txt_nombreCodPos"
        Me.txt_nombreCodPos.Size = New System.Drawing.Size(304, 20)
        Me.txt_nombreCodPos.TabIndex = 29
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(14, 44)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(73, 13)
        Me.lbl_nombre.TabIndex = 28
        Me.lbl_nombre.Text = "Zona/Ciudad:"
        '
        'lbl_numCodPos
        '
        Me.lbl_numCodPos.AutoSize = True
        Me.lbl_numCodPos.Location = New System.Drawing.Point(12, 9)
        Me.lbl_numCodPos.Name = "lbl_numCodPos"
        Me.lbl_numCodPos.Size = New System.Drawing.Size(75, 13)
        Me.lbl_numCodPos.TabIndex = 27
        Me.lbl_numCodPos.Text = "Codigo Postal:"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(338, 295)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_cancelar.TabIndex = 26
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(249, 295)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_guardar.TabIndex = 25
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(24, 295)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(83, 31)
        Me.cmd_nuevo.TabIndex = 23
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(113, 295)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(83, 31)
        Me.cmd_eliminar.TabIndex = 24
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'Form_ABMCodigosPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 341)
        Me.Controls.Add(Me.dgv_CodPos)
        Me.Controls.Add(Me.msk_CodPos)
        Me.Controls.Add(Me.txt_nombreCodPos)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_numCodPos)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Name = "Form_ABMCodigosPost"
        Me.Text = "CodigosPost"
        CType(Me.dgv_CodPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_CodPos As System.Windows.Forms.DataGridView
    Friend WithEvents msk_CodPos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombreCodPos As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_numCodPos As System.Windows.Forms.Label
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
End Class
