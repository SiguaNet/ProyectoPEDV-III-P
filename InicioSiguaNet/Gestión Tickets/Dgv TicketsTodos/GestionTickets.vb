Imports System.Runtime.InteropServices
Public Class GestionTickets
    Dim conexion As Conexion = New Conexion
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        conexion.LlenarDGV(dgvTickets, "consultaTicketsClientes")
    End Sub

    Private Sub GestionTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.LlenarDGV(dgvTickets, "consultaTicketsClientes")
        imprimirLabel()
    End Sub

    Private Sub dgvTickets_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentDoubleClick
        variablesGlobales.numeroIdentidad = ""
        variablesGlobales.numeroIdentidad = dgvTickets.CurrentRow.Cells(3).Value.ToString()

        Me.Close()
        InicioGestion.Show()

    End Sub

    Private Sub btnGestionar_Click(sender As Object, e As EventArgs) Handles btnGestionar.Click
        Me.Close()
        InicioGestion.Show()

    End Sub
    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If PanelOpciones.Height <= 104 Then
            Me.TimerOcultar.Enabled = False
        Else
            Me.PanelOpciones.Height = PanelOpciones.Height - 20
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If PanelOpciones.Height >= 140 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.PanelOpciones.Height = PanelOpciones.Height + 20
        End If
    End Sub
    Private Sub btnGestionTickets_Click(sender As Object, e As EventArgs) Handles btnGestionTickets.Click

        If PanelOpciones.Height = 144 Then
            TimerOcultar.Enabled = True

        ElseIf PanelOpciones.Height = 104 Then
            TimerMostrar.Enabled = True

        End If


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        InicioSiguaNet.Show()

    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Close()
        InicioSiguaNet.Show()
    End Sub

    Private Sub btnAvanzarMes_Click(sender As Object, e As EventArgs) Handles btnAvanzarMes.Click
        If variablesGlobales.cantMesesG = 12 Then
            variablesGlobales.cantMesesG = 1
        Else
            variablesGlobales.cantMesesG += 1
        End If
        imprimirLabel()
        HcodigoHistorial = 1
        EstadosGenerales.Show()
        HcodigoHistorial = 2
        My.Settings.settMesActualP = variablesGlobales.cantMesesG
        My.Settings.Save()
    End Sub

    Sub imprimirLabel()
        Select Case variablesGlobales.cantMesesG
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

    Private Sub PanelOpciones_Paint(sender As Object, e As PaintEventArgs) Handles PanelOpciones.Paint

    End Sub
    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Me.Close()
        FacturasTodas.Show()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnAdministracion.Click
        Me.Close()
        AdministracionCRUD.Show()
    End Sub

    Private Sub btnRealizar_Click_1(sender As Object, e As EventArgs) Handles btnRealizar.Click
        Me.Hide()
        RealizarTickets.Show()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Me.Close()
        FacturasTodas.Show()

    End Sub
End Class