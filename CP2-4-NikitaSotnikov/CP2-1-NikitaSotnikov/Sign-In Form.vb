'MIS 322
'Nikita Sotnikov 
'CP2-4 W01493818
'27/05/2021

Option Explicit On
Option Strict Off

Public Class SignInForm
    Private Sub PreapprovalChackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreapprovalChackToolStripMenuItem.Click
        'Show second application if permission granted
        If perm >= 1 Then
            Preapproval_Form.ShowDialog()
        Else
            MessageBox.Show("Access denied")
            Me.Close()
        End If
    End Sub

    Private Sub ClientDataReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientDataReportToolStripMenuItem.Click
        'Show third application if permission granted
        If perm >= 2 Then
            Approval_Report_Form.ShowDialog()
        Else MessageBox.Show("Access denied")
            Me.Close()
        End If

    End Sub

    Private Sub TblAuthenticationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblAuthenticationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblAuthenticationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AuthenticationDataSet)

    End Sub

    Private Sub SignInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuthenticationDataSet.tblAuthentication' table. You can move, or remove it, as needed.
        Me.TblAuthenticationTableAdapter.Fill(Me.AuthenticationDataSet.tblAuthentication)

    End Sub
    '
    Private Sub LogOut()
        'Make Logout statements
        usnam = ""
        pas = ""
        perm = 0
        uTextBox.Clear()
        pTextBox.Clear()
    End Sub

    Private Sub LogIn()
        'Declare variable and give value for future use in login functions
        Dim indicator As Integer = 0

        usnam = uTextBox.Text

        Select Case usnam.ToUpper
            Case "DEANNADUNSON"
                usnam = "DeannaDunson"
            Case "MOHAMMEDHUSSEIN"
                usnam = "MohammedHussein"
            Case "KENIAKISTLER"
                usnam = "KeniaKistler"
            Case "JASMINEGOODMAN"
                usnam = "JasmineGoodman"
            Case "XIOAFENGLI"
                usnam = "XioafengLi"
            Case "TERINATOMAN"
                usnam = "TerinaToman"
            Case "PRADEEPGUPTA"
                usnam = "PradeepGupta"
            Case "CATHARINECHIVERS"
                usnam = "CatharineChivers"
            Case "LIBBYLEMMONS"
                usnam = "LibbyLemmons"
            Case "JOSEGARCIA"
                usnam = "JoseGarcia"
        End Select

        pas = pTextBox.Text
        For Each myRow In AuthenticationDataSet.tblAuthentication.Rows
            If myRow.item("UserName") = usnam And myRow.item("Password") = pas Then
                perm = myRow.item("PermissionLevel")
                curuse = myRow.item("UserName")
                cu1Label.Text = curuse
                pl1Label.Text = perm
                indicator = 1
            End If
        Next

        If indicator = 0 Then
            MessageBox.Show("No match was found")
            LogOut()
        End If
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        'Call login procedure
        LogIn()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        'Call login procedure
        LogOut()
    End Sub

End Class
