<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentRequest
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveRequest = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ListViewRequestList = New System.Windows.Forms.ListView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.cboDocumentName = New System.Windows.Forms.ComboBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblAddRequestItem = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblDocumentName = New System.Windows.Forms.Label()
        Me.NumericUpDownQuantity = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cboStudentID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStudentInformation = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.cboStudentName = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimePickerDate = New System.Windows.Forms.DateTimePicker()
        Me.lblProcessedBy = New System.Windows.Forms.Label()
        Me.lblCreateNewDocumentRequest = New System.Windows.Forms.Label()
        Me.lblRequestNo = New System.Windows.Forms.Label()
        Me.txtRequestNumber = New System.Windows.Forms.TextBox()
        Me.cboProcessedBy = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.pnlMain.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.NumericUpDownQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel4)
        Me.pnlMain.Controls.Add(Me.ListViewRequestList)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel3)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1904, 1041)
        Me.pnlMain.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.btnSaveRequest, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnCancel, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblTotalAmount, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTotalAmount, 1, 2)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(911, 774)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(479, 187)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'btnSaveRequest
        '
        Me.btnSaveRequest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSaveRequest.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRequest.Location = New System.Drawing.Point(3, 11)
        Me.btnSaveRequest.Name = "btnSaveRequest"
        Me.btnSaveRequest.Size = New System.Drawing.Size(212, 40)
        Me.btnSaveRequest.TabIndex = 9
        Me.btnSaveRequest.Text = "Save Request"
        Me.btnSaveRequest.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(3, 73)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(209, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ListViewRequestList
        '
        Me.ListViewRequestList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewRequestList.HideSelection = False
        Me.ListViewRequestList.Location = New System.Drawing.Point(12, 774)
        Me.ListViewRequestList.Name = "ListViewRequestList"
        Me.ListViewRequestList.Size = New System.Drawing.Size(893, 187)
        Me.ListViewRequestList.TabIndex = 3
        Me.ListViewRequestList.UseCompatibleStateImageBehavior = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.lblFee, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.cboDocumentName, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblQuantity, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblAddRequestItem, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAdd, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblDocumentName, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.NumericUpDownQuantity, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox1, 3, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 515)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1300, 233)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'lblFee
        '
        Me.lblFee.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.Location = New System.Drawing.Point(738, 97)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(83, 37)
        Me.lblFee.TabIndex = 2
        Me.lblFee.Text = "Fee:"
        '
        'cboDocumentName
        '
        Me.cboDocumentName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboDocumentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDocumentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDocumentName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumentName.FormattingEnabled = True
        Me.cboDocumentName.Location = New System.Drawing.Point(303, 95)
        Me.cboDocumentName.Name = "cboDocumentName"
        Me.cboDocumentName.Size = New System.Drawing.Size(429, 40)
        Me.cboDocumentName.TabIndex = 4
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(3, 175)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(156, 37)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblAddRequestItem
        '
        Me.lblAddRequestItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddRequestItem.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.lblAddRequestItem, 4)
        Me.lblAddRequestItem.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddRequestItem.Location = New System.Drawing.Point(3, 0)
        Me.lblAddRequestItem.Name = "lblAddRequestItem"
        Me.lblAddRequestItem.Size = New System.Drawing.Size(1294, 77)
        Me.lblAddRequestItem.TabIndex = 0
        Me.lblAddRequestItem.Text = "Add Request Item"
        Me.lblAddRequestItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(738, 173)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 40)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblDocumentName
        '
        Me.lblDocumentName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocumentName.AutoSize = True
        Me.lblDocumentName.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentName.Location = New System.Drawing.Point(3, 97)
        Me.lblDocumentName.Name = "lblDocumentName"
        Me.lblDocumentName.Size = New System.Drawing.Size(277, 37)
        Me.lblDocumentName.TabIndex = 1
        Me.lblDocumentName.Text = "Document Name:"
        '
        'NumericUpDownQuantity
        '
        Me.NumericUpDownQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDownQuantity.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownQuantity.Location = New System.Drawing.Point(303, 174)
        Me.NumericUpDownQuantity.Name = "NumericUpDownQuantity"
        Me.NumericUpDownQuantity.Size = New System.Drawing.Size(134, 39)
        Me.NumericUpDownQuantity.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(899, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(317, 39)
        Me.TextBox1.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.cboYear, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cboCourse, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblYear, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCourse, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cboStudentID, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblStudentInformation, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblStudentID, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cboStudentName, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 264)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1314, 233)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'cboYear
        '
        Me.cboYear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYear.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(881, 173)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(429, 40)
        Me.cboYear.TabIndex = 6
        '
        'cboCourse
        '
        Me.cboCourse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(881, 95)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(429, 40)
        Me.cboCourse.TabIndex = 5
        '
        'lblYear
        '
        Me.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(738, 175)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(94, 37)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'lblCourse
        '
        Me.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(738, 97)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(137, 37)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course:"
        '
        'cboStudentID
        '
        Me.cboStudentID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboStudentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboStudentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudentID.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentID.FormattingEnabled = True
        Me.cboStudentID.Location = New System.Drawing.Point(303, 95)
        Me.cboStudentID.Name = "cboStudentID"
        Me.cboStudentID.Size = New System.Drawing.Size(429, 40)
        Me.cboStudentID.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Name:"
        '
        'lblStudentInformation
        '
        Me.lblStudentInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentInformation.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lblStudentInformation, 4)
        Me.lblStudentInformation.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentInformation.Location = New System.Drawing.Point(3, 0)
        Me.lblStudentInformation.Name = "lblStudentInformation"
        Me.lblStudentInformation.Size = New System.Drawing.Size(1308, 77)
        Me.lblStudentInformation.TabIndex = 0
        Me.lblStudentInformation.Text = "Student Information"
        Me.lblStudentInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentID
        '
        Me.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(3, 97)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(185, 37)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "Student ID:"
        '
        'cboStudentName
        '
        Me.cboStudentName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudentName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentName.FormattingEnabled = True
        Me.cboStudentName.Location = New System.Drawing.Point(303, 173)
        Me.cboStudentName.Name = "cboStudentName"
        Me.cboStudentName.Size = New System.Drawing.Size(429, 40)
        Me.cboStudentName.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerDate, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProcessedBy, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCreateNewDocumentRequest, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRequestNo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRequestNumber, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboProcessedBy, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDate, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1314, 233)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DateTimePickerDate
        '
        Me.DateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerDate.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDate.Location = New System.Drawing.Point(841, 96)
        Me.DateTimePickerDate.Name = "DateTimePickerDate"
        Me.DateTimePickerDate.Size = New System.Drawing.Size(450, 39)
        Me.DateTimePickerDate.TabIndex = 2
        Me.DateTimePickerDate.Value = New Date(2026, 8, 18, 0, 0, 0, 0)
        '
        'lblProcessedBy
        '
        Me.lblProcessedBy.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProcessedBy.AutoSize = True
        Me.lblProcessedBy.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessedBy.Location = New System.Drawing.Point(3, 175)
        Me.lblProcessedBy.Name = "lblProcessedBy"
        Me.lblProcessedBy.Size = New System.Drawing.Size(236, 37)
        Me.lblProcessedBy.TabIndex = 2
        Me.lblProcessedBy.Text = "Processed By:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblCreateNewDocumentRequest
        '
        Me.lblCreateNewDocumentRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreateNewDocumentRequest.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblCreateNewDocumentRequest, 4)
        Me.lblCreateNewDocumentRequest.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateNewDocumentRequest.Location = New System.Drawing.Point(3, 0)
        Me.lblCreateNewDocumentRequest.Name = "lblCreateNewDocumentRequest"
        Me.lblCreateNewDocumentRequest.Size = New System.Drawing.Size(1308, 77)
        Me.lblCreateNewDocumentRequest.TabIndex = 0
        Me.lblCreateNewDocumentRequest.Text = "Create New Document Request"
        Me.lblCreateNewDocumentRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRequestNo
        '
        Me.lblRequestNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRequestNo.AutoSize = True
        Me.lblRequestNo.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequestNo.Location = New System.Drawing.Point(3, 97)
        Me.lblRequestNo.Name = "lblRequestNo"
        Me.lblRequestNo.Size = New System.Drawing.Size(280, 37)
        Me.lblRequestNo.TabIndex = 1
        Me.lblRequestNo.Text = "Request Number:"
        '
        'txtRequestNumber
        '
        Me.txtRequestNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRequestNumber.BackColor = System.Drawing.Color.White
        Me.txtRequestNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRequestNumber.Enabled = False
        Me.txtRequestNumber.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestNumber.ForeColor = System.Drawing.Color.Black
        Me.txtRequestNumber.Location = New System.Drawing.Point(303, 96)
        Me.txtRequestNumber.Name = "txtRequestNumber"
        Me.txtRequestNumber.ReadOnly = True
        Me.txtRequestNumber.Size = New System.Drawing.Size(429, 39)
        Me.txtRequestNumber.TabIndex = 2
        '
        'cboProcessedBy
        '
        Me.cboProcessedBy.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboProcessedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProcessedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProcessedBy.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcessedBy.FormattingEnabled = True
        Me.cboProcessedBy.Location = New System.Drawing.Point(303, 173)
        Me.cboProcessedBy.Name = "cboProcessedBy"
        Me.cboProcessedBy.Size = New System.Drawing.Size(429, 40)
        Me.cboProcessedBy.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(738, 97)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(97, 37)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(3, 137)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(230, 37)
        Me.lblTotalAmount.TabIndex = 11
        Me.lblTotalAmount.Text = "Total Amount:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(239, 136)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(240, 39)
        Me.txtTotalAmount.TabIndex = 12
        '
        'frmDocumentRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmDocumentRequest"
        Me.Text = "frmDocumentRequest"
        Me.pnlMain.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.NumericUpDownQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCreateNewDocumentRequest As Label
    Friend WithEvents lblRequestNo As Label
    Friend WithEvents lblProcessedBy As Label
    Friend WithEvents txtRequestNumber As TextBox
    Friend WithEvents cboProcessedBy As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentInformation As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents cboStudentID As ComboBox
    Friend WithEvents cboStudentName As ComboBox
    Friend WithEvents DateTimePickerDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblFee As Label
    Friend WithEvents cboDocumentName As ComboBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAddRequestItem As Label
    Friend WithEvents lblDocumentName As Label
    Friend WithEvents NumericUpDownQuantity As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents ListViewRequestList As ListView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveRequest As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtTotalAmount As TextBox
End Class
