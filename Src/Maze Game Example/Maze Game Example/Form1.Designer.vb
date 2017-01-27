<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.MenuStripGame = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NickLabel = New System.Windows.Forms.Label()
        Me.PlayerMoveUp = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerMoveDown = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerMoveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerMoveRight = New System.Windows.Forms.Timer(Me.components)
        Me.StuckCheck = New System.Windows.Forms.Timer(Me.components)
        Me.StuckNotify = New System.Windows.Forms.Label()
        Me.WorldTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NameTagTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DebugBox = New System.Windows.Forms.TextBox()
        Me.SprintTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Coin1 = New System.Windows.Forms.PictureBox()
        Me.FinishZone = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Character = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.Coin1Move = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreFloat = New System.Windows.Forms.Label()
        Me.ScoreFloatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreBox = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Coin2 = New System.Windows.Forms.PictureBox()
        Me.Coin2Label = New System.Windows.Forms.Label()
        Me.Coin1Label = New System.Windows.Forms.Label()
        Me.Coin2Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Coin2Move = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStripGame.SuspendLayout()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripGame
        '
        Me.MenuStripGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.CheatsToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuStripGame.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripGame.Name = "MenuStripGame"
        Me.MenuStripGame.Size = New System.Drawing.Size(1222, 24)
        Me.MenuStripGame.TabIndex = 0
        Me.MenuStripGame.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.DifficultyToolStripMenuItem, Me.PlayerNameToolStripMenuItem, Me.DebugToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty"
        '
        'PlayerNameToolStripMenuItem
        '
        Me.PlayerNameToolStripMenuItem.Name = "PlayerNameToolStripMenuItem"
        Me.PlayerNameToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PlayerNameToolStripMenuItem.Text = "Change Name"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CheatsToolStripMenuItem
        '
        Me.CheatsToolStripMenuItem.Name = "CheatsToolStripMenuItem"
        Me.CheatsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.CheatsToolStripMenuItem.Text = "Cheats"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'NickLabel
        '
        Me.NickLabel.AutoSize = True
        Me.NickLabel.BackColor = System.Drawing.Color.GreenYellow
        Me.NickLabel.Location = New System.Drawing.Point(531, 0)
        Me.NickLabel.Name = "NickLabel"
        Me.NickLabel.Size = New System.Drawing.Size(0, 13)
        Me.NickLabel.TabIndex = 161
        '
        'PlayerMoveUp
        '
        Me.PlayerMoveUp.Interval = 9
        '
        'PlayerMoveDown
        '
        Me.PlayerMoveDown.Interval = 9
        '
        'PlayerMoveLeft
        '
        Me.PlayerMoveLeft.Interval = 9
        '
        'PlayerMoveRight
        '
        Me.PlayerMoveRight.Interval = 9
        '
        'StuckCheck
        '
        Me.StuckCheck.Enabled = True
        Me.StuckCheck.Interval = 10
        '
        'StuckNotify
        '
        Me.StuckNotify.AutoSize = True
        Me.StuckNotify.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StuckNotify.ForeColor = System.Drawing.Color.LawnGreen
        Me.StuckNotify.Location = New System.Drawing.Point(245, 5)
        Me.StuckNotify.Name = "StuckNotify"
        Me.StuckNotify.Size = New System.Drawing.Size(225, 19)
        Me.StuckNotify.TabIndex = 163
        Me.StuckNotify.Text = "You got stuck ya dingus!"
        Me.StuckNotify.Visible = False
        '
        'WorldTimer
        '
        Me.WorldTimer.Enabled = True
        Me.WorldTimer.Interval = 1
        '
        'NameTagTimer
        '
        Me.NameTagTimer.Enabled = True
        Me.NameTagTimer.Interval = 1
        '
        'DebugBox
        '
        Me.DebugBox.BackColor = System.Drawing.Color.LawnGreen
        Me.DebugBox.Enabled = False
        Me.DebugBox.ForeColor = System.Drawing.Color.Red
        Me.DebugBox.Location = New System.Drawing.Point(12, 27)
        Me.DebugBox.Name = "DebugBox"
        Me.DebugBox.Size = New System.Drawing.Size(100, 20)
        Me.DebugBox.TabIndex = 181
        Me.DebugBox.Visible = False
        '
        'SprintTimer
        '
        Me.SprintTimer.Interval = 10
        '
        'Coin1
        '
        Me.Coin1.Image = Global.Maze_Game_Example.My.Resources.Resources.Coin
        Me.Coin1.Location = New System.Drawing.Point(283, 314)
        Me.Coin1.Name = "Coin1"
        Me.Coin1.Size = New System.Drawing.Size(30, 30)
        Me.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin1.TabIndex = 199
        Me.Coin1.TabStop = False
        '
        'FinishZone
        '
        Me.FinishZone.Image = Global.Maze_Game_Example.My.Resources.Resources.Exit_Img0
        Me.FinishZone.Location = New System.Drawing.Point(1144, 607)
        Me.FinishZone.Name = "FinishZone"
        Me.FinishZone.Size = New System.Drawing.Size(61, 112)
        Me.FinishZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FinishZone.TabIndex = 194
        Me.FinishZone.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox13.Location = New System.Drawing.Point(1071, 155)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(113, 102)
        Me.PictureBox13.TabIndex = 193
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox12.Location = New System.Drawing.Point(216, 635)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(113, 24)
        Me.PictureBox12.TabIndex = 192
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox11.Location = New System.Drawing.Point(969, 395)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(156, 97)
        Me.PictureBox11.TabIndex = 191
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox10.Location = New System.Drawing.Point(0, 551)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(134, 180)
        Me.PictureBox10.TabIndex = 190
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox9.Location = New System.Drawing.Point(594, 369)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(191, 97)
        Me.PictureBox9.TabIndex = 189
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox8.Location = New System.Drawing.Point(0, 259)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(145, 24)
        Me.PictureBox8.TabIndex = 188
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox7.Location = New System.Drawing.Point(185, 233)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(42, 317)
        Me.PictureBox7.TabIndex = 187
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox6.Location = New System.Drawing.Point(695, 70)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(224, 99)
        Me.PictureBox6.TabIndex = 186
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox4.Location = New System.Drawing.Point(398, 369)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(93, 290)
        Me.PictureBox4.TabIndex = 184
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox3.Location = New System.Drawing.Point(594, 551)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(636, 50)
        Me.PictureBox3.TabIndex = 183
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox1.Location = New System.Drawing.Point(0, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(636, 50)
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox2.Location = New System.Drawing.Point(283, 233)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(636, 50)
        Me.PictureBox2.TabIndex = 165
        Me.PictureBox2.TabStop = False
        '
        'Character
        '
        Me.Character.Image = CType(resources.GetObject("Character.Image"), System.Drawing.Image)
        Me.Character.Location = New System.Drawing.Point(367, 70)
        Me.Character.Name = "Character"
        Me.Character.Size = New System.Drawing.Size(23, 43)
        Me.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Character.TabIndex = 162
        Me.Character.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Maze_Game_Example.My.Resources.Resources.WallSprite_Horizontal
        Me.PictureBox5.Location = New System.Drawing.Point(969, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 332)
        Me.PictureBox5.TabIndex = 185
        Me.PictureBox5.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(1230, 24)
        Me.PictureBox14.TabIndex = 195
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Location = New System.Drawing.Point(-4, 27)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(10, 710)
        Me.PictureBox15.TabIndex = 196
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Location = New System.Drawing.Point(1220, 21)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(10, 710)
        Me.PictureBox16.TabIndex = 197
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Location = New System.Drawing.Point(0, 721)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(1227, 10)
        Me.PictureBox17.TabIndex = 198
        Me.PictureBox17.TabStop = False
        '
        'Coin1Move
        '
        '
        'ScoreFloat
        '
        Me.ScoreFloat.AutoSize = True
        Me.ScoreFloat.BackColor = System.Drawing.Color.Turquoise
        Me.ScoreFloat.ForeColor = System.Drawing.Color.MediumBlue
        Me.ScoreFloat.Location = New System.Drawing.Point(531, 5)
        Me.ScoreFloat.Name = "ScoreFloat"
        Me.ScoreFloat.Size = New System.Drawing.Size(35, 13)
        Me.ScoreFloat.TabIndex = 200
        Me.ScoreFloat.Text = "TEST"
        '
        'ScoreFloatTimer
        '
        Me.ScoreFloatTimer.Interval = 10
        '
        'ScoreBox
        '
        Me.ScoreBox.AutoSize = True
        Me.ScoreBox.BackColor = System.Drawing.Color.Gold
        Me.ScoreBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreBox.Location = New System.Drawing.Point(1053, 1)
        Me.ScoreBox.Name = "ScoreBox"
        Me.ScoreBox.Size = New System.Drawing.Size(68, 18)
        Me.ScoreBox.TabIndex = 201
        Me.ScoreBox.Text = "SAMPLE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(992, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Score:"
        '
        'Coin2
        '
        Me.Coin2.Image = Global.Maze_Game_Example.My.Resources.Resources.Coin
        Me.Coin2.Location = New System.Drawing.Point(1017, 30)
        Me.Coin2.Name = "Coin2"
        Me.Coin2.Size = New System.Drawing.Size(30, 30)
        Me.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin2.TabIndex = 203
        Me.Coin2.TabStop = False
        '
        'Coin2Label
        '
        Me.Coin2Label.AutoSize = True
        Me.Coin2Label.BackColor = System.Drawing.Color.LawnGreen
        Me.Coin2Label.Location = New System.Drawing.Point(1025, 38)
        Me.Coin2Label.Name = "Coin2Label"
        Me.Coin2Label.Size = New System.Drawing.Size(13, 13)
        Me.Coin2Label.TabIndex = 204
        Me.Coin2Label.Text = "2"
        '
        'Coin1Label
        '
        Me.Coin1Label.AutoSize = True
        Me.Coin1Label.BackColor = System.Drawing.Color.LawnGreen
        Me.Coin1Label.Location = New System.Drawing.Point(291, 331)
        Me.Coin1Label.Name = "Coin1Label"
        Me.Coin1Label.Size = New System.Drawing.Size(13, 13)
        Me.Coin1Label.TabIndex = 205
        Me.Coin1Label.Text = "1"
        '
        'Coin2Timer
        '
        Me.Coin2Timer.Interval = 10
        '
        'Coin2Move
        '
        Me.Coin2Move.Enabled = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1222, 723)
        Me.Controls.Add(Me.Coin1Label)
        Me.Controls.Add(Me.Coin2Label)
        Me.Controls.Add(Me.Coin2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScoreBox)
        Me.Controls.Add(Me.ScoreFloat)
        Me.Controls.Add(Me.Coin1)
        Me.Controls.Add(Me.FinishZone)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DebugBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StuckNotify)
        Me.Controls.Add(Me.Character)
        Me.Controls.Add(Me.NickLabel)
        Me.Controls.Add(Me.MenuStripGame)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox17)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStripGame
        Me.MaximumSize = New System.Drawing.Size(1238, 762)
        Me.MinimumSize = New System.Drawing.Size(1238, 762)
        Me.Name = "Game"
        Me.Text = "Maze Game "
        Me.MenuStripGame.ResumeLayout(False)
        Me.MenuStripGame.PerformLayout()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripGame As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NickLabel As System.Windows.Forms.Label
    Friend WithEvents Character As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerMoveUp As System.Windows.Forms.Timer
    Friend WithEvents PlayerMoveDown As System.Windows.Forms.Timer
    Friend WithEvents PlayerMoveLeft As System.Windows.Forms.Timer
    Friend WithEvents PlayerMoveRight As System.Windows.Forms.Timer
    Friend WithEvents StuckCheck As System.Windows.Forms.Timer
    Friend WithEvents StuckNotify As System.Windows.Forms.Label
    Friend WithEvents WorldTimer As System.Windows.Forms.Timer
    Friend WithEvents NameTagTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DebugBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinishZone As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents SprintTimer As System.Windows.Forms.Timer
    Friend WithEvents Coin1 As System.Windows.Forms.PictureBox
    Friend WithEvents Coin1Move As System.Windows.Forms.Timer
    Friend WithEvents ScoreFloat As System.Windows.Forms.Label
    Friend WithEvents ScoreFloatTimer As System.Windows.Forms.Timer
    Friend WithEvents ScoreBox As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Coin2 As System.Windows.Forms.PictureBox
    Friend WithEvents Coin2Label As System.Windows.Forms.Label
    Friend WithEvents Coin1Label As System.Windows.Forms.Label
    Friend WithEvents Coin2Timer As System.Windows.Forms.Timer
    Friend WithEvents Coin2Move As System.Windows.Forms.Timer

End Class
