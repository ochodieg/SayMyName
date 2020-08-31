'Ivan Ochoa
'RCET0265
'Fall 2020, Semester 4
'Say My Name

Option Strict On
Option Explicit On

Module SayMyName

    Sub Main()
        Dim userInput As String
        Console.WriteLine("beep boop, what is your name, human?")
        userInput = Console.ReadLine()
        Console.WriteLine("Ah")
        Console.WriteLine("Well...When skynets time comes... I'll remember your name," & " " & userInput)
        Console.ReadLine()

    End Sub

End Module
