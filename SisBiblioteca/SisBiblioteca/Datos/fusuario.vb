Imports System.Data.SqlClient
Public Class fusuario
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function validar_usuario(ByVal dts As vusuario)
        Try

            conectado()
            cmd = New SqlCommand("validar_usaurio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@USUARIO", dts.gusuario)
            cmd.Parameters.AddWithValue("@PASS", dts.gpass)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
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

    'llamo a los demas procedimientos almacenados
    Public Function mostrar() As DataTable
        Try                 'clase para la funcion mostrar
            conectado()
            cmd = New SqlCommand("mostrar_usuario") 'llamo al procedimiento almacenado en sql server
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

    Public Function insertar(ByVal dts As vusuario) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@CODIGO", dts.gcodigo)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.gnombre)
            cmd.Parameters.AddWithValue("@APELLIDO", dts.gapellido)
            cmd.Parameters.AddWithValue("@DPI", dts.gdpi)
            cmd.Parameters.AddWithValue("@USUARIO", dts.gusuario)
            cmd.Parameters.AddWithValue("@PASS", dts.gpass)
            cmd.Parameters.AddWithValue("@FECHA", dts.gfecha)
            cmd.Parameters.AddWithValue("@EMAIL", dts.gemail)
            cmd.Parameters.AddWithValue("@TELEFONO", dts.gtelefono)
            cmd.Parameters.AddWithValue("@TIPOUSUARIO", dts.gtipousuario)
            cmd.Parameters.AddWithValue("@ACCESO", dts.gacceso)
            cmd.Parameters.AddWithValue("@IMAGEN", dts.GIMAGEN)


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
    Public Function editar(ByVal dts As vusuario) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@IDUSUARIO", dts.gidusuario)
            cmd.Parameters.AddWithValue("@CODIGO", dts.gcodigo)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.gnombre)
            cmd.Parameters.AddWithValue("@APELLIDO", dts.gapellido)
            cmd.Parameters.AddWithValue("@DPI", dts.gdpi)
            cmd.Parameters.AddWithValue("@USUARIO", dts.gusuario)
            cmd.Parameters.AddWithValue("@PASS", dts.gpass)
            cmd.Parameters.AddWithValue("@FECHA", dts.gfecha)
            cmd.Parameters.AddWithValue("@EMAIL", dts.gemail)
            cmd.Parameters.AddWithValue("@TELEFONO", dts.gtelefono)
            cmd.Parameters.AddWithValue("@TIPOUSUARIO", dts.gtipousuario)
            cmd.Parameters.AddWithValue("@ACCESO", dts.gacceso)
            cmd.Parameters.AddWithValue("@IMAGEN", dts.GIMAGEN)


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
    Public Function eliminar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDUSUARIO", SqlDbType.NVarChar, 50).Value = dts.gidusuario
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
