Public Class FrmConsultaGeneroClient
    Public Clientes As String
    Private Sub FrmConsultaGeneroClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objrptcliente As New rptconsultaclientesgenero
        objrptcliente.SetParameterValue("@SEXO", Clientes)

        CrystalReportViewer4.ReportSource = objrptcliente
    End Sub
End Class