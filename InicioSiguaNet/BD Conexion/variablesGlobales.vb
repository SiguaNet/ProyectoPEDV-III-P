Module variablesGlobales
    'usuario y contrasena por default sera admin y admin
    Public usuario As String = "admin"
    Public contrasena As String = "admin"
    Public numeroIdentidad As String
    Public tablaDatosG As DataTable
    Public identidadPersonalEntro As String


    'Variables formas gestión tickets
    Public cantMesesG As Integer = My.Settings.settMesActualP
    Public idTicketAct As Integer
    Public fechaEstablecida As String
    Public idTecnico As Integer
    Public nombreOpera As String
    Public idOpera As Integer


    Public HcodigoHistorial As Integer
    Public HcantAntenasMes As Integer
    Public HcantEnrutadoresMes As Integer
    Public HcantFacturasMes As Integer
    Public HcantEfectivoTotal As Double
    Public HcantEfectivoMes As Double 
    Public HcantSoporteMes As Integer
    Public HcantCortesMes As Integer
    Public HcantNuevosMes As Integer
    Public HcantActualizacionesMes As Integer

End Module
