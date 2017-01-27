Public Class Game
    'World
    Dim level As Integer = 0
    Dim i As Integer = 0
    'Character
    Dim nick As String

    'Load window
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'level = level save?
        worldTimer.Enabled = True

    End Sub
    'Close game window
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() 'Closes this form

        'Stop and clear all timers
        worldTimer.Enabled = False
        charMovTimer_up.Enabled = False
        charMovTimer_down.Enabled = False
        charMovTimer_left.Enabled = False
        charMovTimer_right.Enabled = False

    End Sub
    'Keypresses
    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Check input keypress
        If e.KeyCode = Keys.W Then
            charMovTimer_up.Enabled = True

        ElseIf e.KeyCode = Keys.A Then
            charMovTimer_left.Enabled = True

        ElseIf e.KeyCode = Keys.S Then
            charMovTimer_down.Enabled = True

        ElseIf e.KeyCode = Keys.D Then
            charMovTimer_right.Enabled = True

        End If

    End Sub
    'Keyups - This is the second half of keypresses
    Private Sub Game_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        'Check key ups (when the key is released)
        If e.KeyCode = Keys.W Then
            charMovTimer_up.Enabled = False

        ElseIf e.KeyCode = Keys.A Then
            charMovTimer_left.Enabled = False

        ElseIf e.KeyCode = Keys.S Then
            charMovTimer_down.Enabled = False

        ElseIf e.KeyCode = Keys.D Then
            charMovTimer_right.Enabled = False

        End If

    End Sub
    'Global clock
    'This clock is used to update everything without a specific timer
    Private Sub worldTimer_Tick(sender As Object, e As EventArgs) Handles worldTimer.Tick

        'Move the nickname label to follow the character
        nickLabel.Top = character.Top - 19 'top left of screen is 0,0 so we '-' to go up
        nickLabel.Left = character.Right - (nickLabel.Width / 2 + 5)


    End Sub
    'Movement UP steps
    Private Sub charMovTimer_up_Tick(sender As Object, e As EventArgs) Handles charMovTimer_up.Tick
        'Debug stuff
        i += 1

        debugBox.Text = "upping " + i.ToString()
    End Sub
    'Movement DOWN steps
    Private Sub charMovTimer_down_Tick(sender As Object, e As EventArgs) Handles charMovTimer_down.Tick
        i += 1

        debugBox.Text = "downing " + i.ToString()
    End Sub
    'Movement LEFT steps
    Private Sub charMovTimer_left_Tick(sender As Object, e As EventArgs) Handles charMovTimer_left.Tick
        i += 1

        debugBox.Text = "lefting " + i.ToString()
    End Sub
    'Movement RIGHT steps
    Private Sub charMovTimer_right_Tick(sender As Object, e As EventArgs) Handles charMovTimer_right.Tick
        i += 1

        debugBox.Text = "righting " + i.ToString()
    End Sub
End Class