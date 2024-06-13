<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEpochUnixConvert
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
        lblResposta = New Label()
        lblEnvio = New Label()
        txbResposta = New TextBox()
        txbEnvio = New TextBox()
        SuspendLayout()
        ' 
        ' lblResposta
        ' 
        lblResposta.AutoSize = True
        lblResposta.Location = New Point(12, 161)
        lblResposta.Name = "lblResposta"
        lblResposta.Size = New Size(54, 15)
        lblResposta.TabIndex = 9
        lblResposta.Text = "Resposta"
        ' 
        ' lblEnvio
        ' 
        lblEnvio.AutoSize = True
        lblEnvio.Location = New Point(12, 13)
        lblEnvio.Name = "lblEnvio"
        lblEnvio.Size = New Size(36, 15)
        lblEnvio.TabIndex = 8
        lblEnvio.Text = "Envio"
        ' 
        ' txbResposta
        ' 
        txbResposta.Location = New Point(12, 179)
        txbResposta.Multiline = True
        txbResposta.Name = "txbResposta"
        txbResposta.Size = New Size(776, 127)
        txbResposta.TabIndex = 7
        ' 
        ' txbEnvio
        ' 
        txbEnvio.Location = New Point(12, 31)
        txbEnvio.Multiline = True
        txbEnvio.Name = "txbEnvio"
        txbEnvio.Size = New Size(776, 127)
        txbEnvio.TabIndex = 5
        ' 
        ' frmEpochUnixConvert
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 319)
        Controls.Add(lblResposta)
        Controls.Add(lblEnvio)
        Controls.Add(txbResposta)
        Controls.Add(txbEnvio)
        Name = "frmEpochUnixConvert"
        Text = "frmEpochUnixConvert"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblResposta As Label
    Friend WithEvents lblEnvio As Label
    Friend WithEvents txbResposta As TextBox
    Friend WithEvents txbEnvio As TextBox
End Class
