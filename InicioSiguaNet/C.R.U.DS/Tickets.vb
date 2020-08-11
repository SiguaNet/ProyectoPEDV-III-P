Public Class Tickets
    Dim conexion As Conexion = New Conexion()
    Private Sub Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.llenarComboBox(cmbOperacion, "select idOperacion from OPERACIONES", "idOperacion")
        conexion.llenarComboBox(cmbPersonal, "select idPersonal from PERSONAL", "idPersonal")
        conexion.llenarComboBox(cmbIDCliente, "select numeroIdentidad from CLIENTES", "numeroIdentidad")
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvTickets, "select * from GESTION_TICKETS")
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        conexion.LlenarDGV(dgvTickets, "consultaTicketsClientes")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim fechaInicio, fechaFin As String
        fechaInicio = String.Format("{0:G}", DateTime.Now)
        fechaFin = ""
        Try
            If conexion.PAOperacionesGestionTickets(txtIDTicket.Text, cmbIDCliente.SelectedItem, cmbPersonal.SelectedIndex + 1, cmbEstado.SelectedItem, cmbPrioridad.SelectedItem,
                                                cmbOperacion.SelectedIndex + 1, txtNotas.Text, fechaInicio, fechaFin, 1) = 0 Then

                MessageBox.Show("Ticket se añadio exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error de insercion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim fechaInicio, fechaFin As String
        fechaInicio = String.Format("{0:G}", DateTime.Now)
        fechaFin = ""
        Try
            If conexion.PAOperacionesGestionTickets(txtIDTicket.Text, cmbIDCliente.SelectedItem, cmbPersonal.SelectedIndex + 1, cmbEstado.SelectedItem, cmbPrioridad.SelectedItem,
                                                cmbOperacion.SelectedIndex + 1, txtNotas.Text, fechaInicio, fechaFin, 2) = 0 Then

                MessageBox.Show("Ticket se modifico exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error de modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AdministracionCRUD.Show()
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If conexion.EjecutarComando("delete GESTION_TICKETS where idTicket = '" & Val(txtIDTicket.Text) & "'") = 0 Then

                MessageBox.Show("Ticket se elimino exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class