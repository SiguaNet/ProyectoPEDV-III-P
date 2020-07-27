Public Class TicketsCliente
    Dim conexion As Conexion = New Conexion
    Private Sub TicketsCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numeroID As String
        numeroID = variablesGlobales.numeroIdentidad

        conexion.LlenarDGVPorIdentidad(dgvTicketsCliente, "consultaInformacionClienteLety", "@numeroIdentidad", numeroID)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        InicioGestion.Show()

    End Sub

    Private Sub btnCasa_Click(sender As Object, e As EventArgs) Handles btnCasa.Click
        Me.Close()
        GestionTickets.Show()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim numeroID As String
        numeroID = variablesGlobales.numeroIdentidad

        conexion.LlenarDGVPorIdentidad(dgvTicketsCliente, "consultaInformacionClienteLety", "@numeroIdentidad", numeroID)

    End Sub

    Private Sub dgvTicketsCliente_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicketsCliente.CellContentDoubleClick


    End Sub
End Class