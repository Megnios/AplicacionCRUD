Public Class FormActualizarVenta


    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Public Sub limpiarTextBox()

        TxtIdCliente.Clear()
        TxtIdVenta.Clear()
        TxtIdProducto.Clear()
        TxtPrecioU.Clear()
        TxtPrecioT.Clear()
        TxtCantidad.Clear()

    End Sub

    Private Sub BtnActualizarVenta_Click(sender As Object, e As EventArgs) Handles BtnActualizarVenta.Click

        Dim lv As New LogVentas

        Try
            If TxtIdVenta.Text <> "" Then

                lv.actualizarVenta(TxtIdCliente.Text, TxtIdVenta.Text, TxtIdProducto.Text, DTFecha.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"), TxtPrecioU.Text, TxtCantidad.Text)
                limpiarTextBox()

            Else
                MsgBox("Tienes que indicar el ID de la venta a actualizar")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)


        End Try


    End Sub

    Private Sub TxtIdVenta_LostFocus(sender As Object, e As EventArgs) Handles TxtIdVenta.LostFocus

        Try
            Dim lv As New LogVentas

            Dim dt As DataTable = lv.consultarVenta(TxtIdVenta.Text)

            Dim dr As DataRow = dt.Rows(0)

            TxtIdCliente.Text = dr("IDCliente")
            TxtId.Text = dr("ID")
            TxtIdProducto.Text = dr("IDProducto")
            TxtPrecioU.Text = dr("PrecioUnitario")
            TxtPrecioT.Text = dr("PrecioTotal")
            TxtCantidad.Text = dr("Cantidad")
            DTFecha.Text = DateTime.Now()


        Catch ex As Exception

            MsgBox("Tienes que indicar un ID válido")

        End Try


    End Sub


End Class