Public Class Linea
    Inherits Equipo
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String
    Private _estado2 As String
    Private _equipo As Equipo
    Public Property codigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value <= 9999 And value >= 100 Then
                _codigoArea = value
            End If
        End Set
    End Property
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value <= 9999999 And value >= 100000 Then
                _numero = value
            End If
        End Set
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return _estado2
        End Get
    End Property
    Public Sub New(codigoArea As UShort, numero As UInteger, equipo As Equipo)
        MyBase.New(equipo.Nombre, equipo.Serie)
        Me.codigoArea = codigoArea
        Me.Numero = numero
    End Sub
    Public Sub Suspender()
        _estado2 = "Suspendido"
    End Sub
    Public Sub Reactivar()
        _estado2 = "Activo"
    End Sub
    Public Overrides Function ToString() As String
        If Estado = "Suspendido" Then
            Return codigoArea & "-" & Numero & ":" & Estado
        Else
            Return codigoArea & "-" & Numero
        End If
    End Function

End Class
