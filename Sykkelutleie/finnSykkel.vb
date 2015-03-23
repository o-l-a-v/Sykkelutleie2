Public Class finnSykkel

    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        Dim sql As String = "SELECT * from sykkel WHERE rammenr LIKE '%" & txtSok.Text & "%'"
        Dim sql2 As String = "SELECT * from sykkel WHERE type LIKE '%" & txtSok.Text & "%'"
        Dim sql3 As String = "SELECT * from sykkel WHERE modell LIKE '%" & txtSok.Text & "%'"
        Dim sql4 As String = "SELECT * from sykkel WHERE org_sted LIKE '%" & txtSok.Text & "%'"

        Dim dataRammenr As DataTable = query(sql)
        Dim dataType As DataTable = query(sql2)
        Dim dataModell As DataTable = query(sql3)
        Dim dataSted As DataTable = query(sql4)

        Dim data As DataTable = dataRammenr
        If dataType.Rows.Count > data.Rows.Count Then
            data = dataType
        End If
        If dataModell.Rows.Count > data.Rows.Count Then
            data = dataModell
        End If
        If dataSted.Rows.Count > data.Rows.Count Then
            data = dataSted
        End If

        DataGridView1.DataSource = data
    End Sub
End Class