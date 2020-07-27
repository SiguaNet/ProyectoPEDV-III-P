Module variablesGlobales
    'usuario y contrasena por default sera admin y admin
    Public usuario As String = "admin"
    Public contrasena As String = "admin"
    Public numeroIdentidad As String
    Public tablaDatosG As DataTable
    Public identidadPersonalEntro As String = "1001200100363"


    'Variables formas gestión tickets
    Public cantMesesG As Integer = 1
    Public idTicketAct As Integer
    Public fechaEstablecida As String
    Public idTecnico As Integer
    Public nombreOpera As String
    Public idOpera As Integer


    Public HcodigoHistorial As Integer = 2
    Public HcantAntenasMes As Integer
    Public HcantEnrutadoresMes As Integer
    Public HcantFacturasMes As Integer
    Public HcantEfectivoTotal As Integer
    Public HcantEfectivoMes As Integer
    Public HcantSoporteMes As Integer
    Public HcantCortesMes As Integer
    Public HcantNuevosMes As Integer
    Public HcantActualizacionesMes As Integer

End Module
