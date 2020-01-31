Public Class Form1

    Dim silverKey = False
    Dim goldenKey = False

    Dim minutes = 0
    Dim seconds = 0

    Dim timer = 0

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        MsgBox("So, the objective of the game is to find the golden key and to escape Clappy's Hell House.")
        MsgBox("Complete a very short series of puzzles in order to escape! Good luck!")
        MsgBox("Oh yeah! You should probably try to finish the game as quick as you can.")
        TabControl1.SelectedTab = North
        gameTimer.Enabled = True

        My.Computer.Audio.Play(My.Resources.creepy, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub wind_Click(sender As Object, e As EventArgs) Handles wind.Click
        TabControl1.SelectedTab = Window
    End Sub

    Private Sub dwrTop_Click(sender As Object, e As EventArgs) Handles dwrTop.Click
        MsgBox("There appears to be nothing here...? Perhaps it is somewhere else.")
    End Sub

    Private Sub dwrBottom_Click(sender As Object, e As EventArgs) Handles dwrBottom.Click
        If silverKey = True Then
            If goldenKey = True Then
                MsgBox("You already retrieved the golden key from this.")
            Else
                goldenKey = True
                MsgBox("You got the golden key!")
            End If
        Else
            MsgBox("You don't have the silver key!")
        End If
    End Sub

    Private Sub door_Click(sender As Object, e As EventArgs) Handles door.Click
        If goldenKey = True Then
            door.Dispose()
            My.Computer.Audio.Play(My.Resources.door, AudioPlayMode.Background)
            completeGame()
        Else
            MsgBox("You don't have a golden key!")
        End If
    End Sub

    Private Sub completeGame()
        gameTimer.Enabled = False
        MsgBox("Congratulations, you escaped Clappy!")
        wait(1)
        scare()
        wait(4)
        Me.Close()
    End Sub

    Private Sub scare()
        TabControl1.SelectedTab = Screamer
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.scream, AudioPlayMode.Background)
    End Sub

    ' Credit to @Ali on StackOverFlow for the #wait function.
    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = Microsoft.VisualBasic.Timer()
        Do While Microsoft.VisualBasic.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

    Private Sub safe_Click(sender As Object, e As EventArgs) Handles safe.Click
        Dim code As String
        code = InputBox("[SAFE]: What is the code, User?")

        If code = "1376" Then
            silverKey = True
            MsgBox("[SAFE]: Access granted, you received a key.")
        Else
            MsgBox("[SAFE]: Access denied.")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        TabControl1.SelectedTab = South
    End Sub

    Private Sub updateTimer()

        timer += 1

        If seconds = 60 Then
            seconds = 0
            minutes += 1
        End If

        If timer = 95 Then
            scare()
        End If

        timer1.Text = minutes & ":" & seconds
        timer2.Text = minutes & ":" & seconds
        timer3.Text = minutes & ":" & seconds
        timer4.Text = minutes & ":" & seconds
        timer5.Text = minutes & ":" & seconds

    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        seconds += 1
        updateTimer()
    End Sub

    Private Sub N_S_Click(sender As Object, e As EventArgs) Handles N_S.Click
        TabControl1.SelectedTab = South
    End Sub

    Private Sub N_E_Click(sender As Object, e As EventArgs) Handles N_E.Click
        TabControl1.SelectedTab = East
    End Sub

    Private Sub E_N_Click(sender As Object, e As EventArgs) Handles E_N.Click
        TabControl1.SelectedTab = North
    End Sub

    Private Sub E_W_Click(sender As Object, e As EventArgs) Handles E_W.Click
        TabControl1.SelectedTab = West
    End Sub

    Private Sub W_E_Click(sender As Object, e As EventArgs) Handles W_E.Click
        TabControl1.SelectedTab = East
    End Sub

    Private Sub W_S_Click(sender As Object, e As EventArgs) Handles W_S.Click
        TabControl1.SelectedTab = South
    End Sub

    Private Sub S_W_Click(sender As Object, e As EventArgs) Handles S_W.Click
        TabControl1.SelectedTab = West
    End Sub

    Private Sub S_N_Click(sender As Object, e As EventArgs) Handles S_N.Click
        TabControl1.SelectedTab = North
    End Sub
End Class
