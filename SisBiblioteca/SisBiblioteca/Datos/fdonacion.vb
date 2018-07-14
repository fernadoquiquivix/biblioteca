Imports System.Data.SqlClient
Public Class fdonacion
    Inherits Conexion
    Dim cmd As New SqlCommand


    'llamo a los demas procedimientos almacenados
    Public Function mostrar() As DataTable
        Try                 'clase para la funcion mostrar
            conectado()
            cmd = New SqlCommand("mostrar_donacion") 'llamo al procedimiento almacenado en sql server
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

    Public Function insertar(ByVal dts As vdonacion) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("insertar_donacion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@NOMBRE", dts.GNOMBRE)
            cmd.Parameters.AddWithValue("@DIRECCION", dts.GDIRECCON)
            cmd.Parameters.AddWithValue("@EMAIL", dts.GEMAIL)
            cmd.Parameters.AddWithValue("@TELEFONO", dts.GTELEFONO)

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
    Public Function editar(ByVal dts As vdonacion) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("editar_donacion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@IDDONACION", dts.GIDDONACION)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.GNOMBRE)
            cmd.Parameters.AddWithValue("@DIRECCION", dts.GDIRECCON)
            cmd.Parameters.AddWithValue("@EMAIL", dts.GEMAIL)
            cmd.Parameters.AddWithValue("@TELEFONO", dts.GTELEFONO)


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
    Public Function eliminar(ByVal dts As vdonacion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_donacion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDDONACION", SqlDbType.NVarChar, 50).Value = dts.GIDDONACION
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
