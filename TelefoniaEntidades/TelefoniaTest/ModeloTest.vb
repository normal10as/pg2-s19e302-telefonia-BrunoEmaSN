Imports TelefoniaEntidades
Module ModeloTest

    Sub HacerModelo()
        Dim marca1 As New Marca("Apple")
        Dim modelo1 As New Modelo("iphone 11", marca1)
        Console.WriteLine("Marca: " & marca1.ToString)
        Console.WriteLine("Modelo: " & modelo1.ToString)
    End Sub
End Module
