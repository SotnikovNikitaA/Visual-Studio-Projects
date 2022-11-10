'MIS 322
'Nikita Sotnikov W01493818
'CP1
'22/04/2021

Option Explicit On
Option Strict On

Public Class Form1
    'Declare all variables for future calculations and for error messsages
    Dim time As Integer = 0
    Dim errorMessage, times As String

    Private Sub ftButton_Click(sender As Object, e As EventArgs) Handles ftButton.Click
        'First Time choice button change color when pushed and give value for variable
        ftButton.BackColor = Color.Yellow
        stButton.BackColor = Color.Gainsboro
        ttButton.BackColor = Color.Gainsboro
        time = 1
    End Sub

    Private Sub stButton_Click(sender As Object, e As EventArgs) Handles stButton.Click
        'Second Time choice button change color when pushed and give value for variable
        stButton.BackColor = Color.Yellow
        ftButton.BackColor = Color.Gainsboro
        ttButton.BackColor = Color.Gainsboro
        time = 2
    End Sub

    Private Sub ttButton_Click(sender As Object, e As EventArgs) Handles ttButton.Click
        'Third Time choice button change color when pushed and give value for variable
        ttButton.BackColor = Color.Yellow
        stButton.BackColor = Color.Gainsboro
        ftButton.BackColor = Color.Gainsboro
        time = 3
    End Sub

    Private Sub tcButton_Click(sender As Object, e As EventArgs) Handles tcButton.Click
        'Declare all variables for calculation and errors
        Dim corni, squal, sum, discsum, groscost As Double
        Dim disc As Double = 1
        Dim numa, numk, totpeop As Integer
        Dim c, s, errorMessage As String

        'Several error messages for each incorrect input
        Select Case time
            Case 0
                errorMessage = "Choose the time"
                MessageBox.Show(errorMessage, "Choice Error")
                Exit Sub
            Case 1
                times = "3:00 PM"
            Case 2
                times = "5:00 PM"
            Case 3
                times = "7:00 PM"
        End Select

        If nTextBox.Text = "" Then
            errorMessage = "Name Text Box can not be empty"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If pTextBox.Text = "" Then
            errorMessage = "Phone Text Box can not be empty"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If dTextBox.Text = "" Then
            errorMessage = "Date Text Box can not be empty"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If cTextBox.Text = "" Then
            errorMessage = "Cornwall Text Box can not be empty"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If sTextBox.Text = "" Then
            errorMessage = "Squallicum Text Box can not be empty"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If naTextBox.Text = "" Then
            errorMessage = "Number of adults Text Box can not be empty"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If nkTextBox.Text = "" Then
            errorMessage = "Number of Kids Text Box can not be empty"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        'If input is correct the next line give a new value for variables

        c = cTextBox.Text
        s = sTextBox.Text

        If c.ToUpper = "YES" Then
            cTextBox.Text = StrConv(c, vbProperCase)
            corni = 1
        ElseIf c.ToUpper = "NO" Then
            cTextBox.Text = StrConv(c, vbProperCase)
            corni = 0
        Else
            errorMessage = "Choose Yes or No for Cornwall"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If s.ToUpper = "YES" Then
            sTextBox.Text = StrConv(s, vbProperCase)
            squal = 3
        ElseIf s.ToUpper = "NO" Then
            sTextBox.Text = StrConv(s, vbProperCase)
            squal = 0
        Else
            errorMessage = "Choose Yes or No for Squallicum"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End If

        If c.ToUpper = "NO" And s.ToUpper = "NO" Then
            errorMessage = "Choose one of the parks"
            MessageBox.Show(errorMessage, "Logical Error")
            Exit Sub
        End If

        'In tour can not be less than 1 adult
        Try
            If Convert.ToInt32(naTextBox.Text) < 1 Then
                errorMessage = "Should be at least one adults"
                MessageBox.Show(errorMessage, "Format Error")
                Exit Sub
            ElseIf Convert.ToInt32(naTextBox.Text) > 1 Then
                numa = Convert.ToInt32(naTextBox.Text)
            End If
        Catch fe As FormatException
            errorMessage = "Number of adults is not input as numbers"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try

        'In tour can not be more than 8 kids
        Try
            If Convert.ToInt32(nkTextBox.Text) < 0 Then
                errorMessage = "Number of kids can not be negative"
                MessageBox.Show(errorMessage, "Format Error")
                Exit Sub
            ElseIf Convert.ToInt32(nkTextBox.Text) > 8 Then
                errorMessage = "Number of kids reached the max number"
                MessageBox.Show(errorMessage, "Overflow Error")
                Exit Sub
            ElseIf Convert.ToInt32(nkTextBox.Text) > 0 Then
                numk = Convert.ToInt32(nkTextBox.Text)
            End If
        Catch fe As FormatException
            errorMessage = "Number of kids is not input as numbers"
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try

        'Calculate number of people for tour
        totpeop = numa + numk

        If totpeop > 12 Then
            errorMessage = "Reach maximum people for the tour"
            MessageBox.Show(errorMessage, "Overflow Error")
            Exit Sub
        ElseIf totpeop > 4 Then
            disc = 0.8
        End If

        'Calculate gross cost, discount and summary
        groscost = (((corni + squal) * numa) + (((corni + squal) / 2) * numk))
        sum = (((corni + squal) * numa) + (((corni + squal) / 2) * numk)) * disc
        discsum = (((corni + squal) * numa) + (((corni + squal) / 2) * numk)) * (1 - disc)

        'Display summary to user
        rs2Label.Text = "Name: " & nTextBox.Text & vbNewLine & "Phone: " & pTextBox.Text & vbNewLine & "Date: " & dTextBox.Text & vbNewLine &
        rs2Label.Text + "Time: " & times & vbNewLine & "Cornwall Park: " & cTextBox.Text & vbNewLine & "Squallicum Park: " & sTextBox.Text & vbNewLine &
        rs2Label.Text + "# of Adults: " & naTextBox.Text & vbNewLine & "# of Kids: " & nkTextBox.Text & vbNewLine & "Gross Cost: " & groscost.ToString("C2") & vbNewLine &
        rs2Label.Text + "Discount: " & discsum.ToString("C2") & vbNewLine & "Total Amount: " & sum.ToString("C2")
    End Sub

    Private Sub rfButton_Click(sender As Object, e As EventArgs) Handles rfButton.Click
        'Reset the form
        nTextBox.Clear()
        pTextBox.Clear()
        dTextBox.Clear()
        ftButton.BackColor = Color.Gainsboro
        stButton.BackColor = Color.Gainsboro
        ttButton.BackColor = Color.Gainsboro
        time = 0
        cTextBox.Clear()
        sTextBox.Clear()
        naTextBox.Clear()
        nkTextBox.Clear()
        rs2Label.Text = ""
    End Sub

    Private Sub eButton_Click(sender As Object, e As EventArgs) Handles eButton.Click
        'Close the application
        Me.Close()
    End Sub

End Class
