Public Class Game
    Dim stuck As Integer = 1
    Dim Collision, NickLabelMove, Won, FloatAnim, Coin1AlreadyCalled, Coin1Collect, Coin1Collide, Coin2AlreadyCalled, Coin2Collect, Coin2Collide As Boolean
    Public MoveSpeed As Integer = 2
    Dim Coin1XDirection, Coin2XDirection, Coin2YDirection As Integer
    Dim Score As Integer = 0
    Dim FloatPosVal As Integer = 20

    'Character Images
    Dim CharLeft As Image = My.Resources.Player__Left
    Dim CharRight As Image = My.Resources.Player__Right
    Dim CharDown As Image = My.Resources.Player__Front
    Dim CharUp As Image = My.Resources.Player__BackWalk

    'Old resource references
    'Dim CharLeft As Image = Image.FromFile("C:\Users\pc\Documents\Visual Studio 2013\Projects\Maze Game Example\Maze Game Example\Resources\Player- Left.gif")
    'Dim CharRight As Image = Image.FromFile("C:\Users\pc\Documents\Visual Studio 2013\Projects\Maze Game Example\Maze Game Example\Resources\Player- Right.gif")
    'Dim CharDown As Image = Image.FromFile("C:\Users\pc\Documents\Visual Studio 2013\Projects\Maze Game Example\Maze Game Example\Resources\Player- Front.gif")
    'Dim CharUp As Image = Image.FromFile("C:\Users\pc\Documents\Visual Studio 2013\Projects\Maze Game Example\Maze Game Example\Resources\Player- Back.gif")

    'On form load
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The welcome screen is shown first

        NickLabel.Text = WelcomeScreen.PlayerNickname
        Collision = False
        Coin1Move.Enabled = True

        'Cleanup
        ScoreFloat.Visible = False
        Coin1Label.Left += 999
        Coin2Label.Left += 999
    End Sub
    'Char direction assignment - Keydowns
    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        'Tells which way the character moves
        If e.KeyCode = Keys.A Then
            Character.Image = CharLeft
            PlayerMoveLeft.Enabled = True

            PlayerMoveUp.Enabled = False
            PlayerMoveDown.Enabled = False
            PlayerMoveRight.Enabled = False

        ElseIf e.KeyCode = Keys.W Then

            Character.Image = CharUp
            PlayerMoveUp.Enabled = True

            PlayerMoveDown.Enabled = False
            PlayerMoveLeft.Enabled = False
            PlayerMoveRight.Enabled = False

        ElseIf e.KeyCode = Keys.S Then

            Character.Image = CharDown
            PlayerMoveDown.Enabled = True

            PlayerMoveUp.Enabled = False
            PlayerMoveLeft.Enabled = False
            PlayerMoveRight.Enabled = False

        ElseIf e.KeyCode = Keys.D Then

            Character.Image = CharRight
            PlayerMoveRight.Enabled = True

            PlayerMoveUp.Enabled = False
            PlayerMoveDown.Enabled = False
            PlayerMoveLeft.Enabled = False

        End If


        If e.KeyCode = Keys.A Or Keys.W Or Keys.S Or Keys.D Then
            NickLabelMove = True

            If Collision = True Then
                DebugBox.Text = "Collision"
            Else
                DebugBox.Text = ""
            End If

        End If

        'Sprint
        If e.KeyCode = Keys.Shift Then
            SprintTimer.Enabled = True
        End If
    End Sub
    'Stop the movement - KeyUps
    Private Sub Game_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp


        If e.KeyCode = Keys.W Then
            PlayerMoveUp.Enabled = False
            Character.Image = My.Resources.Player__FrontStill


        ElseIf e.KeyCode = Keys.S Then
            PlayerMoveDown.Enabled = False
            Character.Image = My.Resources.Player__FrontStill

        ElseIf e.KeyCode = Keys.A Then
            PlayerMoveLeft.Enabled = False
            Character.Image = My.Resources.Player__FrontStill


        ElseIf e.KeyCode = Keys.D Then
            PlayerMoveRight.Enabled = False
            Character.Image = My.Resources.Player__FrontStill

        End If
    End Sub
    'Movement UP steps
    Private Sub PlayerMovement_Tick(sender As Object, e As EventArgs) Handles PlayerMoveUp.Tick

        If Collision = True Then
            Character.Top += (MoveSpeed + (MoveSpeed / 2 + 2))
            PlayerMoveUp.Enabled = False
        Else
            Character.Top -= MoveSpeed

        End If

    End Sub
    'Movement DOWN steps
    Private Sub PlayerMoveDown_Tick(sender As Object, e As EventArgs) Handles PlayerMoveDown.Tick

        If Collision = True Then
            Character.Top -= (MoveSpeed + (MoveSpeed / 2 + 2))
            PlayerMoveDown.Enabled = False
        Else
            Character.Top += MoveSpeed

        End If

    End Sub
    'Movement LEFT steps
    Private Sub PlayerMoveLeft_Tick(sender As Object, e As EventArgs) Handles PlayerMoveLeft.Tick

        If Collision = True Then
            Character.Left += (MoveSpeed + (MoveSpeed / 2 + 1))
            PlayerMoveLeft.Enabled = False
        Else
            Character.Left -= MoveSpeed

        End If

    End Sub
    'Movement RIGHT steps
    Private Sub PlayerMoveRight_Tick(sender As Object, e As EventArgs) Handles PlayerMoveRight.Tick

        If Collision = True Then
            Character.Left -= (MoveSpeed + (MoveSpeed / 2 + 1))
            PlayerMoveRight.Enabled = False
        Else
            Character.Left += MoveSpeed

        End If

    End Sub
    'ChangeNickname
    Private Sub PlayerNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerNameToolStripMenuItem.Click
        'This is the player's nickname

        NameChanging.Show()

    End Sub
    'Quit
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        'Quit game button
        WelcomeScreen.Close()
        Me.Close()
        End

    End Sub
    'HelpScreen
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        HelpScreen.Show()
    End Sub
    'Is stuck?
    Private Sub StuckCheck_Tick(sender As Object, e As EventArgs) Handles StuckCheck.Tick

        For Each PictureBox In Me.Controls
            If PictureBox IsNot Character AndAlso Character.Bounds.IntersectsWith(PictureBox.Bounds) Then
                stuck = stuck + 1
            End If
        Next

        If stuck = 500 Then
            Character.Left = 367
            Character.Top = 70
            stuck = 0
            StuckNotify.Visible = True
        End If
    End Sub
    'World timer MOST USEFUL TIMER
    Public Sub WorldTimer_Tick(sender As Object, e As EventArgs) Handles WorldTimer.Tick

        For Each PictureBox In Me.Controls

            'Rapidly checks for collisions
            If PictureBox IsNot Character AndAlso Character.Bounds.IntersectsWith(PictureBox.Bounds) Then
                If Character.Bounds.IntersectsWith(PictureBox.Bounds) Then
                    Collision = True
                End If
                Exit For
            Else
                Collision = False
            End If

            'This is if the walls collide with the player, unlikely but it works
            If PictureBox.Bounds.IntersectsWith(Character.Bounds) Then
                Collision = True
            Else
                Collision = False
            End If
        Next




        'Open Door
        If Character.Bounds.IntersectsWith(FinishZone.Bounds) Or FinishZone.Bounds.IntersectsWith(Character.Bounds) Then 'Or Character.Left >= (FinishZone.Left - 50) And Character.Top >= FinishZone.Top Then
            Finished()
        End If

        If FloatAnim Then
            DebugBox.Text = FloatAnim
        End If

        ScoreBox.Text = Score.ToString

        'Coins
        If Coin1Collect Then
            If (Coin1.Left = 999) = False Then
                'Moves the coin out the way
                Coin1.Left += 999
            End If
        End If

        If Coin2Collect Then
            If (Coin2.Left = 999) = False Then
                Coin2.Left += 999
            End If
        End If

        'Confirms the coin has been touched
        If Coin1.Bounds.IntersectsWith(Character.Bounds) Or Character.Bounds.IntersectsWith(Coin1.Bounds) Then
            Coin1Collide = True
        End If

        If Coin2.Bounds.IntersectsWith(Character.Bounds) Or Character.Bounds.IntersectsWith(Coin2.Bounds) Then
            Coin2Collide = True
        End If


    End Sub
    'On contact with the FinishZone
    Private Sub Finished()
        FinishZone.Image = My.Resources.Exit_Gif
        Won = True
        DebugBox.Text = "Won"

    End Sub
    'Restart
    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        MsgBox("Do you want to relaunch the game?") 'Make this work!

    End Sub
    'Nickname follow
    Private Sub NameTag_Tick(sender As Object, e As EventArgs) Handles NameTagTimer.Tick
        If NickLabelMove = True Then
            NickLabel.Top = Character.Top - 19
            NickLabel.Left = Character.Right - (NickLabel.Width / 2 + 5)

        End If
    End Sub
    'CheatScreen
    Private Sub CheatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheatsToolStripMenuItem.Click
        Cheats.Show()
    End Sub
    'Open the Debug box
    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        DebugBox.Visible = True
    End Sub
    'Coin1's movement + reactions
    Private Sub Coin1Move_Tick(sender As Object, e As EventArgs) Handles Coin1Move.Tick
        'Original Position is 283
        'This coin only moves on 1 axis so we only add the x

        'Which way to move?
        If Coin1.Left = 283 Then
            Coin1XDirection = 4
        ElseIf Coin1.Left = 403 Then
            Coin1XDirection = -4
        End If

        'The coin moves in the direction
        Coin1.Left += Coin1XDirection

        
        'Picked up?
        If Coin1Collide Then
            If Coin1AlreadyCalled = False Then
                'Stops it moving
                Coin1XDirection = 0
                'ScoreIndi calls the score indicator that floats from the coin
                ScoreIndi(Coin1, 198)
                Score += 198
                Coin1AlreadyCalled = True
            End If
        End If

    End Sub
    'Coin2's movement + reactions
    Private Sub Coin2Move_Tick(sender As Object, e As EventArgs) Handles Coin2Move.Tick
        'Original Pos 1017, 30
        'TopRgt = 1184,30
        'BtmRgt = 1184,358
        'BtmLft = 1017,358
        'This coin moves in a circle (square path) so each point is recorded and we add both x and y

        'Which way to move?
        If Coin2.Left < 1184 And Coin2.Top = 30 Then 'TopLft to TopRgt
            Coin2XDirection = 4
            Coin2YDirection = 0
        ElseIf Coin2.Left >= 1184 And Coin2.Top < 358 Then 'TopRgt to BtmRgt
            Coin2XDirection = 0
            Coin2YDirection = 4
        ElseIf Coin2.Left > 1017 And Coin2.Top = 358 Then 'BtmRgt to BtmLft
            Coin2XDirection = -4 'Works in negatives because we *add* to the current pos
            Coin2YDirection = 0
        ElseIf Coin2.Left = 1017 And Coin2.Top > 30 Then ''BtmLft to TopLft
            Coin2XDirection = 0
            Coin2YDirection = -4
        End If

        'The coin moves in the direction
        Coin2.Left += Coin2XDirection
        Coin2.Top += Coin2YDirection

        'Picked up?
        If Coin2Collide Then
            If Coin2AlreadyCalled = False Then 'Bad var name I know
                'Stops it moving
                Coin2XDirection = 0
                Coin2YDirection = 0
                'ScoreIndi calls the score indicator that floats from the coin
                ScoreIndi(Coin2, 1000)
                Score += 1000
                Coin2AlreadyCalled = True
            End If
        End If

    End Sub
    'Used to handle the floating scores
    Private Sub ScoreIndi(From As Object, Value As Integer)
        FloatAnim = True

        'Make float invis before used!

        'Move to the object
        ScoreFloat.Top = (From.Top - 15)
        ScoreFloat.Left = (From.Left + (Value.ToString.Length / 2))

        ScoreFloat.Text = Value
        ScoreFloat.Visible = True
        ScoreFloatTimer.Enabled = True
        

    End Sub
    'Part of the ScoreIndi sub
    Private Sub ScoreFloatTimer_Tick(sender As Object, e As EventArgs) Handles ScoreFloatTimer.Tick
        'Moves up
        FloatPosVal -= 1
        'Stops the timer
        If FloatPosVal = 0 Then
            ScoreFloatTimer.Enabled = False
            ScoreFloat.Visible = False
            If Coin1Collide Then
                Coin1Collect = True
            ElseIf Coin2Collide Then
                Coin2Collect = True
            End If
        End If
        ScoreFloat.Top -= 1
    End Sub

End Class
