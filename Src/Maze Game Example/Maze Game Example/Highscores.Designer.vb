<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highscores
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreBox = New System.Windows.Forms.ListBox()
        Me.returnBtn = New System.Windows.Forms.Button()
        Me.menuStripHighscores = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripHighscores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Top Scores:"
        '
        'ScoreBox
        '
        Me.ScoreBox.FormattingEnabled = True
        Me.ScoreBox.Location = New System.Drawing.Point(27, 62)
        Me.ScoreBox.Name = "ScoreBox"
        Me.ScoreBox.Size = New System.Drawing.Size(274, 342)
        Me.ScoreBox.TabIndex = 1
        '
        'returnBtn
        '
        Me.returnBtn.Location = New System.Drawing.Point(27, 410)
        Me.returnBtn.Name = "returnBtn"
        Me.returnBtn.Size = New System.Drawing.Size(270, 30)
        Me.returnBtn.TabIndex = 2
        Me.returnBtn.Text = "Return"
        Me.returnBtn.UseVisualStyleBackColor = True
        '
        'menuStripHighscores
        '
        Me.menuStripHighscores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.menuStripHighscores.Location = New System.Drawing.Point(0, 0)
        Me.menuStripHighscores.Name = "menuStripHighscores"
        Me.menuStripHighscores.Size = New System.Drawing.Size(325, 24)
        Me.menuStripHighscores.TabIndex = 3
        Me.menuStripHighscores.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'Highscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(325, 464)
        Me.Controls.Add(Me.menuStripHighscores)
        Me.Controls.Add(Me.returnBtn)
        Me.Controls.Add(Me.ScoreBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Highscores"
        Me.Text = "Highscores"
        Me.menuStripHighscores.ResumeLayout(False)
        Me.menuStripHighscores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ScoreBox As System.Windows.Forms.ListBox
    Friend WithEvents returnBtn As System.Windows.Forms.Button
    Friend WithEvents menuStripHighscores As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
