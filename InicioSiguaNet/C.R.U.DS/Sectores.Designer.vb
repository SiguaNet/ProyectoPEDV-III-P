<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sectores
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTablas = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.dgvSector = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(448, 83)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(75, 48)
        Me.btnIndividual.TabIndex = 48
        Me.btnIndividual.Text = "Consulta Indiv."
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(180, 55)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ID Sector:"
        '
        'btnTablas
        '
        Me.btnTablas.Location = New System.Drawing.Point(448, 29)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(75, 48)
        Me.btnTablas.TabIndex = 41
        Me.btnTablas.Text = "Consulta Tablas"
        Me.btnTablas.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(448, 389)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 40
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'dgvSector
        '
        Me.dgvSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSector.Location = New System.Drawing.Point(53, 209)
        Me.dgvSector.Name = "dgvSector"
        Me.dgvSector.RowHeadersWidth = 51
        Me.dgvSector.RowTemplate.Height = 24
        Me.dgvSector.Size = New System.Drawing.Size(470, 150)
        Me.dgvSector.TabIndex = 37
        '
        'Sectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.btnIndividual)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTablas)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.dgvSector)
        Me.Name = "Sectores"
        Me.Text = "Sectores"
        CType(Me.dgvSector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIndividual As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTablas As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents dgvSector As DataGridView
End Class
