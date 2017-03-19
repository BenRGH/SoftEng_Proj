Public Class Menu
    Public Speed As Integer = 1
    'On load
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.backgroundloop, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles playBtn.Click
        Dim gameWindow As Game
        gameWindow = New Game()
        gameWindow.Show()
        gameWindow = Nothing
    End Sub

    Private Sub highBtn_Click(sender As Object, e As EventArgs) Handles highBtn.Click
        Dim hScores As Score
        hScores = New Score()
        hScores.Show()
        hScores = Nothing
    End Sub

    Private Sub optionBtn_Click(sender As Object, e As EventArgs) Handles optionBtn.Click
        Dim optionWindow As Options
        optionWindow = New Options
        optionWindow.Show()
        optionWindow = Nothing

    End Sub

    Private Sub controlBtn_Click(sender As Object, e As EventArgs) Handles controlBtn.Click
        Dim controlWindow As Controls
        controlWindow = New Controls
        controlWindow.Show()
        controlWindow = Nothing
    End Sub
End Class
