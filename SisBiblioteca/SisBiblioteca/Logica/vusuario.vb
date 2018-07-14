Public Class vusuario
    Dim IDUSUARIO As Integer
    Dim CODIGO, NOMBRE, APELIIDO, DPI, USUARIO, PASS, EMAIL, TELEFONO, TIPOUSUARIO, ACCESO As String
    Dim FECHA As Date
    Dim IMAGEN() As Byte
    Public Property gidusuario
        Get
            Return IDUSUARIO
        End Get
        Set(value)
            IDUSUARIO = value
        End Set
    End Property

    Public Property gcodigo
        Get
            Return CODIGO
        End Get
        Set(value)
            CODIGO = value
        End Set
    End Property
    Public Property gnombre
        Get
            Return NOMBRE
        End Get
        Set(value)
            NOMBRE = value
        End Set
    End Property

    Public Property gapellido
        Get
            Return APELIIDO
        End Get
        Set(value)
            APELIIDO = value
        End Set
    End Property
    Public Property gdpi
        Get
            Return DPI
        End Get
        Set(value)
            DPI = value
        End Set
    End Property

    Public Property gusuario
        Get
            Return USUARIO
        End Get
        Set(value)
            USUARIO = value
        End Set
    End Property

    Public Property gpass
        Get
            Return PASS
        End Get
        Set(value)
            PASS = value
        End Set
    End Property

    Public Property gfecha
        Get
            Return FECHA
        End Get
        Set(value)
            FECHA = value
        End Set
    End Property

    Public Property gemail
        Get
            Return EMAIL
        End Get
        Set(value)
            EMAIL = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return TELEFONO
        End Get
        Set(value)
            TELEFONO = value
        End Set
    End Property
    Public Property gtipousuario
        Get
            Return TIPOUSUARIO
        End Get
        Set(value)
            TIPOUSUARIO = value
        End Set
    End Property

    Public Property gacceso
        Get
            Return ACCESO
        End Get
        Set(value)
            ACCESO = value
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

    Public Sub New()

    End Sub

    'constructos que recibe
    Public Sub New(ByVal IDUSUARIO As Integer, ByVal CODIGO As String, ByVal NOMBRE As String, ByVal APELLIDO As String, ByVal DPI As String, ByVal USUARIO As String, ByVal PASS As String, ByVal FECHA As Date, ByVal EMAIL As String, ByVal TELEFONO As String, ByVal TIPOUSUARIO As String, ByVal ACCESO As String, ByVal IMAGEN() As Byte)
        gidusuario = IDUSUARIO
        gcodigo = CODIGO
        gnombre = NOMBRE
        gapellido = APELIIDO
        gdpi = DPI
        gusuario = USUARIO
        gpass = PASS
        gfecha = FECHA
        gemail = EMAIL
        gtelefono = TELEFONO
        gtipousuario = TIPOUSUARIO
        gacceso = ACCESO
        GIMAGEN = IMAGEN

    End Sub

End Class

