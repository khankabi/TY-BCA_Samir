Module Module2
    Sub Main()
        Dim i, j As Integer
        Dim isPrime As Boolean
        Console.WriteLine("Prime numbers between 1 and 500 are: ")
        For i = 2 To 500
            isPrime = True
            For j = 2 To (i - 1)
                If i Mod j = 0 Then
                    isPrime = False
                    Exit For
                End If
            Next
            If isPrime Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
