<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteClientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTotalsexo = New System.Windows.Forms.Button()
        Me.btnTotalClientes = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Todos Los clientes"
        '
        'txtTotalCliente
        '
        Me.txtTotalCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCliente.Location = New System.Drawing.Point(276, 135)
        Me.txtTotalCliente.Name = "txtTotalCliente"
        Me.txtTotalCliente.Size = New System.Drawing.Size(65, 24)
        Me.txtTotalCliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Consultas de Clientes "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Clientes por Sexo"
        '
        'cboSexo
        '
        Me.cboSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cboSexo.Location = New System.Drawing.Point(79, 260)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(175, 28)
        Me.cboSexo.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(54, 139)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 363)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 50)
        Me.Panel1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(428, 29)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Consulta de Clientes Biblioteca CEPAC"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisBiblioteca.My.Resources.Resources.stop_close_off_14465
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnTotalsexo
        '
        Me.btnTotalsexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTotalsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalsexo.Image = Global.SisBiblioteca.My.Resources.Resources.impresora
        Me.btnTotalsexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTotalsexo.Location = New System.Drawing.Point(289, 226)
        Me.btnTotalsexo.Name = "btnTotalsexo"
        Me.btnTotalsexo.Size = New System.Drawing.Size(147, 82)
        Me.btnTotalsexo.TabIndex = 8
        Me.btnTotalsexo.Text = "Reporte"
        Me.btnTotalsexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTotalsexo.UseVisualStyleBackColor = True
        '
        'btnTotalClientes
        '
        Me.btnTotalClientes.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.Folder_Printer_22393
        Me.btnTotalClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTotalClientes.Location = New System.Drawing.Point(361, 110)
        Me.btnTotalClientes.Name = "btnTotalClientes"
        Me.btnTotalClientes.Size = New System.Drawing.Size(82, 55)
        Me.btnTotalClientes.TabIndex = 4
        Me.btnTotalClientes.UseVisualStyleBackColor = True
        '
        'ReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(498, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cboSexo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTotalsexo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTotalClientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalCliente)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReporteClientes"
        Me.Opacity = 0.96R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTotalClientes As Button
    Friend WithEvents btnTotalsexo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboSexo As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
