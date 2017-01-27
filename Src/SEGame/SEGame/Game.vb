Public Class Game
    'World
    Dim level As Integer = 0

    'Character
    Dim nick As String
    'Load window
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'level = level save?

    End Sub
    'Close game window
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
    'Keypresses
    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Check input keypress
        If e.KeyCode = Keys.W Then
            'do something
        ElseIf e.KeyCode = Keys.A Then
            'do something else
        ElseIf e.KeyCode = Keys.S Then
            'do another thing
        ElseIf e.KeyCode = Keys.D Then
            'do the last thing
        End If

    End Sub
    'Global clock
    'This clock is used to update everything without a specific timer
    Private Sub worldTimer_Tick(sender As Object, e As EventArgs) Handles worldTimer.Tick

        'Move the nickname label to follow the character
        nickLabel.Top = character.Top - 19 'top left of screen is 0,0 so we '-' to go up
        nickLabel.Left = character.Right - (nickLabel.Width / 2 + 5)


    End Sub
End Class