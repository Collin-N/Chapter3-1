Public Class Form1

    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        TxtClassB.Clear()
        txtClassC.Clear()
        lblClassA.Text = " "
        lblClassB.Text = " "
        lblClassC.Text = " "
        lblTotal.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
