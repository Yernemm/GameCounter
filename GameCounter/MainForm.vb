Imports System.Net
Public Class MainForm
    Dim version As String = PVariables.version
    Dim ts As Integer
    Dim tm As Integer
    Dim th As Integer
    Dim cs As Integer
    Dim cm As Integer
    Dim ch As Integer
    Dim ctime As Integer = 0
    Dim ran As Boolean = False
    Dim p() As Process

    Dim pPath As String = PVariables.pPath
    Dim sPath As String = PVariables.sPath
    Public Sub time()
        checkProcess.Start()
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) _
     Handles Me.Shown

        If My.Settings.configured = False Then
            Setup.Show()
            Me.Hide()
        Else
            time()
        End If
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            OwTime.Visible = True
            OwTime.Icon = My.Resources.OwTimer

            OwTime.ShowBalloonTip(50000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles OwTime.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        OwTime.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Public Sub init()


        dispTime()

        Label3.Text = "Version: " + version
        updater()

    End Sub

    Private Sub dispTime()

        th = My.Settings.timeS \ 3600
        tm = (My.Settings.timeS Mod 3600) \ 60
        ts = (My.Settings.timeS Mod 3600) Mod 60

        ch = ctime \ 3600
        cm = (ctime Mod 3600) \ 60
        cs = (ctime Mod 3600) Mod 60

        labelTotal.Text = th & ":" & tm & ":" & ts
        labelCurrent.Text = ch & ":" & cm & ":" & cs
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cont As Integer = MsgBox("Are you sure that you want to reset your time?", MsgBoxStyle.YesNo)
        If cont = DialogResult.Yes Then
            checkProcess.Stop()
            My.Settings.Reset()
            dispTime()
            If My.Settings.configured = False Then
                Setup.Show()
                Me.Hide()
            Else
                time()
            End If
        End If
    End Sub


    Private Sub CheckIfRunning()
        'CURRENTLY OBSOLETE. MIGHT BE USEFUL IF PROGRAM MADE MORE EFFICIENT.
        p = Process.GetProcessesByName("Overwatch")
        If p.Count > 0 Then
            ' Process is running
        Else
            ' Process is not running
        End If
    End Sub

    Private Sub checkProcess_Tick(sender As Object, e As EventArgs) Handles checkProcess.Tick
        p = Process.GetProcessesByName("Overwatch")
        If p.Count > 0 Then
            ' Process is running
            If ran = False Then
                ctime = 0
            End If
            ran = True
            lbCsTxt.Text = "Current Session:"
            My.Settings.timeS = My.Settings.timeS + 1
            ctime = ctime + 1
            dispTime()
        Else
            ran = False
            lbCsTxt.Text = "Previous Session:"
            ' Process is not running
        End If
    End Sub
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub
    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Private Sub updater()
        If CheckForInternetConnection() = True Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://yernemm.xyz/programs/OwCounter/OwVersion.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()

                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = version

                If newestversion.Contains(currentversion) Then

                Else
                    MsgBox("New update detected. Please visit http://yernemm.xyz/projects/owTimer to download.")
                    checkUpdate.Stop()
                    LinkLabel1.Text = "CLICK HERE TO DOWNLOAD UPDATE"
                End If
            Catch
                MsgBox("Connection to yernemm.xyz failed. Cannot check for update.")
                checkUpdate.Stop()
            End Try


        Else
            MsgBox("You do not have an internet connection. Cannot check for update.")
            checkUpdate.Stop()
        End If
    End Sub


    Private Sub checkUpdate_Tick(sender As Object, e As EventArgs) Handles checkUpdate.Tick
        update()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://yernemm.xyz/projects/owTimer")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://yernemm.xyz/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("V1.0.0: Program counts the total time Overwatch is open and can set up any custom starting time." & vbNewLine &
               "V1.2.0: Program can now count current and previous session time. Each timing is coloured (blue and orange) and there is a changelog.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SettingsForm.Show()
    End Sub
End Class


Public Class PVariables

    Public Shared version As String = "1.3.0"
    ' Public Shared ts As Integer
    ' Public Shared tm As Integer
    ' Public Shared th As Integer
    ' Public Shared cs As Integer
    ' Public Shared cm As Integer
    ' Public Shared ch As Integer
    ' Public Shared ctime As Integer = 0
    ' Public Shared ran As Boolean = False
    ' Public Shared p() As Process

    Public Shared pPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Yernemm\Programs\OverwatchGameCounter"
    Public Shared sPath As String = pPath & "\settings"

    Public Shared updates As Boolean
    Public Shared tBack As Boolean
    Public Shared backInterval As Integer

End Class