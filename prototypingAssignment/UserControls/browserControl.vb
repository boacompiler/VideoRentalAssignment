Public Class browserControl

    Public movieIndex As Integer
    Dim myForm As frmMain

    Sub New(isAdmin As Boolean, form As frmMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        movieIndex = 0
        displayMovie(movieIndex)
        AdminToolStripMenuItem.Visible = isAdmin
        myForm = form

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmMain.LogOut()
    End Sub

    Sub displayMovie(index As Integer)
        Try
            lblTitle.Text = frmMain.VideoDatabaseDataSet.Videos.Rows(index).Item(1)
            lblBody.Text = frmMain.VideoDatabaseDataSet.Videos.Rows(index).Item(2)

            lblLength.Text = "Runtime: " & frmMain.VideoDatabaseDataSet.Videos.Rows(index).Item(3) & " minutes"

            If frmMain.VideoDatabaseDataSet.Videos.Rows(index).Item(4) Then
                lblAvailability.ForeColor = Color.Green
                lblAvailability.Text = "Available"
            Else
                lblAvailability.ForeColor = Color.Red
                lblAvailability.Text = "Not Available"
            End If
        Catch ex As Exception
            lblTitle.Text = "Error: " & ex.Message
        End Try


    End Sub

    Sub IncrementIndex()
        movieIndex += 1
        If movieIndex >= frmMain.VideoDatabaseDataSet.Videos.Rows.Count Then
            movieIndex = 0
        End If
        displayMovie(movieIndex)
    End Sub

    Sub DecrementIndex()
        movieIndex -= 1
        If movieIndex <= -1 Then
            movieIndex = frmMain.VideoDatabaseDataSet.Videos.Rows.Count - 1
        End If
        displayMovie(movieIndex)
    End Sub

    Private Sub ManageDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDataToolStripMenuItem.Click
        Dim testfrm As frmAdmin = New frmAdmin(myForm)
        testfrm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        IncrementIndex()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        DecrementIndex()
    End Sub

End Class
