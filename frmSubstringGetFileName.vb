Public Class frmSubstringGetFileName
    Dim nomeFileSave = "ftp://Kjonatas@192.168.90.92/2024/06/05/11/Putting On The Ritz - Freedom Trail Studio.mp3"
    Private Sub frmSubstringGetFileName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbEnvio.Text = nomeFileSave
    End Sub
    Private Sub btnCortar_Click(sender As Object, e As EventArgs) Handles btnCortar.Click
        Try
            Dim nameFile = nomeFileSave.substring(nomeFileSave.LastIndexOf("/") + 1)
            Dim posicaoUltimaBarra As Integer = nomeFileSave.LastIndexOf("/"c) + 1


            txbResposta.Text = nameFile
            txbResposta.Text += Environment.NewLine
            txbResposta.Text += nomeFileSave.substring(0, posicaoUltimaBarra)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txbEnvio_TextChanged(sender As Object, e As EventArgs) Handles txbEnvio.TextChanged
        nomeFileSave = txbEnvio.Text
    End Sub
End Class