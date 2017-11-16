Public Class Form1

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim dblResult As Double
        dblResult = CDbl(txtNumberOfMiles.Text) / CDbl(txtGallonsOfGas.Text)
        lblMilesPerGallon.Text = CStr(dblResult)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallonsOfGas.Clear()
        txtNumberOfMiles.Clear()
        lblMilesPerGallon.Text = " "

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
