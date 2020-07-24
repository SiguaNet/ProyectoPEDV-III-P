Imports System.Net
Imports System.Net.Mail

Public Class RecuperacionContrasena
    Dim conexion As New Conexion()
    Private correos As New MailMessage
    Private envios As New SmtpClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRecu.Click
        'rtxHtml.Text = rtxHtml.Text.Replace("@psw", txtPswMostra.Text)
        enviarCorreo(mensaje:=rtxHtml.Text, asunto:="Recuperar contraseña", destinatario:="alexis.00363@outlook.com", ruta:="")

        If Conexion.comprobarExistencias("select numeroIdentidad from ADMINISTRADORES where numeroIdentidad = '" & txtIdentidad.Text & "'") = 1 Then

        Else
            MessageBox.Show("")
        End If

    End Sub

    Public Sub enviarCorreo(mensaje As String, asunto As String, destinatario As String, ruta As String)
        Dim emisor As String = "icecreamdelifrios@gmail.com"
        Dim psw As String = "icedelifrios2020"
        'Try
        correos.To.Clear()
        correos.Body = ""
        correos.Subject = ""
        correos.Body = mensaje
        correos.Subject = asunto
        correos.IsBodyHtml = True
        correos.To.Add(destinatario)

        correos.From = New MailAddress(emisor)
        envios.Credentials = New NetworkCredential(emisor, psw)

        'datos no modificables 
        envios.Host = "	smtp.gmail.com"
        envios.Port = 465
        envios.Port =
        envios.EnableSsl = True

        envios.Send(correos)
        MessageBox.Show("Correo enviado", "Revisar Bandeja de entrada")
        'Catch ex As Exception
        MessageBox.Show("Correo invalido", "Error")
        'End Try
    End Sub

End Class