<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketsCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketsCliente))
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCasa = New System.Windows.Forms.Button()
        Me.dgvTicketsCliente = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.PanelOpciones.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        CType(Me.dgvTicketsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOpciones
        '
        Me.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelOpciones.Controls.Add(Me.btnCasa)
        Me.PanelOpciones.Controls.Add(Me.btnVolver)
        Me.PanelOpciones.Controls.Add(Me.btnCerrar)
        Me.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(1180, 79)
        Me.PanelOpciones.TabIndex = 0
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.btnActualizar)
        Me.PanelContenido.Controls.Add(Me.dgvTicketsCliente)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 79)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(1180, 690)
        Me.PanelContenido.TabIndex = 1
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), System.Drawing.Image)
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Location = New System.Drawing.Point(12, 9)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(65, 65)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1123, 18)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 45)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnCasa
        '
        Me.btnCasa.BackColor = System.Drawing.Color.Transparent
        Me.btnCasa.BackgroundImage = CType(resources.GetObject("btnCasa.BackgroundImage"), System.Drawing.Image)
        Me.btnCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCasa.FlatAppearance.BorderSize = 0
        Me.btnCasa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCasa.Location = New System.Drawing.Point(109, 20)
        Me.btnCasa.Name = "btnCasa"
        Me.btnCasa.Size = New System.Drawing.Size(48, 43)
        Me.btnCasa.TabIndex = 11
        Me.btnCasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCasa.UseVisualStyleBackColor = False
        '
        'dgvTicketsCliente
        '
        Me.dgvTicketsCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketsCliente.Location = New System.Drawing.Point(44, 89)
        Me.dgvTicketsCliente.Name = "dgvTicketsCliente"
        Me.dgvTicketsCliente.RowHeadersWidth = 51
        Me.dgvTicketsCliente.RowTemplate.Height = 24
        Me.dgvTicketsCliente.Size = New System.Drawing.Size(1063, 489)
        Me.dgvTicketsCliente.TabIndex = 0
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1010, 638)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(158, 40)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'TicketsCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 769)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TicketsCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicketsCliente"
        Me.PanelOpciones.ResumeLayout(False)
        Me.PanelContenido.ResumeLayout(False)
        CType(Me.dgvTicketsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnCasa As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dgvTicketsCliente As DataGridView
End Class
