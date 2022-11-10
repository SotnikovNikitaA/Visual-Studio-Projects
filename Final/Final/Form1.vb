'MIS 322
'Nikita Sotnikov 
'Final
'04/06/2021

Option Explicit On
Option Strict Off

Public Class Form1
    'Declare variables
    Public rows, count As Integer
    Public rop As Double
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductListDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductListDataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.ProductListDataSet.tblProducts)
        'Give values to combobox and variable line
        rows = ProductListDataSet.tblProducts.Count
        slComboBox.Items.Add("50%")
        slComboBox.Items.Add("60%")
        slComboBox.Items.Add("70%")
        slComboBox.Items.Add("80%")
        slComboBox.Items.Add("90%")
        slComboBox.Items.Add("95%")
        slComboBox.Items.Add("99%")
        ltComboBox.Items.Add("1")
        ltComboBox.Items.Add("2")
        ltComboBox.Items.Add("3")
        ltComboBox.Items.Add("4")
        ltComboBox.Items.Add("5")
        ltComboBox.Items.Add("6")
        ltComboBox.Items.Add("7")
    End Sub

    Private Sub nButton_Click(sender As Object, e As EventArgs) Handles nButton.Click
        'Give value to next button and textboxes
        If count < rows And count < 76 Then
            pTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ProductName")
            usTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsInStock")
            uoTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsOnOrder")
            rlTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ReorderLevel")
            adTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("AverageDemandLT")
            sddTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("StandardDevLT")
            count += 1
        Else
            count = 0
        End If
    End Sub

    Private Sub pButton_Click(sender As Object, e As EventArgs) Handles pButton.Click
        'Give value to previous button and textboxes
        If count < rows And count > 0 Then
            count -= 1
            pTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ProductName")
            usTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsInStock")
            uoTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsOnOrder")
            rlTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ReorderLevel")
            adTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("AverageDemandLT")
            sddTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("StandardDevLT")
        Else
            count = 0
        End If
    End Sub

    Private Sub lButton_Click(sender As Object, e As EventArgs) Handles lButton.Click
        'Give value to last button and textboxes
        If count < rows Then
            count = 76
            pTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ProductName")
            usTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsInStock")
            uoTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsOnOrder")
            rlTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ReorderLevel")
            adTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("AverageDemandLT")
            sddTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("StandardDevLT")
        End If
    End Sub

    Private Sub tpiButton_Click(sender As Object, e As EventArgs) Handles tpiButton.Click
        'Transfer values between texboxes
        addTextBox.Text = adTextBox.Text
        sdTextBox.Text = sddTextBox.Text
    End Sub

    Private Sub cButton_Click(sender As Object, e As EventArgs) Handles cButton.Click

        'Calculation and error checking

        Select Case slComboBox.SelectedItem
            Case "50%"
                z = 0.0
            Case "60%"
                z = 0.2533
            Case "70%"
                z = 0.5244
            Case "80%"
                z = 0.8416
            Case "90%"
                z = 1.2816
            Case "95%"
                z = 1.6449
            Case "99%"
                z = 2.3263
        End Select

        slComboBox.Text = slComboBox.Text.Replace("%", "")

        Try
            If addTextBox.Text = "" Or sddTextBox.Text = "" Or slComboBox.Text = "" Or ltComboBox.Text = "" Then
                MessageBox.Show("Input correct number")
            ElseIf addTextBox.Text < 0 Or sddTextBox.Text < 0 Or slComboBox.Text < 0 Or ltComboBox.Text < 0 Then
                MessageBox.Show("Input positive number")
            End If
        Catch fe As FormatException
            MessageBox.Show("Input correct number", "Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Enter correct number", "System Error")
            Exit Sub
        End Try

        rop = addTextBox.Text * ltComboBox.Text + z * sdTextBox.Text * (Math.Sqrt(ltComboBox.Text))
        rpLabel.Text = rop.ToString("N0")
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFormToolStripMenuItem.Click
        'Clear form
        pTextBox.Clear()
        usTextBox.Clear()
        uoTextBox.Clear()
        rlTextBox.Clear()
        addTextBox.Clear()
        adTextBox.Clear()
        sddTextBox.Clear()
        sdTextBox.Clear()
        slComboBox.Text = ""
        ltComboBox.Text = ""
        rpLabel.Text = ""
    End Sub

    Private Sub RunROPReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunROPReportToolStripMenuItem.Click
        'Set up data for second form

        slComboBox.Text = slComboBox.Text.Replace("%", "")

        Select Case slComboBox.SelectedItem
            Case "50%"
                z = 0.0
            Case "60%"
                z = 0.2533
            Case "70%"
                z = 0.5244
            Case "80%"
                z = 0.8416
            Case "90%"
                z = 1.2816
            Case "95%"
                z = 1.6449
            Case "99%"
                z = 2.3263
        End Select

        slComboBox.Text = slComboBox.Text.Replace("%", "")

        Try
            If addTextBox.Text = "" Or sddTextBox.Text = "" Or slComboBox.Text = "" Or ltComboBox.Text = "" Then
                MessageBox.Show("Input correct number")
            ElseIf addTextBox.Text < 0 Or sddTextBox.Text < 0 Or slComboBox.Text < 0 Or ltComboBox.Text < 0 Then
                MessageBox.Show("Input positive number")
            End If
        Catch fe As FormatException
            MessageBox.Show("Input correct number", "Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Enter correct number", "System Error")
            Exit Sub
        End Try

        Dim zone As String = "{0,-40}{1,15}{2,15}"
        y = String.Format(zone, "Product", "Current ROP", "Calculated ROP") & vbNewLine
        y += String.Format(zone, "========", "============", "=============") & vbNewLine
        For Each myRow In ProductListDataSet.tblProducts.Rows
            If count < rows Then
                rop = myRow.item("AverageDemandLT") * ltComboBox.Text + z * myRow.item("StandardDevLT") * Math.Sqrt(ltComboBox.Text)
                y += String.Format(zone, myRow.item("ProductName"), myRow.item("ReorderLevel"), rop.ToString("n0")) & vbNewLine
                count += 1
            End If
        Next
        Reorder_Point_Report.ShowDialog()
    End Sub

    Private Sub fButton_Click(sender As Object, e As EventArgs) Handles fButton.Click
        'Give value to first button and textboxes
        If count < rows Then
            count = 0
            pTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ProductName")
            usTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsInStock")
            uoTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("UnitsOnOrder")
            rlTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("ReorderLevel")
            adTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("AverageDemandLT")
            sddTextBox.Text = ProductListDataSet.tblProducts.Rows(count).Item("StandardDevLT")
        End If
    End Sub

End Class
