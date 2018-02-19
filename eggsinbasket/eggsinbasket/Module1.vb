Module Module1

    Sub Main()
        Dim Nofeggs, Boxes, eggsleft As Integer
        Console.WriteLine("Input No of eggs : ")
        Nofeggs = Console.ReadLine()
        Call Eggsintoboxes(Nofeggs, Boxes, eggsleft)
        Console.WriteLine("Boxes = " & Boxes & " EGGSLEFT = " & eggsleft)
        Console.ReadKey()

    End Sub


    Sub Eggsintoboxes(ByRef NOE As Integer, ByRef B As Integer, ByRef EL As Integer)

        B = NOE \ 6
        EL = NOE Mod 6


    End Sub

End Module
