Imports System.Data.SqlClient

Public Class DbVentas
    Inherits Conexion

    Private idCliente As String
    Private idVenta As String
    Private idProducto As String
    Private fecha As String
    Private precioUnitario As String
    Private precioTotal As String
    Private cantidad As String

    Private comando As SqlCommand


    Public Sub New(idC As String, idV As String, idP As String, precioU As String, cant As String, fec As String)

        idCliente = idC
        idVenta = idV
        idProducto = idP
        fecha = fec
        precioUnitario = precioU
        cantidad = cant
        precioTotal = precioUnitario * cantidad


    End Sub

    Public Sub New()

    End Sub


    ' Pre: -
    ' Post: Devuelve True si se pudo realizar la conexión con la base de datos y la consulta de eliminacion. False en cualquier otro caso.
    Public Function eliminarVenta(idVenta As String) As Boolean

        Try
            conectarDb()

            Dim query As String = "DELETE VENTAS
                                   FROM VENTAS
                                   JOIN VENTASITEMS ON VENTAS.ID = VENTASITEMS.ID
                                   WHERE VENTASITEMS.IDVENTA = '" & idVenta & "'
                                   
                                   DELETE VENTASITEMS
                                   FROM VENTASITEMS
                                   WHERE IDVENTA = '" & idVenta & "'"


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


    ' Pre: cte.fecha debe estar en formato DateTime
    ' Post: Devuelve True si la conexión con la base de datos y la consulta de actualizacion fue exitosa. False en cualquier otro caso.
    Public Function actualizarVenta(cte As DbVentas) As Boolean

        Try
            conectarDb()

            Dim query As String = "UPDATE VENTAS Set Fecha = '" & cte.fecha & "', Total = '" & cte.precioTotal & "'
                                   FROM VENTAS
                                   JOIN VENTASITEMS ON VENTAS.ID = VENTASITEMS.ID
                                   WHERE VENTASITEMS.IDVenta = '" & cte.idVenta & "'

                                   UPDATE VENTASITEMS Set IDVenta = '" & cte.idVenta & "', IDProducto = '" & cte.idProducto & "', PrecioUnitario = '" & cte.precioUnitario & "',
                                   Cantidad = '" & cte.cantidad & "', PrecioTotal = '" & cte.precioTotal & "'
                                   WHERE IDVenta = '" & cte.idVenta & "'"



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
    Public Function consultarVenta(idVenta As String) As DataTable

        Try
            conectarDb()

            Dim query As String = "SELECT VENTAS.ID, VENTAS.IDCliente, VENTASITEMS.IDProducto, VENTASITEMS.IDVenta, VENTASITEMS.PrecioUnitario, VENTASITEMS.Cantidad, VENTASITEMS.PrecioTotal, VENTAS.Fecha FROM VENTAS
                                    JOIN VENTASITEMS ON VENTAS.ID = VENTASITEMS.ID
                                    WHERE VENTASITEMS.IDVENTA = '" & idVenta & "'"

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


    ' Pre: fechaMin y fechaMax deben tener formato DateTime.
    ' Post: Devuelve la información recabada por la consulta. Si hubo algún error devuelve Nothing.
    Public Function consultarVenta(precioMin As String, precioMax As String, cantidadMin As String, cantidadMax As String, fechaMin As String, fechaMax As String) As DataTable

        Try
            conectarDb()

            Dim query As String = "Select IDCliente, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal, Fecha
                                    FROM VENTAS
                                    JOIN VENTASITEMS ON VENTAS.ID = VENTASITEMS.ID
                                    WHERE PrecioTotal BETWEEN '" & precioMin & "' AND '" & precioMax & "'
                                    AND Cantidad BETWEEN '" & cantidadMin & "' AND '" & cantidadMax & "'
                                    AND Fecha BETWEEN '" & fechaMin & "' AND '" & fechaMax & "'"

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


    ' Pre: datos.fecha debe tener formato DateTime
    ' Post: Devuelve True si la conexión con la base de datos y la consulta de inserción fueron exitosas. False en cualquier otro caso.
    Public Function insertarVenta(datos As DbVentas) As Boolean

        Try

            Dim queryVentas As String = "INSERT INTO VENTAS(IDCliente, Fecha, Total) VALUES('" & datos.idCliente & "','" &
                                   datos.fecha & "','" & datos.precioTotal & "')"

            conectarDb()
            comando = New SqlCommand(queryVentas, conexion)
            comando.ExecuteNonQuery()

            Dim queryItems As String = "INSERT INTO VENTASITEMS(IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES('" & datos.idVenta & "','" &
                                   datos.idProducto & "','" & datos.precioUnitario & "','" & datos.cantidad & "','" & datos.precioTotal & "')"

            comando = New SqlCommand(queryItems, conexion)
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

    ' Pre: -
    ' Post: Devuelve la información recabada por la consulta. Si hubo algún error devuelve Nothing.
    Public Function consultarDatosVenta() As DataTable

        Try
            Dim query As String = "SELECT VENTAS.ID, Fecha, IDCliente, IdVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal
                                   FROM VENTAS
                                   JOIN VENTASITEMS ON VENTAS.ID = VENTASITEMS.ID"

            conectarDb()
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
    Public Function consultarTotalVentas() As String

        Try
            Dim query As String = "SELECT SUM(Total) FROM VENTAS"

            conectarDb()
            comando = New SqlCommand(query, conexion)
            Dim totalVentas = comando.ExecuteScalar()

            Return totalVentas

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally

            desconectarDb()

        End Try


    End Function

End Class
