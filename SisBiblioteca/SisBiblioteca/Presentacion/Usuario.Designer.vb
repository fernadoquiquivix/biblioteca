<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.cboacceso = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datosusuario = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btmcargar = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDpi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtidusuario = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.datosusuario.SuspendLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btmcargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboacceso
        '
        Me.cboacceso.FormattingEnabled = True
        Me.cboacceso.Items.AddRange(New Object() {"1", "0"})
        Me.cboacceso.Location = New System.Drawing.Point(257, 237)
        Me.cboacceso.Name = "cboacceso"
        Me.cboacceso.Size = New System.Drawing.Size(67, 28)
        Me.cboacceso.TabIndex = 12
        Me.cboacceso.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Estado"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(553, 114)
        Me.txttelefono.MaxLength = 12
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(125, 26)
        Me.txttelefono.TabIndex = 6
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(310, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(358, 42)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Regístro de Usuarios"
        '
        'datosusuario
        '
        Me.datosusuario.Controls.Add(Me.Button1)
        Me.datosusuario.Controls.Add(Me.btnlimpiar)
        Me.datosusuario.Controls.Add(Me.btmcargar)
        Me.datosusuario.Controls.Add(Me.imagen)
        Me.datosusuario.Controls.Add(Me.Label16)
        Me.datosusuario.Controls.Add(Me.cboTipoUsuario)
        Me.datosusuario.Controls.Add(Me.Label15)
        Me.datosusuario.Controls.Add(Me.Label14)
        Me.datosusuario.Controls.Add(Me.Label13)
        Me.datosusuario.Controls.Add(Me.txtDpi)
        Me.datosusuario.Controls.Add(Me.Label12)
        Me.datosusuario.Controls.Add(Me.txtApellido)
        Me.datosusuario.Controls.Add(Me.Label9)
        Me.datosusuario.Controls.Add(Me.txtCodigo)
        Me.datosusuario.Controls.Add(Me.txtfecha)
        Me.datosusuario.Controls.Add(Me.cboacceso)
        Me.datosusuario.Controls.Add(Me.Label10)
        Me.datosusuario.Controls.Add(Me.Label8)
        Me.datosusuario.Controls.Add(Me.txttelefono)
        Me.datosusuario.Controls.Add(Me.Label6)
        Me.datosusuario.Controls.Add(Me.txtemail)
        Me.datosusuario.Controls.Add(Me.Label5)
        Me.datosusuario.Controls.Add(Me.Label4)
        Me.datosusuario.Controls.Add(Me.txtpass)
        Me.datosusuario.Controls.Add(Me.Label3)
        Me.datosusuario.Controls.Add(Me.txtusuario)
        Me.datosusuario.Controls.Add(Me.Label2)
        Me.datosusuario.Controls.Add(Me.txtnombre)
        Me.datosusuario.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datosusuario.ForeColor = System.Drawing.Color.Black
        Me.datosusuario.Location = New System.Drawing.Point(39, 73)
        Me.datosusuario.Name = "datosusuario"
        Me.datosusuario.Size = New System.Drawing.Size(952, 282)
        Me.datosusuario.TabIndex = 7
        Me.datosusuario.TabStop = False
        Me.datosusuario.Text = "Datos de Usuario"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Snow
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = Global.SisBiblioteca.My.Resources.Resources.camara_de_fotos
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(763, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 61)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Capturar Foto"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Image = Global.SisBiblioteca.My.Resources.Resources.cancel_stop_exit_1583
        Me.btnlimpiar.Location = New System.Drawing.Point(868, 132)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(53, 49)
        Me.btnlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnlimpiar.TabIndex = 37
        Me.btnlimpiar.TabStop = False
        '
        'btmcargar
        '
        Me.btmcargar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.cargar
        Me.btmcargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmcargar.Image = Global.SisBiblioteca.My.Resources.Resources.cargar
        Me.btmcargar.Location = New System.Drawing.Point(868, 77)
        Me.btmcargar.Name = "btmcargar"
        Me.btmcargar.Size = New System.Drawing.Size(53, 49)
        Me.btmcargar.TabIndex = 36
        Me.btmcargar.TabStop = False
        '
        'imagen
        '
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Image = Global.SisBiblioteca.My.Resources.Resources.file
        Me.imagen.Location = New System.Drawing.Point(726, 73)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(123, 116)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 35
        Me.imagen.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(768, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Foto"
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Items.AddRange(New Object() {"Administrador", "Bibliotecario", "Auxiliar Biblioteca"})
        Me.cboTipoUsuario.Location = New System.Drawing.Point(462, 176)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(216, 28)
        Me.cboTipoUsuario.TabIndex = 10
        Me.cboTipoUsuario.Text = "Administrador"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(530, 153)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 20)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Tipo de Usuario"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(344, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Habilitado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(119, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 20)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "DPI"
        '
        'txtDpi
        '
        Me.txtDpi.Location = New System.Drawing.Point(43, 114)
        Me.txtDpi.Name = "txtDpi"
        Me.txtDpi.Size = New System.Drawing.Size(170, 26)
        Me.txtDpi.TabIndex = 4
        Me.txtDpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(534, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(422, 54)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(258, 26)
        Me.txtApellido.TabIndex = 3
        Me.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(45, 54)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(107, 26)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(43, 235)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(171, 26)
        Me.txtfecha.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(579, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(239, 114)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(290, 26)
        Me.txtemail.TabIndex = 5
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contraseña"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(254, 178)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(180, 26)
        Me.txtpass.TabIndex = 8
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(43, 178)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(190, 26)
        Me.txtusuario.TabIndex = 7
        Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(166, 54)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(241, 26)
        Me.txtnombre.TabIndex = 2
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(764, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 73)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de Regístro"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Snow
        Me.btnNuevo.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.new_file_40454
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNuevo.Location = New System.Drawing.Point(20, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(63, 45)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Snow
        Me.btnGuardar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.savetheapplication_guardar_2958
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnGuardar.Location = New System.Drawing.Point(86, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 47)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Snow
        Me.btnEditar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.edit_validated_40458
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEditar.Location = New System.Drawing.Point(89, 19)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 46)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Snow
        Me.btnCancelar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.canceltheapplication_cancelar_2901
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCancelar.Location = New System.Drawing.Point(148, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(63, 47)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(199, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "idUsuario:"
        Me.Label11.Visible = False
        '
        'txtidusuario
        '
        Me.txtidusuario.Location = New System.Drawing.Point(258, 9)
        Me.txtidusuario.Name = "txtidusuario"
        Me.txtidusuario.Size = New System.Drawing.Size(42, 20)
        Me.txtidusuario.TabIndex = 0
        Me.txtidusuario.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Snow
        Me.btnEliminar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.limpiar
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEliminar.Location = New System.Drawing.Point(838, 42)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 57)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(39, 361)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(952, 286)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Usuarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(337, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 34)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Búsquedad de Usuarios"
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(751, 65)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(81, 24)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(431, 217)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(114, 20)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No Existen Datos"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(330, 67)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(318, 26)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"NOMBRE", "USUARIO"})
        Me.cbocampo.Location = New System.Drawing.Point(23, 56)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(202, 28)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "Nombre"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.Location = New System.Drawing.Point(24, 105)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(912, 166)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(135, 7)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(37, 20)
        Me.txtflag.TabIndex = 11
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisBiblioteca.My.Resources.Resources.stop_close_off_14465
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 662)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 40)
        Me.Panel1.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bell MT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(329, -1)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(358, 42)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Regístro de Usuarios"
        '
        'FrmUsuario
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1017, 702)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.datosusuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtidusuario)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.datosusuario.ResumeLayout(False)
        Me.datosusuario.PerformLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btmcargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboacceso As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents datosusuario As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtidusuario As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtflag As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboTipoUsuario As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDpi As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents btmcargar As PictureBox
    Friend WithEvents imagen As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
End Class
