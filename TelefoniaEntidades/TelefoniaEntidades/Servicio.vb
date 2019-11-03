Imports TelefoniaEntidades

Public MustInherit Class Servicio
    Implements Plan
    Private _credito As UInteger
    Private _valor As UInteger
    Private _precio
    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property

    Public Property Precio As Decimal Implements Plan.Precio
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Sub NuevoConsumo(valor As UInteger)
        _valor = valor
    End Sub
    Public Function getDisponible() As UInteger
        Return Credito - _valor
    End Function

    Public Function getDisponibleToString() As String Implements Plan.getDisponibleToString
        Return getDisponible() & " de "
    End Function

    Public Function getConsumoToString() As String Implements Plan.getConsumoToString
        Return _valor
    End Function
End Class
