<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignInForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SignInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToOtherFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreapprovalChackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientDataReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cuLabel = New System.Windows.Forms.Label()
        Me.cu1Label = New System.Windows.Forms.Label()
        Me.plLabel = New System.Windows.Forms.Label()
        Me.pl1Label = New System.Windows.Forms.Label()
        Me.uLabel = New System.Windows.Forms.Label()
        Me.pLabel = New System.Windows.Forms.Label()
        Me.uTextBox = New System.Windows.Forms.TextBox()
        Me.pTextBox = New System.Windows.Forms.TextBox()
        Me.AuthenticationDataSet = New CP2_1_NikitaSotnikov.AuthenticationDataSet()
        Me.TblAuthenticationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAuthenticationTableAdapter = New CP2_1_NikitaSotnikov.AuthenticationDataSetTableAdapters.tblAuthenticationTableAdapter()
        Me.TableAdapterManager = New CP2_1_NikitaSotnikov.AuthenticationDataSetTableAdapters.TableAdapterManager()
        Me.TblAuthenticationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblAuthenticationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblAuthenticationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AuthenticationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAuthenticationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAuthenticationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblAuthenticationBindingNavigator.SuspendLayout()
        CType(Me.TblAuthenticationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignInToolStripMenuItem, Me.NavigateToOtherFormsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(651, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SignInToolStripMenuItem
        '
        Me.SignInToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.SignInToolStripMenuItem.Name = "SignInToolStripMenuItem"
        Me.SignInToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SignInToolStripMenuItem.Text = "&SignIn"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogInToolStripMenuItem.Text = "Log &In"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log &Out"
        '
        'NavigateToOtherFormsToolStripMenuItem
        '
        Me.NavigateToOtherFormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreapprovalChackToolStripMenuItem, Me.ClientDataReportToolStripMenuItem})
        Me.NavigateToOtherFormsToolStripMenuItem.Name = "NavigateToOtherFormsToolStripMenuItem"
        Me.NavigateToOtherFormsToolStripMenuItem.Size = New System.Drawing.Size(149, 20)
        Me.NavigateToOtherFormsToolStripMenuItem.Text = "&Navigate to Other Forms"
        '
        'PreapprovalChackToolStripMenuItem
        '
        Me.PreapprovalChackToolStripMenuItem.Name = "PreapprovalChackToolStripMenuItem"
        Me.PreapprovalChackToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PreapprovalChackToolStripMenuItem.Text = "&Preapproval Chack"
        '
        'ClientDataReportToolStripMenuItem
        '
        Me.ClientDataReportToolStripMenuItem.Name = "ClientDataReportToolStripMenuItem"
        Me.ClientDataReportToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClientDataReportToolStripMenuItem.Text = "&Client Data Report"
        '
        'cuLabel
        '
        Me.cuLabel.AutoSize = True
        Me.cuLabel.Location = New System.Drawing.Point(43, 65)
        Me.cuLabel.Name = "cuLabel"
        Me.cuLabel.Size = New System.Drawing.Size(104, 20)
        Me.cuLabel.TabIndex = 1
        Me.cuLabel.Text = "Current User:"
        '
        'cu1Label
        '
        Me.cu1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cu1Label.Location = New System.Drawing.Point(153, 64)
        Me.cu1Label.Name = "cu1Label"
        Me.cu1Label.Size = New System.Drawing.Size(159, 26)
        Me.cu1Label.TabIndex = 2
        '
        'plLabel
        '
        Me.plLabel.AutoSize = True
        Me.plLabel.Location = New System.Drawing.Point(16, 97)
        Me.plLabel.Name = "plLabel"
        Me.plLabel.Size = New System.Drawing.Size(131, 20)
        Me.plLabel.TabIndex = 3
        Me.plLabel.Text = "Permission Level:"
        '
        'pl1Label
        '
        Me.pl1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl1Label.Location = New System.Drawing.Point(153, 96)
        Me.pl1Label.Name = "pl1Label"
        Me.pl1Label.Size = New System.Drawing.Size(159, 26)
        Me.pl1Label.TabIndex = 4
        '
        'uLabel
        '
        Me.uLabel.AutoSize = True
        Me.uLabel.Location = New System.Drawing.Point(60, 143)
        Me.uLabel.Name = "uLabel"
        Me.uLabel.Size = New System.Drawing.Size(87, 20)
        Me.uLabel.TabIndex = 5
        Me.uLabel.Text = "Username:"
        '
        'pLabel
        '
        Me.pLabel.AutoSize = True
        Me.pLabel.Location = New System.Drawing.Point(65, 172)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(82, 20)
        Me.pLabel.TabIndex = 7
        Me.pLabel.Text = "Password:"
        '
        'uTextBox
        '
        Me.uTextBox.Location = New System.Drawing.Point(153, 137)
        Me.uTextBox.Name = "uTextBox"
        Me.uTextBox.Size = New System.Drawing.Size(159, 26)
        Me.uTextBox.TabIndex = 6
        '
        'pTextBox
        '
        Me.pTextBox.Location = New System.Drawing.Point(153, 169)
        Me.pTextBox.Name = "pTextBox"
        Me.pTextBox.Size = New System.Drawing.Size(159, 26)
        Me.pTextBox.TabIndex = 8
        '
        'AuthenticationDataSet
        '
        Me.AuthenticationDataSet.DataSetName = "AuthenticationDataSet"
        Me.AuthenticationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAuthenticationBindingSource
        '
        Me.TblAuthenticationBindingSource.DataMember = "tblAuthentication"
        Me.TblAuthenticationBindingSource.DataSource = Me.AuthenticationDataSet
        '
        'TblAuthenticationTableAdapter
        '
        Me.TblAuthenticationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAuthenticationTableAdapter = Me.TblAuthenticationTableAdapter
        Me.TableAdapterManager.UpdateOrder = CP2_1_NikitaSotnikov.AuthenticationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblAuthenticationBindingNavigator
        '
        Me.TblAuthenticationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblAuthenticationBindingNavigator.BindingSource = Me.TblAuthenticationBindingSource
        Me.TblAuthenticationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblAuthenticationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblAuthenticationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblAuthenticationBindingNavigatorSaveItem})
        Me.TblAuthenticationBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.TblAuthenticationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblAuthenticationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblAuthenticationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblAuthenticationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblAuthenticationBindingNavigator.Name = "TblAuthenticationBindingNavigator"
        Me.TblAuthenticationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblAuthenticationBindingNavigator.Size = New System.Drawing.Size(651, 25)
        Me.TblAuthenticationBindingNavigator.TabIndex = 9
        Me.TblAuthenticationBindingNavigator.Text = "BindingNavigator1"
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
        'TblAuthenticationBindingNavigatorSaveItem
        '
        Me.TblAuthenticationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblAuthenticationBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblAuthenticationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblAuthenticationBindingNavigatorSaveItem.Name = "TblAuthenticationBindingNavigatorSaveItem"
        Me.TblAuthenticationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblAuthenticationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblAuthenticationDataGridView
        '
        Me.TblAuthenticationDataGridView.AutoGenerateColumns = False
        Me.TblAuthenticationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblAuthenticationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblAuthenticationDataGridView.DataSource = Me.TblAuthenticationBindingSource
        Me.TblAuthenticationDataGridView.Location = New System.Drawing.Point(1, 201)
        Me.TblAuthenticationDataGridView.Name = "TblAuthenticationDataGridView"
        Me.TblAuthenticationDataGridView.Size = New System.Drawing.Size(644, 281)
        Me.TblAuthenticationDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PermissionLevel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PermissionLevel"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'SignInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 554)
        Me.Controls.Add(Me.TblAuthenticationDataGridView)
        Me.Controls.Add(Me.TblAuthenticationBindingNavigator)
        Me.Controls.Add(Me.pTextBox)
        Me.Controls.Add(Me.uTextBox)
        Me.Controls.Add(Me.pLabel)
        Me.Controls.Add(Me.uLabel)
        Me.Controls.Add(Me.pl1Label)
        Me.Controls.Add(Me.plLabel)
        Me.Controls.Add(Me.cu1Label)
        Me.Controls.Add(Me.cuLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignInForm"
        Me.Text = "Sign In and Navigation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AuthenticationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAuthenticationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAuthenticationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblAuthenticationBindingNavigator.ResumeLayout(False)
        Me.TblAuthenticationBindingNavigator.PerformLayout()
        CType(Me.TblAuthenticationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SignInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigateToOtherFormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreapprovalChackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientDataReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cuLabel As Label
    Friend WithEvents cu1Label As Label
    Friend WithEvents plLabel As Label
    Friend WithEvents pl1Label As Label
    Friend WithEvents uLabel As Label
    Friend WithEvents pLabel As Label
    Friend WithEvents uTextBox As TextBox
    Friend WithEvents pTextBox As TextBox
    Friend WithEvents AuthenticationDataSet As AuthenticationDataSet
    Friend WithEvents TblAuthenticationBindingSource As BindingSource
    Friend WithEvents TblAuthenticationTableAdapter As AuthenticationDataSetTableAdapters.tblAuthenticationTableAdapter
    Friend WithEvents TableAdapterManager As AuthenticationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblAuthenticationBindingNavigator As BindingNavigator
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
    Friend WithEvents TblAuthenticationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblAuthenticationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
