Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl11Pro.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblGalaxy.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblPixel.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt11Pro.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtGalaxy.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtPixel.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        '1) Variables
        Dim int11Pro As Integer
        Dim intGalaxy As Integer
        Dim intPixel As Integer
        Dim sngOrder As Single
        Const TAX As Single = 1.12
        Const PRO As Single = 1379
        Const GALAXY As Single = 1459
        Const PIXEL As Single = 1129

        '2) Set values
        int11Pro = Val(txt11Pro.Text)
        intGalaxy = Val(txtGalaxy.Text)
        intPixel = Val(txtPixel.Text)

        '3) Calculate
        int11Pro = PRO * int11Pro
        intGalaxy = GALAXY * intGalaxy
        intPixel = PIXEL * intPixel

        '4) Display
        sngOrder = int11Pro + intGalaxy + intPixel

        lblSub.Text = "Subtotal: $" & sngOrder
        lblTotal.Text = "Total: $" & sngOrder * TAX



    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblSub.Click

    End Sub
End Class
