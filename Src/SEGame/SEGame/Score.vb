Public Class Score

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() 'Closes this form

        If Game.ended Then
            Game.Close()

        End If
    End Sub
End Class