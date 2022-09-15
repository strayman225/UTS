<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRegistration_Form
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
        Dim PasswLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRegistration_Form))
        Me.User_DataSet = New UniFAST_Tracking_System.User_DataSet()
        Me.UtsusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtsusersTableAdapter = New UniFAST_Tracking_System.User_DataSetTableAdapters.utsusersTableAdapter()
        Me.TableAdapterManager = New UniFAST_Tracking_System.User_DataSetTableAdapters.TableAdapterManager()
        Me.UtsusersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UtsusersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UtsusersDataGridView = New System.Windows.Forms.DataGridView()
        Me.PasswTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        PasswLabel = New System.Windows.Forms.Label()
        CType(Me.User_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtsusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtsusersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtsusersBindingNavigator.SuspendLayout()
        CType(Me.UtsusersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswLabel
        '
        PasswLabel.AutoSize = True
        PasswLabel.Location = New System.Drawing.Point(650, 450)
        PasswLabel.Name = "PasswLabel"
        PasswLabel.Size = New System.Drawing.Size(45, 15)
        PasswLabel.TabIndex = 2
        PasswLabel.Text = "passw:"
        '
        'User_DataSet
        '
        Me.User_DataSet.DataSetName = "User_DataSet"
        Me.User_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtsusersBindingSource
        '
        Me.UtsusersBindingSource.DataMember = "utsusers"
        Me.UtsusersBindingSource.DataSource = Me.User_DataSet
        '
        'UtsusersTableAdapter
        '
        Me.UtsusersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = UniFAST_Tracking_System.User_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.utsusersTableAdapter = Me.UtsusersTableAdapter
        '
        'UtsusersBindingNavigator
        '
        Me.UtsusersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UtsusersBindingNavigator.BindingSource = Me.UtsusersBindingSource
        Me.UtsusersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UtsusersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UtsusersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UtsusersBindingNavigatorSaveItem})
        Me.UtsusersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UtsusersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UtsusersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UtsusersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UtsusersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UtsusersBindingNavigator.Name = "UtsusersBindingNavigator"
        Me.UtsusersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UtsusersBindingNavigator.Size = New System.Drawing.Size(940, 25)
        Me.UtsusersBindingNavigator.TabIndex = 0
        Me.UtsusersBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'UtsusersBindingNavigatorSaveItem
        '
        Me.UtsusersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UtsusersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UtsusersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UtsusersBindingNavigatorSaveItem.Name = "UtsusersBindingNavigatorSaveItem"
        Me.UtsusersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UtsusersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UtsusersDataGridView
        '
        Me.UtsusersDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UtsusersDataGridView.AutoGenerateColumns = False
        Me.UtsusersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UtsusersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.UtsusersDataGridView.DataSource = Me.UtsusersBindingSource
        Me.UtsusersDataGridView.Location = New System.Drawing.Point(13, 181)
        Me.UtsusersDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UtsusersDataGridView.Name = "UtsusersDataGridView"
        Me.UtsusersDataGridView.Size = New System.Drawing.Size(914, 240)
        Me.UtsusersDataGridView.TabIndex = 1
        '
        'PasswTextBox
        '
        Me.PasswTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtsusersBindingSource, "passw", True))
        Me.PasswTextBox.Location = New System.Drawing.Point(701, 447)
        Me.PasswTextBox.Name = "PasswTextBox"
        Me.PasswTextBox.Size = New System.Drawing.Size(221, 23)
        Me.PasswTextBox.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Userid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Userid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "hei_uii"
        Me.DataGridViewTextBoxColumn2.HeaderText = "hei_uii"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "passw"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "accesslevel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Access Level"
        Me.DataGridViewTextBoxColumn4.Items.AddRange(New Object() {"School", "UniFAST"})
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'UserRegistration_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 548)
        Me.Controls.Add(PasswLabel)
        Me.Controls.Add(Me.PasswTextBox)
        Me.Controls.Add(Me.UtsusersDataGridView)
        Me.Controls.Add(Me.UtsusersBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UserRegistration_Form"
        Me.Text = "UserRegistration_Form"
        CType(Me.User_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtsusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtsusersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UtsusersBindingNavigator.ResumeLayout(False)
        Me.UtsusersBindingNavigator.PerformLayout()
        CType(Me.UtsusersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents User_DataSet As User_DataSet
    Friend WithEvents UtsusersBindingSource As BindingSource
    Friend WithEvents UtsusersTableAdapter As User_DataSetTableAdapters.utsusersTableAdapter
    Friend WithEvents TableAdapterManager As User_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UtsusersBindingNavigator As BindingNavigator
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
    Friend WithEvents UtsusersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UtsusersDataGridView As DataGridView
    Friend WithEvents PasswTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
End Class
