Public Class frmrptlibrostotaldonados
    Private Sub frmrptlibrostotaldonados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rptlibrostotaldonados
        CrystalReportViewer3.ReportSource = objreporte
    End Sub
End Class