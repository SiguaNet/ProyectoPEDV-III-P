Imports System.ComponentModel
Imports System.Net
Imports System.Net.Mail

Public Class RecuperacionContrasena
    Dim conexion As New Conexion()
    Private correos As New MailMessage
    Private envios As New SmtpClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRecu.Click
        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty Then

            If conexion.comprobarExistencias("select numeroIdentidad from ADMINISTRADORES where numeroIdentidad = '" & txtIdentidad.Text & "'") = 1 Then

                Dim corr As String = conexion.obtenerVariableCadena("select correo from ADMINISTRADORES WHERE numeroIdentidad = '" & txtIdentidad.Text & "'", "correo")
                Dim srtPalabra As String = corr
                If InputBox("Ingrese los primeros cuatro caracteres de su correo", "Comprobacion de Seguridad") = srtPalabra.Substring(0, 4) Then
                    Dim cont As String = conexion.Desencriptar(conexion.obtenerVariableCadena("select contrasena from ADMINISTRADORES WHERE numeroIdentidad = '" & txtIdentidad.Text & "'", "contrasena"))
                    Dim nomb As String = conexion.obtenerVariableCadena("select nombres from DATOS_PERSONAS WHERE numeroIdentidad = '" & txtIdentidad.Text & "'", "nombres")
                    rtxHtml.Text = rtxHtml.Text.Replace("@contra", "  " + cont)
                    rtxHtml.Text = rtxHtml.Text.Replace("@nombre", nomb)
                    enviarCorreo(mensaje:=rtxHtml.Text, asunto:="Recuperar contraseña", destinatario:=corr, ruta:="")
                    MessageBox.Show("Revise la bandeja de entrada, spam de su correo: " & corr, "Recuperacion de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    InputBox("Ingrese los primeros cuatro caracteres de su correo", "Comprobacion de Seguridad")
                    MessageBox.Show("Si la informacion que ingreso es correcta, recibira en su correo electronico la contraseña de su cuenta.", "Recuperacion de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Else
                InputBox("Ingrese los primeros cuatro caracteres de su correo", "Comprobacion de Seguridad")
                MessageBox.Show("Si la informacion que ingreso es correcta, recibira en su correo electronico la contraseña de su cuenta.", "Recuperacion de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If


    End Sub

    Public Sub enviarCorreo(mensaje As String, asunto As String, destinatario As String, ruta As String)

        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient

        _SMTP.UseDefaultCredentials = False
        _SMTP.Credentials = New System.Net.NetworkCredential("sigua.netco@gmail.com", "Siguanet2020")
        _SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True

        '
        _Message.[To].Add(destinatario.ToString)
        _Message.From = New System.Net.Mail.MailAddress("sigua.netco@gmail.com", "SiguaNet No Reply", System.Text.Encoding.UTF8)
        _Message.Subject = asunto.ToString
        _Message.SubjectEncoding = System.Text.Encoding.UTF8
        _Message.Body = mensaje
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.Normal
        _Message.IsBodyHtml = True

        Try
            _SMTP.Send(_Message)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip1.SetToolTip(txtIdentidad, "Introduzca el numero de identidad con el que registro en el sistema")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class