<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionTickets))
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGestionar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.btnAvanzarMes = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelOpciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.Panel1)
        Me.PanelOpciones.Controls.Add(Me.btnGestionar)
        Me.PanelOpciones.Controls.Add(Me.btnActualizar)
        Me.PanelOpciones.Controls.Add(Me.BtnClientes)
        Me.PanelOpciones.Controls.Add(Me.btnInventario)
        Me.PanelOpciones.Controls.Add(Me.btnFacturas)
        Me.PanelOpciones.Controls.Add(Me.btnGestionTickets)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1033, 104)
        Me.PanelOpciones.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 41)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Gestión de tickets"
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
        Me.btnCerrar.Location = New System.Drawing.Point(989, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 34)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGestionar
        '
        Me.btnGestionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionar.ForeColor = System.Drawing.Color.White
        Me.btnGestionar.Location = New System.Drawing.Point(454, 108)
        Me.btnGestionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGestionar.Name = "btnGestionar"
        Me.btnGestionar.Size = New System.Drawing.Size(117, 28)
        Me.btnGestionar.TabIndex = 16
        Me.btnGestionar.Text = "Gestionar"
        Me.btnGestionar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(325, 108)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(117, 28)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Location = New System.Drawing.Point(230, 46)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(140, 43)
        Me.BtnClientes.TabIndex = 14
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'btnInventario
        '
        Me.btnInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventario.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Location = New System.Drawing.Point(657, 45)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(143, 44)
        Me.btnInventario.TabIndex = 11
        Me.btnInventario.Text = "Administración"
        Me.btnInventario.UseVisualStyleBackColor = False
        '
        'btnFacturas
        '
        Me.btnFacturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFacturas.ForeColor = System.Drawing.Color.White
        Me.btnFacturas.Location = New System.Drawing.Point(518, 45)
        Me.btnFacturas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(135, 43)
        Me.btnFacturas.TabIndex = 10
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestionTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionTickets.ForeColor = System.Drawing.Color.White
        Me.btnGestionTickets.Location = New System.Drawing.Point(376, 46)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(137, 43)
        Me.btnGestionTickets.TabIndex = 9
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = False
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.MenuGeneral
        Me.PanelContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenido.Controls.Add(Me.PictureBox1)
        Me.PanelContenido.Controls.Add(Me.lblMes)
        Me.PanelContenido.Controls.Add(Me.btnAvanzarMes)
        Me.PanelContenido.Controls.Add(Me.btnCerrarSesion)
        Me.PanelContenido.Controls.Add(Me.dgvTickets)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 104)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1033, 546)
        Me.PanelContenido.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.InicioSiguaNet.My.Resources.Resources.SIGUANET
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.BackColor = System.Drawing.Color.Transparent
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.Color.White
        Me.lblMes.Location = New System.Drawing.Point(800, 27)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(0, 16)
        Me.lblMes.TabIndex = 7
        '
        'btnAvanzarMes
        '
        Me.btnAvanzarMes.Location = New System.Drawing.Point(891, 18)
        Me.btnAvanzarMes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAvanzarMes.Name = "btnAvanzarMes"
        Me.btnAvanzarMes.Size = New System.Drawing.Size(130, 32)
        Me.btnAvanzarMes.TabIndex = 6
        Me.btnAvanzarMes.Text = "Avanzar Mes"
        Me.btnAvanzarMes.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(894, 495)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(130, 32)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Location = New System.Drawing.Point(44, 66)
        Me.dgvTickets.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.RowHeadersWidth = 51
        Me.dgvTickets.RowTemplate.Height = 24
        Me.dgvTickets.Size = New System.Drawing.Size(942, 414)
        Me.dgvTickets.TabIndex = 0
        '
        'TimerMostrar
        '
        '
        'TimerOcultar
        '
        '
        'GestionTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 650)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GestionTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionTickets"
        Me.PanelOpciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents BtnClientes As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnFacturas As Button
    Friend WithEvents btnGestionTickets As Button
    Friend WithEvents btnGestionar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents btnAvanzarMes As Button
    Friend WithEvents lblMes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
