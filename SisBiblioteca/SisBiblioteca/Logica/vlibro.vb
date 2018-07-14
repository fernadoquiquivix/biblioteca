Public Class vlibro
    Dim IDLIBRO, IDCATEGORIA, IDAUTOR, IDESTADO, IDUBICACION, IDEDITORIAL As Integer
    Dim FECHALIBRO As Date
    Dim CANTIDAD, PAGINAS, DISPONIBLES As Integer
    Dim CODIGO, NOMBRE, DESCRIPCION As String
    Dim IMAGEN() As Byte

    Public Property GIDLIBRO
        Get
            Return IDLIBRO
        End Get
        Set(ByVal value)
            IDLIBRO = value
        End Set
    End Property

    Public Property GIDCATEGORIA
        Get
            Return IDCATEGORIA
        End Get
        Set(ByVal value)
            IDCATEGORIA = value
        End Set
    End Property

    Public Property GIDAUTOR
        Get
            Return IDAUTOR
        End Get
        Set(ByVal value)
            IDAUTOR = value
        End Set
    End Property

    Public Property GIDESTADO
        Get
            Return IDESTADO
        End Get
        Set(ByVal value)
            IDESTADO = value
        End Set
    End Property

    Public Property GIDUBICACION
        Get
            Return IDUBICACION
        End Get
        Set(ByVal value)
            IDUBICACION = value
        End Set
    End Property

    Public Property GFECHALIBRO
        Get
            Return FECHALIBRO
        End Get
        Set(ByVal value)
            FECHALIBRO = value
        End Set
    End Property
    Public Property GCANTIDAD
        Get
            Return CANTIDAD
        End Get
        Set(ByVal value)
            CANTIDAD = value
        End Set
    End Property

    Public Property GCODIGO
        Get
            Return CODIGO
        End Get
        Set(ByVal value)
            CODIGO = value
        End Set
    End Property

    Public Property GNOMBRE
        Get
            Return NOMBRE
        End Get
        Set(ByVal value)
            NOMBRE = value
        End Set
    End Property

    Public Property GIMAGEN
        Get
            Return IMAGEN
        End Get
        Set(ByVal value)
            IMAGEN = value
        End Set
    End Property

    Public Property GDISPONIBLES
        Get
            Return DISPONIBLES
        End Get
        Set(ByVal value)
            DISPONIBLES = value
        End Set
    End Property

    Public Property GDESCRIPCION
        Get
            Return DESCRIPCION
        End Get
        Set(ByVal value)
            DESCRIPCION = value
        End Set
    End Property

    Public Property GPAGINAS
        Get
            Return PAGINAS
        End Get
        Set(ByVal value)
            PAGINAS = value
        End Set
    End Property

    Public Property GIDEDITORIAL
        Get
            Return IDEDITORIAL
        End Get
        Set(ByVal value)
           IDEDITORIAL= value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal IDLIBRO As Integer, ByVal IDCATEGORIA As Integer, ByVal IDAUTOR As Integer, ByVal IDESTADO As Integer, ByVal IDUBICACION As Integer, ByVal CODIGO As String, ByVal NOMBRE As String, ByVal FECHALIBRO As Date, ByVal CANTIDAD As Integer, ByVal IMAGEN() As Byte, ByVal DISPONIBLES As Integer, ByVal DESCRIPCION As String, ByVal PAGINAS As Integer, ByVal IDEDITORIAL As Integer)
        GIDLIBRO = IDLIBRO
        GCODIGO = CODIGO
        GNOMBRE = NOMBRE
        GFECHALIBRO = FECHALIBRO
        GCANTIDAD = CANTIDAD
        GIDCATEGORIA = IDCATEGORIA
        GIDAUTOR = IDAUTOR
        IDESTADO = IDESTADO
        GIDUBICACION = IDUBICACION
        GIMAGEN = IMAGEN
        GDISPONIBLES = DISPONIBLES
        GDESCRIPCION = DESCRIPCION
        GPAGINAS = PAGINAS
        GIDEDITORIAL = IDEDITORIAL

    End Sub
End Class
