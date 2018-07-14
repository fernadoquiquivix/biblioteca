Imports System.ComponentModel
Public Class frmBuscarAutor
    Private dt As New DataTable
    Dim dv As New DataView
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmBuscarAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        datalistado.Columns(5).HeaderText = "CORREO"
    End Sub

    Private Sub mostrar()
        Try
            'creo variable para instanciar a la clase cliente
            Dim func As New Fautor
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

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAutor.Show()

    End Sub


    'Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
    '    FrmAutor.txtidautor.Text = datalistado.CurrentRow.Cells(1).Value.ToString
    '    FrmAutor.txtnombre.Text = datalistado.CurrentRow.Cells(2).Value.ToString
    '    Me.Close()

    'End Sub


    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If bandera.Text = "1" Then
            frmLibros.txtidautor.Text = datalistado.SelectedCells.Item(1).Value
            frmLibros.txtnombre_autor.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar()
    End Sub
End Class