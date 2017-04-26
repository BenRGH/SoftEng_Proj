Public Class Options
    'This code runs the options form, it allows changing of game settings.
    'Authors: UP780065

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load current settings when window opened
        speedNew.Value = My.Settings.speed
        debugEnable.Checked = My.Settings.debugMode
        enemySpeedNew.Value = My.Settings.enemySpeed
        spawnRateNew.Value = My.Settings.spawnRate
    End Sub
    'Save new settings
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Save all settings to the system, runs on clicking save
        My.Settings.speed = speedNew.Value

        My.Settings.debugMode = debugEnable.Checked

        My.Settings.enemySpeed = enemySpeedNew.Value

        My.Settings.spawnRate = spawnRateNew.Value

    End Sub
    'Change text for debug checkbox
    Private Sub debugEnable_CheckedChanged(sender As Object, e As EventArgs) Handles debugEnable.CheckedChanged
        'If the debug checkbox is ticked then this code enables access to debug settings

        If debugEnable.CheckState Then
            debugEnable.Text = "Enabled"
            reloadNew.Enabled = True
            spawnRateNew.Enabled = True
        Else
            debugEnable.Text = "Disabled"
            reloadNew.Enabled = False
            spawnRateNew.Enabled = False
        End If

    End Sub
End Class