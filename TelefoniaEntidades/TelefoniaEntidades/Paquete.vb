Imports TelefoniaEntidades

Public Class Paquete
    Implements Plan
    Private _nombre As String
    Private _precio As Decimal
    Private _servicio As List(Of Servicio)
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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

    Public Sub addServicio(servicio As Servicio)
        _servicio.Add(servicio)
    End Sub
    Public Sub removeServicio(servicio As Servicio)
        _servicio.Remove(servicio)
    End Sub
    Public Function getAllServicio() As List(Of Servicio)
        Return _servicio
    End Function
    '---------------------------EN PROCESO DE DESARROLLO-----------------------------------
    Public Function getDisponibleToString() As String Implements Plan.getDisponibleToString
        Return ""
    End Function

    Public Function getConsumoToString() As String Implements Plan.getConsumoToString
        Return ""
    End Function
    '--------------------------------------------------------------------------------------
End Class
