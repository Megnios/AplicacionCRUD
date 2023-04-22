Public Class FormMainWindow


    Private Sub BtnConsultarVTotal_Click(sender As Object, e As EventArgs) Handles BtnConsultarVTotal.Click

        Dim lv As New LogVentas()

        Dim totalVentas = lv.consultarTotalVentas()

        MsgBox("El total vendido es de ARS$ " & totalVentas)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frm As New FormRepDatosVenta()

        frm.Show()


    End Sub

    Private Sub BtnProductosAlta_Click(sender As Object, e As EventArgs) Handles BtnProductosAlta.Click

        Dim frm As New FormInsertarProducto()
        frm.Show()

    End Sub

    Private Sub BtnProductosBaja_Click(sender As Object, e As EventArgs) Handles BtnProductosBaja.Click

        Dim frm As New FormEliminarProducto()
        frm.Show()

    End Sub

    Private Sub BtnProductosMod_Click(sender As Object, e As EventArgs) Handles BtnProductosMod.Click

        Dim frm As New FormActualizarProducto()
        frm.Show()

    End Sub

    Private Sub BtnProductosBus_Click(sender As Object, e As EventArgs) Handles BtnProductosBus.Click

        Dim frm As New FormBuscarProducto()
        frm.Show()

    End Sub

    Private Sub BtnVentasAlta_Click(sender As Object, e As EventArgs) Handles BtnVentasAlta.Click

        Dim frm As New FormInsertarVenta()
        frm.Show()

    End Sub

    Private Sub BtnVentasBaja_Click(sender As Object, e As EventArgs) Handles BtnVentasBaja.Click

        Dim frm As New FormEliminarVenta()
        frm.Show()

    End Sub

    Private Sub BtnVentasMod_Click(sender As Object, e As EventArgs) Handles BtnVentasMod.Click

        Dim frm As New FormActualizarVenta()
        frm.Show()

    End Sub

    Private Sub BtnVentasBus_Click(sender As Object, e As EventArgs) Handles BtnVentasBus.Click

        Dim frm As New FormBuscarVenta()
        frm.Show()

    End Sub

    Private Sub BtnClientesAlta_Click(sender As Object, e As EventArgs) Handles BtnClientesAlta.Click

        Dim frm As New FormInsertarCliente()
        frm.Show()

    End Sub

    Private Sub BtnClientesBaja_Click(sender As Object, e As EventArgs) Handles BtnClientesBaja.Click

        Dim frm As New FormEliminarCliente()
        frm.Show()

    End Sub

    Private Sub BtnClientesMod_Click(sender As Object, e As EventArgs) Handles BtnClientesMod.Click

        Dim frm As New FormActualizarCliente()
        frm.Show()

    End Sub

    Private Sub BtnClientesBus_Click(sender As Object, e As EventArgs) Handles BtnClientesBus.Click

        Dim frm As New FormBuscarCliente()
        frm.Show()

    End Sub

    Private Sub BtnRepListProd_Click(sender As Object, e As EventArgs) Handles BtnRepListProd.Click

        Dim frm As New FormRepListadoProductos()
        frm.Show()

    End Sub

End Class
