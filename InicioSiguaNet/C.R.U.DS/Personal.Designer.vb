<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal
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
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvPersonal = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTablas = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrimer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSegundo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCasa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbSector = New System.Windows.Forms.ComboBox()
        Me.cmbVehiculo = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(407, 360)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(56, 19)
        Me.btnInicio.TabIndex = 21
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(407, 182)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(56, 19)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(407, 152)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(56, 19)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgvPersonal
        '
        Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonal.Location = New System.Drawing.Point(28, 233)
        Me.dgvPersonal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvPersonal.Name = "dgvPersonal"
        Me.dgvPersonal.RowHeadersWidth = 51
        Me.dgvPersonal.RowTemplate.Height = 24
        Me.dgvPersonal.Size = New System.Drawing.Size(436, 122)
        Me.dgvPersonal.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ID Vehiculo:"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(123, 77)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(76, 20)
        Me.txtIdentidad.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Numero Identidad:"
        '
        'btnTablas
        '
        Me.btnTablas.Location = New System.Drawing.Point(407, 20)
        Me.btnTablas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(56, 39)
        Me.btnTablas.TabIndex = 22
        Me.btnTablas.Text = "Consulta Tablas"
        Me.btnTablas.UseVisualStyleBackColor = True
        '
        'btnTodo
        '
        Me.btnTodo.Location = New System.Drawing.Point(407, 64)
        Me.btnTodo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(56, 39)
        Me.btnTodo.TabIndex = 23
        Me.btnTodo.Text = "Consulta Todo"
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(407, 108)
        Me.btnIndividual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(56, 39)
        Me.btnIndividual.TabIndex = 24
        Me.btnIndividual.Text = "Consulta Indiv."
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ID Personal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 108)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nombres:"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(123, 108)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(76, 20)
        Me.txtNombres.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 135)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Primer Apellido:"
        '
        'txtPrimer
        '
        Me.txtPrimer.Location = New System.Drawing.Point(123, 135)
        Me.txtPrimer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrimer.Name = "txtPrimer"
        Me.txtPrimer.Size = New System.Drawing.Size(76, 20)
        Me.txtPrimer.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 163)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Segundo Apellido:"
        '
        'txtSegundo
        '
        Me.txtSegundo.Location = New System.Drawing.Point(123, 163)
        Me.txtSegundo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSegundo.Name = "txtSegundo"
        Me.txtSegundo.Size = New System.Drawing.Size(76, 20)
        Me.txtSegundo.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 195)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Numero Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(123, 195)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(76, 20)
        Me.txtTelefono.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(206, 48)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Numero Casa:"
        '
        'txtCasa
        '
        Me.txtCasa.Location = New System.Drawing.Point(302, 46)
        Me.txtCasa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCasa.Name = "txtCasa"
        Me.txtCasa.Size = New System.Drawing.Size(76, 20)
        Me.txtCasa.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(216, 77)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "ID Sector:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 166)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Referencias:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(267, 166)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(111, 48)
        Me.txtReferencia.TabIndex = 40
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Libre", "Ocupado", "Eliminado"})
        Me.cmbEstado.Location = New System.Drawing.Point(286, 135)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(92, 21)
        Me.cmbEstado.TabIndex = 41
        '
        'cmbSector
        '
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(286, 77)
        Me.cmbSector.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(92, 21)
        Me.cmbSector.TabIndex = 42
        '
        'cmbVehiculo
        '
        Me.cmbVehiculo.FormattingEnabled = True
        Me.cmbVehiculo.Location = New System.Drawing.Point(286, 108)
        Me.cmbVehiculo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbVehiculo.Name = "cmbVehiculo"
        Me.cmbVehiculo.Size = New System.Drawing.Size(92, 21)
        Me.cmbVehiculo.TabIndex = 43
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(123, 46)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 44
        '
        'Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 388)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cmbVehiculo)
        Me.Controls.Add(Me.cmbSector)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCasa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSegundo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPrimer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnIndividual)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.btnTablas)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvPersonal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Personal"
        Me.Text = "Personal"
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInicio As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvPersonal As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTablas As Button
    Friend WithEvents btnTodo As Button
    Friend WithEvents btnIndividual As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrimer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSegundo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCasa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbSector As ComboBox
    Friend WithEvents cmbVehiculo As ComboBox
    Friend WithEvents txtID As TextBox
End Class
