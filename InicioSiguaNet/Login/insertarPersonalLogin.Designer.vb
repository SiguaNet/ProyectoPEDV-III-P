<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class insertarPersonalLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(insertarPersonalLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerApe = New System.Windows.Forms.TextBox()
        Me.txtSegundoApell = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRefDireccion = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumCasa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbBarri = New System.Windows.Forms.ComboBox()
        Me.txtConfirmContra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumTel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.cmbIdVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(567, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(618, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(697, 41)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(166, 20)
        Me.txtIdentidad.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(697, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtPrimerApe
        '
        Me.txtPrimerApe.Location = New System.Drawing.Point(697, 104)
        Me.txtPrimerApe.Name = "txtPrimerApe"
        Me.txtPrimerApe.Size = New System.Drawing.Size(166, 20)
        Me.txtPrimerApe.TabIndex = 3
        '
        'txtSegundoApell
        '
        Me.txtSegundoApell.Location = New System.Drawing.Point(697, 140)
        Me.txtSegundoApell.Name = "txtSegundoApell"
        Me.txtSegundoApell.Size = New System.Drawing.Size(166, 20)
        Me.txtSegundoApell.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(583, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Primer Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(567, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Segundo Apellido"
        '
        'txtRefDireccion
        '
        Me.txtRefDireccion.Location = New System.Drawing.Point(697, 295)
        Me.txtRefDireccion.Multiline = True
        Me.txtRefDireccion.Name = "txtRefDireccion"
        Me.txtRefDireccion.Size = New System.Drawing.Size(166, 56)
        Me.txtRefDireccion.TabIndex = 9
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(697, 393)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(130, 20)
        Me.txtContrasena.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(620, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(606, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Contraseña"
        '
        'txtNumCasa
        '
        Me.txtNumCasa.Location = New System.Drawing.Point(697, 199)
        Me.txtNumCasa.Name = "txtNumCasa"
        Me.txtNumCasa.Size = New System.Drawing.Size(44, 20)
        Me.txtNumCasa.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(598, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Barrio/Sector"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(592, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Numero Casa"
        '
        'cmbBarri
        '
        Me.cmbBarri.FormattingEnabled = True
        Me.cmbBarri.Location = New System.Drawing.Point(697, 235)
        Me.cmbBarri.Name = "cmbBarri"
        Me.cmbBarri.Size = New System.Drawing.Size(166, 21)
        Me.cmbBarri.TabIndex = 7
        '
        'txtConfirmContra
        '
        Me.txtConfirmContra.Location = New System.Drawing.Point(697, 423)
        Me.txtConfirmContra.Name = "txtConfirmContra"
        Me.txtConfirmContra.Size = New System.Drawing.Size(130, 20)
        Me.txtConfirmContra.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(548, 427)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Confirmar Contraseña"
        '
        'txtNumTel
        '
        Me.txtNumTel.Location = New System.Drawing.Point(697, 170)
        Me.txtNumTel.Name = "txtNumTel"
        Me.txtNumTel.Size = New System.Drawing.Size(166, 20)
        Me.txtNumTel.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(572, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Numero Telefono"
        '
        'btnRegistar
        '
        Me.btnRegistar.Location = New System.Drawing.Point(680, 473)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(130, 46)
        Me.btnRegistar.TabIndex = 12
        Me.btnRegistar.Text = "Registar Usuario"
        Me.btnRegistar.UseVisualStyleBackColor = True
        '
        'cmbIdVehiculo
        '
        Me.cmbIdVehiculo.FormattingEnabled = True
        Me.cmbIdVehiculo.Location = New System.Drawing.Point(697, 265)
        Me.cmbIdVehiculo.Name = "cmbIdVehiculo"
        Me.cmbIdVehiculo.Size = New System.Drawing.Size(44, 21)
        Me.cmbIdVehiculo.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(609, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Id Vehiculo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(697, 361)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(166, 20)
        Me.txtCorreo.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(636, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Correo"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'insertarPersonalLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 541)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbIdVehiculo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnRegistar)
        Me.Controls.Add(Me.txtNumTel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtConfirmContra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbBarri)
        Me.Controls.Add(Me.txtRefDireccion)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumCasa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrimerApe)
        Me.Controls.Add(Me.txtSegundoApell)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "insertarPersonalLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "insertarPersonalLogin"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrimerApe As TextBox
    Friend WithEvents txtSegundoApell As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRefDireccion As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumCasa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbBarri As ComboBox
    Friend WithEvents txtConfirmContra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNumTel As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnRegistar As Button
    Friend WithEvents cmbIdVehiculo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
