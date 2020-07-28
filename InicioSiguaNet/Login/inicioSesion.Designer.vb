<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicioSesion))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnMostrarContra = New System.Windows.Forms.Button()
        Me.btnOcultarContra = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOlvideContra = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(183, 194)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(275, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(183, 298)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(275, 20)
        Me.txtContrasena.TabIndex = 3
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(270, 404)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(100, 39)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar Sesion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnMostrarContra
        '
        Me.btnMostrarContra.BackColor = System.Drawing.Color.White
        Me.btnMostrarContra.FlatAppearance.BorderSize = 0
        Me.btnMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarContra.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMostrarContra.Image = CType(resources.GetObject("btnMostrarContra.Image"), System.Drawing.Image)
        Me.btnMostrarContra.Location = New System.Drawing.Point(467, 297)
        Me.btnMostrarContra.Name = "btnMostrarContra"
        Me.btnMostrarContra.Size = New System.Drawing.Size(29, 20)
        Me.btnMostrarContra.TabIndex = 7
        Me.btnMostrarContra.UseVisualStyleBackColor = False
        '
        'btnOcultarContra
        '
        Me.btnOcultarContra.FlatAppearance.BorderSize = 0
        Me.btnOcultarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultarContra.Image = CType(resources.GetObject("btnOcultarContra.Image"), System.Drawing.Image)
        Me.btnOcultarContra.Location = New System.Drawing.Point(467, 295)
        Me.btnOcultarContra.Name = "btnOcultarContra"
        Me.btnOcultarContra.Size = New System.Drawing.Size(29, 24)
        Me.btnOcultarContra.TabIndex = 8
        Me.btnOcultarContra.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblOlvideContra
        '
        Me.lblOlvideContra.AutoSize = True
        Me.lblOlvideContra.BackColor = System.Drawing.Color.Transparent
        Me.lblOlvideContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlvideContra.LinkColor = System.Drawing.Color.White
        Me.lblOlvideContra.Location = New System.Drawing.Point(263, 363)
        Me.lblOlvideContra.Name = "lblOlvideContra"
        Me.lblOlvideContra.Size = New System.Drawing.Size(122, 15)
        Me.lblOlvideContra.TabIndex = 9
        Me.lblOlvideContra.TabStop = True
        Me.lblOlvideContra.Text = "Olvide mi contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(266, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Login"
        '
        'inicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(632, 468)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOlvideContra)
        Me.Controls.Add(Me.btnMostrarContra)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnOcultarContra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inicioSesion"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnMostrarContra As Button
    Friend WithEvents btnOcultarContra As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblOlvideContra As LinkLabel
    Friend WithEvents Label1 As Label
End Class
