Public Class TEACHER
    Inherits PERSON
    Private subject As String
    Private teacherNumber As String

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub Enter_Teacher_Details()
        Enter_Person_details()
        Console.WriteLine("Enter Subject")
        subject = Console.ReadLine()
        Console.WriteLine("Enter Teacher Number")
        teacherNumber = Console.ReadLine()
    End Sub

End Class
