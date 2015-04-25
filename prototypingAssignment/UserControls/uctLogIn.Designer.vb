<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctLogIn
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
        Me.components = New System.ComponentModel.Container()
        Me.tlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.tlpLabel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VideoDatabaseDataSet = New prototypingAssignment.VideoDatabaseDataSet()
        Me.UsersTableAdapter = New prototypingAssignment.VideoDatabaseDataSetTableAdapters.UsersTableAdapter()
        Me.tlpLayout.SuspendLayout()
        Me.tlpLogin.SuspendLayout()
        Me.tlpLabel.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideoDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 3
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.tlpLayout.Controls.Add(Me.tlpLogin, 1, 1)
        Me.tlpLayout.Controls.Add(Me.lblPrompt, 1, 0)
        Me.tlpLayout.Controls.Add(Me.tlpLabel, 0, 1)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 3
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.tlpLayout.Size = New System.Drawing.Size(531, 497)
        Me.tlpLayout.TabIndex = 1
        '
        'tlpLogin
        '
        Me.tlpLogin.ColumnCount = 2
        Me.tlpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLogin.Controls.Add(Me.txtUserName, 0, 0)
        Me.tlpLogin.Controls.Add(Me.txtPassword, 0, 1)
        Me.tlpLogin.Controls.Add(Me.cmdLogin, 1, 1)
        Me.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogin.Location = New System.Drawing.Point(102, 96)
        Me.tlpLogin.Name = "tlpLogin"
        Me.tlpLogin.RowCount = 2
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLogin.Size = New System.Drawing.Size(325, 304)
        Me.tlpLogin.TabIndex = 0
        '
        'txtUserName
        '
        Me.tlpLogin.SetColumnSpan(Me.txtUserName, 2)
        Me.txtUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUserName.Location = New System.Drawing.Point(3, 129)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(319, 20)
        Me.txtUserName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPassword.Location = New System.Drawing.Point(3, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtPassword.TabIndex = 1
        '
        'cmdLogin
        '
        Me.cmdLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdLogin.Location = New System.Drawing.Point(165, 155)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(157, 23)
        Me.cmdLogin.TabIndex = 2
        Me.cmdLogin.Text = "Log In"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPrompt.Location = New System.Drawing.Point(102, 80)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(325, 13)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Please Enter Your Account Information"
        '
        'tlpLabel
        '
        Me.tlpLabel.ColumnCount = 1
        Me.tlpLabel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabel.Controls.Add(Me.lblUserName, 0, 0)
        Me.tlpLabel.Controls.Add(Me.lblPassword, 0, 2)
        Me.tlpLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLabel.Location = New System.Drawing.Point(3, 96)
        Me.tlpLabel.Name = "tlpLabel"
        Me.tlpLabel.RowCount = 3
        Me.tlpLabel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLabel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpLabel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLabel.Size = New System.Drawing.Size(93, 304)
        Me.tlpLabel.TabIndex = 2
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserName.Location = New System.Drawing.Point(3, 134)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(87, 13)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Username:"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPassword.Location = New System.Drawing.Point(3, 157)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.VideoDatabaseDataSet
        '
        'VideoDatabaseDataSet
        '
        Me.VideoDatabaseDataSet.DataSetName = "VideoDatabaseDataSet"
        Me.VideoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'logInControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "logInControl"
        Me.Size = New System.Drawing.Size(531, 497)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        Me.tlpLogin.ResumeLayout(False)
        Me.tlpLogin.PerformLayout()
        Me.tlpLabel.ResumeLayout(False)
        Me.tlpLabel.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideoDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpLogin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VideoDatabaseDataSet As prototypingAssignment.VideoDatabaseDataSet
    Friend WithEvents UsersTableAdapter As prototypingAssignment.VideoDatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents tlpLabel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label

End Class
