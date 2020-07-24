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
        Me.btnGestionTickets = New System.Windows.Forms.Button()
        Me.btnEstadoFinanciero = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnRecursos = New System.Windows.Forms.Button()
        Me.DbgClientes = New System.Windows.Forms.DataGridView()
        Me.BtnClientes = New System.Windows.Forms.Button()
        CType(Me.DbgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGestionTickets
        '
        Me.btnGestionTickets.Location = New System.Drawing.Point(245, 12)
        Me.btnGestionTickets.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGestionTickets.Name = "btnGestionTickets"
        Me.btnGestionTickets.Size = New System.Drawing.Size(181, 48)
        Me.btnGestionTickets.TabIndex = 0
        Me.btnGestionTickets.Text = "Gestión de tickets"
        Me.btnGestionTickets.UseVisualStyleBackColor = True
        '
        'btnEstadoFinanciero
        '
        Me.btnEstadoFinanciero.Location = New System.Drawing.Point(430, 12)
        Me.btnEstadoFinanciero.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEstadoFinanciero.Name = "btnEstadoFinanciero"
        Me.btnEstadoFinanciero.Size = New System.Drawing.Size(181, 48)
        Me.btnEstadoFinanciero.TabIndex = 1
        Me.btnEstadoFinanciero.Text = "Estado financiero"
        Me.btnEstadoFinanciero.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Location = New System.Drawing.Point(615, 12)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(181, 48)
        Me.btnInventario.TabIndex = 3
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(1109, 595)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(130, 32)
        Me.btnCerrarSesion.TabIndex = 4
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(800, 12)
        Me.btnPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(181, 48)
        Me.btnPersonal.TabIndex = 5
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnRecursos
        '
        Me.btnRecursos.Location = New System.Drawing.Point(985, 11)
        Me.btnRecursos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecursos.Name = "btnRecursos"
        Me.btnRecursos.Size = New System.Drawing.Size(181, 48)
        Me.btnRecursos.TabIndex = 6
        Me.btnRecursos.Text = "Recursos"
        Me.btnRecursos.UseVisualStyleBackColor = True
        '
        'DbgClientes
        '
        Me.DbgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbgClientes.Location = New System.Drawing.Point(11, 131)
        Me.DbgClientes.Name = "DbgClientes"
        Me.DbgClientes.Size = New System.Drawing.Size(1227, 441)
        Me.DbgClientes.TabIndex = 7
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(59, 12)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(181, 47)
        Me.BtnClientes.TabIndex = 8
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'InicioSiguaNet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 638)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.DbgClientes)
        Me.Controls.Add(Me.btnRecursos)
        Me.Controls.Add(Me.btnPersonal)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.btnEstadoFinanciero)
        Me.Controls.Add(Me.btnGestionTickets)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "InicioSiguaNet"
        Me.Text = "Form1"
        CType(Me.DbgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGestionTickets As Button
    Friend WithEvents btnEstadoFinanciero As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnRecursos As Button
    Friend WithEvents DbgClientes As DataGridView
    Friend WithEvents BtnClientes As Button
End Class
