﻿Public Class Empresa
    Inherits Cliente
    Private _razonSocial As String
    Private _cuit As String
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            _razonSocial = value
        End Set
    End Property
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            _cuit = value
        End Set
    End Property
    Public Sub New(razonSocial As String, cuit As String)
        MyBase.New()
        Me.RazonSocial = razonSocial
        Me.Cuit = cuit
    End Sub
    Public Overrides Function ToString() As String
        Return RazonSocial & " " & Cuenta
    End Function
End Class
