Public Class EstadosGenerales

    Dim Conexion As Conexion = New Conexion
    'Dim arrayDatos(12, 11) As Object
    Dim HcantTotalDispo As Integer
    Dim cantTotalActivos As Integer
    Dim cantTotalGestionesMes As Integer

    Private Sub EstadosGenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cantTotalGestionesMes = HcantCortesMes + HcantNuevosMes + HcantSoporteMes + HcantActualizacionesMes
        MostrarDatos()
        imprimirLabel()

        If HcodigoHistorial = 1 Then
            HcantFacturasMes = 0
            HcantEfectivoMes = 0
            HcantSoporteMes = 0
            HcantActualizacionesMes = 0
            HcantNuevosMes = 0
            HcantCortesMes = 0
            cantTotalGestionesMes = 0
        End If
        If cantMesesG = 12 Then
            HcantEfectivoTotal = 0
        End If
    End Sub


    Sub MostrarDatos()
        lblAntenas.Text = Conexion.obtenerVariableEntera("select cantidad from INVENTARIO where idTipoAparato = 1", "cantidad")
        lblEnrutadores.Text = Conexion.obtenerVariableEntera("select cantidad from INVENTARIO where idTipoAparato = 2", "cantidad")
        lblTotalDispo.Text = Val(lblAntenas.Text) + Val(lblEnrutadores.Text)
        lblCantFacturas.Text = HcantFacturasMes
        lblEfectivo.Text = HcantEfectivoMes
        lblTotalEfectivo.Text = HcantEfectivoTotal
        lblSoporteTecnico.Text = HcantSoporteMes
        lblCorteSolicitud.Text = HcantCortesMes
        lblInstalaciones.Text = HcantNuevosMes
        lblActualizacionPaque.Text = HcantActualizacionesMes
        lblTotalGestiones.Text = cantTotalGestionesMes
        lblClientesActivos.Text = Conexion.obtenerVariableEntera("select count(*) from CLIENTES", "")
    End Sub

    'Sub cargarDatos()
    '    'Dim cantAntenasTotal = Conexion.obtenerVariableEntera("select cantidad from INVENTARIO where idTipoAparato = 1", "cantidad")
    '    'lblAntenas.Text = cantAntenasTotal

    '    'Dim cantEnrutadorTotal = Conexion.obtenerVariableEntera("select cantidad from INVENTARIO where idTipoAparato = 2", "cantidad")
    '    'lblEnrutadores.Text = cantEnrutadorTotal

    '    'HcantTotalDispo = cantAntenasTotal + cantEnrutadorTotal
    '    'lblTotalDispo.Text = HcantTotalDispo

    '    'Dim cantFacturasTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from FACTURA", "")
    '    'cantFacturasTotal = cantFacturasTotal - HcantFacturasMes
    '    'HcantFacturasMes = cantFacturasTotal
    '    'lblCantFacturas.Text = HcantFacturasMes

    '    'HcantEfectivoMes = HcantEfectivoTotal - HcantEfectivoMes
    '    ''arrayDatos(cantMeses, 4)
    '    'lblEfectivo.Text = HcantEfectivoMes
    '    ''arrayDatos(cantMeses, 5)
    '    'lblTotalEfectivo.Text = HcantEfectivoTotal

    '    'Dim cantSoporteTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 3", "")
    '    'HcantSoporteMes = cantSoporteTotal - HcantSoporteMes
    '    ''arrayDatos(cantMeses, 6) 
    '    'lblSoporteTecnico.Text = HcantSoporteMes

    '    'Dim cantCortesTotales As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 4", "")
    '    'HcantCortesMes = cantCortesTotales - HcantCortesMes
    '    ''arrayDatos(cantMeses, 7)
    '    'lblCorteSolicitud.Text = HcantCortesMes

    '    'Dim cantNuevosClientesTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 1", "")
    '    'HcantNuevosMes = cantNuevosClientesTotal - HcantNuevosMes
    '    ''arrayDatos(cantMeses, 8)
    '    'lblInstalaciones.Text = HcantNuevosMes

    '    'Dim cantActualizacionTotal As Integer = Conexion.obtenerVariableEntera("select count(*) from GESTION_TICKETS where idOperacion = 2", "")
    '    'HcantActualizacionesMes = cantActualizacionTotal - HcantActualizacionesMes
    '    ''arrayDatos(cantMeses, 9)
    '    'lblActualizacionPaque.Text = HcantActualizacionesMes

    '    'cantTotalGestionesMes = HcantSoporteMes + HcantCortesMes + HcantNuevosMes + HcantActualizacionesMes
    '    ''arrayDatos(cantMeses, 10)
    '    'lblTotalGestiones.Text = cantTotalGestionesMes

    '    'cantTotalActivos = Conexion.obtenerVariableEntera("select count(*) from CLIENTES", "")
    '    ''arrayDatos(cantMeses, 11)
    '    'lblClientesActivos.Text = cantTotalActivos
    'End Sub

    'Private Sub btnMesAnterior_Click(sender As Object, e As EventArgs) Handles btnMesAnterior.Click
    '    'MsgBox(ContadorLocal)
    '    If ContadorLocal = 1 Then
    '        ContadorLocal = 1
    '        MostrarDatos(ContadorLocal)
    '        imprimirLabel()
    '    ElseIf ContadorLocal >= 1 And ContadorLocal <= 12 Then
    '        ContadorLocal -= 1
    '        MostrarDatos(ContadorLocal)
    '        imprimirLabel()
    '    End If
    'End Sub

    'Private Sub btnMesSiguiente_Click(sender As Object, e As EventArgs) Handles btnMesSiguiente.Click

    '    If ContadorLocal = 12 Then
    '        ContadorLocal = 12
    '        MostrarDatos(ContadorLocal)
    '        imprimirLabel()
    '    ElseIf ContadorLocal >= 1 And ContadorLocal <= 12 Then
    '        ContadorLocal += 1
    '        MostrarDatos(ContadorLocal)
    '        imprimirLabel()
    '    End If
    'End Sub

    Sub imprimirLabel()
        Select Case cantMesesG
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class