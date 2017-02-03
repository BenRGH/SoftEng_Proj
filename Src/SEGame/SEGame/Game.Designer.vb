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
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.pauseBtn = New System.Windows.Forms.Button()
        Me.nickLabel = New System.Windows.Forms.Label()
        Me.worldTimer = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_up = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_down = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_left = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_right = New System.Windows.Forms.Timer(Me.components)
        Me.debugBox = New System.Windows.Forms.TextBox()
        Me.character = New System.Windows.Forms.PictureBox()
        Me.boundBoxOutline = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timeIndicator = New System.Windows.Forms.TextBox()
        Me.healthGroupBox = New System.Windows.Forms.GroupBox()
        Me.healthBar = New System.Windows.Forms.PictureBox()
        Me.damageDebug = New System.Windows.Forms.Button()
        Me.pauseScreen = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pausedLbl = New System.Windows.Forms.Label()
        Me.projectileBox = New System.Windows.Forms.PictureBox()
        Me.shootTimer = New System.Windows.Forms.Timer(Me.components)
        Me.reloadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boundBoxOutline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.healthGroupBox.SuspendLayout()
        CType(Me.healthBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pauseScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectileBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(769, 12)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 8
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'pauseBtn
        '
        Me.pauseBtn.Location = New System.Drawing.Point(688, 12)
        Me.pauseBtn.Name = "pauseBtn"
        Me.pauseBtn.Size = New System.Drawing.Size(75, 23)
        Me.pauseBtn.TabIndex = 9
        Me.pauseBtn.Text = "Pause"
        Me.pauseBtn.UseVisualStyleBackColor = True
        '
        'nickLabel
        '
        Me.nickLabel.AutoSize = True
        Me.nickLabel.BackColor = System.Drawing.Color.LightGreen
        Me.nickLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.nickLabel.Location = New System.Drawing.Point(37, 469)
        Me.nickLabel.Name = "nickLabel"
        Me.nickLabel.Size = New System.Drawing.Size(39, 13)
        Me.nickLabel.TabIndex = 11
        Me.nickLabel.Text = "default"
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
        Me.debugBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debugBox.Location = New System.Drawing.Point(275, 165)
        Me.debugBox.Name = "debugBox"
        Me.debugBox.Size = New System.Drawing.Size(284, 47)
        Me.debugBox.TabIndex = 12
        '
        'character
        '
        Me.character.BackColor = System.Drawing.Color.Transparent
        Me.character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.character.Image = Global.SEGame.My.Resources.Resources.Idle
        Me.character.Location = New System.Drawing.Point(22, 485)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(100, 100)
        Me.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.character.TabIndex = 10
        Me.character.TabStop = False
        '
        'boundBoxOutline
        '
        Me.boundBoxOutline.BackColor = System.Drawing.Color.Red
        Me.boundBoxOutline.Location = New System.Drawing.Point(12, 452)
        Me.boundBoxOutline.Name = "boundBoxOutline"
        Me.boundBoxOutline.Size = New System.Drawing.Size(13, 14)
        Me.boundBoxOutline.TabIndex = 13
        Me.boundBoxOutline.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Time:"
        '
        'timeIndicator
        '
        Me.timeIndicator.Location = New System.Drawing.Point(621, 12)
        Me.timeIndicator.Name = "timeIndicator"
        Me.timeIndicator.Size = New System.Drawing.Size(38, 20)
        Me.timeIndicator.TabIndex = 15
        '
        'healthGroupBox
        '
        Me.healthGroupBox.BackColor = System.Drawing.Color.ForestGreen
        Me.healthGroupBox.Controls.Add(Me.healthBar)
        Me.healthGroupBox.ForeColor = System.Drawing.Color.White
        Me.healthGroupBox.Location = New System.Drawing.Point(40, 13)
        Me.healthGroupBox.Name = "healthGroupBox"
        Me.healthGroupBox.Size = New System.Drawing.Size(475, 22)
        Me.healthGroupBox.TabIndex = 16
        Me.healthGroupBox.TabStop = False
        Me.healthGroupBox.Text = "Health"
        '
        'healthBar
        '
        Me.healthBar.BackColor = System.Drawing.Color.Maroon
        Me.healthBar.Location = New System.Drawing.Point(0, 12)
        Me.healthBar.Name = "healthBar"
        Me.healthBar.Size = New System.Drawing.Size(477, 10)
        Me.healthBar.TabIndex = 0
        Me.healthBar.TabStop = False
        '
        'damageDebug
        '
        Me.damageDebug.Location = New System.Drawing.Point(275, 219)
        Me.damageDebug.Name = "damageDebug"
        Me.damageDebug.Size = New System.Drawing.Size(75, 23)
        Me.damageDebug.TabIndex = 17
        Me.damageDebug.Text = "damage"
        Me.damageDebug.UseVisualStyleBackColor = True
        '
        'pauseScreen
        '
        Me.pauseScreen.BackColor = System.Drawing.Color.Lime
        Me.pauseScreen.Location = New System.Drawing.Point(356, 219)
        Me.pauseScreen.Name = "pauseScreen"
        Me.pauseScreen.Size = New System.Drawing.Size(25, 16)
        Me.pauseScreen.TabIndex = 18
        Me.pauseScreen.TabStop = False
        Me.pauseScreen.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PaleGreen
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(856, 45)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'pausedLbl
        '
        Me.pausedLbl.AutoSize = True
        Me.pausedLbl.BackColor = System.Drawing.Color.Lime
        Me.pausedLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pausedLbl.Location = New System.Drawing.Point(311, 265)
        Me.pausedLbl.Name = "pausedLbl"
        Me.pausedLbl.Size = New System.Drawing.Size(228, 55)
        Me.pausedLbl.TabIndex = 20
        Me.pausedLbl.Text = "PAUSED"
        Me.pausedLbl.Visible = False
        '
        'projectileBox
        '
        Me.projectileBox.BackColor = System.Drawing.Color.Red
        Me.projectileBox.Location = New System.Drawing.Point(387, 219)
        Me.projectileBox.Name = "projectileBox"
        Me.projectileBox.Size = New System.Drawing.Size(22, 16)
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
        Me.enemy1.BackColor = System.Drawing.Color.Fuchsia
        Me.enemy1.Location = New System.Drawing.Point(807, 532)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(49, 53)
        Me.enemy1.TabIndex = 22
        Me.enemy1.TabStop = False
        Me.enemy1.Visible = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(856, 607)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.projectileBox)
        Me.Controls.Add(Me.pausedLbl)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.pauseBtn)
        Me.Controls.Add(Me.pauseScreen)
        Me.Controls.Add(Me.damageDebug)
        Me.Controls.Add(Me.healthGroupBox)
        Me.Controls.Add(Me.timeIndicator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nickLabel)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.boundBoxOutline)
        Me.Controls.Add(Me.debugBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(872, 646)
        Me.MinimumSize = New System.Drawing.Size(872, 646)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boundBoxOutline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.healthGroupBox.ResumeLayout(False)
        CType(Me.healthBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pauseScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectileBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents pauseBtn As System.Windows.Forms.Button
    Friend WithEvents character As System.Windows.Forms.PictureBox
    Friend WithEvents nickLabel As System.Windows.Forms.Label
    Friend WithEvents worldTimer As System.Windows.Forms.Timer
    Friend WithEvents debugBox As System.Windows.Forms.TextBox
    Friend WithEvents charMovTimer_up As System.Windows.Forms.Timer
    Friend WithEvents charMovTimer_down As System.Windows.Forms.Timer
    Friend WithEvents charMovTimer_left As System.Windows.Forms.Timer
    Friend WithEvents charMovTimer_right As System.Windows.Forms.Timer
    Friend WithEvents boundBoxOutline As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timeIndicator As System.Windows.Forms.TextBox
    Friend WithEvents healthGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents healthBar As System.Windows.Forms.PictureBox
    Friend WithEvents damageDebug As System.Windows.Forms.Button
    Friend WithEvents pauseScreen As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pausedLbl As System.Windows.Forms.Label
    Friend WithEvents projectileBox As System.Windows.Forms.PictureBox
    Friend WithEvents shootTimer As System.Windows.Forms.Timer
    Friend WithEvents reloadTimer As System.Windows.Forms.Timer
    Friend WithEvents enemy1 As System.Windows.Forms.PictureBox
End Class
