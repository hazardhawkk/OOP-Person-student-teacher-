Public Class STUDENT
    Inherits PERSON
    Private tutorGroup As String
    Private studentCode As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub Enter_Student_Details()
        Enter_Person_details()
        Console.WriteLine("Enter Tutor Group")
        tutorGroup = Console.ReadLine()
        Console.WriteLine("Enter Student Code")
        studentCode = Console.ReadLine()
    End Sub

End Class
