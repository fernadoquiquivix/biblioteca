Imports System.ComponentModel
Public Class frmLibros
    Private dt As New DataTable
    Dim dv As New DataView
    Private Sub frmLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llamo a la funcion mostrar
        mostrar()
        'titulo a columnas
        'datalistado.Columns(3).HeaderText = "TITULO"
        'datalistado.Columns(4).HeaderText = "FECHA"
        'datalistado.Columns(5).HeaderText = "EJEMPLARES"
        'datalistado.Columns(7).HeaderText = "CATEGORIA"
        'datalistado.Columns(11).HeaderText = "ESTADO"
        'datalistado.Columns(15).HeaderText = "DISPONIBLES"
        'datalistado.Columns(17).HeaderText = "PAGINAS"
        'datalistado.Columns(19).HeaderText = "EDITORIAL"

        'centrar datagri
        ' datalistado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    'creo un procedimiento para limpiar el formulario
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtcantidad.Text = ""
        txtidlibro.Text = ""
        txtfechalibro.Text = ""
        txtidcategoria.Text = ""
        txtnombre_categoria.Text = ""
        txtidautor.Text = ""
        txtnombre_autor.Text = ""
        txtidestado.Text = ""
        txtestadolibro.Text = ""
        txtidubicacion.Text = ""
        txtubicacion.Text = ""
        txtdisponibles.Text = ""
        txtdescripcion.Text = ""
        txtpaginas.Text = ""
        txtideditorial.Text = ""
        txteditorial.Text = ""


        'codigo para limpiar imagen
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.file
        imagen.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub
    'creo el procedimiento mostrar
    Private Sub mostrar()
        Try
            'creo variable para instanciar a la clase cliente
            Dim func As New flibro
            'llamo al procedimiento mostrar
            dt = func.mostrar
            'oculto de datalistado la columna eliminar
            datalistado.Columns.Item("Eliminar").Visible = False
            'creo condicional para ver si tengo datos
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt 'relleno con lo que tenfa la variable dt
                txtbuscar.Enabled = True
                'visualizo la cabeceras del datalistado
                datalistado.ColumnHeadersVisible = True
                'oculto el laberl de inexistente
                inexistente.Visible = False
            Else 'si no hay datos
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False 'desavilito las columnas del data listado
                inexistente.Visible = True 'mustro el mensaje en datalistado

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        'en el formulario activo los botones que deseo que aparescan
        btnNuevo.Visible = True
        btnEditar.Visible = False

        'llamo al procedimiento buscar
        buscar() 'ESTA DENTRO DE LA FUNCION MOSTRAR

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"
    End Sub

    'creo el procedimiento buscar
    Private Sub buscar()
        Try
            'creamos una copia del datatable
            Dim ds As New DataSet
            'copia el valor a la variable ds
            ds.Tables.Add(dt.Copy)

            dv.Table = ds.Tables(0)
            'creo un filtro por todos lo campos elegidos en el combobox

            'condicional para ver que sean > 0
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                'llamo a procedimiento ocultar columnas
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'procedimiento ocultar columnas
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(4).Visible = False
        datalistado.Columns(6).Visible = False
        datalistado.Columns(8).Visible = False
        datalistado.Columns(9).Visible = False
        datalistado.Columns(10).Visible = False
        datalistado.Columns(12).Visible = False
        datalistado.Columns(13).Visible = False
        datalistado.Columns(14).Visible = False
        datalistado.Columns(16).Visible = False
        datalistado.Columns(17).Visible = False
        datalistado.Columns(18).Visible = False

    End Sub
    'validacion para las cajas de texto
    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el codigo del libro")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del libro")
        End If
    End Sub


    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la cantidad de libros")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'validar que las cajas de texto no esten vacias
        If Me.ValidateChildren = True And txtcodigo.Text <> "" And txtnombre.Text <> "" And txtfechalibro.Text <> "" And txtcantidad.Text <> "" And txtnombre_categoria.Text <> "" And txtnombre_autor.Text <> "" And txtestadolibro.Text <> "" And txtubicacion.Text <> "" And txtideditorial.Text <> "" And txteditorial.Text <> "" And txtpaginas.Text <> "" And txtdescripcion.Text <> "" Then
            Try
                Dim dts As New vlibro
                Dim func As New flibro

                dts.GCODIGO = txtcodigo.Text
                dts.GNOMBRE = txtnombre.Text
                dts.GFECHALIBRO = txtfechalibro.Text
                dts.GCANTIDAD = txtcantidad.Text
                dts.GIDCATEGORIA = txtidcategoria.Text
                dts.GIDAUTOR = txtidautor.Text
                dts.GIDESTADO = txtidestado.Text
                dts.GIDUBICACION = txtidubicacion.Text
                dts.GIDEDITORIAL = txtideditorial.Text
                dts.GDISPONIBLES = txtdisponibles.Text
                dts.GDESCRIPCION = txtdescripcion.Text
                dts.GPAGINAS = txtpaginas.Text


                'creo una variable de respaldo de memoria
                Dim ms As New IO.MemoryStream()

                'creo una condicional para verificar que la imagen no este vacia
                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.file
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If
                'envio parametros de memoria al picturebox
                dts.GIMAGEN = ms.GetBuffer

                'resivo parametros de funcion insertar
                If func.insertar(dts) Then
                    MessageBox.Show("Libro registrado correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("el Libro no fue registrado intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidlibro.Text = datalistado.SelectedCells.Item(1).Value
        txtcodigo.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre.Text = datalistado.SelectedCells.Item(3).Value
        txtfechalibro.Text = datalistado.SelectedCells.Item(4).Value
        txtcantidad.Text = datalistado.SelectedCells.Item(5).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(6).Value
        txtnombre_categoria.Text = datalistado.SelectedCells.Item(7).Value
        txtidautor.Text = datalistado.SelectedCells.Item(8).Value
        txtnombre_autor.Text = datalistado.SelectedCells.Item(9).Value
        txtidestado.Text = datalistado.SelectedCells.Item(10).Value
        txtestadolibro.Text = datalistado.SelectedCells.Item(11).Value
        txtidubicacion.Text = datalistado.SelectedCells.Item(12).Value
        txtubicacion.Text = datalistado.SelectedCells.Item(13).Value
        txtdisponibles.Text = datalistado.SelectedCells.Item(15).Value
        txtdescripcion.Text = datalistado.SelectedCells.Item(16).Value
        txtpaginas.Text = datalistado.SelectedCells.Item(17).Value
        txtideditorial.Text = datalistado.SelectedCells.Item(18).Value
        txteditorial.Text = datalistado.SelectedCells.Item(19).Value


        'para la imagen en datalistado
        Dim b() As Byte = datalistado.SelectedCells.Item(14).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        'muestro al boton editar y oculto al boton guardar
        btnEditar.Visible = True
        btnGuardar.Visible = False


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del Libro?", "Modificar Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'validar que las cajas de texto no esten vacias
            If Me.ValidateChildren = True And txtcodigo.Text <> "" And txtnombre.Text <> "" And txtfechalibro.Text <> "" And txtcantidad.Text <> "" And txtnombre_categoria.Text <> "" And txtnombre_autor.Text <> "" And txtestadolibro.Text <> "" And txtubicacion.Text <> "" And txtideditorial.Text <> "" And txteditorial.Text <> "" And txtpaginas.Text <> "" And txtdescripcion.Text <> "" Then
                Try
                    Dim dts As New vlibro
                    Dim func As New flibro

                    dts.GIDLIBRO = txtcodigo.Text
                    dts.GCODIGO = txtcodigo.Text
                    dts.GNOMBRE = txtnombre.Text
                    dts.GFECHALIBRO = txtfechalibro.Text
                    dts.GCANTIDAD = txtcantidad.Text
                    dts.GIDCATEGORIA = txtidcategoria.Text
                    dts.GIDAUTOR = txtidautor.Text
                    dts.GIDESTADO = txtidestado.Text
                    dts.GIDUBICACION = txtidubicacion.Text
                    dts.GIDEDITORIAL = txtideditorial.Text
                    dts.GDISPONIBLES = txtdisponibles.Text
                    dts.GDESCRIPCION = txtdescripcion.Text
                    dts.GPAGINAS = txtpaginas.Text


                    'creo una variable de respaldo de memoria
                    Dim ms As New IO.MemoryStream()

                    'creo una condicional para verificar que la imagen no este vacia
                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    Else
                        imagen.Image = My.Resources.file
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    End If
                    'envio parametros de memoria al picturebox
                    dts.GIMAGEN = ms.GetBuffer

                    'resivo parametros de funcion insertar
                    If func.editar(dts) Then
                        MessageBox.Show("Libro modificado correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("EL Libro no fue modificado intente de nuevo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea Eliminar los Libros seleccionados?", "Eliminar Libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDLIBRO").Value)
                        Dim vdb As New vlibro
                        Dim func As New flibro
                        vdb.GIDLIBRO = onekey

                        'llamo a la funcion eliminar
                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("el Libros no fue Eliminado", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next
                'llamamos al procedimiento mostrar
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando Eliminacion de Registros", "Cancelacion de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If
        'llamo al procedimiento limpiar para que limpie las cajas de texto
        Call limpiar()

    End Sub

    Private Sub btmcargar_Click(sender As Object, e As EventArgs) Handles btmcargar.Click
        'codigo para boton cargar imagen
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        'creo el boton limpiar debo cargar la imagen como lo tiene su nombre en resources
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.file
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        frmBuscarCategoria.bandera.Text = "1"
        frmBuscarCategoria.ShowDialog()

    End Sub

    Private Sub btnbuscarautor_Click(sender As Object, e As EventArgs) Handles btnbuscarautor.Click
        frmBuscarAutor.bandera.Text = "1"
        frmBuscarAutor.ShowDialog()

    End Sub

    Private Sub btnbuscarestado_Click(sender As Object, e As EventArgs) Handles btnbuscarestado.Click
        frmBuscarEstadoLibro.bandera.Text = "1"
        frmBuscarEstadoLibro.ShowDialog()
    End Sub

    Private Sub btnbuscarubicacion_Click(sender As Object, e As EventArgs) Handles btnbuscarubicacion.Click
        frmBuscarUbicacion.bandera.Text = "1"
        frmBuscarUbicacion.ShowDialog()
    End Sub

    Private Sub btnbuscareditorial_Click(sender As Object, e As EventArgs) Handles btnbuscareditorial.Click
        FrmBuscarEditorial.bandera.Text = "1"
        FrmBuscarEditorial.ShowDialog()
    End Sub
    'Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
    '    If txtflag.Text = "1" Then
    '        frmDetalle_Donacion.txtidlibro.Text = datalistado.SelectedCells.Item(1).Value
    '        frmDetalle_Donacion.txtnombre_libro.Text = datalistado.SelectedCells.Item(3).Value
    '        Me.Close()

    '    End If
    'End Sub



    'evento de mause para imagenes al pasar por encima
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnlimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnlimpiar.MouseHover
        ttmensaje.SetToolTip(btnlimpiar, "Cancelar Imagenes")
        ttmensaje.ToolTipTitle = "Limpiar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover
        ttmensaje.SetToolTip(btnEliminar, "Eliminar Libros")
        ttmensaje.ToolTipTitle = "Eliminar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        ttmensaje.SetToolTip(btnNuevo, "Nuevo Registro de Libro")
        ttmensaje.ToolTipTitle = "Nuevo"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGuardar_MouseHover(sender As Object, e As EventArgs) Handles btnGuardar.MouseHover
        ttmensaje.SetToolTip(btnGuardar, "Guarda Registro de Libro")
        ttmensaje.ToolTipTitle = "Guarda"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnCancelar_MouseHover(sender As Object, e As EventArgs) Handles btnCancelar.MouseHover
        ttmensaje.SetToolTip(btnCancelar, "Cancela Registro de Libro")
        ttmensaje.ToolTipTitle = "Cancelar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        ttmensaje.SetToolTip(btnEditar, "Edita Registro de Libro")
        ttmensaje.ToolTipTitle = "Editar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscarautor_MouseHover(sender As Object, e As EventArgs) Handles btnbuscarautor.MouseHover
        ttmensaje.SetToolTip(btnbuscarautor, "Busca Autores de Libros")
        ttmensaje.ToolTipTitle = "Buscar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscarcategoria_MouseHover(sender As Object, e As EventArgs) Handles btnbuscarcategoria.MouseHover
        ttmensaje.SetToolTip(btnbuscarcategoria, "Busca Categorias de Libros")
        ttmensaje.ToolTipTitle = "Buscar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscarestado_MouseHover(sender As Object, e As EventArgs) Handles btnbuscarestado.MouseHover
        ttmensaje.SetToolTip(btnbuscarestado, "Busca Estado de Libros")
        ttmensaje.ToolTipTitle = "Buscar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscarubicacion_MouseHover(sender As Object, e As EventArgs) Handles btnbuscarubicacion.MouseHover
        ttmensaje.SetToolTip(btnbuscarubicacion, "Busca Ubicación de Libros")
        ttmensaje.ToolTipTitle = "Buscar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_MouseHover_1(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ttmensaje.SetToolTip(PictureBox1, "Salir del Formulario")
        ttmensaje.ToolTipTitle = "Salir"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten Numeros", "Valor no Admitido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcantidad.Text = ""
            'Me.erroricono.SetError(sender, "Ingrese solo numeros")
        End If
    End Sub


End Class