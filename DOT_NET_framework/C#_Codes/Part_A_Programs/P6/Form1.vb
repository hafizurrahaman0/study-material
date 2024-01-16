Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = "welcome visual studio world"
        Dim i As Integer
        i = Len(s)
        MsgBox(i)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        i = Asc("B")
        MsgBox(i)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As String
        i = Chr(66)
        MsgBox(i)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Boolean
        Dim s As String
        s = "welcome visual studio world"
        i = IsNumeric(s)
        MsgBox(i)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Boolean
        Dim s As String
        s = "30.56"
        i = IsNumeric(s)
        MsgBox(i)
        Dim decprice As Decimal
        decprice = CDec(s)
        MsgBox(decprice)
    End Sub
End Class
