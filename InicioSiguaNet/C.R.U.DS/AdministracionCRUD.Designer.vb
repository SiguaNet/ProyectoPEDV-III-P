<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministracionCRUD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministracionCRUD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSectores = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administración"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1038, 45)
        Me.Panel3.TabIndex = 21
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
        Me.Button1.Location = New System.Drawing.Point(997, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClientes)
        Me.Panel1.Controls.Add(Me.btnFacturas)
        Me.Panel1.Controls.Add(Me.btnAdmin)
        Me.Panel1.Controls.Add(Me.btnGestionTickets)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 104)
        Me.Panel1.TabIndex = 22
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Location = New System.Drawing.Point(218, 50)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(140, 43)
        Me.BtnClientes.TabIndex = 30
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'btnFacturas
        '
        Me.btnFacturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFacturas.ForeColor = System.Drawing.Color.White
        Me.btnFacturas.Location = New System.Drawing.Point(506, 49)
        Me.btnFacturas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(135, 43)
        Me.btnFacturas.TabIndex = 28
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(645, 49)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(143, 44)
        Me.btnAdmin.TabIndex = 29
        Me.btnAdmin.Text = "Administración"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestionTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionTickets.ForeColor = System.Drawing.Color.White
        Me.btnGestionTickets.Location = New System.Drawing.Point(364, 50)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(137, 43)
        Me.btnGestionTickets.TabIndex = 27
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnSectores)
        Me.Panel2.Controls.Add(Me.btnEmpleados)
        Me.Panel2.Controls.Add(Me.btnVehiculos)
        Me.Panel2.Controls.Add(Me.btnInventario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1038, 511)
        Me.Panel2.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(720, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sectores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(720, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Personal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(334, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vehiculos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(334, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inventario"
        '
        'btnSectores
        '
        Me.btnSectores.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Sectores
        Me.btnSectores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSectores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSectores.Location = New System.Drawing.Point(594, 287)
        Me.btnSectores.Name = "btnSectores"
        Me.btnSectores.Size = New System.Drawing.Size(120, 118)
        Me.btnSectores.TabIndex = 3
        Me.btnSectores.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Personal
        Me.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmpleados.Location = New System.Drawing.Point(594, 98)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(120, 123)
        Me.btnEmpleados.TabIndex = 2
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnVehiculos
        '
        Me.btnVehiculos.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.RecursosMotores
        Me.btnVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVehiculos.Location = New System.Drawing.Point(208, 287)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(120, 118)
        Me.btnVehiculos.TabIndex = 1
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Inventario
        Me.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventario.Location = New System.Drawing.Point(208, 98)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(120, 116)
        Me.btnInventario.TabIndex = 0
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'AdministracionCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 615)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdministracionCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdministracionCRUD"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents btnFacturas As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnGestionTickets As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSectores As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
