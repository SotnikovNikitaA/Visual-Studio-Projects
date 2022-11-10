'MIS 322
'Nikita Sotnikov W01493818
'LAP 4
'06/05/2021

Option Explicit On
Option Strict On

Public Class SummaryForm
    Private Sub SummaryForm_Activate(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Show the summary of previous form
        osTextBox.Text = summary
    End Sub

    Private Sub coButton_Click(sender As Object, e As EventArgs) Handles coButton.Click
        'Show the confirmation message and close the program
        MessageBox.Show("Your order has been confirmed", "Confirmation")
        Me.Close()
    End Sub

    Private Sub bButton_Click(sender As Object, e As EventArgs) Handles bButton.Click
        'Close the program
        Me.Close()
    End Sub
End Class