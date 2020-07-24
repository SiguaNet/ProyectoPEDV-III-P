<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecuperacionContrasena
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecuperacionContrasena))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.rtxHtml = New System.Windows.Forms.RichTextBox()
        Me.btnRecu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Identidad"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(127, 61)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(185, 20)
        Me.txtIdentidad.TabIndex = 1
        '
        'rtxHtml
        '
        Me.rtxHtml.Location = New System.Drawing.Point(-1, 191)
        Me.rtxHtml.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxHtml.Name = "rtxHtml"
        Me.rtxHtml.Size = New System.Drawing.Size(126, 105)
        Me.rtxHtml.TabIndex = 618
        Me.rtxHtml.Text = resources.GetString("rtxHtml.Text")
        Me.rtxHtml.Visible = False
        '
        'btnRecu
        '
        Me.btnRecu.Location = New System.Drawing.Point(180, 121)
        Me.btnRecu.Name = "btnRecu"
        Me.btnRecu.Size = New System.Drawing.Size(79, 34)
        Me.btnRecu.TabIndex = 619
        Me.btnRecu.Text = "Recuperar"
        Me.btnRecu.UseVisualStyleBackColor = True
        '
        'RecuperacionContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 215)
        Me.Controls.Add(Me.btnRecu)
        Me.Controls.Add(Me.rtxHtml)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RecuperacionContrasena"
        Me.Text = "RecuperacionContrasena"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents rtxHtml As RichTextBox
    Friend WithEvents btnRecu As Button
End Class
