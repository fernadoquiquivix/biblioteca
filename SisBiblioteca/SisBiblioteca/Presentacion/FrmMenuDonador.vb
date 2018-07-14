Public Class FrmMenuDonador
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        ttmensaje.SetToolTip(btnsalir, "Salir del Formulario")
        ttmensaje.ToolTipTitle = "Salir"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PictureBox9_MouseHover(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover
        ttmensaje.SetToolTip(PictureBox9, "Asignacion de libros, según donador")
        ttmensaje.ToolTipTitle = "Asignación"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ttmensaje.SetToolTip(PictureBox1, "Reporte de Libros según donador")
        ttmensaje.ToolTipTitle = "Reporte"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        frmDetalle_Donacion.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmDonacion.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmReporteDonadores.ShowDialog()
    End Sub
End Class