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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSiguaNet))
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.DbgClientes = New System.Windows.Forms.DataGridView()
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnRecursos = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnEstadoFinanciero = New System.Windows.Forms.Button()
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DbgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOpciones.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(885, 515)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(130, 32)
        Me.btnCerrarSesion.TabIndex = 4
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'DbgClientes
        '
        Me.DbgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbgClientes.Location = New System.Drawing.Point(25, 105)
        Me.DbgClientes.Name = "DbgClientes"
        Me.DbgClientes.RowHeadersWidth = 51
        Me.DbgClientes.Size = New System.Drawing.Size(967, 388)
        Me.DbgClientes.TabIndex = 7
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.Panel3)
        Me.PanelOpciones.Controls.Add(Me.BtnClientes)
        Me.PanelOpciones.Controls.Add(Me.btnRecursos)
        Me.PanelOpciones.Controls.Add(Me.btnPersonal)
        Me.PanelOpciones.Controls.Add(Me.btnInventario)
        Me.PanelOpciones.Controls.Add(Me.btnEstadoFinanciero)
        Me.PanelOpciones.Controls.Add(Me.btnGestionTickets)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1016, 92)
        Me.PanelOpciones.TabIndex = 21
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(55, 47)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(143, 45)
        Me.BtnClientes.TabIndex = 27
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'btnRecursos
        '
        Me.btnRecursos.Location = New System.Drawing.Point(791, 47)
        Me.btnRecursos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRecursos.Name = "btnRecursos"
        Me.btnRecursos.Size = New System.Drawing.Size(143, 45)
        Me.btnRecursos.TabIndex = 26
        Me.btnRecursos.Text = "Recursos"
        Me.btnRecursos.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(644, 47)
        Me.btnPersonal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(143, 45)
        Me.btnPersonal.TabIndex = 25
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Location = New System.Drawing.Point(497, 47)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(143, 45)
        Me.btnInventario.TabIndex = 24
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnEstadoFinanciero
        '
        Me.btnEstadoFinanciero.Location = New System.Drawing.Point(350, 47)
        Me.btnEstadoFinanciero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEstadoFinanciero.Name = "btnEstadoFinanciero"
        Me.btnEstadoFinanciero.Size = New System.Drawing.Size(143, 45)
        Me.btnEstadoFinanciero.TabIndex = 23
        Me.btnEstadoFinanciero.Text = "Estado financiero"
        Me.btnEstadoFinanciero.UseVisualStyleBackColor = True
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.Location = New System.Drawing.Point(203, 47)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(143, 45)
        Me.btnGestionTickets.TabIndex = 22
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = True
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.DbgClientes)
        Me.PanelContenido.Controls.Add(Me.btnCerrarSesion)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 92)
        Me.PanelContenido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1016, 553)
        Me.PanelContenido.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(0, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1016, 39)
        Me.Panel3.TabIndex = 28
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
        Me.Button1.Location = New System.Drawing.Point(979, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'InicioSiguaNet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 645)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "InicioSiguaNet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DbgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOpciones.ResumeLayout(False)
        Me.PanelContenido.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents DbgClientes As DataGridView
    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents btnRecursos As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnEstadoFinanciero As Button
    Friend WithEvents btnGestionTickets As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
