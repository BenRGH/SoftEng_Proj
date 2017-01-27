Public Class WelcomeScreen
    Public PlayerNickname As String


    Private Sub playGameBtn_Click(sender As Object, e As EventArgs) Handles playGameBtn.Click

        PlayerNickname = nicknameIn.Text

        Game.Show()
        Me.Hide()

    End Sub

    Private Sub PlayerNameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NameChanging.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        'Leave the game
        Me.Close()
        End
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        HelpScreen.Show()

    End Sub

    Private Sub WelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Normally would use My.Resources.'Filename' but VB likes bugs
        My.Computer.Audio.Play(My.Resources.wil8, AudioPlayMode.BackgroundLoop)
        '"C:\Users\pc\Documents\Visual Studio 2013\Projects\Maze Game Example\Maze Game Example\Resources\what is love 8 bit.wav"
    End Sub
End Class