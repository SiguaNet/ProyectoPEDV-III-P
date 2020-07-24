Public Class GestionTickets
    Dim conexion As Conexion = New Conexion
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        conexion.LlenarDGV(dgvTickets, "consultaTicketsClientes")

    End Sub

    Private Sub GestionTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.LlenarDGV(dgvTickets, "consultaTicketsClientes")

    End Sub

    Private Sub dgvTickets_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentDoubleClick
        variablesGlobales.numeroIdentidad = dgvTickets.CurrentRow.Cells(0).Value.ToString()
        Me.Hide()
        InicioGestion.Show()

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Me.Hide()
        GenerarTicket.Show()

    End Sub

    Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click
        'If (GradientPanel.Height = 55) Then

        '    GradientPanel.Visible = False
        '    GradientPanel.Height = 105
        '    PanelOpciones.Height = 108
        '    TransMostrar.Show(GradientPanel)

        'Else

        '    GradientPanel.Visible = False
        '    GradientPanel.Height = 55
        '    PanelOpciones.Height = 58
        '    TransOcultar.Show(GradientPanel)

        'End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub
End Class