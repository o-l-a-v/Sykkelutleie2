Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Configuration

Module sqlsokDAO

    Public Function query(sql As String) As DataTable
        Dim data As New DataTable
        Dim conn As MySqlConnection = New MySqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("mysql").ConnectionString

        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = New MySqlCommand(sql, conn)
            adapter.Fill(data)
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Feil ved oppkobling til databasen" & ex.Message)
        Finally
            conn.Dispose()

        End Try
        Return data

    End Function
End Module
