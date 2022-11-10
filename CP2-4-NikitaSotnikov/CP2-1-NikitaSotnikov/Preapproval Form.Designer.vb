<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preapproval_Form
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
        Me.CloseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckPreapprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cuLabel = New System.Windows.Forms.Label()
        Me.plLabel = New System.Windows.Forms.Label()
        Me.cu1Label = New System.Windows.Forms.Label()
        Me.pl1Label = New System.Windows.Forms.Label()
        Me.pvLabel = New System.Windows.Forms.Label()
        Me.dpLabel = New System.Windows.Forms.Label()
        Me.iLabel = New System.Windows.Forms.Label()
        Me.tLabel = New System.Windows.Forms.Label()
        Me.irLabel = New System.Windows.Forms.Label()
        Me.pvTextBox = New System.Windows.Forms.TextBox()
        Me.dpTextBox = New System.Windows.Forms.TextBox()
        Me.iTextBox = New System.Windows.Forms.TextBox()
        Me.tTextBox = New System.Windows.Forms.TextBox()
        Me.irTextBox = New System.Windows.Forms.TextBox()
        Me.wRadioButton = New System.Windows.Forms.RadioButton()
        Me.oRadioButton = New System.Windows.Forms.RadioButton()
        Me.cRadioButton = New System.Windows.Forms.RadioButton()
        Me.sGroupBox = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.sGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseFormToolStripMenuItem, Me.ExitProgramToolStripMenuItem, Me.CheckPreapprovalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(371, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseFormToolStripMenuItem
        '
        Me.CloseFormToolStripMenuItem.Name = "CloseFormToolStripMenuItem"
        Me.CloseFormToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.CloseFormToolStripMenuItem.Text = "&Close Form"
        '
        'ExitProgramToolStripMenuItem
        '
        Me.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem"
        Me.ExitProgramToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ExitProgramToolStripMenuItem.Text = "E&xit Program"
        '
        'CheckPreapprovalToolStripMenuItem
        '
        Me.CheckPreapprovalToolStripMenuItem.Name = "CheckPreapprovalToolStripMenuItem"
        Me.CheckPreapprovalToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.CheckPreapprovalToolStripMenuItem.Text = "Check &Preapproval"
        '
        'cuLabel
        '
        Me.cuLabel.AutoSize = True
        Me.cuLabel.Location = New System.Drawing.Point(39, 39)
        Me.cuLabel.Name = "cuLabel"
        Me.cuLabel.Size = New System.Drawing.Size(104, 20)
        Me.cuLabel.TabIndex = 1
        Me.cuLabel.Text = "Current User:"
        '
        'plLabel
        '
        Me.plLabel.AutoSize = True
        Me.plLabel.Location = New System.Drawing.Point(12, 68)
        Me.plLabel.Name = "plLabel"
        Me.plLabel.Size = New System.Drawing.Size(131, 20)
        Me.plLabel.TabIndex = 3
        Me.plLabel.Text = "Permission Level:"
        '
        'cu1Label
        '
        Me.cu1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cu1Label.Location = New System.Drawing.Point(149, 33)
        Me.cu1Label.Name = "cu1Label"
        Me.cu1Label.Size = New System.Drawing.Size(194, 26)
        Me.cu1Label.TabIndex = 2
        '
        'pl1Label
        '
        Me.pl1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl1Label.Location = New System.Drawing.Point(149, 67)
        Me.pl1Label.Name = "pl1Label"
        Me.pl1Label.Size = New System.Drawing.Size(194, 26)
        Me.pl1Label.TabIndex = 4
        '
        'pvLabel
        '
        Me.pvLabel.AutoSize = True
        Me.pvLabel.Location = New System.Drawing.Point(26, 120)
        Me.pvLabel.Name = "pvLabel"
        Me.pvLabel.Size = New System.Drawing.Size(117, 20)
        Me.pvLabel.TabIndex = 5
        Me.pvLabel.Text = "Property Value:"
        '
        'dpLabel
        '
        Me.dpLabel.AutoSize = True
        Me.dpLabel.Location = New System.Drawing.Point(23, 153)
        Me.dpLabel.Name = "dpLabel"
        Me.dpLabel.Size = New System.Drawing.Size(120, 20)
        Me.dpLabel.TabIndex = 7
        Me.dpLabel.Text = "Down Payment:"
        '
        'iLabel
        '
        Me.iLabel.AutoSize = True
        Me.iLabel.Location = New System.Drawing.Point(77, 182)
        Me.iLabel.Name = "iLabel"
        Me.iLabel.Size = New System.Drawing.Size(66, 20)
        Me.iLabel.TabIndex = 9
        Me.iLabel.Text = "Income:"
        '
        'tLabel
        '
        Me.tLabel.AutoSize = True
        Me.tLabel.Location = New System.Drawing.Point(20, 218)
        Me.tLabel.Name = "tLabel"
        Me.tLabel.Size = New System.Drawing.Size(123, 20)
        Me.tLabel.TabIndex = 11
        Me.tLabel.Text = "Term (In Years):"
        '
        'irLabel
        '
        Me.irLabel.AutoSize = True
        Me.irLabel.Location = New System.Drawing.Point(36, 252)
        Me.irLabel.Name = "irLabel"
        Me.irLabel.Size = New System.Drawing.Size(107, 20)
        Me.irLabel.TabIndex = 13
        Me.irLabel.Text = "Interest Rate:"
        '
        'pvTextBox
        '
        Me.pvTextBox.Location = New System.Drawing.Point(149, 114)
        Me.pvTextBox.Name = "pvTextBox"
        Me.pvTextBox.Size = New System.Drawing.Size(133, 26)
        Me.pvTextBox.TabIndex = 6
        '
        'dpTextBox
        '
        Me.dpTextBox.Location = New System.Drawing.Point(149, 147)
        Me.dpTextBox.Name = "dpTextBox"
        Me.dpTextBox.Size = New System.Drawing.Size(133, 26)
        Me.dpTextBox.TabIndex = 8
        '
        'iTextBox
        '
        Me.iTextBox.Location = New System.Drawing.Point(149, 179)
        Me.iTextBox.Name = "iTextBox"
        Me.iTextBox.Size = New System.Drawing.Size(133, 26)
        Me.iTextBox.TabIndex = 10
        '
        'tTextBox
        '
        Me.tTextBox.Location = New System.Drawing.Point(149, 212)
        Me.tTextBox.Name = "tTextBox"
        Me.tTextBox.Size = New System.Drawing.Size(90, 26)
        Me.tTextBox.TabIndex = 12
        '
        'irTextBox
        '
        Me.irTextBox.Location = New System.Drawing.Point(149, 246)
        Me.irTextBox.Name = "irTextBox"
        Me.irTextBox.Size = New System.Drawing.Size(90, 26)
        Me.irTextBox.TabIndex = 14
        '
        'wRadioButton
        '
        Me.wRadioButton.AutoSize = True
        Me.wRadioButton.Location = New System.Drawing.Point(68, 25)
        Me.wRadioButton.Name = "wRadioButton"
        Me.wRadioButton.Size = New System.Drawing.Size(112, 24)
        Me.wRadioButton.TabIndex = 15
        Me.wRadioButton.TabStop = True
        Me.wRadioButton.Text = "Washington"
        Me.wRadioButton.UseVisualStyleBackColor = True
        '
        'oRadioButton
        '
        Me.oRadioButton.AutoSize = True
        Me.oRadioButton.Location = New System.Drawing.Point(68, 56)
        Me.oRadioButton.Name = "oRadioButton"
        Me.oRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.oRadioButton.TabIndex = 16
        Me.oRadioButton.TabStop = True
        Me.oRadioButton.Text = "Oregon"
        Me.oRadioButton.UseVisualStyleBackColor = True
        '
        'cRadioButton
        '
        Me.cRadioButton.AutoSize = True
        Me.cRadioButton.Location = New System.Drawing.Point(68, 87)
        Me.cRadioButton.Name = "cRadioButton"
        Me.cRadioButton.Size = New System.Drawing.Size(93, 24)
        Me.cRadioButton.TabIndex = 17
        Me.cRadioButton.TabStop = True
        Me.cRadioButton.Text = "California"
        Me.cRadioButton.UseVisualStyleBackColor = True
        '
        'sGroupBox
        '
        Me.sGroupBox.Controls.Add(Me.wRadioButton)
        Me.sGroupBox.Controls.Add(Me.cRadioButton)
        Me.sGroupBox.Controls.Add(Me.oRadioButton)
        Me.sGroupBox.Location = New System.Drawing.Point(31, 284)
        Me.sGroupBox.Name = "sGroupBox"
        Me.sGroupBox.Size = New System.Drawing.Size(251, 118)
        Me.sGroupBox.TabIndex = 15
        Me.sGroupBox.TabStop = False
        Me.sGroupBox.Text = "State"
        '
        'Preapproval_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 416)
        Me.Controls.Add(Me.sGroupBox)
        Me.Controls.Add(Me.irTextBox)
        Me.Controls.Add(Me.tTextBox)
        Me.Controls.Add(Me.iTextBox)
        Me.Controls.Add(Me.dpTextBox)
        Me.Controls.Add(Me.pvTextBox)
        Me.Controls.Add(Me.irLabel)
        Me.Controls.Add(Me.tLabel)
        Me.Controls.Add(Me.iLabel)
        Me.Controls.Add(Me.dpLabel)
        Me.Controls.Add(Me.pvLabel)
        Me.Controls.Add(Me.pl1Label)
        Me.Controls.Add(Me.cu1Label)
        Me.Controls.Add(Me.plLabel)
        Me.Controls.Add(Me.cuLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Preapproval_Form"
        Me.Text = "Preapproval_Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sGroupBox.ResumeLayout(False)
        Me.sGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckPreapprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cuLabel As Label
    Friend WithEvents plLabel As Label
    Friend WithEvents cu1Label As Label
    Friend WithEvents pl1Label As Label
    Friend WithEvents pvLabel As Label
    Friend WithEvents dpLabel As Label
    Friend WithEvents iLabel As Label
    Friend WithEvents tLabel As Label
    Friend WithEvents irLabel As Label
    Friend WithEvents pvTextBox As TextBox
    Friend WithEvents dpTextBox As TextBox
    Friend WithEvents iTextBox As TextBox
    Friend WithEvents tTextBox As TextBox
    Friend WithEvents irTextBox As TextBox
    Friend WithEvents wRadioButton As RadioButton
    Friend WithEvents oRadioButton As RadioButton
    Friend WithEvents cRadioButton As RadioButton
    Friend WithEvents sGroupBox As GroupBox
End Class
