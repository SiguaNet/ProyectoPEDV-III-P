<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioGestion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerDatoCliente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtReferenciasDirec = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.btnTickets = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnPaquete = New System.Windows.Forms.Button()
        Me.txtIdCli = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Identidad cliente"
        '
        'btnVerDatoCliente
        '
        Me.btnVerDatoCliente.Location = New System.Drawing.Point(35, 108)
        Me.btnVerDatoCliente.Name = "btnVerDatoCliente"
        Me.btnVerDatoCliente.Size = New System.Drawing.Size(236, 29)
        Me.btnVerDatoCliente.TabIndex = 11
        Me.btnVerDatoCliente.Text = "Ver datos cliente"
        Me.btnVerDatoCliente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.txtReferenciasDirec)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtNombreCompleto)
        Me.Panel1.Location = New System.Drawing.Point(35, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 170)
        Me.Panel1.TabIndex = 12
        '
        'txtReferenciasDirec
        '
        Me.txtReferenciasDirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciasDirec.Location = New System.Drawing.Point(251, 81)
        Me.txtReferenciasDirec.Multiline = True
        Me.txtReferenciasDirec.Name = "txtReferenciasDirec"
        Me.txtReferenciasDirec.Size = New System.Drawing.Size(308, 76)
        Me.txtReferenciasDirec.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(39, 81)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(184, 30)
        Me.txtTelefono.TabIndex = 5
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(57, 27)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(429, 30)
        Me.txtNombreCompleto.TabIndex = 3
        '
        'btnTickets
        '
        Me.btnTickets.Location = New System.Drawing.Point(682, 143)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Size = New System.Drawing.Size(265, 47)
        Me.btnTickets.TabIndex = 10
        Me.btnTickets.Text = "Tickets cliente"
        Me.btnTickets.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(682, 17)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(265, 45)
        Me.btnGenerar.TabIndex = 9
        Me.btnGenerar.Text = "Generar nuevo ticket"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnPaquete
        '
        Me.btnPaquete.Location = New System.Drawing.Point(682, 77)
        Me.btnPaquete.Name = "btnPaquete"
        Me.btnPaquete.Size = New System.Drawing.Size(265, 45)
        Me.btnPaquete.TabIndex = 8
        Me.btnPaquete.Text = "Actualizar paquete de internet"
        Me.btnPaquete.UseVisualStyleBackColor = True
        '
        'txtIdCli
        '
        Me.txtIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCli.Location = New System.Drawing.Point(200, 55)
        Me.txtIdCli.Name = "txtIdCli"
        Me.txtIdCli.Size = New System.Drawing.Size(255, 30)
        Me.txtIdCli.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnVolver)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(990, 70)
        Me.Panel3.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnVerDatoCliente)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnPaquete)
        Me.Panel2.Controls.Add(Me.btnGenerar)
        Me.Panel2.Controls.Add(Me.txtIdCli)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btnTickets)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(990, 340)
        Me.Panel2.TabIndex = 18
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
        Me.btnCerrar.Location = New System.Drawing.Point(931, 15)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 45)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'InicioGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 410)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InicioGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioGestion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerDatoCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtReferenciasDirec As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents btnTickets As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnPaquete As Button
    Friend WithEvents txtIdCli As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel2 As Panel
End Class
