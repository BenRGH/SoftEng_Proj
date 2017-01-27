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
        Dim charMovTimer_up As System.Windows.Forms.Timer
        Dim charMovTimer_down As System.Windows.Forms.Timer
        Dim charMovTimer_left As System.Windows.Forms.Timer
        Dim charMovTimer_right As System.Windows.Forms.Timer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.character = New System.Windows.Forms.PictureBox()
        Me.nickLabel = New System.Windows.Forms.Label()
        Me.worldTimer = New System.Windows.Forms.Timer(Me.components)
        charMovTimer_up = New System.Windows.Forms.Timer(Me.components)
        charMovTimer_down = New System.Windows.Forms.Timer(Me.components)
        charMovTimer_left = New System.Windows.Forms.Timer(Me.components)
        charMovTimer_right = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'character
        '
        Me.character.BackgroundImage = Global.SEGame.My.Resources.Resources.player
        Me.character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.character.Location = New System.Drawing.Point(22, 485)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(68, 110)
        Me.character.TabIndex = 10
        Me.character.TabStop = False
        '
        'charMovTimer_up
        '
        AddHandler charMovTimer_up.Tick, AddressOf Me.characterMov_up_Tick
        '
        'charMovTimer_down
        '
        AddHandler charMovTimer_down.Tick, AddressOf Me.characterMov_down_Tick
        '
        'charMovTimer_left
        '
        AddHandler charMovTimer_left.Tick, AddressOf Me.characterMov_left_Tick
        '
        'charMovTimer_right
        '
        AddHandler charMovTimer_right.Tick, AddressOf Me.characterMov_right_Tick
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
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(856, 607)
        Me.Controls.Add(Me.nickLabel)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
