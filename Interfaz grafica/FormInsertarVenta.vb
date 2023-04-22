Public Class FormInsertarVenta
    Private Sub BtnInsertarVenta_Click(sender As Object, e As EventArgs) Handles BtnInsertarVenta.Click

        Try

            If TxtIdCliente.Text <> "" And TxtIdVenta.Text <> "" And TxtIdProducto.Text <> "" Then

                Dim lv As New LogVentas()
                lv.insertarVenta(TxtIdCliente.Text, TxtIdVenta.Text, TxtIdProducto.Text, TxtPrecioUnitario.Text, TxtCantidad.Text, DTFecha.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"))
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

        TxtIdCliente.Clear()
        TxtIdProducto.Clear()
        TxtIdVenta.Clear()
        TxtPrecioUnitario.Clear()
        TxtCantidad.Clear()

    End Sub


    Private Sub FormInsertarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTFecha.CustomFormat = "yyyy-MM-dd HH:mm:ss.fff"

    End Sub


End Class