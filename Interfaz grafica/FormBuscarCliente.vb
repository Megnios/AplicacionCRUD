Public Class FormBuscarCliente


    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Private Sub limpiarTextBox()

        TxtCorreo.Clear()
        TxtId.Clear()
        TxtNombre.Clear()
        TxtTelefono.Clear()


    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click

        Try

            Dim lc As New LogClientes
            Dim dt As DataTable = lc.consultarCliente(TxtId.Text)
            Dim dr As DataRow = dt.Rows.Item(0)

            TxtNombre.Text = dr.Item("Cliente")
            TxtTelefono.Text = dr.Item("Telefono")
            TxtCorreo.Text = dr.Item("Correo")

        Catch ex As Exception

            MsgBox("No existe ningún cliente con ese ID")


        End Try

    End Sub

    Private Sub FormBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtCorreo.Enabled = False
        TxtTelefono.Enabled = False
        TxtNombre.Enabled = False

    End Sub

    Private Sub BtnBusClienteAdv_Click(sender As Object, e As EventArgs) Handles BtnBusClienteAdv.Click

        Dim frm As New FormBuscarClienteAdv()
        frm.Show()

    End Sub

    Private Sub BtnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles BtnNuevaConsulta.Click

        limpiarTextBox()


    End Sub


End Class