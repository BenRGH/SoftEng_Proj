Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Imports SEGame.My.Resources

<DesignerGenerated()> _
Partial Class Controls
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 603)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "If you have any further issues contact us here: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://github.com/BenRGH/SoftE" & _
    "ng_Team10A"
        '
        'Controls
        '
        Me.BackgroundImage = Global.SEGame.My.Resources.Resources.ControlScheme
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(683, 638)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Controls"
        Me.Text = "Controls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
