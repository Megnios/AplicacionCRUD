Public Class FormBuscarProductoAdv
    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click

        Try
            If TxtCategoria.Text <> "" And FiltroPrecioMax.Value >= FiltroPrecioMin.Value Then
                Dim lp As New LogProductos
                Dim dt As DataTable = lp.consultarProducto(TxtCategoria.Text, FiltroPrecioMin.Value, FiltroPrecioMax.Value)
                DataGridViewProductos.DataSource = dt

            Else
                MsgBox("Cometiste un error con los filtros, revisalos")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

End Class