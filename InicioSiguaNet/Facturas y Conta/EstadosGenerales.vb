Public Class EstadosGenerales

    Dim Conexion As Conexion = New Conexion
    Dim arrayDatos(12, 11) As Object
    Dim ContadorLocal As Integer = cantMesesG
    Dim HcantTotalDispo As Integer
    Dim cantTotalActivos As Integer
    Dim cantTotalGestionesMes As Integer

    Private Sub EstadosGenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If HcodigoHistorial = 1 Then
            btnMesAnterior.Visible = False
            btnMesSiguiente.Visible = False
            btnAceptar.Visible = True
            cargarDatos(cantMesesG)
            MostrarDatos(cantMesesG)
            imprimirLabel()
        Else
            btnMesAnterior.Visible = True
            btnMesSiguiente.Visible = True
            btnAceptar.Visible = False
            cargarDatos(cantMesesG)
            MostrarDatos(cantMesesG)
            imprimirLabel()
        End If
    End Sub


    Sub MostrarDatos(cantMesesP As Integer)
        lblAntenas.Text = arrayDatos(cantMesesP, 0)
        lblEnrutadores.Text = arrayDatos(cantMesesP, 1)
        lblTotalDispo.Text = arrayDatos(cantMesesP, 2)
        lblCantFacturas.Text = arrayDatos(cantMesesP, 3)
        lblEfectivo.Text = arrayDatos(cantMesesP, 4)
        lblTotalEfectivo.Text = arrayDatos(cantMesesP, 5)
        lblSoporteTecnico.Text = arrayDatos(cantMesesP, 6)
        lblCorteSolicitud.Text = arrayDatos(cantMesesP, 7)
        lblInstalaciones.Text = arrayDatos(cantMesesP, 8)
        lblActualizacionPaque.Text = arrayDatos(cantMesesP, 9)
        lblTotalGestiones.Text = arrayDatos(cantMesesP, 10)
        lblClientesActivos.Text = arrayDatos(cantMesesP, 11)
    End Sub

    Sub cargarDatos(cantMeses)
        Dim cantAntenasTotal = Conexion.obtenerVariableEntera("select cantidad from INVENTARIO where idTipoAparato = 1", "cantidad")
        HcantAntenasMes = cantAntenasTotal - HcantAntenasMes
        arrayDatos(cantMeses, 0) = HcantAntenasMes

        Dim cantEnrutadorTotal = Conexion.obtenerVariableEntera("select cantidad from INVENTARIO where idTipoAparato = 2", "cantidad")
        HcantEnrutadoresMes = cantEnrutadorTotal - HcantEnrutadoresMes
        arrayDatos(cantMeses, 1) = HcantEnrutadoresMes

        HcantTotalDispo = HcantAntenasMes + HcantEnrutadoresMes
        arrayDatos(cantMeses, 2) = HcantTotalDispo

        Dim cantFacturasTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from FACTURA", "")
        HcantFacturasMes = cantFacturasTotal - HcantFacturasMes
        arrayDatos(cantMeses, 3) = HcantFacturasMes

        HcantEfectivoMes = HcantEfectivoTotal - HcantFacturasMes
        arrayDatos(cantMeses, 4) = HcantEfectivoMes
        arrayDatos(cantMeses, 5) = HcantEfectivoTotal

        Dim cantSoporteTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 3", "")
        HcantSoporteMes = cantSoporteTotal - HcantSoporteMes
        arrayDatos(cantMeses, 6) = HcantSoporteMes

        Dim cantCortesTotales As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 4", "")
        HcantCortesMes = cantCortesTotales - HcantCortesMes
        arrayDatos(cantMeses, 7) = HcantCortesMes

        Dim cantNuevosClientesTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 1", "")
        HcantNuevosMes = cantNuevosClientesTotal - HcantNuevosMes
        arrayDatos(cantMeses, 8) = HcantNuevosMes

        Dim cantActualizacionTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 2", "")
        HcantActualizacionesMes = cantActualizacionTotal - HcantActualizacionesMes
        arrayDatos(cantMeses, 9) = HcantActualizacionesMes

        cantTotalGestionesMes = HcantSoporteMes + HcantCortesMes + HcantNuevosMes + HcantActualizacionesMes
        arrayDatos(cantMeses, 10) = cantTotalGestionesMes

        cantTotalActivos = Conexion.obtenerVariableEntera("select count(*) from CLIENTES", "")
        arrayDatos(cantMeses, 11) = cantTotalActivos
    End Sub

    Private Sub btnMesAnterior_Click(sender As Object, e As EventArgs) Handles btnMesAnterior.Click
        'MsgBox(ContadorLocal)
        If ContadorLocal = 1 Then
            ContadorLocal = 1
            MostrarDatos(ContadorLocal)
            imprimirLabel()
        ElseIf ContadorLocal >= 1 And ContadorLocal <= 12 Then
            ContadorLocal -= 1
            MostrarDatos(ContadorLocal)
            imprimirLabel()
        End If
    End Sub

    Private Sub btnMesSiguiente_Click(sender As Object, e As EventArgs) Handles btnMesSiguiente.Click

        If ContadorLocal = 12 Then
            ContadorLocal = 12
            MostrarDatos(ContadorLocal)
            imprimirLabel()
        ElseIf ContadorLocal >= 1 And ContadorLocal <= 12 Then
            ContadorLocal += 1
            MostrarDatos(ContadorLocal)
            imprimirLabel()
        End If
    End Sub

    Sub imprimirLabel()
        Select Case ContadorLocal
            Case 1
                lblMes.Text = "Enero"
            Case 2
                lblMes.Text = "Febrero"
            Case 3
                lblMes.Text = "Marzo"
            Case 4
                lblMes.Text = "Abril"
            Case 5
                lblMes.Text = "Mayo"
            Case 6
                lblMes.Text = "Junio"
            Case 7
                lblMes.Text = "Julio"
            Case 8
                lblMes.Text = "Agosto"
            Case 9
                lblMes.Text = "Septiembre"
            Case 10
                lblMes.Text = "Octubre"
            Case 11
                lblMes.Text = "Noviembre"
            Case 12
                lblMes.Text = "Diciembre"
        End Select
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
End Class