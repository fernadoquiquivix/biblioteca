Public Class vprestamo
    Dim IDPRESTADO, IDUSUARIO, IDCLIENTE As Integer
    Dim CANTIDAD As Integer
    Dim FECHA As Date

    Public Property GIDPRESTADO
        Get
            Return IDPRESTADO
        End Get
        Set(ByVal value)
            IDPRESTADO = value
        End Set
    End Property

    Public Property GIDUSUARIO
        Get
            Return IDUSUARIO
        End Get
        Set(ByVal value)
            IDUSUARIO = value
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

    Public Property GIDCLIENTE
        Get
            Return IDCLIENTE
        End Get
        Set(ByVal value)
            IDCLIENTE = value
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


    Public Sub New()

    End Sub

    Public Sub New(ByVal IDPRESTADO As Integer, ByVal IDUSUARIO As Integer, ByVal FECHA As Date, ByVal IDCLIENTE As Integer, ByVal CANTIDAD As Integer)
        GIDPRESTADO = IDPRESTADO
        GIDUSUARIO = IDUSUARIO
        GIDCLIENTE = IDCLIENTE
        GCANTIDAD = CANTIDAD
        GFECHA = FECHA

    End Sub
End Class
