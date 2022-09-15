<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Grantee_Form
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
        Dim VoucherIDLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.AcadyearComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HeisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Heis_DataSet = New UniFAST_Tracking_System.Heis_DataSet()
        Me.HeisTableAdapter = New UniFAST_Tracking_System.Heis_DataSetTableAdapters.heisTableAdapter()
        Me.Voucher_DataSet = New UniFAST_Tracking_System.Voucher_DataSet()
        Me.VoucherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VoucherTableAdapter = New UniFAST_Tracking_System.Voucher_DataSetTableAdapters.VoucherTableAdapter()
        Me.TableAdapterManager = New UniFAST_Tracking_System.Voucher_DataSetTableAdapters.TableAdapterManager()
        Me.VoucherDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Students_DataSet = New UniFAST_Tracking_System.Students_DataSet()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New UniFAST_Tracking_System.Students_DataSetTableAdapters.studentsTableAdapter()
        Me.TableAdapterManager1 = New UniFAST_Tracking_System.Students_DataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.VoucherIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.StudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        SemesterLabel1 = New System.Windows.Forms.Label()
        Hei_UiiLabel = New System.Windows.Forms.Label()
        AcadyearLabel = New System.Windows.Forms.Label()
        VoucherIDLabel = New System.Windows.Forms.Label()
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoucherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Students_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SemesterLabel1
        '
        SemesterLabel1.AutoSize = True
        SemesterLabel1.Location = New System.Drawing.Point(306, 85)
        SemesterLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SemesterLabel1.Name = "SemesterLabel1"
        SemesterLabel1.Size = New System.Drawing.Size(59, 15)
        SemesterLabel1.TabIndex = 38
        SemesterLabel1.Text = "semester:"
        '
        'Hei_UiiLabel
        '
        Hei_UiiLabel.AutoSize = True
        Hei_UiiLabel.Location = New System.Drawing.Point(31, 50)
        Hei_UiiLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Hei_UiiLabel.Name = "Hei_UiiLabel"
        Hei_UiiLabel.Size = New System.Drawing.Size(47, 15)
        Hei_UiiLabel.TabIndex = 36
        Hei_UiiLabel.Text = "Hei Uii:"
        '
        'AcadyearLabel
        '
        AcadyearLabel.AutoSize = True
        AcadyearLabel.Location = New System.Drawing.Point(31, 89)
        AcadyearLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AcadyearLabel.Name = "AcadyearLabel"
        AcadyearLabel.Size = New System.Drawing.Size(61, 15)
        AcadyearLabel.TabIndex = 35
        AcadyearLabel.Text = "acadyear:"
        '
        'VoucherIDLabel
        '
        VoucherIDLabel.AutoSize = True
        VoucherIDLabel.Location = New System.Drawing.Point(343, 297)
        VoucherIDLabel.Name = "VoucherIDLabel"
        VoucherIDLabel.Size = New System.Drawing.Size(69, 15)
        VoucherIDLabel.TabIndex = 48
        VoucherIDLabel.Text = "Voucher ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 82)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 27)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"First Semester", "Second Semester"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(380, 82)
        Me.SemesterComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(140, 23)
        Me.SemesterComboBox.TabIndex = 40
        '
        'AcadyearComboBox
        '
        Me.AcadyearComboBox.FormattingEnabled = True
        Me.AcadyearComboBox.Items.AddRange(New Object() {"2020 - 2021", "2021 - 2022", "2022 - 2023", "2023 - 2024", "2024 - 2025"})
        Me.AcadyearComboBox.Location = New System.Drawing.Point(96, 82)
        Me.AcadyearComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AcadyearComboBox.Name = "AcadyearComboBox"
        Me.AcadyearComboBox.Size = New System.Drawing.Size(193, 23)
        Me.AcadyearComboBox.TabIndex = 39
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.HeisBindingSource
        Me.ComboBox1.DisplayMember = "HEI_Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 42)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(520, 23)
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
        'HeisTableAdapter
        '
        Me.HeisTableAdapter.ClearBeforeFill = True
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
        'VoucherDataGridView
        '
        Me.VoucherDataGridView.AllowUserToAddRows = False
        Me.VoucherDataGridView.AllowUserToDeleteRows = False
        Me.VoucherDataGridView.AutoGenerateColumns = False
        Me.VoucherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VoucherDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.VoucherDataGridView.DataSource = Me.VoucherBindingSource
        Me.VoucherDataGridView.Location = New System.Drawing.Point(43, 136)
        Me.VoucherDataGridView.Name = "VoucherDataGridView"
        Me.VoucherDataGridView.ReadOnly = True
        Me.VoucherDataGridView.Size = New System.Drawing.Size(591, 143)
        Me.VoucherDataGridView.TabIndex = 41
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
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hei_Uii"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Hei_Uii"
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
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Amount_Liquidated"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Amount_Liquidated"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Students_DataSet
        '
        Me.Students_DataSet.DataSetName = "Students_DataSet"
        Me.Students_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "students"
        Me.StudentsBindingSource.DataSource = Me.Students_DataSet
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.studentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = UniFAST_Tracking_System.Students_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 405)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(591, 193)
        Me.DataGridView1.TabIndex = 42
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(561, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 27)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Import"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(442, 375)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(113, 23)
        Me.ComboBox2.TabIndex = 46
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(335, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 26)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "File"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 375)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 23)
        Me.TextBox1.TabIndex = 43
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(495, 615)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 46)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'VoucherIDTextBox
        '
        Me.VoucherIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VoucherBindingSource, "VoucherID", True))
        Me.VoucherIDTextBox.Location = New System.Drawing.Point(418, 294)
        Me.VoucherIDTextBox.Name = "VoucherIDTextBox"
        Me.VoucherIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.VoucherIDTextBox.TabIndex = 49
        Me.VoucherIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(537, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 23)
        Me.Button5.TabIndex = 50
        Me.Button5.Text = "Master List"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'StudentsDataGridView
        '
        Me.StudentsDataGridView.AllowUserToAddRows = False
        Me.StudentsDataGridView.AllowUserToDeleteRows = False
        Me.StudentsDataGridView.AutoGenerateColumns = False
        Me.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.StudentsDataGridView.DataSource = Me.StudentsBindingSource
        Me.StudentsDataGridView.Location = New System.Drawing.Point(661, 136)
        Me.StudentsDataGridView.Name = "StudentsDataGridView"
        Me.StudentsDataGridView.ReadOnly = True
        Me.StudentsDataGridView.Size = New System.Drawing.Size(435, 462)
        Me.StudentsDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "studentid"
        Me.DataGridViewTextBoxColumn15.HeaderText = "studentid"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "awardnumber"
        Me.DataGridViewTextBoxColumn16.HeaderText = "awardnumber"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "lastname"
        Me.DataGridViewTextBoxColumn17.HeaderText = "lastname"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "firstname"
        Me.DataGridViewTextBoxColumn18.HeaderText = "firstname"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "midname"
        Me.DataGridViewTextBoxColumn19.HeaderText = "midname"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "program"
        Me.DataGridViewTextBoxColumn20.HeaderText = "program"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TES1"
        Me.DataGridViewTextBoxColumn21.HeaderText = "TES1"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TES2"
        Me.DataGridViewTextBoxColumn22.HeaderText = "TES2"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "voucherid"
        Me.DataGridViewTextBoxColumn25.HeaderText = "voucherid"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(962, 631)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Masterlist:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1035, 625)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 23)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 609)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 23)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 615)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Total:"
        '
        'Add_Grantee_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 715)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StudentsDataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(VoucherIDLabel)
        Me.Controls.Add(Me.VoucherIDTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VoucherDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(SemesterLabel1)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.AcadyearComboBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Hei_UiiLabel)
        Me.Controls.Add(AcadyearLabel)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Add_Grantee_Form"
        Me.Text = "Add_Grantee_Form"
        CType(Me.HeisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heis_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voucher_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoucherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Students_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SemesterComboBox As ComboBox
    Friend WithEvents AcadyearComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Heis_DataSet As Heis_DataSet
    Friend WithEvents HeisBindingSource As BindingSource
    Friend WithEvents HeisTableAdapter As Heis_DataSetTableAdapters.heisTableAdapter
    Friend WithEvents Voucher_DataSet As Voucher_DataSet
    Friend WithEvents VoucherBindingSource As BindingSource
    Friend WithEvents VoucherTableAdapter As Voucher_DataSetTableAdapters.VoucherTableAdapter
    Friend WithEvents TableAdapterManager As Voucher_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VoucherDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Students_DataSet As Students_DataSet
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As Students_DataSetTableAdapters.studentsTableAdapter
    Friend WithEvents TableAdapterManager1 As Students_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents VoucherIDTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents StudentsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
