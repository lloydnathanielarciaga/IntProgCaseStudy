<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentInformation
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOrDate = New System.Windows.Forms.Label()
        Me.DateTimePickerOrDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblRecordPaymentInformation = New System.Windows.Forms.Label()
        Me.btnSavePayment = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRequestNo = New System.Windows.Forms.Label()
        Me.cboRequestNo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOrNumber = New System.Windows.Forms.Label()
        Me.txtOrNumber = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.cboTotalAmount = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1904, 1041)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRecordPaymentInformation, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSavePayment, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 453)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.lblOrDate, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DateTimePickerOrDate, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(290, 132)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(304, 76)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'lblOrDate
        '
        Me.lblOrDate.AutoSize = True
        Me.lblOrDate.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrDate.Location = New System.Drawing.Point(3, 0)
        Me.lblOrDate.Name = "lblOrDate"
        Me.lblOrDate.Size = New System.Drawing.Size(90, 31)
        Me.lblOrDate.TabIndex = 0
        Me.lblOrDate.Text = "Or Date"
        '
        'DateTimePickerOrDate
        '
        Me.DateTimePickerOrDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerOrDate.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerOrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerOrDate.Location = New System.Drawing.Point(3, 34)
        Me.DateTimePickerOrDate.Name = "DateTimePickerOrDate"
        Me.DateTimePickerOrDate.Size = New System.Drawing.Size(194, 35)
        Me.DateTimePickerOrDate.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancel.Location = New System.Drawing.Point(290, 408)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblRecordPaymentInformation
        '
        Me.lblRecordPaymentInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordPaymentInformation.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblRecordPaymentInformation, 2)
        Me.lblRecordPaymentInformation.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordPaymentInformation.Location = New System.Drawing.Point(3, 0)
        Me.lblRecordPaymentInformation.Name = "lblRecordPaymentInformation"
        Me.lblRecordPaymentInformation.Size = New System.Drawing.Size(682, 46)
        Me.lblRecordPaymentInformation.TabIndex = 0
        Me.lblRecordPaymentInformation.Text = "Record Payment Information"
        '
        'btnSavePayment
        '
        Me.btnSavePayment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSavePayment.Location = New System.Drawing.Point(186, 408)
        Me.btnSavePayment.Name = "btnSavePayment"
        Me.btnSavePayment.Size = New System.Drawing.Size(98, 23)
        Me.btnSavePayment.TabIndex = 5
        Me.btnSavePayment.Text = "Save Payment"
        Me.btnSavePayment.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lblRequestNo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cboRequestNo, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 49)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(281, 77)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblRequestNo
        '
        Me.lblRequestNo.AutoSize = True
        Me.lblRequestNo.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequestNo.Location = New System.Drawing.Point(3, 0)
        Me.lblRequestNo.Name = "lblRequestNo"
        Me.lblRequestNo.Size = New System.Drawing.Size(135, 31)
        Me.lblRequestNo.TabIndex = 0
        Me.lblRequestNo.Text = "Request No:"
        '
        'cboRequestNo
        '
        Me.cboRequestNo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRequestNo.FormattingEnabled = True
        Me.cboRequestNo.Location = New System.Drawing.Point(3, 34)
        Me.cboRequestNo.Name = "cboRequestNo"
        Me.cboRequestNo.Size = New System.Drawing.Size(212, 35)
        Me.cboRequestNo.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.lblOrNumber, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtOrNumber, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(290, 49)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(304, 77)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'lblOrNumber
        '
        Me.lblOrNumber.AutoSize = True
        Me.lblOrNumber.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrNumber.Location = New System.Drawing.Point(3, 0)
        Me.lblOrNumber.Name = "lblOrNumber"
        Me.lblOrNumber.Size = New System.Drawing.Size(121, 31)
        Me.lblOrNumber.TabIndex = 0
        Me.lblOrNumber.Text = "Or Number"
        '
        'txtOrNumber
        '
        Me.txtOrNumber.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrNumber.Location = New System.Drawing.Point(3, 34)
        Me.txtOrNumber.Name = "txtOrNumber"
        Me.txtOrNumber.Size = New System.Drawing.Size(292, 35)
        Me.txtOrNumber.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.lblTotalAmount, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cboTotalAmount, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 132)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(281, 76)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(3, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(144, 31)
        Me.lblTotalAmount.TabIndex = 0
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'cboTotalAmount
        '
        Me.cboTotalAmount.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTotalAmount.FormattingEnabled = True
        Me.cboTotalAmount.Location = New System.Drawing.Point(3, 34)
        Me.cboTotalAmount.Name = "cboTotalAmount"
        Me.cboTotalAmount.Size = New System.Drawing.Size(212, 35)
        Me.cboTotalAmount.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.Controls.Add(Me.txtAmountPaid, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblAmountPaid, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(290, 214)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(304, 84)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(3, 34)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(194, 35)
        Me.txtAmountPaid.TabIndex = 2
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.Location = New System.Drawing.Point(3, 0)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(139, 31)
        Me.lblAmountPaid.TabIndex = 0
        Me.lblAmountPaid.Text = "Amount Paid"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.cboPaymentStatus, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.lblPaymentStatus, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(290, 304)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(304, 79)
        Me.TableLayoutPanel7.TabIndex = 5
        '
        'cboPaymentStatus
        '
        Me.cboPaymentStatus.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentStatus.FormattingEnabled = True
        Me.cboPaymentStatus.Location = New System.Drawing.Point(3, 34)
        Me.cboPaymentStatus.Name = "cboPaymentStatus"
        Me.cboPaymentStatus.Size = New System.Drawing.Size(194, 35)
        Me.cboPaymentStatus.TabIndex = 2
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentStatus.Location = New System.Drawing.Point(3, 0)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(168, 31)
        Me.lblPaymentStatus.TabIndex = 0
        Me.lblPaymentStatus.Text = "Payment Status"
        '
        'frmPaymentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPaymentInformation"
        Me.Text = "frmPaymentInformation"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblRecordPaymentInformation As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblOrDate As Label
    Friend WithEvents DateTimePickerOrDate As DateTimePicker
    Friend WithEvents lblRequestNo As Label
    Friend WithEvents cboRequestNo As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblOrNumber As Label
    Friend WithEvents txtOrNumber As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents cboTotalAmount As ComboBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents btnSavePayment As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents cboPaymentStatus As ComboBox
    Friend WithEvents lblPaymentStatus As Label
End Class
