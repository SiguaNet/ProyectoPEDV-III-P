<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarPaquete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarPaquete))
        Me.PanelOpciones = New System.Windows.Forms.Panel()
        Me.btnCasa = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPreOp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVelOp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPlanOp = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPreAc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlanAc = New System.Windows.Forms.TextBox()
        Me.txtVelAc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCli = New System.Windows.Forms.TextBox()
        Me.PanelOpciones.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.PanelOpciones.Size = New System.Drawing.Size(919, 80)
        Me.PanelOpciones.TabIndex = 0
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
        Me.btnCasa.Location = New System.Drawing.Point(102, 19)
        Me.btnCasa.Name = "btnCasa"
        Me.btnCasa.Size = New System.Drawing.Size(48, 43)
        Me.btnCasa.TabIndex = 11
        Me.btnCasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCasa.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), System.Drawing.Image)
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Location = New System.Drawing.Point(12, 7)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(71, 67)
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
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(857, 15)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(50, 50)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelContenido
        '
        Me.PanelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenido.Controls.Add(Me.btnActualizar)
        Me.PanelContenido.Controls.Add(Me.GroupBox1)
        Me.PanelContenido.Controls.Add(Me.GroupBox2)
        Me.PanelContenido.Controls.Add(Me.Label1)
        Me.PanelContenido.Controls.Add(Me.txtIdCli)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(0, 80)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(919, 455)
        Me.PanelContenido.TabIndex = 1
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(559, 367)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(283, 52)
        Me.btnActualizar.TabIndex = 24
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPreOp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtVelOp)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbPlanOp)
        Me.GroupBox1.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 301)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(144, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 29)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "L."
        '
        'txtPreOp
        '
        Me.txtPreOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreOp.Location = New System.Drawing.Point(180, 245)
        Me.txtPreOp.Name = "txtPreOp"
        Me.txtPreOp.Size = New System.Drawing.Size(79, 30)
        Me.txtPreOp.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(123, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 29)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Precio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(236, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 29)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Mb/s"
        '
        'txtVelOp
        '
        Me.txtVelOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelOp.Location = New System.Drawing.Point(138, 164)
        Me.txtVelOp.Name = "txtVelOp"
        Me.txtVelOp.Size = New System.Drawing.Size(92, 30)
        Me.txtVelOp.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(75, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 29)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Velocidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 29)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Plan de internet"
        '
        'cmbPlanOp
        '
        Me.cmbPlanOp.FormattingEnabled = True
        Me.cmbPlanOp.Location = New System.Drawing.Point(70, 74)
        Me.cmbPlanOp.Name = "cmbPlanOp"
        Me.cmbPlanOp.Size = New System.Drawing.Size(294, 37)
        Me.cmbPlanOp.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPreAc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPlanAc)
        Me.GroupBox2.Controls.Add(Me.txtVelAc)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(463, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 310)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(159, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "L."
        '
        'txtPreAc
        '
        Me.txtPreAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreAc.Location = New System.Drawing.Point(195, 253)
        Me.txtPreAc.Name = "txtPreAc"
        Me.txtPreAc.Size = New System.Drawing.Size(75, 30)
        Me.txtPreAc.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(130, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 29)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Plan de internet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(248, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 29)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Mb/s"
        '
        'txtPlanAc
        '
        Me.txtPlanAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanAc.Location = New System.Drawing.Point(103, 75)
        Me.txtPlanAc.Name = "txtPlanAc"
        Me.txtPlanAc.Size = New System.Drawing.Size(276, 30)
        Me.txtPlanAc.TabIndex = 17
        '
        'txtVelAc
        '
        Me.txtVelAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelAc.Location = New System.Drawing.Point(151, 166)
        Me.txtVelAc.Name = "txtVelAc"
        Me.txtVelAc.Size = New System.Drawing.Size(91, 30)
        Me.txtVelAc.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 29)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Velocidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Identidad cliente"
        '
        'txtIdCli
        '
        Me.txtIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCli.Location = New System.Drawing.Point(121, 66)
        Me.txtIdCli.Name = "txtIdCli"
        Me.txtIdCli.Size = New System.Drawing.Size(255, 30)
        Me.txtIdCli.TabIndex = 14
        '
        'ActualizarPaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 535)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizarPaquete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActualizarPaquete"
        Me.PanelOpciones.ResumeLayout(False)
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOpciones As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlanAc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdCli As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbPlanOp As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPreAc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVelAc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPreOp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtVelOp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCasa As Button
End Class
