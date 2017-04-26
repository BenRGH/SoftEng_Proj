Public Class Shop
    'This code runs the shop form, it loads character settings and changes them.
    'Authors: UP780065

    'Load form
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads settings on form load

        Dim score As Integer = My.Settings.currentScore 'Local variable for clarity
        moneyBox.Text = score 'Sets currency in top right

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
    'Close form
    Private Sub closeForm(sender As Object, e As EventArgs) Handles closeButton.Click
        'Closes form on button click
        Me.Close()
    End Sub
    'Armour box clicked
    Private Sub armourBox_CheckedChanged(sender As Object, e As EventArgs) Handles armourBox.CheckedChanged
        'If the armour box is clicked then this code enables the setting

        If armourBox.Checked = True Then
            'Enable armour
            My.Settings.armour = True

            'Remove currency
            My.Settings.currentScore -= 50
        End If
    End Sub
    'Lazer box clicked
    Private Sub lazerBox_CheckedChanged(sender As Object, e As EventArgs) Handles lazerBox.CheckedChanged
        'WIP enables character lazer 
        If lazerBox.Checked = True Then
            'Enable armour
            My.Settings.lazer = True

            'Remove currency
            My.Settings.currentScore -= 100
        End If
    End Sub
    'God box clicked
    Private Sub godBox_CheckedChanged(sender As Object, e As EventArgs) Handles godBox.CheckedChanged
        'WIP enables godmode

        If godBox.Checked = True Then
            'Enable armour
            My.Settings.god = True

            'Remove currency
            My.Settings.currentScore -= 500
        End If
    End Sub
End Class