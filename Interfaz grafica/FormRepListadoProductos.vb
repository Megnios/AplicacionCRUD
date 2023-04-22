Imports Microsoft.Reporting.WinForms

Public Class FormRepListadoProductos
    Private Sub FormRepListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RVListadoProductos.RefreshReport()

        generarReporte()

    End Sub

    Private Sub generarReporte()

        Try

            Dim dt As New DataTable
            Dim dp As New DbProductos

            dt = dp.consultarInfoProductos()

            RVListadoProductos.LocalReport.DataSources.Clear()


            Dim rpt As New ReportDataSource("DSListadoProductos", dt)

            RVListadoProductos.LocalReport.DataSources.Add(rpt)

            RVListadoProductos.RefreshReport()


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

End Class