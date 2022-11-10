<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.osTextBox = New System.Windows.Forms.TextBox()
        Me.coButton = New System.Windows.Forms.Button()
        Me.bButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'osTextBox
        '
        Me.osTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.osTextBox.Location = New System.Drawing.Point(13, 13)
        Me.osTextBox.Multiline = True
        Me.osTextBox.Name = "osTextBox"
        Me.osTextBox.ReadOnly = True
        Me.osTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.osTextBox.Size = New System.Drawing.Size(518, 317)
        Me.osTextBox.TabIndex = 0
        '
        'coButton
        '
        Me.coButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.coButton.Location = New System.Drawing.Point(59, 367)
        Me.coButton.Name = "coButton"
        Me.coButton.Size = New System.Drawing.Size(187, 43)
        Me.coButton.TabIndex = 1
        Me.coButton.Text = "Confirm Order"
        Me.coButton.UseVisualStyleBackColor = True
        '
        'bButton
        '
        Me.bButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bButton.Location = New System.Drawing.Point(273, 367)
        Me.bButton.Name = "bButton"
        Me.bButton.Size = New System.Drawing.Size(187, 43)
        Me.bButton.TabIndex = 2
        Me.bButton.Text = "Back to Main Form"
        Me.bButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(546, 423)
        Me.Controls.Add(Me.bButton)
        Me.Controls.Add(Me.coButton)
        Me.Controls.Add(Me.osTextBox)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents osTextBox As TextBox
    Friend WithEvents coButton As Button
    Friend WithEvents bButton As Button
End Class
