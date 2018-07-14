Public Class vcategoria
    'atributos de la tabla autor
    Dim IDCATEGORIA As Integer
    Dim NOMBRE As String

    'seeter guarda un dato en cualquier objeto en memoria y getter lee lo que posee los atributos en memoria
    Public Property GIDCATEGORIA
        Get
            Return IDCATEGORIA
        End Get
        Set(value)
            IDCATEGORIA = value
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

    Public Sub New(ByVal IDCATEGORIA As Integer, ByVal NOMBRE As String)
        GIDCATEGORIA = IDCATEGORIA
        GNOMBRE = NOMBRE

    End Sub

End Class
