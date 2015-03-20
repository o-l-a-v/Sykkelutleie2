Public Class main

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox1.SelectedIndex = 0 Then
            Logginn.Show()
            Me.Hide()
        End If
    End Sub
End Class

