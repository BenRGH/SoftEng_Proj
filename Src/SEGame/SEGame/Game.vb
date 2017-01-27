Public Class Game
    'Globals

    'World
    Dim level As Integer = 0
    Dim timeIndi As Integer = 0

    'Character
    Dim nick As String
        'The area the character can move in
    Dim movBounds = New Integer(3, 1) {{-20, 430}, {200, 430}, {-20, 605}, {200, 605}}

    'Load window
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'level = level save?
        worldTimer.Enabled = True

        'This box is to show what the bounding area looks like while debugging
        boundBoxOutline.Top = movBounds(0, 1)
        boundBoxOutline.Left = movBounds(0, 0)
        boundBoxOutline.Height = movBounds(2, 1) - movBounds(0, 1) 'lowest point - highest point = height
        boundBoxOutline.Width = movBounds(1, 0) - movBounds(0, 0) 'rightest point - leftest point = width

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
        nickLabel.Left = character.Right - (nickLabel.Width / 2) - 50

        'Game time indicator
        timeIndi += 1
        Dim realTimeIndi As Integer = timeIndi / 50
        timeIndicator.Text = realTimeIndi


        'Debug only
        debugBox.Visible = My.Settings.debugMode
        boundBoxOutline.Visible = My.Settings.debugMode
    End Sub
    'Movement UP steps
    Private Sub charMovTimer_up_Tick(sender As Object, e As EventArgs) Handles charMovTimer_up.Tick
        If boundCheck("up") Then
            character.Top -= My.Settings.speed
        End If

        debugBox.Text = "upping"
    End Sub
    'Movement DOWN steps
    Private Sub charMovTimer_down_Tick(sender As Object, e As EventArgs) Handles charMovTimer_down.Tick
        If boundCheck("down") Then
            character.Top += My.Settings.speed
        End If

        debugBox.Text = "downing"
    End Sub
    'Movement LEFT steps
    Private Sub charMovTimer_left_Tick(sender As Object, e As EventArgs) Handles charMovTimer_left.Tick
        If boundCheck("left") Then
            character.Left -= My.Settings.speed
        End If

        debugBox.Text = "lefting"
    End Sub
    'Movement RIGHT steps
    Private Sub charMovTimer_right_Tick(sender As Object, e As EventArgs) Handles charMovTimer_right.Tick
        If boundCheck("right") Then
            character.Left += My.Settings.speed
        End If

        debugBox.Text = "righting"
    End Sub
    'Check if character outside allowed zone
    Private Function boundCheck(direction As String)
        Dim canMove As Boolean = False

        If direction = "up" Then
            If character.Top > movBounds(0, 1) Then
                canMove = True

            End If

        ElseIf direction = "down" Then
            If character.Bottom < movBounds(2, 1) Then
                canMove = True

            End If

        ElseIf direction = "left" Then
            If character.Left > movBounds(0, 0) Then
                canMove = True

            End If

        ElseIf direction = "right" Then
            If character.Right < movBounds(3, 0) Then
                canMove = True

            End If

        End If

        Return canMove
    End Function
    'Level load
    Private Sub loadLevel(level As Integer)
        'do 
    End Sub
End Class