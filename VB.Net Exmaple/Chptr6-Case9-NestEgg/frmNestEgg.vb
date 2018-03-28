'Program: Start Saving Your Nest Egg
'Devleoper: Anthony Milisci
'Date: 2-8-2018
'Purpose: To calculate how much the user would have in their "next egg" after a certain amount of years


Public Class frmNestEgg
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declaring variables
        Dim decTotal As Decimal
        Dim decInterest As Decimal
        Dim decDownPayment As Decimal
        Dim intYears As Int32

        'Clears previous outputted data
        lstSavings.Items.Clear()
        'Is the value numeric?
        If IsNumeric(txtDownpament.Text) And IsNumeric(txtInterest.Text) And IsNumeric(txtYears.Text) Then
            Try
                'Assign values to vairables
                decInterest = Convert.ToDecimal(txtInterest.Text)
                decDownPayment = Convert.ToDecimal(txtDownpament.Text)
                intYears = Convert.ToInt32(txtYears.Text)
                decInterest = decInterest / 100
                If decInterest <= 1 And decDownPayment <= 999999999.99 Then
                    decTotal = decDownPayment
                    'Calculates savings for 10 years
                    For intYears = 1 To intYears Step 1
                        lstSavings.Items.Add(decTotal.ToString("C"))
                        decTotal *= (1 + decInterest)
                    Next
                Else
                    MsgBox("Please input a higher interest rate/ lower downpayment.",, "Input Error")
                End If
            Catch ex As Exception
                MsgBox("Please input valid values.",, "Input Error")
            End Try
        Else
            MsgBox("Please input numeric values.",, "Input Error")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the window
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clears all outputted data
        lstSavings.Items.Clear()
        txtDownpament.Text = ""
        txtInterest.Text = ""
        txtYears.Text = ""
    End Sub
End Class
