Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNumberFormat_Click(sender As Object, e As EventArgs) Handles btnNumberFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("n")
        lblResult.Text = strResult

    End Sub

    Private Sub btnFixedPointFormat_Click(sender As Object, e As EventArgs) Handles btnFixedPointFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("f")
        lblResult.Text = strResult
    End Sub

    Private Sub btnExponentialFormat_Click(sender As Object, e As EventArgs) Handles btnExponentialFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("e")
        lblResult.Text = strResult
    End Sub

    Private Sub btnCurrencyFormat_Click(sender As Object, e As EventArgs) Handles btnCurrencyFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("c")
        lblResult.Text = strResult
    End Sub

    Private Sub btnPercentFormat_Click(sender As Object, e As EventArgs) Handles btnPercentFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("p")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortDateFormat_Click(sender As Object, e As EventArgs) Handles btnShortDateFormat.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("d")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongDateFormat_Click(sender As Object, e As EventArgs) Handles btnLongDateFormat.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("D")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortTimeFormat_Click(sender As Object, e As EventArgs) Handles btnShortTimeFormat.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("t")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongTimeFormat_Click(sender As Object, e As EventArgs) Handles btnLongTimeFormat.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("T")
        lblResult.Text = strResult
    End Sub

    Private Sub btnFullDateTimeFormat_Click(sender As Object, e As EventArgs) Handles btnFullDateTimeFormat.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("F")
        lblResult.Text = strResult
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
