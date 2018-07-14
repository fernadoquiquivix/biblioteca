Imports System.Runtime.InteropServices

Public Class Menu
    'importar librerias
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnmaximizar_Click(sender As Object, e As EventArgs) Handles btnmaximizar.Click
        btnmaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnmaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Panelcabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelcabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If

    End Sub



    ''metodo para llamar a formularios

    Private Sub AbrirFomEnPanel(ByVal Formhijo As Object)
        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelcontenedor.Controls.Add(fh)
        Me.panelcontenedor.Tag = fh
        fh.Show()

    End Sub



    Private Sub btnregistrolibros_Click(sender As Object, e As EventArgs) Handles btnregistrolibros.Click
        AbrirFomEnPanel(New frmMenuRegistros)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFomEnPanel(New FrmMenuDonador)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmayuda.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFomEnPanel(New frmMenuReportes)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFomEnPanel(New frmMenuCliente)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFomEnPanel(New frmMenuUsuario)
    End Sub
End Class