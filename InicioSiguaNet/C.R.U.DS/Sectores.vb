Public Class Sectores
    Dim conexion As Conexion = New Conexion()
    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        conexion.LlenarDGV(dgvSector, "select * from SECTORES")
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        conexion.LlenarDGV(dgvSector, "select idSector, barrio from SECTORES where idSector = '" & Val(txtID.Text) & "'")
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        InicioSiguaNet.Show()
        Me.Hide()
    End Sub
End Class