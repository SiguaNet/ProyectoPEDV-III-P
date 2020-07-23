<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionFacturas
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
        Me.BtnVerFactura = New System.Windows.Forms.Button()
        Me.BtnCrearFactura = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVerFactura
        '
        Me.BtnVerFactura.Location = New System.Drawing.Point(407, 22)
        Me.BtnVerFactura.Name = "BtnVerFactura"
        Me.BtnVerFactura.Size = New System.Drawing.Size(129, 41)
        Me.BtnVerFactura.TabIndex = 5
        Me.BtnVerFactura.Text = "Informacion factura"
        Me.BtnVerFactura.UseVisualStyleBackColor = True
        '
        'BtnCrearFactura
        '
        Me.BtnCrearFactura.Location = New System.Drawing.Point(225, 22)
        Me.BtnCrearFactura.Name = "BtnCrearFactura"
        Me.BtnCrearFactura.Size = New System.Drawing.Size(129, 41)
        Me.BtnCrearFactura.TabIndex = 4
        Me.BtnCrearFactura.Text = "Nueva factura"
        Me.BtnCrearFactura.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(703, 458)
        Me.DataGridView1.TabIndex = 3
        '
        'GestionFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 562)
        Me.Controls.Add(Me.BtnVerFactura)
        Me.Controls.Add(Me.BtnCrearFactura)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionFacturas"
        Me.Text = "GestionFacturas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnVerFactura As Button
    Friend WithEvents BtnCrearFactura As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
