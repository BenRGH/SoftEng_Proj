Public Class Options

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speedNew.Value = Game.speed
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Game.speed = speedNew.Value
    End Sub

End Class