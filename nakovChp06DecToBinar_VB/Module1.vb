Imports System

Namespace nakovChp06DecimToBinar

    Public Class Program

        Public Shared Sub Main(ByVal args As String())
            Console.WriteLine("Please enter a positive number: ")
            Dim userInp As String = Console.ReadLine()
            Dim num As Integer = 0
            Dim check As Boolean = Integer.TryParse(userInp, num)
            If check <> True Then
                Console.WriteLine("Please enter a positive integer")
            End If

            Console.WriteLine("the number is {0}", num)
            Dim division As Integer = 0
            Dim remainder As String = String.Empty
            While num >= 1
                division = num / 2
                remainder += (num Mod 2).ToString()
                num = division
            End While

            Dim binary As String = String.Empty
            For i As Integer = remainder.Length - 1 To 0 Step -1
                binary = binary & remainder(i)
            Next

            Console.WriteLine("The binary version of the entered number is {0}", binary)
        End Sub
    End Class
End Namespace

