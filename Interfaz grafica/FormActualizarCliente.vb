Public Class FormActualizarCliente

    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Public Sub limpiarTextBox()

        TxtId.Clear()
        TxtNombre.Clear()
        TxtCorreo.Clear()
        TxtTel.Clear()

    End Sub

    Private Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs) Handles BtnActualizarCliente.Click

        Dim lc As New LogClientes

        Try

            lc.actualizarCliente(TxtNombre.Text, TxtTel.Text, TxtCorreo.Text, TxtId.Text)
            limpiarTextBox()


        Catch ex As Exception

            MsgBox(ex.Message)


        End Try


    End Sub


    Private Sub TxtId_LostFocus(sender As Object, e As EventArgs) Handles TxtId.LostFocus

        Try
            Dim lc As New LogClientes

            Dim dt As DataTable = lc.consultarCliente(TxtId.Text)                                                     'Utilizo el evento LostFocus para hacer una consulta sobre el resto de datos

            Dim dr As DataRow = dt.Rows(0)                                                                            'Los guardo en una DataTable y luego utilizo DataRow para asignarlos.

            TxtNombre.Text = dr("Cliente")
            TxtCorreo.Text = dr("Correo")
            TxtTel.Text = dr("Telefono")

        Catch ex As Exception

            MsgBox("Tienes que indicar un ID válido")

        End Try


    End Sub


End Class