Public Class CargaSys
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Cada segundo la barra de progreso debe aumentar en 20
        If ProgressBar1.Value < 100 Then
            'vamos aclarando la opacidad del formulario
            Me.Opacity = Me.Opacity + 0.1
            ProgressBar1.Value = ProgressBar1.Value + 10
            lblmensaje.Text = "CARGANDO EL SISTEMA AL " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Dim f As New Menu
            Me.Hide()
            f.ShowDialog()
            End
        End If
    End Sub

End Class