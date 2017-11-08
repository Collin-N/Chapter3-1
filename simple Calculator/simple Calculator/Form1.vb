Public Class form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim dblResult As Double
        lblOperation.Text = " + "
        dblResult = CDbl(txtNum1.Text) + CDbl(txtNum2.Text)
        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim dblResult As Double
        lblOperation.Text = " - "
        dblResult = CDbl(txtNum1.Text) - CDbl(txtNum2.Text)
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        Dim dblResult As Double
        lblOperation.Text = " * "
        dblResult = CDbl(txtNum1.Text) * CDbl(txtNum2.Text)
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim dblResult As Double
        lblOperation.Text = " / "
        dblResult = CDbl(txtNum1.Text) / CDbl(txtNum2.Text)
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Dim dblResult As Double
        lblOperation.Text = " ^ "
        dblResult = CDbl(txtNum1.Text) ^ CDbl(txtNum2.Text)
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dblResult As Integer
        lblOperation.Text = " Mod "
        dblResult = CDbl(txtNum1.Text) Mod CDbl(txtNum2.Text)
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Text = " "
        txtNum2.Text = " "
        lblResult.Text = "         "
        lblOperation.Text = "Operation: "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
