<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWebCam
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bntExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboVideoSource = New System.Windows.Forms.ComboBox()
        Me.VideoSourcePlayer1 = New AForge.Controls.VideoSourcePlayer()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bntExit
        '
        Me.bntExit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.bntExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.bntExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bntExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntExit.Image = Global.SisBiblioteca.My.Resources.Resources.round_delete_button
        Me.bntExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bntExit.Location = New System.Drawing.Point(187, 296)
        Me.bntExit.Name = "bntExit"
        Me.bntExit.Size = New System.Drawing.Size(92, 54)
        Me.bntExit.TabIndex = 9
        Me.bntExit.Text = "Salir"
        Me.bntExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bntExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cámaras"
        '
        'cboVideoSource
        '
        Me.cboVideoSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoSource.FormattingEnabled = True
        Me.cboVideoSource.Location = New System.Drawing.Point(40, 41)
        Me.cboVideoSource.Name = "cboVideoSource"
        Me.cboVideoSource.Size = New System.Drawing.Size(300, 24)
        Me.cboVideoSource.TabIndex = 6
        '
        'VideoSourcePlayer1
        '
        Me.VideoSourcePlayer1.Location = New System.Drawing.Point(40, 80)
        Me.VideoSourcePlayer1.Name = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.Size = New System.Drawing.Size(300, 198)
        Me.VideoSourcePlayer1.TabIndex = 11
        Me.VideoSourcePlayer1.Text = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.VideoSource = Nothing
        '
        'btnCapturar
        '
        Me.btnCapturar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnCapturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnCapturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.Image = Global.SisBiblioteca.My.Resources.Resources.camara_de_fotos
        Me.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCapturar.Location = New System.Drawing.Point(80, 296)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(90, 54)
        Me.btnCapturar.TabIndex = 12
        Me.btnCapturar.Text = "Capturar"
        Me.btnCapturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'FrmWebCam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(388, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCapturar)
        Me.Controls.Add(Me.VideoSourcePlayer1)
        Me.Controls.Add(Me.bntExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboVideoSource)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "FrmWebCam"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebCam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bntExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboVideoSource As ComboBox
    Friend WithEvents VideoSourcePlayer1 As AForge.Controls.VideoSourcePlayer
    Friend WithEvents btnCapturar As Button
End Class
