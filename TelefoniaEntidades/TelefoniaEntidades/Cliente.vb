Public MustInherit Class Cliente
    Private _cuenta As UInteger
    Private _linea As Linea
    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property
    Public Property Linea As Linea
        Friend Set(value As Linea)
            _linea = value
        End Set
        Get
            Return _linea
        End Get
    End Property
    Public Sub New()
        Cuenta = 11111
    End Sub
End Class
