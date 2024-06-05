<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubstringGetFileName
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
        txbEnvio = New TextBox()
        btnCortar = New Button()
        txbResposta = New TextBox()
        lblEnvio = New Label()
        lblResposta = New Label()
        SuspendLayout()
        ' 
        ' txbEnvio
        ' 
        txbEnvio.Location = New Point(12, 27)
        txbEnvio.Multiline = True
        txbEnvio.Name = "txbEnvio"
        txbEnvio.Size = New Size(776, 127)
        txbEnvio.TabIndex = 0
        ' 
        ' btnCortar
        ' 
        btnCortar.Location = New Point(641, 308)
        btnCortar.Name = "btnCortar"
        btnCortar.Size = New Size(147, 49)
        btnCortar.TabIndex = 1
        btnCortar.Text = "Cortar"
        btnCortar.UseVisualStyleBackColor = True
        ' 
        ' txbResposta
        ' 
        txbResposta.Location = New Point(12, 175)
        txbResposta.Multiline = True
        txbResposta.Name = "txbResposta"
        txbResposta.Size = New Size(776, 127)
        txbResposta.TabIndex = 2
        ' 
        ' lblEnvio
        ' 
        lblEnvio.AutoSize = True
        lblEnvio.Location = New Point(12, 9)
        lblEnvio.Name = "lblEnvio"
        lblEnvio.Size = New Size(36, 15)
        lblEnvio.TabIndex = 3
        lblEnvio.Text = "Envio"
        ' 
        ' lblResposta
        ' 
        lblResposta.AutoSize = True
        lblResposta.Location = New Point(12, 157)
        lblResposta.Name = "lblResposta"
        lblResposta.Size = New Size(54, 15)
        lblResposta.TabIndex = 4
        lblResposta.Text = "Resposta"
        ' 
        ' frmSubstringGetFileName
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 369)
        Controls.Add(lblResposta)
        Controls.Add(lblEnvio)
        Controls.Add(txbResposta)
        Controls.Add(btnCortar)
        Controls.Add(txbEnvio)
        Name = "frmSubstringGetFileName"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSubstringGetFileName"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txbEnvio As TextBox
    Friend WithEvents btnCortar As Button
    Friend WithEvents txbResposta As TextBox
    Friend WithEvents lblEnvio As Label
    Friend WithEvents lblResposta As Label
End Class
