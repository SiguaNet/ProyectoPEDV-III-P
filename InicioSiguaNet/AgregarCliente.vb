Imports System.ComponentModel

Public Class AgregarCliente
    Dim conexion As Conexion = New Conexion
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim numeroIdentidad, nombres, primerApellido, segundoApellido, referenciasDireccion, estadoC As String
        Dim numeroTelefono, numeroCasa, idSector, idPaquete, pagosCliente As Integer

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

        Try
            If Me.ValidateChildren And txtNumeroID.Text <> String.Empty And txtNombres.Text <> String.Empty And txtPApellido.Text <> String.Empty And txtTelefono.Text <> String.Empty And txtNumCasa.Text <> String.Empty And Val(txtNumCasa.Text) - Int(Val(txtNumCasa.Text)) = 0 And txtRefDirec.Text <> String.Empty Then

                If (conexion.PAOperacionesPersonaCL(numeroIdentidad, nombres, primerApellido, segundoApellido, numeroTelefono, numeroCasa, idSector, referenciasDireccion, idPaquete, pagosCliente, estadoC, 1) = 0) Then
                    If conexion.PAOperacionesFactura(0, numeroIdentidad, String.Format("{0:G}", DateTime.Now), 1) = 1 Then
                        MessageBox.Show("Cliente ingresado satisfactoriamente", "Registro cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        conexion.llenarComboBox(cmbPaquetes, "select nombrePaquete from PLANES_INTERNET", "nombrePaquete")
        conexion.llenarComboBox(cmbBarrios, "select barrio from SECTORES", "barrio")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
        txtNumeroID.Text = variablesGlobales.numeroIdentidad

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
        If Val(numID.Length) = 13 And numID = "" Then
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
        If Val(numTel.Length) = 13 And numTel = "" Then
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
End Class