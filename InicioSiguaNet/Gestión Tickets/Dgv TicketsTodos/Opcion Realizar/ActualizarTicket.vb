Public Class ActualizarTicket
    Dim conexion As Conexion = New Conexion
    Dim estado As String

    Private Sub ActualizarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumeroID.Text = variablesGlobales.numeroIdentidad
        txtOperacion.Text = variablesGlobales.nombreOpera

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        RealizarTickets.Show()

    End Sub

    Private Sub btnVerDatoCliente_Click(sender As Object, e As EventArgs) Handles btnVerDatoCliente.Click
        Dim idCliente As String
        idCliente = txtNumeroID.Text

        If PanelDatosCliente.Height = 27 Then
            TimerMostrar.Enabled = True

        ElseIf PanelDatosCliente.Height = 187 Then
            TimerOcultar.Enabled = True

        End If

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


                    'Efecto por mientras

                    If PanelDatosCliente.Height = 27 Then
                        TimerMostrar.Enabled = True

                    ElseIf PanelDatosCliente.Height = 187 Then
                        TimerOcultar.Enabled = True

                    End If

                    'Fin efecto

                    'If (GradientDatos.Height = 24) Then

                    '    GradientDatos.Visible = False
                    '    GradientDatos.Height = 211
                    '    PanelDatosCliente.Height = 211
                    '    TransMostrar.Show(GradientDatos)

                    'Else

                    '    GradientDatos.Visible = False
                    '    GradientDatos.Height = 24
                    '    PanelDatosCliente.Height = 24
                    '    TransOcultar.Show(GradientDatos)

                    'End If

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

        Try
            If txtNumeroID.Text = "" Then
                MessageBox.Show("No se ha retornado el numero de identidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf estado = "Realizado" Then
                prioridad = "Baja"
                If (conexion.PAOperacionesGestionTickets(idTicket, numeroIdentidad, idPersonal, estado, prioridad, idOperacion, nota, fechaInicio, fechaFin, 2) = 0) Then
                    conexion.EjecutarComando("update PERSONAL set estado = 'Libre' where idPersonal = '" & idPersonal & "'")

                    cantAn = Val(cmbAn.Text)
                    cantEr = Val(cmbEr.Text)

                    inveAn = Val(conexion.obtenerVariableEntera("select cantidad from INVENTARIO where nombreTipo = 'Antenas'", "cantidad"))
                    inveEr = Val(conexion.obtenerVariableEntera("select cantidad from INVENTARIO where nombreTipo = 'Enrutadores'", "cantidad"))

                    totalAn = inveAn - cantAn
                    totalEr = inveEr - cantEr

                    conexion.PAOperacionesInventario(1, "Antenas", totalAn, 2)
                    conexion.PAOperacionesInventario(2, "Enrutadores", totalEr, 2)

                    MessageBox.Show("Operacion y ticket actulizado exitosamente", "Actualizar ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

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



End Class