Public Class InicioSiguaNet
    Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click

    End Sub

    Private Sub btnEstadoFinanciero_Click(sender As Object, e As EventArgs) Handles btnEstadoFinanciero.Click

    End Sub

    Private Sub btnFichaCliente_Click(sender As Object, e As EventArgs) Handles btnFichaCliente.Click

    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click

    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        Personal.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecursos_Click(sender As Object, e As EventArgs) Handles btnRecursos.Click
        Recursos.Show()
        Me.Hide()
    End Sub
End Class
