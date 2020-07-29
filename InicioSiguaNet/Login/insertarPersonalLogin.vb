Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class insertarPersonalLogin

    Dim Conexion As Conexion = New Conexion

    Private Sub insertarPersonalLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.llenarComboBox(cmbBarri, "select barrio from SECTORES", "barrio")
        Conexion.llenarComboBox(cmbIdVehiculo, "select idVehiculo from RECURSOS_MOTORES", "idVehiculo")
        btnRegistar.Enabled = False
        txtConfirmContra.Enabled = False
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        Dim idVehiculo
        If cmbIdVehiculo.SelectedItem.ToString <> String.Empty Then
            idVehiculo = cmbIdVehiculo.SelectedIndex + 1
        Else
            idVehiculo = DBNull.Value
        End If
        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty And txtNombre.Text <> String.Empty And txtPrimerApe.Text <> String.Empty And txtNumCasa.Text <> String.Empty And
            cmbBarri.Text <> String.Empty And txtContrasena.Text <> String.Empty And txtConfirmContra.Text <> String.Empty And txtCorreo.Text <> String.Empty Then
            If IsNumeric(txtIdentidad.Text) = True And IsNumeric(txtNombre.Text) = False And IsNumeric(txtPrimerApe.Text) = False And IsNumeric(txtSegundoApell.Text) = False And
            IsNumeric(txtNumTel.Text) = True Then
                If txtIdentidad.Text.Length = 13 And txtNumTel.Text.Length = 8 Then
                    If verificarCorreo(txtCorreo.Text) = True Then
                        If btnRegistar.Enabled = True Then
                            If Conexion.PAOperacionesUsuarioPersonal(txtIdentidad.Text, txtNombre.Text, txtPrimerApe.Text, txtSegundoApell.Text,
                                                        Val(txtNumTel.Text), Val(txtNumCasa.Text), cmbBarri.SelectedIndex + 1, txtRefDireccion.Text,
                                                           idVehiculo, "Libre", 1) = 0 Then
                                If Conexion.PAOperacionesUsuarioLogin(txtIdentidad.Text, Conexion.Encriptar(txtContrasena.Text), txtCorreo.Text, 1) = 0 Then

                                    MessageBox.Show("Registro Realizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Me.Close()
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("Verifique su correo!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Verifique la longuitud de los campos!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No se permiten valores numericos, excepto en identidad!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese los valores requeridos!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function verificarCorreo(strCorreo As String) As Boolean
        Static emailRegex As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailRegex.IsMatch(strCorreo)
    End Function

    Private Sub txtConfirmContra_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmContra.TextChanged
        If txtContrasena.Text = txtConfirmContra.Text Then
            btnRegistar.Enabled = True
            ToolTip1.Active = False
        Else
            btnRegistar.Enabled = False
            ToolTip1.SetToolTip(txtConfirmContra, "Las contraseñas deben coincidir")
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
        End If
    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged
        If txtContrasena.TextLength >= 4 And txtContrasena.TextLength <= 8 Then
            txtConfirmContra.Enabled = True
        Else
            btnRegistar.Enabled = False
            ToolTip1.SetToolTip(txtConfirmContra, "Contraseñas de entre 4-8 caracteres")
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            txtConfirmContra.Enabled = False
        End If
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrimerApe_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerApe.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNumCasa_Validating(sender As Object, e As CancelEventArgs) Handles txtNumCasa.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbBarri_Validating(sender As Object, e As CancelEventArgs) Handles cmbBarri.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtCorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtConfirmContra_Validating(sender As Object, e As CancelEventArgs) Handles txtConfirmContra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip1.SetToolTip(txtIdentidad, "Introduzca el numero de identidad")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Introduzca sus nombres")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrimerApe_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerApe.MouseHover
        ToolTip1.SetToolTip(txtPrimerApe, "Introduzca su primer apellido")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoApell_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoApell.MouseHover
        ToolTip1.SetToolTip(txtSegundoApell, "Introduzca su segundo apellido")
        ToolTip1.ToolTipTitle = "Opcional"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCorreo_MouseHover(sender As Object, e As EventArgs) Handles txtCorreo.MouseHover
        ToolTip1.SetToolTip(txtCorreo, "sucorreo@domini.com")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class