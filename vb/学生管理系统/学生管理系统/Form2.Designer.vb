﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim 学号Label As System.Windows.Forms.Label
        Dim 姓名Label As System.Windows.Forms.Label
        Dim 性别Label As System.Windows.Forms.Label
        Dim 党员Label As System.Windows.Forms.Label
        Dim 出生年月Label As System.Windows.Forms.Label
        Dim 专业Label As System.Windows.Forms.Label
        Dim 助学金Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassesDataSet = New 学生管理系统.ClassesDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.选课表TableAdapter = New 学生管理系统.ClassesDataSetTableAdapters.选课表TableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New 学生管理系统.ClassesDataSetTableAdapters.StudentsTableAdapter()
        Me.TableAdapterManager = New 学生管理系统.ClassesDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.学号TextBox = New System.Windows.Forms.TextBox()
        Me.姓名TextBox = New System.Windows.Forms.TextBox()
        Me.性别TextBox = New System.Windows.Forms.TextBox()
        Me.党员CheckBox = New System.Windows.Forms.CheckBox()
        Me.出生年月DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.专业ComboBox = New System.Windows.Forms.ComboBox()
        Me.助学金TextBox = New System.Windows.Forms.TextBox()
        Me.照片PictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.StudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        学号Label = New System.Windows.Forms.Label()
        姓名Label = New System.Windows.Forms.Label()
        性别Label = New System.Windows.Forms.Label()
        党员Label = New System.Windows.Forms.Label()
        出生年月Label = New System.Windows.Forms.Label()
        专业Label = New System.Windows.Forms.Label()
        助学金Label = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.照片PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '学号Label
        '
        学号Label.AutoSize = True
        学号Label.Location = New System.Drawing.Point(39, 24)
        学号Label.Name = "学号Label"
        学号Label.Size = New System.Drawing.Size(35, 12)
        学号Label.TabIndex = 0
        学号Label.Text = "学号:"
        '
        '姓名Label
        '
        姓名Label.AutoSize = True
        姓名Label.Location = New System.Drawing.Point(39, 51)
        姓名Label.Name = "姓名Label"
        姓名Label.Size = New System.Drawing.Size(35, 12)
        姓名Label.TabIndex = 2
        姓名Label.Text = "姓名:"
        '
        '性别Label
        '
        性别Label.AutoSize = True
        性别Label.Location = New System.Drawing.Point(39, 78)
        性别Label.Name = "性别Label"
        性别Label.Size = New System.Drawing.Size(35, 12)
        性别Label.TabIndex = 4
        性别Label.Text = "性别:"
        '
        '党员Label
        '
        党员Label.AutoSize = True
        党员Label.Location = New System.Drawing.Point(39, 107)
        党员Label.Name = "党员Label"
        党员Label.Size = New System.Drawing.Size(35, 12)
        党员Label.TabIndex = 6
        党员Label.Text = "党员:"
        '
        '出生年月Label
        '
        出生年月Label.AutoSize = True
        出生年月Label.Location = New System.Drawing.Point(39, 136)
        出生年月Label.Name = "出生年月Label"
        出生年月Label.Size = New System.Drawing.Size(59, 12)
        出生年月Label.TabIndex = 8
        出生年月Label.Text = "出生年月:"
        '
        '专业Label
        '
        专业Label.AutoSize = True
        专业Label.Location = New System.Drawing.Point(39, 162)
        专业Label.Name = "专业Label"
        专业Label.Size = New System.Drawing.Size(35, 12)
        专业Label.TabIndex = 10
        专业Label.Text = "专业:"
        '
        '助学金Label
        '
        助学金Label.AutoSize = True
        助学金Label.Location = New System.Drawing.Point(39, 186)
        助学金Label.Name = "助学金Label"
        助学金Label.Size = New System.Drawing.Size(47, 12)
        助学金Label.TabIndex = 12
        助学金Label.Text = "助学金:"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "选课表"
        Me.BindingSource1.DataSource = Me.ClassesDataSet
        '
        'ClassesDataSet
        '
        Me.ClassesDataSet.DataSetName = "ClassesDataSet"
        Me.ClassesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "提交"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '选课表TableAdapter
        '
        Me.选课表TableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(467, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "删除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(386, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "添加"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.ClassesDataSet
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = 学生管理系统.ClassesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.选课表TableAdapter = Me.选课表TableAdapter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 256)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.RadioButton2)
        Me.TabPage1.Controls.Add(Me.RadioButton1)
        Me.TabPage1.Controls.Add(学号Label)
        Me.TabPage1.Controls.Add(Me.学号TextBox)
        Me.TabPage1.Controls.Add(姓名Label)
        Me.TabPage1.Controls.Add(Me.姓名TextBox)
        Me.TabPage1.Controls.Add(性别Label)
        Me.TabPage1.Controls.Add(Me.性别TextBox)
        Me.TabPage1.Controls.Add(党员Label)
        Me.TabPage1.Controls.Add(Me.党员CheckBox)
        Me.TabPage1.Controls.Add(出生年月Label)
        Me.TabPage1.Controls.Add(Me.出生年月DateTimePicker)
        Me.TabPage1.Controls.Add(专业Label)
        Me.TabPage1.Controls.Add(Me.专业ComboBox)
        Me.TabPage1.Controls.Add(助学金Label)
        Me.TabPage1.Controls.Add(Me.助学金TextBox)
        Me.TabPage1.Controls.Add(Me.照片PictureBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(544, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "个人"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(166, 73)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "女"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(104, 73)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "男"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        '学号TextBox
        '
        Me.学号TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "学号", True))
        Me.学号TextBox.Location = New System.Drawing.Point(104, 21)
        Me.学号TextBox.Name = "学号TextBox"
        Me.学号TextBox.Size = New System.Drawing.Size(200, 21)
        Me.学号TextBox.TabIndex = 1
        '
        '姓名TextBox
        '
        Me.姓名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "姓名", True))
        Me.姓名TextBox.Location = New System.Drawing.Point(104, 48)
        Me.姓名TextBox.Name = "姓名TextBox"
        Me.姓名TextBox.Size = New System.Drawing.Size(200, 21)
        Me.姓名TextBox.TabIndex = 3
        '
        '性别TextBox
        '
        Me.性别TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "性别", True))
        Me.性别TextBox.Location = New System.Drawing.Point(264, 75)
        Me.性别TextBox.Name = "性别TextBox"
        Me.性别TextBox.Size = New System.Drawing.Size(40, 21)
        Me.性别TextBox.TabIndex = 5
        Me.性别TextBox.Visible = False
        '
        '党员CheckBox
        '
        Me.党员CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.StudentsBindingSource, "党员", True))
        Me.党员CheckBox.Location = New System.Drawing.Point(104, 102)
        Me.党员CheckBox.Name = "党员CheckBox"
        Me.党员CheckBox.Size = New System.Drawing.Size(200, 24)
        Me.党员CheckBox.TabIndex = 7
        Me.党员CheckBox.UseVisualStyleBackColor = True
        '
        '出生年月DateTimePicker
        '
        Me.出生年月DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentsBindingSource, "出生年月", True))
        Me.出生年月DateTimePicker.Location = New System.Drawing.Point(104, 132)
        Me.出生年月DateTimePicker.Name = "出生年月DateTimePicker"
        Me.出生年月DateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.出生年月DateTimePicker.TabIndex = 9
        '
        '专业ComboBox
        '
        Me.专业ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "专业", True))
        Me.专业ComboBox.FormattingEnabled = True
        Me.专业ComboBox.Location = New System.Drawing.Point(104, 159)
        Me.专业ComboBox.Name = "专业ComboBox"
        Me.专业ComboBox.Size = New System.Drawing.Size(200, 20)
        Me.专业ComboBox.TabIndex = 11
        '
        '助学金TextBox
        '
        Me.助学金TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "助学金", True))
        Me.助学金TextBox.Location = New System.Drawing.Point(104, 183)
        Me.助学金TextBox.Name = "助学金TextBox"
        Me.助学金TextBox.Size = New System.Drawing.Size(200, 21)
        Me.助学金TextBox.TabIndex = 13
        '
        '照片PictureBox
        '
        Me.照片PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.照片PictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StudentsBindingSource, "照片", True))
        Me.照片PictureBox.Location = New System.Drawing.Point(366, 24)
        Me.照片PictureBox.Name = "照片PictureBox"
        Me.照片PictureBox.Size = New System.Drawing.Size(145, 180)
        Me.照片PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.照片PictureBox.TabIndex = 15
        Me.照片PictureBox.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.StudentsDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "列表"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StudentsDataGridView
        '
        Me.StudentsDataGridView.AutoGenerateColumns = False
        Me.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StudentsDataGridView.DataSource = Me.StudentsBindingSource
        Me.StudentsDataGridView.Location = New System.Drawing.Point(-4, 0)
        Me.StudentsDataGridView.Name = "StudentsDataGridView"
        Me.StudentsDataGridView.RowTemplate.Height = 23
        Me.StudentsDataGridView.Size = New System.Drawing.Size(545, 227)
        Me.StudentsDataGridView.TabIndex = 0
        '
        'StudentsBindingNavigator
        '
        Me.StudentsBindingNavigator.AddNewItem = Nothing
        Me.StudentsBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StudentsBindingNavigator.BindingSource = Me.StudentsBindingSource
        Me.StudentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentsBindingNavigator.DeleteItem = Nothing
        Me.StudentsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.StudentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.StudentsBindingNavigator.Location = New System.Drawing.Point(57, 9)
        Me.StudentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentsBindingNavigator.Name = "StudentsBindingNavigator"
        Me.StudentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentsBindingNavigator.Size = New System.Drawing.Size(206, 25)
        Me.StudentsBindingNavigator.TabIndex = 5
        Me.StudentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(32, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "总项数"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到第一条记录"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一条记录"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "当前位置"
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
        Me.BindingNavigatorMoveNextItem.Text = "移到下一条记录"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最后一条记录"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "选择图片"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "学号"
        Me.DataGridViewTextBoxColumn1.HeaderText = "学号"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "姓名"
        Me.DataGridViewTextBoxColumn2.HeaderText = "姓名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "性别"
        Me.DataGridViewTextBoxColumn3.HeaderText = "性别"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "党员"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "党员"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "出生年月"
        Me.DataGridViewTextBoxColumn4.HeaderText = "出生年月"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "专业"
        Me.DataGridViewTextBoxColumn5.HeaderText = "专业"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "助学金"
        Me.DataGridViewTextBoxColumn6.HeaderText = "助学金"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 300)
        Me.Controls.Add(Me.StudentsBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "学生基本信息修改"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.照片PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentsBindingNavigator.ResumeLayout(False)
        Me.StudentsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClassesDataSet As 学生管理系统.ClassesDataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents 选课表TableAdapter As 学生管理系统.ClassesDataSetTableAdapters.选课表TableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As 学生管理系统.ClassesDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As 学生管理系统.ClassesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents StudentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 学号TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 姓名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 性别TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 党员CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 出生年月DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents 专业ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 助学金TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 照片PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents StudentsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
