<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentManagement
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
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDocumentName = New System.Windows.Forms.Label()
        Me.lblDocumentManagement = New System.Windows.Forms.Label()
        Me.lblDocumentID = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rdoActive = New System.Windows.Forms.RadioButton()
        Me.rdoInactive = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtDocumentID = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboDocumentName = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListViewDocument = New System.Windows.Forms.ListView()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanelMain.ColumnCount = 2
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.Controls.Add(Me.lblStatus, 0, 5)
        Me.TableLayoutPanelMain.Controls.Add(Me.lblFee, 0, 4)
        Me.TableLayoutPanelMain.Controls.Add(Me.lblDescription, 0, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.lblDocumentName, 0, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.lblDocumentManagement, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.lblDocumentID, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel1, 1, 5)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel4, 1, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel5, 1, 4)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanel6, 0, 6)
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(452, 14)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 7
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66548!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66548!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66548!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66756!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66933!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(810, 613)
        Me.TableLayoutPanelMain.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(3, 471)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(125, 37)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFee
        '
        Me.lblFee.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.Location = New System.Drawing.Point(3, 382)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(176, 37)
        Me.lblFee.TabIndex = 7
        Me.lblFee.Text = "Fee (PHP):"
        Me.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(3, 293)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(205, 37)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description:"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocumentName
        '
        Me.lblDocumentName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocumentName.AutoSize = True
        Me.lblDocumentName.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentName.Location = New System.Drawing.Point(3, 204)
        Me.lblDocumentName.Name = "lblDocumentName"
        Me.lblDocumentName.Size = New System.Drawing.Size(277, 37)
        Me.lblDocumentName.TabIndex = 3
        Me.lblDocumentName.Text = "Document Name:"
        Me.lblDocumentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocumentManagement
        '
        Me.lblDocumentManagement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDocumentManagement.AutoSize = True
        Me.TableLayoutPanelMain.SetColumnSpan(Me.lblDocumentManagement, 2)
        Me.lblDocumentManagement.Font = New System.Drawing.Font("Arial Black", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentManagement.Location = New System.Drawing.Point(112, 14)
        Me.lblDocumentManagement.Name = "lblDocumentManagement"
        Me.lblDocumentManagement.Size = New System.Drawing.Size(586, 60)
        Me.lblDocumentManagement.TabIndex = 0
        Me.lblDocumentManagement.Text = "Document Management"
        Me.lblDocumentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocumentID
        '
        Me.lblDocumentID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocumentID.AutoSize = True
        Me.lblDocumentID.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentID.Location = New System.Drawing.Point(3, 115)
        Me.lblDocumentID.Name = "lblDocumentID"
        Me.lblDocumentID.Size = New System.Drawing.Size(222, 37)
        Me.lblDocumentID.TabIndex = 1
        Me.lblDocumentID.Text = "Document ID:"
        Me.lblDocumentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rdoActive, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rdoInactive, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(290, 448)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(348, 67)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'rdoActive
        '
        Me.rdoActive.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rdoActive.AutoSize = True
        Me.rdoActive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdoActive.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoActive.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoActive.Location = New System.Drawing.Point(3, 15)
        Me.rdoActive.Name = "rdoActive"
        Me.rdoActive.Size = New System.Drawing.Size(112, 37)
        Me.rdoActive.TabIndex = 0
        Me.rdoActive.TabStop = True
        Me.rdoActive.Text = "Active"
        Me.rdoActive.UseVisualStyleBackColor = True
        '
        'rdoInactive
        '
        Me.rdoInactive.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rdoInactive.AutoSize = True
        Me.rdoInactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdoInactive.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoInactive.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInactive.Location = New System.Drawing.Point(177, 15)
        Me.rdoInactive.Name = "rdoInactive"
        Me.rdoInactive.Size = New System.Drawing.Size(132, 37)
        Me.rdoInactive.TabIndex = 1
        Me.rdoInactive.TabStop = True
        Me.rdoInactive.Text = "Inactive"
        Me.rdoInactive.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.txtDocumentID, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(290, 92)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(514, 67)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(3, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 40)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtDocumentID
        '
        Me.txtDocumentID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDocumentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocumentID.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentID.Location = New System.Drawing.Point(3, 14)
        Me.txtDocumentID.Name = "txtDocumentID"
        Me.txtDocumentID.Size = New System.Drawing.Size(275, 39)
        Me.txtDocumentID.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.cboDocumentName, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(290, 189)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(508, 67)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'cboDocumentName
        '
        Me.cboDocumentName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboDocumentName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDocumentName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumentName.FormattingEnabled = True
        Me.cboDocumentName.Location = New System.Drawing.Point(3, 13)
        Me.cboDocumentName.Name = "cboDocumentName"
        Me.cboDocumentName.Size = New System.Drawing.Size(486, 40)
        Me.cboDocumentName.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.txtDescription, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(290, 278)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(517, 67)
        Me.TableLayoutPanel4.TabIndex = 13
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(3, 7)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(508, 53)
        Me.txtDescription.TabIndex = 6
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtFee, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(290, 366)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(309, 68)
        Me.TableLayoutPanel5.TabIndex = 14
        '
        'txtFee
        '
        Me.txtFee.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFee.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.Location = New System.Drawing.Point(3, 14)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(297, 39)
        Me.txtFee.TabIndex = 8
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanelMain.SetColumnSpan(Me.TableLayoutPanel6, 2)
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnEdit, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Delete, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnStatus, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnClear, 4, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 537)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(804, 68)
        Me.TableLayoutPanel6.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(154, 62)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(163, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(154, 62)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(323, 3)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(154, 62)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatus.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.Location = New System.Drawing.Point(483, 3)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(154, 62)
        Me.btnStatus.TabIndex = 3
        Me.btnStatus.Text = "Activate / Deactivate"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(643, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 62)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListViewDocument)
        Me.Panel1.Controls.Add(Me.TableLayoutPanelMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1904, 1041)
        Me.Panel1.TabIndex = 2
        '
        'ListViewDocument
        '
        Me.ListViewDocument.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewDocument.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewDocument.HideSelection = False
        Me.ListViewDocument.Location = New System.Drawing.Point(191, 657)
        Me.ListViewDocument.Name = "ListViewDocument"
        Me.ListViewDocument.Size = New System.Drawing.Size(1311, 346)
        Me.ListViewDocument.TabIndex = 2
        Me.ListViewDocument.UseCompatibleStateImageBehavior = False
        Me.ListViewDocument.View = System.Windows.Forms.View.Details
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.btnSearch, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnClearSearch, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(284, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(224, 61)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'btnClearSearch
        '
        Me.btnClearSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClearSearch.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.Location = New System.Drawing.Point(126, 11)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(98, 39)
        Me.btnClearSearch.TabIndex = 4
        Me.btnClearSearch.Text = "Reset"
        Me.btnClearSearch.UseVisualStyleBackColor = True
        '
        'frmDocumentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDocumentManagement"
        Me.Text = "frmDocumentManagement"
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents lblDocumentManagement As Label
    Friend WithEvents lblDocumentID As Label
    Friend WithEvents txtDocumentID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDocumentName As Label
    Friend WithEvents cboDocumentName As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtFee As TextBox
    Friend WithEvents lblFee As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents rdoActive As RadioButton
    Friend WithEvents rdoInactive As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnSearch As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Delete As Button
    Friend WithEvents btnStatus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ListViewDocument As ListView
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnClearSearch As Button
End Class
