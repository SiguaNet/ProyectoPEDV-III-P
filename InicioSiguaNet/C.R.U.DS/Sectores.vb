Public Class Sectores
    Dim conexion As Conexion = New Conexion()
    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvSector, "select * from SECTORES")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGV(dgvSector, "select idSector, barrio from SECTORES where idSector = '" & Val(txtID.Text) & "'")
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AdministracionCRUD.Show()
        Me.Hide()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        Try
            If conexion.PAOperacionesSectores(txtID.Text, txtBarrios.Text, 1) = 0 Then

                MessageBox.Show("Sector se agrego exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            If conexion.PAOperacionesSectores(txtID.Text, txtBarrios.Text, 2) = 0 Then

                MessageBox.Show("Sector se modifico exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvSector_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSector.CellClick
        conexion.llenarTextBox(txtID, "select idSector from SECTORES where idSector = '" & Val(dgvSector.CurrentCell.Value) & "'", "idSector")
        conexion.llenarTextBox(txtBarrios, "select barrio from SECTORES where idSector = '" & Val(dgvSector.CurrentCell.Value) & "'", "barrio")
    End Sub
End Class