Public Class Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' assign volume up/down keys
        Select Case e.KeyCode
            ' increase volume
            Case Keys.Add
                wmPlayer.settings.volume = wmPlayer.settings.volume + 2
                ' decrease volume
            Case Keys.Subtract
                If wmPlayer.settings.volume > 0 Then

                    wmPlayer.settings.volume = wmPlayer.settings.volume - 2
                    wmPlayer.settings.mute = False

                Else
                    ' mute
                    wmPlayer.settings.mute = True

                End If

            Case Keys.Divide
                wmPlayer.settings.mute = Not wmPlayer.settings.mute

        End Select
    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        ' dialog file filters
        ofdMain.Filter = "AVI Files|*.avi|MPG Files|*.mpg|MP4 Files|*.mp4|WMV Files|*.wmv|All Files|*.*"

        If ofdMain.ShowDialog = Windows.Forms.DialogResult.OK Then
            wmPlayer.URL = ofdMain.FileName
            PlayPauseToolStripMenuItem.Text = "Pause"
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' exit the application
        Application.Exit()
    End Sub

    Private Sub VolumeUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeUpToolStripMenuItem.Click
        ' increase volume
        wmPlayer.settings.volume = wmPlayer.settings.volume + 1
    End Sub

    Private Sub VolumeDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeDownToolStripMenuItem.Click
        ' decrease volume
        If wmPlayer.settings.volume > 0 Then
            wmPlayer.settings.volume = wmPlayer.settings.volume - 1
            wmPlayer.settings.volume = False
        Else
            wmPlayer.settings.mute = True
        End If
    End Sub

    Private Sub MuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MuteToolStripMenuItem.Click
        ' mute function
        wmPlayer.settings.mute = Not wmPlayer.settings.mute
    End Sub

    Private Sub PlayPauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayPauseToolStripMenuItem.Click
        ' change text name
        If PlayerToolStripMenuItem.Text = "Play" Then
            wmPlayer.Ctlcontrols.play()
            PlayPauseToolStripMenuItem.Text = "Pause"
        Else
            wmPlayer.Ctlcontrols.pause()
            PlayPauseToolStripMenuItem.Text = "Play"
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        ' stop the player
        wmPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' shows about page
        about.Show()
    End Sub
End Class
