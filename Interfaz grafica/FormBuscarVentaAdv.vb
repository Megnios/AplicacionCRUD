Public Class FormBuscarVentaAdv
    Private Sub BtnBuscarVenta_Click(sender As Object, e As EventArgs) Handles BtnBuscarVenta.Click

        Try
            If FiltroPrecioTMax.Value >= FiltroPrecioTMin.Value And FiltroCantidadMin.Value <= FiltroCantidadMax.Value And DTFechaMin.Value <= DTFechaMax.Value Then

                Dim lv As New LogVentas
                Dim dt As DataTable = lv.consultarVenta(FiltroPrecioTMin.Value, FiltroPrecioTMax.Value, FiltroCantidadMin.Value,
                                                        FiltroCantidadMax.Value, DTFechaMin.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"), DTFechaMax.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"))

                DataGridViewVentas.DataSource = dt


            Else
                MsgBox("Cometiste un error con los filtros, revisalos.")

            End If

        Catch ex As Exception

            MsgBox(ex.Message())

        End Try
    End Sub

    Private Sub FormBuscarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTFechaMin.CustomFormat = "yyyy-MM-dd HH:mm:ss.fff"
        DTFechaMax.CustomFormat = "yyyy-MM-dd HH:mm:ss.fff"

    End Sub


End Class