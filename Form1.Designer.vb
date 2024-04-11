<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl1 = New Label()
        Label1 = New Label()
        KMIni = New TextBox()
        Label2 = New Label()
        MTIni = New TextBox()
        MTFim = New TextBox()
        KMFim = New TextBox()
        Label3 = New Label()
        txbResult = New TextBox()
        Label4 = New Label()
        Calcular = New Button()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Location = New Point(12, 9)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(41, 15)
        lbl1.TabIndex = 0
        lbl1.Text = "KM Ini"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 1
        Label1.Text = "KM Fim"
        ' 
        ' KMIni
        ' 
        KMIni.Location = New Point(12, 27)
        KMIni.Name = "KMIni"
        KMIni.Size = New Size(139, 23)
        KMIni.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 3
        Label2.Text = "MT Ini"
        ' 
        ' MTIni
        ' 
        MTIni.Location = New Point(157, 27)
        MTIni.Name = "MTIni"
        MTIni.Size = New Size(139, 23)
        MTIni.TabIndex = 4
        ' 
        ' MTFim
        ' 
        MTFim.Location = New Point(157, 71)
        MTFim.Name = "MTFim"
        MTFim.Size = New Size(139, 23)
        MTFim.TabIndex = 6
        ' 
        ' KMFim
        ' 
        KMFim.Location = New Point(12, 71)
        KMFim.Name = "KMFim"
        KMFim.Size = New Size(139, 23)
        KMFim.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(157, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 7
        Label3.Text = "MT Fim"
        ' 
        ' txbResult
        ' 
        txbResult.Location = New Point(302, 27)
        txbResult.Multiline = True
        txbResult.Name = "txbResult"
        txbResult.Size = New Size(486, 170)
        txbResult.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(302, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 9
        Label4.Text = "Calculo"
        ' 
        ' Calcular
        ' 
        Calcular.Location = New Point(672, 238)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(116, 43)
        Calcular.TabIndex = 10
        Calcular.Text = "Calcular"
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 293)
        Controls.Add(Calcular)
        Controls.Add(Label4)
        Controls.Add(txbResult)
        Controls.Add(Label3)
        Controls.Add(MTFim)
        Controls.Add(KMFim)
        Controls.Add(MTIni)
        Controls.Add(Label2)
        Controls.Add(KMIni)
        Controls.Add(Label1)
        Controls.Add(lbl1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KMIni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MTIni As TextBox
    Friend WithEvents MTFim As TextBox
    Friend WithEvents KMFim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbResult As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Calcular As Button

End Class
