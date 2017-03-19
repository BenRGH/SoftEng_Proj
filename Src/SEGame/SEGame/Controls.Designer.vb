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
        Me.SuspendLayout()
        '
        'Controls
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = ControlScheme
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(683, 638)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.Name = "Controls"
        Me.Text = "Controls"
        Me.ResumeLayout(False)

    End Sub
End Class
