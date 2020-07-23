<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionTicket
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnCrearTicket = New System.Windows.Forms.Button()
        Me.BtnVerTicket = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(703, 458)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnCrearTicket
        '
        Me.BtnCrearTicket.Location = New System.Drawing.Point(222, 12)
        Me.BtnCrearTicket.Name = "BtnCrearTicket"
        Me.BtnCrearTicket.Size = New System.Drawing.Size(129, 41)
        Me.BtnCrearTicket.TabIndex = 1
        Me.BtnCrearTicket.Text = "Crear nuevo"
        Me.BtnCrearTicket.UseVisualStyleBackColor = True
        '
        'BtnVerTicket
        '
        Me.BtnVerTicket.Location = New System.Drawing.Point(404, 12)
        Me.BtnVerTicket.Name = "BtnVerTicket"
        Me.BtnVerTicket.Size = New System.Drawing.Size(129, 41)
        Me.BtnVerTicket.TabIndex = 2
        Me.BtnVerTicket.Text = "Informacion ticket"
        Me.BtnVerTicket.UseVisualStyleBackColor = True
        '
        'GestionTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 562)
        Me.Controls.Add(Me.BtnVerTicket)
        Me.Controls.Add(Me.BtnCrearTicket)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionTicket"
        Me.Text = "GestionTicket"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnCrearTicket As Button
    Friend WithEvents BtnVerTicket As Button
End Class
