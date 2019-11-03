Imports TelefoniaEntidades
Module EmpresaTest
    Sub HacerEmpresa()
        Dim empresa1 As New Empresa("Personal", "1204208480812")
        Console.WriteLine("Empresa: " & empresa1.ToString)
    End Sub
End Module
