'MIS 322
'Nikita Sotnikov W01493818
'LAP-3
'22/04/2021

Option Explicit On
Option Strict On

Public Class Form1
    'Declare error message variable
    Dim message, nuc As String

    Private Sub sButton_Click(sender As Object, e As EventArgs) Handles sButton.Click
        'Clean the field 
        sTextBox.Clear()
        'Declare variables for calculations
        Dim avel, prob As Double
        Dim durat, counter, load As Integer
        Dim random As New Random
        'Many error traps
        Try
            If arTextBox.Text = "" Then
                message = "Arrival rate field is empty"
                MessageBox.Show(message, "Empty Space Error")
                Exit Sub
            ElseIf Convert.ToDouble(arTextBox.Text) < 0 Then
                message = "Arrival rate not allow to be negative"
                MessageBox.Show(message, "Format Error")
                Exit Sub
            End If

            If srTextBox.Text = "" Then
                message = "Service rate field is empty"
                MessageBox.Show(message, "Empty Space Error")
                Exit Sub
            ElseIf Convert.ToDouble(srTextBox.Text) < 0 Then
                message = "Service rate not allow to be negative"
                MessageBox.Show(message, "Format Error")
                Exit Sub
            End If
        Catch fe As FormatException
            message = "Arrival or service rate not input as a numbers"
            MessageBox.Show(message, "Format Error")
            Exit Sub
        End Try

        Try
            durat = Convert.ToInt32(InputBox("Enter the number of periods for the simulation", "Simulation Duration", "8"))
            If durat < 0 Then
                message = "Duration not allow to be less then zero"
                MessageBox.Show(message, "Format Error")
                Exit Sub
            End If
        Catch fe As FormatException
            message = "Duration not input as a number"
            MessageBox.Show(message, "Format Error")
            Exit Sub
        End Try

        'If everything is OK so the calculations begin

        avel = Convert.ToDouble(arTextBox.Text) ^ 2 / (Convert.ToDouble(srTextBox.Text) * (Convert.ToDouble(srTextBox.Text) - Convert.ToDouble(arTextBox.Text)))
        prob = 1 - (Convert.ToDouble(arTextBox.Text) / Convert.ToDouble(srTextBox.Text))

        'Display the text

        sTextBox.Text = "***Line Analysis***" & vbNewLine & "- Average Line Lingth = " & avel.ToString("N3") & vbNewLine &
        sTextBox.Text + "- Probability No Customers = " & prob.ToString("P3") & vbNewLine & vbNewLine &
        sTextBox.Text + "=== Customer Simulation ===" & vbNewLine

        'Loop until all result will shown
        Do While counter < durat
            counter = counter + 1

            If slTextBox.Text = "" Then
                message = "Service load field is empty"
                MessageBox.Show(message, "Empty Space Error")
                Exit Sub
            ElseIf slTextBox.Text.ToUpper = "LIGHT" Then
                load = random.Next(0, 6)
            ElseIf slTextBox.Text.ToUpper = "MEDIUM" Then
                load = random.Next(6, 11)
            ElseIf slTextBox.Text.ToUpper = "HEAVY" Then
                load = random.Next(11, 16)
            End If

            nuc = "Period " & counter & " Number of Customers: " & load & vbNewLine
            sTextBox.Text += nuc
        Loop
    End Sub

    Private Sub rButton_Click(sender As Object, e As EventArgs) Handles rButton.Click
        'Reset form
        arTextBox.Clear()
        srTextBox.Clear()
        slTextBox.Clear()
        sTextBox.Clear()
    End Sub

    Private Sub cButton_Click(sender As Object, e As EventArgs) Handles cButton.Click
        'Close the application
        Me.Close()
    End Sub
End Class
