Imports Microsoft.Reporting.WinForms
Public Class FormRepDatosVenta
    Private Sub FormRepDatosVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RepDatosVenta.Refresh()
        generarReporte()

    End Sub


    Public Sub generarReporte()

        Try
            Dim dt As New DataTable
            Dim dv As New DbVentas

            dt = dv.consultarDatosVenta()

            RepDatosVenta.LocalReport.DataSources.Clear()

            Dim rpt As New ReportDataSource("DSVentas", dt)

            RepDatosVenta.LocalReport.DataSources.Add(rpt)

            RepDatosVenta.RefreshReport()



        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class