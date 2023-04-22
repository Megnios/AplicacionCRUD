Public Class FormBuscarProducto


    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Public Sub limpiarTextBox()

        TxtCategoria.Clear()
        TxtId.Clear()
        TxtNombre.Clear()
        TxtPrecio.Clear()


    End Sub
    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click

        Try

            Dim lp As New LogProductos
            Dim dt As DataTable = lp.consultarProducto(TxtId.Text)
            Dim dr As DataRow = dt.Rows.Item(0)

            TxtNombre.Text = dr.Item("Nombre")
            TxtPrecio.Text = dr.Item("Precio")
            TxtCategoria.Text = dr.Item("Categoria")

        Catch ex As Exception

            MsgBox("No existe ningún producto con ese ID")

        End Try
    End Sub


    Private Sub FormBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtNombre.Enabled = False
        TxtPrecio.Enabled = False
        TxtCategoria.Enabled = False

    End Sub

    Private Sub BtnBusProdAdv_Click(sender As Object, e As EventArgs) Handles BtnBusProdAdv.Click

        Dim frm As New FormBuscarProductoAdv()
        frm.Show()

    End Sub

    Private Sub BtnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles BtnNuevaConsulta.Click

        limpiarTextBox()


    End Sub


End Class