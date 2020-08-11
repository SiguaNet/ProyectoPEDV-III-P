Public Class Planes_Internet
    Dim conexion As Conexion = New Conexion()

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvPlanes, "select * from PLANES_INTERNET")
    End Sub
    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGVPorIdentidad(dgvPlanes, "consultaPaqueteCliente", "@numeroIdentidad", txtIDCliente.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If conexion.PAOperacionesPlanes(txtIDPaquete.Text, txtNombrePaquete.Text, txtVelocidad.Text, txtPrecio.Text, 1) = 0 Then

                MessageBox.Show("Plan se añadio exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al añadir plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If conexion.PAOperacionesPlanes(txtIDPaquete.Text, txtNombrePaquete.Text, txtVelocidad.Text, txtPrecio.Text, 2) = 0 Then

                MessageBox.Show("Plan se modifico exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar recurso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error de modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AdministracionCRUD.Show()
        Me.Close()
    End Sub

    Private Sub dgvRecursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanes.CellClick
        conexion.llenarTextBox(txtIDPaquete, "select idPaquete from PLANES_INTERNET where idPaquete = '" & Val(dgvPlanes.CurrentCell.Value) & "'", "idPaquete")
        conexion.llenarTextBox(txtNombrePaquete, "select nombrePaquete from PLANES_INTERNET where idPaquete = '" & Val(dgvPlanes.CurrentCell.Value) & "'", "nombrePaquete")
        conexion.llenarTextBox(txtVelocidad, "select velocidad from PLANES_INTERNET where idPaquete = '" & Val(dgvPlanes.CurrentCell.Value) & "'", "velocidad")
        conexion.llenarTextBox(txtPrecio, "select precio from PLANES_INTERNET where idPaquete = '" & Val(dgvPlanes.CurrentCell.Value) & "'", "precio")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        conexion.limpiar(Me.GroupBox1)
    End Sub
End Class