Public Class browserControl

    Dim movieIndex As Integer

    Sub New(isAdmin As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)
        movieIndex = 0
        displayMovie(movieIndex)
        AdminToolStripMenuItem.Visible = isAdmin

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.LogOut()
    End Sub

    Sub displayMovie(index As Integer)
        LblTitle.Text = VideoDatabaseDataSet.Videos.Rows(index).Item(1)
        LblBody.Text = VideoDatabaseDataSet.Videos.Rows(index).Item(2)

        LblLength.Text = "Runtime: " & VideoDatabaseDataSet.Videos.Rows(index).Item(3) & " minutes"

        If VideoDatabaseDataSet.Videos.Rows(index).Item(4) Then
            LblAvailability.ForeColor = Color.Green
            LblAvailability.Text = "Available"
        Else
            LblAvailability.ForeColor = Color.Red
            LblAvailability.Text = "Not Available"
        End If
    End Sub

    Private Sub ManageDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDataToolStripMenuItem.Click
        Dim testfrm As AdminForm = New AdminForm()
        testfrm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        movieIndex += 1
        If movieIndex = VideoDatabaseDataSet.Videos.Rows.Count Then
            movieIndex = 0
        End If
        displayMovie(movieIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        movieIndex -= 1
        If movieIndex = -1 Then
            movieIndex = VideoDatabaseDataSet.Videos.Rows.Count - 1
        End If
        displayMovie(movieIndex)
    End Sub

End Class
