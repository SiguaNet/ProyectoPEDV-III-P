Imports System.ComponentModel
Imports System.Runtime.InteropServices
Public Class InicioGestion
    Dim conexion As Conexion = New Conexion
    Private Sub InicioGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdCli.Text = variablesGlobales.numeroIdentidad

    End Sub

    Private Sub btnVerDatoCliente_Click(sender As Object, e As EventArgs) Handles btnVerDatoCliente.Click
        Dim idCliente As String
        idCliente = txtIdCli.Text

        Try
            If (conexion.LlenarTablaPorIdentidad("consultaInformacionCliente", "@numeroIdentidad", txtIdCli.Text) = 0) Then
                If tablaDatosG.Rows.Count > 0 Then

                    Dim dat(3) As Object

                    For i As Integer = 0 To tablaDatosG.Columns.Count - 1
                        dat(i) = tablaDatosG.Rows(0)(i)

                    Next

                    txtIdCli.Text = dat(0)
                    txtNombreCompleto.Text = dat(1)
                    txtTelefono.Text = dat(2)
                    txtReferenciasDirec.Text = dat(3)
                End If

            ElseIf idCliente.Length = 13 Then

                If MessageBox.Show("El cliente no existe, ¿Desea ingresarlo?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    variablesGlobales.numeroIdentidad = ""
                    variablesGlobales.numeroIdentidad = txtIdCli.Text
                    Me.Hide()
                    AgregarCliente.Show()

                End If
            Else
                MessageBox.Show("¡Por favor ingrese un número de identidad valido!", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnGestionarTicket_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            If txtIdCli.Text = "" Then
                MessageBox.Show("Por favor ingrese un numero de identidad", "Gestionar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                variablesGlobales.numeroIdentidad = ""
                variablesGlobales.numeroIdentidad = txtIdCli.Text
                Me.Close()
                GenerarTicket.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Gestionar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        GestionTickets.Show()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        GestionTickets.Show()

    End Sub

    'Private Sub btnPaquete_Click(sender As Object, e As EventArgs)
    '    Try
    '        If txtIdCli.Text = "" Then
    '            MessageBox.Show("Por favor ingrese un numero de identidad", "Gestionar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    '        Else
    '            limpiar()
    '            variablesGlobales.numeroIdentidad = txtIdCli.Text
    '            Me.Hide()
    '            ActualizarPaquete.Show()

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error", "Gestionar", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try
    'End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click

        Try
            If txtIdCli.Text = "" Then
                MessageBox.Show("Por favor ingrese un numero de identidad", "Gestionar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                variablesGlobales.numeroIdentidad = txtIdCli.Text
                Me.Hide()
                TicketsCliente.Show()

            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Gestionar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub txtIdCli_Validating(sender As Object, e As CancelEventArgs) Handles txtIdCli.Validating
        Dim numID As String
        numID = txtIdCli.Text
        If Val(numID.Length) = 13 And numID <> "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero de identidad valido")
        End If
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub
End Class