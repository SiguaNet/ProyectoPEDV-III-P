<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recursos
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
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvRecursos = New System.Windows.Forms.DataGridView()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVehiculo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnTablas = New System.Windows.Forms.Button()
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(429, 470)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 21
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(429, 246)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(429, 217)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgvRecursos
        '
        Me.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecursos.Location = New System.Drawing.Point(34, 289)
        Me.dgvRecursos.Name = "dgvRecursos"
        Me.dgvRecursos.RowHeadersWidth = 51
        Me.dgvRecursos.RowTemplate.Height = 24
        Me.dgvRecursos.Size = New System.Drawing.Size(470, 150)
        Me.dgvRecursos.TabIndex = 17
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(161, 140)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 22)
        Me.txtModelo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Matricula:"
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Location = New System.Drawing.Point(161, 41)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.Size = New System.Drawing.Size(100, 22)
        Me.txtVehiculo.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ID Vehiculo:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(161, 95)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 22)
        Me.txtMatricula.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Modelo:"
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(429, 149)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(75, 48)
        Me.btnIndividual.TabIndex = 27
        Me.btnIndividual.Text = "Consulta Indiv."
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'btnTodo
        '
        Me.btnTodo.Location = New System.Drawing.Point(429, 95)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(75, 48)
        Me.btnTodo.TabIndex = 26
        Me.btnTodo.Text = "Consulta Todo"
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'btnTablas
        '
        Me.btnTablas.Location = New System.Drawing.Point(429, 41)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(75, 48)
        Me.btnTablas.TabIndex = 25
        Me.btnTablas.Text = "Consulta Tablas"
        Me.btnTablas.UseVisualStyleBackColor = True
        '
        'Recursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 505)
        Me.Controls.Add(Me.btnIndividual)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.btnTablas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvRecursos)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMatricula)
        Me.Name = "Recursos"
        Me.Text = "Recursos"
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInicio As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvRecursos As DataGridView
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVehiculo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIndividual As Button
    Friend WithEvents btnTodo As Button
    Friend WithEvents btnTablas As Button
End Class
