Public Class FormEliminarProducto



    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Public Sub limpiarTextBox()

        TxtCategoria.Clear()
        TxtId.Clear()
        TxtNombre.Clear()
        TxtPrecio.Clear()


    End Sub
    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click

        Try
            If TxtId.Text <> "" Then

                Dim lp As New LogProductos

                lp.eliminarProducto(TxtId.Text)

                MsgBox("El producto ha sido eliminado satisfactoriamente")

                limpiarTextBox()


            Else

                MsgBox("Tienes que indicar un ID")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)


        End Try

    End Sub


    Private Sub FormEliminarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtCategoria.Enabled = False
        TxtNombre.Enabled = False
        TxtPrecio.Enabled = False


    End Sub

    Private Sub BtnConsultarProducto_Click(sender As Object, e As EventArgs) Handles BtnConsultarProducto.Click

        Try
            Dim lp As New LogProductos

            Dim dt As DataTable = lp.consultarProducto(TxtId.Text)

            Dim dr As DataRow = dt.Rows(0)

            TxtNombre.Text = dr("Nombre")
            TxtPrecio.Text = dr("Precio")
            TxtCategoria.Text = dr("Categoria")

        Catch ex As Exception

            MsgBox("No existe ningún producto con ese ID")

        End Try

    End Sub


End Class