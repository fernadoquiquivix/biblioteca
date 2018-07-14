<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaGeneroClient
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
        Me.CrystalReportViewer4 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewer4
        '
        Me.CrystalReportViewer4.ActiveViewIndex = -1
        Me.CrystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer4.Name = "CrystalReportViewer4"
        Me.CrystalReportViewer4.Size = New System.Drawing.Size(1040, 462)
        Me.CrystalReportViewer4.TabIndex = 0
        '
        'FrmConsultaGeneroClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 462)
        Me.Controls.Add(Me.CrystalReportViewer4)
        Me.Name = "FrmConsultaGeneroClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cliente por Genero"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer4 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
