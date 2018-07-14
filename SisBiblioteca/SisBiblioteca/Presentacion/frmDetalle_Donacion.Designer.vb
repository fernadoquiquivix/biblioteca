<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalle_Donacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalle_Donacion))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtiddetalle_donacion = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtfechalibro = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnbuscarlibro = New System.Windows.Forms.Button()
        Me.txtnombre_libro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidlibro = New System.Windows.Forms.TextBox()
        Me.btnbuscardonador = New System.Windows.Forms.Button()
        Me.txtdonador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtiddonacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(121, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 40)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Asignación Libros"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(27, 23)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(81, 24)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.total)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 317)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Donaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(627, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Total Libros"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(631, 66)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(80, 26)
        Me.total.TabIndex = 29
        Me.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(169, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Ingrese Donador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(256, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Busqueda de Libros"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Snow
        Me.btnEliminar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.limpiar
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEliminar.Location = New System.Drawing.Point(27, 45)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(54, 45)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(321, 205)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(114, 20)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "No Existen Datos"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(329, 65)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(219, 26)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"NOMBRE", "FECHA"})
        Me.cbocampo.Location = New System.Drawing.Point(87, 45)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(79, 28)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "NOMBRE"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(24, 96)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(687, 206)
        Me.datalistado.TabIndex = 0
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtiddetalle_donacion
        '
        Me.txtiddetalle_donacion.Location = New System.Drawing.Point(469, 72)
        Me.txtiddetalle_donacion.Name = "txtiddetalle_donacion"
        Me.txtiddetalle_donacion.Size = New System.Drawing.Size(25, 20)
        Me.txtiddetalle_donacion.TabIndex = 0
        Me.txtiddetalle_donacion.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Snow
        Me.btnEditar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.edit_validated_40458
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEditar.Location = New System.Drawing.Point(93, 25)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 62)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtfechalibro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnbuscarlibro)
        Me.GroupBox1.Controls.Add(Me.txtnombre_libro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtidlibro)
        Me.GroupBox1.Controls.Add(Me.btnbuscardonador)
        Me.GroupBox1.Controls.Add(Me.txtdonador)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtiddonacion)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(25, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 157)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignación de Donaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(544, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(516, 114)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(133, 26)
        Me.txtcantidad.TabIndex = 28
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfechalibro
        '
        Me.txtfechalibro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechalibro.Location = New System.Drawing.Point(504, 52)
        Me.txtfechalibro.Name = "txtfechalibro"
        Me.txtfechalibro.Size = New System.Drawing.Size(155, 26)
        Me.txtfechalibro.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(549, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 23)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Fecha"
        '
        'btnbuscarlibro
        '
        Me.btnbuscarlibro.BackColor = System.Drawing.Color.Snow
        Me.btnbuscarlibro.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.search_book_open_search_locate_6178
        Me.btnbuscarlibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarlibro.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscarlibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarlibro.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscarlibro.Location = New System.Drawing.Point(397, 106)
        Me.btnbuscarlibro.Name = "btnbuscarlibro"
        Me.btnbuscarlibro.Size = New System.Drawing.Size(52, 38)
        Me.btnbuscarlibro.TabIndex = 25
        Me.btnbuscarlibro.UseVisualStyleBackColor = False
        '
        'txtnombre_libro
        '
        Me.txtnombre_libro.Enabled = False
        Me.txtnombre_libro.Location = New System.Drawing.Point(76, 112)
        Me.txtnombre_libro.Name = "txtnombre_libro"
        Me.txtnombre_libro.Size = New System.Drawing.Size(308, 26)
        Me.txtnombre_libro.TabIndex = 24
        Me.txtnombre_libro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 23)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Libro"
        '
        'txtidlibro
        '
        Me.txtidlibro.Location = New System.Drawing.Point(56, 111)
        Me.txtidlibro.Name = "txtidlibro"
        Me.txtidlibro.Size = New System.Drawing.Size(16, 26)
        Me.txtidlibro.TabIndex = 23
        Me.txtidlibro.Visible = False
        '
        'btnbuscardonador
        '
        Me.btnbuscardonador.BackColor = System.Drawing.Color.Snow
        Me.btnbuscardonador.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.search_book_open_search_locate_6178
        Me.btnbuscardonador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscardonador.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnbuscardonador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscardonador.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnbuscardonador.Location = New System.Drawing.Point(397, 49)
        Me.btnbuscardonador.Name = "btnbuscardonador"
        Me.btnbuscardonador.Size = New System.Drawing.Size(52, 37)
        Me.btnbuscardonador.TabIndex = 21
        Me.btnbuscardonador.UseVisualStyleBackColor = False
        '
        'txtdonador
        '
        Me.txtdonador.Enabled = False
        Me.txtdonador.Location = New System.Drawing.Point(76, 54)
        Me.txtdonador.Name = "txtdonador"
        Me.txtdonador.Size = New System.Drawing.Size(308, 26)
        Me.txtdonador.TabIndex = 20
        Me.txtdonador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Donador"
        '
        'txtiddonacion
        '
        Me.txtiddonacion.Location = New System.Drawing.Point(57, 54)
        Me.txtiddonacion.Name = "txtiddonacion"
        Me.txtiddonacion.Size = New System.Drawing.Size(16, 26)
        Me.txtiddonacion.TabIndex = 19
        Me.txtiddonacion.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "iddetalle_donacion:"
        Me.Label11.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Location = New System.Drawing.Point(503, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(255, 92)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Snow
        Me.btnNuevo.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.new_file_40454
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNuevo.Location = New System.Drawing.Point(11, 23)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 62)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Snow
        Me.btnGuardar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.savetheapplication_guardar_2958
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnGuardar.Location = New System.Drawing.Point(92, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 62)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Snow
        Me.btnCancelar.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.canceltheapplication_cancelar_2901
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCancelar.Location = New System.Drawing.Point(171, 24)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 59)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(198, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 40)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Donados"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisBiblioteca.My.Resources.Resources.stop_close_off_14465
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 589)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 40)
        Me.Panel1.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(284, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(265, 31)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Asignación de Libros"
        '
        'frmDetalle_Donacion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(789, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtiddetalle_donacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetalle_Donacion"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Donacion"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtiddetalle_donacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscardonador As Button
    Friend WithEvents txtdonador As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtiddonacion As TextBox
    Friend WithEvents btnbuscarlibro As Button
    Friend WithEvents txtnombre_libro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidlibro As TextBox
    Friend WithEvents txtfechalibro As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents total As TextBox
End Class
