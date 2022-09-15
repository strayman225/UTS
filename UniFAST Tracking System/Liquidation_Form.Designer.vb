<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liquidation_Form
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
        Dim SemesterLabel1 As System.Windows.Forms.Label
        Dim Hei_UiiLabel As System.Windows.Forms.Label
        Dim AcadyearLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liquidation_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.AcadyearComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HeisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Heis_DataSet = New UniFAST_Tracking_System.Heis_DataSet()
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
        Me.VoucherDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount_Liquidated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeisTableAdapter = New UniFAST_Tracking_System.Heis_DataSetTableAdapters.heisTableAdapter()
        Me.Liquidation_DataSet = New UniFAST_Tracking_System.Liquidation_DataSet()
        Me.LiquidationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LiquidationTableAdapter = New UniFAST_Tracking_System.Liquidation_DataSetTableAdapters.LiquidationTableAdapter()
        Me.TableAdapterManager1 = New UniFAST_Tracking_System.Liquidation_DataSetTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangePassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        SemesterLabel1 = New System.Windows.Forms.Label()
        Hei_UiiLabel = New System.Windows.Forms.Label()
        AcadyearLabel = New System.Windows.Forms.Label()
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VoucherBindingNavigator.SuspendLayout()
        CType(Me.VoucherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Liquidation_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SemesterLabel1
        '
        SemesterLabel1.AutoSize = True
        SemesterLabel1.Location = New System.Drawing.Point(28, 257)
        SemesterLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SemesterLabel1.Name = "SemesterLabel1"
        SemesterLabel1.Size = New System.Drawing.Size(59, 15)
        SemesterLabel1.TabIndex = 38
        SemesterLabel1.Text = "semester:"
        '
        'Hei_UiiLabel
        '
        Hei_UiiLabel.AutoSize = True
        Hei_UiiLabel.Location = New System.Drawing.Point(40, 193)
        Hei_UiiLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Hei_UiiLabel.Name = "Hei_UiiLabel"
        Hei_UiiLabel.Size = New System.Drawing.Size(47, 15)
        Hei_UiiLabel.TabIndex = 36
        Hei_UiiLabel.Text = "Hei Uii:"
        '
        'AcadyearLabel
        '
        AcadyearLabel.AutoSize = True
        AcadyearLabel.Location = New System.Drawing.Point(26, 231)
        AcadyearLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AcadyearLabel.Name = "AcadyearLabel"
        AcadyearLabel.Size = New System.Drawing.Size(61, 15)
        AcadyearLabel.TabIndex = 35
        AcadyearLabel.Text = "acadyear:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(266, 225)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 53)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"First Semester", "Second Semester"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(102, 254)
        Me.SemesterComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SemesterComboBox.TabIndex = 40
        '
        'AcadyearComboBox
        '
        Me.AcadyearComboBox.FormattingEnabled = True
        Me.AcadyearComboBox.Items.AddRange(New Object() {"2020 - 2021", "2021 - 2022", "2022 - 2023", "2023 - 2024", "2024 - 2025"})
        Me.AcadyearComboBox.Location = New System.Drawing.Point(102, 225)
        Me.AcadyearComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AcadyearComboBox.Name = "AcadyearComboBox"
        Me.AcadyearComboBox.Size = New System.Drawing.Size(140, 23)
        Me.AcadyearComboBox.TabIndex = 39
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.HeisBindingSource
        Me.ComboBox1.DisplayMember = "HEI_Name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(102, 190)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(269, 23)
        Me.ComboBox1.TabIndex = 37
        Me.ComboBox1.ValueMember = "Hei_Uii"
        '
        'HeisBindingSource
        '
        Me.HeisBindingSource.DataMember = "heis"
        Me.HeisBindingSource.DataSource = Me.Heis_DataSet
        '
        'Heis_DataSet
        '
        Me.Heis_DataSet.DataSetName = "Heis_DataSet"
        Me.Heis_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.VoucherBindingNavigator.Size = New System.Drawing.Size(483, 25)
        Me.VoucherBindingNavigator.TabIndex = 42
        Me.VoucherBindingNavigator.Text = "BindingNavigator1"
        Me.VoucherBindingNavigator.Visible = False
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
        'VoucherDataGridView
        '
        Me.VoucherDataGridView.AllowUserToAddRows = False
        Me.VoucherDataGridView.AllowUserToDeleteRows = False
        Me.VoucherDataGridView.AutoGenerateColumns = False
        Me.VoucherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VoucherDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.Amount_Liquidated})
        Me.VoucherDataGridView.DataSource = Me.VoucherBindingSource
        Me.VoucherDataGridView.Location = New System.Drawing.Point(27, 290)
        Me.VoucherDataGridView.Name = "VoucherDataGridView"
        Me.VoucherDataGridView.ReadOnly = True
        Me.VoucherDataGridView.Size = New System.Drawing.Size(687, 162)
        Me.VoucherDataGridView.TabIndex = 42
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VoucherID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "VoucherID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "category"
        Me.DataGridViewTextBoxColumn6.HeaderText = "category"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ADA_date"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ADA_date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ADA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ADA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amount"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Amount_Liquidated
        '
        Me.Amount_Liquidated.DataPropertyName = "Amount_Liquidated"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Amount_Liquidated.DefaultCellStyle = DataGridViewCellStyle2
        Me.Amount_Liquidated.HeaderText = "Amount_Liquidated"
        Me.Amount_Liquidated.Name = "Amount_Liquidated"
        Me.Amount_Liquidated.ReadOnly = True
        Me.Amount_Liquidated.Width = 150
        '
        'HeisTableAdapter
        '
        Me.HeisTableAdapter.ClearBeforeFill = True
        '
        'Liquidation_DataSet
        '
        Me.Liquidation_DataSet.DataSetName = "Liquidation_DataSet"
        Me.Liquidation_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LiquidationBindingSource
        '
        Me.LiquidationBindingSource.DataMember = "Liquidation"
        Me.LiquidationBindingSource.DataSource = Me.Liquidation_DataSet
        '
        'LiquidationTableAdapter
        '
        Me.LiquidationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.LiquidationTableAdapter = Me.LiquidationTableAdapter
        Me.TableAdapterManager1.UpdateOrder = UniFAST_Tracking_System.Liquidation_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(594, 458)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 30)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Liquidate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 474)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Total Liquidated:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 472)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Total ADA Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(148, 499)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 26)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 507)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 15)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Total UnLiquidated:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 556)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(742, 25)
        Me.ToolStrip1.TabIndex = 78
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel1.Text = "Access by:"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel2.Text = "ToolStripLabel2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(32, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 110)
        Me.Panel2.TabIndex = 111
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(219, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(244, 45)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ADA WINDOW"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePassToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip1.TabIndex = 112
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChangePassToolStripMenuItem
        '
        Me.ChangePassToolStripMenuItem.Name = "ChangePassToolStripMenuItem"
        Me.ChangePassToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ChangePassToolStripMenuItem.Text = "Change Pass"
        '
        'Liquidation_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(742, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.VoucherDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.VoucherBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(SemesterLabel1)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.AcadyearComboBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Hei_UiiLabel)
        Me.Controls.Add(AcadyearLabel)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Liquidation_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidation_Form"
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VoucherBindingNavigator.ResumeLayout(False)
        Me.VoucherBindingNavigator.PerformLayout()
        CType(Me.VoucherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Liquidation_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SemesterComboBox As ComboBox
    Friend WithEvents AcadyearComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
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
    Friend WithEvents VoucherDataGridView As DataGridView
    Friend WithEvents Heis_DataSet As Heis_DataSet
    Friend WithEvents HeisBindingSource As BindingSource
    Friend WithEvents HeisTableAdapter As Heis_DataSetTableAdapters.heisTableAdapter
    Friend WithEvents Liquidation_DataSet As Liquidation_DataSet
    Friend WithEvents LiquidationBindingSource As BindingSource
    Friend WithEvents LiquidationTableAdapter As Liquidation_DataSetTableAdapters.LiquidationTableAdapter
    Friend WithEvents TableAdapterManager1 As Liquidation_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Amount_Liquidated As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChangePassToolStripMenuItem As ToolStripMenuItem
End Class
