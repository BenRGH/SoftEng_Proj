Public Class Score

    Private _nickname As String 'Current nickname

    'Form loaded
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ScoreboardTableAdapter.Fill(Me.ScoreDBDataSet.scoreboard) 'Load from db

        If My.Settings.currentScore = 0 Then
            'Player has clicked highscores from the menu, rather than end game
            saveBtn.Visible = False
            nickLbl.Visible = False
            nickBox.Visible = False
        End If
        'DO THIS!
    End Sub
    'Save button is clicked
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
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
        My.Settings.currentScore = 0 'Reset the score
        Me.Close() 'Closes this form

    End Sub
End Class