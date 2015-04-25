<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.VideoDatabaseDataSet = New prototypingAssignment.VideoDatabaseDataSet()
        Me.VideosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VideosTableAdapter = New prototypingAssignment.VideoDatabaseDataSetTableAdapters.VideosTableAdapter()
        CType(Me.VideoDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VideoDatabaseDataSet
        '
        Me.VideoDatabaseDataSet.DataSetName = "VideoDatabaseDataSet"
        Me.VideoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VideosBindingSource
        '
        Me.VideosBindingSource.DataMember = "Videos"
        Me.VideosBindingSource.DataSource = Me.VideoDatabaseDataSet
        '
        'VideosTableAdapter
        '
        Me.VideosTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 369)
        Me.Name = "frmMain"
        Me.Text = "Video Rental"
        CType(Me.VideoDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VideoDatabaseDataSet As prototypingAssignment.VideoDatabaseDataSet
    Friend WithEvents VideosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VideosTableAdapter As prototypingAssignment.VideoDatabaseDataSetTableAdapters.VideosTableAdapter

End Class
