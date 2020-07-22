Public Class PagosFacturas

    Dim Conexion As Conexion = New Conexion

    Private Sub PagosFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBuscar.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Conexion.LlenarDGVPorIdentidad(dgvFacturas, "consultaInformacionFacturas", "@numeroIdentidad", txtIdentidad.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMesPago.SelectedIndexChanged

    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty Then
            If IsNumeric(txtIdentidad.Text) = True Then
                Dim cant As Integer = Val(Conexion.obtenerVariableEntera("select pagosCliente FROM CLIENTES where numeroIdentidad = '" & txtIdentidad.Text & "'", "pagosCliente")) + 1

                If cant = cmbMesPago.SelectedIndex + 1 Then
                    Conexion.EjecutarComando("update CLIENTES set pagosCliente = '" & cant & "' where numeroIdentidad = '" & txtIdentidad.Text & "'")
                    Conexion.PAOperacionesFactura(0, txtIdentidad.Text, String.Format("{0:G}", DateTime.Now), 1)
                    Conexion.LlenarDGVPorIdentidad(dgvFacturas, "consultaInformacionFacturas", "@numeroIdentidad", txtIdentidad.Text)
                Else
                    MessageBox.Show("El mes seleccionado no concuerda con su respectivo pago!", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Ingrese Valores correctos para la identidad!", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese Valores!", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged
        If txtIdentidad.TextLength > 0 And txtIdentidad.TextLength <= 13 Then
            ToolTip1.Active = False
            btnBuscar.Enabled = True
        Else
            btnBuscar.Enabled = False
            ToolTip1.Active = True
            ToolTip1.SetToolTip(txtIdentidad, "Identidad entre 0-13 caracteres")
            ToolTip1.ToolTipIcon = ToolTipIcon.Info
        End If
    End Sub
End Class