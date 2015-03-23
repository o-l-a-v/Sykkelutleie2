Public Class main

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox1.SelectedIndex = 0 Then
            Logginn.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        finnKunde.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        finnSykkel.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        finnUtstyr.Show()

    End Sub
End Class

