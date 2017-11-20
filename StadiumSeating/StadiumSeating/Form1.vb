Public Class Form1

    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        Dim dblClassA, dblClassB, dblClassC, dblTotal As Double
        Dim numberOfTickets1, numberOfTickets2, numberOfTickets3 As Double
        Try
            numberOfTickets1 = CDbl(txtClassA.Text)
            numberOfTickets2 = CDbl(TxtClassB.Text)
            numberOfTickets3 = CDbl(txtClassC.Text)
            dblClassA = numberOfTickets1 * 15
            dblClassB = numberOfTickets2 * 12
            dblClassC = numberOfTickets3 * 9
            dblTotal = dblClassA + dblClassB + dblClassC
            lblClassA.Text = CStr(dblClassA)
            lblClassB.Text = CStr(dblClassB)
            lblClassC.Text = CStr(dblClassC)
            lblTotal.Text = CStr(dblTotal)
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
            txtClassA.Clear()
            TxtClassB.Clear()
            txtClassC.Clear()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        TxtClassB.Clear()
        txtClassC.Clear()
        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
