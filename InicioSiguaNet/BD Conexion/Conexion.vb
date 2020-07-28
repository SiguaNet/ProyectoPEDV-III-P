Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-9JQIMLJ;Initial Catalog=bd_SiguaNet;Integrated Security=True")
    Public adaptador As SqlDataAdapter
    Public tablaDatos1 As DataTable
    Public lectorVariables As SqlDataReader
    Public comando As SqlCommand
    Public sskey As String = "qualityi"

    Public Sub abrirConexion()
        Try
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo Conectar: " + ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Public Sub LlenarDGV(ByVal dgv As DataGridView, instruccion As String)
        Try
            conexion.Open()
            adaptador = New SqlDataAdapter(instruccion, conexion)
            tablaDatos1 = New DataTable
            adaptador.Fill(tablaDatos1)
            dgv.DataSource = tablaDatos1
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
        End Try
    End Sub

    'Función que llena dataGridView apartir de procedimientos almacenados.       
    'dgv = dataGridView que se quiere llenar.               
    'nombrePA = nombre del procedimiento almacenado que se llamará.            
    'parametrosPA = que parámetro necesita la funcion por ejemplo si está especificada @numeroIdentidad, literal llamarla como ”@numeroIdentidad".             
    'identidad = identificador que se le envía a la función
    Public Sub LlenarDGVPorIdentidad(dgv As DataGridView, ByVal nombrePA As String, ByVal parametroPA As String, ByVal identidad As String)
        Try
            conexion.Open()
            comando = New SqlCommand(nombrePA, conexion)
            comando.CommandType = CommandType.StoredProcedure
            adaptador = New SqlDataAdapter(comando)
            tablaDatos1 = New DataTable
            With comando.Parameters
                .Add(New SqlParameter(parametroPA, identidad))
            End With
            adaptador.Fill(tablaDatos1)

            'Recorre tabla de datos de la consulta y asigna a variables los valores requeridos
            'If tablaDatos1.Rows.Count > 0 Then
            '    For i As Integer = 0 To tablaDatos1.Columns.Count - 1
            '        MsgBox(tablaDatos1.Rows(0)(i))
            '    Next
            'End If
            tablaDatosG = tablaDatos1
            dgv.DataSource = tablaDatos1
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub ObtenerVariablesPorIdentidad(ByVal nombrePA As String, ByVal parametroPA As String, ByVal identidad As String)
        Try
            conexion.Open()
            comando = New SqlCommand(nombrePA, conexion)
            comando.CommandType = CommandType.StoredProcedure
            adaptador = New SqlDataAdapter(comando)
            tablaDatos1 = New DataTable
            With comando.Parameters
                .Add(New SqlParameter(parametroPA, identidad))
            End With
            adaptador.Fill(tablaDatos1)

            tablaDatosG = tablaDatos1
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    'Consulta individualmente el personal
    'Function PAconsultaIndividual(ByVal dgv As DataGridView, ByVal numeroIdent As String)
    '    Try
    '        conexion.Open()
    '        Dim cmd As New SqlCommand("consultaPersonal", conexion)
    '        tablaDatos1 = New DataTable
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.AddWithValue("@idPersonal", numeroIdent)
    '        dgv.DataSource = "consultaPersonal"
    '    Catch ex As Exception
    '        conexion.Close()
    '        MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
    '        Return 1
    '    End Try
    'End Function

    Public Sub llenarComboBox(ByVal cmb As ComboBox, instruccion As String, columnas As String)
        Try
            conexion.Open()
            comando = New SqlCommand(instruccion, conexion)
            lectorVariables = comando.ExecuteReader
            While lectorVariables.Read
                cmb.Items.Add(lectorVariables.Item(columnas))
            End While
            lectorVariables.Close()
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
        End Try

    End Sub

    Public Sub llenarTextBox(ByVal text As TextBox, instruccion As String, columnas As String)
        Try
            conexion.Open()
            comando = New SqlCommand(instruccion, conexion)
            lectorVariables = comando.ExecuteReader
            While lectorVariables.Read
                text.Text = Convert.ToString(lectorVariables(columnas))
            End While
            lectorVariables.Close()
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
        End Try
    End Sub

    Public Function comprobarExistencias(ByVal instruccion As String) As Integer
        Try
            conexion.Open()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = instruccion
            Dim existe As String = CStr(comando.ExecuteScalar())
            If existe <> "" Then
                conexion.Close()
                Return 1
            Else
                conexion.Close()
                Return 2
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function

    'Obtiene solo un valor entero de la base
    Public Function obtenerVariableEntera(ByVal instruccion As String, columnas As String) As Integer
        Try
            conexion.Open()
            Dim valor As Integer
            comando = New SqlCommand(instruccion, conexion)
            lectorVariables = comando.ExecuteReader
            While lectorVariables.Read
                valor = Convert.ToInt16(lectorVariables(columnas))
            End While
            lectorVariables.Close()
            conexion.Close()
            Return valor
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function

    Public Function obtenerVariableDecimal(ByVal instruccion As String, columnas As String) As Double
        Try
            conexion.Open()
            Dim valor As Double
            comando = New SqlCommand(instruccion, conexion)
            lectorVariables = comando.ExecuteReader
            While lectorVariables.Read
                valor = Convert.ToDouble(lectorVariables(columnas))
            End While
            lectorVariables.Close()
            conexion.Close()
            Return valor
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function

    Public Function obtenerVariableCadena(ByVal instruccion As String, columnas As String) As String
        Try
            conexion.Open()
            Dim valorS As String
            comando = New SqlCommand(instruccion, conexion)
            lectorVariables = comando.ExecuteReader
            If lectorVariables.Read Then
                valorS = Convert.ToString(lectorVariables(columnas))
            Else
                Return Nothing
            End If
            lectorVariables.Close()
            conexion.Close()
            Return valorS
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function


    Public Function EjecutarComando(ByVal instruccion As String) As Integer
        Try
            comando = New SqlCommand(instruccion, conexion)
            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return -1
        End Try
    End Function

    'Funcion para encriptar datos
    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function


    Public Function comprobarUsuario(ByVal usua As String, ByVal contra As String) As Boolean

        conexion.Open()
        Dim sqlcomando As String = "SELECT count(*) FROM ADMINISTRADORES WHERE numeroIdentidad = '" & usua & "' And contrasena ='" & contra & "' "
        comando = conexion.CreateCommand
        comando.CommandText = sqlcomando

        Dim t As Object = CInt(comando.ExecuteScalar())

        conexion.Close()
        If t = 0 Then
            Return False
        End If

        Return True

    End Function

    'Funcion para insertar usuarios de personal
    Function PAOperacionesUsuarioPersonal(ByVal numeroIdent As String, ByVal nombres As String, ByVal primerApellido As String,
                                    ByVal segundoApellido As String, ByVal numeroTelefono As Integer, ByVal numeroCasa As Integer, ByVal idSector As Integer, ByVal refDireccion As String,
                                    ByVal idVehiculo As Object, ByVal estado As String, ByVal opcion As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "OperacionesPersonaPE"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@numeroIdentidad", numeroIdent)
            comando.Parameters.AddWithValue("@nombres", fTexto(nombres))
            comando.Parameters.AddWithValue("@primerApellido", fTexto(primerApellido))
            comando.Parameters.AddWithValue("@segundoApellido", fTexto(segundoApellido))
            comando.Parameters.AddWithValue("@numeroTelefono", numeroTelefono)
            comando.Parameters.AddWithValue("@numeroCasa", numeroCasa)
            comando.Parameters.AddWithValue("@idSector", idSector)
            comando.Parameters.AddWithValue("@referenciasDireccion", refDireccion)
            comando.Parameters.AddWithValue("@idVehiculo", idVehiculo)
            comando.Parameters.AddWithValue("@estado", fTexto(estado))
            If opcion = 1 Then
                comando.Parameters.AddWithValue("@codigoOP", 1)
            ElseIf opcion = 2 Then
                comando.Parameters.AddWithValue("@codigoOP", 2)
            End If

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Insercion Usuario", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function

    'Funcion para insertar/modificar inventario
    Function PAOperacionesInventario(ByVal idTipoAparato As Integer, ByVal nombre As String, ByVal cantidad As Integer, ByVal opcion As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "OperacionesInventario"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@idTipoAparato", idTipoAparato)
            comando.Parameters.AddWithValue("@nombreTipo", nombre)
            comando.Parameters.AddWithValue("@cantidad", cantidad)
            If opcion = 1 Then
                comando.Parameters.AddWithValue("@codigoOP", 1)
            ElseIf opcion = 2 Then
                comando.Parameters.AddWithValue("@codigoOP", 2)
            End If

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Insercion/Modificacion Inventario", "Error de Insercion/Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function

    'Funcion para insertar en vehiculos
    Function PAOperacionesRecursosMotores(ByVal idVehiculo As Integer, ByVal matricula As String, ByVal modelo As String, ByVal opcion As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "OperacionesRecursosMotores"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@idVehiculo", idVehiculo)
            comando.Parameters.AddWithValue("@matricula", matricula)
            comando.Parameters.AddWithValue("@modelo", modelo)
            If opcion = 1 Then
                comando.Parameters.AddWithValue("@codigoOP", 1)
            ElseIf opcion = 2 Then
                comando.Parameters.AddWithValue("@codigoOP", 2)
            End If

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Insercion Recurso", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function
    'Funcion para eliminar vehiculos
    Function PAEliminarRecursosMotores(ByVal idVehiculo As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "BorrarRecursosMotores"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@idVehiculo", idVehiculo)

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Eliminacion de Recurso", "Error de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function

    'Funcion para insertar usuarios de personal administrativo
    Function PAOperacionesUsuarioLogin(ByVal numeroIdent As String, ByVal contra As String, ByVal correo As String, ByVal opcion As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "OperacionesAdministradores"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@numeroIdentidad", Trim(numeroIdent))
            comando.Parameters.AddWithValue("@contrasena", contra)
            comando.Parameters.AddWithValue("@correo", LCase(correo))
            If opcion = 1 Then
                comando.Parameters.AddWithValue("@codigoOP", 1)
            ElseIf opcion = 2 Then
                comando.Parameters.AddWithValue("@codigoOP", 2)
            End If

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Insercion Contraseña", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function


    'Función que trabaja la parte de modificación y inserción de factura    
    'OJO    
    'si se quiere llamar para inserción o modificación especificar que operación es mediante 1 ó 2, no crear otra nueva funcion
    Function PAOperacionesFactura(ByVal idFactura As Integer, ByVal numeroIdentidad As String, ByVal fechaPago As String, ByVal opcion As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "OperacionesFactura"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@idFactura", idFactura)
            comando.Parameters.AddWithValue("@numeroIdentidadC", numeroIdentidad)
            comando.Parameters.AddWithValue("@fechaPago", fechaPago)
            If opcion = 1 Then
                comando.Parameters.AddWithValue("@codigoOP", 1)
            ElseIf opcion = 2 Then
                comando.Parameters.AddWithValue("@codigoOP", 2)
            End If

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Operacion de Facturas", "Error de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function

    'Funcion para consultar la información de un sólo cliente por numero de indentidad
    Public Function PAConsultarInformacionCliente(ByVal numeroIdentidad As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand("consultaInformacionCliente", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@numeroIdentidad", numeroIdentidad)

            If comando.ExecuteNonQuery() Then
                conexion.Close()

                Return 0

            Else
                MessageBox.Show("No existe ningun usuario con ese numero ID", "Error busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try

    End Function

    'Función para llenar textbox por medio de un procedimiento almacenado de consulta
    Public Function LlenarTablaPorIdentidad(ByVal nombrePA As String, ByVal parametroPA As String, ByVal identidad As String)
        Try
            conexion.Open()
            comando = New SqlCommand(nombrePA, conexion)
            comando.CommandType = CommandType.StoredProcedure
            adaptador = New SqlDataAdapter(comando)
            tablaDatos1 = New DataTable

            With comando.Parameters
                .Add(New SqlParameter(parametroPA, identidad))
            End With
            adaptador.Fill(tablaDatos1)
            tablaDatosG = tablaDatos1
            conexion.Close()
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 1
        Finally
            conexion.Close()

        End Try
    End Function

    'Función para insertar/actualizar clientes
    Public Function PAOperacionesPersonaCL(ByVal numeroIdentidad As String, ByVal nombres As String, ByVal primerApellido As String,
                                  ByVal segundoApellido As String, ByVal numeroTelefono As Integer, ByVal numeroCasa As Integer, ByVal idSector As Integer, ByVal refDireccion As String,
                                  ByVal idPaquete As Integer, ByVal pagosCliente As Integer, ByVal estadoC As String, ByVal opcion As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "operacionesPersonaCL"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@numeroIdentidad", numeroIdentidad)
            comando.Parameters.AddWithValue("@nombres", nombres)
            comando.Parameters.AddWithValue("@primerApellido", primerApellido)
            comando.Parameters.AddWithValue("@segundoApellido", segundoApellido)
            comando.Parameters.AddWithValue("@numeroTelefono", numeroTelefono)
            comando.Parameters.AddWithValue("@numeroCasa", numeroCasa)
            comando.Parameters.AddWithValue("@idSector", idSector)
            comando.Parameters.AddWithValue("@referenciasDireccion", refDireccion)
            comando.Parameters.AddWithValue("@idPaquete", idPaquete)
            comando.Parameters.AddWithValue("@pagosCliente", pagosCliente)
            comando.Parameters.AddWithValue("@estadoC", estadoC)

            If opcion = 1 Then
                comando.Parameters.AddWithValue("@codigoOP", 1)
            ElseIf opcion = 2 Then
                comando.Parameters.AddWithValue("@codigoOP", 2)
            End If

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Insercion Usuario", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function

    'Función para insertar/actualizar tickets
    Public Function PAOperacionesGestionTickets(ByVal idTicket As Integer, ByVal numeroIdentidadC As String, ByVal idPersonal As Integer, ByVal estado As String, ByVal prioridad As String,
                                                ByVal idOperacion As Integer, ByVal nota As String, ByVal fechaInicio As String, ByVal fechaFin As String, ByVal opcion As Integer)
        Try
            conexion.Close()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = "OperacionesGestionTickets"
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.AddWithValue("@idTicket", idTicket)
            comando.Parameters.AddWithValue("@numeroIdentidadC", numeroIdentidadC)
            comando.Parameters.AddWithValue("@idPersonal", idPersonal)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.Parameters.AddWithValue("@prioridad", prioridad)
            comando.Parameters.AddWithValue("@idOperacion", idOperacion)
            comando.Parameters.AddWithValue("@nota", nota)
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio)
            comando.Parameters.AddWithValue("@fechaFin", fechaFin)

            If opcion = 1 Then
                comando.Parameters.AddWithValue("@codigoOP", 1)
            ElseIf opcion = 2 Then
                comando.Parameters.AddWithValue("@codigoOP", 2)
            End If

            conexion.Open()
            If comando.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                MessageBox.Show("Error de Insercion Usuario", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
                Return 1
            End If
        Catch ex As Exception
            conexion.Close()
            MessageBox.Show("Error de Base de datos! " & vbCrLf + ex.ToString)
            Return 1
        End Try
    End Function

    Public Function fTexto(ByVal str As String) As String
        Return StrConv(str, VbStrConv.ProperCase)
    End Function

    Public Sub limpiar(cont As Object)
        For Each control As Control In cont.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
            If TypeOf control Is MaskedTextBox Then
                control.Text = String.Empty
            End If
        Next
    End Sub

End Class
