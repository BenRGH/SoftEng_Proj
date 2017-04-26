Public Class Menu
    'This is the code for the menu form, which is used to open many other forms
    'and start the game.
    'Authors: UP780065

    Public Speed As Integer = 1 'WIP

    'On load
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Play game soundtrack on run
        My.Computer.Audio.Play(My.Resources.backgroundloop, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles playBtn.Click
        'This opens the game form when the play button is clicked
        Dim gameWindow As Game
        gameWindow = New Game()
        gameWindow.Show()
        gameWindow = Nothing
    End Sub

    Private Sub highBtn_Click(sender As Object, e As EventArgs) Handles highBtn.Click
        'This opens the score form on score button click
        Dim hScores As Score
        hScores = New Score()
        hScores.Show()
        hScores = Nothing
    End Sub

    Private Sub optionBtn_Click(sender As Object, e As EventArgs) Handles optionBtn.Click
        'This opens the options form on options button click
        Dim optionWindow As Options
        optionWindow = New Options
        optionWindow.Show()
        optionWindow = Nothing
    End Sub

    Private Sub controlBtn_Click(sender As Object, e As EventArgs) Handles controlBtn.Click
        'This opens the controls form on click
        Dim controlWindow As Controls
        controlWindow = New Controls
        controlWindow.Show()
        controlWindow = Nothing
    End Sub
End Class
