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
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPersonal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtNumeroID = New System.Windows.Forms.TextBox()
        Me.btnVerDatoCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelDatosCliente = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReferenciasDirec = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.btnCasa = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.PanelDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(193, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 28)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Teléfono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(175, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 28)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(305, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 29)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Datos tecnico"
        '
        'txtTelefonoTec
        '
        Me.txtTelefonoTec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoTec.Location = New System.Drawing.Point(298, 320)
        Me.txtTelefonoTec.Name = "txtTelefonoTec"
        Me.txtTelefonoTec.Size = New System.Drawing.Size(203, 30)
        Me.txtTelefonoTec.TabIndex = 35
        '
        'txtNombreTec
        '
        Me.txtNombreTec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreTec.Location = New System.Drawing.Point(266, 268)
        Me.txtNombreTec.Name = "txtNombreTec"
        Me.txtNombreTec.Size = New System.Drawing.Size(265, 30)
        Me.txtNombreTec.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(154, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 28)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Nota"
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(142, 482)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(535, 131)
        Me.txtNota.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(139, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 28)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Operacion"
        '
        'cmbOperaciones
        '
        Me.cmbOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperaciones.FormattingEnabled = True
        Me.cmbOperaciones.Location = New System.Drawing.Point(142, 402)
        Me.cmbOperaciones.Name = "cmbOperaciones"
        Me.cmbOperaciones.Size = New System.Drawing.Size(286, 33)
        Me.cmbOperaciones.TabIndex = 30
        '
        'cmbPrioridad
        '
        Me.cmbPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrioridad.FormattingEnabled = True
        Me.cmbPrioridad.Items.AddRange(New Object() {"Alta", "Baja"})
        Me.cmbPrioridad.Location = New System.Drawing.Point(523, 402)
        Me.cmbPrioridad.Name = "cmbPrioridad"
        Me.cmbPrioridad.Size = New System.Drawing.Size(130, 33)
        Me.cmbPrioridad.TabIndex = 29
        '
        'cmbEstado
        '
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Ocupado", "Libre"})
        Me.cmbEstado.Location = New System.Drawing.Point(594, 287)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(185, 33)
        Me.cmbEstado.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Asignar a"
        '
        'cmbPersonal
        '
        Me.cmbPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPersonal.FormattingEnabled = True
        Me.cmbPersonal.Location = New System.Drawing.Point(30, 272)
        Me.cmbPersonal.Name = "cmbPersonal"
        Me.cmbPersonal.Size = New System.Drawing.Size(115, 33)
        Me.cmbPersonal.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(591, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 28)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(520, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 28)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Prioridad"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(335, 638)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(201, 48)
        Me.btnGenerar.TabIndex = 23
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtNumeroID
        '
        Me.txtNumeroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroID.Location = New System.Drawing.Point(30, 152)
        Me.txtNumeroID.Name = "txtNumeroID"
        Me.txtNumeroID.Size = New System.Drawing.Size(236, 30)
        Me.txtNumeroID.TabIndex = 22
        '
        'btnVerDatoCliente
        '
        Me.btnVerDatoCliente.BackColor = System.Drawing.Color.Silver
        Me.btnVerDatoCliente.Location = New System.Drawing.Point(335, 91)
        Me.btnVerDatoCliente.Name = "btnVerDatoCliente"
        Me.btnVerDatoCliente.Size = New System.Drawing.Size(236, 29)
        Me.btnVerDatoCliente.TabIndex = 40
        Me.btnVerDatoCliente.Text = "Ver datos cliente"
        Me.btnVerDatoCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 28)
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
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(900, 76)
        Me.Panel3.TabIndex = 41
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
        Me.PanelDatosCliente.Location = New System.Drawing.Point(335, 128)
        Me.PanelDatosCliente.Name = "PanelDatosCliente"
        Me.PanelDatosCliente.Size = New System.Drawing.Size(537, 33)
        Me.PanelDatosCliente.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Fugaz One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(18, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(160, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Nombre completo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Fugaz One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(18, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 25)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Teléfono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Fugaz One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(223, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 25)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Ref. dirección"
        '
        'txtReferenciasDirec
        '
        Me.txtReferenciasDirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciasDirec.Location = New System.Drawing.Point(221, 129)
        Me.txtReferenciasDirec.Multiline = True
        Me.txtReferenciasDirec.Name = "txtReferenciasDirec"
        Me.txtReferenciasDirec.Size = New System.Drawing.Size(308, 76)
        Me.txtReferenciasDirec.TabIndex = 12
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(23, 57)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(429, 30)
        Me.txtNombreCompleto.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(20, 127)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(184, 30)
        Me.txtTelefono.TabIndex = 11
        '
        'TimerMostrar
        '
        '
        'TimerOcultar
        '
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
        Me.btnCasa.Location = New System.Drawing.Point(97, 15)
        Me.btnCasa.Name = "btnCasa"
        Me.btnCasa.Size = New System.Drawing.Size(48, 43)
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
        Me.btnVolver.Location = New System.Drawing.Point(12, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(65, 65)
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
        Me.btnCerrar.Location = New System.Drawing.Point(845, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 45)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'GenerarTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 698)
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
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPersonal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtNumeroID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPersonal As ComboBox
    Friend WithEvents Label3 As Label
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
