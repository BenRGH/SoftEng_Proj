﻿Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Public Class Game

    'World
    Dim _level As Integer = 0 'WIP
    Dim _timeIndi As Integer = 0 'The clock in the top right
    Dim _paused As Boolean = False
    Public Ended As Boolean = False 'Used for the score form


    'Character
    Dim _nick As String
    'The area the character can move in
    ReadOnly _movBounds = New Integer(,) {{-20, 430}, {200, 430}, {-20, 605}, {200, 605}} 'Each pair is a corner of the square
    Dim _health As Double = 100
    Dim _animated As Boolean = False
    Dim _lastShotTime As Integer
    Dim _lastSpawnTime As Integer = 0
    Dim _noKilled As Integer = 0
    Dim _lvl As Integer = 0
    Dim _wearingArmour As Boolean = False

    'Load window
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'level = level save?
        worldTimer.Enabled = True
        charMovTimer_down.Enabled = True

        'This box is to show what the bounding area looks like while debugging
        boundBoxOutline.Top = _movBounds(0, 1)
        boundBoxOutline.Left = _movBounds(0, 0)
        boundBoxOutline.Height = _movBounds(2, 1) - _movBounds(0, 1) 'lowest point - highest point = height
        boundBoxOutline.Width = _movBounds(1, 0) - _movBounds(0, 0) 'rightest point - leftest point = width

        'Make the pause window the right size, by default it's small so it's not in the way
        pauseScreen.Width = 872
        pauseScreen.Height = 606
        pauseScreen.Top = 40
        pauseScreen.Left = 0
        pauseScreen.Visible = False
        pausedLbl.Visible = False

        'Enemy starting pos
        enemy1.Left = Right
        enemy1.Visible = True

        'Reset shop
        My.Settings.armour = False
        My.Settings.lazer = False
        My.Settings.god = False


    End Sub
    'Close game window
    Private Sub exitBtn_click(sender As Object, e As EventArgs) Handles exitBtn.Click
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
        'Is the game paused?
        If Not _paused Then
            'Check input keypress
            If e.KeyCode = Keys.W Then
                charMovTimer_up.Enabled = True
                charMovTimer_down.Enabled = False 'Turn off the gravity


            ElseIf e.KeyCode = Keys.A Then
                If Not _animated Then
                    character.Image = My.Resources.Backwards 'Change animation
                    _animated = True 'Stops the character image constantly being set
                End If
                charMovTimer_left.Enabled = True

            ElseIf e.KeyCode = Keys.D Then
                If Not _animated Then
                    character.Image = My.Resources.Foward 'Change animation
                    _animated = True
                End If
                charMovTimer_right.Enabled = True

            End If
        End If

    End Sub
    'Keyups - This is the second half of keypresses
    Private Sub Game_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        'Check key ups (when the key is released)
        If e.KeyCode = Keys.W Then
            charMovTimer_up.Enabled = False
            charMovTimer_down.Enabled = True 'Gravity

        ElseIf e.KeyCode = Keys.A Then
            charMovTimer_left.Enabled = False
            character.Image = My.Resources.Idle 'Change animation
            _animated = False

        ElseIf e.KeyCode = Keys.D Then
            charMovTimer_right.Enabled = False
            character.Image = My.Resources.Idle
            _animated = False

        End If

    End Sub
    'Global clock
    'This clock is used to update everything without a specific timer
    Private Sub worldTimer_Tick(sender As Object, e As EventArgs) Handles worldTimer.Tick

        'Game time indicator
        _timeIndi += 1
        Dim realTimeIndi As Integer = _timeIndi / 50
        timeIndicator.Text = realTimeIndi

        If realTimeIndi >= _lastSpawnTime + My.Settings.spawnRate And Not enemy1.Visible Then 'This allows enemies to respawn
            enemyMoveTimer.Enabled = True
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
        My.Settings.currentScore = realTimeIndi + (_noKilled * 10)

        If _noKilled >= 10 Then
            LoadLevel(_lvl + 1)
        End If

        'Shop items check
        If My.Settings.armour Then
            armourAlert.Visible = True
            If Not _wearingArmour Then
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
        If BoundCheck("up") Then
            character.Top -= My.Settings.speed
        End If

        debugBox.Text = "upping"
    End Sub
    'Movement DOWN steps
    Private Sub charMovTimer_down_Tick(sender As Object, e As EventArgs) Handles charMovTimer_down.Tick
        If BoundCheck("down") Then
            If Not _paused Then 'movement only when the game is not paused
                character.Top += My.Settings.speed
            End If
        End If

        debugBox.Text = "downing"
    End Sub
    'Movement LEFT steps
    Private Sub charMovTimer_left_Tick(sender As Object, e As EventArgs) Handles charMovTimer_left.Tick
        If BoundCheck("left") Then
            character.Left -= My.Settings.speed
        End If

        debugBox.Text = "lefting"
    End Sub
    'Movement RIGHT steps
    Private Sub charMovTimer_right_Tick(sender As Object, e As EventArgs) Handles charMovTimer_right.Tick
        If BoundCheck("right") Then
            character.Left += My.Settings.speed
        End If

        debugBox.Text = "righting"
    End Sub
    'Check if character outside allowed zone
    Private Function BoundCheck(direction As String)
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
        _noKilled = 0
        nextLevelLbl.Visible = True
        Dim i As Integer
        For i = 1 To 20
            nextLevelLbl.Top += 2 'Slide up
            Thread.Sleep(10)
        Next
        nextLevelLbl.Visible = False
        nextLevelLbl.Top -= 40 'Return to old pos

        Me.BackgroundImage = My.Resources.background2
    End Sub
    'Debug damage button
    Private Sub damageDebug_Click(sender As Object, e As EventArgs) Handles damageDebug.Click
        'Pressing this damages the character by a set number of points
        _health -= 10
    End Sub
    'Endgame
    Private Sub EndGame()
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

        'Used to aim projectiles


        'Shooting
        If _timeIndi >= _lastShotTime + My.Settings.reloadSpeed Then 'This is the reload limit
            projectileBox.Left = character.Right
            projectileBox.Top = character.Top + (character.Height / 2)
            projectileBox.Visible = True
            shootTimer.Enabled = True
            _lastShotTime = _timeIndi

            'Look like he's shooting
            character.Image = My.Resources.Shooting
            'Thread.Sleep(100)
            'character.Image = My.Resources.Idle
        End If

    End Sub
    'Projectile movement
    Private Sub shootTimer_Tick(sender As Object, e As EventArgs) Handles shootTimer.Tick
        If projectileBox.Left >= Me.Width Then
            shootTimer.Enabled = False 'Stop moving once it's further than the edge of the window
        Else
            projectileBox.Left += 20 'Change this for the speed of projectile
        End If

        If projectileBox.Bounds.IntersectsWith(enemy1.Bounds) Then '<----------Change specific enemy to enemy array!----------
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
        Dim shopWindow As Shop
        shopWindow = New Shop()

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
        enemy1.Visible = True '<-------------------------------Change this to array when implemented!

        'Movement
        If enemy1.Left <= character.Right Then
            _health -= 1
        Else
            enemy1.Left -= My.Settings.enemySpeed
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