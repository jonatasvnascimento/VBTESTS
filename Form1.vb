Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMIni.Text = 0
        MTIni.Text = 0
        KMFim.Text = 0
        MTFim.Text = 0
    End Sub
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Try
            Dim kIni As String = KMIni.Text
            Dim mIni As String = MTIni.Text
            Dim kfim As String = KMFim.Text
            Dim mFin As String = MTFim.Text

            Dim kIniCal As Single = CInt(kIni.ToString()) + (CInt(mIni.ToString()) / 1000)
            Dim kFimCal As Single = CInt(kfim.ToString()) + (CInt(mFin.ToString()) / 1000)

            txbResult.Text = ""
            txbResult.Text += $"KMIni: {CDbl(kIniCal)} - KMFim: {CDbl(kFimCal)}"
        Catch ex As Exception
            MessageBox.Show("Erro ao calcular KM")
        End Try
    End Sub


End Class
