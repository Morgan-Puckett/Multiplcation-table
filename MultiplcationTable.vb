﻿

Option Strict On
Option Explicit On


Module MultiplcationTable
    Dim userResponse As String
    Dim intResponse As Integer
    Dim go As Boolean

    Sub Main()
        go = False
        Console.WriteLine("Enter a table size...")

        Do While go = False
            userResponse = Console.ReadLine()
            Try
                intResponse = CInt(userResponse)
                go = True
            Catch ex As Exception
                Console.WriteLine($"You entered ""{userResponse},"" please enter a valid number")
                go = False
            End Try
        Loop
        Console.WriteLine($"Here is your desired {intResponse}x{intResponse}...")
        Dim horizontal As Integer
        Dim vert As Integer

        horizontal = 1
        For i As Integer = 1 To intResponse

            For j As Integer = 1 To intResponse
                horizontal = j * i
                Console.Write($"{horizontal}".PadLeft(8))
            Next

            vert = vert + 1
            Console.WriteLine(vbNewLine)
        Next







        Console.ReadLine()


    End Sub

End Module
