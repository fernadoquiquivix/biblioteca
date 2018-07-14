<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Panelcabecera = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnmaximizar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btndevolucion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnprestamo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnregistrolibros = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelcontenedor = New System.Windows.Forms.Panel()
        Me.Panelcabecera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelcabecera
        '
        Me.Panelcabecera.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panelcabecera.Controls.Add(Me.Label1)
        Me.Panelcabecera.Controls.Add(Me.btnRestaurar)
        Me.Panelcabecera.Controls.Add(Me.btnMinimizar)
        Me.Panelcabecera.Controls.Add(Me.btnmaximizar)
        Me.Panelcabecera.Controls.Add(Me.btncerrar)
        Me.Panelcabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelcabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panelcabecera.Name = "Panelcabecera"
        Me.Panelcabecera.Size = New System.Drawing.Size(1200, 50)
        Me.Panelcabecera.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registro y Gestión Bibliotecaria"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.SisBiblioteca.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1109, 7)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.SisBiblioteca.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1063, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnmaximizar
        '
        Me.btnmaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaximizar.FlatAppearance.BorderSize = 0
        Me.btnmaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnmaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmaximizar.Image = Global.SisBiblioteca.My.Resources.Resources.Icono_Maximizar
        Me.btnmaximizar.Location = New System.Drawing.Point(1109, 7)
        Me.btnmaximizar.Name = "btnmaximizar"
        Me.btnmaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnmaximizar.TabIndex = 1
        Me.btnmaximizar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.SisBiblioteca.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(1155, 5)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(40, 40)
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.PaleGreen
        Me.PanelMenu.Controls.Add(Me.PictureBox3)
        Me.PanelMenu.Controls.Add(Me.Panel7)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.Button6)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.Button5)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.Button4)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.btndevolucion)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.btnprestamo)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.btnregistrolibros)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 50)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 650)
        Me.PanelMenu.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SisBiblioteca.My.Resources.Resources.info
        Me.PictureBox3.Location = New System.Drawing.Point(0, 604)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel7.Location = New System.Drawing.Point(0, 426)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 50)
        Me.Panel7.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SisBiblioteca.My.Resources.Resources.cliente
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 50)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "     Donaciones"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Jokerman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 51)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CEPAC"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel6.Location = New System.Drawing.Point(0, 484)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.SisBiblioteca.My.Resources.Resources.diagrama
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(3, 484)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(217, 50)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "     Reportes"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel5.Location = New System.Drawing.Point(0, 366)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.SisBiblioteca.My.Resources.Resources.equipo
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 366)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 50)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "     Usuarios"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel4.Location = New System.Drawing.Point(0, 308)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.SisBiblioteca.My.Resources.Resources.grupo
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 50)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "     Clientes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel3.Location = New System.Drawing.Point(0, 250)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 4
        '
        'btndevolucion
        '
        Me.btndevolucion.BackColor = System.Drawing.Color.Transparent
        Me.btndevolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndevolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndevolucion.FlatAppearance.BorderSize = 0
        Me.btndevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btndevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndevolucion.Image = Global.SisBiblioteca.My.Resources.Resources.trabajador_de_delivery_que_da_una_caja_a_un_receptor
        Me.btndevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndevolucion.Location = New System.Drawing.Point(3, 250)
        Me.btndevolucion.Name = "btndevolucion"
        Me.btndevolucion.Size = New System.Drawing.Size(217, 50)
        Me.btndevolucion.TabIndex = 5
        Me.btndevolucion.Text = "     Devoluciones"
        Me.btndevolucion.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Location = New System.Drawing.Point(0, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 2
        '
        'btnprestamo
        '
        Me.btnprestamo.BackColor = System.Drawing.Color.Transparent
        Me.btnprestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnprestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprestamo.FlatAppearance.BorderSize = 0
        Me.btnprestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnprestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnprestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprestamo.Image = Global.SisBiblioteca.My.Resources.Resources.dar_una_tarjeta_de_presentacion
        Me.btnprestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprestamo.Location = New System.Drawing.Point(3, 192)
        Me.btnprestamo.Name = "btnprestamo"
        Me.btnprestamo.Size = New System.Drawing.Size(217, 50)
        Me.btnprestamo.TabIndex = 3
        Me.btnprestamo.Text = "     Prestamos"
        Me.btnprestamo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Location = New System.Drawing.Point(0, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SisBiblioteca.My.Resources.Resources.libros_en_pila_de_tres
        Me.PictureBox1.Location = New System.Drawing.Point(3, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnregistrolibros
        '
        Me.btnregistrolibros.BackColor = System.Drawing.Color.Transparent
        Me.btnregistrolibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnregistrolibros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistrolibros.FlatAppearance.BorderSize = 0
        Me.btnregistrolibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregistrolibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnregistrolibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistrolibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistrolibros.Image = Global.SisBiblioteca.My.Resources.Resources.libro_abierto2
        Me.btnregistrolibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistrolibros.Location = New System.Drawing.Point(3, 133)
        Me.btnregistrolibros.Name = "btnregistrolibros"
        Me.btnregistrolibros.Size = New System.Drawing.Size(217, 50)
        Me.btnregistrolibros.TabIndex = 0
        Me.btnregistrolibros.Text = "      Registros"
        Me.btnregistrolibros.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = Global.SisBiblioteca.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(173, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(47, 37)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'panelcontenedor
        '
        Me.panelcontenedor.BackgroundImage = Global.SisBiblioteca.My.Resources.Resources.logo_fonfo_biblioteca
        Me.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelcontenedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcontenedor.Location = New System.Drawing.Point(220, 50)
        Me.panelcontenedor.Name = "panelcontenedor"
        Me.panelcontenedor.Size = New System.Drawing.Size(980, 650)
        Me.panelcontenedor.TabIndex = 2
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.panelcontenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panelcabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteca"
        Me.Panelcabecera.ResumeLayout(False)
        Me.Panelcabecera.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelcabecera As Panel
    Friend WithEvents btncerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents panelcontenedor As Panel
    Friend WithEvents btnmaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnregistrolibros As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btndevolucion As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnprestamo As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
