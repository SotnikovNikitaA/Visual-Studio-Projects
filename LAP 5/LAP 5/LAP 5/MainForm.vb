'MIS 322
'Nikita Sotnikov W01493818
'LAP 5
'18/05/2021

Option Explicit On
Option Strict On

Public Class MainForm
    Private Sub RunSimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunSimToolStripMenuItem.Click
        'Error catch
        Try
            numot = Convert.ToInt32(notTextBox.Text)
            defr = Convert.ToDouble(drTextBox.Text)
            testa = Convert.ToDouble(taTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Input correct numbers", "Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error")
            Exit Sub
        End Try

        If defr < 0 Or testa < 0 Or defr > 100 Or testa > 100 Then
            MessageBox.Show("Percent must be input from 0 to 100", "Format Error")
            Exit Sub
        End If
        'Show second form
        OutputForm.ShowDialog()
    End Sub

    Private Sub ResetSimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSimToolStripMenuItem.Click
        'Clear form
        numot = 0
        defr = 0
        testa = 0
        notTextBox.Clear()
        drTextBox.Clear()
        taTextBox.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the form
        Me.Close()
    End Sub
End Class
