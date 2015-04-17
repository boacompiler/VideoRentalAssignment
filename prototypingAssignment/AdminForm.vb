Public Class AdminForm

    Dim columnType As Type
    Dim myForm As Form1

    Sub New(form As Form1)

        ' This call is required by the designer.
        InitializeComponent()
        myForm = form
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VideoDatabaseDataSet.Videos' table. You can move, or remove it, as needed.
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)

        initComboBox()

    End Sub

    Sub initComboBox()

        For i As Integer = 0 To VideoDatabaseDataSet.Videos.Columns.Count - 1

            ComboBox1.Items.Add(VideoDatabaseDataSet.Videos.Columns(i).ColumnName)

        Next

        ComboBox1.SelectedIndex = 0
        columnType = VideoDatabaseDataSet.Videos.Columns(ComboBox1.SelectedIndex).DataType

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If TextBox1.Text <> Nothing Then

            Dim filter As String

            Select Case columnType.Name
                Case "Boolean"
                    filter = ComboBox1.Text & " = " & TextBox1.Text.Trim
                Case "Int32"
                    filter = ComboBox1.Text & " = " & TextBox1.Text.Trim
                Case "String"
                    filter = ComboBox1.Text & " like '%" & TextBox1.Text & "%'"
                Case Else
                    MsgBox("unsupported dataType: " & columnType.Name)
            End Select

            If filter <> Nothing Then
                VideosBindingSource.Filter = filter
            Else
                MsgBox("Unssuported Search")
            End If
        Else
            MsgBox("please enter a search term")
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Clear()
        columnType = VideoDatabaseDataSet.Videos.Columns(ComboBox1.SelectedIndex).DataType
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Select Case columnType.Name
            Case "Boolean"
                TextBox1.Clear()
                If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso e.KeyChar <> "0" AndAlso e.KeyChar <> "1" Then
                    MessageBox.Show("Please enter Boolean values only: 1/0")
                    e.Handled = True
                End If
            Case "Int32"
                If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
                    MessageBox.Show("Please enter Integer values only: 0-9")
                    e.Handled = True
                End If
            Case "String"

            Case Else
                MsgBox("unsupported dataType: " & columnType.Name)
        End Select
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TextBox1.Clear()
        VideosBindingSource.RemoveFilter()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'VideoDatabaseDataSet.Videos.Rows(NumericUpDown1.Value).Delete()
        Dim found = False
        Dim index As Integer = 0
        For i As Integer = 0 To VideoDatabaseDataSet.Videos.Rows.Count - 1
            If VideoDatabaseDataSet.Videos.Rows(i).Item(0) = NumericUpDown1.Value Then
                'MsgBox("found!")
                index = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("ID not found")
        Else
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & Form1.VideoDatabaseDataSet.Videos.Rows(index).Item(1), "Delete", MessageBoxButtons.OKCancel)

            If result = DialogResult.OK Then
                Me.VideoDatabaseDataSet.Videos.Rows(index).Delete()
                Me.VideosTableAdapter.Update(VideoDatabaseDataSet.Videos)
                myForm.DeleteRow(index)
            End If

        End If

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim found = False
        Dim index As Integer = 0
        For i As Integer = 0 To VideoDatabaseDataSet.Videos.Rows.Count - 1
            If VideoDatabaseDataSet.Videos.Rows(i).Item(0) = NumericUpDown1.Value Then
                'MsgBox("found!")
                index = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("ID not found")
        Else
            Dim id As Integer = VideoDatabaseDataSet.Videos.Rows(index).Item(0)
            Dim title As String = VideoDatabaseDataSet.Videos.Rows(index).Item(1)
            Dim description As String = VideoDatabaseDataSet.Videos.Rows(index).Item(2)
            Dim length As String = VideoDatabaseDataSet.Videos.Rows(index).Item(3)
            Dim available As Boolean = VideoDatabaseDataSet.Videos.Rows(index).Item(4)
            Dim editForm As VideoEditForm = New VideoEditForm(id, title, description, length, available)
            editForm.ShowDialog()
            'MsgBox(title)
            VideoDatabaseDataSet.Videos.Rows(index).Item(1) = editForm.TextBoxTitle.Text
            VideoDatabaseDataSet.Videos.Rows(index).Item(2) = editForm.RichTextBoxDescription.Text
            VideoDatabaseDataSet.Videos.Rows(index).Item(3) = editForm.NumericUpDownLength.Value
            VideoDatabaseDataSet.Videos.Rows(index).Item(4) = editForm.CheckBoxAvailable.Checked
            editForm.Dispose()

            Me.VideosTableAdapter.Update(VideoDatabaseDataSet.Videos)
            myForm.UpdateRow()

        End If
    End Sub
End Class