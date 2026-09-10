<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestList
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnProcessPayment = New System.Windows.Forms.Button()
        Me.ListViewRequestList = New System.Windows.Forms.ListView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboStatusFilter = New System.Windows.Forms.ComboBox()
        Me.lblStatusFilter = New System.Windows.Forms.Label()
        Me.cboSearchRequest = New System.Windows.Forms.ComboBox()
        Me.lblSearchRequest = New System.Windows.Forms.Label()
        Me.lblDocumentRequestList = New System.Windows.Forms.Label()
        Me.lblSearchStudentID = New System.Windows.Forms.Label()
        Me.cboSearchStudentID = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.btnReset)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlMain.Controls.Add(Me.ListViewRequestList)
        Me.pnlMain.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1904, 1041)
        Me.pnlMain.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnProcessPayment, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(615, 815)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(542, 58)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnProcessPayment
        '
        Me.btnProcessPayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcessPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnProcessPayment.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessPayment.Location = New System.Drawing.Point(274, 3)
        Me.btnProcessPayment.Name = "btnProcessPayment"
        Me.btnProcessPayment.Size = New System.Drawing.Size(265, 52)
        Me.btnProcessPayment.TabIndex = 1
        Me.btnProcessPayment.Text = "Process Payment"
        Me.btnProcessPayment.UseVisualStyleBackColor = True
        '
        'ListViewRequestList
        '
        Me.ListViewRequestList.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewRequestList.HideSelection = False
        Me.ListViewRequestList.Location = New System.Drawing.Point(12, 368)
        Me.ListViewRequestList.Name = "ListViewRequestList"
        Me.ListViewRequestList.Size = New System.Drawing.Size(1145, 441)
        Me.ListViewRequestList.TabIndex = 1
        Me.ListViewRequestList.UseCompatibleStateImageBehavior = False
        Me.ListViewRequestList.View = System.Windows.Forms.View.Details
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cboStatusFilter, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatusFilter, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cboSearchRequest, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSearchRequest, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDocumentRequestList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSearchStudentID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboSearchStudentID, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 328)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cboStatusFilter
        '
        Me.cboStatusFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFilter.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatusFilter.FormattingEnabled = True
        Me.cboStatusFilter.Items.AddRange(New Object() {"Pending", "Paid", "Processing", "Ready for Release", "Released"})
        Me.cboStatusFilter.Location = New System.Drawing.Point(386, 285)
        Me.cboStatusFilter.Name = "cboStatusFilter"
        Me.cboStatusFilter.Size = New System.Drawing.Size(374, 40)
        Me.cboStatusFilter.TabIndex = 6
        '
        'lblStatusFilter
        '
        Me.lblStatusFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatusFilter.AutoSize = True
        Me.lblStatusFilter.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusFilter.Location = New System.Drawing.Point(3, 291)
        Me.lblStatusFilter.Name = "lblStatusFilter"
        Me.lblStatusFilter.Size = New System.Drawing.Size(216, 37)
        Me.lblStatusFilter.TabIndex = 5
        Me.lblStatusFilter.Text = "Status Filter:"
        Me.lblStatusFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSearchRequest
        '
        Me.cboSearchRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboSearchRequest.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchRequest.FormattingEnabled = True
        Me.cboSearchRequest.Location = New System.Drawing.Point(386, 193)
        Me.cboSearchRequest.Name = "cboSearchRequest"
        Me.cboSearchRequest.Size = New System.Drawing.Size(374, 40)
        Me.cboSearchRequest.TabIndex = 4
        '
        'lblSearchRequest
        '
        Me.lblSearchRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSearchRequest.AutoSize = True
        Me.lblSearchRequest.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchRequest.Location = New System.Drawing.Point(3, 199)
        Me.lblSearchRequest.Name = "lblSearchRequest"
        Me.lblSearchRequest.Size = New System.Drawing.Size(268, 37)
        Me.lblSearchRequest.TabIndex = 3
        Me.lblSearchRequest.Text = "Search Request:"
        Me.lblSearchRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocumentRequestList
        '
        Me.lblDocumentRequestList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocumentRequestList.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblDocumentRequestList, 2)
        Me.lblDocumentRequestList.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentRequestList.Location = New System.Drawing.Point(3, 0)
        Me.lblDocumentRequestList.Name = "lblDocumentRequestList"
        Me.lblDocumentRequestList.Size = New System.Drawing.Size(760, 56)
        Me.lblDocumentRequestList.TabIndex = 0
        Me.lblDocumentRequestList.Text = "Document Request List"
        Me.lblDocumentRequestList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchStudentID
        '
        Me.lblSearchStudentID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSearchStudentID.AutoSize = True
        Me.lblSearchStudentID.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchStudentID.Location = New System.Drawing.Point(3, 109)
        Me.lblSearchStudentID.Name = "lblSearchStudentID"
        Me.lblSearchStudentID.Size = New System.Drawing.Size(301, 37)
        Me.lblSearchStudentID.TabIndex = 1
        Me.lblSearchStudentID.Text = "Search Student ID:"
        Me.lblSearchStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSearchStudentID
        '
        Me.cboSearchStudentID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboSearchStudentID.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchStudentID.FormattingEnabled = True
        Me.cboSearchStudentID.Location = New System.Drawing.Point(386, 103)
        Me.cboSearchStudentID.Name = "cboSearchStudentID"
        Me.cboSearchStudentID.Size = New System.Drawing.Size(377, 40)
        Me.cboSearchStudentID.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(781, 115)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(101, 33)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmRequestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmRequestList"
        Me.Text = "frmRequestList"
        Me.pnlMain.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDocumentRequestList As Label
    Friend WithEvents lblSearchStudentID As Label
    Friend WithEvents cboSearchStudentID As ComboBox
    Friend WithEvents cboSearchRequest As ComboBox
    Friend WithEvents lblSearchRequest As Label
    Friend WithEvents ListViewRequestList As ListView
    Friend WithEvents cboStatusFilter As ComboBox
    Friend WithEvents lblStatusFilter As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnProcessPayment As Button
    Friend WithEvents btnReset As Button
End Class
