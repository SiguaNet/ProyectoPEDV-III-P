Public Class FichaCliente
    Dim Conexion As Conexion = New Conexion

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Me.Close()
        AgregarCliente.Show()
    End Sub

    Private Sub FichaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim estado As String

        TxtId.Text = variablesGlobales.numeroIdentidad
        Conexion.llenarTextBox(TxtNombres, "select nombres from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "nombres")
        Conexion.llenarTextBox(TxtPrimerApellido, "select primerApellido from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "primerApellido")
        Conexion.llenarTextBox(TxtSegundoApellido, "select segundoApellido from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "segundoApellido")
        Conexion.llenarTextBox(TxtTelefono, "select numeroTelefono from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "numeroTelefono")
        Conexion.llenarTextBox(TxtDireccion, "select referenciasDireccion from DATOS_PERSONAS where numeroIdentidad = '" & TxtId.Text & "'", "referenciasDireccion")

        'estado = Conexion.obtenerVariableCadena("select estadoC from CLIENTES where numeroIdentidad = '" & TxtId.Text & "'", "estadoC")

        'If estado = "Eliminado" Then
        '    txtCortado.Visible = True

        'Else
        '    txtConectado.Visible = True

        'End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        InicioSiguaNet.Show()
        variablesGlobales.numeroIdentidad = ""
    End Sub

    Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click
        variablesGlobales.numeroIdentidad = TxtId.Text
        Me.Close()
        TicketsCliente.Show()

    End Sub

    Private Sub btnCrearTicket_Click(sender As Object, e As EventArgs) Handles btnCrearTicket.Click
        variablesGlobales.numeroIdentidad = TxtId.Text
        Me.Close()
        GenerarTicket.Show()

    End Sub

    Private Sub btnGestionFacturas_Click(sender As Object, e As EventArgs) Handles btnGestionFacturas.Click
        Me.Close()
        PagosFacturas.Show()

    End Sub
End Class