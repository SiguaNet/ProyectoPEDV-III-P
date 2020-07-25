Public Class GenerarTicket
    Dim conexion As Conexion = New Conexion

    '(@numeroIdentidadC, @idPersonal, @estado, @prioridad, @idOperacion, @nota, @fechaInicio, @fechaFin)
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click



        Dim idTicket, idPersonal, idOperacion As Integer
        Dim numeroIdentidad, estado, prioridad, nota, fechaInicio, fechaFin As String

        idTicket = 0
        numeroIdentidad = txtNumeroID.Text
        idPersonal = cmbPersonal.Text
        estado = cmbEstado.Text
        prioridad = cmbPrioridad.Text
        idOperacion = cmbOperaciones.SelectedIndex + 1
        nota = txtNota.Text
        fechaInicio = String.Format("{0:G}", DateTime.Now)
        fechaFin = ""

        Try
            If Me.ValidateChildren And txtNumeroID.Text <> String.Empty And cmbPersonal.Text <> String.Empty And cmbEstado.Text <> String.Empty And cmbOperaciones.Text <> String.Empty And cmbPrioridad.Text <> String.Empty Then
                If (conexion.PAOperacionesGestionTickets(idTicket, numeroIdentidad, idPersonal, estado, prioridad, idOperacion, nota, fechaInicio, fechaFin, 1) = 0) Then
                    MessageBox.Show("Ticket registrado exitosamente", "Generar ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Por favor ingrese todos los datos solicitados", "Generar ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub GenerarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNumeroID.Text = variablesGlobales.numeroIdentidad
        conexion.llenarComboBox(cmbPersonal, "select idPersonal from PERSONAL", "idPersonal")
        conexion.llenarComboBox(cmbOperaciones, "select nombreOperacion from OPERACIONES", "nombreOperacion")

    End Sub

    Private Sub cmbPersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPersonal.SelectedIndexChanged
        Dim IdPersonal As Integer

        IdPersonal = cmbPersonal.SelectedIndex + 1

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

    Private Sub limpiar()
        txtNumeroID.Clear()
        txtNota.Clear()
        txtTelefonoTec.Clear()
        txtNombreTec.Clear()
        cmbPersonal.SelectedIndex = -1
        cmbOperaciones.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        cmbPrioridad.SelectedIndex = -1
        txtNombreCompleto.Clear()
        txtTelefono.Clear()
        txtReferenciasDirec.Clear()

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
                AgregarCliente.Show()
                Me.Hide()

            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Me.Close()
        InicioGestion.Show()

    End Sub

    Private Sub btnCasa_Click(sender As Object, e As EventArgs) Handles btnCasa.Click
        limpiar()
        Me.Close()
        GestionTickets.Show()

    End Sub
End Class