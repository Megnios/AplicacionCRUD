Public Class FormBuscarVenta



    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Private Sub limpiarTextBox()

        TxtCantidad.Clear()
        TxtIdCliente.Clear()
        TxtIdProducto.Clear()
        TxtIdVenta.Clear()
        TxtPrecioT.Clear()
        TxtPrecioU.Clear()


    End Sub
    Private Sub BtnBuscarVenta_Click(sender As Object, e As EventArgs) Handles BtnBuscarVenta.Click

        Try

            Dim lv As New LogVentas
            Dim dt As DataTable = lv.consultarVenta(TxtIdVenta.Text)
            Dim dr As DataRow = dt.Rows.Item(0)

            TxtIdProducto.Text = dr("IDProducto")
            TxtIdCliente.Text = dr("IDCliente")
            TxtPrecioU.Text = dr("PrecioUnitario")
            TxtCantidad.Text = dr("Cantidad")
            TxtPrecioT.Text = dr("PrecioTotal")
            DTPFecha.Value = dr("Fecha")


        Catch ex As Exception

            MsgBox("No existe ninguna venta con ese ID")

        End Try
    End Sub


    Private Sub FormBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtIdProducto.Enabled = False
        TxtIdCliente.Enabled = False
        TxtPrecioU.Enabled = False
        TxtCantidad.Enabled = False
        TxtPrecioT.Enabled = False
        DTPFecha.Enabled = False


    End Sub

    Private Sub BtnBusVentaAdv_Click(sender As Object, e As EventArgs) Handles BtnBusVentaAdv.Click

        Dim frm As New FormBuscarVentaAdv()
        frm.Show()

    End Sub

    Private Sub BtnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles BtnNuevaConsulta.Click

        limpiarTextBox()


    End Sub


End Class