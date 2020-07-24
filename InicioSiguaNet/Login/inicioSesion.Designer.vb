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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnMostrarContra = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnOcultarContra = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOlvideContra = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(132, 136)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(132, 174)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(132, 210)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(100, 39)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar Sesion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnMostrarContra
        '
        Me.btnMostrarContra.FlatAppearance.BorderSize = 0
        Me.btnMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarContra.Image = CType(resources.GetObject("btnMostrarContra.Image"), System.Drawing.Image)
        Me.btnMostrarContra.Location = New System.Drawing.Point(247, 171)
        Me.btnMostrarContra.Name = "btnMostrarContra"
        Me.btnMostrarContra.Size = New System.Drawing.Size(40, 24)
        Me.btnMostrarContra.TabIndex = 7
        Me.btnMostrarContra.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(92, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 105)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnOcultarContra
        '
        Me.btnOcultarContra.FlatAppearance.BorderSize = 0
        Me.btnOcultarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultarContra.Image = CType(resources.GetObject("btnOcultarContra.Image"), System.Drawing.Image)
        Me.btnOcultarContra.Location = New System.Drawing.Point(247, 172)
        Me.btnOcultarContra.Name = "btnOcultarContra"
        Me.btnOcultarContra.Size = New System.Drawing.Size(40, 24)
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
        Me.lblOlvideContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlvideContra.Location = New System.Drawing.Point(110, 268)
        Me.lblOlvideContra.Name = "lblOlvideContra"
        Me.lblOlvideContra.Size = New System.Drawing.Size(122, 15)
        Me.lblOlvideContra.TabIndex = 9
        Me.lblOlvideContra.TabStop = True
        Me.lblOlvideContra.Text = "Olvide mi contraseña"
        '
        'inicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 301)
        Me.Controls.Add(Me.lblOlvideContra)
        Me.Controls.Add(Me.btnMostrarContra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOcultarContra)
        Me.Name = "inicioSesion"
        Me.Text = "inicioSesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMostrarContra As Button
    Friend WithEvents btnOcultarContra As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblOlvideContra As LinkLabel
End Class
