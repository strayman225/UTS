<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voucher_Form
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
        Dim VoucherdateLabel As System.Windows.Forms.Label
        Dim AcadyearLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim TotalGranteesLabel As System.Windows.Forms.Label
        Dim Hei_UiiLabel As System.Windows.Forms.Label
        Dim SemesterLabel1 As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Voucher_Form))
        Me.Voucher_DataSet = New UniFAST_Tracking_System.Voucher_DataSet()
        Me.VoucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VoucherTableAdapter = New UniFAST_Tracking_System.Voucher_DataSetTableAdapters.VoucherTableAdapter()
        Me.TableAdapterManager = New UniFAST_Tracking_System.Voucher_DataSetTableAdapters.TableAdapterManager()
        Me.VoucherBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VoucherBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VoucherdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.TotalGranteesTextBox = New System.Windows.Forms.TextBox()
        Me.Heis_DataSet = New UniFAST_Tracking_System.Heis_DataSet()
        Me.HeisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeisTableAdapter = New UniFAST_Tracking_System.Heis_DataSetTableAdapters.heisTableAdapter()
        Me.VoucherDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AcadyearComboBox = New System.Windows.Forms.ComboBox()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        VoucherdateLabel = New System.Windows.Forms.Label()
        AcadyearLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        TotalGranteesLabel = New System.Windows.Forms.Label()
        Hei_UiiLabel = New System.Windows.Forms.Label()
        SemesterLabel1 = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VoucherBindingNavigator.SuspendLayout()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VoucherdateLabel
        '
        VoucherdateLabel.AutoSize = True
        VoucherdateLabel.Location = New System.Drawing.Point(276, 136)
        VoucherdateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VoucherdateLabel.Name = "VoucherdateLabel"
        VoucherdateLabel.Size = New System.Drawing.Size(78, 15)
        VoucherdateLabel.TabIndex = 5
        VoucherdateLabel.Text = "voucherdate:"
        AddHandler VoucherdateLabel.Click, AddressOf Me.VoucherdateLabel_Click
        '
        'AcadyearLabel
        '
        AcadyearLabel.AutoSize = True
        AcadyearLabel.Location = New System.Drawing.Point(29, 211)
        AcadyearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AcadyearLabel.Name = "AcadyearLabel"
        AcadyearLabel.Size = New System.Drawing.Size(61, 15)
        AcadyearLabel.TabIndex = 7
        AcadyearLabel.Text = "acadyear:"
        AddHandler AcadyearLabel.Click, AddressOf Me.AcadyearLabel_Click
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(28, 282)
        AmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(52, 15)
        AmountLabel.TabIndex = 13
        AmountLabel.Text = "Amount:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(29, 324)
        RemarksLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(57, 15)
        RemarksLabel.TabIndex = 23
        RemarksLabel.Text = "Remarks:"
        '
        'TotalGranteesLabel
        '
        TotalGranteesLabel.AutoSize = True
        TotalGranteesLabel.Location = New System.Drawing.Point(409, 277)
        TotalGranteesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalGranteesLabel.Name = "TotalGranteesLabel"
        TotalGranteesLabel.Size = New System.Drawing.Size(89, 15)
        TotalGranteesLabel.TabIndex = 25
        TotalGranteesLabel.Text = "Total Grantees:"
        '
        'Hei_UiiLabel
        '
        Hei_UiiLabel.AutoSize = True
        Hei_UiiLabel.Location = New System.Drawing.Point(29, 177)
        Hei_UiiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Hei_UiiLabel.Name = "Hei_UiiLabel"
        Hei_UiiLabel.Size = New System.Drawing.Size(47, 15)
        Hei_UiiLabel.TabIndex = 28
        Hei_UiiLabel.Text = "Hei Uii:"
        AddHandler Hei_UiiLabel.Click, AddressOf Me.Hei_UiiLabel_Click
        '
        'SemesterLabel1
        '
        SemesterLabel1.AutoSize = True
        SemesterLabel1.Location = New System.Drawing.Point(327, 206)
        SemesterLabel1.Name = "SemesterLabel1"
        SemesterLabel1.Size = New System.Drawing.Size(59, 15)
        SemesterLabel1.TabIndex = 31
        SemesterLabel1.Text = "semester:"
        AddHandler SemesterLabel1.Click, AddressOf Me.SemesterLabel1_Click
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(28, 239)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(57, 15)
        CategoryLabel.TabIndex = 32
        CategoryLabel.Text = "category:"
        '
        'Voucher_DataSet
        '
        Me.Voucher_DataSet.DataSetName = "Voucher_DataSet"
        Me.Voucher_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VoucherBindingSource
        '
        Me.VoucherBindingSource.DataMember = "Voucher"
        Me.VoucherBindingSource.DataSource = Me.Voucher_DataSet
        '
        'VoucherTableAdapter
        '
        Me.VoucherTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = UniFAST_Tracking_System.Voucher_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VoucherTableAdapter = Me.VoucherTableAdapter
        '
        'VoucherBindingNavigator
        '
        Me.VoucherBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VoucherBindingNavigator.BindingSource = Me.VoucherBindingSource
        Me.VoucherBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VoucherBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VoucherBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VoucherBindingNavigatorSaveItem})
        Me.VoucherBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VoucherBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VoucherBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VoucherBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VoucherBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VoucherBindingNavigator.Name = "VoucherBindingNavigator"
        Me.VoucherBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VoucherBindingNavigator.Size = New System.Drawing.Size(611, 25)
        Me.VoucherBindingNavigator.TabIndex = 0
        Me.VoucherBindingNavigator.Text = "BindingNavigator1"
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
        'VoucherBindingNavigatorSaveItem
        '
        Me.VoucherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VoucherBindingNavigatorSaveItem.Image = CType(resources.GetObject("VoucherBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VoucherBindingNavigatorSaveItem.Name = "VoucherBindingNavigatorSaveItem"
        Me.VoucherBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VoucherBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VoucherdateDateTimePicker
        '
        Me.VoucherdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VoucherBindingSource, "voucherdate", True))
        Me.VoucherdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "voucherdate", True))
        Me.VoucherdateDateTimePicker.Location = New System.Drawing.Point(360, 128)
        Me.VoucherdateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.VoucherdateDateTimePicker.Name = "VoucherdateDateTimePicker"
        Me.VoucherdateDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.VoucherdateDateTimePicker.TabIndex = 6
        '
        'AmountTextBox
        '
        Me.AmountTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "Amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.ForeColor = System.Drawing.Color.Yellow
        Me.AmountTextBox.Location = New System.Drawing.Point(147, 265)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(233, 40)
        Me.AmountTextBox.TabIndex = 14
        Me.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(147, 324)
        Me.RemarksTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(446, 82)
        Me.RemarksTextBox.TabIndex = 24
        '
        'TotalGranteesTextBox
        '
        Me.TotalGranteesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "TotalGrantees", True))
        Me.TotalGranteesTextBox.Location = New System.Drawing.Point(508, 274)
        Me.TotalGranteesTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TotalGranteesTextBox.Name = "TotalGranteesTextBox"
        Me.TotalGranteesTextBox.Size = New System.Drawing.Size(85, 23)
        Me.TotalGranteesTextBox.TabIndex = 26
        '
        'Heis_DataSet
        '
        Me.Heis_DataSet.DataSetName = "Heis_DataSet"
        Me.Heis_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeisBindingSource
        '
        Me.HeisBindingSource.DataMember = "heis"
        Me.HeisBindingSource.DataSource = Me.Heis_DataSet
        '
        'HeisTableAdapter
        '
        Me.HeisTableAdapter.ClearBeforeFill = True
        '
        'VoucherDataGridView
        '
        Me.VoucherDataGridView.AllowUserToAddRows = False
        Me.VoucherDataGridView.AllowUserToDeleteRows = False
        Me.VoucherDataGridView.AutoGenerateColumns = False
        Me.VoucherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VoucherDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.VoucherDataGridView.DataSource = Me.VoucherBindingSource
        Me.VoucherDataGridView.Location = New System.Drawing.Point(12, 412)
        Me.VoucherDataGridView.Name = "VoucherDataGridView"
        Me.VoucherDataGridView.ReadOnly = True
        Me.VoucherDataGridView.Size = New System.Drawing.Size(583, 206)
        Me.VoucherDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VoucherID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "VoucherID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Hei_Uii"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.HeisBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "HEI_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hei_Uii"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Hei_Uii"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "voucherdate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "voucherdate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "acadyear"
        Me.DataGridViewTextBoxColumn4.HeaderText = "acadyear"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "semester"
        Me.DataGridViewTextBoxColumn5.HeaderText = "semester"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "category"
        Me.DataGridViewTextBoxColumn6.HeaderText = "category"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Amount_Liquidated"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Amount_Liquidated"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DV"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DV"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DV_date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DV_date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ADA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ADA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ADA_date"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ADA_date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TotalGrantees"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TotalGrantees"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VoucherBindingSource, "Hei_Uii", True))
        Me.ComboBox1.DataSource = Me.HeisBindingSource
        Me.ComboBox1.DisplayMember = "HEI_Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(446, 23)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.ValueMember = "Hei_Uii"
        '
        'AcadyearComboBox
        '
        Me.AcadyearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "acadyear", True))
        Me.AcadyearComboBox.FormattingEnabled = True
        Me.AcadyearComboBox.Items.AddRange(New Object() {"2020 - 2021", "2021 - 2022", "2022 - 2023", "2023 - 2024", "2024 - 2025"})
        Me.AcadyearComboBox.Location = New System.Drawing.Point(147, 203)
        Me.AcadyearComboBox.Name = "AcadyearComboBox"
        Me.AcadyearComboBox.Size = New System.Drawing.Size(166, 23)
        Me.AcadyearComboBox.TabIndex = 31
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "semester", True))
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"First Semester", "Second Semester"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(390, 203)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(121, 23)
        Me.SemesterComboBox.TabIndex = 32
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "category", True))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"TES", "TDP", "TES asc", "TDP asc", "3a", "3b", "StuFAP"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(147, 236)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 23)
        Me.CategoryComboBox.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(518, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Voucher_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 630)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(SemesterLabel1)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.AcadyearComboBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.VoucherDataGridView)
        Me.Controls.Add(Hei_UiiLabel)
        Me.Controls.Add(VoucherdateLabel)
        Me.Controls.Add(Me.VoucherdateDateTimePicker)
        Me.Controls.Add(AcadyearLabel)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(TotalGranteesLabel)
        Me.Controls.Add(Me.TotalGranteesTextBox)
        Me.Controls.Add(Me.VoucherBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Voucher_Form"
        Me.Text = "Voucher_Form"
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VoucherBindingNavigator.ResumeLayout(False)
        Me.VoucherBindingNavigator.PerformLayout()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Voucher_DataSet As Voucher_DataSet
    Friend WithEvents VoucherBindingSource As BindingSource
    Friend WithEvents VoucherTableAdapter As Voucher_DataSetTableAdapters.VoucherTableAdapter
    Friend WithEvents TableAdapterManager As Voucher_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VoucherBindingNavigator As BindingNavigator
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
    Friend WithEvents VoucherBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VoucherdateDateTimePicker As DateTimePicker
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents TotalGranteesTextBox As TextBox
    Friend WithEvents Heis_DataSet As Heis_DataSet
    Friend WithEvents HeisBindingSource As BindingSource
    Friend WithEvents HeisTableAdapter As Heis_DataSetTableAdapters.heisTableAdapter
    Friend WithEvents VoucherDataGridView As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AcadyearComboBox As ComboBox
    Friend WithEvents SemesterComboBox As ComboBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
