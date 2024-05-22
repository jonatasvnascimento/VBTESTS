<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplitData
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
        Executar = New Button()
        Label4 = New Label()
        txtResult = New TextBox()
        SuspendLayout()
        ' 
        ' Executar
        ' 
        Executar.Location = New Point(672, 207)
        Executar.Name = "Executar"
        Executar.Size = New Size(116, 43)
        Executar.TabIndex = 21
        Executar.Text = "Executar"
        Executar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 20
        Label4.Text = "Data"
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(12, 31)
        txtResult.Multiline = True
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(776, 170)
        txtResult.TabIndex = 19
        ' 
        ' frmSplitData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 261)
        Controls.Add(Executar)
        Controls.Add(Label4)
        Controls.Add(txtResult)
        Name = "frmSplitData"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSplitData"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Executar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResult As TextBox
End Class
