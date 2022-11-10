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
        Me.ProductListDataSet = New Final.ProductListDataSet()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsTableAdapter = New Final.ProductListDataSetTableAdapters.tblProductsTableAdapter()
        Me.TableAdapterManager = New Final.ProductListDataSetTableAdapters.TableAdapterManager()
        Me.TblProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RunROPReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dpvGroupBox = New System.Windows.Forms.GroupBox()
        Me.lButton = New System.Windows.Forms.Button()
        Me.fButton = New System.Windows.Forms.Button()
        Me.pButton = New System.Windows.Forms.Button()
        Me.nButton = New System.Windows.Forms.Button()
        Me.sddTextBox = New System.Windows.Forms.TextBox()
        Me.sddLabel = New System.Windows.Forms.Label()
        Me.adTextBox = New System.Windows.Forms.TextBox()
        Me.adLabel = New System.Windows.Forms.Label()
        Me.rlTextBox = New System.Windows.Forms.TextBox()
        Me.rlLabel = New System.Windows.Forms.Label()
        Me.uoTextBox = New System.Windows.Forms.TextBox()
        Me.uoLabel = New System.Windows.Forms.Label()
        Me.usTextBox = New System.Windows.Forms.TextBox()
        Me.usLabel = New System.Windows.Forms.Label()
        Me.pTextBox = New System.Windows.Forms.TextBox()
        Me.pLabel = New System.Windows.Forms.Label()
        Me.rpcGroupBox = New System.Windows.Forms.GroupBox()
        Me.rpLabel = New System.Windows.Forms.Label()
        Me.cButton = New System.Windows.Forms.Button()
        Me.tpiButton = New System.Windows.Forms.Button()
        Me.ltComboBox = New System.Windows.Forms.ComboBox()
        Me.slComboBox = New System.Windows.Forms.ComboBox()
        Me.ltLabel = New System.Windows.Forms.Label()
        Me.slLabel = New System.Windows.Forms.Label()
        Me.rp1Label = New System.Windows.Forms.Label()
        Me.sdTextBox = New System.Windows.Forms.TextBox()
        Me.sdLabel = New System.Windows.Forms.Label()
        Me.addTextBox = New System.Windows.Forms.TextBox()
        Me.addLabel = New System.Windows.Forms.Label()
        CType(Me.ProductListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblProductsBindingNavigator.SuspendLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.dpvGroupBox.SuspendLayout()
        Me.rpcGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductListDataSet
        '
        Me.ProductListDataSet.DataSetName = "ProductListDataSet"
        Me.ProductListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.ProductListDataSet
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblProductsTableAdapter = Me.TblProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Final.ProductListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblProductsBindingNavigator
        '
        Me.TblProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblProductsBindingNavigator.BindingSource = Me.TblProductsBindingSource
        Me.TblProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblProductsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblProductsBindingNavigatorSaveItem})
        Me.TblProductsBindingNavigator.Location = New System.Drawing.Point(0, 662)
        Me.TblProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblProductsBindingNavigator.Name = "TblProductsBindingNavigator"
        Me.TblProductsBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.TblProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblProductsBindingNavigator.Size = New System.Drawing.Size(1111, 25)
        Me.TblProductsBindingNavigator.TabIndex = 4
        Me.TblProductsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 23)
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
        'TblProductsBindingNavigatorSaveItem
        '
        Me.TblProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblProductsBindingNavigatorSaveItem.Name = "TblProductsBindingNavigatorSaveItem"
        Me.TblProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(15, 345)
        Me.TblProductsDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(1089, 305)
        Me.TblProductsDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QuantityPerUnit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qty Per Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitsInStock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Units In Stock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitsOnOrder"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Units On Order"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ReorderLevel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Reorder Level"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "AverageDemandLT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Average Demand"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "StandardDevLT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Standard Deviation"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunROPReportToolStripMenuItem, Me.ClearFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1111, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RunROPReportToolStripMenuItem
        '
        Me.RunROPReportToolStripMenuItem.Name = "RunROPReportToolStripMenuItem"
        Me.RunROPReportToolStripMenuItem.Size = New System.Drawing.Size(104, 19)
        Me.RunROPReportToolStripMenuItem.Text = "&Run ROP Report"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(77, 19)
        Me.ClearFormToolStripMenuItem.Text = "&Clear Form"
        '
        'dpvGroupBox
        '
        Me.dpvGroupBox.Controls.Add(Me.lButton)
        Me.dpvGroupBox.Controls.Add(Me.fButton)
        Me.dpvGroupBox.Controls.Add(Me.pButton)
        Me.dpvGroupBox.Controls.Add(Me.nButton)
        Me.dpvGroupBox.Controls.Add(Me.sddTextBox)
        Me.dpvGroupBox.Controls.Add(Me.sddLabel)
        Me.dpvGroupBox.Controls.Add(Me.adTextBox)
        Me.dpvGroupBox.Controls.Add(Me.adLabel)
        Me.dpvGroupBox.Controls.Add(Me.rlTextBox)
        Me.dpvGroupBox.Controls.Add(Me.rlLabel)
        Me.dpvGroupBox.Controls.Add(Me.uoTextBox)
        Me.dpvGroupBox.Controls.Add(Me.uoLabel)
        Me.dpvGroupBox.Controls.Add(Me.usTextBox)
        Me.dpvGroupBox.Controls.Add(Me.usLabel)
        Me.dpvGroupBox.Controls.Add(Me.pTextBox)
        Me.dpvGroupBox.Controls.Add(Me.pLabel)
        Me.dpvGroupBox.Location = New System.Drawing.Point(15, 38)
        Me.dpvGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.dpvGroupBox.Name = "dpvGroupBox"
        Me.dpvGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.dpvGroupBox.Size = New System.Drawing.Size(548, 299)
        Me.dpvGroupBox.TabIndex = 1
        Me.dpvGroupBox.TabStop = False
        Me.dpvGroupBox.Text = "Detail Product View"
        '
        'lButton
        '
        Me.lButton.Location = New System.Drawing.Point(394, 249)
        Me.lButton.Margin = New System.Windows.Forms.Padding(4)
        Me.lButton.Name = "lButton"
        Me.lButton.Size = New System.Drawing.Size(112, 32)
        Me.lButton.TabIndex = 15
        Me.lButton.Text = "Last"
        Me.lButton.UseVisualStyleBackColor = True
        '
        'fButton
        '
        Me.fButton.Location = New System.Drawing.Point(273, 249)
        Me.fButton.Margin = New System.Windows.Forms.Padding(4)
        Me.fButton.Name = "fButton"
        Me.fButton.Size = New System.Drawing.Size(112, 32)
        Me.fButton.TabIndex = 14
        Me.fButton.Text = "First"
        Me.fButton.UseVisualStyleBackColor = True
        '
        'pButton
        '
        Me.pButton.Location = New System.Drawing.Point(152, 249)
        Me.pButton.Margin = New System.Windows.Forms.Padding(4)
        Me.pButton.Name = "pButton"
        Me.pButton.Size = New System.Drawing.Size(112, 32)
        Me.pButton.TabIndex = 13
        Me.pButton.Text = "Previous"
        Me.pButton.UseVisualStyleBackColor = True
        '
        'nButton
        '
        Me.nButton.Location = New System.Drawing.Point(30, 249)
        Me.nButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nButton.Name = "nButton"
        Me.nButton.Size = New System.Drawing.Size(112, 32)
        Me.nButton.TabIndex = 12
        Me.nButton.Text = "Next"
        Me.nButton.UseVisualStyleBackColor = True
        '
        'sddTextBox
        '
        Me.sddTextBox.Location = New System.Drawing.Point(195, 210)
        Me.sddTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.sddTextBox.Name = "sddTextBox"
        Me.sddTextBox.Size = New System.Drawing.Size(148, 24)
        Me.sddTextBox.TabIndex = 11
        '
        'sddLabel
        '
        Me.sddLabel.AutoSize = True
        Me.sddLabel.Location = New System.Drawing.Point(26, 215)
        Me.sddLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sddLabel.Name = "sddLabel"
        Me.sddLabel.Size = New System.Drawing.Size(132, 18)
        Me.sddLabel.TabIndex = 10
        Me.sddLabel.Text = "Std. Dev. Demand:"
        '
        'adTextBox
        '
        Me.adTextBox.Location = New System.Drawing.Point(195, 174)
        Me.adTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.adTextBox.Name = "adTextBox"
        Me.adTextBox.Size = New System.Drawing.Size(148, 24)
        Me.adTextBox.TabIndex = 9
        '
        'adLabel
        '
        Me.adLabel.AutoSize = True
        Me.adLabel.Location = New System.Drawing.Point(26, 179)
        Me.adLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adLabel.Name = "adLabel"
        Me.adLabel.Size = New System.Drawing.Size(125, 18)
        Me.adLabel.TabIndex = 8
        Me.adLabel.Text = "Average Demand:"
        '
        'rlTextBox
        '
        Me.rlTextBox.Location = New System.Drawing.Point(195, 138)
        Me.rlTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.rlTextBox.Name = "rlTextBox"
        Me.rlTextBox.Size = New System.Drawing.Size(148, 24)
        Me.rlTextBox.TabIndex = 7
        '
        'rlLabel
        '
        Me.rlLabel.AutoSize = True
        Me.rlLabel.Location = New System.Drawing.Point(26, 143)
        Me.rlLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rlLabel.Name = "rlLabel"
        Me.rlLabel.Size = New System.Drawing.Size(104, 18)
        Me.rlLabel.TabIndex = 6
        Me.rlLabel.Text = "Reorder Level:"
        '
        'uoTextBox
        '
        Me.uoTextBox.Location = New System.Drawing.Point(195, 102)
        Me.uoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.uoTextBox.Name = "uoTextBox"
        Me.uoTextBox.Size = New System.Drawing.Size(148, 24)
        Me.uoTextBox.TabIndex = 5
        '
        'uoLabel
        '
        Me.uoLabel.AutoSize = True
        Me.uoLabel.Location = New System.Drawing.Point(26, 107)
        Me.uoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uoLabel.Name = "uoLabel"
        Me.uoLabel.Size = New System.Drawing.Size(109, 18)
        Me.uoLabel.TabIndex = 4
        Me.uoLabel.Text = "Units on Order:"
        '
        'usTextBox
        '
        Me.usTextBox.Location = New System.Drawing.Point(195, 66)
        Me.usTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.usTextBox.Name = "usTextBox"
        Me.usTextBox.Size = New System.Drawing.Size(148, 24)
        Me.usTextBox.TabIndex = 3
        '
        'usLabel
        '
        Me.usLabel.AutoSize = True
        Me.usLabel.Location = New System.Drawing.Point(26, 71)
        Me.usLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.usLabel.Name = "usLabel"
        Me.usLabel.Size = New System.Drawing.Size(104, 18)
        Me.usLabel.TabIndex = 2
        Me.usLabel.Text = "Units in Stock:"
        '
        'pTextBox
        '
        Me.pTextBox.Location = New System.Drawing.Point(195, 30)
        Me.pTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.pTextBox.Name = "pTextBox"
        Me.pTextBox.Size = New System.Drawing.Size(308, 24)
        Me.pTextBox.TabIndex = 1
        '
        'pLabel
        '
        Me.pLabel.AutoSize = True
        Me.pLabel.Location = New System.Drawing.Point(26, 35)
        Me.pLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(64, 18)
        Me.pLabel.TabIndex = 0
        Me.pLabel.Text = "Product:"
        '
        'rpcGroupBox
        '
        Me.rpcGroupBox.Controls.Add(Me.rpLabel)
        Me.rpcGroupBox.Controls.Add(Me.cButton)
        Me.rpcGroupBox.Controls.Add(Me.tpiButton)
        Me.rpcGroupBox.Controls.Add(Me.ltComboBox)
        Me.rpcGroupBox.Controls.Add(Me.slComboBox)
        Me.rpcGroupBox.Controls.Add(Me.ltLabel)
        Me.rpcGroupBox.Controls.Add(Me.slLabel)
        Me.rpcGroupBox.Controls.Add(Me.rp1Label)
        Me.rpcGroupBox.Controls.Add(Me.sdTextBox)
        Me.rpcGroupBox.Controls.Add(Me.sdLabel)
        Me.rpcGroupBox.Controls.Add(Me.addTextBox)
        Me.rpcGroupBox.Controls.Add(Me.addLabel)
        Me.rpcGroupBox.Location = New System.Drawing.Point(571, 38)
        Me.rpcGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.rpcGroupBox.Name = "rpcGroupBox"
        Me.rpcGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.rpcGroupBox.Size = New System.Drawing.Size(533, 299)
        Me.rpcGroupBox.TabIndex = 2
        Me.rpcGroupBox.TabStop = False
        Me.rpcGroupBox.Text = "Reorder Point Calculator"
        '
        'rpLabel
        '
        Me.rpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rpLabel.Location = New System.Drawing.Point(188, 179)
        Me.rpLabel.Name = "rpLabel"
        Me.rpLabel.Size = New System.Drawing.Size(148, 22)
        Me.rpLabel.TabIndex = 9
        '
        'cButton
        '
        Me.cButton.Location = New System.Drawing.Point(254, 245)
        Me.cButton.Margin = New System.Windows.Forms.Padding(4)
        Me.cButton.Name = "cButton"
        Me.cButton.Size = New System.Drawing.Size(188, 36)
        Me.cButton.TabIndex = 11
        Me.cButton.Text = "Calculate ROP"
        Me.cButton.UseVisualStyleBackColor = True
        '
        'tpiButton
        '
        Me.tpiButton.Location = New System.Drawing.Point(32, 245)
        Me.tpiButton.Margin = New System.Windows.Forms.Padding(4)
        Me.tpiButton.Name = "tpiButton"
        Me.tpiButton.Size = New System.Drawing.Size(188, 36)
        Me.tpiButton.TabIndex = 10
        Me.tpiButton.Text = "Transfer Product Info"
        Me.tpiButton.UseVisualStyleBackColor = True
        '
        'ltComboBox
        '
        Me.ltComboBox.FormattingEnabled = True
        Me.ltComboBox.Location = New System.Drawing.Point(188, 140)
        Me.ltComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ltComboBox.Name = "ltComboBox"
        Me.ltComboBox.Size = New System.Drawing.Size(148, 26)
        Me.ltComboBox.TabIndex = 7
        '
        'slComboBox
        '
        Me.slComboBox.FormattingEnabled = True
        Me.slComboBox.Location = New System.Drawing.Point(188, 102)
        Me.slComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.slComboBox.Name = "slComboBox"
        Me.slComboBox.Size = New System.Drawing.Size(148, 26)
        Me.slComboBox.TabIndex = 5
        '
        'ltLabel
        '
        Me.ltLabel.AutoSize = True
        Me.ltLabel.Location = New System.Drawing.Point(27, 144)
        Me.ltLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ltLabel.Name = "ltLabel"
        Me.ltLabel.Size = New System.Drawing.Size(126, 18)
        Me.ltLabel.TabIndex = 6
        Me.ltLabel.Text = "Lead Time (days):"
        '
        'slLabel
        '
        Me.slLabel.AutoSize = True
        Me.slLabel.Location = New System.Drawing.Point(27, 107)
        Me.slLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.slLabel.Name = "slLabel"
        Me.slLabel.Size = New System.Drawing.Size(99, 18)
        Me.slLabel.TabIndex = 4
        Me.slLabel.Text = "Service Level:"
        '
        'rp1Label
        '
        Me.rp1Label.AutoSize = True
        Me.rp1Label.Location = New System.Drawing.Point(27, 183)
        Me.rp1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rp1Label.Name = "rp1Label"
        Me.rp1Label.Size = New System.Drawing.Size(104, 18)
        Me.rp1Label.TabIndex = 8
        Me.rp1Label.Text = "Reorder Point:"
        '
        'sdTextBox
        '
        Me.sdTextBox.Location = New System.Drawing.Point(188, 66)
        Me.sdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.sdTextBox.Name = "sdTextBox"
        Me.sdTextBox.Size = New System.Drawing.Size(113, 24)
        Me.sdTextBox.TabIndex = 3
        '
        'sdLabel
        '
        Me.sdLabel.AutoSize = True
        Me.sdLabel.Location = New System.Drawing.Point(27, 71)
        Me.sdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sdLabel.Name = "sdLabel"
        Me.sdLabel.Size = New System.Drawing.Size(136, 18)
        Me.sdLabel.TabIndex = 2
        Me.sdLabel.Text = "Standard Deviation:"
        '
        'addTextBox
        '
        Me.addTextBox.Location = New System.Drawing.Point(188, 30)
        Me.addTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.addTextBox.Name = "addTextBox"
        Me.addTextBox.Size = New System.Drawing.Size(113, 24)
        Me.addTextBox.TabIndex = 1
        '
        'addLabel
        '
        Me.addLabel.AutoSize = True
        Me.addLabel.Location = New System.Drawing.Point(27, 35)
        Me.addLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addLabel.Name = "addLabel"
        Me.addLabel.Size = New System.Drawing.Size(125, 18)
        Me.addLabel.TabIndex = 0
        Me.addLabel.Text = "Average Demand:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(1111, 687)
        Me.Controls.Add(Me.rpcGroupBox)
        Me.Controls.Add(Me.dpvGroupBox)
        Me.Controls.Add(Me.TblProductsDataGridView)
        Me.Controls.Add(Me.TblProductsBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Final - Inventory Control System"
        CType(Me.ProductListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblProductsBindingNavigator.ResumeLayout(False)
        Me.TblProductsBindingNavigator.PerformLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.dpvGroupBox.ResumeLayout(False)
        Me.dpvGroupBox.PerformLayout()
        Me.rpcGroupBox.ResumeLayout(False)
        Me.rpcGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductListDataSet As ProductListDataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As ProductListDataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TableAdapterManager As ProductListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProductsBindingNavigator As BindingNavigator
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
    Friend WithEvents TblProductsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RunROPReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dpvGroupBox As GroupBox
    Friend WithEvents lButton As Button
    Friend WithEvents fButton As Button
    Friend WithEvents pButton As Button
    Friend WithEvents nButton As Button
    Friend WithEvents sddTextBox As TextBox
    Friend WithEvents sddLabel As Label
    Friend WithEvents adTextBox As TextBox
    Friend WithEvents adLabel As Label
    Friend WithEvents rlTextBox As TextBox
    Friend WithEvents rlLabel As Label
    Friend WithEvents uoTextBox As TextBox
    Friend WithEvents uoLabel As Label
    Friend WithEvents usTextBox As TextBox
    Friend WithEvents usLabel As Label
    Friend WithEvents pTextBox As TextBox
    Friend WithEvents pLabel As Label
    Friend WithEvents rpcGroupBox As GroupBox
    Friend WithEvents cButton As Button
    Friend WithEvents tpiButton As Button
    Friend WithEvents ltComboBox As ComboBox
    Friend WithEvents slComboBox As ComboBox
    Friend WithEvents ltLabel As Label
    Friend WithEvents slLabel As Label
    Friend WithEvents rp1Label As Label
    Friend WithEvents sdTextBox As TextBox
    Friend WithEvents sdLabel As Label
    Friend WithEvents addTextBox As TextBox
    Friend WithEvents addLabel As Label
    Friend WithEvents rpLabel As Label
End Class
