<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionTickets))
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGestionar = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnRecursos = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnEstadoFinanciero = New System.Windows.Forms.Button()
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.btnAvanzarMes = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelOpciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.btnRealizar)
        Me.PanelOpciones.Controls.Add(Me.Panel1)
        Me.PanelOpciones.Controls.Add(Me.btnGestionar)
        Me.PanelOpciones.Controls.Add(Me.btnPersonal)
        Me.PanelOpciones.Controls.Add(Me.btnActualizar)
        Me.PanelOpciones.Controls.Add(Me.BtnClientes)
        Me.PanelOpciones.Controls.Add(Me.btnRecursos)
        Me.PanelOpciones.Controls.Add(Me.btnInventario)
        Me.PanelOpciones.Controls.Add(Me.btnEstadoFinanciero)
        Me.PanelOpciones.Controls.Add(Me.btnGestionTickets)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1377, 128)
        Me.PanelOpciones.TabIndex = 0
        '
        'btnRealizar
        '
        Me.btnRealizar.Location = New System.Drawing.Point(535, 135)
        Me.btnRealizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(176, 34)
        Me.btnRealizar.TabIndex = 19
        Me.btnRealizar.Text = "Realizar"
        Me.btnRealizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1377, 50)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1319, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(43, 42)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGestionar
        '
        Me.btnGestionar.Location = New System.Drawing.Point(363, 135)
        Me.btnGestionar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionar.Name = "btnGestionar"
        Me.btnGestionar.Size = New System.Drawing.Size(156, 34)
        Me.btnGestionar.TabIndex = 16
        Me.btnGestionar.Text = "Gestionar"
        Me.btnGestionar.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(849, 62)
        Me.btnPersonal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(191, 54)
        Me.btnPersonal.TabIndex = 12
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(191, 135)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(156, 34)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(83, 63)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(187, 53)
        Me.BtnClientes.TabIndex = 14
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'btnRecursos
        '
        Me.btnRecursos.Location = New System.Drawing.Point(1045, 62)
        Me.btnRecursos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRecursos.Name = "btnRecursos"
        Me.btnRecursos.Size = New System.Drawing.Size(191, 55)
        Me.btnRecursos.TabIndex = 13
        Me.btnRecursos.Text = "Recursos"
        Me.btnRecursos.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Location = New System.Drawing.Point(652, 62)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(191, 54)
        Me.btnInventario.TabIndex = 11
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnEstadoFinanciero
        '
        Me.btnEstadoFinanciero.Location = New System.Drawing.Point(467, 62)
        Me.btnEstadoFinanciero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEstadoFinanciero.Name = "btnEstadoFinanciero"
        Me.btnEstadoFinanciero.Size = New System.Drawing.Size(180, 53)
        Me.btnEstadoFinanciero.TabIndex = 10
        Me.btnEstadoFinanciero.Text = "Estado financiero"
        Me.btnEstadoFinanciero.UseVisualStyleBackColor = True
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.Location = New System.Drawing.Point(277, 63)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(183, 53)
        Me.btnGestionTickets.TabIndex = 9
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = True
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.lblMes)
        Me.PanelContenido.Controls.Add(Me.btnAvanzarMes)
        Me.PanelContenido.Controls.Add(Me.btnCerrarSesion)
        Me.PanelContenido.Controls.Add(Me.dgvTickets)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 128)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1377, 672)
        Me.PanelContenido.TabIndex = 1
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.BackColor = System.Drawing.Color.Transparent
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.Color.White
        Me.lblMes.Location = New System.Drawing.Point(1067, 33)
        Me.lblMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(0, 20)
        Me.lblMes.TabIndex = 7
        '
        'btnAvanzarMes
        '
        Me.btnAvanzarMes.Location = New System.Drawing.Point(1188, 22)
        Me.btnAvanzarMes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAvanzarMes.Name = "btnAvanzarMes"
        Me.btnAvanzarMes.Size = New System.Drawing.Size(173, 39)
        Me.btnAvanzarMes.TabIndex = 6
        Me.btnAvanzarMes.Text = "Avanzar Mes"
        Me.btnAvanzarMes.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(1192, 609)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(173, 39)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Location = New System.Drawing.Point(59, 81)
        Me.dgvTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.RowHeadersWidth = 51
        Me.dgvTickets.RowTemplate.Height = 24
        Me.dgvTickets.Size = New System.Drawing.Size(1256, 510)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1377, 800)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestionTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionTickets"
        Me.PanelOpciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents BtnClientes As Button
    Friend WithEvents btnRecursos As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnEstadoFinanciero As Button
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
    Friend WithEvents btnRealizar As Button
End Class
