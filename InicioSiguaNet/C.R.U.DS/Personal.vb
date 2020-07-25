Public Class Personal
    Dim conexion As Conexion = New Conexion()
    Private Sub Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.llenarComboBox(cmbSector, "select idSector from SECTORES", "idSector")
        conexion.llenarComboBox(cmbVehiculo, "select idVehiculo from RECURSOS_MOTORES", "idVehiculo")
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvPersonal, "select * from PERSONAL")
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        conexion.LlenarDGV(dgvPersonal, "consultaTodoPersonal")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGVPorIdentidad(dgvPersonal, "consultaPersonal", "@idPersonal", txtID.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            conexion.PAOperacionesUsuarioPersonal(txtID.Text, txtNombres.Text, txtPrimer.Text, txtSegundo.Text, Val(txtTelefono.Text),
                                        Val(txtCasa.Text), cmbSector.SelectedIndex + 1, txtReferencia.Text, cmbVehiculo.SelectedIndex + 1, cmbEstado.Text, 1)
            MessageBox.Show("Usuario se añadio exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            conexion.PAOperacionesUsuarioPersonal(txtID.Text, txtNombres.Text, txtPrimer.Text, txtSegundo.Text, Val(txtTelefono.Text),
                                        Val(txtCasa.Text), cmbSector.SelectedIndex + 1, txtReferencia.Text, cmbVehiculo.SelectedIndex + 1, cmbEstado.Text, 2)
            MessageBox.Show("Usuario se modifico exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error de modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        InicioSiguaNet.Show()
        Me.Hide()
    End Sub
    'Val(dgvPersonal.CurrentCell.Value)
    'dgvPersonal.CurrentCell.Value.ToString
    Private Sub dgvPersonal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonal.CellClick
        conexion.llenarTextBox(txtID, "select idPersonal from PERSONAL where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "idPersonal")
        conexion.llenarTextBox(txtIdentidad, "select numeroIdentidad from PERSONAL where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "numeroIdentidad")
        conexion.llenarTextBox(txtNombres, "select nombres from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "nombres")
        conexion.llenarTextBox(txtPrimer, "select primerApellido from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "primerApellido")
        conexion.llenarTextBox(txtSegundo, "select segundoApellido from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "segundoApellido")
        conexion.llenarTextBox(txtTelefono, "select numeroTelefono from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "numeroTelefono")
        conexion.llenarTextBox(txtCasa, "select numeroCasa from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "numeroCasa")
    End Sub
End Class