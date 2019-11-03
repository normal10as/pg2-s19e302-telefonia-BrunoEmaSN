Imports TelefoniaEntidades
Module SMSTest
    Sub HacerSMS()
        Dim sms1 As New SMS(100.0, 2222)
        Console.WriteLine("Servicio: " & sms1.ToString)
    End Sub
End Module
