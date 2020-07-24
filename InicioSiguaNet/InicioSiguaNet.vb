Public Class InicioSiguaNet
    Dim Conexion As Conexion = New Conexion

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        Personal.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecursos_Click(sender As Object, e As EventArgs) Handles btnRecursos.Click
        Recursos.Show()
        Me.Hide()
    End Sub

    Private Sub InicioSiguaNet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.LlenarDGV(DbgClientes, "consultaInformacionClientes")
    End Sub

    Private Sub DbgClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbgClientes.CellContentDoubleClick
        variablesGlobales.numeroIdentidad = DbgClientes.CurrentRow.Cells(0).Value.ToString()
        Me.Hide()
        FichaCliente.Show()
    End Sub
End Class
