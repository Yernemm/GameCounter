Public NotInheritable Class Setup
    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("This program aims to count the time you spend with Overwatch open. The in-game playtime only shows the time you spend in a matach of quickplay or competitive. It doesn't even consider the arcade mode. In order for this program to function properly, you must first enter your estiamted time that you had Overwatch open." & vbNewLine & vbNewLine & "In order to get your esimated playtime, add all of your playtime from quickplay, all competitive seasons, and the vs AI mode. On top of that, add how long you think you spent in the main menu, and in the arcade.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Dim tS As Integer
            Dim tM As Integer
            Dim tH As Integer

            If Integer.TryParse(Val(TextBox3.Text), tS) Then
                'successfully parsed as Integer
                If Integer.TryParse(Val(TextBox2.Text), tM) Then
                    'successfully parsed as Integer
                    If Integer.TryParse(Val(TextBox1.Text), tH) Then
                        'successfully parsed as Integer

                        tH = Val(TextBox1.Text)
                        tM = Val(TextBox2.Text)
                        tS = Val(TextBox3.Text)

                        If tS > 59 Or tM > 59 Then
                            MsgBox("Seconds and minutes should be below 60.")
                        ElseIf tS < 0 Or tM < 0 Or tH < 0 Then
                            MsgBox("Do not enter negative time.")
                        Else
                            Dim t As Integer = tS + (tM * 60) + (tH * 3600)
                            Dim cont As Integer = MsgBox("You have entered: " & tH & " hours, " & tM & " minutes, " & tS & " seconds. Do you want to continue?", MsgBoxStyle.YesNo, "Can't stop, won't stop!")
                            If cont = DialogResult.No Then
                            ElseIf DialogResult.Yes Then
                                My.Settings.timeS = t
                            My.Settings.configured = True
                            MainForm.init()
                            MainForm.time()
                            MainForm.Show()
                            Me.Close()

                            End If
                        End If


                    Else
                        'not an Integer
                        MsgBox("Please enter an integer in the hours box.")
                    End If
                Else
                    'not an Integer
                    MsgBox("Please enter an integer in the minutes box.")
                End If
            Else
                'not an Integer
                MsgBox("Please enter an integer in the seconds box.")
            End If





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MainForm.Close()
    End Sub
End Class
