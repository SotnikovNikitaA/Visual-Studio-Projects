<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunSimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ntLabel = New System.Windows.Forms.Label()
        Me.percsLabel = New System.Windows.Forms.Label()
        Me.percLabel = New System.Windows.Forms.Label()
        Me.taLabel = New System.Windows.Forms.Label()
        Me.drLabel = New System.Windows.Forms.Label()
        Me.notTextBox = New System.Windows.Forms.TextBox()
        Me.drTextBox = New System.Windows.Forms.TextBox()
        Me.taTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimulationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(339, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunSimToolStripMenuItem, Me.ResetSimToolStripMenuItem})
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.SimulationToolStripMenuItem.Text = "&Simulation"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'RunSimToolStripMenuItem
        '
        Me.RunSimToolStripMenuItem.Name = "RunSimToolStripMenuItem"
        Me.RunSimToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RunSimToolStripMenuItem.Text = "&Run Sim"
        '
        'ResetSimToolStripMenuItem
        '
        Me.ResetSimToolStripMenuItem.Name = "ResetSimToolStripMenuItem"
        Me.ResetSimToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetSimToolStripMenuItem.Text = "R&eset Sim"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.taTextBox)
        Me.GroupBox1.Controls.Add(Me.drTextBox)
        Me.GroupBox1.Controls.Add(Me.notTextBox)
        Me.GroupBox1.Controls.Add(Me.drLabel)
        Me.GroupBox1.Controls.Add(Me.taLabel)
        Me.GroupBox1.Controls.Add(Me.percLabel)
        Me.GroupBox1.Controls.Add(Me.percsLabel)
        Me.GroupBox1.Controls.Add(Me.ntLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 147)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Simulation Settings"
        '
        'ntLabel
        '
        Me.ntLabel.AutoSize = True
        Me.ntLabel.Location = New System.Drawing.Point(30, 40)
        Me.ntLabel.Name = "ntLabel"
        Me.ntLabel.Size = New System.Drawing.Size(124, 20)
        Me.ntLabel.TabIndex = 0
        Me.ntLabel.Text = "Number of trials:"
        '
        'percsLabel
        '
        Me.percsLabel.AutoSize = True
        Me.percsLabel.Location = New System.Drawing.Point(266, 107)
        Me.percsLabel.Name = "percsLabel"
        Me.percsLabel.Size = New System.Drawing.Size(23, 20)
        Me.percsLabel.TabIndex = 7
        Me.percsLabel.Text = "%"
        '
        'percLabel
        '
        Me.percLabel.AutoSize = True
        Me.percLabel.Location = New System.Drawing.Point(266, 72)
        Me.percLabel.Name = "percLabel"
        Me.percLabel.Size = New System.Drawing.Size(23, 20)
        Me.percLabel.TabIndex = 4
        Me.percLabel.Text = "%"
        '
        'taLabel
        '
        Me.taLabel.AutoSize = True
        Me.taLabel.Location = New System.Drawing.Point(30, 107)
        Me.taLabel.Name = "taLabel"
        Me.taLabel.Size = New System.Drawing.Size(113, 20)
        Me.taLabel.TabIndex = 5
        Me.taLabel.Text = "Test Accuracy:"
        '
        'drLabel
        '
        Me.drLabel.AutoSize = True
        Me.drLabel.Location = New System.Drawing.Point(30, 72)
        Me.drLabel.Name = "drLabel"
        Me.drLabel.Size = New System.Drawing.Size(100, 20)
        Me.drLabel.TabIndex = 2
        Me.drLabel.Text = "Defect Rate:"
        '
        'notTextBox
        '
        Me.notTextBox.Location = New System.Drawing.Point(160, 37)
        Me.notTextBox.Name = "notTextBox"
        Me.notTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.notTextBox.Size = New System.Drawing.Size(100, 26)
        Me.notTextBox.TabIndex = 1
        '
        'drTextBox
        '
        Me.drTextBox.Location = New System.Drawing.Point(160, 69)
        Me.drTextBox.Name = "drTextBox"
        Me.drTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.drTextBox.Size = New System.Drawing.Size(100, 26)
        Me.drTextBox.TabIndex = 3
        '
        'taTextBox
        '
        Me.taTextBox.Location = New System.Drawing.Point(160, 104)
        Me.taTextBox.Name = "taTextBox"
        Me.taTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.taTextBox.Size = New System.Drawing.Size(100, 26)
        Me.taTextBox.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(339, 196)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "LAP 5 - Monte Carlo Simulation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunSimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents taTextBox As TextBox
    Friend WithEvents drTextBox As TextBox
    Friend WithEvents notTextBox As TextBox
    Friend WithEvents drLabel As Label
    Friend WithEvents taLabel As Label
    Friend WithEvents percLabel As Label
    Friend WithEvents percsLabel As Label
    Friend WithEvents ntLabel As Label
End Class
