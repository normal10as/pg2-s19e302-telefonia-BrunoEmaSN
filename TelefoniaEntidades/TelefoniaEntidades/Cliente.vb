Public Class Cliente
    Private _cuenta As UInteger
    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property
    Public Sub New()
        Cuenta = 11111
    End Sub
End Class
