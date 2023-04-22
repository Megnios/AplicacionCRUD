Imports System.Data.SqlClient

Public Class DbProductos
    Inherits Conexion

    Private id_cliente As String
    Private nombre As String
    Private precio As String
    Private categoria As String

    Private comando As SqlCommand


    Public Sub New(nom As String, pre As String, cat As String)

        nombre = nom
        precio = pre
        categoria = cat

    End Sub

    Public Sub New(nom As String, pre As String, cat As String, id As String)

        nombre = nom
        precio = pre
        categoria = cat
        id_cliente = id

    End Sub

    Public Sub New()


    End Sub


    ' Pre: -
    ' Post: Devuelve la información recabada por la consulta. Si hubo algún error devuelve Nothing.
    Public Function consultarInfoProductos() As DataTable

        Try
            conectarDb()

            Dim query As String = "SELECT PRODUCTOS.*,  SUM(VENTASITEMS.PrecioTotal) as TotalVendidoMes
                                   FROM PRODUCTOS
                                   JOIN VENTASITEMS ON PRODUCTOS.ID = VENTASITEMS.IDPRODUCTO
                                   GROUP BY PRODUCTOS.ID, PRODUCTOS.NOMBRE, PRODUCTOS.PRECIO, PRODUCTOS.CATEGORIA"

            comando = New SqlCommand(query, conexion)

            If comando.ExecuteNonQuery() Then

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
    ' Post: Devuelve True si la conexión con la base de datos y la consulta de eliminación fueron exitosas. False en cualquier otro caso.
    Public Function eliminarCliente(id As String) As Boolean

        Try
            conectarDb()

            Dim query As String = "DELETE FROM PRODUCTOS WHERE ID = '" & id & "'"

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
    ' Post: Devuelve True si la conexión con la base de datos y la consulta fueron exitosas. False en cualquier otro caso.
    Public Function actualizarProducto(cte As DbProductos) As Boolean

        Try
            conectarDb()

            Dim query As String = "UPDATE PRODUCTOS Set Nombre = '" & cte.nombre & "', Precio = '" & cte.precio & "',Categoria = '" & cte.categoria & "' WHERE ID = '" & cte.id_cliente & "'"

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
    Public Function consultarProducto(categoria As String, precioMin As String, precioMax As String) As DataTable

        Try

            conectarDb()

            Dim query As String = "SELECT* FROM PRODUCTOS
                                   WHERE PRECIO BETWEEN '" & precioMin & "' AND '" & precioMax & "' AND CATEGORIA = '" & categoria & "'"

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
    Public Function consultarProducto(id As String) As DataTable

        Try
            conectarDb()

            Dim querry As String = "Select ID, Nombre, Precio, Categoria FROM PRODUCTOS WHERE ID = '" & id & "'"
            comando = New SqlCommand(querry, conexion)

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
    Public Function insertarProducto(datos As DbProductos) As Boolean

        Try

            Dim query As String = "INSERT INTO PRODUCTOS(Nombre, Precio, Categoria) VALUES('" & datos.nombre & "','" &
                                   datos.precio & "','" & datos.categoria & "')"

            conectarDb()
            comando = New SqlCommand(query, conexion)
            comando.ExecuteNonQuery()

            MsgBox("¡El producto ha sido registrado con éxito!")

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        Finally

            desconectarDb()

        End Try



    End Function

End Class
