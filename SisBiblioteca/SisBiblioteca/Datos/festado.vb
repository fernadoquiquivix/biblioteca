Imports System.Data.SqlClient
Public Class festado
    Inherits Conexion
    Dim cmd As New SqlCommand

    'llamo a los demas procedimientos almacenados
    Public Function mostrar() As DataTable
        Try                 'clase para la funcion mostrar
            conectado()
            cmd = New SqlCommand("mostra_estado") 'llamo al procedimiento almacenado en sql server
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

    Public Function insertar(ByVal dts As vestado) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("insertar_estado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@NOMBRE", dts.GNOMBRE)


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
    Public Function editar(ByVal dts As vestado) As Boolean
        Try
            'envio parametros a la base de datos
            conectado()
            cmd = New SqlCommand("editar_estado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'envio paramentros
            cmd.Parameters.AddWithValue("@IDESTADO", dts.GIDESTADO)



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
    Public Function eliminar(ByVal dts As vestado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_estado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@IDESTADO", SqlDbType.NVarChar, 50).Value = dts.GIDESTADO
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
