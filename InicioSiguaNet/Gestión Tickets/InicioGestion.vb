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

            ElseIf MessageBox.Show("El cliente no existe, ¿Desea ingresarlo?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                AgregarCliente.Show()
                Me.Hide()

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnGestionarTicket_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        variablesGlobales.numeroIdentidad = txtIdCli.Text
        Me.Close()
        GestionTickets.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        GestionTickets.Show()

    End Sub
End Class