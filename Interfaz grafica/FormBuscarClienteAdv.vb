Public Class FormBuscarClienteAdv

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click

        Try
            If TxtIdProducto.Text <> "" And FiltroPrecioMax.Value >= FiltroPrecioMin.Value Then

                Dim lc As New LogClientes
                Dim dt As DataTable = lc.consultarCliente(TxtIdProducto.Text, FiltroPrecioMin.Value, FiltroPrecioMax.Value)

                DataGridViewClientes.DataSource = dt


            Else
                MsgBox("Cometiste un error con los filtros, revisalos.")

            End If

        Catch ex As Exception

            MsgBox(ex.Message())

        End Try

    End Sub


End Class