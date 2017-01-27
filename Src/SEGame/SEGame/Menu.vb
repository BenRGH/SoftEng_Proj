Public Class Menu

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim optionWindow As Options
        optionWindow = New Options
        optionWindow.Show()
        optionWindow = Nothing

    End Sub
End Class
