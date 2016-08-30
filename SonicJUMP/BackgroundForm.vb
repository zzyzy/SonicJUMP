Imports System.Windows.Forms

Public Class BackgroundForm
    Private Sub BackgroundForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        If GameForm.Visible = False Then
            SettingsForm.Show()
        End If
        e.Cancel = True
    End Sub

    Private Sub BackgroundForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            If GameForm.Visible = False Then
                SettingsForm.Show()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            Me.Hide()
            If GameForm.Visible = False Then
                SettingsForm.Show()
            End If
        End If
    End Sub
End Class
