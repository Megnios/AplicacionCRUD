Public Class FormEliminarCliente



    ' Pre: -
    ' Post: Quita el texto de todas las TextBox.
    Private Sub limpiarTextBox()

        TxtCorreo.Clear()
        TxtId.Clear()
        TxtNombre.Clear()
        TxtTel.Clear()


    End Sub
    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles BtnEliminarCliente.Click

        Try
            If TxtId.Text <> "" Then

                Dim lc As New LogClientes

                lc.eliminarCliente(TxtId.Text)

                MsgBox("El Cliente ha sido eliminado satisfactoriamente")

                limpiarTextBox()

            Else

                MsgBox("Tienes que indicar un ID")

            End If


        Catch ex As Exception

            MsgBox(ex.Message)


        End Try

    End Sub



    Private Sub BtnConsultarCliente_Click(sender As Object, e As EventArgs) Handles BtnConsultarCliente.Click

        Try

            Dim lc As New LogClientes

            Dim dt As DataTable = lc.consultarCliente(TxtId.Text)

            Dim dr As DataRow = dt.Rows(0)

            TxtNombre.Text = dr("Cliente")
            TxtCorreo.Text = dr("Correo")
            TxtTel.Text = dr("Telefono")



        Catch ex As Exception

            MsgBox("No existe ningún cliente con ese ID")

        End Try

    End Sub

    Private Sub FormEliminarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtCorreo.Enabled = False
        TxtNombre.Enabled = False
        TxtTel.Enabled = False


    End Sub


End Class