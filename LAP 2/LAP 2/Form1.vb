'MIS 322
'Nikita Sotnikov W01493818
'LAP 2
'15/04/2021

Option Explicit On
Option Strict On

Public Class Form1
    'Declare a several constant for each currency, two variable for input and one for error message
    Const Euro As Double = 0.85
    Const Pound As Double = 0.722
    Const Yen As Double = 110.63
    Const Bitcoin As Double = 0.00002
    Dim amount As Double
    Dim Conv As Double
    Dim errorMessage As String

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        'Set three error traps and if all correct plus one hundred
        Try
            If amountTextBox.Text = "" Or conversionTextBox.Text = "" Then
                errorMessage = "One or both fields are empty"
                MessageBox.Show(errorMessage, "Empty Space Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) < 0 Then
                errorMessage = "Amount must be greater than or equal to zero"
                MessageBox.Show(errorMessage, "Negative Amount Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) > 0 Then
                amount = Convert.ToDouble(amountTextBox.Text)
                amount = amount + 100
                amountTextBox.Text = amount.ToString
            End If
        Catch fe As FormatException
            errorMessage = "Currency not entered as a number. Be certain to omit any symbols."
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        'Also set three error traps, but here if all good minus one hundred
        Try
            If amountTextBox.Text = "" Or conversionTextBox.Text = "" Then
                errorMessage = "One or both fields are empty"
                MessageBox.Show(errorMessage, "Empty Space Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) < 100 Then
                errorMessage = "Amount must be greater than or equal to zero"
                MessageBox.Show(errorMessage, "Negative Amount Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) > 100 Then
                amount = Convert.ToDouble(amountTextBox.Text)
                amount = amount - 100
                amountTextBox.Text = amount.ToString
            End If
        Catch fe As FormatException
            errorMessage = "Currency not entered as a number. Be certain to omit any symbols."
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try
    End Sub

    Private Sub convertcurrencyButton_Click(sender As Object, e As EventArgs) Handles convertcurrencyButton.Click
        'Declare variables for calculation
        Dim ameuro, ampound, amyen, ambit, efeur, efpound, efyen, efbit As Double

        'Give value for variable
        amount = Convert.ToDouble(amountTextBox.Text)
        amountTextBox.Text = amount.ToString
        Conv = Convert.ToDouble(conversionTextBox.Text)

        'Caculation and show all results
        Try
            If amountTextBox.Text = "" Or conversionTextBox.Text = "" Then
                errorMessage = "One or both fields are empty"
                MessageBox.Show(errorMessage, "Empty Space Error")
                Exit Sub
            ElseIf Convert.ToDouble(amountTextBox.Text) > 0 Then
                ereurosTextBox.Text = Euro.ToString("P3")
                erpoundsTextBox.Text = Pound.ToString("P3")
                eryenTextBox.Text = Yen.ToString("P3")
                erbitcoinTextBox.Text = Bitcoin.ToString("P3")

                efeur = (amount * Euro) * (Conv / 100)
                efeurosTextBox.Text = efeur.ToString("N2")
                ameuro = (amount * Euro) - efeur
                eurosamountTextBox.Text = ameuro.ToString("N2")

                efpound = (amount * Pound) * (Conv / 100)
                efpoundsTextBox.Text = efpound.ToString("N2")
                ampound = (amount * Pound) - efpound
                poundsamountTextBox.Text = ampound.ToString("N2")

                efyen = (amount * Yen) * (Conv / 100)
                efyenTextBox.Text = efyen.ToString("N2")
                amyen = (amount * Yen) - efyen
                yenamountTextBox.Text = amyen.ToString("N2")

                efbit = (amount * Bitcoin) * (Conv / 100)
                efbitcoinTextBox.Text = efbit.ToString("N2")
                ambit = (amount * Bitcoin) - efbit
                bitcoinamountTextBox.Text = ambit.ToString("N2")
            End If
        Catch fe As FormatException
            errorMessage = "Currency not entered as a number. Be certain to omit any symbols."
            MessageBox.Show(errorMessage, "Format Error")
            Exit Sub
        End Try
    End Sub

    Private Sub resetformButton_Click(sender As Object, e As EventArgs) Handles resetformButton.Click
        'Retern form the first view
        amountTextBox.Clear()
        conversionTextBox.Clear()
        eurosamountTextBox.Clear()
        poundsamountTextBox.Clear()
        yenamountTextBox.Clear()
        bitcoinamountTextBox.Clear()
        ereurosTextBox.Clear()
        erpoundsTextBox.Clear()
        eryenTextBox.Clear()
        erbitcoinTextBox.Clear()
        efeurosTextBox.Clear()
        efpoundsTextBox.Clear()
        efyenTextBox.Clear()
        efbitcoinTextBox.Clear()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Close Application
        Me.Close()
    End Sub

End Class
