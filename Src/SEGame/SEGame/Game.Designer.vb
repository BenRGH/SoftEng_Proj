Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Game
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
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
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Game))
        Me.exitBtn = New Button()
        Me.pauseBtn = New Button()
        Me.worldTimer = New Timer(Me.components)
        Me.charMovTimer_up = New Timer(Me.components)
        Me.charMovTimer_down = New Timer(Me.components)
        Me.charMovTimer_left = New Timer(Me.components)
        Me.charMovTimer_right = New Timer(Me.components)
        Me.debugBox = New TextBox()
        Me.character = New PictureBox()
        Me.boundBoxOutline = New PictureBox()
        Me.Label1 = New Label()
        Me.timeIndicator = New TextBox()
        Me.healthGroupBox = New GroupBox()
        Me.healthBar = New PictureBox()
        Me.damageDebug = New Button()
        Me.pauseScreen = New PictureBox()
        Me.PictureBox1 = New PictureBox()
        Me.pausedLbl = New Label()
        Me.projectileBox = New PictureBox()
        Me.shootTimer = New Timer(Me.components)
        Me.reloadTimer = New Timer(Me.components)
        Me.enemy1 = New PictureBox()
        Me.enemyMoveTimer = New Timer(Me.components)
        Me.nextLevelLbl = New Label()
        CType(Me.character, ISupportInitialize).BeginInit()
        CType(Me.boundBoxOutline, ISupportInitialize).BeginInit()
        Me.healthGroupBox.SuspendLayout()
        CType(Me.healthBar, ISupportInitialize).BeginInit()
        CType(Me.pauseScreen, ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        CType(Me.projectileBox, ISupportInitialize).BeginInit()
        CType(Me.enemy1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.Location = New Point(769, 12)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New Size(75, 23)
        Me.exitBtn.TabIndex = 8
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'pauseBtn
        '
        Me.pauseBtn.Location = New Point(688, 12)
        Me.pauseBtn.Name = "pauseBtn"
        Me.pauseBtn.Size = New Size(75, 23)
        Me.pauseBtn.TabIndex = 9
        Me.pauseBtn.Text = "Pause"
        Me.pauseBtn.UseVisualStyleBackColor = True
        '
        'worldTimer
        '
        Me.worldTimer.Enabled = True
        Me.worldTimer.Interval = 10
        '
        'charMovTimer_up
        '
        Me.charMovTimer_up.Interval = 10
        '
        'charMovTimer_down
        '
        Me.charMovTimer_down.Interval = 10
        '
        'charMovTimer_left
        '
        Me.charMovTimer_left.Interval = 10
        '
        'charMovTimer_right
        '
        Me.charMovTimer_right.Interval = 10
        '
        'debugBox
        '
        Me.debugBox.Font = New Font("Microsoft Sans Serif", 26.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.debugBox.Location = New Point(275, 165)
        Me.debugBox.Name = "debugBox"
        Me.debugBox.Size = New Size(284, 47)
        Me.debugBox.TabIndex = 12
        '
        'character
        '
        Me.character.BackColor = Color.Transparent
        Me.character.BackgroundImageLayout = ImageLayout.None
        Me.character.Image = My.Resources.Resources.Idle
        Me.character.Location = New Point(22, 485)
        Me.character.Name = "character"
        Me.character.Size = New Size(100, 100)
        Me.character.SizeMode = PictureBoxSizeMode.AutoSize
        Me.character.TabIndex = 10
        Me.character.TabStop = False
        '
        'boundBoxOutline
        '
        Me.boundBoxOutline.BackColor = Color.Red
        Me.boundBoxOutline.Location = New Point(12, 452)
        Me.boundBoxOutline.Name = "boundBoxOutline"
        Me.boundBoxOutline.Size = New Size(13, 14)
        Me.boundBoxOutline.TabIndex = 13
        Me.boundBoxOutline.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = Color.ForestGreen
        Me.Label1.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New Point(568, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(47, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Time:"
        '
        'timeIndicator
        '
        Me.timeIndicator.Location = New Point(621, 12)
        Me.timeIndicator.Name = "timeIndicator"
        Me.timeIndicator.Size = New Size(38, 20)
        Me.timeIndicator.TabIndex = 15
        '
        'healthGroupBox
        '
        Me.healthGroupBox.BackColor = Color.ForestGreen
        Me.healthGroupBox.Controls.Add(Me.healthBar)
        Me.healthGroupBox.ForeColor = Color.White
        Me.healthGroupBox.Location = New Point(40, 13)
        Me.healthGroupBox.Name = "healthGroupBox"
        Me.healthGroupBox.Size = New Size(475, 22)
        Me.healthGroupBox.TabIndex = 16
        Me.healthGroupBox.TabStop = False
        Me.healthGroupBox.Text = "Health"
        '
        'healthBar
        '
        Me.healthBar.BackColor = Color.Maroon
        Me.healthBar.Location = New Point(0, 12)
        Me.healthBar.Name = "healthBar"
        Me.healthBar.Size = New Size(477, 10)
        Me.healthBar.TabIndex = 0
        Me.healthBar.TabStop = False
        '
        'damageDebug
        '
        Me.damageDebug.Location = New Point(275, 219)
        Me.damageDebug.Name = "damageDebug"
        Me.damageDebug.Size = New Size(75, 23)
        Me.damageDebug.TabIndex = 17
        Me.damageDebug.Text = "damage"
        Me.damageDebug.UseVisualStyleBackColor = True
        '
        'pauseScreen
        '
        Me.pauseScreen.BackColor = Color.Lime
        Me.pauseScreen.Location = New Point(356, 219)
        Me.pauseScreen.Name = "pauseScreen"
        Me.pauseScreen.Size = New Size(25, 16)
        Me.pauseScreen.TabIndex = 18
        Me.pauseScreen.TabStop = False
        Me.pauseScreen.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = Color.PaleGreen
        Me.PictureBox1.Location = New Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(856, 45)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'pausedLbl
        '
        Me.pausedLbl.AutoSize = True
        Me.pausedLbl.BackColor = Color.Lime
        Me.pausedLbl.Font = New Font("Microsoft Sans Serif", 36.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.pausedLbl.Location = New Point(311, 265)
        Me.pausedLbl.Name = "pausedLbl"
        Me.pausedLbl.Size = New Size(228, 55)
        Me.pausedLbl.TabIndex = 20
        Me.pausedLbl.Text = "PAUSED"
        Me.pausedLbl.Visible = False
        '
        'projectileBox
        '
        Me.projectileBox.BackColor = Color.Transparent
        Me.projectileBox.BackgroundImage = CType(resources.GetObject("projectileBox.BackgroundImage"), Image)
        Me.projectileBox.BackgroundImageLayout = ImageLayout.Stretch
        Me.projectileBox.Location = New Point(387, 219)
        Me.projectileBox.Name = "projectileBox"
        Me.projectileBox.Size = New Size(26, 16)
        Me.projectileBox.TabIndex = 21
        Me.projectileBox.TabStop = False
        Me.projectileBox.Visible = False
        '
        'shootTimer
        '
        Me.shootTimer.Interval = 1
        '
        'reloadTimer
        '
        Me.reloadTimer.Interval = 1
        '
        'enemy1
        '
        Me.enemy1.BackColor = Color.Transparent
        Me.enemy1.Image = My.Resources.Resources.Skeleton
        Me.enemy1.Location = New Point(769, 509)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New Size(87, 100)
        Me.enemy1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.enemy1.TabIndex = 22
        Me.enemy1.TabStop = False
        '
        'enemyMoveTimer
        '
        Me.enemyMoveTimer.Enabled = True
        '
        'nextLevelLbl
        '
        Me.nextLevelLbl.AutoSize = True
        Me.nextLevelLbl.BackColor = Color.Aquamarine
        Me.nextLevelLbl.Font = New Font("Microsoft Sans Serif", 36.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.nextLevelLbl.Location = New Point(265, 334)
        Me.nextLevelLbl.Name = "nextLevelLbl"
        Me.nextLevelLbl.Size = New Size(325, 55)
        Me.nextLevelLbl.TabIndex = 23
        Me.nextLevelLbl.Text = "NEXT LEVEL"
        Me.nextLevelLbl.Visible = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(856, 607)
        Me.Controls.Add(Me.nextLevelLbl)
        Me.Controls.Add(Me.pauseScreen)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.projectileBox)
        Me.Controls.Add(Me.pausedLbl)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.pauseBtn)
        Me.Controls.Add(Me.damageDebug)
        Me.Controls.Add(Me.healthGroupBox)
        Me.Controls.Add(Me.timeIndicator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.boundBoxOutline)
        Me.Controls.Add(Me.debugBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximumSize = New Size(872, 646)
        Me.MinimumSize = New Size(872, 646)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.character, ISupportInitialize).EndInit()
        CType(Me.boundBoxOutline, ISupportInitialize).EndInit()
        Me.healthGroupBox.ResumeLayout(False)
        CType(Me.healthBar, ISupportInitialize).EndInit()
        CType(Me.pauseScreen, ISupportInitialize).EndInit()
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        CType(Me.projectileBox, ISupportInitialize).EndInit()
        CType(Me.enemy1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitBtn As Button
    Friend WithEvents pauseBtn As Button
    Friend WithEvents character As PictureBox
    Friend WithEvents worldTimer As Timer
    Friend WithEvents debugBox As TextBox
    Friend WithEvents charMovTimer_up As Timer
    Friend WithEvents charMovTimer_down As Timer
    Friend WithEvents charMovTimer_left As Timer
    Friend WithEvents charMovTimer_right As Timer
    Friend WithEvents boundBoxOutline As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents timeIndicator As TextBox
    Friend WithEvents healthGroupBox As GroupBox
    Friend WithEvents healthBar As PictureBox
    Friend WithEvents damageDebug As Button
    Friend WithEvents pauseScreen As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pausedLbl As Label
    Friend WithEvents projectileBox As PictureBox
    Friend WithEvents shootTimer As Timer
    Friend WithEvents reloadTimer As Timer
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents enemyMoveTimer As Timer
    Friend WithEvents nextLevelLbl As Label
End Class
