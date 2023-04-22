Public Class FormEliminarVenta



    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Private Sub limpiarTextBox()

        TxtCantidad.Clear()
        TxtFecha.Clear()
        TxtId.Clear()
        TxtIdCliente.Clear()
        TxtIdProducto.Clear()
        TxtIdVenta.Clear()
        TxtPrecioT.Clear()
        TxtPrecioU.Clear()


    End Sub
    Private Sub BtnEliminarVenta_Click(sender As Object, e As EventArgs) Handles BtnEliminarVenta.Click

        Try
            If TxtIdVenta.Text <> "" Then

                Dim lv As New LogVentas

                lv.eliminarVenta(TxtIdVenta.Text)

                MsgBox("La venta ha sido eliminado satisfactoriamente")
                limpiarTextBox()


            Else
                MsgBox("Tienes que indicar un ID de venta")

            End If


        Catch ex As Exception

            MsgBox(ex.Message)


        End Try

    End Sub



    Private Sub FormEliminarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtId.Enabled = False
        TxtIdCliente.Enabled = False
        TxtIdProducto.Enabled = False
        TxtPrecioU.Enabled = False
        TxtCantidad.Enabled = False
        TxtFecha.Enabled = False
        TxtPrecioT.Enabled = False


    End Sub

    Private Sub BtnConsultarVenta_Click(sender As Object, e As EventArgs) Handles BtnConsultarVenta.Click

        Try


            Dim lv As New LogVentas

            Dim dt As DataTable = lv.consultarVenta(TxtIdVenta.Text)

            Dim dr As DataRow = dt.Rows(0)

            TxtId.Text = dr("ID")
            TxtIdCliente.Text = dr("IDCliente")
            TxtIdVenta.Text = dr("IDVenta")
            TxtIdProducto.Text = dr("IDProducto")
            TxtPrecioU.Text = dr("PrecioUnitario")
            TxtCantidad.Text = dr("Cantidad")
            TxtFecha.Text = dr("Fecha")
            TxtPrecioT.Text = dr("PrecioTotal")


        Catch ex As Exception

            MsgBox("No existe ninguna venta con ese ID")

        End Try
    End Sub


End Class