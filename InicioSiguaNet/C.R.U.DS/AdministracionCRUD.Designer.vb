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
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPlanesInter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSectores = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCrudClientes = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
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
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1384, 55)
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
        Me.Button1.Location = New System.Drawing.Point(1329, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 42)
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1384, 128)
        Me.Panel1.TabIndex = 22
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Location = New System.Drawing.Point(291, 62)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(187, 53)
        Me.BtnClientes.TabIndex = 30
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'btnFacturas
        '
        Me.btnFacturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFacturas.ForeColor = System.Drawing.Color.White
        Me.btnFacturas.Location = New System.Drawing.Point(675, 60)
        Me.btnFacturas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(180, 53)
        Me.btnFacturas.TabIndex = 28
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(860, 60)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(191, 54)
        Me.btnAdmin.TabIndex = 29
        Me.btnAdmin.Text = "Administración"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestionTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionTickets.ForeColor = System.Drawing.Color.White
        Me.btnGestionTickets.Location = New System.Drawing.Point(485, 62)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(183, 53)
        Me.btnGestionTickets.TabIndex = 27
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnCrudClientes)
        Me.Panel2.Controls.Add(Me.btnCerrarSesion)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnPlanesInter)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnSectores)
        Me.Panel2.Controls.Add(Me.btnEmpleados)
        Me.Panel2.Controls.Add(Me.btnVehiculos)
        Me.Panel2.Controls.Add(Me.btnInventario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 128)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1384, 629)
        Me.Panel2.TabIndex = 23
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(1152, 579)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(173, 39)
        Me.btnCerrarSesion.TabIndex = 10
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1059, 115)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 78)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Paquetes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "internet"
        '
        'btnPlanesInter
        '
        Me.btnPlanesInter.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Sectores
        Me.btnPlanesInter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlanesInter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlanesInter.Location = New System.Drawing.Point(891, 95)
        Me.btnPlanesInter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlanesInter.Name = "btnPlanesInter"
        Me.btnPlanesInter.Size = New System.Drawing.Size(160, 145)
        Me.btnPlanesInter.TabIndex = 8
        Me.btnPlanesInter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1059, 385)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 39)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sectores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(745, 257)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Personal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(398, 376)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vehiculos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(398, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inventario"
        '
        'btnSectores
        '
        Me.btnSectores.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Sectores
        Me.btnSectores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSectores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSectores.Location = New System.Drawing.Point(891, 331)
        Me.btnSectores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSectores.Name = "btnSectores"
        Me.btnSectores.Size = New System.Drawing.Size(160, 145)
        Me.btnSectores.TabIndex = 3
        Me.btnSectores.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Personal
        Me.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmpleados.Location = New System.Drawing.Point(577, 208)
        Me.btnEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(160, 151)
        Me.btnEmpleados.TabIndex = 2
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnVehiculos
        '
        Me.btnVehiculos.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.RecursosMotores
        Me.btnVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVehiculos.Location = New System.Drawing.Point(230, 329)
        Me.btnVehiculos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(160, 145)
        Me.btnVehiculos.TabIndex = 1
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Inventario
        Me.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventario.Location = New System.Drawing.Point(230, 97)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(160, 143)
        Me.btnInventario.TabIndex = 0
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(745, 494)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 39)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Clientes"
        '
        'btnCrudClientes
        '
        Me.btnCrudClientes.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.Personal
        Me.btnCrudClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCrudClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrudClientes.Location = New System.Drawing.Point(577, 445)
        Me.btnCrudClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrudClientes.Name = "btnCrudClientes"
        Me.btnCrudClientes.Size = New System.Drawing.Size(160, 151)
        Me.btnCrudClientes.TabIndex = 11
        Me.btnCrudClientes.UseVisualStyleBackColor = True
        '
        'AdministracionCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 757)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPlanesInter As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCrudClientes As Button
End Class
