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
            If conexion.PAOperacionesUsuarioPersonal(txtID.Text, txtNombres.Text, txtPrimer.Text, txtSegundo.Text, Val(txtTelefono.Text),
                                        Val(txtCasa.Text), cmbSector.SelectedIndex + 1, txtReferencia.Text, cmbVehiculo.SelectedIndex + 1, cmbEstado.Text, 1) = 0 Then

                MessageBox.Show("Usuario se añadio exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error de insercion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If conexion.PAOperacionesUsuarioPersonal(txtID.Text, txtNombres.Text, txtPrimer.Text, txtSegundo.Text, Val(txtTelefono.Text),
                                        Val(txtCasa.Text), cmbSector.SelectedIndex + 1, txtReferencia.Text, cmbVehiculo.SelectedIndex + 1, cmbEstado.Text, 2) = 0 Then

                MessageBox.Show("Usuario se modifico exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error de modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AdministracionCRUD.Show()
        Me.Hide()
    End Sub
    Private Sub dgvPersonal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonal.CellClick
        conexion.llenarTextBox(txtID, "select idPersonal from PERSONAL where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "idPersonal")
        conexion.llenarTextBox(txtIdentidad, "select numeroIdentidad from PERSONAL where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "numeroIdentidad")
        conexion.llenarTextBox(txtNombres, "select nombres from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "nombres")
        conexion.llenarTextBox(txtPrimer, "select primerApellido from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "primerApellido")
        conexion.llenarTextBox(txtSegundo, "select segundoApellido from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "segundoApellido")
        conexion.llenarTextBox(txtTelefono, "select numeroTelefono from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "numeroTelefono")
        conexion.llenarTextBox(txtCasa, "select numeroCasa from DATOS_PERSONAS where numeroIdentidad = '" & dgvPersonal.CurrentCell.Value.ToString & "'", "numeroCasa")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        conexion.limpiar(Me.GroupBox1)
        cmbEstado.SelectedIndex = -1
        cmbSector.SelectedIndex = -1
        cmbVehiculo.SelectedIndex = -1
    End Sub
End Class