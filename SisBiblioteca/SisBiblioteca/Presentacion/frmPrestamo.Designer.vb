<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamo
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtidentificacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnbuscarcliente = New System.Windows.Forms.Button()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtLibro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdlibro = New System.Windows.Forms.TextBox()
        Me.btnAgregarlibro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtidprestado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtidusuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre_usuario = New System.Windows.Forms.TextBox()
        Me.btnbuscarusuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txttelefono)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.imagen)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtapellido)
        Me.GroupBox4.Controls.Add(Me.txtidentificacion)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.btnGuardar)
        Me.GroupBox4.Controls.Add(Me.btnCancelar)
        Me.GroupBox4.Controls.Add(Me.btnNuevo)
        Me.GroupBox4.Controls.Add(Me.btnEditar)
        Me.GroupBox4.Controls.Add(Me.btnbuscarcliente)
        Me.GroupBox4.Controls.Add(Me.txtnombre_cliente)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtidcliente)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(18, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 259)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Cliente"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(103, 99)
        Me.txttelefono.MaxLength = 12
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(145, 21)
        Me.txttelefono.TabIndex = 51
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Telefono:"
        '
        'imagen
        '
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Image = Global.SisBiblioteca.My.Resources.Resources.file
        Me.imagen.Location = New System.Drawing.Point(257, 36)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(106, 95)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 50
        Me.imagen.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Apellidos:"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(103, 169)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(203, 21)
        Me.txtapellido.TabIndex = 47
        Me.txtapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtidentificacion
        '
        Me.txtidentificacion.Location = New System.Drawing.Point(103, 68)
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Size = New System.Drawing.Size(145, 21)
        Me.txtidentificacion.TabIndex = 45
        Me.txtidentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "DPI / Carné"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(254, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button2.Location = New System.Drawing.Point(29, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnGuardar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnGuardar.Location = New System.Drawing.Point(130, 215)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(101, 33)
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCancelar.Location = New System.Drawing.Point(252, -134)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkGreen
        Me.btnNuevo.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNuevo.Location = New System.Drawing.Point(21, -134)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 33)
        Me.btnNuevo.TabIndex = 39
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEditar.Location = New System.Drawing.Point(140, 215)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 33)
        Me.btnEditar.TabIndex = 40
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnbuscarcliente
        '
        Me.btnbuscarcliente.BackColor = System.Drawing.Color.DarkGreen
        Me.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscarcliente.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscarcliente.Location = New System.Drawing.Point(125, 29)
        Me.btnbuscarcliente.Name = "btnbuscarcliente"
        Me.btnbuscarcliente.Size = New System.Drawing.Size(123, 25)
        Me.btnbuscarcliente.TabIndex = 35
        Me.btnbuscarcliente.Text = "Asignar Cliente"
        Me.btnbuscarcliente.UseVisualStyleBackColor = False
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Location = New System.Drawing.Point(103, 140)
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(201, 21)
        Me.txtnombre_cliente.TabIndex = 34
        Me.txtnombre_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nombre:"
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(308, 141)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(16, 21)
        Me.txtidcliente.TabIndex = 33
        Me.txtidcliente.Visible = False
        '
        'txtLibro
        '
        Me.txtLibro.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibro.Location = New System.Drawing.Point(230, 65)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.Size = New System.Drawing.Size(315, 30)
        Me.txtLibro.TabIndex = 51
        Me.txtLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Libros:"
        '
        'txtIdlibro
        '
        Me.txtIdlibro.Location = New System.Drawing.Point(551, 67)
        Me.txtIdlibro.Name = "txtIdlibro"
        Me.txtIdlibro.Size = New System.Drawing.Size(16, 26)
        Me.txtIdlibro.TabIndex = 50
        Me.txtIdlibro.Visible = False
        '
        'btnAgregarlibro
        '
        Me.btnAgregarlibro.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAgregarlibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarlibro.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnAgregarlibro.Location = New System.Drawing.Point(508, 25)
        Me.btnAgregarlibro.Name = "btnAgregarlibro"
        Me.btnAgregarlibro.Size = New System.Drawing.Size(124, 33)
        Me.btnAgregarlibro.TabIndex = 45
        Me.btnAgregarlibro.Text = "Agregar libros"
        Me.btnAgregarlibro.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "de Libros"
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtcantidad.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.Lime
        Me.txtcantidad.Location = New System.Drawing.Point(538, 405)
        Me.txtcantidad.Multiline = True
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(94, 32)
        Me.txtcantidad.TabIndex = 37
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Cantidad"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(103, 68)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(145, 21)
        Me.txtfecha.TabIndex = 48
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(238, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "idprestado:"
        Me.Label8.Visible = False
        '
        'txtidprestado
        '
        Me.txtidprestado.Location = New System.Drawing.Point(320, 12)
        Me.txtidprestado.Name = "txtidprestado"
        Me.txtidprestado.Size = New System.Drawing.Size(25, 21)
        Me.txtidprestado.TabIndex = 46
        Me.txtidprestado.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Fecha:"
        '
        'txtidusuario
        '
        Me.txtidusuario.Location = New System.Drawing.Point(87, 37)
        Me.txtidusuario.Name = "txtidusuario"
        Me.txtidusuario.Size = New System.Drawing.Size(16, 21)
        Me.txtidusuario.TabIndex = 29
        Me.txtidusuario.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Usuario:"
        '
        'txtnombre_usuario
        '
        Me.txtnombre_usuario.Location = New System.Drawing.Point(105, 37)
        Me.txtnombre_usuario.Name = "txtnombre_usuario"
        Me.txtnombre_usuario.Size = New System.Drawing.Size(201, 21)
        Me.txtnombre_usuario.TabIndex = 30
        Me.txtnombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnbuscarusuario
        '
        Me.btnbuscarusuario.BackColor = System.Drawing.Color.DarkGreen
        Me.btnbuscarusuario.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscarusuario.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscarusuario.Location = New System.Drawing.Point(312, 38)
        Me.btnbuscarusuario.Name = "btnbuscarusuario"
        Me.btnbuscarusuario.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscarusuario.TabIndex = 31
        Me.btnbuscarusuario.Text = "...."
        Me.btnbuscarusuario.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Old English Text MT", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(38, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(322, 42)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Prestamos de Libros"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLibro)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.txtIdlibro)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.btnAgregarlibro)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(409, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(657, 455)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Prestamos"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.limpiar
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEliminar.Location = New System.Drawing.Point(18, 395)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 50)
        Me.btnEliminar.TabIndex = 23
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(33, 59)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(81, 24)
        Me.cbeliminar.TabIndex = 21
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"NOMBRE"})
        Me.cbocampo.Location = New System.Drawing.Point(33, 25)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(202, 28)
        Me.cbocampo.TabIndex = 19
        Me.cbocampo.Text = "nombre"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(276, 231)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(114, 20)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No Existen Datos"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(18, 103)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(614, 283)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnombre_usuario)
        Me.GroupBox1.Controls.Add(Me.btnbuscarusuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtidusuario)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtidprestado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 99)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Sistema"
        '
        'frmPrestamo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1076, 479)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrestamo"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents btnbuscarcliente As Button
    Friend WithEvents txtidusuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre_cliente As TextBox
    Friend WithEvents txtnombre_usuario As TextBox
    Friend WithEvents btnbuscarusuario As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregarlibro As Button
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents txtidprestado As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtLibro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdlibro As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidentificacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents imagen As PictureBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label10 As Label
End Class
