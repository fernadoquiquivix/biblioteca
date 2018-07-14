Public Class vubicacion
    'atributos de la tabla autor
    Dim IDUBICACION As Integer
    Dim NOMBRE_ESTANTERIA As String
    Dim NUMERO_FILA As Integer



    'seeter guarda un dato en cualquier objeto en memoria y getter lee lo que posee los atributos en memoria
    Public Property GIDUBICACION
        Get
            Return IDUBICACION
        End Get
        Set(value)
            IDUBICACION = value
        End Set
    End Property

    Public Property GNOMBRE_ESTANTERIA
        Get
            Return NOMBRE_ESTANTERIA
        End Get
        Set(value)
            NOMBRE_ESTANTERIA = value
        End Set
    End Property

    Public Property GNUMERO_FILA
        Get
            Return NUMERO_FILA
        End Get
        Set(value)
            NUMERO_FILA = value
        End Set
    End Property


    'constructores son lo que se comunican con la carpeta datos
    'creamos un constructor en blanco
    Public Sub New()

    End Sub

    Public Sub New(ByVal IDUBICACION As Integer, ByVal NOMBRE_ESTANTERIA As String, ByVal NUMERO_FILA As Integer)
        GIDUBICACION = IDUBICACION
        GNOMBRE_ESTANTERIA = NOMBRE_ESTANTERIA
        GNUMERO_FILA = NUMERO_FILA

    End Sub


End Class
