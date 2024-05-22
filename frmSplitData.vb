Public Class frmSplitData
    Private Sub Executar_Click(sender As Object, e As EventArgs) Handles Executar.Click
        Try
            Dim ds As String = "22/05/2024"
            Dim CompData As Date = DateSerial(CInt(ds.Substring(6, 4)), CInt(ds.Substring(3, 2)), CInt(ds.Substring(0, 2)))

            Dim data As DateTime = DateTime.ParseExact(ds, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            Dim CompDatas As Date = New Date(data.Year, data.Month, data.Day)

            txtResult.Text = CompData.ToString
            txtResult.Text += vbCrLf + CompDatas.ToString
        Catch ex As Exception
            Dim erro As String = "Erro: " + ex.ToString()
            txtResult.Text = erro
        End Try


    End Sub
End Class