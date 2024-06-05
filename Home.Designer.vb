<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        ListBox1 = New ListBox()
        btnCalculoKM = New Button()
        btnSplitData = New Button()
        btnSubstringFileName = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(185, 424)
        ListBox1.TabIndex = 0
        ' 
        ' btnCalculoKM
        ' 
        btnCalculoKM.Location = New Point(203, 12)
        btnCalculoKM.Name = "btnCalculoKM"
        btnCalculoKM.Size = New Size(134, 40)
        btnCalculoKM.TabIndex = 1
        btnCalculoKM.Text = "CalculoKM"
        btnCalculoKM.UseVisualStyleBackColor = True
        ' 
        ' btnSplitData
        ' 
        btnSplitData.Location = New Point(203, 58)
        btnSplitData.Name = "btnSplitData"
        btnSplitData.Size = New Size(134, 40)
        btnSplitData.TabIndex = 2
        btnSplitData.Text = "SplitData"
        btnSplitData.UseVisualStyleBackColor = True
        ' 
        ' btnSubstringFileName
        ' 
        btnSubstringFileName.Location = New Point(203, 104)
        btnSubstringFileName.Name = "btnSubstringFileName"
        btnSubstringFileName.Size = New Size(134, 40)
        btnSubstringFileName.TabIndex = 3
        btnSubstringFileName.Text = "SubstringFileName"
        btnSubstringFileName.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubstringFileName)
        Controls.Add(btnSplitData)
        Controls.Add(btnCalculoKM)
        Controls.Add(ListBox1)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnCalculoKM As Button
    Friend WithEvents btnSplitData As Button
    Friend WithEvents btnSubstringFileName As Button
End Class
