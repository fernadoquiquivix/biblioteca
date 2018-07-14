Public Class frmMenuRegistros
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub regLibros_Click(sender As Object, e As EventArgs) Handles regLibros.Click
        frmLibros.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmCategoria.ShowDialog()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        FrmAutor.ShowDialog()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        FrmEstado.ShowDialog()

    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmUbicacion.ShowDialog()
    End Sub
End Class