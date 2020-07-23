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
                    impresoraFacturas.Print()
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

        Dim datos(7) As Object
        Dim cantRows As Integer = tablaDatosG.Rows.Count - 1
        If tablaDatosG.Rows.Count > 0 Then
            For i As Integer = 0 To tablaDatosG.Columns.Count - 1
                datos(i) = tablaDatosG.Rows(cantRows)(i)
            Next
        End If


        Dim fuente As System.Drawing.Font = New Font("consolas", 15)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim unidad As Byte = 0
        Dim detalle As String = ""
        Dim valor As Decimal = 0
        Dim tabulacion As String = ""
        Dim compensador As Integer = 0
        Dim total As Decimal = 0
        Dim Lvalor As Integer
        Dim lineaTotal As String


        ' Imprime la cabecera
        yPos = 10
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
        e.Graphics.DrawString("Precio: " & datos(4).ToString & " Lempiras", printFont, Brushes.Black, 5, 340)
        e.Graphics.DrawString("Fecha y Hora: " & datos(5).ToString, printFont, Brushes.Black, 5, 360)
        e.Graphics.DrawString("Mes Pago: " & datos(6).ToString, printFont, Brushes.Black, 5, 380)
        e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 5, 400)


        ''For Each row As DataGridViewRow In Grilla.Rows
        'unidad = row.Cells(0).Value : detalle = row.Cells(1).Value : valor = row.Cells(2).FormattedValue
        '    Lvalor = Len(row.Cells(2).FormattedValue.ToString)
        '    compensador = Len(row.Cells(1).Value)
        '    tabulacion = StrDup(22 - compensador, " ")

        texto = unidad & "    " & detalle & tabulacion & StrDup(8 - Lvalor, " ") & valor 'Configura la linea
        yPos = 120 + topMargin + (count * printFont.GetHeight(e.Graphics)) ' Calcula la posición en la que se escribe la línea
        ' Imprime la línea con el objeto Graphics
        'If Not row.IsNewRow Then
        'e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        'total += valor
        'End If
        count += 1
        'Next
        yPos += 10
        'e.Graphics.DrawString("                           _______", printFont, System.Drawing.Brushes.Black, 10, yPos)
        Dim XXX As Integer = 0
        XXX = Len(total.ToString)
        lineaTotal = StrDup(28 - XXX, ".")
        yPos += 20
        'e.Graphics.DrawString("Total" & lineaTotal & total, printFont, System.Drawing.Brushes.Black, 10, yPos)
        yPos += 30
        e.Graphics.DrawString("Atendido por: Luis", printFont, System.Drawing.Brushes.Black, 10, 420)
        'e.Graphics.DrawString(("Coletilla"), printFont, Brushes.Black, 10, yPos + 20)
    End Sub

End Class