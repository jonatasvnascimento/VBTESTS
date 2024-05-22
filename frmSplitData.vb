Public Class frmSplitData
    Private Sub Executar_Click(sender As Object, e As EventArgs) Handles Executar.Click
        Dim ds As String = "22/05/2024"
        Dim CompData As Date = DateSerial(CInt(ds.Substring(6, 4)), CInt(ds.Substring(3, 2)), CInt(ds.Substring(0, 2))).AddHours(CInt(ds.Substring(11, 2)))

        txtResult.Text = CompData.ToString

    End Sub
End Class