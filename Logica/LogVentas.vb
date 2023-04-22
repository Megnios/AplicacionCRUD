Public Class LogVentas

    ' Pre: -
    ' Post: Devuelve True si se pudo eliminar exitosamente el registro correspondiente. False en cualquier otro caso.
    Public Function eliminarVenta(id As String) As Boolean

        Try
            Dim dv As New DbVentas

            dv.eliminarVenta(id)

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False


        End Try


    End Function

    ' Pre: -
    ' Post: Devuelve True si se pudo actualizar exitosamente el registro correspondiente. False en cualquier otro caso.
    Public Function actualizarVenta(idCliente As String, id As String, idProducto As String, fecha As String, precioU As String, cantidad As String) As Boolean

        Try

            Dim dv As New DbVentas(idCliente, id, idProducto, precioU, cantidad, fecha)

            dv.actualizarVenta(dv)
            Return True


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    ' Pre: -
    ' Post: Recaba los datos pedidos y los devuelve. Si hubo algún error devuelve Nothing.
    Public Function consultarVenta(idVenta As String) As DataTable

        Try
            Dim dv As New DbVentas
            Dim dt As DataTable = dv.consultarVenta(idVenta)

            Return dt


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function

    ' Pre: 
    ' Post: Recaba los datos pedidos y los devuelve. Si hubo algún error devuelve Nothing.
    Public Function consultarVenta(precioMin As String, precioMax As String, cantidadMin As String, cantidadMax As String, fechaMin As String, fechaMax As String) As DataTable

        Try
            Dim dv As New DbVentas
            Dim dt As DataTable = dv.consultarVenta(precioMin, precioMax, cantidadMin, cantidadMax, fechaMin, fechaMax)

            Return dt


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function


    ' Pre:
    ' Post: Devuelve True si se pudo insertar satisfactoriamente el registro correspondiente. False en cualquier otro caso.
    Public Function insertarVenta(idCliente As String, idVenta As String, idProducto As String, precioUnitario As String, cantidad As String, fecha As String)

        Dim dv As New DbVentas(idCliente, idVenta, idProducto, precioUnitario, cantidad, fecha)

        If dv.insertarVenta(dv) = True Then
            Return True

        Else
            Return False

        End If

    End Function


    ' Pre: -
    ' Post: Devuelve el total de ventas. Nothing si algo sale mal.
    Public Function consultarTotalVentas() As String

        Dim dv As New DbVentas()

        Try

            Dim totalVentas = dv.consultarTotalVentas()
            Return totalVentas

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try


    End Function


End Class
