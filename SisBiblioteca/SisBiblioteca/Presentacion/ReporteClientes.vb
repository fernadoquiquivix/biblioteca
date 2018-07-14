Public Class ReporteClientes
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnTotalsexo_Click(sender As Object, e As EventArgs) Handles btnTotalsexo.Click
        Dim parametro As String = cboSexo.Text

        Dim consultgenerocliente As New FrmConsultaGeneroClient

        consultgenerocliente.Clientes = parametro

        consultgenerocliente.ShowDialog()
    End Sub
End Class