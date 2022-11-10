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
        Me.arLabel = New System.Windows.Forms.Label()
        Me.slLabel = New System.Windows.Forms.Label()
        Me.srLabel = New System.Windows.Forms.Label()
        Me.lLabel = New System.Windows.Forms.Label()
        Me.arTextBox = New System.Windows.Forms.TextBox()
        Me.sTextBox = New System.Windows.Forms.TextBox()
        Me.slTextBox = New System.Windows.Forms.TextBox()
        Me.srTextBox = New System.Windows.Forms.TextBox()
        Me.sButton = New System.Windows.Forms.Button()
        Me.cButton = New System.Windows.Forms.Button()
        Me.rButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'arLabel
        '
        Me.arLabel.AutoSize = True
        Me.arLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.arLabel.Location = New System.Drawing.Point(33, 33)
        Me.arLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.arLabel.Name = "arLabel"
        Me.arLabel.Size = New System.Drawing.Size(110, 24)
        Me.arLabel.TabIndex = 0
        Me.arLabel.Text = "Arrival Rate:"
        '
        'slLabel
        '
        Me.slLabel.AutoSize = True
        Me.slLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.slLabel.Location = New System.Drawing.Point(33, 141)
        Me.slLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.slLabel.Name = "slLabel"
        Me.slLabel.Size = New System.Drawing.Size(123, 24)
        Me.slLabel.TabIndex = 5
        Me.slLabel.Text = "System Load:"
        '
        'srLabel
        '
        Me.srLabel.AutoSize = True
        Me.srLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.srLabel.Location = New System.Drawing.Point(33, 84)
        Me.srLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.srLabel.Name = "srLabel"
        Me.srLabel.Size = New System.Drawing.Size(121, 24)
        Me.srLabel.TabIndex = 3
        Me.srLabel.Text = "Service Rate:"
        '
        'lLabel
        '
        Me.lLabel.AutoSize = True
        Me.lLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lLabel.Location = New System.Drawing.Point(310, 146)
        Me.lLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lLabel.Name = "lLabel"
        Me.lLabel.Size = New System.Drawing.Size(204, 24)
        Me.lLabel.TabIndex = 7
        Me.lLabel.Text = "(Light, Medium, Heavy)"
        '
        'arTextBox
        '
        Me.arTextBox.Location = New System.Drawing.Point(183, 33)
        Me.arTextBox.Name = "arTextBox"
        Me.arTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.arTextBox.Size = New System.Drawing.Size(100, 29)
        Me.arTextBox.TabIndex = 1
        '
        'sTextBox
        '
        Me.sTextBox.Location = New System.Drawing.Point(37, 195)
        Me.sTextBox.Multiline = True
        Me.sTextBox.Name = "sTextBox"
        Me.sTextBox.ReadOnly = True
        Me.sTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.sTextBox.Size = New System.Drawing.Size(506, 300)
        Me.sTextBox.TabIndex = 8
        '
        'slTextBox
        '
        Me.slTextBox.Location = New System.Drawing.Point(183, 141)
        Me.slTextBox.Name = "slTextBox"
        Me.slTextBox.Size = New System.Drawing.Size(100, 29)
        Me.slTextBox.TabIndex = 6
        '
        'srTextBox
        '
        Me.srTextBox.Location = New System.Drawing.Point(183, 84)
        Me.srTextBox.Name = "srTextBox"
        Me.srTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.srTextBox.Size = New System.Drawing.Size(100, 29)
        Me.srTextBox.TabIndex = 4
        '
        'sButton
        '
        Me.sButton.Location = New System.Drawing.Point(407, 56)
        Me.sButton.Name = "sButton"
        Me.sButton.Size = New System.Drawing.Size(136, 32)
        Me.sButton.TabIndex = 2
        Me.sButton.Text = "Simulate"
        Me.sButton.UseVisualStyleBackColor = True
        '
        'cButton
        '
        Me.cButton.Location = New System.Drawing.Point(407, 515)
        Me.cButton.Name = "cButton"
        Me.cButton.Size = New System.Drawing.Size(136, 32)
        Me.cButton.TabIndex = 10
        Me.cButton.Text = "Close"
        Me.cButton.UseVisualStyleBackColor = True
        '
        'rButton
        '
        Me.rButton.Location = New System.Drawing.Point(249, 515)
        Me.rButton.Name = "rButton"
        Me.rButton.Size = New System.Drawing.Size(136, 32)
        Me.rButton.TabIndex = 9
        Me.rButton.Text = "Reset Form"
        Me.rButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(568, 568)
        Me.Controls.Add(Me.rButton)
        Me.Controls.Add(Me.cButton)
        Me.Controls.Add(Me.sButton)
        Me.Controls.Add(Me.srTextBox)
        Me.Controls.Add(Me.slTextBox)
        Me.Controls.Add(Me.sTextBox)
        Me.Controls.Add(Me.arTextBox)
        Me.Controls.Add(Me.lLabel)
        Me.Controls.Add(Me.srLabel)
        Me.Controls.Add(Me.slLabel)
        Me.Controls.Add(Me.arLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "LAP 3: Waiting Line Simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents arLabel As Label
    Friend WithEvents slLabel As Label
    Friend WithEvents srLabel As Label
    Friend WithEvents lLabel As Label
    Friend WithEvents arTextBox As TextBox
    Friend WithEvents sTextBox As TextBox
    Friend WithEvents slTextBox As TextBox
    Friend WithEvents srTextBox As TextBox
    Friend WithEvents sButton As Button
    Friend WithEvents cButton As Button
    Friend WithEvents rButton As Button
End Class
