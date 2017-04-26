Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Public Class Game
    'This form contains code for the main game window, all interactable elements
    'and player controls are here.
    'Authors:
    'UP780065

    'World vars
    Dim _lvl As Integer = 0 'WIP
    Dim _timeIndi As Integer = 0 'The clock in the top right
    Dim _paused As Boolean = False
    Public Ended As Boolean = False 'Used for the score form

    'Character vars
    Dim _nick As String 'The character nickname that's saved into the db
    'The area the character can move in
    ReadOnly _movBounds = New Integer(,) {{-20, 430}, {200, 430}, {-20, 605}, {200, 605}} 'Each pair is a corner of the square
    Dim _health As Double = 100
    Dim _animated As Boolean = False 'Whether the character is currently animated
    Dim _lastShotTime As Integer 'Used for delaying shots
    Dim _lastSpawnTime As Integer = 0 'Used to delay enemy spawns
    Dim _noKilled As Integer = 0 'Number of killed enemies
    Dim _wearingArmour As Boolean = False 'Applies the extra health modifier

    'Load window
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This function is run on form opening

        worldTimer.Enabled = True 'Start the world timer
        charMovTimer_down.Enabled = True 'Enable gravity

        'This box is to show what the bounding area looks like while debugging
        boundBoxOutline.Top = _movBounds(0, 1)
        boundBoxOutline.Left = _movBounds(0, 0)
        boundBoxOutline.Height = _movBounds(2, 1) - _movBounds(0, 1) 'lowest point - highest point = height
        boundBoxOutline.Width = _movBounds(1, 0) - _movBounds(0, 0) 'rightest point - leftest point = width

        'Make the pause window the right size, by default it's small so it doesn't interfere
        pauseScreen.Width = 872
        pauseScreen.Height = 606
        pauseScreen.Top = 40
        pauseScreen.Left = 0
        pauseScreen.Visible = False
        pausedLbl.Visible = False

        'Enemy starting pos
        enemy1.Left = Right 'Right is the main window's rightmost point
        enemy1.Visible = True

        'Reset shop - Disables all purchase options
        My.Settings.armour = False
        My.Settings.lazer = False
        My.Settings.god = False


    End Sub
    'Close game window
    Private Sub exitBtn_click(sender As Object, e As EventArgs) Handles exitBtn.Click
        'This function runs on form close

        Me.Close() 'Closes this form

        'Stop all timers
        worldTimer.Enabled = False
        charMovTimer_up.Enabled = False
        charMovTimer_down.Enabled = False
        charMovTimer_left.Enabled = False
        charMovTimer_right.Enabled = False

    End Sub
    'Keypresses
    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'This function runs on any keypress event

        'Is the game paused?
        If Not _paused Then
            'Check input keypress
            If e.KeyCode = Keys.W Then
                charMovTimer_up.Enabled = True 'Move char up
                charMovTimer_down.Enabled = False 'Turn off the gravity

            ElseIf e.KeyCode = Keys.A Then
                If Not _animated Then
                    character.Image = My.Resources.Backwards 'Change animation
                    _animated = True 'Stops the character image constantly being set
                End If
                charMovTimer_left.Enabled = True 'Move char left

            ElseIf e.KeyCode = Keys.D Then
                If Not _animated Then
                    character.Image = My.Resources.Foward 'Change animation
                    _animated = True 'See above
                End If
                charMovTimer_right.Enabled = True 'Move char right

            End If
        End If
    End Sub
    'Keyups
    Private Sub Game_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'This function runs on any key release/up event

        'Check key ups (when the key is released)
        If e.KeyCode = Keys.W Then
            charMovTimer_up.Enabled = False 'Stop moving char up
            charMovTimer_down.Enabled = True 'Gravity enabled again

        ElseIf e.KeyCode = Keys.A Then
            charMovTimer_left.Enabled = False 'Stop moving char left
            character.Image = My.Resources.Idle 'Change animation
            _animated = False

        ElseIf e.KeyCode = Keys.D Then
            charMovTimer_right.Enabled = False 'Stop moving char right
            character.Image = My.Resources.Idle
            _animated = False

        End If

    End Sub
    'Global clock
    Private Sub worldTimer_Tick(sender As Object, e As EventArgs) Handles worldTimer.Tick
        'This timer is used to update everything without a specific timer, runs on every tick

        'Game time indicator
        _timeIndi += 1
        Dim realTimeIndi As Integer = _timeIndi / 50 'Remove decimals
        timeIndicator.Text = realTimeIndi 'realTimeIndi is only used in this sub

        If realTimeIndi >= _lastSpawnTime + My.Settings.spawnRate And Not enemy1.Visible Then 'This allows enemies to respawn
            enemyMoveTimer.Enabled = True 'Start moving the enemy left
            _lastSpawnTime = realTimeIndi
        End If

        'Health bar update
        healthBar.Width = 477 * (_health / 100) 'Sets the healthbar width to the health percentage of the default width 477

        'Test for end game
        If _health <= 0 Then
            EndGame()
            _paused = True
        End If

        'Score update
        My.Settings.currentScore = realTimeIndi + (_noKilled * 10) 'Score is time + (killed * 10)

        If _noKilled >= 10 Then
            LoadLevel(_lvl + 1) 'Change level after a 10 kills
        End If

        'Shop items check
        If My.Settings.armour Then
            armourAlert.Visible = True 'Tell player armour is on
            If Not _wearingArmour Then 'We don't want multiple layers of armour
                _health += 20 'Increase health due to armour
            End If
            _wearingArmour = True
        End If


        'Debug only
        debugBox.Visible = My.Settings.debugMode
        boundBoxOutline.Visible = My.Settings.debugMode
        damageDebug.Visible = My.Settings.debugMode
        healthLabel.Visible = My.Settings.debugMode
        healthBox.Visible = My.Settings.debugMode
        healthBox.Text = _health
    End Sub
    'Movement UP steps
    Private Sub charMovTimer_up_Tick(sender As Object, e As EventArgs) Handles charMovTimer_up.Tick
        'Moves character up, runs on tick

        If BoundCheck("up") Then 'Check if in bounds
            character.Top -= My.Settings.speed
        End If

        debugBox.Text = "upping"
    End Sub
    'Movement DOWN steps
    Private Sub charMovTimer_down_Tick(sender As Object, e As EventArgs) Handles charMovTimer_down.Tick
        'Moves character down as gravity, runs on tick

        If BoundCheck("down") Then 'Checks char is in bounds
            If Not _paused Then 'movement only when the game is not paused
                character.Top += My.Settings.speed
            End If
        End If

        debugBox.Text = "downing"
    End Sub
    'Movement LEFT steps
    Private Sub charMovTimer_left_Tick(sender As Object, e As EventArgs) Handles charMovTimer_left.Tick
        'Moves character left, runs on tick

        If BoundCheck("left") Then 'Checks char is within bounds
            character.Left -= My.Settings.speed
        End If

        debugBox.Text = "lefting"
    End Sub
    'Movement RIGHT steps
    Private Sub charMovTimer_right_Tick(sender As Object, e As EventArgs) Handles charMovTimer_right.Tick
        'Moves character right, runs on tick

        If BoundCheck("right") Then 'Checks char is within bounds
            character.Left += My.Settings.speed
        End If

        debugBox.Text = "righting"
    End Sub
    'Bounds Check
    Private Function BoundCheck(direction As String)
        'This takes a direction as a string input and returns true or false depending
        'on whether the character can move in that direction without passing 
        'through the set bounds

        Dim canMove As Boolean = False

        If direction = "up" Then
            If character.Top > _movBounds(0, 1) Then
                canMove = True

            End If

        ElseIf direction = "down" Then
            If character.Bottom < _movBounds(2, 1) Then
                canMove = True

            End If

        ElseIf direction = "left" Then
            If character.Left > _movBounds(0, 0) Then
                canMove = True

            End If

        ElseIf direction = "right" Then
            If character.Right < _movBounds(3, 0) Then
                canMove = True

            End If

        End If

        Return canMove

    End Function
    'Level load
    Private Sub LoadLevel(level As Integer)
        'Loads the level by given int, currently only 2 levels

        _noKilled = 0 'Reset kill count

        'Below makes a small level up notification slide up the screen then hide
        nextLevelLbl.Visible = True
        Dim i As Integer
        For i = 1 To 20
            nextLevelLbl.Top += 2 'Slide up
            Thread.Sleep(10)
        Next
        nextLevelLbl.Visible = False
        nextLevelLbl.Top -= 40 'Return to old pos

        Me.BackgroundImage = My.Resources.background2 'Loads the second level image into the background
    End Sub
    'Debug damage button
    Private Sub damageDebug_Click(sender As Object, e As EventArgs) Handles damageDebug.Click
        'Pressing this damages the character by a set number of points
        _health -= 10
    End Sub
    'Endgame
    Private Sub EndGame()
        'This runs on game completion, it opens the highscore form and closes the game

        Ended = True

        'Open highscores window
        Dim hScores As Score
        hScores = New Score()
        hScores.Show()
        hScores = Nothing

        Me.Close() 'Close this window - Game over

    End Sub
    'Shoot - mouse click
    Private Sub Game_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        debugBox.Text = GetMousePos().ToString()

        'Find the pos along a line between two points
        '<------------------------DO THIS------------------------------->
        'x = (x0 + x1) / 2
        'y = (y0 + y1) / 2

        '*0.1 ...1 instead of / 2

        'Used to aim projectiles, WIP


        'Shooting
        If _timeIndi >= _lastShotTime + My.Settings.reloadSpeed Then 'This is the reload delay
            projectileBox.Left = character.Right 'Position bullet
            projectileBox.Top = character.Top + (character.Height / 2) 'Pos bullet
            projectileBox.Visible = True
            shootTimer.Enabled = True 'Start movement of bullet
            _lastShotTime = _timeIndi 'Used for delay

            'Look like he's shooting
            character.Image = My.Resources.Shooting
            'Thread.Sleep(100)
            'character.Image = My.Resources.Idle
        End If

    End Sub
    'Projectile movement
    Private Sub shootTimer_Tick(sender As Object, e As EventArgs) Handles shootTimer.Tick
        'This is run on tick and moves the player's projectile

        If projectileBox.Left >= Me.Width Then
            shootTimer.Enabled = False 'Stop moving once it's further than the edge of the form
        Else
            projectileBox.Left += 20 'Change this for the speed of projectile
        End If

        'Below runs if the bounds of the bullet are found to be inside the bounds of the enemy
        If projectileBox.Bounds.IntersectsWith(enemy1.Bounds) Then
            'Kill the enemy
            enemy1.Visible = False
            enemyMoveTimer.Enabled = False
            enemy1.Left = Me.Right 'Push it back to where it started
            'Hide the projectile
            projectileBox.Visible = False

            _noKilled += 1 'Increase the number of killed enemies

        End If

    End Sub
    'Gets mouse current location - WIP
    Private Function GetMousePos() As Point
        GetMousePos = Me.PointToClient(Cursor.Position)
        Return GetMousePos
    End Function
    'Pause button
    Private Sub Pause(sender As Object, e As EventArgs) Handles pauseBtn.Click
        'This code runs on clicking the pause button, it stops all game actions until run again

        Dim shopWindow As Shop
        shopWindow = New Shop() 'Opens the shop form

        If _paused Then 'If the game is already paused then unpause
            _paused = False
            pauseBtn.Text = "Pause"
            pauseBtn.BackColor = Color.MistyRose
            pauseScreen.Visible = False 'Hide pause screen
            pausedLbl.Visible = False

            worldTimer.Enabled = True 'Resumes running major code
            enemyMoveTimer.Enabled = True

            'Hide the shop window
            shopWindow.Close()
            shopWindow = Nothing

        Else
            _paused = True 'If the game isn't paused then pause
            pauseBtn.Text = "Resume"
            pauseBtn.BackColor = Color.DarkTurquoise
            pauseScreen.Visible = True
            pausedLbl.Visible = True

            worldTimer.Enabled = False 'Stops major code
            enemyMoveTimer.Enabled = False

            'Open the shop window
            shopWindow.Show()
            shopWindow = Nothing
        End If
    End Sub
    'Enemy timer
    Private Sub enemyMoveTimer_Tick(sender As Object, e As EventArgs) Handles enemyMoveTimer.Tick
        'This runs on tick, moves the enemy towards the player

        enemy1.Visible = True '<-------------------------------Change this to array when implemented!

        'Movement
        If enemy1.Left <= character.Right Then
            _health -= 1 'Damage player on contact
        Else
            enemy1.Left -= My.Settings.enemySpeed 'Move towards player
        End If

    End Sub
End Class

'Projectile class - MAJOR WIP
Public Class Projectile
    Dim _speed As Integer
    Dim _dmg As Integer

    Sub New(ByVal speedNew As Integer, ByVal dmgNew As Integer)
        _speed = speedNew
        _dmg = dmgNew
    End Sub
End Class