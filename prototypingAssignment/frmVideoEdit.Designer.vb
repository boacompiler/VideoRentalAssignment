<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoEdit
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
        Me.tlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.nudID = New System.Windows.Forms.NumericUpDown()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.rtfDescription = New System.Windows.Forms.RichTextBox()
        Me.chkAvailable = New System.Windows.Forms.CheckBox()
        Me.nudLength = New System.Windows.Forms.NumericUpDown()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblRuntime = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.tlpLayout.SuspendLayout()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 5
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.03491!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66837!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.22449!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.03732!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.03491!))
        Me.tlpLayout.Controls.Add(Me.nudID, 0, 1)
        Me.tlpLayout.Controls.Add(Me.txtTitle, 1, 1)
        Me.tlpLayout.Controls.Add(Me.rtfDescription, 2, 1)
        Me.tlpLayout.Controls.Add(Me.chkAvailable, 4, 1)
        Me.tlpLayout.Controls.Add(Me.nudLength, 3, 1)
        Me.tlpLayout.Controls.Add(Me.cmdOk, 4, 2)
        Me.tlpLayout.Controls.Add(Me.lblID, 0, 0)
        Me.tlpLayout.Controls.Add(Me.lblTitle, 1, 0)
        Me.tlpLayout.Controls.Add(Me.lblDescription, 2, 0)
        Me.tlpLayout.Controls.Add(Me.lblRuntime, 3, 0)
        Me.tlpLayout.Controls.Add(Me.lblAvailable, 4, 0)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 3
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(563, 277)
        Me.tlpLayout.TabIndex = 0
        '
        'nudID
        '
        Me.nudID.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudID.Enabled = False
        Me.nudID.Location = New System.Drawing.Point(3, 43)
        Me.nudID.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudID.Name = "nudID"
        Me.nudID.Size = New System.Drawing.Size(56, 20)
        Me.nudID.TabIndex = 0
        '
        'txtTitle
        '
        Me.txtTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitle.Location = New System.Drawing.Point(65, 43)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(155, 20)
        Me.txtTitle.TabIndex = 1
        '
        'rtfDescription
        '
        Me.rtfDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfDescription.Location = New System.Drawing.Point(226, 43)
        Me.rtfDescription.Name = "rtfDescription"
        Me.rtfDescription.Size = New System.Drawing.Size(209, 191)
        Me.rtfDescription.TabIndex = 2
        Me.rtfDescription.Text = ""
        '
        'chkAvailable
        '
        Me.chkAvailable.AutoSize = True
        Me.chkAvailable.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkAvailable.Location = New System.Drawing.Point(503, 43)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Size = New System.Drawing.Size(57, 14)
        Me.chkAvailable.TabIndex = 3
        Me.chkAvailable.UseVisualStyleBackColor = True
        '
        'nudLength
        '
        Me.nudLength.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLength.Location = New System.Drawing.Point(441, 43)
        Me.nudLength.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLength.Name = "nudLength"
        Me.nudLength.Size = New System.Drawing.Size(56, 20)
        Me.nudLength.TabIndex = 4
        '
        'cmdOk
        '
        Me.cmdOk.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdOk.Location = New System.Drawing.Point(503, 251)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(57, 23)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblID.Location = New System.Drawing.Point(3, 27)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(56, 13)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "ID"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTitle.Location = New System.Drawing.Point(65, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(155, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Title"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDescription.Location = New System.Drawing.Point(226, 27)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(209, 13)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description"
        '
        'lblRuntime
        '
        Me.lblRuntime.AutoSize = True
        Me.lblRuntime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblRuntime.Location = New System.Drawing.Point(441, 14)
        Me.lblRuntime.Name = "lblRuntime"
        Me.lblRuntime.Size = New System.Drawing.Size(56, 26)
        Me.lblRuntime.TabIndex = 9
        Me.lblRuntime.Text = "Runtime (Minutes)"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAvailable.Location = New System.Drawing.Point(503, 27)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(57, 13)
        Me.lblAvailable.TabIndex = 10
        Me.lblAvailable.Text = "Available"
        '
        'frmVideoEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 277)
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "frmVideoEdit"
        Me.Text = "Data Manager"
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nudID As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents rtfDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents chkAvailable As System.Windows.Forms.CheckBox
    Friend WithEvents nudLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblRuntime As System.Windows.Forms.Label
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
End Class
