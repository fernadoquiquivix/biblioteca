Imports System.ComponentModel
Public Class frmDonacion
    Private dt As New DataTable
    Dim dv As New DataView
    Private Sub frmDonacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    'creo un procedimiento para limpiar el formulario
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txtemail.Text = ""
        txttelefono.Text = ""
        txtiddonador.Text = ""
    End Sub
    'creo el procedimiento mostrar
    Private Sub mostrar()
        Try
            'creo variable para instanciar a la clase cliente
            Dim func As New fdonacion
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
    End Sub

    'validar campos de usuario
    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del Donador")
        End If
    End Sub


    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion del Donador")
        End If
    End Sub


    Private Sub txttelefono_Validating(sender As Object, e As CancelEventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el telefono del Donador")
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'validar que las cajas de texto no esten vacias
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdireccion.Text <> "" And txtemail.Text <> "" And txttelefono.Text <> "" Then
            Try
                Dim dts As New vdonacion
                Dim func As New fdonacion

                dts.GNOMBRE = txtnombre.Text
                dts.GDIRECCON = txtdireccion.Text
                dts.GTELEFONO = txttelefono.Text
                dts.GEMAIL = txtemail.Text


                'resivo parametros de funcion insertar
                If func.insertar(dts) Then
                    MessageBox.Show("Donador registrado correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Donador no registrado intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtiddonador.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(3).Value
        txttelefono.Text = datalistado.SelectedCells.Item(4).Value
        txtemail.Text = datalistado.SelectedCells.Item(5).Value

        'muestro al boton editar y oculto al boton guardar
        btnEditar.Visible = True
        btnGuardar.Visible = False


    End Sub

    'editar usuario
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de las donaciones?", "Modificar Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            'validar que las cajas de texto no esten vacias
            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdireccion.Text <> "" And txtemail.Text <> "" And txttelefono.Text <> "" Then
                Try
                    Dim dts As New vdonacion
                    Dim func As New fdonacion

                    dts.GIDDONACION = txtiddonador.Text
                    dts.GNOMBRE = txtnombre.Text
                    dts.GDIRECCON = txtdireccion.Text
                    dts.GTELEFONO = txttelefono.Text
                    dts.GEMAIL = txtemail.Text

                    'resivo parametros de funcion insertar
                    If func.editar(dts) Then
                        MessageBox.Show("Donador modificado correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Donador no fue modificado intente de nuevo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        result = MessageBox.Show("Realmente desea Eliminar a los Donadores seleccionados?", "Eliminar Donadores", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDDONACION").Value)
                        Dim vdb As New vdonacion
                        Dim func As New fdonacion
                        vdb.GIDDONACION = onekey

                        'llamo a la funcion eliminar
                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Donador no Eliminado", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            frmDetalle_Donacion.txtiddonacion.Text = datalistado.SelectedCells.Item(1).Value
            frmDetalle_Donacion.txtdonador.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ttmensaje.SetToolTip(PictureBox1, "Salir del Formulario")
        ttmensaje.ToolTipTitle = "Salir"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover
        ttmensaje.SetToolTip(btnEliminar, "Eliminar registro de Autor")
        ttmensaje.ToolTipTitle = "Eliminar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        ttmensaje.SetToolTip(btnNuevo, "Nuevo registro de Autor")
        ttmensaje.ToolTipTitle = "Nuevo"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGuardar_MouseHover(sender As Object, e As EventArgs) Handles btnGuardar.MouseHover
        ttmensaje.SetToolTip(btnGuardar, "Guarda registro de Autor")
        ttmensaje.ToolTipTitle = "Guardar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnCancelar_MouseHover(sender As Object, e As EventArgs) Handles btnCancelar.MouseHover
        ttmensaje.SetToolTip(btnCancelar, "Cancela registro de Autor")
        ttmensaje.ToolTipTitle = "Cancelar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        ttmensaje.SetToolTip(btnEditar, "Edita registro de Autor")
        ttmensaje.ToolTipTitle = "Editar"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten Numeros", "Valor no Admitido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txttelefono.Text = ""
            'Me.erroricono.SetError(sender, "Ingrese solo numeros")
        End If
    End Sub
End Class