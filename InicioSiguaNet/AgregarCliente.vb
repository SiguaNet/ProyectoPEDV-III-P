Imports System.ComponentModel
Imports System.Runtime.InteropServices
Public Class AgregarCliente
    Dim conexion As Conexion = New Conexion
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim numeroIdentidad, nombres, primerApellido, segundoApellido, referenciasDireccion, estadoC, estado, prioridad, nota, fechaInicio, fechaFin As String
        Dim numeroTelefono, numeroCasa, idSector, idPaquete, pagosCliente, idTicket, idPersonal, idOperacion, cantEr, cantAn, inveEr, inveAn, totalEr, totalAn As Integer

        idTicket = 0
        idPersonal = cmbPersonal.SelectedIndex + 1
        estado = "Pendiente"
        numeroIdentidad = txtNumeroID.Text
        nombres = convertirMayusMin(Me.txtNombres.Text)
        primerApellido = convertirMayusMin(Me.txtPApellido.Text)
        segundoApellido = convertirMayusMin(Me.txtSApellido.Text)
        numeroTelefono = txtTelefono.Text
        numeroCasa = txtNumCasa.Text
        idSector = cmbBarrios.SelectedIndex + 1
        referenciasDireccion = LCase(txtRefDirec.Text)
        idPaquete = cmbPaquetes.SelectedIndex + 1
        pagosCliente = variablesGlobales.cantMesesG
        estadoC = "Al día"
        prioridad = "Alta"
        idOperacion = 1
        nota = txtNota.Text
        fechaInicio = String.Format("{0:G}", DateTime.Now)
        fechaFin = ""
        cantAn = txtAN.Text
        cantEr = txtER.Text
        inveAn = Val(conexion.obtenerVariableEntera("select cantidad from INVENTARIO where nombreTipo = 'Antenas'", "cantidad"))
        inveEr = Val(conexion.obtenerVariableEntera("select cantidad from INVENTARIO where nombreTipo = 'Enrutadores'", "cantidad"))

        Try
            If Me.ValidateChildren And txtNumeroID.Text <> String.Empty And txtNombres.Text <> String.Empty And txtPApellido.Text <> String.Empty And txtTelefono.Text <> String.Empty And txtNumCasa.Text <> String.Empty And Val(txtNumCasa.Text) - Int(Val(txtNumCasa.Text)) = 0 Then

                If (conexion.PAOperacionesPersonaCL(numeroIdentidad, nombres, primerApellido, segundoApellido, numeroTelefono, numeroCasa, idSector, referenciasDireccion, idPaquete, pagosCliente, estadoC, 1) = 0) Then

                    If conexion.PAOperacionesFactura(0, numeroIdentidad, String.Format("{0:G}", DateTime.Now), 1) = 0 Then
                        MessageBox.Show("Cliente ingresado satisfactoriamente", "Registro cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If (conexion.PAOperacionesGestionTickets(idTicket, numeroIdentidad, idPersonal, estado, prioridad, idOperacion, nota, fechaInicio, fechaFin, 1) = 0) Then
                            conexion.EjecutarComando("update PERSONAL set estado = 'Ocupado' where idPersonal = '" & idPersonal & "'")
                            MessageBox.Show("Ticket registrado exitosamente", "Generar ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            totalAn = inveAn - cantAn
                            totalEr = inveEr - cantEr

                            conexion.PAOperacionesInventario(1, "Antenas", totalAn, 2)
                            conexion.PAOperacionesInventario(2, "Enrutadores", totalEr, 2)
                        Else
                            MessageBox.Show("Error al registrar ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        HcantEfectivoTotal += conexion.obtenerVariableDecimal("select pli.precio from PLANES_INTERNET pli  inner join CLIENTES c ON pli.idPaquete = c.idPaquete inner join FACTURA f on c.numeroIdentidad = f.numeroIdentidadC where c.numeroIdentidad = '" & numeroIdentidad & "'", "precio")
                    Else
                        MessageBox.Show("Error al registrar cliente", "Registro cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Else
                MessageBox.Show("Por favor ingrese todos los datos solicitados", "Registro cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNumeroID.Text = variablesGlobales.numeroIdentidad
        conexion.llenarComboBox(cmbPaquetes, "select nombrePaquete from PLANES_INTERNET", "nombrePaquete")
        conexion.llenarComboBox(cmbBarrios, "select barrio from SECTORES", "barrio")
        conexion.llenarComboBox(cmbPersonal, "select idPersonal from PERSONAL where estado <> 'Eliminado'", "idPersonal")

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        InicioGestion.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub
    Function convertirMayusMin(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a

    End Function

    Private Sub txtNumeroID_Validating(sender As Object, e As CancelEventArgs) Handles txtNumeroID.Validating
        Dim numID As String
        numID = txtNumeroID.Text
        If Val(numID.Length) = 13 And numID <> "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero de identidad valido")
        End If
    End Sub

    Private Sub txtNombres_Validating(sender As Object, e As CancelEventArgs) Handles txtNombres.Validating

        If txtNombres.Text <> "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub txtPApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtPApellido.Validating
        If txtPApellido.Text <> "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtTelefono_Validating(sender As Object, e As CancelEventArgs) Handles txtTelefono.Validating
        Dim numTel As String
        numTel = txtTelefono.Text
        If Val(numTel.Length) = 8 And numTel <> "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero de teléfono valido")
        End If
    End Sub

    Private Sub txtRefDirec_MouseHover(sender As Object, e As EventArgs) Handles txtRefDirec.MouseHover
        ToolTip.SetToolTip(txtRefDirec, "Tiene un límite de 80 caracteres")
        ToolTip.ToolTipTitle = "Referencias"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnCasa_Click(sender As Object, e As EventArgs) Handles btnCasa.Click
        Me.Close()
        GestionTickets.Show()

    End Sub

    Private Sub cmbPaquetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaquetes.SelectedIndexChanged
        conexion.llenarTextBox(txtVelocidad, "select velocidad from PLANES_INTERNET where nombrePaquete = '" & cmbPaquetes.Text & "'", "velocidad")
        conexion.llenarTextBox(txtPrecio, "select precio from PLANES_INTERNET where nombrePaquete = '" & cmbPaquetes.Text & "'", "precio")


    End Sub

    Private Sub cmbPersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPersonal.SelectedIndexChanged
        Dim IdPersonal As Integer

        IdPersonal = cmbPersonal.Text

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