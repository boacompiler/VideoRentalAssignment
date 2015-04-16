Public Class Form1

    Public isAdmin As Boolean
    Public logInMenu As logInControl
    Public browserMenu As browserControl

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isAdmin = True

        logInMenu = New logInControl()
        Me.Controls.Add(logInMenu)

        

        DockControl(logInMenu)
    End Sub

    Sub DockControl(uControl As Control)

        uControl.Dock = DockStyle.Fill
        uControl.BringToFront()

    End Sub

    Sub LogIn(admin As Boolean)
        browserMenu = New browserControl(admin, Me)
        Me.Controls.Add(browserMenu)
        DockControl(browserMenu)
    End Sub

    Sub LogOut()
        DockControl(logInMenu)
        Me.Controls.Remove(browserMenu)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VideoDatabaseDataSet.Videos' table. You can move, or remove it, as needed.
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)

    End Sub

    Sub deleteRow(index)
        Me.VideoDatabaseDataSet.Videos.Rows(index).Delete()
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)
    End Sub

End Class
