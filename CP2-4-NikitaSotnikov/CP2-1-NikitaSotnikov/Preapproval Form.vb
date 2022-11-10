'MIS 322
'Nikita Sotnikov 
'CP2-4 W01493818
'27/05/2021

Option Explicit On
Option Strict On

Public Class Preapproval_Form
    Private Sub Preapproval_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adding current user and permission level to the form
        cu1Label.Text = curuse
        pl1Label.Text = perm.ToString
    End Sub
    Private Sub CloseFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseFormToolStripMenuItem.Click
        'Close second application
        Me.Close()
    End Sub

    Private Sub ExitProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProgramToolStripMenuItem.Click
        'Close first application
        SignInForm.Close()
    End Sub

    Private Sub CheckPreapprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckPreapprovalToolStripMenuItem.Click
        'Replace method for $ sign
        pvTextBox.Text = Replace(pvTextBox.Text, "$", "")
        dpTextBox.Text = Replace(dpTextBox.Text, "$", "")
        iTextBox.Text = Replace(iTextBox.Text, "$", "")
        tTextBox.Text = Replace(tTextBox.Text, "$", "")
        irTextBox.Text = Replace(irTextBox.Text, "$", "")
        'Error catch also give variables a values
        Try
            prov = Convert.ToDouble(pvTextBox.Text)
            dop = Convert.ToDouble(dpTextBox.Text)
            inc = Convert.ToDouble(iTextBox.Text)
            term = Convert.ToDouble(tTextBox.Text)
            term = term * 12
            inr = Convert.ToDouble(irTextBox.Text)
            If prov < 0 Or dop < 0 Or inc < 0 Or term < 0 Or inr < 0 Then
                MessageBox.Show("Input correct numbers", "Format Error")
                Exit Sub
            End If
        Catch fe As FormatException
            MessageBox.Show("Input correct numbers", "Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error")
            Exit Sub
        End Try

        If wRadioButton.Checked Then
            st = "Washington"
        ElseIf oRadioButton.Checked Then
            st = "Oregon"
        ElseIf cRadioButton.Checked Then
            st = "California"
        Else
            MessageBox.Show("Choose the state", "Choice Error")
            Exit Sub
        End If

        'Checked the inputs to approve or denied
        If LoanApproval(prov, dop, inc, term, inr, st) = True Then
            MessageBox.Show("Loan Approved")
        Else
            MessageBox.Show("Loan Denied")
        End If
    End Sub

End Class