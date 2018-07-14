Imports System.Windows.Forms

Public Class frmInicio

    Public sp As login

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmUsuario.MdiParent = Me
        FrmUsuario.Show()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblLogUsuario.Text = My.Forms.login.txtUsuario.Text

        lblhora.Text = TimeOfDay

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmayuda.MdiParent = Me
        frmayuda.Show()
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        FrmAutor.MdiParent = Me
        FrmAutor.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        FrmCategoria.MdiParent = Me
        FrmCategoria.Show()
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoToolStripMenuItem.Click
        FrmEstado.MdiParent = Me
        FrmEstado.Show()
    End Sub

    Private Sub DonaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonaciónToolStripMenuItem.Click
        frmDonacion.MdiParent = Me
        frmDonacion.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        frmcliente.MdiParent = Me
        frmcliente.Show()
    End Sub

    Private Sub UbicacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbicacionesToolStripMenuItem.Click
        FrmUbicacion.MdiParent = Me
        FrmUbicacion.Show()
    End Sub

    Private Sub IngresoDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeLibrosToolStripMenuItem.Click
        frmLibros.MdiParent = Me
        frmLibros.Show()
    End Sub

    Private Sub AsignaciónDeLibrosDonadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaciónDeLibrosDonadosToolStripMenuItem.Click
        frmDetalle_Donacion.MdiParent = Me
        frmDetalle_Donacion.Show()
    End Sub

    Private Sub ConsultaDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeLibrosToolStripMenuItem.Click
        frmConsultalibros.MdiParent = Me
        frmConsultalibros.Show()

    End Sub

    Private Sub PrestamoDeLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamoDeLibroToolStripMenuItem.Click
        frmPrestamo.MdiParent = Me
        frmPrestamo.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FrmUsuario.MdiParent = Me
        FrmUsuario.Show()
    End Sub

    Private Sub ReporteClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteClientesToolStripMenuItem.Click
        ReporteClientes.MdiParent = Me
        ReporteClientes.Show()
    End Sub
End Class
