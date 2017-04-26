Public Class Score
    'This code runs the score form, used for loading and saving to the score database.
    'Authors: UP780065

    Private _nickname As String 'Current nickname

    'Form loaded
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This runs on form load, gets scores from db

        Me.ScoreboardTableAdapter.Fill(Me.ScoreDBDataSet.scoreboard) 'Load from db

        If My.Settings.currentScore = 0 Then
            'Player has clicked highscores from the menu, rather than end game
            saveBtn.Visible = False
            nickLbl.Visible = False
            nickBox.Visible = False
        End If
    End Sub
    'Save button is clicked
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'This runs on clicking save, adds the given nickname and score to the db

        _nickname = nickBox.Text 'Save new nickname
        Dim cScore = My.Settings.currentScore 'Get score (variable here to make it clearer)

        Me.ScoreboardTableAdapter.Insert(_nickname, cScore) 'Insert new score

        Me.ScoreboardTableAdapter.Fill(Me.ScoreDBDataSet.scoreboard) 'Update display

        saveBtn.Visible = False 'You can only add a score once per game
        nickLbl.Visible = False
        nickBox.Visible = False

    End Sub
    'Close button is clicked
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        'This closes the form on close button click
        My.Settings.currentScore = 0 'Reset the score
        Me.Close() 'Closes this form

    End Sub
End Class