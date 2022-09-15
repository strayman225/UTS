<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AccesslevelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Form))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.AccesslevelLabel1 = New System.Windows.Forms.Label()
        AccesslevelLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtsusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtsusersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtsusersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccesslevelLabel
        '
        AccesslevelLabel.AutoSize = True
        AccesslevelLabel.Location = New System.Drawing.Point(123, 257)
        AccesslevelLabel.Name = "AccesslevelLabel"
        AccesslevelLabel.Size = New System.Drawing.Size(63, 15)
        AccesslevelLabel.TabIndex = 8
        AccesslevelLabel.Text = "Access by:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(86, 151)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 154)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 183)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(86, 180)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(255, 23)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tracking System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UniFAST_Tracking_System.My.Resources.Resources.unifast1
        Me.PictureBox1.Location = New System.Drawing.Point(163, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
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
        Me.UtsusersBindingNavigator.Size = New System.Drawing.Size(426, 25)
        Me.UtsusersBindingNavigator.TabIndex = 7
        Me.UtsusersBindingNavigator.Text = "BindingNavigator1"
        Me.UtsusersBindingNavigator.Visible = False
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
        'UtsusersBindingNavigatorSaveItem
        '
        Me.UtsusersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UtsusersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UtsusersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UtsusersBindingNavigatorSaveItem.Name = "UtsusersBindingNavigatorSaveItem"
        Me.UtsusersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UtsusersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccesslevelLabel1
        '
        Me.AccesslevelLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtsusersBindingSource, "accesslevel", True))
        Me.AccesslevelLabel1.Location = New System.Drawing.Point(192, 257)
        Me.AccesslevelLabel1.Name = "AccesslevelLabel1"
        Me.AccesslevelLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AccesslevelLabel1.TabIndex = 9
        Me.AccesslevelLabel1.Text = "School"
        '
        'User_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(426, 289)
        Me.Controls.Add(AccesslevelLabel)
        Me.Controls.Add(Me.AccesslevelLabel1)
        Me.Controls.Add(Me.UtsusersBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximumSize = New System.Drawing.Size(442, 328)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(442, 328)
        Me.Name = "User_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UniFAST Tracking System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtsusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtsusersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UtsusersBindingNavigator.ResumeLayout(False)
        Me.UtsusersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents AccesslevelLabel1 As Label
End Class
