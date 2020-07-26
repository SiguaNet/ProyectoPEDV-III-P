Public Class FichaCliente
    Dim Conexion As Conexion = New Conexion
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TxtSegundoApellido.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Me.Close()
        AgregarCliente.Show()
    End Sub

    Private Sub TxtNombres_TextChanged(sender As Object, e As EventArgs) Handles TxtNombres.TextChanged

    End Sub

    Private Sub FichaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.Text = variablesGlobales.numeroIdentidad
        Conexion.llenarTextBox(TxtNombres, "select nombres from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "nombres")
        Conexion.llenarTextBox(TxtPrimerApellido, "select primerApellido from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "primerApellido")
        Conexion.llenarTextBox(TxtSegundoApellido, "select segundoApellido from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "segundoApellido")
        Conexion.llenarTextBox(TxtTelefono, "select numeroTelefono from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "numeroTelefono")
        Conexion.llenarTextBox(TxtDireccion, "select referenciasDireccion from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "referenciasDireccion")
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        InicioSiguaNet.Show()
        variablesGlobales.numeroIdentidad = ""
    End Sub

    Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click

    End Sub

    Private Sub btnCrearTicket_Click(sender As Object, e As EventArgs) Handles btnCrearTicket.Click
        variablesGlobales.numeroIdentidad = TxtId.Text
        Me.Close()
        GenerarTicket.Show()

    End Sub
End Class