<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActualizarTicket
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarTicket))
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkEstadoRealizado = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOperacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroID = New System.Windows.Forms.TextBox()
        Me.PanelDatosCliente = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReferenciasDirec = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnVerDatoCliente = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkCambioEqui = New System.Windows.Forms.CheckBox()
        Me.cmbEr = New System.Windows.Forms.ComboBox()
        Me.cmbAn = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelOpciones.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelDatosCliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.btnCerrar)
        Me.PanelOpciones.Controls.Add(Me.btnVolver)
        Me.PanelOpciones.Controls.Add(Me.Label2)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1128, 82)
        Me.PanelOpciones.TabIndex = 0
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
        Me.btnCerrar.Location = New System.Drawing.Point(1071, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 45)
        Me.btnCerrar.TabIndex = 23
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), System.Drawing.Image)
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Location = New System.Drawing.Point(12, 11)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(65, 65)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Actualizar ticket"
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.PanelDatosCliente)
        Me.PanelContenido.Controls.Add(Me.GroupBox1)
        Me.PanelContenido.Controls.Add(Me.btnActualizar)
        Me.PanelContenido.Controls.Add(Me.Label1)
        Me.PanelContenido.Controls.Add(Me.txtNumeroID)
        Me.PanelContenido.Controls.Add(Me.btnVerDatoCliente)
        Me.PanelContenido.Controls.Add(Me.GroupBox2)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 82)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1128, 396)
        Me.PanelContenido.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkEstadoRealizado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtOperacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 209)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'chkEstadoRealizado
        '
        Me.chkEstadoRealizado.AutoSize = True
        Me.chkEstadoRealizado.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstadoRealizado.ForeColor = System.Drawing.Color.White
        Me.chkEstadoRealizado.Location = New System.Drawing.Point(203, 138)
        Me.chkEstadoRealizado.Name = "chkEstadoRealizado"
        Me.chkEstadoRealizado.Size = New System.Drawing.Size(129, 33)
        Me.chkEstadoRealizado.TabIndex = 50
        Me.chkEstadoRealizado.Text = "Realizado"
        Me.chkEstadoRealizado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(63, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 28)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Cambiar estado a:"
        '
        'txtOperacion
        '
        Me.txtOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperacion.Location = New System.Drawing.Point(107, 48)
        Me.txtOperacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.ReadOnly = True
        Me.txtOperacion.Size = New System.Drawing.Size(236, 30)
        Me.txtOperacion.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 28)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Operación:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(407, 339)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(230, 45)
        Me.btnActualizar.TabIndex = 51
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 28)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Número ID cliente:"
        '
        'txtNumeroID
        '
        Me.txtNumeroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroID.Location = New System.Drawing.Point(129, 52)
        Me.txtNumeroID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroID.Name = "txtNumeroID"
        Me.txtNumeroID.ReadOnly = True
        Me.txtNumeroID.Size = New System.Drawing.Size(236, 30)
        Me.txtNumeroID.TabIndex = 45
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
        Me.PanelDatosCliente.Location = New System.Drawing.Point(531, 53)
        Me.PanelDatosCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelDatosCliente.Name = "PanelDatosCliente"
        Me.PanelDatosCliente.Size = New System.Drawing.Size(537, 33)
        Me.PanelDatosCliente.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(19, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Nombre completo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(19, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Teléfono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(223, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Ref. dirección"
        '
        'txtReferenciasDirec
        '
        Me.txtReferenciasDirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciasDirec.Location = New System.Drawing.Point(221, 129)
        Me.txtReferenciasDirec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReferenciasDirec.Multiline = True
        Me.txtReferenciasDirec.Name = "txtReferenciasDirec"
        Me.txtReferenciasDirec.ReadOnly = True
        Me.txtReferenciasDirec.Size = New System.Drawing.Size(308, 75)
        Me.txtReferenciasDirec.TabIndex = 12
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(23, 57)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(429, 30)
        Me.txtNombreCompleto.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(20, 127)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(184, 30)
        Me.txtTelefono.TabIndex = 11
        '
        'btnVerDatoCliente
        '
        Me.btnVerDatoCliente.BackColor = System.Drawing.Color.Silver
        Me.btnVerDatoCliente.Location = New System.Drawing.Point(531, 16)
        Me.btnVerDatoCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVerDatoCliente.Name = "btnVerDatoCliente"
        Me.btnVerDatoCliente.Size = New System.Drawing.Size(236, 30)
        Me.btnVerDatoCliente.TabIndex = 43
        Me.btnVerDatoCliente.Text = "Ver datos cliente"
        Me.btnVerDatoCliente.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbAn)
        Me.GroupBox2.Controls.Add(Me.cmbEr)
        Me.GroupBox2.Controls.Add(Me.chkCambioEqui)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(531, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 209)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 28)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Detalles"
        '
        'chkCambioEqui
        '
        Me.chkCambioEqui.AutoSize = True
        Me.chkCambioEqui.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCambioEqui.ForeColor = System.Drawing.Color.White
        Me.chkCambioEqui.Location = New System.Drawing.Point(49, 52)
        Me.chkCambioEqui.Name = "chkCambioEqui"
        Me.chkCambioEqui.Size = New System.Drawing.Size(302, 32)
        Me.chkCambioEqui.TabIndex = 49
        Me.chkCambioEqui.Text = "Se requirio cambio de equipo"
        Me.chkCambioEqui.UseVisualStyleBackColor = True
        '
        'cmbEr
        '
        Me.cmbEr.Enabled = False
        Me.cmbEr.Font = New System.Drawing.Font("Fugaz One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEr.FormattingEnabled = True
        Me.cmbEr.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbEr.Location = New System.Drawing.Point(112, 147)
        Me.cmbEr.Name = "cmbEr"
        Me.cmbEr.Size = New System.Drawing.Size(88, 30)
        Me.cmbEr.TabIndex = 50
        '
        'cmbAn
        '
        Me.cmbAn.Enabled = False
        Me.cmbAn.Font = New System.Drawing.Font("Fugaz One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAn.FormattingEnabled = True
        Me.cmbAn.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbAn.Location = New System.Drawing.Point(261, 147)
        Me.cmbAn.Name = "cmbAn"
        Me.cmbAn.Size = New System.Drawing.Size(88, 30)
        Me.cmbAn.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 28)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Enrutadores"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(216, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 28)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Antenas"
        '
        'ActualizarTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 478)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizarTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActualizarTicket"
        Me.PanelOpciones.ResumeLayout(False)
        Me.PanelOpciones.PerformLayout()
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelDatosCliente.ResumeLayout(False)
        Me.PanelDatosCliente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelDatosCliente As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtReferenciasDirec As TextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnVerDatoCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOperacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkEstadoRealizado As CheckBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbAn As ComboBox
    Friend WithEvents cmbEr As ComboBox
    Friend WithEvents chkCambioEqui As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents TimerOcultar As Timer
End Class
