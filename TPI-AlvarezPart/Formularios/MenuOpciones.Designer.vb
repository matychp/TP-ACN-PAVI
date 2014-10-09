<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuOpciones
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
        Me.cmd_profesores = New System.Windows.Forms.Button()
        Me.cmd_abm = New System.Windows.Forms.Button()
        Me.cmd_clubafiliado = New System.Windows.Forms.Button()
        Me.cmd_nadadores = New System.Windows.Forms.Button()
        Me.cmd_especialidades = New System.Windows.Forms.Button()
        Me.cmd_torneos = New System.Windows.Forms.Button()
        Me.cmd_codpostal = New System.Windows.Forms.Button()
        Me.cmd_tipodocumento = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_procesos = New System.Windows.Forms.Button()
        Me.cmd_listconsultas = New System.Windows.Forms.Button()
        Me.cmd_estadisticas = New System.Windows.Forms.Button()
        Me.cmd_nadXespe = New System.Windows.Forms.Button()
        Me.cmd_profXespe = New System.Windows.Forms.Button()
        Me.cmd_TorneosXAño = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_profesores
        '
        Me.cmd_profesores.Location = New System.Drawing.Point(119, 146)
        Me.cmd_profesores.Name = "cmd_profesores"
        Me.cmd_profesores.Size = New System.Drawing.Size(102, 46)
        Me.cmd_profesores.TabIndex = 1
        Me.cmd_profesores.Text = "Profesores"
        Me.cmd_profesores.UseVisualStyleBackColor = True
        '
        'cmd_abm
        '
        Me.cmd_abm.BackColor = System.Drawing.Color.White
        Me.cmd_abm.BackgroundImage = Global.TPI_PAVI.My.Resources.Resources.flechitaVerde
        Me.cmd_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_abm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_abm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm.Location = New System.Drawing.Point(12, 146)
        Me.cmd_abm.Name = "cmd_abm"
        Me.cmd_abm.Size = New System.Drawing.Size(100, 100)
        Me.cmd_abm.TabIndex = 0
        Me.cmd_abm.Text = "Altas, Bajas, Modificaciones"
        Me.cmd_abm.UseVisualStyleBackColor = False
        '
        'cmd_clubafiliado
        '
        Me.cmd_clubafiliado.Location = New System.Drawing.Point(227, 146)
        Me.cmd_clubafiliado.Name = "cmd_clubafiliado"
        Me.cmd_clubafiliado.Size = New System.Drawing.Size(102, 46)
        Me.cmd_clubafiliado.TabIndex = 2
        Me.cmd_clubafiliado.Text = "Club Afiliado"
        Me.cmd_clubafiliado.UseVisualStyleBackColor = True
        '
        'cmd_nadadores
        '
        Me.cmd_nadadores.Location = New System.Drawing.Point(334, 145)
        Me.cmd_nadadores.Name = "cmd_nadadores"
        Me.cmd_nadadores.Size = New System.Drawing.Size(102, 46)
        Me.cmd_nadadores.TabIndex = 3
        Me.cmd_nadadores.Text = "Nadadores"
        Me.cmd_nadadores.UseVisualStyleBackColor = True
        '
        'cmd_especialidades
        '
        Me.cmd_especialidades.Location = New System.Drawing.Point(442, 146)
        Me.cmd_especialidades.Name = "cmd_especialidades"
        Me.cmd_especialidades.Size = New System.Drawing.Size(102, 46)
        Me.cmd_especialidades.TabIndex = 4
        Me.cmd_especialidades.Text = "Especialidades"
        Me.cmd_especialidades.UseVisualStyleBackColor = True
        '
        'cmd_torneos
        '
        Me.cmd_torneos.Location = New System.Drawing.Point(118, 198)
        Me.cmd_torneos.Name = "cmd_torneos"
        Me.cmd_torneos.Size = New System.Drawing.Size(102, 46)
        Me.cmd_torneos.TabIndex = 5
        Me.cmd_torneos.Text = "Torneos"
        Me.cmd_torneos.UseVisualStyleBackColor = True
        '
        'cmd_codpostal
        '
        Me.cmd_codpostal.Location = New System.Drawing.Point(334, 197)
        Me.cmd_codpostal.Name = "cmd_codpostal"
        Me.cmd_codpostal.Size = New System.Drawing.Size(102, 46)
        Me.cmd_codpostal.TabIndex = 7
        Me.cmd_codpostal.Text = "Codigo Postal"
        Me.cmd_codpostal.UseVisualStyleBackColor = True
        '
        'cmd_tipodocumento
        '
        Me.cmd_tipodocumento.Location = New System.Drawing.Point(226, 198)
        Me.cmd_tipodocumento.Name = "cmd_tipodocumento"
        Me.cmd_tipodocumento.Size = New System.Drawing.Size(102, 46)
        Me.cmd_tipodocumento.TabIndex = 6
        Me.cmd_tipodocumento.Text = "Tipos de Documentos"
        Me.cmd_tipodocumento.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 130)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Asociación Cordobesa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Natación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.TPI_PAVI.My.Resources.Resources.ico_n_natacion
        Me.PictureBox1.Location = New System.Drawing.Point(464, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'cmd_procesos
        '
        Me.cmd_procesos.BackColor = System.Drawing.Color.White
        Me.cmd_procesos.BackgroundImage = Global.TPI_PAVI.My.Resources.Resources.flechitaVerde
        Me.cmd_procesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_procesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_procesos.Location = New System.Drawing.Point(12, 266)
        Me.cmd_procesos.Name = "cmd_procesos"
        Me.cmd_procesos.Size = New System.Drawing.Size(100, 100)
        Me.cmd_procesos.TabIndex = 8
        Me.cmd_procesos.Text = "Procesos"
        Me.cmd_procesos.UseVisualStyleBackColor = False
        '
        'cmd_listconsultas
        '
        Me.cmd_listconsultas.BackColor = System.Drawing.Color.White
        Me.cmd_listconsultas.BackgroundImage = Global.TPI_PAVI.My.Resources.Resources.flechitaVerde
        Me.cmd_listconsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_listconsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_listconsultas.Location = New System.Drawing.Point(12, 392)
        Me.cmd_listconsultas.Name = "cmd_listconsultas"
        Me.cmd_listconsultas.Size = New System.Drawing.Size(100, 100)
        Me.cmd_listconsultas.TabIndex = 9
        Me.cmd_listconsultas.Text = "Listados/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consultas"
        Me.cmd_listconsultas.UseVisualStyleBackColor = False
        '
        'cmd_estadisticas
        '
        Me.cmd_estadisticas.BackColor = System.Drawing.Color.White
        Me.cmd_estadisticas.BackgroundImage = Global.TPI_PAVI.My.Resources.Resources.flechitaVerde
        Me.cmd_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_estadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_estadisticas.Location = New System.Drawing.Point(12, 514)
        Me.cmd_estadisticas.Name = "cmd_estadisticas"
        Me.cmd_estadisticas.Size = New System.Drawing.Size(100, 100)
        Me.cmd_estadisticas.TabIndex = 10
        Me.cmd_estadisticas.Text = "Estadísticas"
        Me.cmd_estadisticas.UseVisualStyleBackColor = False
        '
        'cmd_nadXespe
        '
        Me.cmd_nadXespe.Location = New System.Drawing.Point(119, 266)
        Me.cmd_nadXespe.Name = "cmd_nadXespe"
        Me.cmd_nadXespe.Size = New System.Drawing.Size(102, 46)
        Me.cmd_nadXespe.TabIndex = 11
        Me.cmd_nadXespe.Text = "Nadadores X Especialidad"
        Me.cmd_nadXespe.UseVisualStyleBackColor = True
        '
        'cmd_profXespe
        '
        Me.cmd_profXespe.Location = New System.Drawing.Point(227, 266)
        Me.cmd_profXespe.Name = "cmd_profXespe"
        Me.cmd_profXespe.Size = New System.Drawing.Size(102, 46)
        Me.cmd_profXespe.TabIndex = 11
        Me.cmd_profXespe.Text = "Profesores X Especialidad"
        Me.cmd_profXespe.UseVisualStyleBackColor = True
        '
        'cmd_TorneosXAño
        '
        Me.cmd_TorneosXAño.Location = New System.Drawing.Point(334, 266)
        Me.cmd_TorneosXAño.Name = "cmd_TorneosXAño"
        Me.cmd_TorneosXAño.Size = New System.Drawing.Size(102, 45)
        Me.cmd_TorneosXAño.TabIndex = 12
        Me.cmd_TorneosXAño.Text = "Torneos X Año"
        Me.cmd_TorneosXAño.UseVisualStyleBackColor = True
        '
        'MenuOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TPI_PAVI.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 626)
        Me.Controls.Add(Me.cmd_TorneosXAño)
        Me.Controls.Add(Me.cmd_clubafiliado)
        Me.Controls.Add(Me.cmd_profesores)
        Me.Controls.Add(Me.cmd_profXespe)
        Me.Controls.Add(Me.cmd_nadXespe)
        Me.Controls.Add(Me.cmd_abm)
        Me.Controls.Add(Me.cmd_estadisticas)
        Me.Controls.Add(Me.cmd_listconsultas)
        Me.Controls.Add(Me.cmd_procesos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_codpostal)
        Me.Controls.Add(Me.cmd_especialidades)
        Me.Controls.Add(Me.cmd_nadadores)
        Me.Controls.Add(Me.cmd_torneos)
        Me.Controls.Add(Me.cmd_tipodocumento)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MenuOpciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de Opciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_profesores As System.Windows.Forms.Button
    Friend WithEvents cmd_clubafiliado As System.Windows.Forms.Button
    Friend WithEvents cmd_nadadores As System.Windows.Forms.Button
    Friend WithEvents cmd_especialidades As System.Windows.Forms.Button
    Friend WithEvents cmd_torneos As System.Windows.Forms.Button
    Friend WithEvents cmd_codpostal As System.Windows.Forms.Button
    Friend WithEvents cmd_tipodocumento As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_procesos As System.Windows.Forms.Button
    Friend WithEvents cmd_listconsultas As System.Windows.Forms.Button
    Friend WithEvents cmd_estadisticas As System.Windows.Forms.Button
    Private WithEvents cmd_abm As System.Windows.Forms.Button
    Friend WithEvents cmd_nadXespe As System.Windows.Forms.Button
    Friend WithEvents cmd_profXespe As System.Windows.Forms.Button
    Friend WithEvents cmd_TorneosXAño As System.Windows.Forms.Button
End Class
