Public Class frmAdmin

    Dim columnType As Type
    Dim myForm As frmMain

    Sub New(form As frmMain)

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

            cboColumn.Items.Add(VideoDatabaseDataSet.Videos.Columns(i).ColumnName)

        Next

        cboColumn.SelectedIndex = 0
        columnType = VideoDatabaseDataSet.Videos.Columns(cboColumn.SelectedIndex).DataType

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        If txtSearch.Text <> Nothing Then

            Dim filter As String

            Select Case columnType.Name
                Case "Boolean"
                    filter = cboColumn.Text & " = " & txtSearch.Text.Trim
                Case "Int32"
                    filter = cboColumn.Text & " = " & txtSearch.Text.Trim
                Case "String"
                    filter = cboColumn.Text & " like '%" & txtSearch.Text & "%'"
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColumn.SelectedIndexChanged
        txtSearch.Clear()
        columnType = VideoDatabaseDataSet.Videos.Columns(cboColumn.SelectedIndex).DataType
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Select Case columnType.Name
            Case "Boolean"
                txtSearch.Clear()
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

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtSearch.Clear()
        VideosBindingSource.RemoveFilter()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        'VideoDatabaseDataSet.Videos.Rows(NumericUpDown1.Value).Delete()
        Dim found = False
        Dim index As Integer = 0
        For i As Integer = 0 To VideoDatabaseDataSet.Videos.Rows.Count - 1
            If VideoDatabaseDataSet.Videos.Rows(i).Item(0) = nudID.Value Then
                'MsgBox("found!")
                index = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("ID not found")
        Else
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & frmMain.VideoDatabaseDataSet.Videos.Rows(index).Item(1), "Delete", MessageBoxButtons.OKCancel)

            If result = DialogResult.OK Then
                Me.VideoDatabaseDataSet.Videos.Rows(index).Delete()
                Me.VideosTableAdapter.Update(VideoDatabaseDataSet.Videos)
                myForm.DeleteRow(index)
            End If

        End If

        If myForm.browserMenu.movieIndex = index Then
            myForm.browserMenu.IncrementIndex() 'TODO fix this
        End If


    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim found = False
        Dim index As Integer = 0
        For i As Integer = 0 To VideoDatabaseDataSet.Videos.Rows.Count - 1
            If VideoDatabaseDataSet.Videos.Rows(i).Item(0) = nudID.Value Then
                'MsgBox("found!")
                index = i
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("ID not found")
        Else
            Dim id As Integer = VideoDatabaseDataSet.Videos.Rows(index).Item(0) 'this is the ugly solution we needed, but not the ugly solution we deserve
            Dim title As String = VideoDatabaseDataSet.Videos.Rows(index).Item(1)
            Dim description As String = VideoDatabaseDataSet.Videos.Rows(index).Item(2)
            Dim length As String = VideoDatabaseDataSet.Videos.Rows(index).Item(3)
            Dim available As Boolean = VideoDatabaseDataSet.Videos.Rows(index).Item(4)
            Dim editForm As frmVideoEdit = New frmVideoEdit(id, title, description, length, available)
            editForm.ShowDialog()
            'MsgBox(title)
            If editForm.cancelled = False Then
                VideoDatabaseDataSet.Videos.Rows(index).Item(1) = editForm.txtTitle.Text
                VideoDatabaseDataSet.Videos.Rows(index).Item(2) = editForm.rtfDescription.Text
                VideoDatabaseDataSet.Videos.Rows(index).Item(3) = editForm.nudLength.Value
                VideoDatabaseDataSet.Videos.Rows(index).Item(4) = editForm.chkAvailable.Checked

                Me.VideosTableAdapter.Update(VideoDatabaseDataSet.Videos)
                Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)
                myForm.UpdateRow()
            End If
            editForm.Dispose()
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim addForm As frmVideoEdit = New frmVideoEdit()
        addForm.ShowDialog()
        Dim title As String = addForm.txtTitle.Text
        Dim description As String = addForm.rtfDescription.Text
        Dim length As String = addForm.nudLength.Value
        Dim available As Boolean = addForm.chkAvailable.Checked

        If addForm.cancelled = False Then
            Me.VideoDatabaseDataSet.Videos.Rows.Add(Nothing, title, description, length, available)
            Me.VideosTableAdapter.Update(VideoDatabaseDataSet.Videos)
            Me.VideosTableAdapter.Fill(Me.VideoDatabaseDataSet.Videos)
            myForm.UpdateRow()
        End If
        addForm.Dispose()
    End Sub
End Class