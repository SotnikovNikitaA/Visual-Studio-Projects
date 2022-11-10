'MIS 322
'Nikita Sotnikov 
'CP2-4 W01493818
'27/05/2021

Option Explicit On
Option Strict Off

Public Class Approval_Report_Form
    Dim zone As String = "{0,-7}{1,-20}{2,-15}{3,-10}"
    Private Sub CloseFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseFormToolStripMenuItem.Click
        'Close last application
        Me.Close()
    End Sub

    Private Sub ExitProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProgramToolStripMenuItem.Click
        'Close first application
        SignInForm.Close()
    End Sub

    Private Sub TblApplicationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblApplicationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblApplicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoanApplicationSecondDataSet)

    End Sub

    Private Sub Approval_Report_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adding statements to size of the form depends from permission level
        cusLabel.Text = curuse
        permLabel.Text = perm.ToString
        If perm = 3 Then
            Me.TblApplicationDataGridView.Visible = True
            'TODO: This line of code loads data into the 'LoanApplicationSecondDataSet.tblApplication' table. You can move, or remove it, as needed.
            Me.TblApplicationTableAdapter.Fill(Me.LoanApplicationSecondDataSet.tblApplication)
            Me.Size = New System.Drawing.Size(1276, 754)
            Me.MaximumSize = New System.Drawing.Size(1276, 754)
        Else
            Me.TblApplicationDataGridView.Visible = False
            Me.MaximumSize = New System.Drawing.Size(525, 445)
            Me.TblApplicationTableAdapter.Fill(Me.LoanApplicationSecondDataSet.tblApplication)
        End If
        BatchLoanApproval()
    End Sub
    Private Sub BatchLoanApproval()
        'Adding sub procedure to fill the text box according with database
        For Each myRow In LoanApplicationSecondDataSet.tblApplication.Rows
            Dim aprove As String
            prov = myRow.item("PropertyValue")
            dop = (myRow.item("PropertyValue") - myRow.item("LoanAmount"))
            inc = myRow.item("ClientIncome")
            term = myRow.item("TermInMonths")
            inr = myRow.item("AnnualInterestRate")
            st = myRow.item("PropertyState")
            If LoanApproval(prov, dop, inc, term, inr, st) = True Then
                aprove = "Approved"
            Else
                aprove = "Denied"
            End If
            ciTextBox.Text += String.Format(zone, myRow.item("ApplicationID"),
                                            myRow.item("ClientFirstName") & " " + myRow.item("ClientLastName"),
                                            myRow.item("PropertyState"),
                                            aprove) & vbNewLine
        Next
    End Sub
End Class