Public Class frmMain

    Public isAdmin As Boolean
    Public logInMenu As uctLogIn
    Public browserMenu As browserControl
    Public userIndex As Integer = 1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isAdmin = True

        logInMenu = New uctLogIn()
        Me.Controls.Add(logInMenu)



        DockControl(logInMenu)
    End Sub

    Sub DockControl(uControl As Control)

        uControl.Dock = DockStyle.Fill
        uControl.BringToFront()

    End Sub

    Sub LogIn(admin As Boolean)
        Me.Controls.Remove(browserMenu)
        browserMenu = New browserControl(admin, Me)
        Me.Controls.Add(browserMenu)
        DockControl(browserMenu)
        Me.Controls.Remove(logInMenu)
    End Sub

    Sub LogOut()
        Me.Controls.Remove(logInMenu)
        logInMenu = New uctLogIn()
        Me.Controls.Add(logInMenu)
        DockControl(logInMenu)
        Me.Controls.Remove(browserMenu)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VideoDatabaseDataSet.Videos' table. You can move, or remove it, as needed.
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)

    End Sub

    Sub DeleteRow(index)
        Me.VideoDatabaseDataSet.Videos.Rows(index).Delete()
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)
    End Sub

    Sub UpdateRow()
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)
    End Sub

    Private Sub VideosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VideosBindingSource.CurrentChanged

    End Sub
End Class
