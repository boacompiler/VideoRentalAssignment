Public Class logInControl

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.UsersTableAdapter.Fill(MainForm.VideoDatabaseDataSet.Users)

        Dim found = False
        Dim index As Integer = 0
        For i As Integer = 0 To MainForm.VideoDatabaseDataSet.Users.Rows.Count - 1
            If MainForm.VideoDatabaseDataSet.Users.Rows(i).Item(1) = TextBox1.Text Then
                'MsgBox("found!")
                index = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("User not found")
        Else
            If MainForm.VideoDatabaseDataSet.Users.Rows(index).Item(2) = TextBox2.Text Then
                If MainForm.VideoDatabaseDataSet.Users.Rows(index).Item(3) = True Then
                    MainForm.isAdmin = True
                Else
                    MainForm.isAdmin = False
                End If

                MainForm.LogIn(MainForm.isAdmin)
            Else
                MsgBox("password incorrect") 'TODO this is for testing, login should never be specific about the login failure on users end
            End If
        End If

    End Sub
End Class
