Public Class PERSON
    Private firstName As String
    Private surname As String
    Private address As String

    Public Sub New()

    End Sub

    Public Sub Enter_Person_details()
        Console.WriteLine("Enter First Name")
        firstName = Console.ReadLine()
        Console.WriteLine("Enter Surname")
        surname = Console.ReadLine()
        Console.WriteLine("Enter Address")
        address = Console.ReadLine()
    End Sub

End Class
