Public Class LogProductos


    ' Pre: -
    ' Post: Devuelve True si la acción de eliminar el registro correspondiente fue exitosa. False en cualquier otro caso.
    Public Function eliminarProducto(id As String) As Boolean

        Try
            Dim dp As New DbProductos

            dp.eliminarCliente(id)

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False


        End Try


    End Function


    ' Pre: -
    ' Post: Devuelve True si la accion de actualizar el registro correspondiente fue exitoso. False en cualquier otro caso.
    Public Function actualizarProducto(nombre As String, precio As String, categoria As String, id As String) As Boolean

        Try

            Dim dp As New DbProductos(nombre, precio, categoria, id)

            dp.actualizarProducto(dp)
            Return True


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function



    ' Pre: -
    ' Post: Devuelve la informacion recabada por la consulta. Si hubo algún error devuelve Nothing.
    Public Function consultarProducto(categoria As String, precioMin As String, precioMax As String) As DataTable
        Try
            Dim dp As New DbProductos
            Dim dt As DataTable = dp.consultarProducto(categoria, precioMin, precioMax)

            Return dt


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try


    End Function


    ' Pre: -
    ' Post: Devuelve la informacion recabada por la consulta. Si hubo algún error devuelve Nothing.
    Public Function consultarProducto(id As String) As DataTable

        Try
            Dim dp As New DbProductos
            Dim dt As DataTable = dp.consultarProducto(id)

            Return dt


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function


    ' Pre: -
    ' Post: Devuelve True si la acción de insertar el registro correspondiente fue exitosa. False en cualquier otro caso.
    Public Function insertarProducto(nombre As String, precio As String, categoria As String) As Boolean

        Dim dp As New DbProductos(nombre, precio, categoria)

        If dp.insertarProducto(dp) = True Then
            Return True

        Else
            Return False

        End If

    End Function

End Class
