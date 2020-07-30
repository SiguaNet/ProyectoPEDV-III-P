Public Class Clientes
    Dim conexion As Conexion = New Conexion

    Function convertirMayusMin(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a

    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
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
        estadoC = cmbEstado.SelectedItem
        pagosCliente = variablesGlobales.cantMesesG

        Try
            If Me.ValidateChildren And txtNumeroID.Text <> String.Empty And txtNombres.Text <> String.Empty And txtPApellido.Text <> String.Empty And txtTelefono.Text <> String.Empty And txtNumCasa.Text <> String.Empty And Val(txtNumCasa.Text) - Int(Val(txtNumCasa.Text)) = 0 Then

                If (conexion.PAOperacionesPersonaCL(numeroIdentidad, nombres, primerApellido, segundoApellido, numeroTelefono, numeroCasa, idSector, referenciasDireccion, idPaquete, pagosCliente, estadoC, 2) = 0) Then

                    MessageBox.Show("Modificacion exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Error modificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvClientes, "select * from CLIENTES")
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        conexion.LlenarDGV(dgvClientes, "consultaInformacionClientes")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGVPorIdentidad(dgvClientes, "consultaInformacionCliente", "@numeroIdentidad", txtNumeroID.Text)
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.vbarra.Maximum = 0
        Me.AutoScroll = True
        conexion.llenarComboBox(cmbPaquetes, "select nombrePaquete from PLANES_INTERNET", "nombrePaquete")
        conexion.llenarComboBox(cmbBarrios, "select barrio from SECTORES", "barrio")
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AdministracionCRUD.Show()
        Me.Hide()
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        conexion.llenarTextBox(txtNumeroID, "select numeroIdentidad from DATOS_PERSONAS where numeroIdentidad = '" & dgvClientes.CurrentCell.Value.ToString & "'", "numeroIdentidad")
        conexion.llenarTextBox(txtNombres, "select nombres from DATOS_PERSONAS where numeroIdentidad = '" & dgvClientes.CurrentCell.Value.ToString & "'", "nombres")
        conexion.llenarTextBox(txtPApellido, "select primerApellido from DATOS_PERSONAS where numeroIdentidad = '" & dgvClientes.CurrentCell.Value.ToString & "'", "primerApellido")
        conexion.llenarTextBox(txtSApellido, "select segundoApellido from DATOS_PERSONAS where numeroIdentidad = '" & dgvClientes.CurrentCell.Value.ToString & "'", "segundoApellido")
        conexion.llenarTextBox(txtTelefono, "select numeroTelefono from DATOS_PERSONAS where numeroIdentidad = '" & dgvClientes.CurrentCell.Value.ToString & "'", "numeroTelefono")
        conexion.llenarTextBox(txtNumCasa, "select numeroCasa from DATOS_PERSONAS where numeroIdentidad = '" & dgvClientes.CurrentCell.Value.ToString & "'", "numeroCasa")
        conexion.llenarTextBox(txtRefDirec, "select referenciasDireccion from DATOS_PERSONAS where numeroIdentidad = '" & dgvClientes.CurrentCell.Value.ToString & "'", "referenciasDireccion")
    End Sub
    Private Sub cmbPaquetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaquetes.SelectedIndexChanged
        conexion.llenarTextBox(txtVelocidad, "select velocidad from PLANES_INTERNET where nombrePaquete = '" & cmbPaquetes.Text & "'", "velocidad")
        conexion.llenarTextBox(txtPrecio, "select precio from PLANES_INTERNET where nombrePaquete = '" & cmbPaquetes.Text & "'", "precio")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        conexion.limpiar(Me.GroupBox1)
        conexion.limpiar(Me.GroupBox2)
        cmbBarrios.SelectedIndex = -1
        cmbPaquetes.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
    End Sub
End Class