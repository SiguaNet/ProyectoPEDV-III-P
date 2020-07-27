Public Class RealizarTickets
    Dim conexion As Conexion = New Conexion
    Private Sub btnRealizados_Click(sender As Object, e As EventArgs) Handles btnRealizados.Click
        dgvRealizados.Visible = True
        dgvPendientes.Visible = False

        conexion.LlenarDGVPorIdentidad(dgvRealizados, "consultaEstadoTickets", "@codigoOP", 1)

    End Sub
    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        dgvRealizados.Visible = False
        dgvPendientes.Visible = True

        conexion.LlenarDGVPorIdentidad(dgvPendientes, "consultaEstadoTickets", "@codigoOP", 2)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        GestionTickets.Show()

    End Sub

    Private Sub dgvPendientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendientes.CellContentDoubleClick
        variablesGlobales.idTicketAct = dgvPendientes.CurrentRow.Cells(0).Value.ToString()
        variablesGlobales.numeroIdentidad = dgvPendientes.CurrentRow.Cells(3).Value.ToString()
        variablesGlobales.fechaEstablecida = dgvPendientes.CurrentRow.Cells(13).Value.ToString()
        variablesGlobales.idTecnico = dgvPendientes.CurrentRow.Cells(11).Value.ToString()
        variablesGlobales.nombreOpera = dgvPendientes.CurrentRow.Cells(6).Value.ToString()
        variablesGlobales.idOpera = dgvPendientes.CurrentRow.Cells(5).Value.ToString()

        Me.Close()
        ActualizarTicket.Show()

    End Sub
End Class