Public Class AdminForm

    Dim columnType As Type

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VideoDatabaseDataSet.Videos' table. You can move, or remove it, as needed.
        Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)

        initComboBox()

    End Sub

    Sub initComboBox()

        For i As Integer = 0 To VideoDatabaseDataSet.Videos.Columns.Count

            ComboBox1.Items.Add(VideoDatabaseDataSet.Videos.Columns(i).ColumnName)

            If i = VideoDatabaseDataSet.Videos.Columns.Count - 1 Then
                ComboBox1.SelectedIndex = 0
                columnType = VideoDatabaseDataSet.Videos.Columns(ComboBox1.SelectedIndex).DataType
            End If

        Next

        

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
        Dim found As Boolean = False
        Dim index As Integer = 0
        For i As Integer = 0 To VideoDatabaseDataSet.Videos.Rows.Count - 1
            If VideoDatabaseDataSet.Videos.Rows(i).Item(0) = NumericUpDown1.Value Then
                MsgBox("found!")
                index = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("ID not found")
        Else
            VideoDatabaseDataSet.Videos.Rows(index).Delete()
            VideosTableAdapter.Update(VideoDatabaseDataSet.Videos)

        End If

    End Sub
End Class