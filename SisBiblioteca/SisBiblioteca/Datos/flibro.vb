Imports System.Data.SqlClient
Public Class flibro
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try                 'clase para la funcion mostrar
            conectado()
            cmd = New SqlCommand("mostrar_libro") 'llamo al procedimiento almacenado en sql server
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

    Public Function insertar(ByVal dts As vlibro) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("insertar_libro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@CODIGO", dts.GCODIGO)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.GNOMBRE)
            cmd.Parameters.AddWithValue("@FECHALIBRO", dts.GFECHALIBRO)
            cmd.Parameters.AddWithValue("@CANTIDAD", dts.GCANTIDAD)
            cmd.Parameters.AddWithValue("@IDCATEGORIA", dts.GIDCATEGORIA)
            cmd.Parameters.AddWithValue("@IDAUTOR", dts.GIDAUTOR)
            cmd.Parameters.AddWithValue("@IDESTADO", dts.GIDESTADO)
            cmd.Parameters.AddWithValue("@IDUBICACION", dts.GIDUBICACION)
            cmd.Parameters.AddWithValue("@IMAGEN", dts.GIMAGEN)
            cmd.Parameters.AddWithValue("@DISPONIBLES", dts.GDISPONIBLES)
            cmd.Parameters.AddWithValue("@DESCRIPCION", dts.GDESCRIPCION)
            cmd.Parameters.AddWithValue("@PAGINAS", dts.GPAGINAS)
            cmd.Parameters.AddWithValue("@IDEDITORIAL", dts.GPAGINAS)

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
    Public Function editar(ByVal dts As vlibro) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("editar_libro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            'envio paramentros
            cmd.Parameters.AddWithValue("@IDLIBRO", dts.GIDLIBRO)
            cmd.Parameters.AddWithValue("@CODIGO", dts.GCODIGO)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.GNOMBRE)
            cmd.Parameters.AddWithValue("@FECHALIBRO", dts.GFECHALIBRO)
            cmd.Parameters.AddWithValue("@CANTIDAD", dts.GCANTIDAD)
            cmd.Parameters.AddWithValue("@IDCATEGORIA", dts.GIDCATEGORIA)
            cmd.Parameters.AddWithValue("@IDAUTOR", dts.GIDAUTOR)
            cmd.Parameters.AddWithValue("@IDESTADO", dts.GIDESTADO)
            cmd.Parameters.AddWithValue("@IDUBICACION", dts.GIDUBICACION)
            cmd.Parameters.AddWithValue("@IMAGEN", dts.GIMAGEN)
            cmd.Parameters.AddWithValue("@DISPONIBLES", dts.GDISPONIBLES)
            cmd.Parameters.AddWithValue("@DESCRIPCION", dts.GDESCRIPCION)
            cmd.Parameters.AddWithValue("@PAGINAS", dts.GPAGINAS)
            cmd.Parameters.AddWithValue("@IDEDITORIAL", dts.GPAGINAS)

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
    Public Function eliminar(ByVal dts As vlibro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_libro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDLIBRO", SqlDbType.NVarChar, 50).Value = dts.GIDLIBRO
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
