Imports System.Data.SqlClient
Public Class fcliente
    Inherits Conexion
    Dim cmd As New SqlCommand


    'llamo a los demas procedimientos almacenados
    Public Function mostrar() As DataTable
        Try                 'clase para la funcion mostrar
            conectado()
            cmd = New SqlCommand("mostrar_cliente") 'llamo al procedimiento almacenado en sql server
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try

    End Function

    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@NOMBRE", dts.GNOMBRE)
            cmd.Parameters.AddWithValue("@APELLIDO", dts.GAPELLIDO)
            cmd.Parameters.AddWithValue("@DIRECCION", dts.GDIRECCON)
            cmd.Parameters.AddWithValue("@TELEFONO", dts.GTELEFONO)
            cmd.Parameters.AddWithValue("@IDENTIFICACION", dts.GIDENTIFICACION)
            cmd.Parameters.AddWithValue("@CARGO", dts.GCARGO)
            cmd.Parameters.AddWithValue("@IMAGEN", dts.GIMAGEN)
            cmd.Parameters.AddWithValue("@SEXO", dts.GSEXO)
            cmd.Parameters.AddWithValue("@FECHA", dts.GFECHA)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function

    'creo funcion editar
    Public Function editar(ByVal dts As vcliente) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@IDCLIENTE", dts.GIDCLIENTE)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.GNOMBRE)
            cmd.Parameters.AddWithValue("@APELLIDO", dts.GAPELLIDO)
            cmd.Parameters.AddWithValue("@DIRECCION", dts.GDIRECCON)
            cmd.Parameters.AddWithValue("@TELEFONO", dts.GTELEFONO)
            cmd.Parameters.AddWithValue("@IDENTIFICACION", dts.GIDENTIFICACION)
            cmd.Parameters.AddWithValue("@CARGO", dts.GCARGO)
            cmd.Parameters.AddWithValue("@IMAGEN", dts.GIMAGEN)
            cmd.Parameters.AddWithValue("@SEXO", dts.GSEXO)
            cmd.Parameters.AddWithValue("@FECHA", dts.GFECHA)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function

    'creo la funcion eliminar para llamar al procedimiento almacenado
    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDCLIENTE", SqlDbType.NVarChar, 50).Value = dts.GIDCLIENTE
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function



End Class
