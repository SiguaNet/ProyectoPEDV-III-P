<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSiguaNet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSiguaNet))
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.DgvClientes = New System.Windows.Forms.DataGridView()
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOpciones.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(1160, 616)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(173, 39)
        Me.btnCerrarSesion.TabIndex = 4
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'DgvClientes
        '
        Me.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.Location = New System.Drawing.Point(149, 197)
        Me.DgvClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.RowHeadersWidth = 51
        Me.DgvClientes.Size = New System.Drawing.Size(1184, 413)
        Me.DgvClientes.TabIndex = 7
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.btnActualizar)
        Me.PanelOpciones.Controls.Add(Me.btnAgregar)
        Me.PanelOpciones.Controls.Add(Me.Panel3)
        Me.PanelOpciones.Controls.Add(Me.BtnClientes)
        Me.PanelOpciones.Controls.Add(Me.btnAdmin)
        Me.PanelOpciones.Controls.Add(Me.btnFacturas)
        Me.PanelOpciones.Controls.Add(Me.btnGestionTickets)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1355, 128)
        Me.PanelOpciones.TabIndex = 21
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(376, 133)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(136, 35)
        Me.btnActualizar.TabIndex = 32
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(241, 133)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 35)
        Me.btnAgregar.TabIndex = 29
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(0, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1355, 48)
        Me.Panel3.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Clientes"
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
        Me.Button1.Location = New System.Drawing.Point(1305, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Location = New System.Drawing.Point(279, 57)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(191, 55)
        Me.BtnClientes.TabIndex = 27
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(868, 57)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(191, 55)
        Me.btnAdmin.TabIndex = 24
        Me.btnAdmin.Text = "Administración"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnFacturas
        '
        Me.btnFacturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFacturas.ForeColor = System.Drawing.Color.White
        Me.btnFacturas.Location = New System.Drawing.Point(672, 57)
        Me.btnFacturas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(191, 55)
        Me.btnFacturas.TabIndex = 23
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestionTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionTickets.ForeColor = System.Drawing.Color.White
        Me.btnGestionTickets.Location = New System.Drawing.Point(476, 57)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(191, 55)
        Me.btnGestionTickets.TabIndex = 22
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = False
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.MenuGeneral
        Me.PanelContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenido.Controls.Add(Me.Label2)
        Me.PanelContenido.Controls.Add(Me.Label4)
        Me.PanelContenido.Controls.Add(Me.PictureBox1)
        Me.PanelContenido.Controls.Add(Me.DgvClientes)
        Me.PanelContenido.Controls.Add(Me.btnCerrarSesion)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 128)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1355, 666)
        Me.PanelContenido.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(519, 627)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(448, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Barrio San Miguel, Siguatepeque   Tel: 2773-1110"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(470, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(492, 36)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "¡La mayor velocidad, todo el tiempo!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.InicioSiguaNet.My.Resources.Resources.SIGUANET
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TimerMostrar
        '
        '
        'TimerOcultar
        '
        '
        'InicioSiguaNet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 794)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InicioSiguaNet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOpciones.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents DgvClientes As DataGridView
    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnFacturas As Button
    Friend WithEvents btnGestionTickets As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents btnAgregar As Button
End Class
