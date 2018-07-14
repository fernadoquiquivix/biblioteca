Imports System.ComponentModel
Public Class frmPrestamo
    Private dt As New DataTable
    Public sp As login
    Private Sub frmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llamo a la funcion mostrar
        mostrar()
        'titulo a columnas
        'datalistado.Columns(3).HeaderText = "LIBRO"
        'datalistado.Columns(5).HeaderText = "USUARIO"
        'datalistado.Columns(8).HeaderText = "CLIENTE"
        'centrar datagri
        ' datalistado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        txtnombre_usuario.Text = My.Forms.login.txtUsuario.Text

    End Sub

    'creo un procedimiento para limpiar el formulario
    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtidusuario.Text = ""
        txtnombre_usuario.Text = ""
        txtfecha.Text = ""
        txtidcliente.Text = ""
        txtnombre_cliente.Text = ""

    End Sub
    'creo el procedimiento mostrar
    Private Sub mostrar()
        Try
            'creo variable para instanciar a la clase cliente
            Dim func As New fprestamo
            'llamo al procedimiento mostrar
            dt = func.mostrar
            'oculto de datalistado la columna eliminar
            datalistado.Columns.Item("Eliminar").Visible = False
            'creo condicional para ver si tengo datos
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt 'relleno con lo que tenfa la variable dt
                'txtbuscar.Enabled = True
                'visualizo la cabeceras del datalistado
                datalistado.ColumnHeadersVisible = True
                'oculto el laberl de inexistente
                inexistente.Visible = False
            Else 'si no hay datos
                datalistado.DataSource = Nothing
                'txtbuscar.Enabled = False
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
        'buscar() 'ESTA DENTRO DE LA FUNCION MOSTRAR

    End Sub

    'creo el procedimiento buscar
    'Private Sub buscar()
    '    Try
    '        'creamos una copia del datatable
    '        Dim ds As New DataSet
    '        'copia el valor a la variable ds
    '        ds.Tables.Add(dt.Copy)
    '        Dim dv As New DataView(ds.Tables(0))
    '        'creo un filtro por todos lo campos elegidos en el combobox
    '        dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"
    '        'condicional para ver que sean > 0
    '        If dv.Count <> 0 Then
    '            inexistente.Visible = False
    '            datalistado.DataSource = dv
    '            'llamo a procedimiento ocultar columnas
    '            ocultar_columnas()
    '        Else
    '            inexistente.Visible = True
    '            datalistado.DataSource = Nothing

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'procedimiento ocultar columnas
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(4).Visible = False
        datalistado.Columns(7).Visible = False

    End Sub
    'validacion para las cajas de texto


    Private Sub txtnombre_usuario_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Usuario")
        End If
    End Sub

    Private Sub txtnombre_cliente_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Cliente")
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        limpiar()
        mostrar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        txtidprestado.Text = datalistado.SelectedCells.Item(1).Value
        txtidusuario.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_usuario.Text = datalistado.SelectedCells.Item(3).Value
        txtidcliente.Text = datalistado.SelectedCells.Item(4).Value
        txtnombre_cliente.Text = datalistado.SelectedCells.Item(5).Value
        txtcantidad.Text = datalistado.SelectedCells.Item(6).Value
        txtfecha.Text = datalistado.SelectedCells.Item(7).Value



        'muestro al boton editar y oculto al boton guardar
        btnEditar.Visible = True
        btnGuardar.Visible = False


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs)
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea Eliminar el Prestamo seleccionado?", "Eliminar asignacion de Prestamo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("IDPRESTAMO").Value)
                        Dim vdb As New vprestamo
                        Dim func As New fprestamo
                        vdb.GIDPRESTADO = onekey

                        'llamo a la funcion eliminar
                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("el Prestamo no fue Eliminado", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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



    Private Sub txtfecha_DoubleClick(sender As Object, e As EventArgs) Handles txtfecha.DoubleClick
        txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btnbuscarcliente_Click_1(sender As Object, e As EventArgs) Handles btnbuscarcliente.Click
        frmcliente.txtflag.Text = "1"
        frmcliente.ShowDialog()

    End Sub

    Private Sub btnbuscarusuario_Click(sender As Object, e As EventArgs) Handles btnbuscarusuario.Click
        FrmUsuario.txtflag.Text = "1"
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub btnAgregarlibro_Click(sender As Object, e As EventArgs) Handles btnAgregarlibro.Click
        frmCargalibros.Show()

    End Sub

    Private Sub txtfecha_TextChanged(sender As Object, e As EventArgs) Handles txtfecha.TextChanged
        txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub


End Class