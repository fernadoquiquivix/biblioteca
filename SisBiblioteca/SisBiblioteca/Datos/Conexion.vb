Imports System.Data.SqlClient
Public Class Conexion
    Protected cnn As New SqlConnection

    Public IDUSUARIO As Integer

    Protected Function conectado()

        Try
            cnn = New SqlConnection("Data Source=STECINFOS;Initial Catalog=biblioteca;Integrated Security=True") 'servidor base de datos sqlserver 2014
            'cnn = New SqlConnection("Data Source = 192.168.1.20,1433; Initial Catalog = biblioteca; user Id=pucho; password=1234;")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
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
