Public Class browserControl

    Dim movieIndex As Integer
    Dim myForm As Form1

    Sub New(isAdmin As Boolean, form As Form1)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        movieIndex = 0
        displayMovie(movieIndex)
        AdminToolStripMenuItem.Visible = isAdmin
        myForm = form

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.LogOut()
    End Sub

    Sub displayMovie(index As Integer)
        Try
            LblTitle.Text = Form1.VideoDatabaseDataSet.Videos.Rows(index).Item(1)
            LblBody.Text = Form1.VideoDatabaseDataSet.Videos.Rows(index).Item(2)

            LblLength.Text = "Runtime: " & Form1.VideoDatabaseDataSet.Videos.Rows(index).Item(3) & " minutes"

            If Form1.VideoDatabaseDataSet.Videos.Rows(index).Item(4) Then
                LblAvailability.ForeColor = Color.Green
                LblAvailability.Text = "Available"
            Else
                LblAvailability.ForeColor = Color.Red
                LblAvailability.Text = "Not Available"
            End If
        Catch ex As Exception
            LblTitle.Text = "Error: " & ex.Message
        End Try


    End Sub

    Private Sub ManageDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDataToolStripMenuItem.Click
        Dim testfrm As AdminForm = New AdminForm(myForm)
        testfrm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        movieIndex += 1
        If movieIndex = Form1.VideoDatabaseDataSet.Videos.Rows.Count Then
            movieIndex = 0
        End If
        displayMovie(movieIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        movieIndex -= 1
        If movieIndex = -1 Then
            movieIndex = Form1.VideoDatabaseDataSet.Videos.Rows.Count - 1
        End If
        displayMovie(movieIndex)
    End Sub

End Class
