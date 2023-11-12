Imports System
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())
        ' Common Variables and datatypes

        'String 
        Dim name As String = "Melvin Agustin"

        'Char
        Dim middleInitial As Char = "C"

        'Integer
        Dim age As Integer = 19

        'Boolean
        Dim is_married As Boolean = False

        'Double, Float, and Decimal
        Dim weight As Decimal = 57.89
        Dim height As Double = 5.4

        'Date
        Dim birthDate As Date = #12/30/2003#

        'Output
        Console.WriteLine("Name: " & name)
        Console.WriteLine("Middle Initial : " & middleInitial)
        Console.WriteLine("Age: " & age)
        Console.WriteLine("is_married: " & is_married)
        Console.WriteLine("weight: " & weight)
        Console.WriteLine("height: " & height)
        Console.WriteLine("Birthdate: " & birthDate)

    End Sub
End Module
