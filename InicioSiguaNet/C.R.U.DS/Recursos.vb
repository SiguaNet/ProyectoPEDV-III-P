Public Class Recursos
    Dim conexion As Conexion = New Conexion()

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvRecursos, "select * from RECURSOS_MOTORES")
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        conexion.LlenarDGV(dgvRecursos, "consultaTodoRecursosMotores")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGVPorIdentidad(dgvRecursos, "consultaRecursosMotores", "@idVehiculo", txtVehiculo.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            conexion.PAOperacionesRecursosMotores(txtVehiculo.Text, txtMatricula.Text, txtModelo.Text, 1)
            MessageBox.Show("Recurso se añadio exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            conexion.PAOperacionesRecursosMotores(txtVehiculo.Text, txtMatricula.Text, txtModelo.Text, 2)
            MessageBox.Show("Recurso se modifico exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error de modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            conexion.PAEliminarRecursosMotores(txtVehiculo.Text)
            MessageBox.Show("Recurso se elimino exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        InicioSiguaNet.Show()
        Me.Hide()
    End Sub

    Private Sub dgvRecursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecursos.CellClick
        conexion.llenarTextBox(txtVehiculo, "select idVehiculo from RECURSOS_MOTORES where idVehiculo = '" & Val(dgvRecursos.CurrentCell.Value) & "'", "idVehiculo")
        conexion.llenarTextBox(txtMatricula, "select matricula from RECURSOS_MOTORES where idVehiculo = '" & Val(dgvRecursos.CurrentCell.Value) & "'", "matricula")
        conexion.llenarTextBox(txtModelo, "select modelo from RECURSOS_MOTORES where idVehiculo = '" & Val(dgvRecursos.CurrentCell.Value) & "'", "modelo")
    End Sub

End Class