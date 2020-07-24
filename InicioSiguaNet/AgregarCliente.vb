Public Class AgregarCliente
    Dim conexion As Conexion = New Conexion
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim numeroIdentidad, nombres, primerApellido, segundoApellido, referenciasDireccion, estadoC As String
        Dim numeroTelefono, numeroCasa, idSector, idPaquete, pagosCliente As Integer

        numeroIdentidad = txtNumeroID.Text
        nombres = txtNombres.Text
        primerApellido = txtPApellido.Text
        segundoApellido = txtSApellido.Text
        numeroTelefono = txtTelefono.Text
        numeroCasa = txtNumCasa.Text
        idSector = cmbBarrios.SelectedIndex + 1
        referenciasDireccion = txtRefDirec.Text
        idPaquete = cmbPaquetes.SelectedIndex + 1
        pagosCliente = 1
        estadoC = "Al día"

        Try
            If (conexion.PAOperacionesPersonaCL(numeroIdentidad, nombres, primerApellido, segundoApellido, numeroTelefono, numeroCasa, idSector, referenciasDireccion, idPaquete, pagosCliente, estadoC, 1) = 0) Then
                MessageBox.Show("Cliente ingresado satisfactoriamente", "Registro cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al registrar cliente", "Registro cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
End Class