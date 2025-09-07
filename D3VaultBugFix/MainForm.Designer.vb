<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BugFixForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BrowseSaveFile = New Button()
        SaveFileLocation = New TextBox()
        SaveFileLabel = New Label()
        FixSaveFile = New Button()
        ResultsLabel = New Label()
        SuspendLayout()
        ' 
        ' BrowseSaveFile
        ' 
        BrowseSaveFile.Location = New Point(578, 63)
        BrowseSaveFile.Margin = New Padding(3, 4, 3, 4)
        BrowseSaveFile.Name = "BrowseSaveFile"
        BrowseSaveFile.Size = New Size(133, 31)
        BrowseSaveFile.TabIndex = 0
        BrowseSaveFile.Text = "Browse"
        BrowseSaveFile.UseVisualStyleBackColor = True
        ' 
        ' SaveFileLocation
        ' 
        SaveFileLocation.Location = New Point(33, 63)
        SaveFileLocation.Margin = New Padding(3, 4, 3, 4)
        SaveFileLocation.Name = "SaveFileLocation"
        SaveFileLocation.Size = New Size(502, 27)
        SaveFileLocation.TabIndex = 1
        ' 
        ' SaveFileLabel
        ' 
        SaveFileLabel.AutoSize = True
        SaveFileLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SaveFileLabel.Location = New Point(33, 31)
        SaveFileLabel.Name = "SaveFileLabel"
        SaveFileLabel.Size = New Size(88, 28)
        SaveFileLabel.TabIndex = 2
        SaveFileLabel.Text = "Save File"
        ' 
        ' FixSaveFile
        ' 
        FixSaveFile.Font = New Font("Segoe UI", 14F)
        FixSaveFile.Location = New Point(33, 132)
        FixSaveFile.Margin = New Padding(3, 4, 3, 4)
        FixSaveFile.Name = "FixSaveFile"
        FixSaveFile.Size = New Size(144, 83)
        FixSaveFile.TabIndex = 6
        FixSaveFile.Text = "Fix Save File"
        FixSaveFile.UseVisualStyleBackColor = True
        ' 
        ' ResultsLabel
        ' 
        ResultsLabel.AutoSize = True
        ResultsLabel.Location = New Point(363, 157)
        ResultsLabel.Name = "ResultsLabel"
        ResultsLabel.Size = New Size(172, 40)
        ResultsLabel.TabIndex = 7
        ResultsLabel.Text = "Select Save File Location" & vbCrLf & "Click Fix Save File"
        ResultsLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BugFixForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(787, 266)
        Controls.Add(ResultsLabel)
        Controls.Add(FixSaveFile)
        Controls.Add(SaveFileLabel)
        Controls.Add(SaveFileLocation)
        Controls.Add(BrowseSaveFile)
        Margin = New Padding(3, 4, 3, 4)
        Name = "BugFixForm"
        Text = "D3VaultBugFix"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BrowseSaveFile As Button
    Friend WithEvents SaveFileLocation As TextBox
    Friend WithEvents SaveFileLabel As Label
    Friend WithEvents FixSaveFile As Button
    Friend WithEvents ResultsLabel As Label

End Class
