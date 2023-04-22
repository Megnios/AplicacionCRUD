Public Class LogClientes



    ' Pre: -
    ' Post: Devuelve True si la acción de eliminar el cliente fue exitosa. False en cualquier otro caso.
    Public Function eliminarCliente(id As String) As Boolean

        Try
            Dim dc As New DbClientes

            dc.eliminarCliente(id)

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False


        End Try


    End Function


    ' Pre: -
    ' Post: Devuelve True si la acción de actualizar el cliente fue exitosa. False en cualquier otro caso.
    Public Function actualizarCliente(cliente As String, telefono As String, correo As String, id As String) As Boolean

        Try

            Dim dc As New DbClientes(cliente, telefono, correo, id)

            dc.actualizarCliente(dc)
            Return True


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function


    ' Pre: -
    ' Post: Devuelve la información recabada por la consulta. Nothing si hubo algún error.
    Public Function consultarCliente(idProducto As String, precioMin As String, precioMax As String) As DataTable

        Try
            Dim dc As New DbClientes
            Dim dt As DataTable = dc.consultarCliente(idProducto, precioMin, precioMax)

            Return dt

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function


    ' Pre: -
    ' Post: Devuelve la información recabada por la consulta. Nothing si hubo algun error.
    Public Function consultarCliente(id As String) As DataTable

        Try
            Dim dc As New DbClientes
            Dim dt As DataTable = dc.consultarCliente(id)

            Return dt


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function


    ' Pre: -
    ' Post: Devuelve True si la acción de insertar el cliente fue exitosa. False en cualquier otro caso.
    Public Function insertarCliente(nombre As String, tel As String, correo As String, id As String) As Boolean

        Dim datos_cliente As New DbClientes(nombre, tel, correo, id)

        If datos_cliente.insertarCliente(datos_cliente) = True Then
            Return True

        Else
            Return False

        End If

    End Function
End Class
