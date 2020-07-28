Public Class AdministracionCRUD
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Close()
        InicioSiguaNet.Show()
    End Sub


    Private Sub btnInventario_Click_1(sender As Object, e As EventArgs) Handles btnInventario.Click
        Inventario.Show()
    End Sub

    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        Recursos.Show()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Personal.Show()
    End Sub

    Private Sub btnSectores_Click(sender As Object, e As EventArgs) Handles btnSectores.Click
        Sectores.Show()
    End Sub

    Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click
        Me.Close()
        GestionTickets.Show()
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Me.Close()
        FacturasTodas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class