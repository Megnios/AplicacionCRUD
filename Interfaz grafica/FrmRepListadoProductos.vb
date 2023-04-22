Imports Microsoft.Reporting.WinForms

Public Class FrmRepListadoProductos
    Private Sub FrmRepListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RepListadoProductos.RefreshReport()

        generarReporte()

    End Sub

    Private Sub generarReporte()

        Try

            Dim dt As New DataTable
            Dim dp As New DbProductos

            dt = dp.consultarInfoProductos()

            RepListadoProductos.LocalReport.DataSources.Clear()

            Dim rpt As New ReportDataSource("DSListadoProductos", dt)

            RepListadoProductos.LocalReport.DataSources.Add(rpt)

            RepListadoProductos.RefreshReport()


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub
End Class