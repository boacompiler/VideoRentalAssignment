<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvRows = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VideoTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VideoDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VideoLengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VideosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VideoDatabaseDataSet = New prototypingAssignment.VideoDatabaseDataSet()
        Me.tlpSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboColumn = New System.Windows.Forms.ComboBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.tlpEditor = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.tlpID = New System.Windows.Forms.TableLayoutPanel()
        Me.nudID = New System.Windows.Forms.NumericUpDown()
        Me.LblID = New System.Windows.Forms.Label()
        Me.VideosTableAdapter = New prototypingAssignment.VideoDatabaseDataSetTableAdapters.VideosTableAdapter()
        Me.tlpLayout.SuspendLayout()
        CType(Me.dgvRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideoDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpSearch.SuspendLayout()
        Me.tlpEditor.SuspendLayout()
        Me.tlpControls.SuspendLayout()
        Me.tlpID.SuspendLayout()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 1
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Controls.Add(Me.dgvRows, 0, 1)
        Me.tlpLayout.Controls.Add(Me.tlpSearch, 0, 0)
        Me.tlpLayout.Controls.Add(Me.tlpEditor, 0, 2)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 3
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(538, 486)
        Me.tlpLayout.TabIndex = 0
        '
        'dgvRows
        '
        Me.dgvRows.AllowUserToAddRows = False
        Me.dgvRows.AutoGenerateColumns = False
        Me.dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRows.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.VideoTitleDataGridViewTextBoxColumn, Me.VideoDescriptionDataGridViewTextBoxColumn, Me.VideoLengthDataGridViewTextBoxColumn, Me.AvailableDataGridViewCheckBoxColumn})
        Me.dgvRows.DataSource = Me.VideosBindingSource
        Me.dgvRows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRows.Location = New System.Drawing.Point(3, 43)
        Me.dgvRows.Name = "dgvRows"
        Me.dgvRows.ReadOnly = True
        Me.dgvRows.Size = New System.Drawing.Size(532, 400)
        Me.dgvRows.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VideoTitleDataGridViewTextBoxColumn
        '
        Me.VideoTitleDataGridViewTextBoxColumn.DataPropertyName = "VideoTitle"
        Me.VideoTitleDataGridViewTextBoxColumn.HeaderText = "VideoTitle"
        Me.VideoTitleDataGridViewTextBoxColumn.Name = "VideoTitleDataGridViewTextBoxColumn"
        Me.VideoTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VideoDescriptionDataGridViewTextBoxColumn
        '
        Me.VideoDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VideoDescription"
        Me.VideoDescriptionDataGridViewTextBoxColumn.HeaderText = "VideoDescription"
        Me.VideoDescriptionDataGridViewTextBoxColumn.Name = "VideoDescriptionDataGridViewTextBoxColumn"
        Me.VideoDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VideoLengthDataGridViewTextBoxColumn
        '
        Me.VideoLengthDataGridViewTextBoxColumn.DataPropertyName = "VideoLength"
        Me.VideoLengthDataGridViewTextBoxColumn.HeaderText = "VideoLength"
        Me.VideoLengthDataGridViewTextBoxColumn.Name = "VideoLengthDataGridViewTextBoxColumn"
        Me.VideoLengthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AvailableDataGridViewCheckBoxColumn
        '
        Me.AvailableDataGridViewCheckBoxColumn.DataPropertyName = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.HeaderText = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.Name = "AvailableDataGridViewCheckBoxColumn"
        Me.AvailableDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'VideosBindingSource
        '
        Me.VideosBindingSource.DataMember = "Videos"
        Me.VideosBindingSource.DataSource = Me.VideoDatabaseDataSet
        '
        'VideoDatabaseDataSet
        '
        Me.VideoDatabaseDataSet.DataSetName = "VideoDatabaseDataSet"
        Me.VideoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tlpSearch
        '
        Me.tlpSearch.ColumnCount = 4
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSearch.Controls.Add(Me.cmdSearch, 2, 0)
        Me.tlpSearch.Controls.Add(Me.txtSearch, 1, 0)
        Me.tlpSearch.Controls.Add(Me.cboColumn, 0, 0)
        Me.tlpSearch.Controls.Add(Me.cmdClear, 3, 0)
        Me.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSearch.Location = New System.Drawing.Point(3, 3)
        Me.tlpSearch.Name = "tlpSearch"
        Me.tlpSearch.RowCount = 1
        Me.tlpSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSearch.Size = New System.Drawing.Size(532, 34)
        Me.tlpSearch.TabIndex = 1
        '
        'cmdSearch
        '
        Me.cmdSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdSearch.Location = New System.Drawing.Point(269, 3)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(127, 23)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Location = New System.Drawing.Point(136, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(127, 20)
        Me.txtSearch.TabIndex = 0
        '
        'cboColumn
        '
        Me.cboColumn.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn.FormattingEnabled = True
        Me.cboColumn.Location = New System.Drawing.Point(3, 3)
        Me.cboColumn.Name = "cboColumn"
        Me.cboColumn.Size = New System.Drawing.Size(127, 21)
        Me.cboColumn.TabIndex = 2
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdClear.Location = New System.Drawing.Point(402, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(127, 23)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'tlpEditor
        '
        Me.tlpEditor.ColumnCount = 2
        Me.tlpEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEditor.Controls.Add(Me.tlpControls, 1, 0)
        Me.tlpEditor.Controls.Add(Me.tlpID, 0, 0)
        Me.tlpEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEditor.Location = New System.Drawing.Point(3, 449)
        Me.tlpEditor.Name = "tlpEditor"
        Me.tlpEditor.RowCount = 1
        Me.tlpEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEditor.Size = New System.Drawing.Size(532, 34)
        Me.tlpEditor.TabIndex = 2
        '
        'tlpControls
        '
        Me.tlpControls.ColumnCount = 3
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpControls.Controls.Add(Me.cmdEdit, 0, 0)
        Me.tlpControls.Controls.Add(Me.cmdAdd, 1, 0)
        Me.tlpControls.Controls.Add(Me.cmdDelete, 2, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControls.Location = New System.Drawing.Point(269, 3)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 1
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControls.Size = New System.Drawing.Size(260, 28)
        Me.tlpControls.TabIndex = 0
        '
        'cmdEdit
        '
        Me.cmdEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdEdit.Location = New System.Drawing.Point(3, 3)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(80, 22)
        Me.cmdEdit.TabIndex = 0
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdAdd.Location = New System.Drawing.Point(89, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 22)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdDelete.Location = New System.Drawing.Point(175, 3)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(82, 22)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'tlpID
        '
        Me.tlpID.ColumnCount = 2
        Me.tlpID.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpID.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpID.Controls.Add(Me.nudID, 1, 0)
        Me.tlpID.Controls.Add(Me.LblID, 0, 0)
        Me.tlpID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpID.Location = New System.Drawing.Point(3, 3)
        Me.tlpID.Name = "tlpID"
        Me.tlpID.RowCount = 1
        Me.tlpID.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpID.Size = New System.Drawing.Size(260, 28)
        Me.tlpID.TabIndex = 1
        '
        'nudID
        '
        Me.nudID.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudID.Location = New System.Drawing.Point(133, 3)
        Me.nudID.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudID.Name = "nudID"
        Me.nudID.Size = New System.Drawing.Size(124, 20)
        Me.nudID.TabIndex = 0
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblID.Location = New System.Drawing.Point(3, 0)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(124, 28)
        Me.LblID.TabIndex = 1
        Me.LblID.Text = "ID : "
        Me.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VideosTableAdapter
        '
        Me.VideosTableAdapter.ClearBeforeFill = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 486)
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        Me.tlpLayout.ResumeLayout(False)
        CType(Me.dgvRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideoDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpSearch.ResumeLayout(False)
        Me.tlpSearch.PerformLayout()
        Me.tlpEditor.ResumeLayout(False)
        Me.tlpControls.ResumeLayout(False)
        Me.tlpID.ResumeLayout(False)
        Me.tlpID.PerformLayout()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvRows As System.Windows.Forms.DataGridView
    Friend WithEvents VideoDatabaseDataSet As prototypingAssignment.VideoDatabaseDataSet
    Friend WithEvents VideosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VideosTableAdapter As prototypingAssignment.VideoDatabaseDataSetTableAdapters.VideosTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VideoTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VideoDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VideoLengthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tlpSearch As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cboColumn As System.Windows.Forms.ComboBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents tlpEditor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpID As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nudID As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
End Class
