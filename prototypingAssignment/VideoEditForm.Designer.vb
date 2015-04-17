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
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDownID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDownID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxTitle, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxDescription, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBoxAvailable, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDownLength, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnOk, 4, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(563, 256)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NumericUpDownID
        '
        Me.NumericUpDownID.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDownID.Enabled = False
        Me.NumericUpDownID.Location = New System.Drawing.Point(3, 88)
        Me.NumericUpDownID.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownID.Name = "NumericUpDownID"
        Me.NumericUpDownID.Size = New System.Drawing.Size(44, 20)
        Me.NumericUpDownID.TabIndex = 0
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTitle.Location = New System.Drawing.Point(53, 88)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxTitle.TabIndex = 1
        '
        'RichTextBoxDescription
        '
        Me.RichTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxDescription.Location = New System.Drawing.Point(216, 88)
        Me.RichTextBoxDescription.Name = "RichTextBoxDescription"
        Me.RichTextBoxDescription.Size = New System.Drawing.Size(212, 79)
        Me.RichTextBoxDescription.TabIndex = 2
        Me.RichTextBoxDescription.Text = ""
        '
        'CheckBoxAvailable
        '
        Me.CheckBoxAvailable.AutoSize = True
        Me.CheckBoxAvailable.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBoxAvailable.Location = New System.Drawing.Point(484, 88)
        Me.CheckBoxAvailable.Name = "CheckBoxAvailable"
        Me.CheckBoxAvailable.Size = New System.Drawing.Size(76, 17)
        Me.CheckBoxAvailable.TabIndex = 3
        Me.CheckBoxAvailable.Text = "Available"
        Me.CheckBoxAvailable.UseVisualStyleBackColor = True
        '
        'NumericUpDownLength
        '
        Me.NumericUpDownLength.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumericUpDownLength.Location = New System.Drawing.Point(434, 88)
        Me.NumericUpDownLength.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDownLength.Name = "NumericUpDownLength"
        Me.NumericUpDownLength.Size = New System.Drawing.Size(44, 20)
        Me.NumericUpDownLength.TabIndex = 4
        '
        'BtnOk
        '
        Me.BtnOk.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnOk.Location = New System.Drawing.Point(484, 230)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(76, 23)
        Me.BtnOk.TabIndex = 5
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'VideoEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 256)
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
End Class
