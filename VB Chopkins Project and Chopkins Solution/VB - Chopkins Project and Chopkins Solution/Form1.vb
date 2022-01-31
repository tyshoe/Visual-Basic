Public Class Form1
    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Me.Close()
    End Sub

    Private Sub Calculate_btn_Click(sender As Object, e As EventArgs) Handles Calculate_btn.Click
        Dim num1, num2, num3 As Integer
        Dim total_price, total_packs As Double

        ' this will prevent error if empty or string in cell
        Integer.TryParse(TextBox1.Text, num1)
        Integer.TryParse(TextBox2.Text, num2)
        Integer.TryParse(TextBox3.Text, num3)

        total_price = (num1 * 14.99) + (num2 * 6.99) + (num3 * 2.5)
        total_packs = (num1 * 12) + (num2 * 5) + (num3 * 2)

        ' standard format specifiers
        ' https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings?redirectedfrom=MSDN
        Label5.Text = total_packs.ToString("N0")
        Label6.Text = total_price.ToString("C")
    End Sub
End Class
