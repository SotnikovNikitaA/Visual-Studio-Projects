<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputForm
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
        Me.RerunSimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fpTextBox = New System.Windows.Forms.TextBox()
        Me.fpLabel = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.dpTextBox = New System.Windows.Forms.TextBox()
        Me.dpLabel = New System.Windows.Forms.Label()
        Me.gpTextBox = New System.Windows.Forms.TextBox()
        Me.gpLabel = New System.Windows.Forms.Label()
        Me.pmTextBox = New System.Windows.Forms.TextBox()
        Me.pmLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimulationToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(398, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RerunSimToolStripMenuItem})
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.SimulationToolStripMenuItem.Text = "&Simulation"
        '
        'RerunSimToolStripMenuItem
        '
        Me.RerunSimToolStripMenuItem.Name = "RerunSimToolStripMenuItem"
        Me.RerunSimToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RerunSimToolStripMenuItem.Text = "&Rerun Sim"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fpTextBox)
        Me.GroupBox1.Controls.Add(Me.fpLabel)
        Me.GroupBox1.Controls.Add(Me.idTextBox)
        Me.GroupBox1.Controls.Add(Me.idLabel)
        Me.GroupBox1.Controls.Add(Me.dpTextBox)
        Me.GroupBox1.Controls.Add(Me.dpLabel)
        Me.GroupBox1.Controls.Add(Me.gpTextBox)
        Me.GroupBox1.Controls.Add(Me.gpLabel)
        Me.GroupBox1.Controls.Add(Me.pmTextBox)
        Me.GroupBox1.Controls.Add(Me.pmLabel)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(23, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 362)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Simulation Results"
        '
        'fpTextBox
        '
        Me.fpTextBox.Location = New System.Drawing.Point(201, 286)
        Me.fpTextBox.Name = "fpTextBox"
        Me.fpTextBox.ReadOnly = True
        Me.fpTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.fpTextBox.Size = New System.Drawing.Size(100, 26)
        Me.fpTextBox.TabIndex = 9
        '
        'fpLabel
        '
        Me.fpLabel.AutoSize = True
        Me.fpLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.fpLabel.Location = New System.Drawing.Point(39, 292)
        Me.fpLabel.Name = "fpLabel"
        Me.fpLabel.Size = New System.Drawing.Size(110, 20)
        Me.fpLabel.TabIndex = 8
        Me.fpLabel.Text = "False Positive:"
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(201, 225)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.ReadOnly = True
        Me.idTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.idTextBox.Size = New System.Drawing.Size(100, 26)
        Me.idTextBox.TabIndex = 7
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.idLabel.Location = New System.Drawing.Point(39, 231)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(139, 20)
        Me.idLabel.TabIndex = 6
        Me.idLabel.Text = "Identified Defects:"
        '
        'dpTextBox
        '
        Me.dpTextBox.Location = New System.Drawing.Point(201, 161)
        Me.dpTextBox.Name = "dpTextBox"
        Me.dpTextBox.ReadOnly = True
        Me.dpTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dpTextBox.Size = New System.Drawing.Size(100, 26)
        Me.dpTextBox.TabIndex = 5
        '
        'dpLabel
        '
        Me.dpLabel.AutoSize = True
        Me.dpLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dpLabel.Location = New System.Drawing.Point(39, 167)
        Me.dpLabel.Name = "dpLabel"
        Me.dpLabel.Size = New System.Drawing.Size(147, 20)
        Me.dpLabel.TabIndex = 4
        Me.dpLabel.Text = "Defective Products:"
        '
        'gpTextBox
        '
        Me.gpTextBox.Location = New System.Drawing.Point(201, 101)
        Me.gpTextBox.Name = "gpTextBox"
        Me.gpTextBox.ReadOnly = True
        Me.gpTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gpTextBox.Size = New System.Drawing.Size(100, 26)
        Me.gpTextBox.TabIndex = 3
        '
        'gpLabel
        '
        Me.gpLabel.AutoSize = True
        Me.gpLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gpLabel.Location = New System.Drawing.Point(39, 107)
        Me.gpLabel.Name = "gpLabel"
        Me.gpLabel.Size = New System.Drawing.Size(120, 20)
        Me.gpLabel.TabIndex = 2
        Me.gpLabel.Text = "Good Products:"
        '
        'pmTextBox
        '
        Me.pmTextBox.Location = New System.Drawing.Point(201, 42)
        Me.pmTextBox.Name = "pmTextBox"
        Me.pmTextBox.ReadOnly = True
        Me.pmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pmTextBox.Size = New System.Drawing.Size(100, 26)
        Me.pmTextBox.TabIndex = 1
        '
        'pmLabel
        '
        Me.pmLabel.AutoSize = True
        Me.pmLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pmLabel.Location = New System.Drawing.Point(39, 48)
        Me.pmLabel.Name = "pmLabel"
        Me.pmLabel.Size = New System.Drawing.Size(120, 20)
        Me.pmLabel.TabIndex = 0
        Me.pmLabel.Text = "Products Made:"
        '
        'OutputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(398, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "OutputForm"
        Me.Text = "Simulation Results"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RerunSimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fpTextBox As TextBox
    Friend WithEvents fpLabel As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents idLabel As Label
    Friend WithEvents dpTextBox As TextBox
    Friend WithEvents dpLabel As Label
    Friend WithEvents gpTextBox As TextBox
    Friend WithEvents gpLabel As Label
    Friend WithEvents pmTextBox As TextBox
    Friend WithEvents pmLabel As Label
End Class
