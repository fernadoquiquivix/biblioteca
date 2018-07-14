Public Class login

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim dts As New vusuario
            Dim func As New fusuario

            dts.gusuario = txtUsuario.Text
            dts.gpass = txtPass.Text


            If func.validar_usuario(dts) = True Then
                CargaSys.Show()
                Me.Hide()
            Else
                MsgBox("Datos incorrectos intente de nuevo", MsgBoxStyle.Information, "Acceso denegado al Sistema")
                txtPass.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        'para login de usuario del sistema
        Dim ag As frmInicio = New frmInicio

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub txtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        txtUsuario.Clear()
        txtUsuario.ForeColor = Color.LightGreen

    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        txtPass.Clear()
        txtPass.ForeColor = Color.LightGreen
        txtPass.UseSystemPasswordChar = True

    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ttmensaje.SetToolTip(btnIngresar, "Ingresar al Sistema")
        ttmensaje.ToolTipTitle = "Ingresar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ttmensaje.SetToolTip(txtUsuario, "Ingresar Usuario")
        ttmensaje.ToolTipTitle = "Usuario"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtPass_MouseHover(sender As Object, e As EventArgs) Handles txtPass.MouseHover
        ttmensaje.SetToolTip(txtPass, "Ingresar Contraseña")
        ttmensaje.ToolTipTitle = "Contraseña"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "Usuario"
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then
            txtPass.Text = "Contraseña"
            txtPass.ForeColor = Color.DimGray
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub

End Class