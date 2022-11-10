'MIS 322
'Nikita Sotnikov W01493818
'LAP 1
'06/04/2021

Public Class Form1

    Private Sub addtolistButton_Click(sender As Object, e As EventArgs) Handles addtolistButton.Click
        'Here you type your item to text box and then it appear in shopping list

        shoppinglistcommentLabel.Text = shoppinglistcommentLabel.Text & descriptionTextBox.Text & ","

        Dim Count As Integer
        Count = countLabel.Text
        Count = Count + 1
        countLabel.Text = Count
    End Sub

    Private Sub yellowButton_Click(sender As Object, e As EventArgs) Handles yellowButton.Click
        'Change a color of text and background on black and yellow

        shoppinglistcommentLabel.ForeColor = Color.Black
        shoppinglistcommentLabel.BackColor = Color.Yellow
    End Sub

    Private Sub blueButton_Click(sender As Object, e As EventArgs) Handles blueButton.Click
        'Change a color of text and background on white and blue

        shoppinglistcommentLabel.ForeColor = Color.White
        shoppinglistcommentLabel.BackColor = Color.Blue
    End Sub

    Private Sub redButton_Click(sender As Object, e As EventArgs) Handles redButton.Click
        'Change a color of text and background on white and red
        shoppinglistcommentLabel.ForeColor = Color.White
        shoppinglistcommentLabel.BackColor = Color.Red
    End Sub

    Private Sub resetformButton_Click(sender As Object, e As EventArgs) Handles resetformButton.Click
        'Reset all to Start moment
        descriptionTextBox.Text = "Enter Item"
        countLabel.Text = "0"
        shoppinglistcommentLabel.Text = ""
        shoppinglistcommentLabel.ForeColor = Color.Black
        shoppinglistcommentLabel.BackColor = Color.DimGray
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Close the program
        Me.Close()
    End Sub
End Class