<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasTodas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturasTodas))
        Me.dgvFactuTodas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnRecursos = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnEstadoFinanciero = New System.Windows.Forms.Button()
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvFactuTodas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOpciones.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFactuTodas
        '
        Me.dgvFactuTodas.AllowUserToAddRows = False
        Me.dgvFactuTodas.AllowUserToDeleteRows = False
        Me.dgvFactuTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactuTodas.Location = New System.Drawing.Point(72, 189)
        Me.dgvFactuTodas.Name = "dgvFactuTodas"
        Me.dgvFactuTodas.ReadOnly = True
        Me.dgvFactuTodas.Size = New System.Drawing.Size(918, 431)
        Me.dgvFactuTodas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Facturas Procesadas"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(915, 152)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.dgvFactuTodas)
        Me.Panel1.Controls.Add(Me.btnActualizar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 650)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InicioSiguaNet.My.Resources.Resources.SIGUANET
        Me.PictureBox1.Location = New System.Drawing.Point(0, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.Button2)
        Me.PanelOpciones.Controls.Add(Me.btnPersonal)
        Me.PanelOpciones.Controls.Add(Me.BtnClientes)
        Me.PanelOpciones.Controls.Add(Me.btnRecursos)
        Me.PanelOpciones.Controls.Add(Me.btnInventario)
        Me.PanelOpciones.Controls.Add(Me.btnEstadoFinanciero)
        Me.PanelOpciones.Controls.Add(Me.btnGestionTickets)
        Me.PanelOpciones.Controls.Add(Me.Panel3)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1033, 146)
        Me.PanelOpciones.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(449, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPersonal.ForeColor = System.Drawing.Color.White
        Me.btnPersonal.Location = New System.Drawing.Point(700, 47)
        Me.btnPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(143, 44)
        Me.btnPersonal.TabIndex = 24
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Location = New System.Drawing.Point(125, 48)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(140, 43)
        Me.BtnClientes.TabIndex = 26
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'btnRecursos
        '
        Me.btnRecursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecursos.ForeColor = System.Drawing.Color.White
        Me.btnRecursos.Location = New System.Drawing.Point(847, 47)
        Me.btnRecursos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecursos.Name = "btnRecursos"
        Me.btnRecursos.Size = New System.Drawing.Size(143, 45)
        Me.btnRecursos.TabIndex = 25
        Me.btnRecursos.Text = "Recursos"
        Me.btnRecursos.UseVisualStyleBackColor = False
        '
        'btnInventario
        '
        Me.btnInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventario.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Location = New System.Drawing.Point(552, 47)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(143, 44)
        Me.btnInventario.TabIndex = 23
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = False
        '
        'btnEstadoFinanciero
        '
        Me.btnEstadoFinanciero.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEstadoFinanciero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEstadoFinanciero.ForeColor = System.Drawing.Color.White
        Me.btnEstadoFinanciero.Location = New System.Drawing.Point(413, 47)
        Me.btnEstadoFinanciero.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEstadoFinanciero.Name = "btnEstadoFinanciero"
        Me.btnEstadoFinanciero.Size = New System.Drawing.Size(135, 43)
        Me.btnEstadoFinanciero.TabIndex = 22
        Me.btnEstadoFinanciero.Text = "Pago de Facturas"
        Me.btnEstadoFinanciero.UseVisualStyleBackColor = False
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestionTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionTickets.ForeColor = System.Drawing.Color.White
        Me.btnGestionTickets.Location = New System.Drawing.Point(271, 48)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(137, 43)
        Me.btnGestionTickets.TabIndex = 21
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1033, 42)
        Me.Panel3.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(999, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TimerMostrar
        '
        '
        'TimerOcultar
        '
        '
        'FacturasTodas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 650)
        Me.Controls.Add(Me.PanelOpciones)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FacturasTodas"
        Me.Text = "FacturasTodas"
        CType(Me.dgvFactuTodas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOpciones.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvFactuTodas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPersonal As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents btnRecursos As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnEstadoFinanciero As Button
    Friend WithEvents btnGestionTickets As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents Button2 As Button
End Class
