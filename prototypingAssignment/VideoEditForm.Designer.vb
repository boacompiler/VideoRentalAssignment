<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoEditForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDownID = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.RichTextBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.CheckBoxAvailable = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownLength = New System.Windows.Forms.NumericUpDown()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDownID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.03491!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66837!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.22449!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.03732!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.03491!))
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDownID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxTitle, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxDescription, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxAvailable, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDownLength, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnOk, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(563, 277)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NumericUpDownID
        '
        Me.NumericUpDownID.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDownID.Enabled = False
        Me.NumericUpDownID.Location = New System.Drawing.Point(3, 43)
        Me.NumericUpDownID.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownID.Name = "NumericUpDownID"
        Me.NumericUpDownID.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDownID.TabIndex = 0
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTitle.Location = New System.Drawing.Point(65, 43)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxTitle.TabIndex = 1
        '
        'RichTextBoxDescription
        '
        Me.RichTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxDescription.Location = New System.Drawing.Point(226, 43)
        Me.RichTextBoxDescription.Name = "RichTextBoxDescription"
        Me.RichTextBoxDescription.Size = New System.Drawing.Size(209, 191)
        Me.RichTextBoxDescription.TabIndex = 2
        Me.RichTextBoxDescription.Text = ""
        '
        'CheckBoxAvailable
        '
        Me.CheckBoxAvailable.AutoSize = True
        Me.CheckBoxAvailable.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBoxAvailable.Location = New System.Drawing.Point(503, 43)
        Me.CheckBoxAvailable.Name = "CheckBoxAvailable"
        Me.CheckBoxAvailable.Size = New System.Drawing.Size(57, 14)
        Me.CheckBoxAvailable.TabIndex = 3
        Me.CheckBoxAvailable.UseVisualStyleBackColor = True
        '
        'NumericUpDownLength
        '
        Me.NumericUpDownLength.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDownLength.Location = New System.Drawing.Point(441, 43)
        Me.NumericUpDownLength.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDownLength.Name = "NumericUpDownLength"
        Me.NumericUpDownLength.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDownLength.TabIndex = 4
        '
        'BtnOk
        '
        Me.BtnOk.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnOk.Location = New System.Drawing.Point(503, 251)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(57, 23)
        Me.BtnOk.TabIndex = 5
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(65, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(226, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(441, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Runtime (Minutes)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(503, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Available"
        '
        'VideoEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 277)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "VideoEditForm"
        Me.Text = "VideoEditForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDownID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NumericUpDownID As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxTitle As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBoxDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBoxAvailable As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
