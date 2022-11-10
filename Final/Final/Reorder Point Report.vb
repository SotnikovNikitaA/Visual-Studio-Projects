'MIS 322
'Nikita Sotnikov 
'Final
'04/06/2021

Option Explicit On
Option Strict Off
Public Class Reorder_Point_Report
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub Reorder_Point_Report_Activate(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Transfer all info to the second form
        rppTextBox.Clear()
        rppTextBox.Text = y.ToString
    End Sub
End Class