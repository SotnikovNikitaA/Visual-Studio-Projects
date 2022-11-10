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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesDataSet = New LAP_6.GamesDataSet()
        Me.TblGamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGamesTableAdapter = New LAP_6.GamesDataSetTableAdapters.tblGamesTableAdapter()
        Me.TableAdapterManager = New LAP_6.GamesDataSetTableAdapters.TableAdapterManager()
        Me.TblGamesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblGamesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblGamesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gfGroupBox = New System.Windows.Forms.GroupBox()
        Me.gComboBox = New System.Windows.Forms.ComboBox()
        Me.gLabel = New System.Windows.Forms.Label()
        Me.tComboBox = New System.Windows.Forms.ComboBox()
        Me.tLabel = New System.Windows.Forms.Label()
        Me.maxComboBox = New System.Windows.Forms.ComboBox()
        Me.maxLabel = New System.Windows.Forms.Label()
        Me.minComboBox = New System.Windows.Forms.ComboBox()
        Me.minLabel = New System.Windows.Forms.Label()
        Me.gfTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GamesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGamesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblGamesBindingNavigator.SuspendLayout()
        CType(Me.TblGamesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gfGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1165, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'GamesDataSet
        '
        Me.GamesDataSet.DataSetName = "GamesDataSet"
        Me.GamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGamesBindingSource
        '
        Me.TblGamesBindingSource.DataMember = "tblGames"
        Me.TblGamesBindingSource.DataSource = Me.GamesDataSet
        '
        'TblGamesTableAdapter
        '
        Me.TblGamesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGamesTableAdapter = Me.TblGamesTableAdapter
        Me.TableAdapterManager.UpdateOrder = LAP_6.GamesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblGamesBindingNavigator
        '
        Me.TblGamesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblGamesBindingNavigator.BindingSource = Me.TblGamesBindingSource
        Me.TblGamesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblGamesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblGamesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblGamesBindingNavigatorSaveItem})
        Me.TblGamesBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.TblGamesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblGamesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblGamesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblGamesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblGamesBindingNavigator.Name = "TblGamesBindingNavigator"
        Me.TblGamesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblGamesBindingNavigator.Size = New System.Drawing.Size(1165, 25)
        Me.TblGamesBindingNavigator.TabIndex = 1
        Me.TblGamesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblGamesBindingNavigatorSaveItem
        '
        Me.TblGamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblGamesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblGamesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblGamesBindingNavigatorSaveItem.Name = "TblGamesBindingNavigatorSaveItem"
        Me.TblGamesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblGamesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblGamesDataGridView
        '
        Me.TblGamesDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblGamesDataGridView.AutoGenerateColumns = False
        Me.TblGamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblGamesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TblGamesDataGridView.DataSource = Me.TblGamesBindingSource
        Me.TblGamesDataGridView.Location = New System.Drawing.Point(12, 61)
        Me.TblGamesDataGridView.Name = "TblGamesDataGridView"
        Me.TblGamesDataGridView.Size = New System.Drawing.Size(1134, 278)
        Me.TblGamesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Game Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "YearRelease"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Year Release"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NumMinPlayers"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Minimum Players"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NumMaxPlayers"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Maximum Players"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'gfGroupBox
        '
        Me.gfGroupBox.Controls.Add(Me.gComboBox)
        Me.gfGroupBox.Controls.Add(Me.gLabel)
        Me.gfGroupBox.Controls.Add(Me.tComboBox)
        Me.gfGroupBox.Controls.Add(Me.tLabel)
        Me.gfGroupBox.Controls.Add(Me.maxComboBox)
        Me.gfGroupBox.Controls.Add(Me.maxLabel)
        Me.gfGroupBox.Controls.Add(Me.minComboBox)
        Me.gfGroupBox.Controls.Add(Me.minLabel)
        Me.gfGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.gfGroupBox.Location = New System.Drawing.Point(12, 358)
        Me.gfGroupBox.Name = "gfGroupBox"
        Me.gfGroupBox.Size = New System.Drawing.Size(1134, 73)
        Me.gfGroupBox.TabIndex = 3
        Me.gfGroupBox.TabStop = False
        Me.gfGroupBox.Text = "Game Filter"
        '
        'gComboBox
        '
        Me.gComboBox.FormattingEnabled = True
        Me.gComboBox.IntegralHeight = False
        Me.gComboBox.Items.AddRange(New Object() {"Co-op", "Fighting", "FPS", "Horror", "Open World", "Party", "Platformer", "Racing", "Roll and Move", "RPG", "Sandbox", "Strategy", "Trick Taking"})
        Me.gComboBox.Location = New System.Drawing.Point(960, 26)
        Me.gComboBox.MaxDropDownItems = 6
        Me.gComboBox.Name = "gComboBox"
        Me.gComboBox.Size = New System.Drawing.Size(124, 26)
        Me.gComboBox.TabIndex = 7
        '
        'gLabel
        '
        Me.gLabel.AutoSize = True
        Me.gLabel.Location = New System.Drawing.Point(909, 29)
        Me.gLabel.Name = "gLabel"
        Me.gLabel.Size = New System.Drawing.Size(49, 18)
        Me.gLabel.TabIndex = 6
        Me.gLabel.Text = "Genre"
        '
        'tComboBox
        '
        Me.tComboBox.FormattingEnabled = True
        Me.tComboBox.IntegralHeight = False
        Me.tComboBox.Items.AddRange(New Object() {"Video Game", "Board Game", "Card Game"})
        Me.tComboBox.Location = New System.Drawing.Point(701, 26)
        Me.tComboBox.MaxDropDownItems = 6
        Me.tComboBox.Name = "tComboBox"
        Me.tComboBox.Size = New System.Drawing.Size(146, 26)
        Me.tComboBox.TabIndex = 5
        '
        'tLabel
        '
        Me.tLabel.AutoSize = True
        Me.tLabel.Location = New System.Drawing.Point(652, 29)
        Me.tLabel.Name = "tLabel"
        Me.tLabel.Size = New System.Drawing.Size(44, 18)
        Me.tLabel.TabIndex = 4
        Me.tLabel.Text = "Type:"
        '
        'maxComboBox
        '
        Me.maxComboBox.FormattingEnabled = True
        Me.maxComboBox.IntegralHeight = False
        Me.maxComboBox.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.maxComboBox.Location = New System.Drawing.Point(534, 26)
        Me.maxComboBox.MaxDropDownItems = 6
        Me.maxComboBox.Name = "maxComboBox"
        Me.maxComboBox.Size = New System.Drawing.Size(56, 26)
        Me.maxComboBox.TabIndex = 3
        '
        'maxLabel
        '
        Me.maxLabel.AutoSize = True
        Me.maxLabel.Location = New System.Drawing.Point(324, 29)
        Me.maxLabel.Name = "maxLabel"
        Me.maxLabel.Size = New System.Drawing.Size(204, 18)
        Me.maxLabel.TabIndex = 2
        Me.maxLabel.Text = "Maximum Number of Players:"
        '
        'minComboBox
        '
        Me.minComboBox.FormattingEnabled = True
        Me.minComboBox.IntegralHeight = False
        Me.minComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.minComboBox.Location = New System.Drawing.Point(212, 26)
        Me.minComboBox.MaxDropDownItems = 6
        Me.minComboBox.Name = "minComboBox"
        Me.minComboBox.Size = New System.Drawing.Size(56, 26)
        Me.minComboBox.TabIndex = 1
        '
        'minLabel
        '
        Me.minLabel.AutoSize = True
        Me.minLabel.Location = New System.Drawing.Point(6, 29)
        Me.minLabel.Name = "minLabel"
        Me.minLabel.Size = New System.Drawing.Size(200, 18)
        Me.minLabel.TabIndex = 0
        Me.minLabel.Text = "Minimum Number of Players:"
        '
        'gfTextBox
        '
        Me.gfTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gfTextBox.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.gfTextBox.Location = New System.Drawing.Point(12, 446)
        Me.gfTextBox.Multiline = True
        Me.gfTextBox.Name = "gfTextBox"
        Me.gfTextBox.ReadOnly = True
        Me.gfTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gfTextBox.Size = New System.Drawing.Size(1134, 275)
        Me.gfTextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1165, 733)
        Me.Controls.Add(Me.gfTextBox)
        Me.Controls.Add(Me.gfGroupBox)
        Me.Controls.Add(Me.TblGamesDataGridView)
        Me.Controls.Add(Me.TblGamesBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "LAP 6 - Game App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GamesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGamesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblGamesBindingNavigator.ResumeLayout(False)
        Me.TblGamesBindingNavigator.PerformLayout()
        CType(Me.TblGamesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gfGroupBox.ResumeLayout(False)
        Me.gfGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GamesDataSet As GamesDataSet
    Friend WithEvents TblGamesBindingSource As BindingSource
    Friend WithEvents TblGamesTableAdapter As GamesDataSetTableAdapters.tblGamesTableAdapter
    Friend WithEvents TableAdapterManager As GamesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblGamesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblGamesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblGamesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents gfGroupBox As GroupBox
    Friend WithEvents gComboBox As ComboBox
    Friend WithEvents gLabel As Label
    Friend WithEvents tComboBox As ComboBox
    Friend WithEvents tLabel As Label
    Friend WithEvents maxComboBox As ComboBox
    Friend WithEvents maxLabel As Label
    Friend WithEvents minComboBox As ComboBox
    Friend WithEvents minLabel As Label
    Friend WithEvents gfTextBox As TextBox
End Class
