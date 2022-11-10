'MIS 322
'Nikita Sotnikov W01493818
'LAP 6
'01/06/2021

Option Explicit On
Option Strict Off
Option Infer On

Public Class Form1
    Private Sub TblGamesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblGamesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblGamesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GamesDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GamesDataSet.tblGames' table. You can move, or remove it, as needed.
        Me.TblGamesTableAdapter.Fill(Me.GamesDataSet.tblGames)
    End Sub
    Private Sub GameDisplay()
        'Clear the form
        gfTextBox.Clear()
        'Declare variables
        Dim min, max As Integer
        Dim typ, gen As String
        Dim count = 0
        Dim zone As String = "{0,-40}{1,-20}{2,-20}{3,-10}{4,-15}{5,-15}"

        gfTextBox.Text = String.Format(zone, "Title", "Type", "Genre", "Year", "Min Players", "Max Players") & vbNewLine
        gfTextBox.Text += String.Format(zone, "-----", "----", "-----", "----", "-----------", "-----------") & vbNewLine
        'Set the statements for line checker
        For Each myRow In GamesDataSet.tblGames.Rows

            If minComboBox.SelectedIndex = -1 Then
                min = 0
            Else
                min = minComboBox.SelectedItem
            End If

            If maxComboBox.SelectedIndex = -1 Then
                max = 20
            Else
                max = maxComboBox.SelectedItem
            End If

            typ = tComboBox.SelectedItem
            gen = gComboBox.SelectedItem


            If myRow.item("Type") = typ And
                    myRow.item("Genre") = gen And
                    myRow.item("NumMinPlayers") = min And
                    myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Genre") = gen And
                myRow.item("NumMinPlayers") = min And
                myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Type") = typ And
                myRow.item("Genre") = gen And
                myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                        myRow.item("Type"),
                                                        myRow.item("Genre"),
                                                        myRow.item("YearRelease"),
                                                        myRow.item("NumMinPlayers"),
                                                        myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Type") = typ And
                    myRow.item("Genre") = gen And
                    myRow.item("NumMinPlayers") = min Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                        myRow.item("Type"),
                                                        myRow.item("Genre"),
                                                        myRow.item("YearRelease"),
                                                        myRow.item("NumMinPlayers"),
                                                        myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Type") = typ And
                    myRow.item("NumMinPlayers") = min And
                    myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Type") = typ And
                    myRow.item("Genre") = gen Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Type") = typ And
                    myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Type") = typ And
                    myRow.item("NumMinPlayers") = min Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Genre") = gen And
                    myRow.item("NumMinPlayers") = min Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Genre") = gen And
                    myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("NumMinPlayers") = min And
                    myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                    myRow.item("Type"),
                                                    myRow.item("Genre"),
                                                    myRow.item("YearRelease"),
                                                    myRow.item("NumMinPlayers"),
                                                    myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Type") = typ Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                            myRow.item("Type"),
                                                            myRow.item("Genre"),
                                                            myRow.item("YearRelease"),
                                                            myRow.item("NumMinPlayers"),
                                                            myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("Genre") = gen Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                        myRow.item("Type"),
                                                        myRow.item("Genre"),
                                                        myRow.item("YearRelease"),
                                                        myRow.item("NumMinPlayers"),
                                                        myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("NumMinPlayers") = min Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                        myRow.item("Type"),
                                                        myRow.item("Genre"),
                                                        myRow.item("YearRelease"),
                                                        myRow.item("NumMinPlayers"),
                                                        myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            ElseIf myRow.item("NumMaxPlayers") = max Then
                gfTextBox.Text += String.Format(zone, myRow.item("Title"),
                                                            myRow.item("Type"),
                                                            myRow.item("Genre"),
                                                            myRow.item("YearRelease"),
                                                            myRow.item("NumMinPlayers"),
                                                            myRow.item("NumMaxPlayers")) & vbNewLine
                count += 1
            End If
        Next
        'If no match items then message about this
        If count = 0 Then
            gfTextBox.Text = vbNewLine & " - No games match criteria - "
        Else
            gfTextBox.Text += "Number of game matching criteria: " & count
        End If
    End Sub
    'Any changes start the procedure
    Private Sub minComboBox_TextChanged(sender As Object, e As EventArgs) Handles minComboBox.TextChanged
        GameDisplay()
    End Sub
    Private Sub minComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles minComboBox.SelectedIndexChanged
        GameDisplay()
    End Sub

    Private Sub maxComboBox_TextChanged(sender As Object, e As EventArgs) Handles maxComboBox.TextChanged
        GameDisplay()
    End Sub
    Private Sub maxComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maxComboBox.SelectedIndexChanged
        GameDisplay()
    End Sub
    Private Sub tComboBox_TextChanged(sender As Object, e As EventArgs) Handles tComboBox.TextChanged
        GameDisplay()
    End Sub
    Private Sub tComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tComboBox.SelectedIndexChanged
        GameDisplay()
    End Sub
    Private Sub gComboBox_TextChanged(sender As Object, e As EventArgs) Handles gComboBox.TextChanged
        GameDisplay()
    End Sub
    Private Sub gComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gComboBox.SelectedIndexChanged
        GameDisplay()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'Reset form
        minComboBox.SelectedIndex = -1
        maxComboBox.SelectedIndex = -1
        tComboBox.SelectedIndex = -1
        gComboBox.SelectedIndex = -1
        gfTextBox.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the form
        Me.Close()
    End Sub

End Class
