Public Class Recursos
    Dim conexion As Conexion = New Conexion()

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvRecursos, "consultaTablaRecursosMotores")
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        conexion.LlenarDGV(dgvRecursos, "consultaTodoRecursosMotores")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click

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
End Class