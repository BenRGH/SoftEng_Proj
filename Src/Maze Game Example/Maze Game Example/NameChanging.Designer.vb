<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameChanging
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
        Me.Current = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewNick = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Current
        '
        Me.Current.Enabled = False
        Me.Current.Location = New System.Drawing.Point(44, 53)
        Me.Current.Name = "Current"
        Me.Current.Size = New System.Drawing.Size(176, 20)
        Me.Current.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Nickname:"
        '
        'NewNick
        '
        Me.NewNick.Location = New System.Drawing.Point(44, 134)
        Me.NewNick.Name = "NewNick"
        Me.NewNick.Size = New System.Drawing.Size(176, 20)
        Me.NewNick.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Nickname:"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(47, 187)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(172, 41)
        Me.ConfirmButton.TabIndex = 4
        Me.ConfirmButton.Text = "Okay"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'NameChanging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(292, 269)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NewNick)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Current)
        Me.Name = "NameChanging"
        Me.Text = "Name Changing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Current As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewNick As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
End Class
