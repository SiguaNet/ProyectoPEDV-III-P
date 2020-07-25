<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCliente))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumeroID = New System.Windows.Forms.TextBox()
        Me.cmbPaquetes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSApellido = New System.Windows.Forms.TextBox()
        Me.txtRefDirec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumCasa = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbBarrios = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 29)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Número de identidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(385, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 29)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Referencia dirección"
        '
        'txtNumeroID
        '
        Me.txtNumeroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroID.Location = New System.Drawing.Point(45, 60)
        Me.txtNumeroID.Name = "txtNumeroID"
        Me.txtNumeroID.Size = New System.Drawing.Size(231, 30)
        Me.txtNumeroID.TabIndex = 28
        '
        'cmbPaquetes
        '
        Me.cmbPaquetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaquetes.FormattingEnabled = True
        Me.cmbPaquetes.Location = New System.Drawing.Point(40, 397)
        Me.cmbPaquetes.Name = "cmbPaquetes"
        Me.cmbPaquetes.Size = New System.Drawing.Size(293, 33)
        Me.cmbPaquetes.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(300, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 29)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Segundo apellido"
        '
        'txtSApellido
        '
        Me.txtSApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApellido.Location = New System.Drawing.Point(310, 163)
        Me.txtSApellido.Name = "txtSApellido"
        Me.txtSApellido.Size = New System.Drawing.Size(276, 30)
        Me.txtSApellido.TabIndex = 26
        '
        'txtRefDirec
        '
        Me.txtRefDirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefDirec.Location = New System.Drawing.Point(395, 385)
        Me.txtRefDirec.Multiline = True
        Me.txtRefDirec.Name = "txtRefDirec"
        Me.txtRefDirec.Size = New System.Drawing.Size(373, 96)
        Me.txtRefDirec.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Primer apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(331, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 29)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Número casa"
        '
        'txtPApellido
        '
        Me.txtPApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApellido.Location = New System.Drawing.Point(45, 163)
        Me.txtPApellido.Name = "txtPApellido"
        Me.txtPApellido.Size = New System.Drawing.Size(236, 30)
        Me.txtPApellido.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(40, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 29)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Planes de internet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(300, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nombres"
        '
        'txtNumCasa
        '
        Me.txtNumCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCasa.Location = New System.Drawing.Point(341, 271)
        Me.txtNumCasa.Name = "txtNumCasa"
        Me.txtNumCasa.Size = New System.Drawing.Size(99, 30)
        Me.txtNumCasa.TabIndex = 32
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(310, 60)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(276, 30)
        Me.txtNombres.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(488, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 29)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Barrio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 29)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(40, 264)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(236, 30)
        Me.txtTelefono.TabIndex = 30
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(687, 124)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(195, 63)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Registrar cliente"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbBarrios
        '
        Me.cmbBarrios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarrios.FormattingEnabled = True
        Me.cmbBarrios.Location = New System.Drawing.Point(498, 268)
        Me.cmbBarrios.Name = "cmbBarrios"
        Me.cmbBarrios.Size = New System.Drawing.Size(157, 33)
        Me.cmbBarrios.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.btnVolver)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(991, 56)
        Me.Panel3.TabIndex = 40
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
        Me.btnVolver.Size = New System.Drawing.Size(54, 50)
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
        Me.btnCerrar.Location = New System.Drawing.Point(936, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(43, 42)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.Label4)
        Me.PanelContenido.Controls.Add(Me.Label8)
        Me.PanelContenido.Controls.Add(Me.txtNumeroID)
        Me.PanelContenido.Controls.Add(Me.cmbPaquetes)
        Me.PanelContenido.Controls.Add(Me.Label3)
        Me.PanelContenido.Controls.Add(Me.txtSApellido)
        Me.PanelContenido.Controls.Add(Me.txtRefDirec)
        Me.PanelContenido.Controls.Add(Me.Label2)
        Me.PanelContenido.Controls.Add(Me.Label6)
        Me.PanelContenido.Controls.Add(Me.txtPApellido)
        Me.PanelContenido.Controls.Add(Me.Label9)
        Me.PanelContenido.Controls.Add(Me.Label1)
        Me.PanelContenido.Controls.Add(Me.txtNumCasa)
        Me.PanelContenido.Controls.Add(Me.txtNombres)
        Me.PanelContenido.Controls.Add(Me.Label7)
        Me.PanelContenido.Controls.Add(Me.Label5)
        Me.PanelContenido.Controls.Add(Me.txtTelefono)
        Me.PanelContenido.Controls.Add(Me.btnAgregar)
        Me.PanelContenido.Controls.Add(Me.cmbBarrios)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 56)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(991, 543)
        Me.PanelContenido.TabIndex = 41
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 599)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarCliente"
        Me.Panel3.ResumeLayout(False)
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumeroID As TextBox
    Friend WithEvents cmbPaquetes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSApellido As TextBox
    Friend WithEvents txtRefDirec As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPApellido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumCasa As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbBarrios As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelContenido As Panel
End Class
