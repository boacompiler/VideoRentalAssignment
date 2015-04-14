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
        MsgBox("i like easter eggs")

    End Sub

    Sub LogIn(admin As Boolean)
        browserMenu = New browserControl(admin)
        Me.Controls.Add(browserMenu)
        DockControl(browserMenu)
    End Sub

    Sub LogOut()
        DockControl(logInMenu)
        Me.Controls.Remove(browserMenu)
    End Sub

End Class
