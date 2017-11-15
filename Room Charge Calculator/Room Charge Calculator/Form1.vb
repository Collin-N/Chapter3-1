Public Class Form1

  
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        lblStatus.Text = String.Empty
        Try
            decRoomCharges = CDec(txtNights.Text) * CDec(TxtNightCharges.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")
            decAddCharges = CDec(TxtRoomService.Text) + CDec(TxtTelephone.Text) + CDec(txtMisc.Text)
            lblAdditionalCharges.Text = decAddCharges.ToString("c")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")

    End Sub
End Class
