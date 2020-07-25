<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarTicket))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefonoTec = New System.Windows.Forms.TextBox()
        Me.txtNombreTec = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbOperaciones = New System.Windows.Forms.ComboBox()
        Me.cmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPersonal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtNumeroID = New System.Windows.Forms.TextBox()
        Me.btnVerDatoCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCasa = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelDatosCliente = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReferenciasDirec = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.PanelDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(198, 259)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Teléfono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(184, 220)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(282, 178)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Datos tecnico"
        '
        'txtTelefonoTec
        '
        Me.txtTelefonoTec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoTec.Location = New System.Drawing.Point(277, 259)
        Me.txtTelefonoTec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefonoTec.Name = "txtTelefonoTec"
        Me.txtTelefonoTec.Size = New System.Drawing.Size(153, 26)
        Me.txtTelefonoTec.TabIndex = 35
        '
        'txtNombreTec
        '
        Me.txtNombreTec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTec.Location = New System.Drawing.Point(253, 217)
        Me.txtNombreTec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreTec.Name = "txtNombreTec"
        Me.txtNombreTec.Size = New System.Drawing.Size(200, 26)
        Me.txtNombreTec.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(169, 365)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Nota"
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(159, 391)
        Me.txtNota.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(402, 107)
        Me.txtNota.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(157, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Operacion"
        '
        'cmbOperaciones
        '
        Me.cmbOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperaciones.FormattingEnabled = True
        Me.cmbOperaciones.Location = New System.Drawing.Point(159, 326)
        Me.cmbOperaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbOperaciones.Name = "cmbOperaciones"
        Me.cmbOperaciones.Size = New System.Drawing.Size(216, 28)
        Me.cmbOperaciones.TabIndex = 30
        '
        'cmbPrioridad
        '
        Me.cmbPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrioridad.FormattingEnabled = True
        Me.cmbPrioridad.Items.AddRange(New Object() {"Alta", "Baja"})
        Me.cmbPrioridad.Location = New System.Drawing.Point(445, 326)
        Me.cmbPrioridad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPrioridad.Name = "cmbPrioridad"
        Me.cmbPrioridad.Size = New System.Drawing.Size(98, 28)
        Me.cmbPrioridad.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Asignar a"
        '
        'cmbPersonal
        '
        Me.cmbPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPersonal.FormattingEnabled = True
        Me.cmbPersonal.Location = New System.Drawing.Point(35, 220)
        Me.cmbPersonal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPersonal.Name = "cmbPersonal"
        Me.cmbPersonal.Size = New System.Drawing.Size(97, 28)
        Me.cmbPersonal.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(443, 300)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Prioridad"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(304, 517)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(151, 39)
        Me.btnGenerar.TabIndex = 23
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtNumeroID
        '
        Me.txtNumeroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroID.Location = New System.Drawing.Point(22, 124)
        Me.txtNumeroID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNumeroID.Name = "txtNumeroID"
        Me.txtNumeroID.Size = New System.Drawing.Size(178, 26)
        Me.txtNumeroID.TabIndex = 22
        '
        'btnVerDatoCliente
        '
        Me.btnVerDatoCliente.BackColor = System.Drawing.Color.Silver
        Me.btnVerDatoCliente.Location = New System.Drawing.Point(251, 74)
        Me.btnVerDatoCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVerDatoCliente.Name = "btnVerDatoCliente"
        Me.btnVerDatoCliente.Size = New System.Drawing.Size(177, 24)
        Me.btnVerDatoCliente.TabIndex = 40
        Me.btnVerDatoCliente.Text = "Ver datos cliente"
        Me.btnVerDatoCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Número ID cliente:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnCasa)
        Me.Panel3.Controls.Add(Me.btnVolver)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(675, 62)
        Me.Panel3.TabIndex = 41
        '
        'btnCasa
        '
        Me.btnCasa.BackColor = System.Drawing.Color.Transparent
        Me.btnCasa.BackgroundImage = CType(resources.GetObject("btnCasa.BackgroundImage"), System.Drawing.Image)
        Me.btnCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCasa.FlatAppearance.BorderSize = 0
        Me.btnCasa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCasa.Location = New System.Drawing.Point(73, 12)
        Me.btnCasa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCasa.Name = "btnCasa"
        Me.btnCasa.Size = New System.Drawing.Size(36, 35)
        Me.btnCasa.TabIndex = 9
        Me.btnCasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCasa.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), System.Drawing.Image)
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Location = New System.Drawing.Point(9, 2)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(49, 53)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(634, 10)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 37)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelDatosCliente
        '
        Me.PanelDatosCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelDatosCliente.Controls.Add(Me.Label12)
        Me.PanelDatosCliente.Controls.Add(Me.Label11)
        Me.PanelDatosCliente.Controls.Add(Me.Label10)
        Me.PanelDatosCliente.Controls.Add(Me.txtReferenciasDirec)
        Me.PanelDatosCliente.Controls.Add(Me.txtNombreCompleto)
        Me.PanelDatosCliente.Controls.Add(Me.txtTelefono)
        Me.PanelDatosCliente.Location = New System.Drawing.Point(251, 104)
        Me.PanelDatosCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDatosCliente.Name = "PanelDatosCliente"
        Me.PanelDatosCliente.Size = New System.Drawing.Size(403, 27)
        Me.PanelDatosCliente.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(14, 24)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Nombre completo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Teléfono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(167, 80)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Ref. dirección"
        '
        'txtReferenciasDirec
        '
        Me.txtReferenciasDirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciasDirec.Location = New System.Drawing.Point(166, 105)
        Me.txtReferenciasDirec.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReferenciasDirec.Multiline = True
        Me.txtReferenciasDirec.Name = "txtReferenciasDirec"
        Me.txtReferenciasDirec.Size = New System.Drawing.Size(232, 62)
        Me.txtReferenciasDirec.TabIndex = 12
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(17, 46)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(323, 26)
        Me.txtNombreCompleto.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(15, 103)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(139, 26)
        Me.txtTelefono.TabIndex = 11
        '
        'TimerMostrar
        '
        '
        'TimerOcultar
        '
        '
        'GenerarTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(675, 580)
        Me.Controls.Add(Me.PanelDatosCliente)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnVerDatoCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelefonoTec)
        Me.Controls.Add(Me.txtNombreTec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbOperaciones)
        Me.Controls.Add(Me.cmbPrioridad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPersonal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtNumeroID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GenerarTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenerarTicket"
        Me.Panel3.ResumeLayout(False)
        Me.PanelDatosCliente.ResumeLayout(False)
        Me.PanelDatosCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelefonoTec As TextBox
    Friend WithEvents txtNombreTec As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbOperaciones As ComboBox
    Friend WithEvents cmbPrioridad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPersonal As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtNumeroID As TextBox
    Friend WithEvents btnVerDatoCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelDatosCliente As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtReferenciasDirec As TextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents btnCasa As Button
End Class
