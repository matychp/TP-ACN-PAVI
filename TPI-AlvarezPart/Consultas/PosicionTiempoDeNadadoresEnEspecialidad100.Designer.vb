﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosicionTiempoDeNadadoresEnEspecialidad100
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
        Me.cmd_ejecutarConsulta = New System.Windows.Forms.Button()
        Me.cmb_nadador = New System.Windows.Forms.ComboBox()
        Me.grd_dgvTiempoPosNad = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.cmd_consultaPerso = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_help = New System.Windows.Forms.Button()
        CType(Me.grd_dgvTiempoPosNad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_ejecutarConsulta
        '
        Me.cmd_ejecutarConsulta.Location = New System.Drawing.Point(12, 284)
        Me.cmd_ejecutarConsulta.Name = "cmd_ejecutarConsulta"
        Me.cmd_ejecutarConsulta.Size = New System.Drawing.Size(126, 41)
        Me.cmd_ejecutarConsulta.TabIndex = 0
        Me.cmd_ejecutarConsulta.Text = "Ejecutar Consulta Estándar"
        Me.cmd_ejecutarConsulta.UseVisualStyleBackColor = True
        '
        'cmb_nadador
        '
        Me.cmb_nadador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nadador.FormattingEnabled = True
        Me.cmb_nadador.Location = New System.Drawing.Point(85, 16)
        Me.cmb_nadador.Name = "cmb_nadador"
        Me.cmb_nadador.Size = New System.Drawing.Size(121, 21)
        Me.cmb_nadador.TabIndex = 1
        '
        'grd_dgvTiempoPosNad
        '
        Me.grd_dgvTiempoPosNad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_dgvTiempoPosNad.Location = New System.Drawing.Point(12, 112)
        Me.grd_dgvTiempoPosNad.Name = "grd_dgvTiempoPosNad"
        Me.grd_dgvTiempoPosNad.Size = New System.Drawing.Size(345, 166)
        Me.grd_dgvTiempoPosNad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nadador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Especialidad:"
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(85, 49)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_especialidad.TabIndex = 1
        '
        'cmd_consultaPerso
        '
        Me.cmd_consultaPerso.Location = New System.Drawing.Point(144, 284)
        Me.cmd_consultaPerso.Name = "cmd_consultaPerso"
        Me.cmd_consultaPerso.Size = New System.Drawing.Size(126, 41)
        Me.cmd_consultaPerso.TabIndex = 0
        Me.cmd_consultaPerso.Text = "Ejecutar Consulta Personalizada"
        Me.cmd_consultaPerso.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado de la consulta:"
        '
        'cmd_help
        '
        Me.cmd_help.Location = New System.Drawing.Point(307, 284)
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(50, 41)
        Me.cmd_help.TabIndex = 0
        Me.cmd_help.Text = "Help"
        Me.cmd_help.UseVisualStyleBackColor = True
        '
        'PosicionTiempoDeNadadoresEnEspecialidad100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 333)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_dgvTiempoPosNad)
        Me.Controls.Add(Me.cmb_especialidad)
        Me.Controls.Add(Me.cmb_nadador)
        Me.Controls.Add(Me.cmd_help)
        Me.Controls.Add(Me.cmd_consultaPerso)
        Me.Controls.Add(Me.cmd_ejecutarConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PosicionTiempoDeNadadoresEnEspecialidad100"
        Me.Text = "PosicionTiempoDeNadadoresEnEspecialidad100"
        CType(Me.grd_dgvTiempoPosNad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_ejecutarConsulta As System.Windows.Forms.Button
    Friend WithEvents cmb_nadador As System.Windows.Forms.ComboBox
    Friend WithEvents grd_dgvTiempoPosNad As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_consultaPerso As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_help As System.Windows.Forms.Button
End Class