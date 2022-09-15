<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADA_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADA_Form))
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
        Me.HeisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Heis_DataSet = New UniFAST_Tracking_System.Heis_DataSet()
        Me.HeisTableAdapter = New UniFAST_Tracking_System.Heis_DataSetTableAdapters.heisTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.VoucherDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DV_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADA_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VoucherBindingNavigator.SuspendLayout()
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.VoucherBindingNavigator.Size = New System.Drawing.Size(837, 25)
        Me.VoucherBindingNavigator.TabIndex = 49
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
        'HeisTableAdapter
        '
        Me.HeisTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(593, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 45)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(711, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 45)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 162)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 19)
        Me.CheckBox1.TabIndex = 51
        Me.CheckBox1.Text = "New for ADA"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'VoucherDataGridView
        '
        Me.VoucherDataGridView.AllowUserToAddRows = False
        Me.VoucherDataGridView.AllowUserToDeleteRows = False
        Me.VoucherDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VoucherDataGridView.AutoGenerateColumns = False
        Me.VoucherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VoucherDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DV, Me.DV_date, Me.ADA, Me.ADA_date})
        Me.VoucherDataGridView.DataSource = Me.VoucherBindingSource
        Me.VoucherDataGridView.Location = New System.Drawing.Point(12, 184)
        Me.VoucherDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.VoucherDataGridView.Name = "VoucherDataGridView"
        Me.VoucherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VoucherDataGridView.Size = New System.Drawing.Size(811, 205)
        Me.VoucherDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VoucherID"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "VoucherID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Hei_Uii"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.HeisBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "HEI_Name"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hei_Uii"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Hei_Uii"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "category"
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "category"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn7.Frozen = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DV
        '
        Me.DV.DataPropertyName = "DV"
        Me.DV.HeaderText = "DV"
        Me.DV.Name = "DV"
        Me.DV.ReadOnly = True
        '
        'DV_date
        '
        Me.DV_date.DataPropertyName = "DV_date"
        Me.DV_date.HeaderText = "DV_date"
        Me.DV_date.Name = "DV_date"
        Me.DV_date.ReadOnly = True
        '
        'ADA
        '
        Me.ADA.DataPropertyName = "ADA"
        Me.ADA.HeaderText = "ADA"
        Me.ADA.Name = "ADA"
        '
        'ADA_date
        '
        Me.ADA_date.DataPropertyName = "ADA_date"
        Me.ADA_date.HeaderText = "ADA_date"
        Me.ADA_date.Name = "ADA_date"
        '
        'ADA_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 464)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.VoucherDataGridView)
        Me.Controls.Add(Me.VoucherBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ADA_Form"
        Me.Text = "ADA_Form"
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VoucherBindingNavigator.ResumeLayout(False)
        Me.VoucherBindingNavigator.PerformLayout()
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Heis_DataSet As Heis_DataSet
    Friend WithEvents HeisBindingSource As BindingSource
    Friend WithEvents HeisTableAdapter As Heis_DataSetTableAdapters.heisTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents VoucherDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DV As DataGridViewTextBoxColumn
    Friend WithEvents DV_date As DataGridViewTextBoxColumn
    Friend WithEvents ADA As DataGridViewTextBoxColumn
    Friend WithEvents ADA_date As DataGridViewTextBoxColumn
End Class
