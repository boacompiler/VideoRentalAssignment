Public Class frmVideoEdit

    Dim editMode As Boolean
    Public cancelled As Boolean

    Sub New()
        'this constructor is for adding
        ' This call is required by the designer.
        InitializeComponent()
        editMode = False
        cancelled = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(id As Integer, title As String, description As String, length As Integer, available As Boolean)
        'this constructor is for editing
        ' This call is required by the designer.
        InitializeComponent()
        editMode = True
        cancelled = False
        ' Add any initialization after the InitializeComponent() call.

        nudID.Value = id
        txtTitle.Text = title
        rtfDescription.Text = description
        nudLength.Value = length
        chkAvailable.Checked = available
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click

        Me.Hide()

    End Sub

    Private Sub VideoEditForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            cancelled = True
        End If



    End Sub
End Class