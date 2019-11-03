Imports TelefoniaEntidades
Module VozTest
    Sub HacerVoz()
        Dim voz1 As New Voz(100.0, 1111)
        Console.WriteLine("Servicio: " & voz1.ToString)
    End Sub
End Module
