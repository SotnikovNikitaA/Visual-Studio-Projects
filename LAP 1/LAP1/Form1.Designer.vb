<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.numberofitemsLabel = New System.Windows.Forms.Label()
        Me.shoppinglistLabel = New System.Windows.Forms.Label()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.shoppinglistcommentLabel = New System.Windows.Forms.Label()
        Me.countLabel = New System.Windows.Forms.Label()
        Me.addtolistButton = New System.Windows.Forms.Button()
        Me.yellowButton = New System.Windows.Forms.Button()
        Me.resetformButton = New System.Windows.Forms.Button()
        Me.redButton = New System.Windows.Forms.Button()
        Me.blueButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Location = New System.Drawing.Point(12, 35)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(142, 21)
        Me.descriptionLabel.TabIndex = 0
        Me.descriptionLabel.Text = "Description:"
        '
        'numberofitemsLabel
        '
        Me.numberofitemsLabel.AutoSize = True
        Me.numberofitemsLabel.Location = New System.Drawing.Point(12, 96)
        Me.numberofitemsLabel.Name = "numberofitemsLabel"
        Me.numberofitemsLabel.Size = New System.Drawing.Size(186, 21)
        Me.numberofitemsLabel.TabIndex = 3
        Me.numberofitemsLabel.Text = "Number of Items:"
        '
        'shoppinglistLabel
        '
        Me.shoppinglistLabel.AutoSize = True
        Me.shoppinglistLabel.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.shoppinglistLabel.Location = New System.Drawing.Point(12, 168)
        Me.shoppinglistLabel.Name = "shoppinglistLabel"
        Me.shoppinglistLabel.Size = New System.Drawing.Size(153, 21)
        Me.shoppinglistLabel.TabIndex = 5
        Me.shoppinglistLabel.Text = "Shopping List"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(160, 32)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(242, 29)
        Me.descriptionTextBox.TabIndex = 1
        Me.descriptionTextBox.Text = "Enter Item"
        '
        'shoppinglistcommentLabel
        '
        Me.shoppinglistcommentLabel.BackColor = System.Drawing.Color.DimGray
        Me.shoppinglistcommentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shoppinglistcommentLabel.ForeColor = System.Drawing.Color.Black
        Me.shoppinglistcommentLabel.Location = New System.Drawing.Point(12, 201)
        Me.shoppinglistcommentLabel.Name = "shoppinglistcommentLabel"
        Me.shoppinglistcommentLabel.Size = New System.Drawing.Size(590, 233)
        Me.shoppinglistcommentLabel.TabIndex = 6
        '
        'countLabel
        '
        Me.countLabel.AutoSize = True
        Me.countLabel.ForeColor = System.Drawing.Color.White
        Me.countLabel.Location = New System.Drawing.Point(204, 96)
        Me.countLabel.Name = "countLabel"
        Me.countLabel.Size = New System.Drawing.Size(21, 21)
        Me.countLabel.TabIndex = 4
        Me.countLabel.Text = "0"
        '
        'addtolistButton
        '
        Me.addtolistButton.Location = New System.Drawing.Point(420, 27)
        Me.addtolistButton.Name = "addtolistButton"
        Me.addtolistButton.Size = New System.Drawing.Size(182, 37)
        Me.addtolistButton.TabIndex = 2
        Me.addtolistButton.Text = "Add to List"
        Me.addtolistButton.UseVisualStyleBackColor = True
        '
        'yellowButton
        '
        Me.yellowButton.Location = New System.Drawing.Point(16, 490)
        Me.yellowButton.Name = "yellowButton"
        Me.yellowButton.Size = New System.Drawing.Size(182, 37)
        Me.yellowButton.TabIndex = 7
        Me.yellowButton.Text = "Yellow"
        Me.yellowButton.UseVisualStyleBackColor = True
        '
        'resetformButton
        '
        Me.resetformButton.Location = New System.Drawing.Point(220, 574)
        Me.resetformButton.Name = "resetformButton"
        Me.resetformButton.Size = New System.Drawing.Size(182, 37)
        Me.resetformButton.TabIndex = 10
        Me.resetformButton.Text = "Reset Form"
        Me.resetformButton.UseVisualStyleBackColor = True
        '
        'redButton
        '
        Me.redButton.Location = New System.Drawing.Point(420, 490)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(182, 37)
        Me.redButton.TabIndex = 9
        Me.redButton.Text = "Red"
        Me.redButton.UseVisualStyleBackColor = True
        '
        'blueButton
        '
        Me.blueButton.Location = New System.Drawing.Point(220, 490)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(182, 37)
        Me.blueButton.TabIndex = 8
        Me.blueButton.Text = "Blue"
        Me.blueButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(420, 574)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(182, 37)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(638, 727)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.blueButton)
        Me.Controls.Add(Me.redButton)
        Me.Controls.Add(Me.resetformButton)
        Me.Controls.Add(Me.yellowButton)
        Me.Controls.Add(Me.addtolistButton)
        Me.Controls.Add(Me.countLabel)
        Me.Controls.Add(Me.shoppinglistcommentLabel)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.shoppinglistLabel)
        Me.Controls.Add(Me.numberofitemsLabel)
        Me.Controls.Add(Me.descriptionLabel)
        Me.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAP 1 Shopping List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents descriptionLabel As Label
    Friend WithEvents numberofitemsLabel As Label
    Friend WithEvents shoppinglistLabel As Label
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents shoppinglistcommentLabel As Label
    Friend WithEvents countLabel As Label
    Friend WithEvents addtolistButton As Button
    Friend WithEvents yellowButton As Button
    Friend WithEvents resetformButton As Button
    Friend WithEvents redButton As Button
    Friend WithEvents blueButton As Button
    Friend WithEvents exitButton As Button
End Class
