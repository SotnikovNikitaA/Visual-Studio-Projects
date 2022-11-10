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
        Me.idLabel = New System.Windows.Forms.Label()
        Me.aoButton = New System.Windows.Forms.Button()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.smTextBox = New System.Windows.Forms.TextBox()
        Me.rfButton = New System.Windows.Forms.Button()
        Me.alLabel = New System.Windows.Forms.Label()
        Me.bpTextBox = New System.Windows.Forms.TextBox()
        Me.atlButton = New System.Windows.Forms.Button()
        Me.smLabel = New System.Windows.Forms.Label()
        Me.qTextBox = New System.Windows.Forms.TextBox()
        Me.soButton = New System.Windows.Forms.Button()
        Me.qLabel = New System.Windows.Forms.Label()
        Me.alTextBox = New System.Windows.Forms.TextBox()
        Me.eButton = New System.Windows.Forms.Button()
        Me.speLabel = New System.Windows.Forms.Label()
        Me.bpLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(68, 43)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(129, 20)
        Me.idLabel.TabIndex = 0
        Me.idLabel.Text = "Item Description:"
        '
        'aoButton
        '
        Me.aoButton.Location = New System.Drawing.Point(322, 90)
        Me.aoButton.Name = "aoButton"
        Me.aoButton.Size = New System.Drawing.Size(42, 26)
        Me.aoButton.TabIndex = 4
        Me.aoButton.Text = "+1"
        Me.aoButton.UseVisualStyleBackColor = True
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(203, 37)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(286, 26)
        Me.idTextBox.TabIndex = 1
        '
        'smTextBox
        '
        Me.smTextBox.Location = New System.Drawing.Point(203, 193)
        Me.smTextBox.Name = "smTextBox"
        Me.smTextBox.Size = New System.Drawing.Size(100, 26)
        Me.smTextBox.TabIndex = 9
        '
        'rfButton
        '
        Me.rfButton.Location = New System.Drawing.Point(221, 255)
        Me.rfButton.Name = "rfButton"
        Me.rfButton.Size = New System.Drawing.Size(115, 34)
        Me.rfButton.TabIndex = 12
        Me.rfButton.Text = "Reset Form"
        Me.rfButton.UseVisualStyleBackColor = True
        '
        'alLabel
        '
        Me.alLabel.AutoSize = True
        Me.alLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.alLabel.Location = New System.Drawing.Point(68, 311)
        Me.alLabel.Name = "alLabel"
        Me.alLabel.Size = New System.Drawing.Size(92, 20)
        Me.alLabel.TabIndex = 14
        Me.alLabel.Text = "Auction List"
        '
        'bpTextBox
        '
        Me.bpTextBox.Location = New System.Drawing.Point(203, 139)
        Me.bpTextBox.Name = "bpTextBox"
        Me.bpTextBox.Size = New System.Drawing.Size(100, 26)
        Me.bpTextBox.TabIndex = 7
        '
        'atlButton
        '
        Me.atlButton.Location = New System.Drawing.Point(72, 255)
        Me.atlButton.Name = "atlButton"
        Me.atlButton.Size = New System.Drawing.Size(115, 34)
        Me.atlButton.TabIndex = 11
        Me.atlButton.Text = "Add to List"
        Me.atlButton.UseVisualStyleBackColor = True
        '
        'smLabel
        '
        Me.smLabel.AutoSize = True
        Me.smLabel.Location = New System.Drawing.Point(68, 199)
        Me.smLabel.Name = "smLabel"
        Me.smLabel.Size = New System.Drawing.Size(133, 20)
        Me.smLabel.TabIndex = 8
        Me.smLabel.Text = "Shipping Method:"
        '
        'qTextBox
        '
        Me.qTextBox.Location = New System.Drawing.Point(203, 90)
        Me.qTextBox.Name = "qTextBox"
        Me.qTextBox.ReadOnly = True
        Me.qTextBox.Size = New System.Drawing.Size(100, 26)
        Me.qTextBox.TabIndex = 3
        '
        'soButton
        '
        Me.soButton.Location = New System.Drawing.Point(370, 90)
        Me.soButton.Name = "soButton"
        Me.soButton.Size = New System.Drawing.Size(39, 27)
        Me.soButton.TabIndex = 5
        Me.soButton.Text = "-1"
        Me.soButton.UseVisualStyleBackColor = True
        '
        'qLabel
        '
        Me.qLabel.AutoSize = True
        Me.qLabel.Location = New System.Drawing.Point(68, 90)
        Me.qLabel.Name = "qLabel"
        Me.qLabel.Size = New System.Drawing.Size(72, 20)
        Me.qLabel.TabIndex = 2
        Me.qLabel.Text = "Quantity:"
        '
        'alTextBox
        '
        Me.alTextBox.Location = New System.Drawing.Point(72, 363)
        Me.alTextBox.Multiline = True
        Me.alTextBox.Name = "alTextBox"
        Me.alTextBox.ReadOnly = True
        Me.alTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.alTextBox.Size = New System.Drawing.Size(417, 302)
        Me.alTextBox.TabIndex = 15
        '
        'eButton
        '
        Me.eButton.Location = New System.Drawing.Point(374, 255)
        Me.eButton.Name = "eButton"
        Me.eButton.Size = New System.Drawing.Size(115, 34)
        Me.eButton.TabIndex = 13
        Me.eButton.Text = "Exit"
        Me.eButton.UseVisualStyleBackColor = True
        '
        'speLabel
        '
        Me.speLabel.AutoSize = True
        Me.speLabel.Location = New System.Drawing.Point(306, 199)
        Me.speLabel.Name = "speLabel"
        Me.speLabel.Size = New System.Drawing.Size(195, 20)
        Me.speLabel.TabIndex = 10
        Me.speLabel.Text = "Standard, Priority, Express"
        '
        'bpLabel
        '
        Me.bpLabel.AutoSize = True
        Me.bpLabel.Location = New System.Drawing.Point(68, 145)
        Me.bpLabel.Name = "bpLabel"
        Me.bpLabel.Size = New System.Drawing.Size(89, 20)
        Me.bpLabel.TabIndex = 6
        Me.bpLabel.Text = "Base Price:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(583, 700)
        Me.Controls.Add(Me.bpLabel)
        Me.Controls.Add(Me.alTextBox)
        Me.Controls.Add(Me.eButton)
        Me.Controls.Add(Me.speLabel)
        Me.Controls.Add(Me.qTextBox)
        Me.Controls.Add(Me.soButton)
        Me.Controls.Add(Me.qLabel)
        Me.Controls.Add(Me.bpTextBox)
        Me.Controls.Add(Me.atlButton)
        Me.Controls.Add(Me.smLabel)
        Me.Controls.Add(Me.smTextBox)
        Me.Controls.Add(Me.rfButton)
        Me.Controls.Add(Me.alLabel)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.aoButton)
        Me.Controls.Add(Me.idLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Spring 2021 Midterm - Auction Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idLabel As Label
    Friend WithEvents aoButton As Button
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents smTextBox As TextBox
    Friend WithEvents rfButton As Button
    Friend WithEvents alLabel As Label
    Friend WithEvents bpTextBox As TextBox
    Friend WithEvents atlButton As Button
    Friend WithEvents smLabel As Label
    Friend WithEvents qTextBox As TextBox
    Friend WithEvents soButton As Button
    Friend WithEvents qLabel As Label
    Friend WithEvents alTextBox As TextBox
    Friend WithEvents eButton As Button
    Friend WithEvents speLabel As Label
    Friend WithEvents bpLabel As Label
End Class
