'MIS 322
'Nikita Sotnikov W01493818
'LAP 4
'06/05/2021

Option Explicit On
Option Strict On

Public Class MainForm
    'Declare a variables 
    Dim em, frek, wid, qua, sizu, widu, c1, d1, sa1, sp1 As String
    Dim cost, disc, subt, tax, tot, c, d, sa, sp As Double
    Dim size As Integer
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'With load application show a numbers
        cCheckBox.Text += cas.ToString("c2")
        dCheckBox.Text += dre.ToString("c2")
        saCheckBox.Text += san.ToString("c2")
        spCheckBox.Text += spo.ToString("c2")
    End Sub

    Private Sub sfButton_Click(sender As Object, e As EventArgs) Handles sfButton.Click
        'Error traps and also discount if everything is correct
        If mRadioButton.Checked = False And qRadioButton.Checked = False And eRadioButton.Checked = False And aRadioButton.Checked = False Then
            MessageBox.Show("Choose the frequency", "Choice Error")
            Exit Sub
        ElseIf mRadioButton.Checked = True Then
            frek = "Monthly "
            disc = 0.2
        ElseIf qRadioButton.Checked = True Then
            frek = "Quarterly "
            disc = 0.15
        ElseIf eRadioButton.Checked = True Then
            frek = "Every Six Months "
            disc = 0.1
        ElseIf aRadioButton.Checked = True Then
            frek = "Anually "
            disc = 0
        End If

        'Error trap for style checkboxes
        If cCheckBox.Checked = False And dCheckBox.Checked = False And saCheckBox.Checked = False And spCheckBox.Checked = False Then
            MessageBox.Show("Choose the shoe style", "Choice Error")
            Exit Sub
        End If

        'Give a value if all is OK
        If cCheckBox.Checked = True Then
            c = cas
        Else
            c = 0
        End If

        If dCheckBox.Checked = True Then
            d = dre
        Else
            d = 0
        End If

        If saCheckBox.Checked = True Then
            sa = san
        Else
            sa = 0
        End If

        If spCheckBox.Checked = True Then
            sp = spo
        Else
            sp = 0
        End If

        'Calculate the cost
        cost = c + d + sa + sp

        'More error traps
        Try
            size = Convert.ToInt32(ssTextBox.Text)
            If size < 5 Or size > 15 Then
                MessageBox.Show("Limit is reached", "Min 5 - Max 15")
                Exit Sub
            End If
        Catch fe As FormatException
            em = "Shoe size must be a number"
            MessageBox.Show(em, "Format Error")
            Exit Sub
        Catch ex As Exception
            em = ex.Message
            MessageBox.Show(em, "System Error")
            Exit Sub
        End Try

        'Error traps for size
        If meRadioButton.Checked = False And wRadioButton.Checked = False Then
            MessageBox.Show("Choose men's or women's")
            Exit Sub
        ElseIf wRadioButton.Checked Then
            sizu = "Size: Women's " & size & widu & vbNewLine
        ElseIf meRadioButton.Checked Then
            sizu = "Size: Men's " & size & widu & vbNewLine
        End If

        'Check the text ib width
        wid = wTextBox.Text

        Select Case wid.ToUpper
            Case "NARROW"
                widu = " Narrow"
            Case "STANDARD"
                widu = " Standard"
            Case "WIDE"
                widu = " Wide"
            Case Else
                MessageBox.Show("Choose one of three widths")
                Exit Sub
        End Select

        'Value for text of summary
        If cCheckBox.Checked Then
            c1 = "*" & cCheckBox.Text & vbNewLine
        Else
            c1 = ""
        End If

        If dCheckBox.Checked Then
            d1 = "*" & dCheckBox.Text & vbNewLine
        Else
            d1 = ""
        End If

        If saCheckBox.Checked Then
            sa1 = "*" & saCheckBox.Text & vbNewLine
        Else
            sa1 = ""
        End If


        If spCheckBox.Checked Then
            sp1 = "*" & spCheckBox.Text & vbNewLine
        Else
            sp1 = ""
        End If

        'Error traps for empty fields
        If ssTextBox.Text = "" Then
            MessageBox.Show("Shoe size should be enter")
            Exit Sub
        ElseIf wTextBox.Text = "" Then
            MessageBox.Show("Width should be enter")
            Exit Sub
        End If

        'Starting summary text
        qua = frek & " Order Delivery" & vbNewLine & c1 + d1 + sa1 + sp1

        'Calculation
        subt = cost - cost * disc
        tax = cost * 0.1
        tot = subt + tax

        'All summary text
        summary = qua & vbNewLine & sizu & "Shoe Cost: " & cost.ToString("c2") & vbNewLine
        summary += "Discount: " & (cost * disc).ToString("c2") & vbNewLine
        summary += "Subtotal: " & subt.ToString("c2") & vbNewLine
        summary += "Tax Amount: " & tax.ToString("c2") & vbNewLine
        summary += "========================" & vbNewLine
        summary += "Total Due: " & tot.ToString("c2")

        'Show second form
        SummaryForm.ShowDialog()
    End Sub

    Private Sub rfButton_Click(sender As Object, e As EventArgs) Handles rfButton.Click
        'Clear all form
        mRadioButton.Checked = False
        qRadioButton.Checked = False
        eRadioButton.Checked = False
        aRadioButton.Checked = False
        cCheckBox.Checked = False
        dCheckBox.Checked = False
        saCheckBox.Checked = False
        spCheckBox.Checked = False
        ssTextBox.Clear()
        wTextBox.Clear()
        meRadioButton.Checked = False
        wRadioButton.Checked = False
    End Sub

    Private Sub cfButton_Click(sender As Object, e As EventArgs) Handles cfButton.Click
        'Close the form
        Me.Close()
    End Sub
End Class
