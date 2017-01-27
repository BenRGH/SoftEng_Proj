Public Class Cheats

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Change.Click
        Game.MoveSpeed = NewSpeed.Text

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class