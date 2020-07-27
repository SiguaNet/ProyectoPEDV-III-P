Imports System.ComponentModel

Public Class PagosFacturas

    Dim Conexion As Conexion = New Conexion
    Public dineroEntregado As Double
    Public dineroCambio As Double

    Private Sub PagosFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBuscar.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Conexion.LlenarDGVPorIdentidad(dgvFacturas, "consultaInformacionFacturas", "@numeroIdentidad", txtIdentidad.Text)
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty Then
            If IsNumeric(txtIdentidad.Text) = True Then
                Dim cant As Integer = Val(Conexion.obtenerVariableEntera("select pagosCliente FROM CLIENTES where numeroIdentidad = '" & txtIdentidad.Text & "'", "pagosCliente")) + 1

                If cant = cmbMesPago.SelectedIndex + 1 Then
                    Dim valorEfectivo As String = (InputBox("Ingrese el valor de su pago(Efectivo)", "Gestion de Pagos"))
                    If IsNumeric(valorEfectivo) = True Then
                        Dim valorPago As Double = Conexion.obtenerVariableDecimal("select pli.precio from PLANES_INTERNET pli  inner join CLIENTES c ON pli.idPaquete = c.idPaquete inner join FACTURA f on c.numeroIdentidad = f.numeroIdentidadC where c.numeroIdentidad = '" & txtIdentidad.Text & "'", "precio")
                        If Val(valorEfectivo) >= valorPago Then
                            dineroEntregado = Val(valorEfectivo)
                            dineroCambio = Val(valorEfectivo) - valorPago
                            If Conexion.EjecutarComando("update CLIENTES set pagosCliente = '" & cant & "' where numeroIdentidad = '" & txtIdentidad.Text & "'") = 0 Then
                                If Conexion.PAOperacionesFactura(0, txtIdentidad.Text, String.Format("{0:G}", DateTime.Now), 1) = 0 Then
                                    Conexion.LlenarDGVPorIdentidad(dgvFacturas, "consultaInformacionFacturas", "@numeroIdentidad", txtIdentidad.Text)
                                    HcantEfectivoTotal += valorPago
                                    impresoraFacturas.Print()
                                    If cant >= variablesGlobales.cantMesesG Then
                                        Conexion.EjecutarComando("update CLIENTES set estadoC = 'Al Dia' where numeroIdentidad = '" & txtIdentidad.Text & "'")
                                    Else
                                        Conexion.EjecutarComando("update CLIENTES set estadoC = 'En Mora' where numeroIdentidad = '" & txtIdentidad.Text & "'")
                                    End If
                                End If
                            End If
                        Else
                            MessageBox.Show("El monto que intenta ingresar es menor al del pago de su factura!", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Ingrese valores correctos de efectivo!", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
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

    Private Sub impresoraFacturas_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles impresoraFacturas.PrintPage
        Dim nombreEncargado As String = Conexion.obtenerVariableCadena("select nombres from DATOS_PERSONAS where numeroIdentidad = '" & identidadPersonalEntro & "'", "nombres")
        Dim datos(7) As Object
        Dim cantRows As Integer = tablaDatosG.Rows.Count - 1
        If tablaDatosG.Rows.Count > 0 Then
            For i As Integer = 0 To tablaDatosG.Columns.Count - 1
                datos(i) = tablaDatosG.Rows(cantRows)(i)
            Next
        End If


        Dim fuente As System.Drawing.Font = New Font("consolas", 15)
        Dim topMargin As Double = e.MarginBounds.Top

        ' Imprime la cabecera
        Dim printFont As System.Drawing.Font = New Font("consolas", 9)
        e.Graphics.DrawImage(My.Resources.logoF, 70, 0, 150, 150)
        e.Graphics.DrawString(("SiguaNet"), fuente, Brushes.Black, 100, 140)
        e.Graphics.DrawString(("La Velocidad Mas Rapida"), printFont, Brushes.Black, 60, 170)
        e.Graphics.DrawString(("Barrio San Miguel, Siguatepeque"), printFont, Brushes.Black, 30, 200)
        e.Graphics.DrawString(("Tel: 2773-1110"), printFont, Brushes.Black, 90, 220)
        e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 5, 240)
        e.Graphics.DrawString(("N Factura: ") & datos(0).ToString, printFont, Brushes.Black, 5, 260)
        e.Graphics.DrawString(("Ident C: ") & datos(1).ToString, printFont, Brushes.Black, 5, 280)
        e.Graphics.DrawString("Nombre C: " & datos(2).ToString, printFont, Brushes.Black, 5, 300)
        e.Graphics.DrawString("Paquete: " & datos(3).ToString, printFont, Brushes.Black, 5, 320)
        e.Graphics.DrawString("Precio: " & Format(CDec(datos(4).ToString), "0.00L"), printFont, Brushes.Black, 5, 340)
        e.Graphics.DrawString("Fecha y Hora: " & datos(5).ToString, printFont, Brushes.Black, 5, 360)
        e.Graphics.DrawString("Mes Pago: " & datos(6).ToString, printFont, Brushes.Black, 5, 380)
        e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 5, 400)
        e.Graphics.DrawString("Entregado Efectivo: " & Format(CDec(dineroEntregado.ToString), "0.00L"), printFont, Brushes.Black, 5, 420)
        e.Graphics.DrawString("Su cambio efectivo: " & Format(CDec(dineroCambio.ToString), "0.00L"), printFont, Brushes.Black, 5, 440)
        e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 5, 460)

        e.Graphics.DrawString("Atendido por: " & nombreEncargado.ToString, printFont, System.Drawing.Brushes.Black, 10, 480)
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class