Public Class veditorial
    'atributos de la tabla autor
    Dim IDEDITORIAL As Integer
    Dim NOMBRE As String

    'seeter guarda un dato en cualquier objeto en memoria y getter lee lo que posee los atributos en memoria
    Public Property GIDEDITORIAL
        Get
            Return IDEDITORIAL
        End Get
        Set(value)
            IDEDITORIAL = value
        End Set
    End Property

    Public Property GNOMBRE
        Get
            Return NOMBRE
        End Get
        Set(value)
            NOMBRE = value
        End Set
    End Property

    'constructores son lo que se comunican con la carpeta datos
    'creamos un constructor en blanco
    Public Sub New()

    End Sub

    Public Sub New(ByVal IDEDITORIAL As Integer, ByVal NOMBRE As String)
        GIDEDITORIAL = IDEDITORIAL
        GNOMBRE = NOMBRE

    End Sub

End Class