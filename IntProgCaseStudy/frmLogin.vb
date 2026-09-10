Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connection()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Connection()

        ' Step 1: Check if the username and password fields are empty
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter your username and password.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Step 2: Prepare the SQL query to check the credentials
        sql = "SELECT * FROM tblusers WHERE username = @username AND password = @password"
        cmd = New MySqlCommand(sql, cn)
        With cmd

            .Parameters.AddWithValue("@username", txtUsername.Text)
            .Parameters.AddWithValue("@password", txtPassword.Text)
            .ExecuteNonQuery()

        End With

        ' Step 3: Execute the query and check if any rows are returned
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            ' Step 4: If credentials are valid, show the main form and hide the login form
            dr.Read()
            ' Show message box with the role
            MsgBox("Welcome " & dr("role").ToString() & "!", MsgBoxStyle.Information)
            frmMenu.Show()
            Me.Hide()
        Else
            ' Step 5: If credentials are invalid, show an error message
            MsgBox("Invalid username or password.", MsgBoxStyle.Critical)
        End If

        ' Step 6: Close the data reader
        dr.Close()

        ' Step 7: Clear the username and password fields
        txtUsername.Clear()
        txtPassword.Clear()

        ' Step 8: Set focus back to the username field
        txtUsername.Focus()

        ' Step 9: Close the database connection
        cn.Close()

        ' Step 10: Hide the login form
        Me.Hide()

    End Sub
End Class