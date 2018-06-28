Public Class SettingsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim time As Integer = Convert.ToInt32(TextBox2.Text)
        If time >= 1 And time <> vbNull Then
            PVariables.backInterval = time
            MsgBox(time)
        End If
    End Sub
End Class