Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        input.Text = input.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        input.Text = input.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        input.Text = input.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        input.Text = input.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        input.Text = input.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        input.Text = input.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        input.Text = input.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        input.Text = input.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        input.Text = input.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        If input.Text = "" Then
            input.Text = ""
        Else
            input.Text = input.Text + "0"
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim _input As String = input.Text
        If _input = "" Then

        Else
            Dim _output As String = _input.Remove(_input.Length - 1, 1)
            input.Text = _output
        End If


    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        input.Text = ""
        total.Text = ""
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        input.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        total.Text = total.Text + input.Text + " + "
        input.Text = ""
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        total.Text = total.Text + input.Text + " - "
        input.Text = ""
    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click

    End Sub
End Class
