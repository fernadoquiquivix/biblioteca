Public Class frmConsultalibros
    Private Sub frmConsultalibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rptlibros
        CrystalReportViewer1.ReportSource = objreporte
    End Sub


End Class