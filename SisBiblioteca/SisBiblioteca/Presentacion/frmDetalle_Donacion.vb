Imports System.ComponentModel
Public Class frmDetalle_Donacion
    Private dt As New DataTable
    Dim dv As New DataView


    Private Sub frmDetalle_Donacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llamo a la funcion mostrar
        mostrar()
        'titulo a columnas
        datalistado.Columns(3).HeaderText = "DONADOR"
        datalistado.Columns(5).HeaderText = "LIBRO"
        'datalistado.Columns(9).HeaderText = "AUTOR"
        'datalistado.Columns(11).HeaderText = "ESTADO"
        'datalistado.Columns(13).HeaderText = "CLIENTE"
        'centrar datagri
        ' datalistado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'llamo al procedimiento contar
        contar()

    End Sub


    'creo un procedimiento para limpiar el formulario
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtiddetalle_donacion.Text = ""
        txtiddonacion.Text = ""
        txtdonador.Text = ""
        txtidlibro.Text = ""
        txtnombre_libro.Text = ""
        txtfechalibro.Text = ""
        txtcantidad.Text = ""

    End Sub
    'creo el procedimiento mostrar
    Private Sub mostrar()
        Try
            'creo variable para instanciar a la clase cliente
            Dim func As New fdetalle_donacion
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
        datalistado.Columns(2).Visible = False
        datalistado.Columns(4).Visible = False

    End Sub
    'validacion para las cajas de texto
    Private Sub txtdonador_Validating(sender As Object, e As CancelEventArgs) Handles txtdonador.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el donador")
        End If
    End Sub

    Private Sub txtnombre_libro_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre_libro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Libro")
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtcantidad.Text < 1 Then
            MessageBox.Show("Solo numeros mayores a 0?", "validar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Else
            'validar que las cajas de texto no esten vacias
            If Me.ValidateChildren = True And txtiddonacion.Text <> "" And txtdonador.Text <> "" And txtidlibro.Text <> "" And txtnombre_libro.Text <> "" And txtfechalibro.Text <> "" And txtcantidad.Text <> "" Then
                Try
                    Dim dts As New vdetalle_donacion
                    Dim func As New fdetalle_donacion

                    dts.GIDDONACION = txtiddonacion.Text
                    dts.GIDLIBRO = txtidlibro.Text
                    dts.GFECHA = txtfechalibro.Text
                    dts.GCANTIDAD = txtcantidad.Text



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
        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

        txtiddetalle_donacion.Text = datalistado.SelectedCells.Item(1).Value
        txtiddonacion.Text = datalistado.SelectedCells.Item(2).Value
        txtdonador.Text = datalistado.SelectedCells.Item(3).Value
        txtidlibro.Text = datalistado.SelectedCells.Item(4).Value
        txtnombre_libro.Text = datalistado.SelectedCells.Item(5).Value
        txtfechalibro.Text = datalistado.SelectedCells.Item(6).Value
        txtcantidad.Text = datalistado.SelectedCells.Item(7).Value

        'muestro al boton editar y oculto al boton guardar
        btnEditar.Visible = True
        btnGuardar.Visible = False


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        If txtcantidad.Text < 1 Then
            MessageBox.Show("Solo numeros mayores a 0?", "validar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Else

            result = MessageBox.Show("Realmente desea editar los datos del Libro?", "Modificar Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                'validar que las cajas de texto no esten vacias
                If Me.ValidateChildren = True And txtiddonacion.Text <> "" And txtdonador.Text <> "" And txtidlibro.Text <> "" And txtnombre_libro.Text <> "" And txtfechalibro.Text <> "" And txtiddetalle_donacion.Text <> "" And txtcantidad.Text <> "" Then
                    Try
                        Dim dts As New vdetalle_donacion
                        Dim func As New fdetalle_donacion

                        dts.GIDDETALLE_DONACION = txtiddetalle_donacion.Text
                        dts.GIDDONACION = txtiddonacion.Text
                        dts.GIDLIBRO = txtidlibro.Text
                        dts.GFECHA = txtfechalibro.Text
                        dts.GCANTIDAD = txtcantidad.Text


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

        result = MessageBox.Show("Realmente desea Eliminar los Libros seleccionados?", "Eliminar asignacion de libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDDETALLE_DONACION").Value)
                        Dim vdb As New vdetalle_donacion
                        Dim func As New fdetalle_donacion
                        vdb.GIDDETALLE_DONACION = onekey

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


    Private Sub btnbuscardonador_Click(sender As Object, e As EventArgs) Handles btnbuscardonador.Click
        frmBuscarDonador.bandera.Text = "1"
        frmBuscarDonador.ShowDialog()
    End Sub

    'Private Sub btnbuscarlibro_Click(sender As Object, e As EventArgs) Handles btnbuscarlibro.Click
    '    frmLibros.txtflag.Text = "1"
    '    frmLibros.ShowDialog()
    'End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub btnbuscarlibro_Click(sender As Object, e As EventArgs) Handles btnbuscarlibro.Click
        frmBuscarLibro.bandera.Text = "1"
        frmBuscarLibro.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    'procedimiento almacenado para contar valores de columna
    Private Sub contar()
        Dim linea As DataGridViewRow
        Dim valor As Integer

        For Each linea In datalistado.Rows
            valor = valor + linea.Cells(7).Value
        Next

        total.Text = valor

    End Sub


End Class