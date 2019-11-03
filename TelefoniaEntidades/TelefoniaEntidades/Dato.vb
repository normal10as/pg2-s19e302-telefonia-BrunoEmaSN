Public Class Dato
    Inherits Servicio
    Public Sub New(precio As Decimal, credito As UInteger)
        MyBase.Precio = precio
        MyBase.Credito = credito
    End Sub
    Public Overrides Function ToString() As String
        Return Credito & " Mbytes"
    End Function
End Class
