Public Class Personal
    Dim conexion As Conexion = New Conexion()
    Private Sub Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.llenarComboBox(cmbSector, "select idSector from SECTORES", "idSector")
        conexion.llenarComboBox(cmbVehiculo, "select idVehiculo from RECURSOS_MOTORES", "idVehiculo")
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvPersonal, "consultaTablaPersonal")
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        conexion.LlenarDGV(dgvPersonal, "consultaTodoPersonal")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        'conexion.PAconsultaIndividual(dgvPersonal, Val(txtID.Text))
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            conexion.PAinsertarUsuarioLogin(txtID.Text, txtNombres.Text, txtPrimer.Text, txtSegundo.Text, Val(txtTelefono.Text),
                                        Val(txtCasa.Text), cmbSector.SelectedIndex + 1, txtReferencia.Text, cmbVehiculo.SelectedIndex + 1)
        Catch ex As Exception
            MessageBox.Show("Error", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            conexion.PAmodificarPersonal(txtID.Text, txtNombres.Text, txtPrimer.Text, txtSegundo.Text, Val(txtTelefono.Text),
                                        Val(txtCasa.Text), cmbSector.SelectedIndex + 1, txtReferencia.Text, cmbVehiculo.SelectedIndex + 1)
        Catch ex As Exception
            MessageBox.Show("Error", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conexion.PAmodificarPersonal(txtID.Text, txtNombres.Text, txtPrimer.Text, txtSegundo.Text, Val(txtTelefono.Text),
                                        Val(txtCasa.Text), cmbSector.SelectedIndex + 1, txtReferencia.Text, cmbVehiculo.SelectedIndex + 1)
    End Sub
End Class