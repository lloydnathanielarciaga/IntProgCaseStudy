Imports MySql.Data.MySqlClient
Public Class frmRequestList
    ' Flags to handle state and prevent cascading event loops
    Private isInitializing As Boolean = True
    Private isCascading As Boolean = False

    Private Sub frmRequestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True
        PopulateStudentIDComboBox()
        PopulateRequestComboBox()
        isInitializing = False
        SetupListViewColumns()
        LoadRequestList()
    End Sub
    Private Sub SetupListViewColumns()
        With ListViewRequestList
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()

            ' Add columns matching your SQL query structure
            .Columns.Add("Request No.", 120)
            .Columns.Add("Student ID", 110)
            .Columns.Add("Student Name", 160)
            .Columns.Add("Document Name", 180)
            .Columns.Add("Quantity", 70)
            .Columns.Add("Fee", 80)
            .Columns.Add("Status", 100)
        End With
    End Sub

    Public Sub PopulateRequestComboBox(Optional studentID As String = "")
        Try
            Connection()

            sql = "SELECT RequestID, RequestNo FROM tblrequest "
            If Not String.IsNullOrEmpty(studentID) Then
                sql &= "WHERE StudentID = '" & studentID & "' "
            End If
            sql &= "ORDER BY RequestNo ASC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dr.Close()

            cboSearchRequest.DataSource = dt
            cboSearchRequest.DisplayMember = "RequestNo"
            cboSearchRequest.ValueMember = "RequestNo"
            cboSearchRequest.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error loading Request numbers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
        End Try
    End Sub

    Public Sub PopulateStudentIDComboBox()
        Try
            Connection()

            sql = "SELECT StudentID, CONCAT(StudentID, ' - ', LastName, ', ', FirstName) AS DisplayText FROM tblstudents ORDER BY StudentID ASC"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dr.Close()

            cboSearchStudentID.DataSource = dt
            cboSearchStudentID.DisplayMember = "DisplayText"
            cboSearchStudentID.ValueMember = "StudentID"
            cboSearchStudentID.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error loading Student IDs: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
        End Try
    End Sub

    ' Event: Selecting Student ID updates Request Dropdown
    Private Sub cboSearchStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchStudentID.SelectedIndexChanged
        If isInitializing OrElse isCascading Then Exit Sub

        Try
            isCascading = True

            If cboSearchStudentID.SelectedIndex <> -1 AndAlso cboSearchStudentID.SelectedItem IsNot Nothing Then
                If TypeOf cboSearchStudentID.SelectedItem Is DataRowView Then
                    Dim drv As DataRowView = CType(cboSearchStudentID.SelectedItem, DataRowView)
                    Dim studentID As String = drv("StudentID").ToString()

                    ' Filter request list for this student only
                    PopulateRequestComboBox(studentID)
                End If
            Else
                ' Load all requests if no student is selected
                PopulateRequestComboBox()
            End If

            LoadRequestList()

        Finally
            isCascading = False
        End Try
    End Sub

    ' Event: Selecting Request Number selects corresponding Student ID
    Private Sub cboSearchRequest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchRequest.SelectedIndexChanged
        If isInitializing OrElse isCascading Then Exit Sub

        Try
            isCascading = True

            If cboSearchRequest.SelectedIndex <> -1 AndAlso cboSearchRequest.SelectedItem IsNot Nothing Then
                If TypeOf cboSearchRequest.SelectedItem Is DataRowView Then
                    Dim drv As DataRowView = CType(cboSearchRequest.SelectedItem, DataRowView)
                    Dim requestNo As String = drv("RequestNo").ToString()

                    ' Retrieve associated Student ID for selected Request Number
                    Connection()
                    sql = "SELECT StudentID FROM tblrequest WHERE RequestNo = '" & requestNo & "' LIMIT 1"
                    cmd = New MySqlCommand(sql, cn)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        cboSearchStudentID.SelectedValue = result.ToString()
                    End If
                End If
            End If

            LoadRequestList()

        Catch ex As Exception
            MessageBox.Show("Error auto-selecting Student ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            isCascading = False
        End Try
    End Sub

    ' Event: Status Filter selection
    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        If isInitializing OrElse isCascading Then Exit Sub
        LoadRequestList()
    End Sub

    Public Sub LoadRequestList()
        If isInitializing Then Exit Sub

        Try
            ListViewRequestList.Items.Clear()

            sql = "SELECT r.RequestNo, " &
                  "       s.StudentID, " &
                  "       CONCAT(s.LastName, ', ', s.FirstName) AS StudentName, " &
                  "       IFNULL(d.DocumentName, 'N/A') AS DocumentName, " &
                  "       IFNULL(rd.Quantity, 0) AS Quantity, " &
                  "       IFNULL(d.Fee, 0) AS Fee, " &
                  "       r.Status " &
                  "FROM tblrequest r " &
                  "LEFT JOIN tblstudents s ON r.StudentID = s.StudentID " &
                  "LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                  "LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                  "WHERE 1=1 "

            ' Filter by Student ID if selected
            If cboSearchStudentID.SelectedIndex <> -1 AndAlso cboSearchStudentID.SelectedItem IsNot Nothing Then
                If TypeOf cboSearchStudentID.SelectedItem Is DataRowView Then
                    Dim drv As DataRowView = CType(cboSearchStudentID.SelectedItem, DataRowView)
                    Dim studentID As String = drv("StudentID").ToString()
                    If Not String.IsNullOrEmpty(studentID) Then
                        sql &= " AND s.StudentID = '" & studentID & "' "
                    End If
                End If
            End If

            ' Filter by Request Number if selected
            If cboSearchRequest.SelectedIndex <> -1 AndAlso cboSearchRequest.SelectedItem IsNot Nothing Then
                If TypeOf cboSearchRequest.SelectedItem Is DataRowView Then
                    Dim drv As DataRowView = CType(cboSearchRequest.SelectedItem, DataRowView)
                    Dim requestNo As String = drv("RequestNo").ToString()
                    If Not String.IsNullOrEmpty(requestNo) Then
                        sql &= " AND r.RequestNo = '" & requestNo & "' "
                    End If
                End If
            End If

            ' Filter by Status if selected
            If cboStatusFilter.SelectedIndex <> -1 AndAlso Not String.IsNullOrWhiteSpace(cboStatusFilter.Text) Then
                sql &= " AND r.Status = '" & cboStatusFilter.Text.Trim() & "' "
            End If

            sql &= " ORDER BY r.RequestID DESC"

            Connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("RequestNo").ToString())
                item.SubItems.Add(dr("StudentID").ToString())
                item.SubItems.Add(dr("StudentName").ToString())
                item.SubItems.Add(dr("DocumentName").ToString())
                item.SubItems.Add(dr("Quantity").ToString())
                item.SubItems.Add(Convert.ToDecimal(dr("Fee")).ToString("N2"))
                item.SubItems.Add(dr("Status").ToString())

                ListViewRequestList.Items.Add(item)
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading request list: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            ' Prevent event cascading loops while clearing selections
            isCascading = True

            ' Reset selections
            cboSearchStudentID.SelectedIndex = -1
            cboSearchRequest.SelectedIndex = -1

            If cboStatusFilter IsNot Nothing Then
                cboStatusFilter.SelectedIndex = -1
            End If

            ' Restore cboSearchRequest to display ALL requests (removes student-specific filter)
            PopulateRequestComboBox()

        Finally
            isCascading = False
        End Try

        ' Refresh ListView to show all records without filters
        LoadRequestList()
    End Sub
End Class