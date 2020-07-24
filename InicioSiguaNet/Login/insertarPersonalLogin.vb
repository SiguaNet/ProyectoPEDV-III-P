Public Class insertarPersonalLogin

    Dim Conexion As Conexion = New Conexion

    Private Sub insertarPersonalLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.llenarComboBox(cmbBarri, "select barrio from SECTORES", "barrio")
        Conexion.llenarComboBox(cmbIdVehiculo, "select idVehiculo from RECURSOS_MOTORES", "idVehiculo")
        btnRegistar.Enabled = False
        txtConfirmContra.Enabled = False
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        If txtIdentidad.Text <> String.Empty And txtNombre.Text <> String.Empty And txtPrimerApe.Text <> String.Empty And txtNumCasa.Text <> String.Empty And
            cmbBarri.Text <> String.Empty And txtContrasena.Text <> String.Empty And txtConfirmContra.Text <> String.Empty Then
            'If IsNumeric(txtIdentidad) = True And IsNumeric(txtNombre) = False And IsNumeric(txtPrimerApe) = False And IsNumeric(txtSegundoApell) = False And
            'IsNumeric(txtNumTel) = True And IsNumeric(cmbBarri) = True And IsNumeric(cmbIdVehiculo) = True Then
            If btnRegistar.Enabled = True Then
                If Conexion.PAOperacionesUsuarioPersonal(txtIdentidad.Text, txtNombre.Text, txtPrimerApe.Text, txtSegundoApell.Text,
                                                    Val(txtNumTel.Text), Val(txtNumCasa.Text), cmbBarri.SelectedIndex + 1, txtRefDireccion.Text,
                                                       cmbIdVehiculo.SelectedIndex + 1, "Libre", 1) = 0 Then
                    If Conexion.PAOperacionesUsuarioLogin(txtIdentidad.Text, Conexion.Encriptar(txtContrasena.Text), 1) = 0 Then
                        MessageBox.Show("Registro Realizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                End If
            End If
            'Else
            'MessageBox.Show("No se permiten valores numericos!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'End If
        Else
            MessageBox.Show("Ingrese los valores requeridos!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtConfirmContra_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmContra.TextChanged
        If txtContrasena.Text = txtConfirmContra.Text Then
            btnRegistar.Enabled = True
            erroresCon.Active = False
        Else
            btnRegistar.Enabled = False
            erroresCon.SetToolTip(txtConfirmContra, "Las contraseñas deben coincidir")
            erroresCon.ToolTipIcon = ToolTipIcon.Error
        End If
    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged
        If txtContrasena.TextLength >= 4 And txtContrasena.TextLength <= 8 Then
            txtConfirmContra.Enabled = True
        Else
            btnRegistar.Enabled = False
            erroresCon.SetToolTip(txtConfirmContra, "Contraseñas de entre 4-8 caracteres")
            erroresCon.ToolTipIcon = ToolTipIcon.Error
            txtConfirmContra.Enabled = False
        End If
    End Sub
End Class