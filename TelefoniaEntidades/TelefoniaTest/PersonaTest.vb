Imports TelefoniaEntidades
Module PersonaTest
    Sub HacerPersona()
        Dim persona As New Persona("Laizan", "Daniel´s", 12345678)
        Console.WriteLine("Persona: " & persona.ToString)
    End Sub
End Module
