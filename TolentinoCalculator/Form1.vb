Public Class Form1

    Dim _lahat As Double = 0
    Dim _check As Integer = 0

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
        _lahat = 0
        _check = 0
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        input.Text = ""
    End Sub



    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click

    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        Dim _total As String = total.Text
        Dim num As Integer = _total.Length
        Dim _lastOperation As Integer
        If num = 0 Then


        Else

            If (_total.Substring(_total.Length - 2) = "x ") Then
                _lahat = _lahat * Double.Parse(input.Text)
                _lastOperation = 1
            ElseIf (_total.Substring(_total.Length - 2) = "÷ ") Then
                _lahat = _lahat / Double.Parse(input.Text)
                _lastOperation = 2
            ElseIf (_total.Substring(_total.Length - 2) = "+ ") Then
                _lahat = _lahat + Double.Parse(input.Text)
                _lastOperation = 3
            ElseIf (_total.Substring(_total.Length - 2) = "- ") Then
                _lahat = _lahat - Double.Parse(input.Text)
                _lastOperation = 4
            Else
                If (_lastOperation = 1) Then
                    _lahat = _lahat * Double.Parse(input.Text)
                ElseIf (_lastOperation = 2) Then
                    _lahat = _lahat / Double.Parse(input.Text)
                ElseIf (_lastOperation = 3) Then
                    _lahat = _lahat + Double.Parse(input.Text)
                ElseIf (_lastOperation = 4) Then
                    _lahat = _lahat - Double.Parse(input.Text)
                End If

                MsgBox("Hello world")
            End If

            total.Text = total.Text + input.Text + " = "

            input.Text = _lahat
            _check = 1


        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Not (input.Text = "") Then

            If (_check = 1) Then
                Dim lahat As String = _lahat
                total.Text = ""
                total.Text = total.Text + lahat
                _check = 0
            Else

                total.Text = total.Text + input.Text

                'check if _lahat is empty
                If (_lahat = 0) Then
                    _lahat = Double.Parse(input.Text)
                Else
                    _lahat = _lahat + Double.Parse(input.Text)
                End If
            End If

            '_lahat = _lahat + Double.Parse(input.Text)

            total.Text = total.Text + " + "
            input.Text = ""
        End If


    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

        If Not (input.Text = "") Then

            '_lahat = _lahat - Double.Parse(input.Text)

            If (_check = 1) Then
                Dim lahat As String = _lahat
                total.Text = ""
                total.Text = total.Text + lahat
                _check = 0
            Else
                'check if _laht is empty
                If (_lahat = 0) Then
                    _lahat = Double.Parse(input.Text)
                Else
                    _lahat = _lahat - Double.Parse(input.Text)
                End If

                total.Text = total.Text + input.Text

            End If

            total.Text = total.Text + " - "
            input.Text = ""

        End If


    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        If Not (input.Text = "") Then

            If (_check = 1) Then
                Dim lahat As String = _lahat
                total.Text = ""
                total.Text = total.Text + lahat
                _check = 0
            Else
                'check if _laht is empty
                If (_lahat = 0) Then
                    _lahat = Double.Parse(input.Text)
                Else
                    _lahat = _lahat * Double.Parse(input.Text)
                End If

                total.Text = total.Text + input.Text
            End If

            '_lahat = _lahat * Double.Parse(input.Text)

            total.Text = total.Text + " x "
            input.Text = ""
        End If

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        If Not (input.Text = "") Then

            If (_check = 1) Then
                Dim lahat As String = _lahat
                total.Text = ""
                total.Text = total.Text + lahat
                _check = 0
            Else
                'check if _laht is empty
                If (_lahat = 0) Then
                    _lahat = Integer.Parse(input.Text)
                Else
                    _lahat = _lahat / Integer.Parse(input.Text)
                End If

                total.Text = total.Text + input.Text
            End If

            '_lahat = _lahat / Double.Parse(input.Text)

            total.Text = total.Text + " ÷ "
            input.Text = ""
        End If


    End Sub
End Class
