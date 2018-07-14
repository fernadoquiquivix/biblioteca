Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class FrmWebCam
    Private Declare Function GetAsyncKeyState Lib "User32" (ByVal vKey As Integer) As Integer
    Dim VideoCaptureSource As VideoCaptureDevice
    Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
    '======================ROTINAS========================

    Private Sub DescarregarWebCam()
        VideoSourcePlayer1.SignalToStop()
        VideoSourcePlayer1.WaitForStop()
        VideoDevices = Nothing
        VideoCaptureSource = Nothing
        Me.Close()
    End Sub 'DESCARREGA DA MEMORIA


    Private Sub FrmWebCam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MySingleDevice As FilterInfo
        If VideoDevices.Count = 0 Then
            cboVideoSource.Items.Add("Não há dispositivos de vídeo")
        Else
            For Each MySingleDevice In VideoDevices
                cboVideoSource.Items.Add(MySingleDevice.Name)
            Next
        End If
        cboVideoSource.SelectedIndex = 0
    End Sub
    Private Sub cboVideoSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVideoSource.SelectedIndexChanged
        If cboVideoSource.SelectedItem <> "Não há dispositivos de vídeo" Then
            If VideoSourcePlayer1.IsRunning = True Then
                VideoSourcePlayer1.SignalToStop()
                VideoSourcePlayer1.WaitForStop()
            End If
            VideoCaptureSource = New VideoCaptureDevice(VideoDevices(cboVideoSource.SelectedIndex).MonikerString)
            VideoSourcePlayer1.VideoSource = VideoCaptureSource
            VideoSourcePlayer1.Start()
        End If
    End Sub 'INICIA VIDEO

    Private Sub bntExit_Click(sender As Object, e As EventArgs) Handles bntExit.Click
        DescarregarWebCam()
    End Sub

    'Private Sub SalvarImagem()
    '    Try
    '        Dim strFilename As String
    '        strFilename = "Sem_Nome" & ".jpg"

    '        If VideoSourcePlayer1.IsRunning = True Then
    '            VideoSourcePlayer1.GetCurrentVideoFrame.Save("C:\fotos\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
    '            MsgBox("Imagem Salva", MsgBoxStyle.Information, Title:="Web")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Exclamation, Title:="Web")
    '    End Try
    'End Sub 'SALVA A FOTO


    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click
        Try
            Dim strFilename As String
            strFilename = "Sem_Nome" & ".jpg"

            If VideoSourcePlayer1.IsRunning = True Then
                VideoSourcePlayer1.GetCurrentVideoFrame.Save("C:\fotos\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
                MsgBox("Imagem Salva", MsgBoxStyle.Information, Title:="Web")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, Title:="Web")
        End Try
    End Sub
End Class