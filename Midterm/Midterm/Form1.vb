'MIS 322
'Nikita Sotnikov W01493818
'Midterm
'29/04/2021

Option Explicit On
Option Strict On

Public Class Form1
    'Declare Variables for all code
    Dim qua As Integer = 1
    Dim ln As Integer = 0
    Dim em As String
    Dim ap As Double = 1
    Dim smp, tc, apl, bp As Double
    Dim cur As String = "NEW"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Give a first value to quantity
        qTextBox.Text = qua.ToString
    End Sub

    Private Sub aoButton_Click(sender As Object, e As EventArgs) Handles aoButton.Click
        'Set first error trap
        If qua > 0 And qua < 12 Then
            qua += 1
            qTextBox.Text = qua.ToString
        ElseIf qua = 12 Then
            em = "Quantity limit is 12"
            MessageBox.Show(em, "Format Error")
            Exit Sub
        End If
    End Sub

    Private Sub soButton_Click(sender As Object, e As EventArgs) Handles soButton.Click
        'Set second error trap
        If qua <= 1 Then
            em = "Minimum quantity is 1"
            MessageBox.Show(em, "Format Error")
            Exit Sub
        ElseIf qua >= 1 Then
            qua -= 1
            qTextBox.Text = qua.ToString
        End If
    End Sub
    Private Sub atlButton_Click(sender As Object, e As EventArgs) Handles atlButton.Click
        'Declare variable for text
        Dim sm, user, alltext As String
        sm = smTextBox.Text
        bp = Convert.ToDouble(bpTextBox.Text)
        'Set several error traps
        If idTextBox.Text = "" Then
            em = "Item description text box can not be empty"
            MessageBox.Show(em, "Format Error")
            Exit Sub
        End If

        Try
            If bp.ToString = "" Then
                em = "Base prise text box can not be empty"
                MessageBox.Show(em, "Format Error")
                Exit Sub
            ElseIf bp <= 0 Then
                em = "Base price should be more than 0"
                MessageBox.Show(em, "Format Error")
                Exit Sub
            End If
        Catch oe As OverflowException
            em = "Base price is too big"
            MessageBox.Show(em, "Overflow Error")
            Exit Sub
        Catch fe As FormatException
            em = "Base price must be a number"
            MessageBox.Show(em, "Format Error")
            Exit Sub
        Catch ex As Exception
            em = ex.Message
            MessageBox.Show(em, "System Error")
            Exit Sub
        End Try

        'Give a value for two case selection
        Select Case sm.ToUpper
            Case ""
                em = "Choose the shipping method"
                MessageBox.Show(em, "Format Error")
                Exit Sub
            Case "STANDARD"
                sm = "Standard"
                smp = 5.95
            Case "PRIORITY"
                sm = "Priority"
                smp = 8.95
            Case "EXPRESS"
                sm = "Express"
                smp = 12.95
            Case Else
                em = "Choose the correct shipping method"
                MessageBox.Show(em, "Format Error")
                Exit Sub
        End Select
        'Make inputbox for variable
        user = Convert.ToString(InputBox("Enter the condition of the items as NEW, USED or SALVAGE", "Item Condition", cur))
        Select Case user.ToUpper
            Case ""
                em = "Item condition can not be empty"
                MessageBox.Show(em, "Format Error")
                Exit Sub
            Case "NEW"
                ap = 1
                cur = "New"
            Case "USED"
                ap = 0.75
                cur = "Used"
            Case "SALVAGE"
                ap = 0.25
                cur = "Salvage"
            Case Else
                em = "Choose the correct item condition"
                MessageBox.Show(em, "Format Error")
                Exit Sub
        End Select
        'Make calculations
        apl = ap * bp
        tc = apl * qua * smp
        ln += 1
        'Show summary for lots
        alltext = "* Lot " & ln.ToString & vbNewLine
        alltext += idTextBox.Text & vbNewLine
        alltext += bpLabel.Text & " " & bp.ToString("C2") & vbNewLine
        alltext += "Adjusted Price: " & apl.ToString("C2") & vbNewLine
        alltext += qLabel.Text & " " & qTextBox.Text & vbNewLine
        alltext += smLabel.Text & " " & sm.ToString & vbNewLine
        alltext += "Shipping Cost: " & smp.ToString("C2") & vbNewLine
        alltext += "Total Cost: " & tc.ToString("C2") & vbNewLine
        alltext += "---------------------------------" & vbNewLine & vbNewLine
        alTextBox.AppendText(alltext)
    End Sub

    Private Sub rfButton_Click(sender As Object, e As EventArgs) Handles rfButton.Click
        'Reset form
        idTextBox.Clear()
        qTextBox.Clear()
        bpTextBox.Clear()
        smTextBox.Clear()
        alTextBox.Clear()
        ln = 0
        idTextBox.Focus()
    End Sub

    Private Sub eButton_Click(sender As Object, e As EventArgs) Handles eButton.Click
        'Close the application
        Me.Close()
    End Sub
End Class
