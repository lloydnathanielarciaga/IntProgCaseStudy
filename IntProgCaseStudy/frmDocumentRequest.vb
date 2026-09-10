Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frmDocumentRequest
    Private isSyncing As Boolean = False
    Private unitFee As Decimal = 0.00D
    Private Sub frmDocumentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtRequestNumber.Text = GenerateRequestNo()
        LoadRegistrarStaff()
        LoadStudents()
        LoadDocuments()
        SetupListView()
        txtTotalAmount.Text = "0.00"

    End Sub

    Public Sub LoadRegistrarStaff()
        Try
            Connection()

            ' 1. Write the SQL query using Parameters (@role, @status)
            sql = "SELECT FullName FROM tblusers WHERE Role = @role AND Status = @status"
            cmd = New MySqlCommand(sql, cn)

            ' 2. Assign values to the parameters
            cmd.Parameters.AddWithValue("@role", "Registrar Staff")
            cmd.Parameters.AddWithValue("@status", "Active")

            ' 3. Clear existing items in the ComboBox before adding new ones
            cboProcessedBy.Items.Clear()

            ' 4. Use the DataReader (dr) to read the database rows
            dr = cmd.ExecuteReader()

            While dr.Read()
                ' Add each fetched name to the dropdown
                cboProcessedBy.Items.Add(dr("FullName").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            ' Close the DataReader and Connection to free up resources
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Public Function GenerateRequestNo() As String
        Dim reqNo As String = ""
        Try
            Connection()
            sql = "SELECT IFNULL(MAX(RequestID), 0) + 1 FROM tblrequest"
            cmd = New MySqlCommand(sql, cn)

            Dim nextId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Dim currentYear As String = DateTime.Now.Year.ToString()

            ' Produces format: REQ-2026-00016
            reqNo = "REQ-" & currentYear & "-" & nextId.ToString("D5")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        Return reqNo
    End Function

    Public Sub LoadStudents()
        Try
            Connection()

            sql = "SELECT StudentID, CONCAT(LastName, ', ', FirstName) AS FullName FROM tblstudents WHERE Status = @status ORDER BY StudentID ASC"

            cmd = New MySqlCommand()
            With cmd
                .Connection = cn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@status", "Active")

                cboStudentID.Items.Clear()
                cboStudentName.Items.Clear()

                dr = .ExecuteReader()

                While dr.Read()
                    cboStudentID.Items.Add(dr("StudentID").ToString())
                    cboStudentName.Items.Add(dr("FullName").ToString())
                End While
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Public Sub LoadDocuments()
        Try
            Connection()

            sql = "SELECT DocumentName FROM tbldocuments WHERE Status = @status ORDER BY DocumentName ASC"

            cmd = New MySqlCommand()
            With cmd
                .Connection = cn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@status", "Active")

                cboDocumentName.Items.Clear()

                dr = .ExecuteReader()

                While dr.Read()
                    cboDocumentName.Items.Add(dr("DocumentName").ToString())
                End While
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub cboStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentID.SelectedIndexChanged
        If isSyncing OrElse cboStudentID.SelectedIndex = -1 Then Exit Sub

        isSyncing = True
        cboStudentName.SelectedIndex = cboStudentID.SelectedIndex
        GetStudentDetails(cboStudentID.Text)
        isSyncing = False
    End Sub

    Private Sub cboStudentName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentName.SelectedIndexChanged
        If isSyncing OrElse cboStudentName.SelectedIndex = -1 Then Exit Sub

        isSyncing = True
        cboStudentID.SelectedIndex = cboStudentName.SelectedIndex
        GetStudentDetails(cboStudentID.Text)
        isSyncing = False
    End Sub

    Public Sub GetStudentDetails(studentId As String)
        Try
            Connection()

            sql = "SELECT Course, YearLevel FROM tblstudents WHERE StudentID = @studentId"

            cmd = New MySqlCommand()
            With cmd
                .Connection = cn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@studentId", studentId)

                dr = .ExecuteReader()

                If dr.Read() Then
                    cboCourse.Text = dr("Course").ToString()
                    cboYear.Text = dr("YearLevel").ToString()
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Public Sub GetDocumentFee()
        If cboDocumentName.SelectedIndex = -1 Then Exit Sub

        Try
            Connection()

            sql = "SELECT Fee FROM tbldocuments WHERE DocumentName = @docName AND Status = 'Active'"

            cmd = New MySqlCommand()
            With cmd
                .Connection = cn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@docName", cboDocumentName.Text)

                dr = .ExecuteReader()

                If dr.Read() Then
                    unitFee = Convert.ToDecimal(dr("Fee"))
                Else
                    unitFee = 0.00D
                End If
            End With

            CalculateItemFee()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub CalculateItemFee()
        Dim totalFee As Decimal = unitFee * NumericUpDownQuantity.Value
        TextBox1.Text = totalFee.ToString("N2")
    End Sub

    Private Sub cboDocumentName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentName.SelectedIndexChanged
        GetDocumentFee()
    End Sub

    ' Triggers when the quantity number changes
    Private Sub NumericUpDownQuantity_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownQuantity.ValueChanged
        CalculateItemFee()
    End Sub

    Public Sub SetupListView()
        With ListViewRequestList
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()

            ' Setup columns
            .Columns.Add("Request No.", 120)
            .Columns.Add("Student ID", 110)
            .Columns.Add("Student Name", 180)
            .Columns.Add("Document Name", 200)
            .Columns.Add("Quantity", 80)
            .Columns.Add("Fee", 100)
        End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' 1. Validate selections
        If String.IsNullOrWhiteSpace(txtRequestNumber.Text) Then
            MsgBox("Request number is missing.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        If cboStudentID.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cboStudentID.Text) Then
            MsgBox("Please select a Student ID first.", MsgBoxStyle.Exclamation, "Selection Required")
            Exit Sub
        End If

        If cboDocumentName.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cboDocumentName.Text) Then
            MsgBox("Please select a Document Name first.", MsgBoxStyle.Exclamation, "Selection Required")
            Exit Sub
        End If

        If NumericUpDownQuantity.Value <= 0 Then
            MsgBox("Please enter a valid quantity.", MsgBoxStyle.Exclamation, "Invalid Quantity")
            Exit Sub
        End If

        ' 2. Prompt user for confirmation
        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to add this document request item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Add")
        If confirm = MsgBoxResult.No Then Exit Sub

        ' 3. Add item to ListViewRequestList
        Dim item As New ListViewItem(txtRequestNumber.Text)
        item.SubItems.Add(cboStudentID.Text)
        item.SubItems.Add(cboStudentName.Text)
        item.SubItems.Add(cboDocumentName.Text)
        item.SubItems.Add(NumericUpDownQuantity.Value.ToString())
        item.SubItems.Add(TextBox1.Text) ' Index 5: Total Fee

        ListViewRequestList.Items.Add(item)

        ' 4. Recalculate total amount
        CalculateTotalAmount()

        ' 5. Reset document input controls for the next item
        cboDocumentName.SelectedIndex = -1
        NumericUpDownQuantity.Value = 1
        TextBox1.Text = "0.00"
        unitFee = 0.00D
    End Sub

    Public Sub CalculateTotalAmount()
        Dim grandTotal As Decimal = 0.00D

        ' Loop through every item in ListViewRequestList
        For Each item As ListViewItem In ListViewRequestList.Items
            Dim rowFee As Decimal = 0.00D

            ' Column index 5 corresponds to the "Fee" column
            If Decimal.TryParse(item.SubItems(5).Text, rowFee) Then
                grandTotal += rowFee
            End If
        Next

        ' Display formatted total in TextBox2 (lblTotalAmount)
        txtTotalAmount.Text = grandTotal.ToString("N2")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewRequestList.SelectedIndexChanged

    End Sub

    Private Sub btnSaveRequest_Click(sender As Object, e As EventArgs) Handles btnSaveRequest.Click
        ' 1. Validate inputs before saving
        If ListViewRequestList.Items.Count = 0 Then
            MsgBox("Please add at least one document request item to the list before saving.", MsgBoxStyle.Exclamation, "Empty Request")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cboProcessedBy.Text) Then
            MsgBox("Please select who processed this request.", MsgBoxStyle.Exclamation, "Validation Error")
            cboProcessedBy.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cboStudentID.Text) Then
            MsgBox("Please select a student.", MsgBoxStyle.Exclamation, "Validation Error")
            cboStudentID.Focus()
            Exit Sub
        End If

        ' 2. Confirm action
        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to save this document request?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Save")
        If confirm = MsgBoxResult.No Then Exit Sub

        ' 3. Save using MySQL Transaction
        Dim transaction As MySqlTransaction = Nothing

        Try
            Connection()
            transaction = cn.BeginTransaction()

            ' Step A: Lookup UserID (CreatedBy) from tblusers based on FullName
            Dim createdByUserId As Integer = 0
            Dim sqlGetUser As String = "SELECT UserID FROM tblusers WHERE FullName = @FullName LIMIT 1"
            Using cmdUser As New MySqlCommand(sqlGetUser, cn, transaction)
                cmdUser.Parameters.AddWithValue("@FullName", cboProcessedBy.Text)
                Dim result = cmdUser.ExecuteScalar()
                If result IsNot Nothing Then
                    createdByUserId = Convert.ToInt32(result)
                Else
                    Throw New Exception("Selected staff user was not found in tblusers.")
                End If
            End Using

            ' Step B: Insert Header Record into tblrequest
            Dim sqlRequest As String = "INSERT INTO tblrequest " &
            "(RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, ORNo, ORDate, Status, CreatedBy) " &
            "VALUES (@RequestNo, @StudentID, @RequestDate, @TotalAmount, 'Unpaid', NULL, NULL, 'Pending', @CreatedBy)"

            Dim newRequestId As Long = 0

            Using cmdRequest As New MySqlCommand(sqlRequest, cn, transaction)
                cmdRequest.Parameters.AddWithValue("@RequestNo", txtRequestNumber.Text)
                cmdRequest.Parameters.AddWithValue("@StudentID", cboStudentID.Text)
                cmdRequest.Parameters.AddWithValue("@RequestDate", DateTimePickerDate.Value.ToString("yyyy-MM-dd"))
                cmdRequest.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(txtTotalAmount.Text))
                cmdRequest.Parameters.AddWithValue("@CreatedBy", createdByUserId)

                cmdRequest.ExecuteNonQuery()

                ' Fetch newly generated RequestID for detail records
                newRequestId = cmdRequest.LastInsertedId
            End Using

            ' Step C: Insert Line Items into tblrequestdetails
            For Each item As ListViewItem In ListViewRequestList.Items
                Dim docName As String = item.SubItems(3).Text
                Dim qty As Integer = Convert.ToInt32(item.SubItems(4).Text)
                Dim fee As Decimal = Convert.ToDecimal(item.SubItems(5).Text)
                Dim subtotal As Decimal = qty * fee

                ' Lookup DocumentID from tbldocuments
                Dim docId As Integer = 0
                Dim sqlGetDoc As String = "SELECT DocumentID FROM tbldocuments WHERE DocumentName = @DocName LIMIT 1"
                Using cmdDoc As New MySqlCommand(sqlGetDoc, cn, transaction)
                    cmdDoc.Parameters.AddWithValue("@DocName", docName)
                    Dim docResult = cmdDoc.ExecuteScalar()
                    If docResult IsNot Nothing Then
                        docId = Convert.ToInt32(docResult)
                    Else
                        Throw New Exception("Document '" & docName & "' not found in tbldocuments.")
                    End If
                End Using

                ' Insert details record
                Dim sqlDetails As String = "INSERT INTO tblrequestdetails " &
                "(RequestID, DocumentID, Quantity, Amount, Subtotal) " &
                "VALUES (@RequestID, @DocumentID, @Quantity, @Amount, @Subtotal)"

                Using cmdDetails As New MySqlCommand(sqlDetails, cn, transaction)
                    cmdDetails.Parameters.AddWithValue("@RequestID", newRequestId)
                    cmdDetails.Parameters.AddWithValue("@DocumentID", docId)
                    cmdDetails.Parameters.AddWithValue("@Quantity", qty)
                    cmdDetails.Parameters.AddWithValue("@Amount", fee)
                    cmdDetails.Parameters.AddWithValue("@Subtotal", subtotal)

                    cmdDetails.ExecuteNonQuery()
                End Using
            Next

            ' Commit all changes if no exceptions occurred
            transaction.Commit()

            MsgBox("Document request saved successfully!", MsgBoxStyle.Information, "Success")
            ResetForm()

        Catch ex As Exception
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MsgBox("An error occurred while saving: " & ex.Message, MsgBoxStyle.Critical, "Save Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub ResetForm()
        ' Generate a new Request Number
        txtRequestNumber.Text = GenerateRequestNo()

        ' Reset selection inputs
        cboProcessedBy.SelectedIndex = -1
        cboStudentID.SelectedIndex = -1
        cboStudentName.SelectedIndex = -1
        cboCourse.SelectedIndex = -1
        cboYear.SelectedIndex = -1
        cboDocumentName.SelectedIndex = -1

        NumericUpDownQuantity.Value = 1
        TextBox1.Text = "0.00"
        txtTotalAmount.Text = "0.00"
        unitFee = 0.00D

        ' Clear ListView items
        ListViewRequestList.Items.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to cancel and clear the form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Cancel")
        If confirm = MsgBoxResult.Yes Then
            ResetForm()
        End If
    End Sub

End Class