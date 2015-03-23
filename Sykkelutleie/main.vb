Public Class main
    Public Shared main As New main()
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox1.SelectedIndex = 0 Then
            Logginn.Show()
            Me.Hide()
        End If
    End Sub

<<<<<<< HEAD
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        finnUtstyr.Show()
=======
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        finnKunde.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        finnSykkel.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        finnUtstyr.Show()

>>>>>>> origin/master
    End Sub
End Class

