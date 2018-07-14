<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibros))
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfechalibro = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.btmcargar = New System.Windows.Forms.PictureBox()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btnbuscarubicacion = New System.Windows.Forms.Button()
        Me.txtubicacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtidubicacion = New System.Windows.Forms.TextBox()
        Me.btnbuscarestado = New System.Windows.Forms.Button()
        Me.txtestadolibro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidestado = New System.Windows.Forms.TextBox()
        Me.txtidlibro = New System.Windows.Forms.TextBox()
        Me.btnbuscarautor = New System.Windows.Forms.Button()
        Me.txtnombre_autor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidautor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnbuscarcategoria = New System.Windows.Forms.Button()
        Me.txtnombre_categoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ttmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnbuscareditorial = New System.Windows.Forms.Button()
        Me.txteditorial = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtideditorial = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtpaginas = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtdisponibles = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btmcargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-49, -29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Portda"
        '
        'txtfechalibro
        '
        Me.txtfechalibro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechalibro.Location = New System.Drawing.Point(502, 175)
        Me.txtfechalibro.Name = "txtfechalibro"
        Me.txtfechalibro.Size = New System.Drawing.Size(149, 26)
        Me.txtfechalibro.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(549, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtdisponibles)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtpaginas)
        Me.GroupBox1.Controls.Add(Me.btnbuscareditorial)
        Me.GroupBox1.Controls.Add(Me.txteditorial)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtideditorial)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.btnbuscarubicacion)
        Me.GroupBox1.Controls.Add(Me.txtubicacion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtidubicacion)
        Me.GroupBox1.Controls.Add(Me.btnbuscarestado)
        Me.GroupBox1.Controls.Add(Me.txtestadolibro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidestado)
        Me.GroupBox1.Controls.Add(Me.txtidlibro)
        Me.GroupBox1.Controls.Add(Me.btnbuscarautor)
        Me.GroupBox1.Controls.Add(Me.txtnombre_autor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtidautor)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.txtfechalibro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcategoria)
        Me.GroupBox1.Controls.Add(Me.txtnombre_categoria)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(32, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 331)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Libros"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.imagen)
        Me.GroupBox4.Controls.Add(Me.btmcargar)
        Me.GroupBox4.Controls.Add(Me.btnlimpiar)
        Me.GroupBox4.Location = New System.Drawing.Point(663, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 183)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Portada Libro"
        '
        'imagen
        '
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Image = Global.SisBiblioteca.My.Resources.Resources.file
        Me.imagen.Location = New System.Drawing.Point(10, 23)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(143, 154)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 24
        Me.imagen.TabStop = False
        '
        'btmcargar
        '
        Me.btmcargar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.Add_27013
        Me.btmcargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmcargar.Image = Global.SisBiblioteca.My.Resources.Resources.cargar
        Me.btmcargar.Location = New System.Drawing.Point(164, 41)
        Me.btmcargar.Name = "btmcargar"
        Me.btmcargar.Size = New System.Drawing.Size(63, 55)
        Me.btmcargar.TabIndex = 25
        Me.btmcargar.TabStop = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Image = Global.SisBiblioteca.My.Resources.Resources.cancel_stop_exit_1583
        Me.btnlimpiar.Location = New System.Drawing.Point(164, 102)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(63, 55)
        Me.btnlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnlimpiar.TabIndex = 26
        Me.btnlimpiar.TabStop = False
        '
        'btnbuscarubicacion
        '
        Me.btnbuscarubicacion.BackColor = System.Drawing.Color.White
        Me.btnbuscarubicacion.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.search_book_open_search_locate_6178
        Me.btnbuscarubicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarubicacion.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscarubicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarubicacion.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscarubicacion.Location = New System.Drawing.Point(437, 169)
        Me.btnbuscarubicacion.Name = "btnbuscarubicacion"
        Me.btnbuscarubicacion.Size = New System.Drawing.Size(53, 36)
        Me.btnbuscarubicacion.TabIndex = 40
        Me.btnbuscarubicacion.UseVisualStyleBackColor = False
        '
        'txtubicacion
        '
        Me.txtubicacion.Enabled = False
        Me.txtubicacion.Location = New System.Drawing.Point(271, 179)
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.Size = New System.Drawing.Size(160, 26)
        Me.txtubicacion.TabIndex = 12
        Me.txtubicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 20)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Ubicacion"
        '
        'txtidubicacion
        '
        Me.txtidubicacion.Location = New System.Drawing.Point(409, 152)
        Me.txtidubicacion.Name = "txtidubicacion"
        Me.txtidubicacion.Size = New System.Drawing.Size(16, 26)
        Me.txtidubicacion.TabIndex = 11
        Me.txtidubicacion.Visible = False
        '
        'btnbuscarestado
        '
        Me.btnbuscarestado.BackColor = System.Drawing.Color.White
        Me.btnbuscarestado.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.search_book_open_search_locate_6178
        Me.btnbuscarestado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarestado.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscarestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarestado.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscarestado.Location = New System.Drawing.Point(440, 106)
        Me.btnbuscarestado.Name = "btnbuscarestado"
        Me.btnbuscarestado.Size = New System.Drawing.Size(53, 35)
        Me.btnbuscarestado.TabIndex = 36
        Me.btnbuscarestado.UseVisualStyleBackColor = False
        '
        'txtestadolibro
        '
        Me.txtestadolibro.Enabled = False
        Me.txtestadolibro.Location = New System.Drawing.Point(271, 111)
        Me.txtestadolibro.Name = "txtestadolibro"
        Me.txtestadolibro.Size = New System.Drawing.Size(162, 26)
        Me.txtestadolibro.TabIndex = 10
        Me.txtestadolibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Estado del Libro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "idLibro"
        Me.Label1.Visible = False
        '
        'txtidestado
        '
        Me.txtidestado.Location = New System.Drawing.Point(417, 84)
        Me.txtidestado.Name = "txtidestado"
        Me.txtidestado.Size = New System.Drawing.Size(13, 26)
        Me.txtidestado.TabIndex = 9
        Me.txtidestado.Visible = False
        '
        'txtidlibro
        '
        Me.txtidlibro.Location = New System.Drawing.Point(287, 13)
        Me.txtidlibro.Name = "txtidlibro"
        Me.txtidlibro.Size = New System.Drawing.Size(31, 26)
        Me.txtidlibro.TabIndex = 0
        Me.txtidlibro.Visible = False
        '
        'btnbuscarautor
        '
        Me.btnbuscarautor.BackColor = System.Drawing.Color.White
        Me.btnbuscarautor.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.search_book_open_search_locate_6178
        Me.btnbuscarautor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarautor.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscarautor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarautor.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscarautor.Location = New System.Drawing.Point(217, 106)
        Me.btnbuscarautor.Name = "btnbuscarautor"
        Me.btnbuscarautor.Size = New System.Drawing.Size(51, 35)
        Me.btnbuscarautor.TabIndex = 32
        Me.btnbuscarautor.UseVisualStyleBackColor = False
        '
        'txtnombre_autor
        '
        Me.txtnombre_autor.Enabled = False
        Me.txtnombre_autor.Location = New System.Drawing.Point(11, 112)
        Me.txtnombre_autor.Name = "txtnombre_autor"
        Me.txtnombre_autor.Size = New System.Drawing.Size(202, 26)
        Me.txtnombre_autor.TabIndex = 8
        Me.txtnombre_autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Autor"
        '
        'txtidautor
        '
        Me.txtidautor.Location = New System.Drawing.Point(192, 82)
        Me.txtidautor.Name = "txtidautor"
        Me.txtidautor.Size = New System.Drawing.Size(16, 26)
        Me.txtidautor.TabIndex = 7
        Me.txtidautor.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Codigo Libro"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(11, 49)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(163, 26)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnbuscarcategoria
        '
        Me.btnbuscarcategoria.BackColor = System.Drawing.Color.White
        Me.btnbuscarcategoria.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.search_book_open_search_locate_6178
        Me.btnbuscarcategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarcategoria.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarcategoria.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscarcategoria.Location = New System.Drawing.Point(214, 169)
        Me.btnbuscarcategoria.Name = "btnbuscarcategoria"
        Me.btnbuscarcategoria.Size = New System.Drawing.Size(51, 39)
        Me.btnbuscarcategoria.TabIndex = 17
        Me.btnbuscarcategoria.UseVisualStyleBackColor = False
        '
        'txtnombre_categoria
        '
        Me.txtnombre_categoria.Enabled = False
        Me.txtnombre_categoria.Location = New System.Drawing.Point(11, 179)
        Me.txtnombre_categoria.Name = "txtnombre_categoria"
        Me.txtnombre_categoria.Size = New System.Drawing.Size(197, 26)
        Me.txtnombre_categoria.TabIndex = 6
        Me.txtnombre_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ejemplares"
        '
        'txtcantidad
        '
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Location = New System.Drawing.Point(16, 299)
        Me.txtcantidad.MaxLength = 15
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(105, 26)
        Me.txtcantidad.TabIndex = 4
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria"
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(192, 152)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(16, 26)
        Me.txtidcategoria.TabIndex = 5
        Me.txtidcategoria.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del Libro"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(196, 49)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(429, 26)
        Me.txtnombre.TabIndex = 2
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(703, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(255, 77)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de Registro"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.new_file_40454
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNuevo.Location = New System.Drawing.Point(22, 20)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(66, 51)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(-2, -29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 18)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Libro"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.canceltheapplication_cancelar_2901
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCancelar.Location = New System.Drawing.Point(169, 20)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(68, 51)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.savetheapplication_guardar_2958
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnGuardar.Location = New System.Drawing.Point(94, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 51)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.edit_validated_40458
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEditar.Location = New System.Drawing.Point(94, 20)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(69, 51)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(14, 51)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(81, 24)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(30, 412)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 314)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Libros"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(8, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 25)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Eliminar Libros"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Old English Text MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(349, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(255, 32)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Busqueda de Libros"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.limpiar
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEliminar.Location = New System.Drawing.Point(157, 23)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(62, 52)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(425, 185)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(114, 20)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No Existen Datos"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(610, 56)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(305, 26)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.AutoCompleteCustomSource.AddRange(New String() {"NOMBRE"})
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"CODIGO", "NOMBRE"})
        Me.cbocampo.Location = New System.Drawing.Point(610, 25)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(191, 28)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "NOMBRE"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datalistado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.Location = New System.Drawing.Point(9, 84)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(905, 181)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(331, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(292, 37)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Registros de Libros"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisBiblioteca.My.Resources.Resources.stop_close_off_14465
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 689)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 40)
        Me.Panel1.TabIndex = 44
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Snow
        Me.Label15.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(277, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(248, 37)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Regístrar Libros"
        '
        'btnbuscareditorial
        '
        Me.btnbuscareditorial.BackColor = System.Drawing.Color.White
        Me.btnbuscareditorial.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.search_book_open_search_locate_6178
        Me.btnbuscareditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscareditorial.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscareditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscareditorial.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscareditorial.Location = New System.Drawing.Point(219, 229)
        Me.btnbuscareditorial.Name = "btnbuscareditorial"
        Me.btnbuscareditorial.Size = New System.Drawing.Size(51, 39)
        Me.btnbuscareditorial.TabIndex = 48
        Me.btnbuscareditorial.UseVisualStyleBackColor = False
        '
        'txteditorial
        '
        Me.txteditorial.Enabled = False
        Me.txteditorial.Location = New System.Drawing.Point(16, 239)
        Me.txteditorial.Name = "txteditorial"
        Me.txteditorial.Size = New System.Drawing.Size(197, 26)
        Me.txteditorial.TabIndex = 47
        Me.txteditorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(70, 214)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 20)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Editorial"
        '
        'txtideditorial
        '
        Me.txtideditorial.Location = New System.Drawing.Point(197, 212)
        Me.txtideditorial.Name = "txtideditorial"
        Me.txtideditorial.Size = New System.Drawing.Size(16, 26)
        Me.txtideditorial.TabIndex = 46
        Me.txtideditorial.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(543, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 20)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Paginas"
        '
        'txtpaginas
        '
        Me.txtpaginas.Location = New System.Drawing.Point(514, 107)
        Me.txtpaginas.Name = "txtpaginas"
        Me.txtpaginas.Size = New System.Drawing.Size(112, 26)
        Me.txtpaginas.TabIndex = 49
        Me.txtpaginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(157, 276)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 20)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Disponibles"
        '
        'txtdisponibles
        '
        Me.txtdisponibles.Enabled = False
        Me.txtdisponibles.Location = New System.Drawing.Point(139, 299)
        Me.txtdisponibles.Name = "txtdisponibles"
        Me.txtdisponibles.Size = New System.Drawing.Size(110, 26)
        Me.txtdisponibles.TabIndex = 51
        Me.txtdisponibles.Text = "0"
        Me.txtdisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(299, 263)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 20)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Descripción"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(388, 229)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(513, 81)
        Me.txtdescripcion.TabIndex = 54
        '
        'frmLibros
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(974, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLibros"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libros"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btmcargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents btmcargar As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfechalibro As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnbuscarcategoria As Button
    Friend WithEvents txtnombre_categoria As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidcategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidlibro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btnbuscarautor As Button
    Friend WithEvents txtnombre_autor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidautor As TextBox
    Friend WithEvents btnbuscarestado As Button
    Friend WithEvents txtestadolibro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidestado As TextBox
    Friend WithEvents btnbuscarubicacion As Button
    Friend WithEvents txtubicacion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtidubicacion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents imagen As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ttmensaje As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtdisponibles As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtpaginas As TextBox
    Friend WithEvents btnbuscareditorial As Button
    Friend WithEvents txteditorial As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtideditorial As TextBox
End Class
