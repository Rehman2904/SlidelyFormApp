Public Class ViewSubmissionsForm

    ' Example data source
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load or initialize submissions
        ShowCurrentSubmission()
    End Sub

    Private Sub ShowCurrentSubmission()
        ' Display the current submission
        Dim submission = submissions(currentIndex)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithubLink.Text = submission.GithubLink
        lblStopwatch.Text = submission.StopwatchTime
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowCurrentSubmission()
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowCurrentSubmission()
        End If
    End Sub


End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String ' Alternatively, use TimeSpan or another suitable type
End Class

