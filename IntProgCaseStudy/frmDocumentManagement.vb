Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmDocumentManagement
    Private isPopulating As Boolean = False
    Private Sub frmDocumentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connection()

        ' Step 1: Set ListViewDocument properties
        ListViewDocument.View = View.Details
        ListViewDocument.FullRowSelect = True
        ListViewDocument.GridLines = True

        ' Step 2: Define the columns
        ListViewDocument.Columns.Add("DocumentID", 100)
        ListViewDocument.Columns.Add("DocumentName", 200)
        ListViewDocument.Columns.Add("Description", 250)
        ListViewDocument.Columns.Add("Fee", 100)
        ListViewDocument.Columns.Add("Status", 100)

        LoadAllDocuments()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Call Connection()

        ' Step 1: txtDocumentID and cboDocumentName are empty, show a message and exit
        If txtDocumentID.Text = "" And cboDocumentName.SelectedIndex = -1 Then
            MsgBox("Please enter a Document ID or select a Document Name to search.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Step 2: Check if txtDocumentID and cboDocumentName are both in the tbldocuments table
        sql = "SELECT * FROM tbldocuments WHERE DocumentID = @DocumentID OR DocumentName = @DocumentName"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@DocumentID", txtDocumentID.Text)
            .Parameters.AddWithValue("@DocumentName", cboDocumentName.SelectedItem?.ToString())
            dr = .ExecuteReader()
        End With

        ' Step 3: If no rows are returned, show a message and exit
        If Not dr.HasRows Then
            MsgBox("No matching document found.", MsgBoxStyle.Information)
            dr.Close()
            cn.Close()
            Exit Sub
        End If

        ' Step 4: If a matching document is found, display it in the ListView
        ListViewDocument.Items.Clear()
        While dr.Read()
            Dim item As New ListViewItem(dr("DocumentID").ToString())
            item.SubItems.Add(dr("DocumentName").ToString())
            item.SubItems.Add(dr("Description").ToString())
            item.SubItems.Add(dr("Fee").ToString())
            item.SubItems.Add(dr("Status").ToString())
            ListViewDocument.Items.Add(item)
        End While

        ' Step 5: Clean up connections
        txtDocumentID.Clear()
        cboDocumentName.SelectedIndex = -1

        dr.Close()
        cn.Close()

    End Sub

    Private Sub cboDocumentName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentName.SelectedIndexChanged
        ' Step 1: Check if nothing is selected, OR if the change is coming from the ListView click
        If cboDocumentName.SelectedIndex = -1 OrElse isPopulating Then
            Exit Sub
        End If

        Call Connection()

        ' Step 2: Search only by the selected Document Name
        sql = "SELECT * FROM tbldocuments WHERE DocumentName = @DocumentName"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@DocumentName", cboDocumentName.SelectedItem.ToString())

        dr = cmd.ExecuteReader()

        ' Step 3: Clear the ListView and display the matching document(s)
        ListViewDocument.Items.Clear()

        While dr.Read()
            Dim item As New ListViewItem(dr("DocumentID").ToString())
            item.SubItems.Add(dr("DocumentName").ToString())
            item.SubItems.Add(dr("Description").ToString())
            item.SubItems.Add(dr("Fee").ToString())
            item.SubItems.Add(dr("Status").ToString())
            ListViewDocument.Items.Add(item)
        End While

        ' Step 4: Close connections
        dr.Close()
        cn.Close()
    End Sub

    Private Sub LoadAllDocuments()
        Call Connection()

        ListViewDocument.Items.Clear()
        cboDocumentName.Items.Clear()

        sql = "SELECT * FROM tbldocuments"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim item As New ListViewItem(dr("DocumentID").ToString())
            item.SubItems.Add(dr("DocumentName").ToString())
            item.SubItems.Add(dr("Description").ToString())
            item.SubItems.Add(dr("Fee").ToString())
            item.SubItems.Add(dr("Status").ToString())
            ListViewDocument.Items.Add(item)

            Dim docName As String = dr("DocumentName").ToString()
            If Not cboDocumentName.Items.Contains(docName) Then
                cboDocumentName.Items.Add(docName)
            End If
        End While

        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click

        txtDocumentID.Clear()
        cboDocumentName.SelectedIndex = -1
        txtDescription.Clear()
        txtFee.Clear()
        rdoActive.Checked = False
        rdoInactive.Checked = False
        LoadAllDocuments()

    End Sub

    Public Sub LoadDocumentData()
        ListViewDocument.Items.Clear()

        sql = "SELECT DocumentID, DocumentName, Description, Fee, Status FROM tbldocuments"

        Try
            Connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                ' Column 0: DocumentID
                Dim item As New ListViewItem(dr("DocumentID").ToString())

                ' Remaining SubItems
                item.SubItems.Add(dr("DocumentName").ToString())
                item.SubItems.Add(If(IsDBNull(dr("Description")), "", dr("Description").ToString()))
                item.SubItems.Add(Convert.ToDecimal(dr("Fee")).ToString("N2"))
                item.SubItems.Add(dr("Status").ToString())

                ListViewDocument.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading documents: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub ClearInputFields()
        txtDocumentID.Clear()
        cboDocumentName.SelectedIndex = -1
        txtDescription.Clear()
        txtFee.Clear()
        rdoActive.Checked = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Updated to check cboDocumentName instead of txtDocumentName
        If String.IsNullOrWhiteSpace(cboDocumentName.Text) OrElse String.IsNullOrWhiteSpace(txtFee.Text) Then
            MessageBox.Show("Please fill in Document Name and Fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim statusValue As String = If(rdoActive.Checked, "Active", "Inactive")
        Dim query As String = "INSERT INTO tbldocuments (DocumentName, Description, Fee, Status) VALUES (@name, @desc, @fee, @status);"

        Try
            Using cmd As New MySqlCommand(query, cn)
                ' Updated parameter to grab the text from the ComboBox
                cmd.Parameters.AddWithValue("@name", cboDocumentName.Text.Trim())
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@fee", Convert.ToDecimal(txtFee.Text.Trim()))
                cmd.Parameters.AddWithValue("@status", statusValue)

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Document added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputFields()
            LoadDocumentData() ' Refreshes the ListView
        Catch ex As Exception
            MessageBox.Show("Error adding document: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        ' Display a message confirming to edit the selected document, ask in yes or no style and if yes, display a message box comparing the old and new values of the document, update the following in the database, then update the document in the database and refresh the ListViewDocument
        If ListViewDocument.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a document to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedItem As ListViewItem = ListViewDocument.SelectedItems(0)

        Dim oldDocumentName As String = selectedItem.SubItems(1).Text

        Dim oldDescription As String = selectedItem.SubItems(2).Text

        Dim oldFee As String = selectedItem.SubItems(3).Text

        Dim oldStatus As String = selectedItem.SubItems(4).Text

        Dim newDocumentName As String = cboDocumentName.Text.Trim()

        Dim newDescription As String = txtDescription.Text.Trim()

        Dim newFee As String = txtFee.Text.Trim()

        Dim newStatus As String = If(rdoActive.Checked, "Active", "Inactive")

        Dim confirmationMessage As String = $"Are you sure you want to edit the selected document?" & vbCrLf & vbCrLf &
                                            $"Old Values:" & vbCrLf &
                                            $"Document Name: {oldDocumentName}" & vbCrLf &
                                            $"Description: {oldDescription}" & vbCrLf &
                                            $"Fee: {oldFee}" & vbCrLf &
                                            $"Status: {oldStatus}" & vbCrLf & vbCrLf &
                                            $"New Values:" & vbCrLf &
                                            $"Document Name: {newDocumentName}" & vbCrLf &
                                            $"Description: {newDescription}" & vbCrLf &
                                            $"Fee: {newFee}" & vbCrLf &
                                            $"Status: {newStatus}"

        Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim updateQuery As String = "UPDATE tbldocuments SET DocumentName = @name, Description = @desc, Fee = @fee, Status = @status WHERE DocumentID = @id"
            Try
                Using cmd As New MySqlCommand(updateQuery, cn)
                    cmd.Parameters.AddWithValue("@name", newDocumentName)
                    cmd.Parameters.AddWithValue("@desc", newDescription)
                    cmd.Parameters.AddWithValue("@fee", Convert.ToDecimal(newFee))
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@id", selectedItem.SubItems(0).Text)
                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Document updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearInputFields()
                LoadDocumentData() ' Refreshes the ListView
            Catch ex As Exception
                MessageBox.Show("Error updating document: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cn.Close()
            End Try
        End If

    End Sub

    Private Sub ListViewDocument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewDocument.SelectedIndexChanged

        ' Automatically fill the input, combo box, and radio buttons
        If ListViewDocument.SelectedItems.Count > 0 Then
            isPopulating = True ' Set flag to true before making changes

            Dim selectedItem As ListViewItem = ListViewDocument.SelectedItems(0)
            txtDocumentID.Text = selectedItem.SubItems(0).Text
            cboDocumentName.Text = selectedItem.SubItems(1).Text
            txtDescription.Text = selectedItem.SubItems(2).Text
            txtFee.Text = selectedItem.SubItems(3).Text

            If selectedItem.SubItems(4).Text = "Active" Then
                rdoActive.Checked = True
            Else
                rdoInactive.Checked = True
            End If

            isPopulating = False ' Turn flag back off once done
        End If

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        ' 1. Check if an item is selected from the ListView (matches btnEdit logic)
        If ListViewDocument.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a document from the list to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim selectedItem As ListViewItem = ListViewDocument.SelectedItems(0)
        Dim docName As String = selectedItem.SubItems(1).Text

        ' 2. Ask for user confirmation (includes the document name for better UI)
        Dim confirm As DialogResult = MessageBox.Show($"Are you sure you want to permanently delete '{docName}'?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Return

        sql = "DELETE FROM tbldocuments WHERE DocumentID = @id"

        Try
            Connection()
            cmd = New MySqlCommand(sql, cn)
            ' 3. Grab the ID safely from the selected ListView item
            cmd.Parameters.AddWithValue("@id", selectedItem.SubItems(0).Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Document deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 4. Updated method name to match the rest of your class
            ClearInputFields()
            LoadDocumentData() ' Refreshes the ListView

        Catch ex As MySqlException
            ' Handles Foreign Key constraint violation (Error 1451) if document is in tblrequestdetails
            If ex.Number = 1451 Then
                MessageBox.Show("Cannot delete this document because it has existing student requests. Use Deactivate instead to preserve transaction history.", "Referential Integrity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Database error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click

        ' 1. Validate using ListView selection instead of the text box
        If ListViewDocument.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a document from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim selectedItem As ListViewItem = ListViewDocument.SelectedItems(0)

        ' 2. Safely read current status from the grid and toggle it
        Dim currentStatus As String = selectedItem.SubItems(4).Text
        Dim newStatus As String = If(currentStatus = "Active", "Inactive", "Active")

        Dim sql As String = "UPDATE tbldocuments SET Status = @status WHERE DocumentID = @id"

        Try
            Connection()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@status", newStatus)
            ' 3. Grab the ID directly from the selected list item
            cmd.Parameters.AddWithValue("@id", selectedItem.SubItems(0).Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show($"Status successfully changed to {newStatus}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearInputFields()
            LoadDocumentData() ' Refreshes ListView
        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' 1. Clear all TextBoxes
        txtDocumentID.Clear()
        txtDescription.Clear()
        txtFee.Clear()

        ' 2. Clear ComboBox (removes text and drops any selection)
        cboDocumentName.SelectedIndex = -1
        cboDocumentName.Text = ""

        ' 3. Uncheck all Radio Buttons
        rdoActive.Checked = False
        rdoInactive.Checked = False

        ' 4. Clear any selected row in the ListView
        ListViewDocument.SelectedItems.Clear()

    End Sub
End Class