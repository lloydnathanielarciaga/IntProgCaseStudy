Imports MySql.Data.MySqlClient

Public Class frmPaymentInformation

    Private isInitializing As Boolean = True

    Private Sub frmPaymentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True
        PopulatePaymentStatusOptions()
        PopulateRequestNoComboBox()
        isInitializing = False
    End Sub

    ''' <summary>
    ''' Fills options for cboPaymentStatus (Paid / Unpaid)
    ''' </summary>
    Private Sub PopulatePaymentStatusOptions()
        cboPaymentStatus.Items.Clear()
        cboPaymentStatus.Items.Add("Paid")
        cboPaymentStatus.Items.Add("Unpaid")
        cboPaymentStatus.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' Populates cboRequestNo with active request numbers from tblrequest
    ''' </summary>
    Public Sub PopulateRequestNoComboBox()
        Try
            Connection()
            sql = "SELECT RequestID, RequestNo FROM tblrequest ORDER BY RequestNo DESC"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dr.Close()

            cboRequestNo.DataSource = dt
            cboRequestNo.DisplayMember = "RequestNo"
            cboRequestNo.ValueMember = "RequestNo"
            cboRequestNo.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error loading request numbers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Event triggered when a Request Number is selected
    ''' Updates cboTotalAmount and cboPaymentStatus
    ''' </summary>
    Private Sub cboRequestNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRequestNo.SelectedIndexChanged
        If isInitializing Then Exit Sub

        If cboRequestNo.SelectedIndex = -1 OrElse cboRequestNo.SelectedItem Is Nothing Then
            cboTotalAmount.Items.Clear()
            cboTotalAmount.Text = ""
            cboPaymentStatus.SelectedIndex = -1
            Exit Sub
        End If

        Try
            Dim selectedRequestNo As String = ""
            If TypeOf cboRequestNo.SelectedItem Is DataRowView Then
                Dim drv As DataRowView = CType(cboRequestNo.SelectedItem, DataRowView)
                selectedRequestNo = drv("RequestNo").ToString()
            Else
                selectedRequestNo = cboRequestNo.Text
            End If

            If String.IsNullOrEmpty(selectedRequestNo) Then Exit Sub

            Connection()

            ' Retrieves total calculated fee and current status from tblrequest
            sql = "SELECT r.Status, " &
                  "       IFNULL(SUM(rd.Quantity * d.Fee), 0) AS TotalAmount " &
                  "FROM tblrequest r " &
                  "LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                  "LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                  "WHERE r.RequestNo = '" & selectedRequestNo & "' " &
                  "GROUP BY r.RequestID, r.Status"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim totalFee As Decimal = Convert.ToDecimal(dr("TotalAmount"))
                Dim dbStatus As String = dr("Status").ToString().Trim()

                ' Set total amount in cboTotalAmount
                cboTotalAmount.Items.Clear()
                cboTotalAmount.Items.Add(totalFee.ToString("N2"))
                cboTotalAmount.SelectedIndex = 0

                ' Match Status to Paid or Unpaid
                If dbStatus.Equals("Paid", StringComparison.OrdinalIgnoreCase) Then
                    cboPaymentStatus.SelectedItem = "Paid"
                Else
                    cboPaymentStatus.SelectedItem = "Unpaid"
                End If
            End If

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading payment details for selected request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
        End Try
    End Sub

    Private Sub btnSavePayment_Click(sender As Object, e As EventArgs) Handles btnSavePayment.Click
        ' 1. Validate Required Inputs
        If cboRequestNo.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cboRequestNo.Text) Then
            MessageBox.Show("Please select a Request Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboRequestNo.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtOrNumber.Text) Then
            MessageBox.Show("Please enter the OR Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtOrNumber.Focus()
            Exit Sub
        End If

        If cboPaymentStatus.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cboPaymentStatus.Text) Then
            MessageBox.Show("Please select a Payment Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPaymentStatus.Focus()
            Exit Sub
        End If

        ' 2. Update Payment Details in tblrequest
        Try
            Connection()

            ' Match column names with phpMyAdmin: ORNo, ORDate, PaymentStatus, Status
            sql = "UPDATE tblrequest " &
              "SET ORNo = @ORNo, " &
              "    ORDate = @ORDate, " &
              "    PaymentStatus = @PaymentStatus, " &
              "    Status = @Status " &
              "WHERE RequestNo = @RequestNo"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@ORNo", txtOrNumber.Text.Trim())
            cmd.Parameters.AddWithValue("@ORDate", DateTimePickerOrDate.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@PaymentStatus", cboPaymentStatus.SelectedItem.ToString())

            ' Set workflow Status to 'Processing' if Paid, otherwise keep as 'Pending'
            Dim requestStatus As String = If(cboPaymentStatus.SelectedItem.ToString() = "Paid", "Processing", "Pending")
            cmd.Parameters.AddWithValue("@Status", requestStatus)

            cmd.Parameters.AddWithValue("@RequestNo", cboRequestNo.Text.Trim())

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Payment information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearPaymentForm()
            Else
                MessageBox.Show("No matching Request Number found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating payment information: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Resets form controls back to blank states
    ''' </summary>
    Private Sub ClearPaymentForm()
        cboRequestNo.SelectedIndex = -1
        cboTotalAmount.Items.Clear()
        cboTotalAmount.Text = ""
        txtOrNumber.Clear()
        DateTimePickerOrDate.Value = DateTime.Now
        txtAmountPaid.Clear()
        cboPaymentStatus.SelectedIndex = -1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearPaymentForm()
        Me.Close()
    End Sub

End Class