<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamoDeLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignaciónDeLibrosDonadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblLogUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblhora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LimeGreen
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.RegistrosToolStripMenuItem, Me.LibrosToolStripMenuItem, Me.BusquedaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip.Size = New System.Drawing.Size(1354, 37)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.UsuariosToolStripMenuItem, Me.PrintSetupToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(92, 29)
        Me.FileMenu.Text = "&Archivo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(158, 6)
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(161, 30)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(161, 30)
        Me.PrintSetupToolStripMenuItem.Text = "Empresa"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(158, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources.Windows_Stand_By_225291
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 30)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriaToolStripMenuItem, Me.AutorToolStripMenuItem, Me.UbicacionesToolStripMenuItem, Me.DonaciónToolStripMenuItem, Me.EstadoToolStripMenuItem, Me.ClienteToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(106, 29)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources.cabinet_21466
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources._1455555011_users_10_icon_icons_com_53271
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.AutorToolStripMenuItem.Text = "Autor"
        '
        'UbicacionesToolStripMenuItem
        '
        Me.UbicacionesToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources.books_214681
        Me.UbicacionesToolStripMenuItem.Name = "UbicacionesToolStripMenuItem"
        Me.UbicacionesToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.UbicacionesToolStripMenuItem.Text = "Ubicaciones"
        '
        'DonaciónToolStripMenuItem
        '
        Me.DonaciónToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources.box_21467
        Me.DonaciónToolStripMenuItem.Name = "DonaciónToolStripMenuItem"
        Me.DonaciónToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.DonaciónToolStripMenuItem.Text = "Donadores"
        '
        'EstadoToolStripMenuItem
        '
        Me.EstadoToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources.book_19742
        Me.EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem"
        Me.EstadoToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.EstadoToolStripMenuItem.Text = "Estado"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources.User_Group_80_icon_icons_com_57247
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeLibrosToolStripMenuItem, Me.PrestamoDeLibroToolStripMenuItem, Me.DevolucionesDeLibrosToolStripMenuItem, Me.AsignaciónDeLibrosDonadosToolStripMenuItem})
        Me.LibrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.LibrosToolStripMenuItem.Text = "Libros"
        '
        'IngresoDeLibrosToolStripMenuItem
        '
        Me.IngresoDeLibrosToolStripMenuItem.Image = Global.SisBiblioteca.My.Resources.Resources.books_214681
        Me.IngresoDeLibrosToolStripMenuItem.Name = "IngresoDeLibrosToolStripMenuItem"
        Me.IngresoDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(354, 30)
        Me.IngresoDeLibrosToolStripMenuItem.Text = "Ingreso de Libros"
        '
        'PrestamoDeLibroToolStripMenuItem
        '
        Me.PrestamoDeLibroToolStripMenuItem.Name = "PrestamoDeLibroToolStripMenuItem"
        Me.PrestamoDeLibroToolStripMenuItem.Size = New System.Drawing.Size(354, 30)
        Me.PrestamoDeLibroToolStripMenuItem.Text = "Prestamo de Libros"
        '
        'DevolucionesDeLibrosToolStripMenuItem
        '
        Me.DevolucionesDeLibrosToolStripMenuItem.Name = "DevolucionesDeLibrosToolStripMenuItem"
        Me.DevolucionesDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(354, 30)
        Me.DevolucionesDeLibrosToolStripMenuItem.Text = "Devoluciones de Libros"
        '
        'AsignaciónDeLibrosDonadosToolStripMenuItem
        '
        Me.AsignaciónDeLibrosDonadosToolStripMenuItem.Name = "AsignaciónDeLibrosDonadosToolStripMenuItem"
        Me.AsignaciónDeLibrosDonadosToolStripMenuItem.Size = New System.Drawing.Size(354, 30)
        Me.AsignaciónDeLibrosDonadosToolStripMenuItem.Text = "Asignación de Libros Donados"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaDeLibrosToolStripMenuItem, Me.BusquedaDeUsuarioToolStripMenuItem})
        Me.BusquedaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'BusquedaDeLibrosToolStripMenuItem
        '
        Me.BusquedaDeLibrosToolStripMenuItem.Name = "BusquedaDeLibrosToolStripMenuItem"
        Me.BusquedaDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(273, 30)
        Me.BusquedaDeLibrosToolStripMenuItem.Text = "Busqueda de Libros"
        '
        'BusquedaDeUsuarioToolStripMenuItem
        '
        Me.BusquedaDeUsuarioToolStripMenuItem.Name = "BusquedaDeUsuarioToolStripMenuItem"
        Me.BusquedaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(273, 30)
        Me.BusquedaDeUsuarioToolStripMenuItem.Text = "Busqueda de Usuario"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeLibrosToolStripMenuItem, Me.ReporteClientesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(104, 29)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ConsultaDeLibrosToolStripMenuItem
        '
        Me.ConsultaDeLibrosToolStripMenuItem.Name = "ConsultaDeLibrosToolStripMenuItem"
        Me.ConsultaDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(249, 30)
        Me.ConsultaDeLibrosToolStripMenuItem.Text = "Consulta de Libros"
        '
        'ReporteClientesToolStripMenuItem
        '
        Me.ReporteClientesToolStripMenuItem.Name = "ReporteClientesToolStripMenuItem"
        Me.ReporteClientesToolStripMenuItem.Size = New System.Drawing.Size(249, 30)
        Me.ReporteClientesToolStripMenuItem.Text = "Reporte Clientes"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(105, 29)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(254, 30)
        Me.NewWindowToolStripMenuItem.Text = "&Nueva ventana"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(254, 30)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(254, 30)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(254, 30)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(254, 30)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(254, 30)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(81, 29)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(253, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblLogUsuario, Me.ToolStripStatusLabel, Me.lblhora})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 705)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1354, 28)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 23)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'lblLogUsuario
        '
        Me.lblLogUsuario.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogUsuario.Name = "lblLogUsuario"
        Me.lblLogUsuario.Size = New System.Drawing.Size(78, 23)
        Me.lblLogUsuario.Text = "Usuario"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(143, 23)
        Me.ToolStripStatusLabel.Text = "Hora del Sistema:"
        '
        'lblhora
        '
        Me.lblhora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(52, 23)
        Me.lblhora.Text = "fecha"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.logo_fonfo_biblioteca
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.Text = "Sistema Biblioteca"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents lblhora As ToolStripStatusLabel
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamoDeLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolucionesDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignaciónDeLibrosDonadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblLogUsuario As ToolStripStatusLabel
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteClientesToolStripMenuItem As ToolStripMenuItem
End Class
