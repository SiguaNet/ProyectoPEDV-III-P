Public Class InicioSiguaNet
    Dim Conexion As Conexion = New Conexion

    Private Sub InicioSiguaNet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.LlenarDGV(DbgClientes, "consultaInformacionClientes")
    End Sub

    Private Sub DbgClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgClientes.CellContentDoubleClick
        variablesGlobales.numeroIdentidad = DbgClientes.CurrentRow.Cells(0).Value.ToString()
        Me.Hide()
        FichaCliente.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub btnGestionTickets_Click_1(sender As Object, e As EventArgs) Handles btnGestionTickets.Click
        Me.Hide()
        GestionTickets.Show()

    End Sub

    Private Sub btnRecursos_Click_1(sender As Object, e As EventArgs)
        Recursos.Show()
        Me.Hide()
    End Sub

    Private Sub btnPersonal_Click_1(sender As Object, e As EventArgs)
        Personal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        inicioSesion.Show()
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Me.Close()
        FacturasTodas.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Close()
        AdministracionCRUD.Show()
    End Sub
End Class
