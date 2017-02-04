Public Class Options

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load current settings when window opened
        speedNew.Value = My.Settings.speed
        debugEnable.Checked = My.Settings.debugMode
        enemySpeedNew.Value = My.Settings.enemySpeed

    End Sub
    'Save new settings
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        My.Settings.speed = speedNew.Value

        My.Settings.debugMode = debugEnable.Checked

        My.Settings.enemySpeed = enemySpeedNew.Value

    End Sub
    'Change text for debug checkbox
    Private Sub debugEnable_CheckedChanged(sender As Object, e As EventArgs) Handles debugEnable.CheckedChanged
        If debugEnable.CheckState Then
            debugEnable.Text = "Enabled"
            reloadNew.Enabled = True
        Else
            debugEnable.Text = "Disabled"
            reloadNew.Enabled = False
        End If

    End Sub
End Class