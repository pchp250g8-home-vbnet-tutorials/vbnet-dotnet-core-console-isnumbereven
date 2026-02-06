Imports System

Module Program
    Sub Main(args As String())
        Dim ulNumber As UInt64
        Console.WriteLine("Input an integer positive number")
        UInt64.TryParse(Console.ReadLine(), ulNumber)
        If (ulNumber Mod 2 = 0) Then
            Console.WriteLine("The number is even")
        Else
            Console.WriteLine("The number is odd")
        End If
        Console.ReadLine()
    End Sub
End Module