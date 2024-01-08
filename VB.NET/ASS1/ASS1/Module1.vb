Module Module1
    Sub Main()
        Dim arr As Integer() = New Integer(5) {}
        Dim first_large As Integer
        Dim second_large As Integer

        Console.WriteLine("Enter array elements")
        For i As Integer = 0 To 4 Step 1
            Console.Write("Element[{0}]: ", i)
            arr(i) = Integer.Parse(Console.ReadLine())

            If (first_large < arr(i)) Then
                second_large = first_large
                first_large = arr(i)
            End If
        Next
        Console.WriteLine("second largest element is array is :{0}", second_large)
        Console.ReadKey()
    End Sub
End Module
