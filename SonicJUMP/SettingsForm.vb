Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class SettingsForm
    Private Sub SettingsForm_FormClosing1(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        If GameForm.Visible = False Then
            MenuForm.Show()
        End If
        e.Cancel = True
    End Sub

    Private Sub SettingsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            If GameForm.Visible = False Then
                MenuForm.Show()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            Me.Hide()
            If GameForm.Visible = False Then
                MenuForm.Show()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        If GameForm.Visible = False Then
            MenuForm.Show()
        End If
    End Sub

    Private Sub infoEnemy_Click(sender As Object, e As EventArgs) Handles infoEnemy.Click
        MessageBox.Show("Enables enemy(ies) that will compete with you for the rings!", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub infoDify_Click(sender As Object, e As EventArgs) Handles infoDify.Click
        MessageBox.Show(
            "Easy - Power Ups spawns often, 1 Enemy (if enabled), Enemy speed slower, Enemy -5 score" + vbNewLine +
            vbNewLine + "Hard - Power Ups spawns less often, 2 Enemies (if enabled), Enemy speed faster, Enemy -6 score" +
            vbNewLine + vbNewLine +
            "Insane - Power Ups spawns most often, 3 Enemies (if enabled), Enemy speed fastest, Enemy -5 score", "Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub infoTime_Click(sender As Object, e As EventArgs) Handles infoTime.Click
        MessageBox.Show(
            "Enables Time Challenge." + vbNewLine + "Key in values in minutes." + vbNewLine + "Minimum value: 1", "Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub infoScore_Click(sender As Object, e As EventArgs) Handles infoScore.Click
        MessageBox.Show("Enables Score Challenge." + vbNewLine + "Key in values." + vbNewLine + "Minimum value: 1",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnBackground_Click(sender As Object, e As EventArgs) Handles btnBackground.Click
        Me.Hide()
        If GameForm.Visible = False Then
            BackgroundForm.Show()
        End If
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        If Not IsNumeric(txtTime.Text) Then
            txtTime.Text = ""
            txtTime.Select(txtScore.Text.Length, 0)
        ElseIf Val(txtTime.Text) < 1 Then
            txtTime.Text = ""
            txtTime.Select(txtScore.Text.Length, 0)
        End If
    End Sub

    Private Sub txtScore_TextChanged(sender As Object, e As EventArgs) Handles txtScore.TextChanged
        If Not IsNumeric(txtScore.Text) Then
            txtScore.Text = ""
            txtScore.Select(txtScore.Text.Length, 0)
        ElseIf Val(txtScore.Text) < 1 Then
            txtScore.Text = ""
            txtScore.Select(txtScore.Text.Length, 0)
        End If
    End Sub

    Private Sub radTime_CheckedChanged_1(sender As Object, e As EventArgs) Handles radTime.CheckedChanged
        If radTime.Checked = True Then
            txtTime.Visible = True
        ElseIf radTime.Checked = False Then
            txtTime.Visible = False
        End If
    End Sub

    Private Sub radScore_CheckedChanged_1(sender As Object, e As EventArgs) Handles radScore.CheckedChanged
        If radScore.Checked = True Then
            txtScore.Visible = True
        ElseIf radScore.Checked = False Then
            txtScore.Visible = False
        End If
    End Sub
End Class