Public Class Inventario
    Dim conexion As Conexion = New Conexion()
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AdministracionCRUD.Show()
        Me.Close()
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvInventario, "select * from INVENTARIO")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If conexion.PAOperacionesInventario(txtID.Text, txtNombre.Text, txtCantidad.Text, 1) = 0 Then

                MessageBox.Show("Inventario se agrego exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If conexion.PAOperacionesInventario(txtID.Text, txtNombre.Text, txtCantidad.Text, 2) = 0 Then

                MessageBox.Show("Inventario se modifico exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellClick
        conexion.llenarTextBox(txtID, "select idTipoAparato from INVENTARIO where idTipoAparato = '" & Val(dgvInventario.CurrentCell.Value) & "'", "idTipoAparato")
        conexion.llenarTextBox(txtNombre, "select nombreTipo from INVENTARIO where idTipoAparato = '" & dgvInventario.CurrentCell.Value.ToString & "'", "nombreTipo")
        conexion.llenarTextBox(txtCantidad, "select cantidad from INVENTARIO where idTipoAparato = '" & Val(dgvInventario.CurrentCell.Value) & "'", "cantidad")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGV(dgvInventario, "select idTipoAparato, nombreTipo, cantidad from INVENTARIO where idTipoAparato = '" & Val(txtID.Text) & "'")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        conexion.limpiar(Me.GroupBox1)
    End Sub
End Class