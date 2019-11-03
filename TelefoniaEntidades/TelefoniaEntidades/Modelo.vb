Public Class Modelo
    Private _nombre As String
    Protected _marca As Marca
    Public Overloads Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length < 50 And value.Length > 0 Then
                _nombre = value
            End If
        End Set
    End Property
    Public Property Marca As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property
    Public Sub New(nombre As String, marca As Marca)
        Me.Nombre = nombre
        Me.Marca = marca
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

End Class
