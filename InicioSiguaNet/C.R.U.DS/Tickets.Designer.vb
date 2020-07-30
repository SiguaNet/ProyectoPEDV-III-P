<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tickets
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
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.txtIDTicket = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnTablas = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.cmbPersonal = New System.Windows.Forms.ComboBox()
        Me.cmbIDCliente = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(155, 261)
        Me.txtNotas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(212, 70)
        Me.txtNotas.TabIndex = 50
        '
        'txtIDTicket
        '
        Me.txtIDTicket.Location = New System.Drawing.Point(202, 41)
        Me.txtIDTicket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIDTicket.Name = "txtIDTicket"
        Me.txtIDTicket.Size = New System.Drawing.Size(100, 22)
        Me.txtIDTicket.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(311, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Identidad Cliente:"
        '
        'cmbPrioridad
        '
        Me.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrioridad.FormattingEnabled = True
        Me.cmbPrioridad.Items.AddRange(New Object() {"Baja", "Media", "Alta"})
        Me.cmbPrioridad.Location = New System.Drawing.Point(489, 180)
        Me.cmbPrioridad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPrioridad.Name = "cmbPrioridad"
        Me.cmbPrioridad.Size = New System.Drawing.Size(121, 24)
        Me.cmbPrioridad.TabIndex = 48
        '
        'cmbOperacion
        '
        Me.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Location = New System.Drawing.Point(181, 180)
        Me.cmbOperacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(121, 24)
        Me.cmbOperacion.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(345, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Prioridad:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Al dia", "En mora", "Eliminado"})
        Me.cmbEstado.Location = New System.Drawing.Point(181, 103)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 24)
        Me.cmbEstado.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(41, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(32, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 24)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "ID Ticket:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(34, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 24)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Notas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(345, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 24)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "ID Personal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(41, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 24)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "ID Operacion:"
        '
        'btnTodo
        '
        Me.btnTodo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnTodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTodo.Location = New System.Drawing.Point(642, 141)
        Me.btnTodo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(96, 63)
        Me.btnTodo.TabIndex = 63
        Me.btnTodo.Text = "Consulta Todo"
        Me.btnTodo.UseVisualStyleBackColor = False
        '
        'btnTablas
        '
        Me.btnTablas.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnTablas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTablas.Location = New System.Drawing.Point(642, 39)
        Me.btnTablas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(96, 70)
        Me.btnTablas.TabIndex = 62
        Me.btnTablas.Text = "Consulta Tablas"
        Me.btnTablas.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificar.Location = New System.Drawing.Point(642, 266)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 29)
        Me.btnModificar.TabIndex = 66
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNuevo.Location = New System.Drawing.Point(642, 217)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 32)
        Me.btnNuevo.TabIndex = 65
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(509, 543)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(101, 35)
        Me.btnLimpiar.TabIndex = 69
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInicio.Location = New System.Drawing.Point(637, 543)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(108, 35)
        Me.btnInicio.TabIndex = 67
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'dgvTickets
        '
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Location = New System.Drawing.Point(52, 352)
        Me.dgvTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.RowHeadersWidth = 51
        Me.dgvTickets.RowTemplate.Height = 24
        Me.dgvTickets.Size = New System.Drawing.Size(693, 150)
        Me.dgvTickets.TabIndex = 68
        '
        'cmbPersonal
        '
        Me.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPersonal.FormattingEnabled = True
        Me.cmbPersonal.Location = New System.Drawing.Point(489, 105)
        Me.cmbPersonal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPersonal.Name = "cmbPersonal"
        Me.cmbPersonal.Size = New System.Drawing.Size(121, 24)
        Me.cmbPersonal.TabIndex = 70
        '
        'cmbIDCliente
        '
        Me.cmbIDCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIDCliente.FormattingEnabled = True
        Me.cmbIDCliente.Location = New System.Drawing.Point(489, 41)
        Me.cmbIDCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbIDCliente.Name = "cmbIDCliente"
        Me.cmbIDCliente.Size = New System.Drawing.Size(121, 24)
        Me.cmbIDCliente.TabIndex = 71
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(642, 302)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 29)
        Me.btnEliminar.TabIndex = 72
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InicioSiguaNet.My.Resources.Resources.MenuGeneral
        Me.ClientSize = New System.Drawing.Size(800, 593)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.cmbIDCliente)
        Me.Controls.Add(Me.cmbPersonal)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.dgvTickets)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.btnTablas)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.txtIDTicket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPrioridad)
        Me.Controls.Add(Me.cmbOperacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tickets"
        Me.Text = "Tickets"
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNotas As TextBox
    Friend WithEvents txtIDTicket As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPrioridad As ComboBox
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnTodo As Button
    Friend WithEvents btnTablas As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents cmbPersonal As ComboBox
    Friend WithEvents cmbIDCliente As ComboBox
    Friend WithEvents btnEliminar As Button
End Class
