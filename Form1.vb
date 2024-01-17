Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BirthYear.Click
        Dim YourMessage As String


        Dim BirthYear As Integer
        YourMessage = "Happy bday! How old are you"


        MsgBox(YourMessage)
        BirthYear = Val(InputBox("Enter year of birth"))
        MsgBox("You are now " & 2023 - BirthYear & " years old")

    End Sub
End Class
