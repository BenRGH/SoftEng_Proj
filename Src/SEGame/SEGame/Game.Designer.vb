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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nickLabel = New System.Windows.Forms.Label()
        Me.worldTimer = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_up = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_down = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_left = New System.Windows.Forms.Timer(Me.components)
        Me.charMovTimer_right = New System.Windows.Forms.Timer(Me.components)
        Me.debugBox = New System.Windows.Forms.TextBox()
        Me.character = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(769, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(688, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Pause"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nickLabel
        '
        Me.nickLabel.AutoSize = True
        Me.nickLabel.BackColor = System.Drawing.Color.LightGreen
        Me.nickLabel.ForeColor = System.Drawing.Color.SeaGreen
        Me.nickLabel.Location = New System.Drawing.Point(37, 469)
        Me.nickLabel.Name = "nickLabel"
        Me.nickLabel.Size = New System.Drawing.Size(39, 13)
        Me.nickLabel.TabIndex = 11
        Me.nickLabel.Text = "default"
        '
        'worldTimer
        '
        Me.worldTimer.Enabled = True
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
        Me.debugBox.Location = New System.Drawing.Point(321, 31)
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
        Me.character.Size = New System.Drawing.Size(50, 50)
        Me.character.TabIndex = 10
        Me.character.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(95, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(14, 447)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 621)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(856, 607)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.debugBox)
        Me.Controls.Add(Me.nickLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.KeyPreview = True
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents character As System.Windows.Forms.PictureBox
    Friend WithEvents nickLabel As System.Windows.Forms.Label
    Friend WithEvents worldTimer As System.Windows.Forms.Timer
    Friend WithEvents debugBox As System.Windows.Forms.TextBox
    Friend WithEvents charMovTimer_up As System.Windows.Forms.Timer
    Friend WithEvents charMovTimer_down As System.Windows.Forms.Timer
    Friend WithEvents charMovTimer_left As System.Windows.Forms.Timer
    Friend WithEvents charMovTimer_right As System.Windows.Forms.Timer
End Class
