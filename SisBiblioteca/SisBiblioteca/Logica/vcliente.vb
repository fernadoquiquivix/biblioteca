Public Class vcliente
    'atributos de la tabla autor
    Dim IDCLIENTE As Integer
    Dim NOMBRE, APELLIDO As String
    Dim DIRECCION As String
    Dim TELEFONO, IDENTIFICACION, CARGO, SEXO As String
    Dim FECHA As Date
    Dim IMAGEN() As Byte




    'seeter guarda un dato en cualquier objeto en memoria y getter lee lo que posee los atributos en memoria
    Public Property GIDCLIENTE
        Get
            Return IDCLIENTE
        End Get
        Set(value)
            IDCLIENTE = value
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

    Public Property GAPELLIDO
        Get
            Return APELLIDO
        End Get
        Set(value)
            APELLIDO = value
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

    Public Property GIDENTIFICACION
        Get
            Return IDENTIFICACION
        End Get
        Set(value)
            IDENTIFICACION = value
        End Set
    End Property

    Public Property GCARGO
        Get
            Return CARGO
        End Get
        Set(value)
            CARGO = value
        End Set
    End Property

    Public Property GIMAGEN
        Get
            Return IMAGEN
        End Get
        Set(value)
            IMAGEN = value
        End Set
    End Property

    Public Property GSEXO
        Get
            Return SEXO
        End Get
        Set(value)
            SEXO = value
        End Set
    End Property

    Public Property GFECHA
        Get
            Return FECHA
        End Get
        Set(value)
            FECHA = value
        End Set
    End Property

    'constructores son lo que se comunican con la carpeta datos
    'creamos un constructor en blanco
    Public Sub New()

    End Sub

    Public Sub New(ByVal IDCLIENTE As Integer, ByVal NOMBRES As String, ByVal APELLIDO As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal IDENTIFICACION As String, ByVal CARGO As String, ByVal IMAGEN() As Byte, ByVal SEXO As String, ByVal FECHA As Date)
        GIDCLIENTE = IDCLIENTE
        GNOMBRE = NOMBRE
        GAPELLIDO = APELLIDO
        GDIRECCON = DIRECCION
        GTELEFONO = TELEFONO
        GIDENTIFICACION = IDENTIFICACION
        GCARGO = CARGO
        GIMAGEN = IMAGEN
        GSEXO = SEXO
        GFECHA = FECHA

    End Sub
End Class
