<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.playBtn = New System.Windows.Forms.Button()
        Me.highBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Menu"
        '
        'playBtn
        '
        Me.playBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playBtn.Location = New System.Drawing.Point(121, 108)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(258, 42)
        Me.playBtn.TabIndex = 1
        Me.playBtn.Text = "Play"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'highBtn
        '
        Me.highBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highBtn.Location = New System.Drawing.Point(121, 166)
        Me.highBtn.Name = "highBtn"
        Me.highBtn.Size = New System.Drawing.Size(258, 42)
        Me.highBtn.TabIndex = 3
        Me.highBtn.Text = "Highscores"
        Me.highBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(121, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Options"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 316)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.highBtn)
        Me.Controls.Add(Me.playBtn)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(518, 355)
        Me.MinimumSize = New System.Drawing.Size(518, 355)
        Me.Name = "Menu"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents playBtn As System.Windows.Forms.Button
    Friend WithEvents highBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
