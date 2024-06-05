Public Class frmSubstringGetFileName
    Dim nomeFileSave = "ftp://Kjonatas@192.168.90.92/teste/Body of Water - TrackTribe.mp3"
    Private Sub frmSubstringGetFileName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbEnvio.Text = nomeFileSave
    End Sub
    Private Sub btnCortar_Click(sender As Object, e As EventArgs) Handles btnCortar.Click
        Try
            Dim nameFile = nomeFileSave.substring(nomeFileSave.LastIndexOf("/") + 1)
            txbResposta.Text = nameFile
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txbEnvio_TextChanged(sender As Object, e As EventArgs) Handles txbEnvio.TextChanged
        nomeFileSave = txbEnvio.Text
    End Sub
End Class