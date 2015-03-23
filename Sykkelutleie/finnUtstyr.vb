Public Class finnUtstyr

    Private Sub btnFerdig_Click(sender As Object, e As EventArgs) Handles btnFerdig.Click
        main.Show()
        'If steningene gjør at hvis noen av utstyrene ikke er valgt skrives de ikke ut i listboxen i main formen.
        If utstyr1.Value <> 0 Then
            main.ListBox1.Items.Add("Antall sykkelvesker: " & vbTab & utstyr1.Value)
        End If
        If utstyr2.Value <> 0 Then
            main.ListBox1.Items.Add("Antall barnehengere: " & utstyr2.Value)
        End If
        If utstyr3.Value <> 0 Then
            main.ListBox1.Items.Add("Antall lastehengere: " & vbTab & utstyr3.Value)
        End If
        If utstyr4.Value <> 0 Then
            main.ListBox1.Items.Add("Antall hjelmer: " & vbTab & utstyr4.Value)
        End If
        If utstyr5.Value <> 0 Then
            main.ListBox1.Items.Add("Antall beskyttelse: " & vbTab & utstyr5.Value)
        End If
        If utstyr6.Value <> 0 Then
            main.ListBox1.Items.Add("Antall barneseter: " & vbTab & utstyr6.Value)
        End If
        If utstyr7.Value <> 0 Then
            main.ListBox1.Items.Add("Antall verktøysett: " & vbTab & utstyr7.Value)
        End If
        If utstyr8.Value <> 0 Then
            main.ListBox1.Items.Add("Antall låser: " & vbTab & utstyr8.Value)
        End If
    End Sub

End Class