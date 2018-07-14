Public Class Vautor
    'atributos de la tabla autor
    Dim IDAUTOR As Integer
    Dim NOMBRE As String
    Dim DIRECCION As String
    Dim TELEFONO As String
    Dim EMAIL As String


    'seeter guarda un dato en cualquier objeto en memoria y getter lee lo que posee los atributos en memoria
    Public Property GIDAUTOR
        Get
            Return IDAUTOR
        End Get
        Set(value)
            IDAUTOR = value
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

    Public Property GDIRECCON
        Get
            Return DIRECCION
        End Get
        Set(value)
            DIRECCION = value
        End Set
    End Property

    Public Property GTELEFONO
        Get
            Return TELEFONO
        End Get
        Set(value)
            TELEFONO = value
        End Set
    End Property

    Public Property GEMAIL
        Get
            Return EMAIL
        End Get
        Set(value)
            EMAIL = value
        End Set
    End Property

    'constructores son lo que se comunican con la carpeta datos
    'creamos un constructor en blanco
    Public Sub New()

    End Sub

    Public Sub New(ByVal IDAUTOR As Integer, ByVal NOMBRES As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal EMAIL As String)
        GIDAUTOR = IDAUTOR
        GNOMBRE = NOMBRE
        GDIRECCON = DIRECCION
        GTELEFONO = TELEFONO
        GEMAIL = EMAIL

    End Sub

End Class
