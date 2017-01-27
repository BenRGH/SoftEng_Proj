Public Class NameChanging

    Private Sub NameChanging_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Current.Text = WelcomeScreen.PlayerNickname

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        WelcomeScreen.PlayerNickname = NewNick.Text
        Game.NickLabel.Text = WelcomeScreen.PlayerNickname
        Me.Close()

    End Sub
End Class