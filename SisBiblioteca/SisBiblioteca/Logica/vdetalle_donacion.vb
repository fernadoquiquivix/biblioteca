Public Class vdetalle_donacion
    Dim IDDETALLE_DONACION, IDDONACION, IDLIBRO, CANTIDAD As Integer
    Dim FECHA As Date

    Public Property GIDDETALLE_DONACION
        Get
            Return IDDETALLE_DONACION
        End Get
        Set(ByVal value)
            IDDETALLE_DONACION = value
        End Set
    End Property

    Public Property GIDDONACION
        Get
            Return IDDONACION
        End Get
        Set(ByVal value)
            IDDONACION = value
        End Set
    End Property


    Public Property GIDLIBRO
        Get
            Return IDLIBRO
        End Get
        Set(ByVal value)
            IDLIBRO = value
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

    Public Property GFECHA
        Get
            Return FECHA
        End Get
        Set(ByVal value)
            FECHA = value
        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(ByVal IDDETALLE_DONACION As Integer, ByVal IDDONACION As Integer, ByVal IDLIBRO As Integer, ByVal FECHA As Date, ByVal CANTIDAD As Integer)
        GIDDETALLE_DONACION = IDDETALLE_DONACION
        GIDDONACION = IDDONACION
        GIDLIBRO = IDLIBRO
        GFECHA = FECHA
        GCANTIDAD = CANTIDAD

    End Sub
End Class
