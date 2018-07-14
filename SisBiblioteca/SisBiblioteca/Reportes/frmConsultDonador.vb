

Public Class frmConsultDonador
    Public donador As String

    Private Sub frmConsultDonador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objrptdonador As New rptconsultaDonadorLibro
        objrptdonador.SetParameterValue("@NOMBRE", donador)

        CrystalReportViewer2.ReportSource = objrptdonador

    End Sub
End Class