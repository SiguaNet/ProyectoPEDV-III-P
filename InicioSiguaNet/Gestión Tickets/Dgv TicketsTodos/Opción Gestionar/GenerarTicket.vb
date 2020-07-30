Imports System.Runtime.InteropServices
Public Class GenerarTicket
    Dim conexion As Conexion = New Conexion

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim idTicket, idPersonal, idOperacion As Integer
        Dim numeroIdentidad, estado, prioridad, nota, fechaInicio, fechaFin As String

        idTicket = 0
        numeroIdentidad = txtNumeroID.Text
        idPersonal = cmbPersonal.Text
        estado = "Pendiente"
        prioridad = cmbPrioridad.Text

        nota = txtNota.Text
        fechaInicio = String.Format("{0:G}", DateTime.Now)
        fechaFin = ""

        Try
            If Me.ValidateChildren And txtNumeroID.Text <> String.Empty And cmbPersonal.Text <> String.Empty And cmbOperaciones.Text <> String.Empty And cmbPrioridad.Text <> String.Empty Then
                Dim cantPagos As Integer = conexion.obtenerVariableEntera("Select pagosCliente from CLIENTES where numeroIdentidad = '" & numeroIdentidad & "'", "pagosCliente")
                Dim totalCanti As Integer = cantMesesG - cantPagos

                If cantMesesG <= cantPagos Then

                    If cmbOperaciones.Text = "Actualización" Then
                        idOperacion = 2
                        HcantActualizacionesMes += 1

                    ElseIf cmbOperaciones.Text = "Soporte técnico" Then
                        idOperacion = 3
                        HcantSoporteMes += 1

                    ElseIf cmbOperaciones.Text = "Corte por solicitud" Then
                        idOperacion = 4
                    Else
                        idOperacion = 1

                    End If

                    If conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where numeroIdentidadC = '" & numeroIdentidad & "' and estado = 'Pendiente'", "") = 0 Then

                        If (conexion.PAOperacionesGestionTickets(idTicket, numeroIdentidad, idPersonal, estado, prioridad, idOperacion, nota, fechaInicio, fechaFin, 1) = 0) Then
                            conexion.EjecutarComando("update PERSONAL set estado = 'Ocupado' where idPersonal = '" & idPersonal & "'")
                            MessageBox.Show("Ticket registrado exitosamente", "Generar ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            conexion.PAOperacionesFactura(0, numeroIdentidad, fechaInicio, 1)
                            ImprimirTicket.Print()

                            If idOperacion = 4 Then

                                'conexion.EjecutarComando("update CLIENTES set estadoC = 'Eliminado' where numeroIdentidad = '" & numeroIdentidad & "'")
                                'conexion.EjecutarComando("update PERSONAL set estado = 'Libre' where idPersonal = '" & idPersonal & "'")
                                'conexion.EjecutarComando("update GESTION_TICKETS set estado = 'Realizado' where numeroIdentidadC = '" & numeroIdentidad & "'")
                                HcantCortesMes += 1
                            End If
                        Else
                            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    Else
                        MessageBox.Show("Por favor resuelva los tickets pendientes de " & numeroIdentidad, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                        MessageBox.Show("La cuenta " & numeroIdentidad & " presenta una mora de " & totalCanti & " meses" & vbCrLf & "¡Por favor realice su pago!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If
                Else
                MessageBox.Show("Por favor ingrese todos los datos solicitados", "Generar ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        conexion.limpiar(Me)
        Me.Close()
        InicioGestion.Show()
    End Sub

    Private Sub GenerarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumeroID.Text = variablesGlobales.numeroIdentidad
        conexion.llenarComboBox(cmbPersonal, "select idPersonal from PERSONAL where estado <> 'Eliminado' and estado <> 'Ocupado'", "idPersonal")
        conexion.llenarComboBox(cmbOperaciones, "select nombreOperacion from OPERACIONES where nombreOperacion <> 'Instalación'", "nombreOperacion")

    End Sub

    Private Sub cmbPersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPersonal.SelectedIndexChanged
        Dim IdPersonal As Integer

        IdPersonal = Val(cmbPersonal.Text)

        Try
            If (conexion.LlenarTablaPorIdentidad("consultaDatosTecnico", "@idPersonal", IdPersonal) = 0) Then
                If tablaDatosG.Rows.Count > 0 Then

                    Dim dat(1) As Object

                    For i As Integer = 0 To tablaDatosG.Columns.Count - 1
                        dat(i) = tablaDatosG.Rows(0)(i)

                    Next

                    txtNombreTec.Text = dat(0)
                    txtTelefonoTec.Text = dat(1)
                End If

            Else
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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


                    'Efecto por mientras

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

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        conexion.limpiar(Me)
        Me.Close()
        InicioGestion.Show()

    End Sub

    Private Sub btnCasa_Click(sender As Object, e As EventArgs) Handles btnCasa.Click
        conexion.limpiar(Me)
        Me.Close()
        GestionTickets.Show()

    End Sub

    Private Sub cmbOperaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperaciones.SelectedIndexChanged
        If cmbOperaciones.Text = "Actualización" Then
            variablesGlobales.numeroIdentidad = txtNumeroID.Text
            ActualizarPaquete.Show()

        End If

    End Sub

    Private Sub ImprimirTicket_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ImprimirTicket.PrintPage
        conexion.ObtenerVariablesPorIdentidad("consultaInformacionClienteTicket", "@numeroIdentidad", variablesGlobales.numeroIdentidad)

        Dim nombreEncargado As String = conexion.obtenerVariableCadena("select nombres from DATOS_PERSONAS where numeroIdentidad = '" & identidadPersonalEntro & "'", "nombres")

        Dim datos(11) As Object
        Dim cantRows As Integer = tablaDatosG.Rows.Count - 1
        If tablaDatosG.Rows.Count > 0 Then
            For i As Integer = 0 To tablaDatosG.Columns.Count - 1
                datos(i) = tablaDatosG.Rows(cantRows)(i)
            Next
        End If

        Dim fuente As System.Drawing.Font = New Font("consolas", 15)
        Dim topMargin As Double = e.MarginBounds.Top

        ' Imprime la cabecera
        Dim printFont As System.Drawing.Font = New Font("consolas", 9)
        e.Graphics.DrawImage(My.Resources.logoF, 70, 0, 150, 150)
        e.Graphics.DrawString(("SiguaNet"), fuente, Brushes.Black, 100, 140)
        e.Graphics.DrawString(("¡La mayor velocidad, todo el tiempo!"), printFont, Brushes.Black, 60, 170)
        e.Graphics.DrawString(("Barrio San Miguel, Siguatepeque"), printFont, Brushes.Black, 30, 200)
        e.Graphics.DrawString(("Tel: 2773-1110"), printFont, Brushes.Black, 90, 220)
        e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 5, 240)
        e.Graphics.DrawString(("N Ticket: ") & datos(0).ToString, printFont, Brushes.Black, 5, 260)
        e.Graphics.DrawString(("Prioridad: ") & datos(1).ToString, printFont, Brushes.Black, 5, 280)
        e.Graphics.DrawString("Nombre C: " & datos(2).ToString, printFont, Brushes.Black, 5, 300)
        e.Graphics.DrawString("Operación: " & datos(3).ToString, printFont, Brushes.Black, 5, 320)
        e.Graphics.DrawString("Notas: " & datos(4).ToString, printFont, Brushes.Black, 5, 340)
        e.Graphics.DrawString("Paquete: " & datos(5).ToString, printFont, Brushes.Black, 5, 360)
        e.Graphics.DrawString("Cant Pagos: " & datos(6).ToString, printFont, Brushes.Black, 5, 380)
        e.Graphics.DrawString("Descrip Ope: " & datos(7).ToString, printFont, Brushes.Black, 5, 400)

        e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 5, 430)
        e.Graphics.DrawString("Fecha Inicio: " & datos(9).ToString, printFont, Brushes.Black, 5, 450)
        e.Graphics.DrawString(("Fecha Fin:  Pendiente "), printFont, Brushes.Black, 5, 470)
        e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 5, 490)

        e.Graphics.DrawString("Empleado encargado: " & datos(8).ToString, printFont, Brushes.Black, 5, 510)
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub btnAdelante_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        Me.Close()
        FichaCliente.Show()

    End Sub
End Class