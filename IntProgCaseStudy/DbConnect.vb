Imports MySql.Data.MySqlClient
Module DbConnect

    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub Connection()
        Try
            cn.Close()
            cn.ConnectionString = "server=localhost;user=root;password=;database=registrar_db"
            cn.Open()
            'MsgBox("Database Connected", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
