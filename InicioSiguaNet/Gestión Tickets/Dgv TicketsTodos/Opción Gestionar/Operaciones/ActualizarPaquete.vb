Public Class ActualizarPaquete
    Dim conexion As Conexion = New Conexion
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub ActualizarPaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdCli.Text = variablesGlobales.numeroIdentidad

        Try
            If (conexion.LlenarTablaPorIdentidad("consultaPaqueteCliente", "@numeroIdentidad", txtIdCli.Text) = 0) Then
                If tablaDatosG.Rows.Count > 0 Then

                    Dim dat(3) As Object

                    For i As Integer = 0 To tablaDatosG.Columns.Count - 1
                        dat(i) = tablaDatosG.Rows(0)(i)

                    Next

                    txtPlanAc.Text = dat(1)
                    txtVelAc.Text = dat(2)
                    txtPreAc.Text = dat(3)

                End If

                conexion.llenarComboBox(cmbPlanOp, "select nombrePaquete from PLANES_INTERNET", "nombrePaquete")

            ElseIf MessageBox.Show("El cliente no existe, ¿Desea ingresarlo?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                AgregarCliente.Show()
                Me.Hide()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbPlanOp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlanOp.SelectedIndexChanged
        conexion.llenarTextBox(txtVelOp, "select velocidad from PLANES_INTERNET where nombrePaquete = '" & cmbPlanOp.Text & "'", "velocidad")
        conexion.llenarTextBox(txtPreOp, "select precio from PLANES_INTERNET where nombrePaquete = '" & cmbPlanOp.Text & "'", "precio")

    End Sub

    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click
        Dim idCli As String

        idCli = txtIdCli.Text

        Try
            If idCli = "" And idCli.Length <> 13 Then
                MessageBox.Show("Por favor ingrese un número de identidad válido", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf cmbPlanOp.SelectedIndex = -1 Then
                MessageBox.Show("Por favor seleccione un paquete de internet", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                conexion.EjecutarComando("update CLIENTES set idPaquete = '" & cmbPlanOp.SelectedIndex + 1 & "' where numeroIdentidad = '" & txtIdCli.Text & "'")
                MessageBox.Show("Paquete actualizado exitosamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show("Error", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class