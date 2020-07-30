Imports System.Runtime.InteropServices
Public Class ActualizarTicket
    Dim conexion As Conexion = New Conexion
    Dim estado As String

    Private Sub ActualizarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumeroID.Text = variablesGlobales.numeroIdentidad
        txtOperacion.Text = variablesGlobales.nombreOpera

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        RealizarTickets.Show()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        RealizarTickets.Show()

    End Sub

    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If PanelDatosCliente.Height <= 27 Then
            Me.TimerOcultar.Enabled = False
        Else
            Me.PanelDatosCliente.Height = PanelDatosCliente.Height - 40
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If PanelDatosCliente.Height >= 180 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.PanelDatosCliente.Height = PanelDatosCliente.Height + 40
        End If
    End Sub

    Private Sub btnVerDatoCliente_Click(sender As Object, e As EventArgs) Handles btnVerDatoCliente.Click
        Dim idCliente As String
        idCliente = txtNumeroID.Text

        Try
            If (conexion.LlenarTablaPorIdentidad("consultaInformacionCliente", "@numeroIdentidad", idCliente) = 0) Then
                If tablaDatosG.Rows.Count > 0 Then

                    Dim dat(3) As Object

                    For i As Integer = 0 To tablaDatosG.Columns.Count - 1
                        dat(i) = tablaDatosG.Rows(0)(i)

                    Next

                    txtNumeroID.Text = dat(0)
                    txtNombreCompleto.Text = dat(1)
                    txtTelefono.Text = dat(2)
                    txtReferenciasDirec.Text = dat(3)

                    If PanelDatosCliente.Height = 27 Then
                        TimerMostrar.Enabled = True

                    ElseIf PanelDatosCliente.Height = 187 Then
                        TimerOcultar.Enabled = True

                    End If

                End If

            ElseIf MessageBox.Show("El cliente no existe, ¿Desea ingresarlo?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.Hide()
                variablesGlobales.numeroIdentidad = txtNumeroID.Text
                AgregarCliente.Show()

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkEstadoRealizado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstadoRealizado.CheckedChanged
        If chkEstadoRealizado.Checked = True Then
            estado = "Realizado"
            chkEstadoRealizado.Enabled = True

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim idTicket, idPersonal, idOperacion, cantEr, cantAn, inveAn, inveEr, totalAn, totalEr As Integer
        Dim numeroIdentidad, prioridad, nota, fechaInicio, fechaFin As String

        idTicket = variablesGlobales.idTicketAct
        numeroIdentidad = txtNumeroID.Text
        nota = "Operación realizada"
        fechaInicio = variablesGlobales.fechaEstablecida
        fechaFin = String.Format("{0:G}", DateTime.Now)
        idPersonal = variablesGlobales.idTecnico
        prioridad = "Baja"
        idOperacion = variablesGlobales.idOpera

        inveAn = Val(conexion.obtenerVariableEntera("select cantidad from INVENTARIO where nombreTipo = 'Antenas'", "cantidad"))
        inveEr = Val(conexion.obtenerVariableEntera("select cantidad from INVENTARIO where nombreTipo = 'Enrutadores'", "cantidad"))
        cantAn = Val(cmbAn.Text)
        cantEr = Val(cmbEr.Text)

        Try
            If txtNumeroID.Text = "" Then
                MessageBox.Show("No se ha retornado el numero de identidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf estado = "Realizado" Then
                prioridad = "Baja"
                If inveAn > cantAn Or inveEr > cantEr Then
                    If (conexion.PAOperacionesGestionTickets(idTicket, numeroIdentidad, idPersonal, estado, prioridad, idOperacion, nota, fechaInicio, fechaFin, 2) = 0) Then
                        conexion.EjecutarComando("update PERSONAL set estado = 'Libre' where idPersonal = '" & idPersonal & "'")

                        If idOperacion = 4 Then
                            conexion.EjecutarComando("update CLIENTES set estadoC = 'Eliminado' where numeroIdentidad = '" & numeroIdentidad & "'")
                        End If

                        totalAn = inveAn - cantAn
                        totalEr = inveEr - cantEr

                        conexion.PAOperacionesInventario(1, "Antenas", totalAn, 2)
                        conexion.PAOperacionesInventario(2, "Enrutadores", totalEr, 2)

                        MessageBox.Show("Operacion y ticket actualizado exitosamente", "Actualizar ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("La cantidad de inventario es insuficiente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                    MessageBox.Show("El estado de la operacion está en pendiente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub chkCambioEqui_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambioEqui.CheckedChanged

        If chkCambioEqui.Checked Then
            cmbAn.Enabled = True
            cmbEr.Enabled = True

        Else
            cmbAn.Enabled = False
            cmbEr.Enabled = False
            cmbAn.SelectedIndex = -1
            cmbEr.SelectedIndex = -1


        End If

    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelOpciones_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelOpciones.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class