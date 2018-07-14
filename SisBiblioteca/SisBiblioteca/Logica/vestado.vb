Public Class vestado
    'atributos de la tabla autor
    Dim IDESTADO As Integer
    Dim NOMBRE As String


    'seeter guarda un dato en cualquier objeto en memoria y getter lee lo que posee los atributos en memoria
    Public Property GIDESTADO
        Get
            Return IDESTADO
        End Get
        Set(value)
            IDESTADO = value
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

    Public Sub New(ByVal IDESTADO As Integer, ByVal NOMBRE As String)
        GIDESTADO = IDESTADO
        GNOMBRE = NOMBRE

    End Sub


End Class
