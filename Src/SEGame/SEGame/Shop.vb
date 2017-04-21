Public Class Shop
    'Close form
    Private Sub closeForm(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
    'Load form
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer = My.Settings.currentScore

        moneyBox.Text = score

        'Load already bought items
        armourBox.Checked = My.Settings.armour
        lazerBox.Checked = My.Settings.lazer
        godBox.Checked = My.Settings.god

        'Enable armour purchase
        If score >= 50 Then
            armourBox.Enabled = True
        End If

        'Enable lazer purchase
        If score >= 100 Then
            lazerBox.Enabled = True
        End If

        'Enable godmode purchase
        If score >= 500 Then
            godBox.Enabled = True
        End If


    End Sub
    'Armour box clicked
    Private Sub armourBox_CheckedChanged(sender As Object, e As EventArgs) Handles armourBox.CheckedChanged
        If armourBox.Checked = True Then
            'Enable armour
            My.Settings.armour = True

            'Remove currency
            My.Settings.currentScore -= 50
        End If
    End Sub
    'Lazer box clicked
    Private Sub lazerBox_CheckedChanged(sender As Object, e As EventArgs) Handles lazerBox.CheckedChanged
        If lazerBox.Checked = True Then
            'Enable armour
            My.Settings.lazer = True

            'Remove currency
            My.Settings.currentScore -= 100
        End If
    End Sub
    'God box clicked
    Private Sub godBox_CheckedChanged(sender As Object, e As EventArgs) Handles godBox.CheckedChanged
        If godBox.Checked = True Then
            'Enable armour
            My.Settings.god = True

            'Remove currency
            My.Settings.currentScore -= 500
        End If
    End Sub
End Class