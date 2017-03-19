Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.playBtn = New System.Windows.Forms.Button()
        Me.highBtn = New System.Windows.Forms.Button()
        Me.optionBtn = New System.Windows.Forms.Button()
        Me.controlBtn = New System.Windows.Forms.Button()
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
        Me.highBtn.Location = New System.Drawing.Point(121, 156)
        Me.highBtn.Name = "highBtn"
        Me.highBtn.Size = New System.Drawing.Size(258, 42)
        Me.highBtn.TabIndex = 3
        Me.highBtn.Text = "Highscores"
        Me.highBtn.UseVisualStyleBackColor = True
        '
        'optionBtn
        '
        Me.optionBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionBtn.Location = New System.Drawing.Point(121, 204)
        Me.optionBtn.Name = "optionBtn"
        Me.optionBtn.Size = New System.Drawing.Size(258, 42)
        Me.optionBtn.TabIndex = 4
        Me.optionBtn.Text = "Options"
        Me.optionBtn.UseVisualStyleBackColor = True
        '
        'controlBtn
        '
        Me.controlBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controlBtn.Location = New System.Drawing.Point(121, 252)
        Me.controlBtn.Name = "controlBtn"
        Me.controlBtn.Size = New System.Drawing.Size(258, 42)
        Me.controlBtn.TabIndex = 5
        Me.controlBtn.Text = "Controls"
        Me.controlBtn.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.ClientSize = New System.Drawing.Size(502, 316)
        Me.Controls.Add(Me.controlBtn)
        Me.Controls.Add(Me.optionBtn)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents playBtn As Button
    Friend WithEvents highBtn As Button
    Friend WithEvents optionBtn As Button
    Friend WithEvents controlBtn As Button

End Class
