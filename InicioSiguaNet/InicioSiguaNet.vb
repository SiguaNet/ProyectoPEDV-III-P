Imports System.Runtime.InteropServices
Public Class InicioSiguaNet
    Dim Conexion As Conexion = New Conexion

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub InicioSiguaNet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.LlenarDGV(DgvClientes, "consultaInformacionClientes")
    End Sub

    Private Sub DbgClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentDoubleClick
        variablesGlobales.numeroIdentidad = DgvClientes.CurrentRow.Cells(0).Value.ToString()
        Me.Hide()
        FichaCliente.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub btnGestionTickets_Click_1(sender As Object, e As EventArgs) Handles btnGestionTickets.Click
        Me.Hide()
        GestionTickets.Show()

    End Sub

    Private Sub btnRecursos_Click_1(sender As Object, e As EventArgs)
        Recursos.Show()
        Me.Hide()
    End Sub

    Private Sub btnPersonal_Click_1(sender As Object, e As EventArgs)
        Personal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        inicioSesion.Show()
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Me.Close()
        FacturasTodas.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Close()
        AdministracionCRUD.Show()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Conexion.LlenarDGV(DgvClientes, "consultaInformacionClientes")

        Conexion.EjecutarComando("update CLIENTES set estadoC = 'En mora' where pagosCliente < '" & variablesGlobales.cantMesesG & "'")

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

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click

        If PanelOpciones.Height = 144 Then
            TimerOcultar.Enabled = True

        ElseIf PanelOpciones.Height = 104 Then
            TimerMostrar.Enabled = True

        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Hide()
        AgregarCliente.Show()

    End Sub
End Class
