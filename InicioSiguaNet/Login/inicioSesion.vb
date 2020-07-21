Public Class inicioSesion

    Dim Conexion As Conexion = New Conexion

    Private Sub inicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.abrirConexion()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If txtUsuario.Text <> String.Empty And txtContrasena.Text <> String.Empty Then

            If txtUsuario.Text = usuario And txtContrasena.Text = contrasena Then
                usuario = "?"
                contrasena = "?"
                MessageBox.Show("Esta es su primera vez iniciando el sistema, por favor cree un usuario/personal para continuar!", "Requisito de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                insertarPersonalLogin.Show()

            ElseIf Conexion.comprobarUsuario(txtUsuario.Text, Conexion.Encriptar(txtContrasena.Text)) = True Then
                MsgBox("hola q ase")
                InicioSiguaNet.Show()
            Else
                MessageBox.Show("Usuario o Contraseña incorrectos!", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Else
            MessageBox.Show("Introduzca Valores!", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


End Class