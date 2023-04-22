Public Class FormInsertarCliente
    Private Sub BtnInsertarCliente_Click(sender As Object, e As EventArgs) Handles BtnInsertarCliente.Click

        Try

            If TxtNombre.Text <> "" And TxtCorreo.Text <> "" And TxtTel.Text <> "" Then

                Dim lc As New LogClientes()
                lc.insertarCliente(TxtNombre.Text, TxtTel.Text, TxtCorreo.Text, "0")
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
        TxtCorreo.Clear()
        TxtTel.Clear()

    End Sub


End Class