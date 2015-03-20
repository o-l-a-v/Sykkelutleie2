Imports MySql.Data.MySqlClient
Imports System.Data
Public Class login
    Dim brukernavn As String
    Dim passord As String
    Dim connstring As String
    Private connectionOK As Boolean = False
    Dim conn As New MySqlConnection
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPW.PasswordChar = "*"
    End Sub

    Private Sub btnLogin_Click_1(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        brukernavn = txtUN.Text
        passord = txtPW.Text

        connstring = "Uid=" & txtUN.Text & ";" _
            & "Pwd=" & txtPW.Text & ";"

        conn.ConnectionString = connstring

        Try
            conn.Open()
            MessageBox.Show("Du er nå logget inn som: " & "navn")
            connectionOK = True

        Catch myerror As MySqlException
            MessageBox.Show("Feil brukernavn eller passord")
            connectionOK = False

        Finally
            conn.Dispose()
        End Try
    End Sub
End Class