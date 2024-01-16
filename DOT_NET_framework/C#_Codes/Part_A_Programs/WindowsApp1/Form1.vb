Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim netpay As Double
        Dim gross As Double
        Dim week, hour, sun, sat, sathour, sunhour As Double
        Dim dec, tax As Double
        week = Convert.ToDouble(txtweek.Text) * 125
        sun = Convert.ToDouble(txtsat.Text) * 80
        sat = Convert.ToDouble(txtsun.Text) * 160
        hour = Convert.ToDouble(txthrweek.Text) * 180
        sathour = Convert.ToDouble(txthrsat.Text) * 30
        sunhour = Convert.ToDouble(txtharsun.Text) * 30
        gross = (week + hour + sun + sat + sathour + sunhour)
        dec = gross * (10 / 100)
        tax = gross * (15 / 100)
        netpay = gross - tax - dec
        txtgross.Text = Convert.ToString(gross)
        txtdec.Text = Convert.ToString(dec)
        txttax.Text = Convert.ToString(tax)
        total.Text = Convert.ToString(netpay)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
