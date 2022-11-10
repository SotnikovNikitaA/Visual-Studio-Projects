'MIS 322
'Nikita Sotnikov W01493818
'LAP 5
'18/05/2021

Option Explicit On
Option Strict On

Public Class OutputForm

    Private Sub OutputForm_Activate(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Start the process
        MonteCarloSim()
    End Sub

    Private Sub RerunSimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RerunSimToolStripMenuItem.Click
        'Rerun the process
        MonteCarloSim()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Close the form
        Me.Close()
    End Sub
    'Create independent process
    Private Sub MonteCarloSim()
        Do While count < numot
            num = random.Next(1, 1001)
            num = num / 10
            bol = ProductDefect(num)
            test = ProductInspection(num, bol)
            If test = "found defect" Then
                idd = idd + 1
            ElseIf test = "missed defect" Then
                dep = dep + 1
            ElseIf test = "false positive" Then
                falp = falp + 1
            ElseIf test = "no defect" Then
                gop = gop + 1
            End If
            count = count + 1
        Loop

        pmTextBox.Text = numot.ToString
        gpTextBox.Text = gop.ToString
        dpTextBox.Text = dep.ToString
        idTextBox.Text = idd.ToString
        fpTextBox.Text = falp.ToString
    End Sub
End Class