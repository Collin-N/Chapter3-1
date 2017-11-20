Public Class Form1

    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        Dim dblScore1, dblScore2, dblScore3 As Double
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0
        Dim dblAverage As Double
        Try

            dblScore1 = txtScore1.Text
            dblScore2 = txtScore2.Text
            dblScore3 = txtScore3.Text
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES
            lblAverage.Text = CStr(dblAverage)
            If dblAverage <= 100 And dblAverage >= 81 Then
                lblGrade.Text = "A"
            ElseIf dblAverage <= 80 And dblAverage >= 71 Then
                lblGrade.Text = "B"
            ElseIf dblAverage <= 70 And dblAverage >= 66 Then
                lblGrade.Text = "C"
            ElseIf dblAverage <= 65 Then
                lblGrade.Text = "F"
            Else
                lblGrade.Text = "Invalid Score"
            End If
            If dblAverage >= dblHIGH_SCORE Then
                lblNotes.Text = "congradulations! Great Job"
            Else
                lblNotes.Text = "Keep Trying"
            End If
        Catch ex As Exception

            lblNotes.Text = "all input boxes must be filled and scores must be numeric"
            txtScore1.Clear()
            txtScore2.Clear()
            txtScore3.Clear()
            lblNotes.Text = String.Empty
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = String.Empty
        lblNotes.Text = String.Empty
        lblGrade.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
