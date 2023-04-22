Public Class FormInsertarProducto
    Private Sub BtnInsertarProducto_Click(sender As Object, e As EventArgs) Handles BtnInsertarProducto.Click

        Try

            If TxtNombre.Text <> "" And TxtPrecio.Text <> "" And TxtCategoria.Text <> "" Then

                Dim lp As New LogProductos()
                lp.insertarProducto(TxtNombre.Text, TxtPrecio.Text, TxtCategoria.Text)
                limpiarTextBox()

            Else
                MsgBox("No se pudo agregar al cliente porque faltan datos")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Public Sub limpiarTextBox()

        TxtNombre.Clear()
        TxtPrecio.Clear()
        TxtCategoria.Clear()

    End Sub


End Class