Imports System.Data.SqlClient
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("SU CADENA DE CONEXION DE LA BASE")
    Public adaptador As SqlDataAdapter
    Public tablaDatos1 As DataTable
    Public lectorVariables As SqlDataReader
    Public comando As SqlCommand

    Sub abrirConexion()
        Try
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo Conectar: " + ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Sub LlenarDGVHistorial(ByVal dgv As DataGridView, instruccion As String)
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

    Sub llenarComboBox(ByVal cmb As ComboBox, instruccion As String, columnas As String)
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

    Sub llenarTextBox(ByVal text As TextBox, instruccion As String, columnas As String)
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

    Function comprobarExistencias(ByVal instruccion As String)
        Try
            conexion.Open()
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.CommandText = instruccion
            Dim existe As Integer = CInt(comando.ExecuteScalar())
            If existe > 0 Then
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
    Function obtenerVariableEntera(ByVal instruccion As String, columnas As String)
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

    Function obtenerVariableDecimal(ByVal instruccion As String, columnas As String)
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

    Function obtenerVariableCadena(ByVal instruccion As String, columnas As String)
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


    Function EjecutarComando(ByVal instruccion As String)
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

    Sub limpiar(cont As Object)
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
