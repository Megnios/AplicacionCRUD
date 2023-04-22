Imports System.Data.SqlClient
Imports System.Configuration


Public Class Conexion

    Protected conexionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString
    Protected conexion As New SqlConnection(conexionString)





    ' Pre: -
    ' Post: Devuelve True si la conexión con la base de datos fue exitosa. False en cualquier otro caso.
    Public Function conectarDb() As Boolean

        Try
            conexion.Open()
            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function


    ' Pre: 
    ' Post: Si la conexión con la base de datos está abierta, la cierra.
    Public Sub desconectarDb()

        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

End Class
