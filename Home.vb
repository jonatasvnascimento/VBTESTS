Imports System.Runtime.CompilerServices

Public Class Home
    Private Sub btnCalculoKM_Click(sender As Object, e As EventArgs) Handles btnCalculoKM.Click
        frmCalculoKM.Show()
    End Sub

    Private Sub btnSplitData_Click(sender As Object, e As EventArgs) Handles btnSplitData.Click
        frmSplitData.Show()
    End Sub

    Private Sub btnSubstringFileName_Click(sender As Object, e As EventArgs) Handles btnSubstringFileName.Click
        frmSubstringGetFileName.Show()
    End Sub

    Private Sub btnEpochUnix_Click(sender As Object, e As EventArgs) Handles btnEpochUnix.Click
        frmEpochUnixConvert.Show()
    End Sub
End Class