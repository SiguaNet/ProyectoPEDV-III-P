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
        TxtNombres.Text = ""
        TxtPrimerApellido.Text = ""
        TxtSegundoApellido.Text = ""
        TxtId.Text = ""
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        InicioSiguaNet.Show()
        variablesGlobales.numeroIdentidad = ""
    End Sub
End Class