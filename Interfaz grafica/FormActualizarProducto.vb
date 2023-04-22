Public Class FormActualizarProducto


    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Public Sub limpiarTextBox()

        TxtId.Clear()
        TxtNombre.Clear()
        TxtPrecio.Clear()
        TxtCategoria.Clear()

    End Sub

    Private Sub BtnActualizarProducto_Click(sender As Object, e As EventArgs) Handles BtnActualizarProducto.Click

        Dim lp As New LogProductos

        Try

            lp.actualizarProducto(TxtNombre.Text, TxtPrecio.Text, TxtCategoria.Text, TxtId.Text)
            limpiarTextBox()


        Catch ex As Exception

            MsgBox(ex.Message)


        End Try


    End Sub

    Private Sub TxtId_LostFocus(sender As Object, e As EventArgs) Handles TxtId.LostFocus

        Try
            Dim lp As New LogProductos

            Dim dt As DataTable = lp.consultarProducto(TxtId.Text)

            Dim dr As DataRow = dt.Rows(0)

            TxtNombre.Text = dr("Nombre")
            TxtPrecio.Text = dr("Precio")
            TxtCategoria.Text = dr("Categoria")

        Catch ex As Exception

            MsgBox("Tienes que indicar un ID válido")

        End Try


    End Sub


End Class