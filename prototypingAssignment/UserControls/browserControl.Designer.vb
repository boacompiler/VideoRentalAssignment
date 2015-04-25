<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AdminMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.tlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.grpVideo = New System.Windows.Forms.GroupBox()
        Me.tlpVideo = New System.Windows.Forms.TableLayoutPanel()
        Me.grpTechnical = New System.Windows.Forms.GroupBox()
        Me.tlpTechnical = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.AdminMenuStrip.SuspendLayout()
        Me.tlpLayout.SuspendLayout()
        Me.grpControls.SuspendLayout()
        Me.tlpControls.SuspendLayout()
        Me.grpVideo.SuspendLayout()
        Me.tlpVideo.SuspendLayout()
        Me.grpTechnical.SuspendLayout()
        Me.tlpTechnical.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminMenuStrip
        '
        Me.AdminMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.AdminMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AdminMenuStrip.Name = "AdminMenuStrip"
        Me.AdminMenuStrip.Size = New System.Drawing.Size(770, 24)
        Me.AdminMenuStrip.TabIndex = 0
        Me.AdminMenuStrip.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageDataToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'ManageDataToolStripMenuItem
        '
        Me.ManageDataToolStripMenuItem.Name = "ManageDataToolStripMenuItem"
        Me.ManageDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManageDataToolStripMenuItem.Text = "Manage Data"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(45, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Label1"
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.tlpVideo.SetColumnSpan(Me.lblBody, 2)
        Me.lblBody.Location = New System.Drawing.Point(3, 106)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(39, 13)
        Me.lblBody.TabIndex = 1
        Me.lblBody.Text = "Label2"
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdPrevious.Location = New System.Drawing.Point(3, 3)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(373, 22)
        Me.cmdPrevious.TabIndex = 2
        Me.cmdPrevious.Text = "Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdNext.Location = New System.Drawing.Point(382, 3)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(373, 22)
        Me.cmdNext.TabIndex = 3
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 1
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Controls.Add(Me.grpControls, 0, 2)
        Me.tlpLayout.Controls.Add(Me.grpVideo, 0, 1)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 3
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(770, 702)
        Me.tlpLayout.TabIndex = 5
        '
        'grpControls
        '
        Me.grpControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpControls.Controls.Add(Me.tlpControls)
        Me.grpControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpControls.Location = New System.Drawing.Point(3, 645)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(764, 54)
        Me.grpControls.TabIndex = 1
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Controls"
        '
        'tlpControls
        '
        Me.tlpControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpControls.ColumnCount = 2
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControls.Controls.Add(Me.cmdPrevious, 0, 0)
        Me.tlpControls.Controls.Add(Me.cmdNext, 1, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControls.Location = New System.Drawing.Point(3, 16)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 1
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.tlpControls.Size = New System.Drawing.Size(758, 35)
        Me.tlpControls.TabIndex = 0
        '
        'grpVideo
        '
        Me.grpVideo.Controls.Add(Me.tlpVideo)
        Me.grpVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpVideo.Location = New System.Drawing.Point(3, 23)
        Me.grpVideo.Name = "grpVideo"
        Me.grpVideo.Size = New System.Drawing.Size(764, 616)
        Me.grpVideo.TabIndex = 0
        Me.grpVideo.TabStop = False
        Me.grpVideo.Text = "Video"
        '
        'tlpVideo
        '
        Me.tlpVideo.ColumnCount = 2
        Me.tlpVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpVideo.Controls.Add(Me.lblTitle, 0, 0)
        Me.tlpVideo.Controls.Add(Me.lblBody, 0, 1)
        Me.tlpVideo.Controls.Add(Me.grpTechnical, 1, 0)
        Me.tlpVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpVideo.Location = New System.Drawing.Point(3, 16)
        Me.tlpVideo.Name = "tlpVideo"
        Me.tlpVideo.RowCount = 2
        Me.tlpVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpVideo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpVideo.Size = New System.Drawing.Size(758, 597)
        Me.tlpVideo.TabIndex = 0
        '
        'grpTechnical
        '
        Me.grpTechnical.Controls.Add(Me.tlpTechnical)
        Me.grpTechnical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTechnical.Location = New System.Drawing.Point(382, 3)
        Me.grpTechnical.Name = "grpTechnical"
        Me.grpTechnical.Size = New System.Drawing.Size(373, 100)
        Me.grpTechnical.TabIndex = 2
        Me.grpTechnical.TabStop = False
        Me.grpTechnical.Text = "Technical"
        '
        'tlpTechnical
        '
        Me.tlpTechnical.ColumnCount = 1
        Me.tlpTechnical.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTechnical.Controls.Add(Me.lblAvailability, 0, 0)
        Me.tlpTechnical.Controls.Add(Me.lblLength, 0, 1)
        Me.tlpTechnical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTechnical.Location = New System.Drawing.Point(3, 16)
        Me.tlpTechnical.Name = "tlpTechnical"
        Me.tlpTechnical.RowCount = 2
        Me.tlpTechnical.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTechnical.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTechnical.Size = New System.Drawing.Size(367, 81)
        Me.tlpTechnical.TabIndex = 0
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(3, 0)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(39, 13)
        Me.lblAvailability.TabIndex = 0
        Me.lblAvailability.Text = "Label1"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(3, 40)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(39, 13)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Text = "Label3"
        '
        'browserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AdminMenuStrip)
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "browserControl"
        Me.Size = New System.Drawing.Size(770, 702)
        Me.AdminMenuStrip.ResumeLayout(False)
        Me.AdminMenuStrip.PerformLayout()
        Me.tlpLayout.ResumeLayout(False)
        Me.grpControls.ResumeLayout(False)
        Me.tlpControls.ResumeLayout(False)
        Me.grpVideo.ResumeLayout(False)
        Me.tlpVideo.ResumeLayout(False)
        Me.tlpVideo.PerformLayout()
        Me.grpTechnical.ResumeLayout(False)
        Me.tlpTechnical.ResumeLayout(False)
        Me.tlpTechnical.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblBody As System.Windows.Forms.Label
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents ManageDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpVideo As System.Windows.Forms.GroupBox
    Friend WithEvents tlpVideo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents tlpControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpTechnical As System.Windows.Forms.GroupBox
    Friend WithEvents tlpTechnical As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAvailability As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label

End Class
