<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealizarTickets))
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPendientes = New System.Windows.Forms.Button()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRealizados = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvRealizados = New System.Windows.Forms.DataGridView()
        Me.dgvPendientes = New System.Windows.Forms.DataGridView()
        Me.PanelOpciones.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRealizados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.Label1)
        Me.PanelOpciones.Controls.Add(Me.btnPendientes)
        Me.PanelOpciones.Controls.Add(Me.PanelBotones)
        Me.PanelOpciones.Controls.Add(Me.btnRealizados)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1474, 147)
        Me.PanelOpciones.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filtrar por:"
        '
        'btnPendientes
        '
        Me.btnPendientes.Location = New System.Drawing.Point(440, 94)
        Me.btnPendientes.Name = "btnPendientes"
        Me.btnPendientes.Size = New System.Drawing.Size(181, 38)
        Me.btnPendientes.TabIndex = 2
        Me.btnPendientes.Text = "Pendientes"
        Me.btnPendientes.UseVisualStyleBackColor = True
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.Color.Black
        Me.PanelBotones.Controls.Add(Me.btnVolver)
        Me.PanelBotones.Controls.Add(Me.btnCerrar)
        Me.PanelBotones.Controls.Add(Me.Label2)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBotones.Location = New System.Drawing.Point(0, 0)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(1474, 75)
        Me.PanelBotones.TabIndex = 20
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
        Me.btnVolver.Location = New System.Drawing.Point(12, 2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(65, 65)
        Me.btnVolver.TabIndex = 21
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
        Me.btnCerrar.Location = New System.Drawing.Point(1417, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 45)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Realizar tickets"
        '
        'btnRealizados
        '
        Me.btnRealizados.Location = New System.Drawing.Point(207, 94)
        Me.btnRealizados.Name = "btnRealizados"
        Me.btnRealizados.Size = New System.Drawing.Size(181, 38)
        Me.btnRealizados.TabIndex = 1
        Me.btnRealizados.Text = "Realizados"
        Me.btnRealizados.UseVisualStyleBackColor = True
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.Panel1)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 147)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1474, 599)
        Me.PanelContenido.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.dgvRealizados)
        Me.Panel1.Controls.Add(Me.dgvPendientes)
        Me.Panel1.Location = New System.Drawing.Point(37, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1406, 571)
        Me.Panel1.TabIndex = 0
        '
        'dgvRealizados
        '
        Me.dgvRealizados.AllowUserToAddRows = False
        Me.dgvRealizados.AllowUserToDeleteRows = False
        Me.dgvRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRealizados.Location = New System.Drawing.Point(22, 22)
        Me.dgvRealizados.Name = "dgvRealizados"
        Me.dgvRealizados.ReadOnly = True
        Me.dgvRealizados.RowHeadersWidth = 51
        Me.dgvRealizados.RowTemplate.Height = 24
        Me.dgvRealizados.Size = New System.Drawing.Size(1363, 523)
        Me.dgvRealizados.TabIndex = 1
        Me.dgvRealizados.Visible = False
        '
        'dgvPendientes
        '
        Me.dgvPendientes.AllowUserToAddRows = False
        Me.dgvPendientes.AllowUserToDeleteRows = False
        Me.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendientes.Location = New System.Drawing.Point(22, 22)
        Me.dgvPendientes.Name = "dgvPendientes"
        Me.dgvPendientes.ReadOnly = True
        Me.dgvPendientes.RowHeadersWidth = 51
        Me.dgvPendientes.RowTemplate.Height = 24
        Me.dgvPendientes.Size = New System.Drawing.Size(1363, 516)
        Me.dgvPendientes.TabIndex = 0
        Me.dgvPendientes.Visible = False
        '
        'RealizarTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1474, 746)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealizarTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealzarTickets"
        Me.PanelOpciones.ResumeLayout(False)
        Me.PanelOpciones.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelBotones.PerformLayout()
        Me.PanelContenido.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvRealizados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPendientes As Button
    Friend WithEvents btnRealizados As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvRealizados As DataGridView
    Friend WithEvents dgvPendientes As DataGridView
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCerrar As Button
End Class
