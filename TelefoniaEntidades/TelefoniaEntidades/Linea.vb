Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String
    Private _estadoActivo As Boolean = True
    Private _equipo As Equipo
    Private _cliente As List(Of Cliente)
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
            If _estadoActivo Then
                Return "Activo"
            Else
                Return "Suspendido"
            End If
        End Get
    End Property
    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Set(value As Equipo)
            _equipo = value
        End Set
    End Property
    '----------------------------------EN PROCESO DE DESARROLLO------------------------------------
    Public Sub New(codigoArea As UShort, numero As UInteger, equipo As Equipo, cliente As Cliente)
        _cliente = New List(Of Cliente)
        Me.codigoArea = codigoArea
        Me.Numero = numero
        Me.Equipo = equipo
        AddLinea(cliente)
    End Sub
    '-----------------------------------------------------------------------------------------------
    Public Sub Suspender()
        _estadoActivo = False
    End Sub
    Public Sub Reactivar()
        _estadoActivo = True
    End Sub
    Public Overrides Function ToString() As String
        Dim resultado As String = codigoArea & "-" & Numero
        If Not _estadoActivo Then
            resultado &= ":" & Estado
        End If
        Return resultado
    End Function
    '----------------WARNING----------------
    Private Sub AddLinea(cliente As Cliente)
        cliente.Linea = Me
        _cliente.Add(cliente)
    End Sub
    '---------------------------------------
End Class
