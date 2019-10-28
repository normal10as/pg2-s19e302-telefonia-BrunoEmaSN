﻿Public Class Equipo
    Inherits Modelo
    Private _serie As String
    Private _fechaVenta2 As Date
    Private _fechaVenta As Date
    Private _modelo As Modelo
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length < 15 And value.Length > 0 Then
                _serie = value
            End If
        End Set
    End Property
    Public ReadOnly Property fechaVenta
        Get
            Return _fechaVenta2
        End Get
    End Property
    Public Sub vender(fecha As Date)
        _fechaVenta2 = fecha
    End Sub
    Public Sub New(modelo As Modelo, serie As String)
        MyBase.New(modelo.Nombre, modelo.)
        Me.Serie = serie
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
