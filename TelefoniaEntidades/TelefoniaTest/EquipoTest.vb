Imports TelefoniaEntidades
Module EquipoTest
    Dim marca1 As New Marca("Apple")
    Dim modelo1 As New Modelo("iphone", marca1)
    Dim equipo1 As New Equipo(modelo1, "1a2b3c4d5e6f7g8")
    Sub HacerEquipo()
        Console.WriteLine("Marca: " & marca1.ToString)
        Console.WriteLine("Modelo: " & modelo1.ToString)
        Console.WriteLine("Equipo: " & equipo1.ToString)
    End Sub
End Module
