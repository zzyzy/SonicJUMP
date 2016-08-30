Imports System
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class MenuForm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SettingsForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(
            "Arrow Key Left - Move Left" + vbNewLine + "Arrow Key Right - Move Right" + vbNewLine + "Spacebar - Jump!",
            "How to play?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GameForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SPLASHSCREEN :P
        Me.Visible = False
        Dim s = New SplashScreen1()
        s.Show()
        Thread.Sleep(500)
        s.Close()
        s.Dispose()
        Me.Visible = True

        SettingsForm.comDify.SelectedItem = "Easy"
        SettingsForm.comMusic.SelectedItem = "Greenhill Zone"
    End Sub
End Class