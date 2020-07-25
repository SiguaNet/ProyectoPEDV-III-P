Public Class Inventario
    Dim conexion As Conexion = New Conexion()
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        InicioSiguaNet.Show()
        Me.Hide()
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvInventario, "select * from INVENTARIO")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        conexion.PAOperacionesInventario(txtID.Text, txtNombre.Text, txtCantidad.Text, 1)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        conexion.PAOperacionesInventario(txtID.Text, txtNombre.Text, txtCantidad.Text, 2)
    End Sub

    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellClick
        conexion.llenarTextBox(txtID, "select idTipoAparato from INVENTARIO where idTipoAparato = '" & Val(dgvInventario.CurrentCell.Value) & "'", "idTipoAparato")
        conexion.llenarTextBox(txtNombre, "select nombreTipo from INVENTARIO where idTipoAparato = '" & dgvInventario.CurrentCell.Value.ToString & "'", "nombreTipo")
        conexion.llenarTextBox(txtCantidad, "select cantidad from INVENTARIO where idTipoAparato = '" & Val(dgvInventario.CurrentCell.Value) & "'", "cantidad")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGV(dgvInventario, "select idTipoAparato, nombreTipo, cantidad from INVENTARIO where idTipoAparato = '" & Val(txtID.Text) & "'")
    End Sub
End Class