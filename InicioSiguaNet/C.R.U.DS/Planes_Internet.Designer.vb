<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Planes_Internet
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
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.btnTablas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvPlanes = New System.Windows.Forms.DataGridView()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDPaquete = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombrePaquete = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvPlanes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIndividual
        '
        Me.btnIndividual.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnIndividual.Location = New System.Drawing.Point(427, 100)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(112, 71)
        Me.btnIndividual.TabIndex = 28
        Me.btnIndividual.Text = "Consulta ID"
        Me.btnIndividual.UseVisualStyleBackColor = False
        '
        'btnTablas
        '
        Me.btnTablas.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnTablas.Location = New System.Drawing.Point(427, 27)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(112, 67)
        Me.btnTablas.TabIndex = 26
        Me.btnTablas.Text = "Consulta Tablas"
        Me.btnTablas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(14, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Velocidad:"
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnInicio.Location = New System.Drawing.Point(427, 504)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(112, 41)
        Me.btnInicio.TabIndex = 32
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnModificar.Location = New System.Drawing.Point(427, 219)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(112, 32)
        Me.btnModificar.TabIndex = 30
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnNuevo.Location = New System.Drawing.Point(427, 177)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 31)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'dgvPlanes
        '
        Me.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanes.Location = New System.Drawing.Point(32, 320)
        Me.dgvPlanes.Name = "dgvPlanes"
        Me.dgvPlanes.RowHeadersWidth = 51
        Me.dgvPlanes.RowTemplate.Height = 24
        Me.dgvPlanes.Size = New System.Drawing.Size(507, 166)
        Me.dgvPlanes.TabIndex = 35
        '
        'txtVelocidad
        '
        Me.txtVelocidad.Location = New System.Drawing.Point(163, 140)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(100, 28)
        Me.txtVelocidad.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(14, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre:"
        '
        'txtIDPaquete
        '
        Me.txtIDPaquete.Location = New System.Drawing.Point(163, 46)
        Me.txtIDPaquete.Name = "txtIDPaquete"
        Me.txtIDPaquete.Size = New System.Drawing.Size(100, 28)
        Me.txtIDPaquete.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "ID Paquete:"
        '
        'txtNombrePaquete
        '
        Me.txtNombrePaquete.Location = New System.Drawing.Point(163, 98)
        Me.txtNombrePaquete.Name = "txtNombrePaquete"
        Me.txtNombrePaquete.Size = New System.Drawing.Size(100, 28)
        Me.txtNombrePaquete.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(14, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 24)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(163, 191)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 28)
        Me.txtPrecio.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(14, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Consulta por ID:"
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(163, 240)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(100, 28)
        Me.txtIDCliente.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtIDPaquete)
        Me.GroupBox1.Controls.Add(Me.txtIDCliente)
        Me.GroupBox1.Controls.Add(Me.txtNombrePaquete)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtVelocidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(58, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 290)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planes Internet"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(301, 504)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(101, 41)
        Me.btnLimpiar.TabIndex = 57
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Planes_Internet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.MenuGeneral
        Me.ClientSize = New System.Drawing.Size(574, 554)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnIndividual)
        Me.Controls.Add(Me.btnTablas)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvPlanes)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Planes_Internet"
        Me.Text = "Planes_Internet"
        CType(Me.dgvPlanes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIndividual As Button
    Friend WithEvents btnTablas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvPlanes As DataGridView
    Friend WithEvents txtVelocidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIDPaquete As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombrePaquete As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
End Class
