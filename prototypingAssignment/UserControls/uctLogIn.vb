Public Class uctLogIn

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmdLogin.Click

        Me.UsersTableAdapter.Fill(frmMain.VideoDatabaseDataSet.Users)

        Dim found = False
        Dim index As Integer = 0
        For i As Integer = 0 To frmMain.VideoDatabaseDataSet.Users.Rows.Count - 1
            If frmMain.VideoDatabaseDataSet.Users.Rows(i).Item(1) = txtUserName.Text Then
                'MsgBox("found!")
                index = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("User not found")
        Else
            If frmMain.VideoDatabaseDataSet.Users.Rows(index).Item(2) = txtPassword.Text Then
                If frmMain.VideoDatabaseDataSet.Users.Rows(index).Item(3) = True Then
                    frmMain.isAdmin = True
                Else
                    frmMain.isAdmin = False
                End If

                frmMain.LogIn(frmMain.isAdmin)
            Else
                MsgBox("password incorrect") 'TODO this is for testing, login should never be specific about the login failure on users end
            End If
        End If

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        If keyData = Keys.Enter Then
            cmdLogin.PerformClick()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
