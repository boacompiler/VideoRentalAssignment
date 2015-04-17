Public Class VideoEditForm

    Dim editMode As Boolean = True

    Sub New()
        'this constructor is for adding
        ' This call is required by the designer.
        InitializeComponent()
        editMode = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(id As Integer, title As String, description As String, length As Integer, available As Boolean)
        'this constructor is for editing
        ' This call is required by the designer.
        InitializeComponent()
        editMode = True
        ' Add any initialization after the InitializeComponent() call.

        NumericUpDownID.Value = id
        TextBoxTitle.Text = title
        RichTextBoxDescription.Text = description
        NumericUpDownLength.Value = length
        CheckBoxAvailable.Checked = available
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        Me.Hide()

    End Sub
End Class