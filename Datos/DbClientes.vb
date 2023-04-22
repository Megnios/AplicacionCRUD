Imports System.Data.SqlClient

Public Class DbClientes
    Inherits Conexion

    Private id_cliente As Integer
    Private cliente As String
    Private telefono As String
    Private correo As String
    Private comando As SqlCommand


    Public Sub New(nombre As String, tel As String, mail As String, id As String)

        id_cliente = id
        cliente = nombre
        telefono = tel
        correo = mail


    End Sub

    Public Sub New()


    End Sub


    ' Pre: -
    ' Post: Devuelve True si la conexión con la base de datos y la consulta fueron exitosas. False en cualquier otro caso.
    Public Function eliminarCliente(id As String) As Boolean

        Try
            conectarDb()

            Dim query As String = "DELETE FROM CLIENTES WHERE ID = '" & id & "'"

            comando = New SqlCommand(query, conexion)

            If comando.ExecuteNonQuery Then

                Return True

            Else

                Return False


            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Return False


        Finally
            desconectarDb()

        End Try

    End Function


    ' Pre: -
    ' Post: Devuelve True si la conexion con la base de datos y la consulta fueron exitosas. False en cualquier otro caso.
    Public Function actualizarCliente(cte As DbClientes) As Boolean

        Try
            conectarDb()

            Dim query As String = "UPDATE CLIENTES Set Cliente = '" & cte.cliente & "', Telefono = '" & cte.telefono & "',Correo = '" & cte.correo & "' WHERE ID = '" & cte.id_cliente & "'"

            comando = New SqlCommand(query, conexion)

            If comando.ExecuteNonQuery Then
                MsgBox("El usuario fue actualizado exitosamente")
                Return True

            Else
                Return False


            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Return False


        Finally
            desconectarDb()

        End Try
    End Function

    ' Pre: -
    ' Post: Devuelve la información recabada por la consulta. Si hubo algún error devuelve Nothing.

    Public Function consultarCliente(idProducto As String, precioMin As String, precioMax As String) As DataTable

        Try
            conectarDb()
            Dim query As String = "SELECT CLIENTES.ID, CLIENTES.Cliente, CLIENTES.Telefono, CLIENTES.Correo, VENTASITEMS.IDProducto, VENTASITEMS.PrecioTotal
                                   FROM CLIENTES
                                   JOIN VENTASITEMS ON CLIENTES.ID = VENTASITEMS.ID
                                   WHERE VENTASITEMS.IDPRODUCTO = '" & idProducto & "' AND VENTASITEMS.PrecioTotal BETWEEN '" & precioMin & "' AND '" & precioMax & "'"

            comando = New SqlCommand(query, conexion)

            If comando.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)

                da.Fill(dt)
                Return dt

            Else
                Return Nothing


            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally

            desconectarDb()

        End Try

    End Function


    ' Pre: -
    ' Post: Devuelve la información recabada por la consulta. Si hubo algún error devuelve Nothing.
    Public Function consultarCliente(id As String) As DataTable

        Try
            conectarDb()

            Dim query As String = "Select ID, cliente, telefono, correo FROM CLIENTES WHERE ID = '" & id & "'"
            comando = New SqlCommand(query, conexion)

            If comando.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)

                da.Fill(dt)

                Return dt

            Else
                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally

            desconectarDb()

        End Try
    End Function

    ' Pre: -
    ' Post: Devuelve True si la conexion con la base de datos y la consulta fueron exitosas. False en cualquier otro caso.
    Public Function insertarCliente(datos As DbClientes) As Boolean

        Try

            Dim query As String = "INSERT INTO CLIENTES(Cliente, telefono, correo) VALUES('" & datos.cliente & "','" &
                                   datos.telefono & "','" & datos.correo & "')"

            conectarDb()
            comando = New SqlCommand(query, conexion)
            comando.ExecuteNonQuery()

            MsgBox("¡El cliente ha sido registrado con éxito!")

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        Finally

            desconectarDb()

        End Try



    End Function
End Class
