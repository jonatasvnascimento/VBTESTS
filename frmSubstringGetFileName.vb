Public Class frmSubstringGetFileName
    Dim nomeFileSave = "ftp://Kjonatas@192.168.90.92/2024/06/05/11/Putting On The Ritz - Freedom Trail Studio.mp3"
    Private Sub frmSubstringGetFileName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbEnvio.Text = nomeFileSave
    End Sub
    Private Sub btnCortar_Click(sender As Object, e As EventArgs) Handles btnCortar.Click
        Try
            Dim nameFile = nomeFileSave.substring(nomeFileSave.LastIndexOf("/") + 1)
            Dim posicaoUltimaBarra As Integer = nomeFileSave.LastIndexOf("/"c) + 1

            Dim link As String = "ftp://Kjonatas@192.168.90.92/Call%20teste/2024/06/05/11/Putting On The Ritz - Freedom Trail Studio.mp3"

            Dim linkDesescapado As String = Uri.UnescapeDataString(link)
            Dim posicaoUltimaBarras As Integer = linkDesescapado.LastIndexOf("/"c)
            Dim caminhoFTP As String = linkDesescapado.Substring(0, posicaoUltimaBarras + 1)
            Dim nomeArquivo As String = linkDesescapado.Substring(posicaoUltimaBarras + 1)

            Dim link1 As String = "C:\Users\jonat\Downloads\teste.mp3"
            Dim linkDesescapado1 As String = Uri.UnescapeDataString(link1)
            Dim posicaoUltimaBarras1 As Integer = linkDesescapado1.LastIndexOf("\"c)
            Dim caminhoFTP1 As String = linkDesescapado1.Substring(0, posicaoUltimaBarras1 + 1)
            Dim nomeArquivo1 As String = linkDesescapado1.Substring(posicaoUltimaBarras1 + 1)



            txbResposta.Text = nameFile
            txbResposta.Text += Environment.NewLine
            txbResposta.Text += nomeFileSave.substring(0, posicaoUltimaBarra)
            txbResposta.Text += Environment.NewLine
            txbResposta.Text += caminhoFTP
            txbResposta.Text += Environment.NewLine
            txbResposta.Text += nomeArquivo
            txbResposta.Text += Environment.NewLine
            txbResposta.Text += caminhoFTP1
            txbResposta.Text += Environment.NewLine
            txbResposta.Text += nomeArquivo1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txbEnvio_TextChanged(sender As Object, e As EventArgs) Handles txbEnvio.TextChanged
        nomeFileSave = txbEnvio.Text
    End Sub
End Class