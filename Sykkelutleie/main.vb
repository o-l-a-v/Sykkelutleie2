﻿Public Class main
    Public Shared main As New main()
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox1.SelectedIndex = 0 Then
            Logginn.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        finnUtstyr.Show()
    End Sub
End Class

