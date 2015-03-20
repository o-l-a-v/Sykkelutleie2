Public Class Logginn
    Dim data As New DataTable
    Dim passord As String
    Private Sub Logginn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPW.PasswordChar = "*"
        txtBN.Focus()
    End Sub


    Private Sub btnLogginn_Click(sender As Object, e As EventArgs) Handles btnLogginn.Click
        Dim sql As String = "SELECT passord FROM ansatte WHERE personnr LIKE '" & txtBN.Text & "'"

        data = query(sql)

        Dim rad As DataRow
        If txtBN.Text = "" Or txtPW.Text = "" Then
            MsgBox("Feil.")
        Else
            Try
                For Each rad In data.Rows
                    passord = rad("passord")
                Next rad
            Catch ex As Exception
                MsgBox("Feil." & ex.Message)
            End Try
            If passord = txtPW.Text Then
                main.Show()
                Me.Hide()
            Else
                MsgBox("Feil brukernavn eller passord, prøv på nytt.")
            End If
        End If
        txtBN.Text = ""
        txtPW.Text = ""
    End Sub

    Private Sub txtBN_TextChanged(sender As Object, e As EventArgs) Handles txtBN.TextChanged
        Me.AcceptButton = btnLogginn

    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged
        Me.AcceptButton = btnLogginn
    End Sub
End Class