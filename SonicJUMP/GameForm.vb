Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.DirectX.AudioVideoPlayback
Imports Microsoft.VisualBasic

Public Class GameForm
    ReadOnly sonic_run_right As Image = My.Resources.sonic_run_right
    ReadOnly sonic_run_left As Image = My.Resources.sonic_run_left
    ReadOnly sonic_sprint_right As Image = My.Resources.sonic_sprint_right
    ReadOnly sonic_sprint_left As Image = My.Resources.sonic_sprint_left
    ReadOnly sonic_stand_right As Image = My.Resources.sonic_stand_right
    ReadOnly sonic_stand_left As Image = My.Resources.sonic_stand_left
    ReadOnly sonic_jump_right As Image = My.Resources.sonic_jump_right
    ReadOnly sonic_jump_left As Image = My.Resources.sonic_jump_left
    Dim PressedLeft As Boolean
    Dim PressedRight As Boolean
    Dim PressedJump As Boolean
    Dim GetRing As Boolean
    Dim GetSpd As Boolean
    Dim GetFreeze As Boolean
    Dim GetBomb As Boolean
    Dim SpeedUp As Boolean = False
    Dim Freezed As Boolean = False
    Dim Speed As Integer = 5
    Dim Score As Integer
    Dim FWidth As Integer
    Dim FHeight As Integer
    Dim Temp1 As Integer
    Dim Seconds As Double = 0
    Dim Minutes As Double = 0
    ReadOnly Ring(15) As PictureBox
    ReadOnly Enemy(3) As PictureBox
    ReadOnly Lightning(1) As PictureBox
    ReadOnly Freeze(1) As PictureBox
    ReadOnly Bomb(3) As PictureBox
    ReadOnly mp3jump As Audio = New Audio("Resources\Jump.mp3")
    ReadOnly mp3ring As Audio = New Audio("Resources\Ring.mp3")
    ReadOnly mp3ringsout As Audio = New Audio("Resources\RingsOut.mp3")
    ReadOnly mp3bomb As Audio = New Audio("Resources\Bomb.mp3")
    ReadOnly mp3freeze As Audio = New Audio("Resources\Freeze.mp3")
    ReadOnly mp3laugh As Audio = New Audio("Resources\Laugh.mp3")
    ReadOnly mp3spdup As Audio = New Audio("Resources\SpeedUp.mp3")
    ReadOnly midGreen As Audio = New Audio("Resources\Greenhill Zone.mid")
    ReadOnly midMarb As Audio = New Audio("Resources\Marble Zone.mid")
    ReadOnly midStar As Audio = New Audio("Resources\Starlight Zone.mid")

    'Exit Game Form

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GameForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mp3jump.Dispose()
        mp3ring.Dispose()
        mp3ringsout.Dispose()
        mp3bomb.Dispose()
        mp3freeze.Dispose()
        mp3laugh.Dispose()
        mp3spdup.Dispose()

        midGreen.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
        midGreen.Dispose()
        midMarb.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
        midMarb.Dispose()
        midStar.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
        midStar.Dispose()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MenuForm.Show()
    End Sub

    'Open Settings Form

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles SettingsToolStripMenuItem.Click
        Dim result = MessageBox.Show("This will quit the game. Continue?", "Warning", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
            SettingsForm.Show()
            MenuForm.Hide()
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    'Initialization

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization
        Me.DoubleBuffered = False
        If BackgroundForm.chkSpring.Checked = True Then
            Background.Image = My.Resources.background1
        ElseIf BackgroundForm.chkIce.Checked = True Then
            Background.Image = My.Resources.background2
        End If
        lblMins.Text = ""
        SonicPB.Parent = Background
        SonicPB.Tag = "stand right"
        Temp1 = SonicPB.Top
        FHeight = Me.Height
        FWidth = Me.Width

        'Timers

        CollisionCtrl.Start()
        JumpCtrl.Start()
        KeyCtrl.Start()
        SoundCtrl.Start()
        TimeLapse.Start()

        'Create PictureBoxes

        Create(15, Ring, My.Resources.ring, 35, 35, PictureBoxSizeMode.CenterImage)
        Create(1, Lightning, My.Resources.speedup, 40, 40, PictureBoxSizeMode.StretchImage)
        Lightning(1).SetBounds(-100, -100, 40, 40)
        Create(1, Freeze, My.Resources.freeze, 40, 40, PictureBoxSizeMode.StretchImage)
        Freeze(1).SetBounds(-100, -100, 40, 40)

        'Settings

        If SettingsForm.chkEnemies.Checked = True Then
            Create(3, Bomb, My.Resources.bomb, 35, 35, PictureBoxSizeMode.StretchImage)
            Bomb(1).SetBounds(-100, -100, 35, 35)
            Bomb(2).SetBounds(-100, -100, 35, 35)
            Bomb(3).SetBounds(-100, -100, 35, 35)
            If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
                Create(1, Enemy, My.Resources.enemy_left, 100, 90, PictureBoxSizeMode.CenterImage)
                Enemy(1).Tag = "left"
                EnemyCtrl.Start()
                lblEnemy.Text = "Enemy"
                FreezeSpwn.Interval = 15000
                EnemyAtk.Interval = 20000
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
                Create(2, Enemy, My.Resources.enemy_left, 100, 90, PictureBoxSizeMode.CenterImage)
                Enemy(1).Tag = "left"
                Enemy(2).Tag = "left"
                EnemyCtrl.Start()
                lblEnemy.Text = "Enemies"
                FreezeSpwn.Interval = 20000
                EnemyAtk.Interval = 10000
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
                Create(3, Enemy, My.Resources.enemy_left, 100, 90, PictureBoxSizeMode.CenterImage)
                Enemy(1).Tag = "left"
                Enemy(2).Tag = "left"
                Enemy(3).Tag = "left"
                EnemyCtrl.Start()
                lblEnemy.Text = "Enemies!!"
                FreezeSpwn.Interval = 12000
                EnemyAtk.Interval = 5000
            End If
            FreezeSpwn.Start() 'Freeze spawn timer
            EnemyAtk.Start()
        Else
            lblEnemy.Text = ""
            If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
                FreezeSpwn.Interval = 15000
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
                FreezeSpwn.Interval = 20000
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
                FreezeSpwn.Interval = 12000
            End If
            FreezeSpwn.Start() 'Freeze spawn timer
        End If

        If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
            lblDify.Text = "Easy"
            SpeedUPSpwn.Interval = 10000
        ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
            lblDify.Text = "Hard"
            SpeedUPSpwn.Interval = 20000
        ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
            lblDify.Text = "Insane"
            SpeedUPSpwn.Interval = 5000
        End If
        SpeedUPSpwn.Start() 'Speed Up spawn timer
    End Sub

    'Help MessageBox

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show(
            "Arrow Key Left - Move Left" + Environment.NewLine + "Arrow Key Right - Move Right\n" + Environment.NewLine +
            "Spacebar - Jump!", "How to play?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Key Down

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Right Key

        If e.KeyCode = Keys.Right Then
            'Animation
            If SpeedUp = True Then
                If Not SonicPB.Tag.ToString = "sprint right" Then
                    Speed = 10
                    SonicPB.Image = sonic_sprint_right
                    SonicPB.Tag = "sprint right"
                End If
            ElseIf SpeedUp = False Then
                If _
                    SonicPB.Tag.ToString = "stand right" Or SonicPB.Tag.ToString = "stand left" Or
                    SonicPB.Tag.ToString = "run left" Or
                    SonicPB.Tag.ToString = "jump left" Or SonicPB.Tag.ToString = "jump left run" Or
                    SonicPB.Tag.ToString = "jump left sprint" _
                    Or SonicPB.Tag.ToString = "sprint left" Then
                    SonicPB.Image = sonic_run_right
                    SonicPB.Tag = "run right"
                    Speed = 5
                End If
            End If
            'Boolean
            PressedRight = True

            'Left Key

        ElseIf e.KeyCode = Keys.Left Then
            'Animation
            If SpeedUp = True Then
                If Not SonicPB.Tag.ToString = "sprint left" Then
                    Speed = 10
                    SonicPB.Image = sonic_sprint_left
                    SonicPB.Tag = "sprint left"
                End If
            ElseIf SpeedUp = False Then
                If _
                    SonicPB.Tag.ToString = "stand left" Or SonicPB.Tag.ToString = "stand right" Or
                    SonicPB.Tag.ToString = "run right" Or
                    SonicPB.Tag.ToString = "jump right" Or SonicPB.Tag.ToString = "jump right run" Or
                    SonicPB.Tag.ToString = "jump right sprint" _
                    Or SonicPB.Tag.ToString = "sprint right" Then
                    SonicPB.Image = sonic_run_left
                    SonicPB.Tag = "run left"
                    Speed = 5
                End If
            End If
            'Boolean
            PressedLeft = True

            'Space Key

        ElseIf e.KeyCode = Keys.Space Then
            'Animation
            Select Case SonicPB.Tag.ToString
                Case "stand right"
                    SonicPB.Image = sonic_jump_right
                    SonicPB.Tag = "jump right"
                Case "stand left"
                    SonicPB.Image = sonic_jump_left
                    SonicPB.Tag = "jump left"
                Case "run right"
                    SonicPB.Image = sonic_jump_right
                    SonicPB.Tag = "jump right run"
                Case "run left"
                    SonicPB.Image = sonic_jump_left
                    SonicPB.Tag = "jump left run"
                Case "sprint right"
                    SonicPB.Image = sonic_jump_right
                    SonicPB.Tag = "jump right sprint"
                Case "sprint left"
                    SonicPB.Image = sonic_jump_left
                    SonicPB.Tag = "jump left sprint"
            End Select
            'Boolean
            PressedJump = True
        End If
    End Sub

    'Key Up

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'Right Key

        If e.KeyCode = Keys.Right Then
            'Animation
            If SonicPB.Tag.ToString = "run right" Or SonicPB.Tag.ToString = "sprint right" Or
               SonicPB.Tag.ToString = "jump right" Or SonicPB.Tag.ToString = "jump right run" _
               Or SonicPB.Tag.ToString = "jump right sprint" Then
                SonicPB.Image = sonic_stand_right
                SonicPB.Tag = "stand right"
            End If
            'Boolean
            PressedRight = False

            'Left Key

        ElseIf e.KeyCode = Keys.Left Then
            'Animation
            If SonicPB.Tag.ToString = "run left" Or SonicPB.Tag.ToString = "sprint left" Or
               SonicPB.Tag.ToString = "jump left" Or SonicPB.Tag.ToString = "jump left run" _
               Or SonicPB.Tag.ToString = "jump left sprint" Then
                SonicPB.Image = sonic_stand_left
                SonicPB.Tag = "stand left"
            End If
            'Boolean
            PressedLeft = False
        End If

        'Space Key

        If e.KeyCode = Keys.Space Then
            'Animation
            Select Case SonicPB.Tag.ToString
                Case "jump right"
                    SonicPB.Image = sonic_stand_right
                    SonicPB.Tag = "stand right"
                Case "jump left"
                    SonicPB.Image = sonic_stand_left
                    SonicPB.Tag = "stand left"
                Case "jump right run"
                    SonicPB.Image = sonic_run_right
                    SonicPB.Tag = "run right"
                Case "jump left run"
                    SonicPB.Image = sonic_run_left
                    SonicPB.Tag = "run left"
                Case "jump right sprint"
                    SonicPB.Image = sonic_sprint_right
                    SonicPB.Tag = "sprint right"
                Case "jump left sprint"
                    SonicPB.Image = sonic_sprint_left
                    SonicPB.Tag = "sprint left"
            End Select
            'Boolean
            PressedJump = False
        End If
    End Sub

    'Collision Control

    Private Sub CollisionCtrl_Tick(sender As Object, e As EventArgs) Handles CollisionCtrl.Tick
        For z = 1 To 15 'Ring Collision
            ColRing(z, SonicPB, True, 10, True)
            If SettingsForm.chkEnemies.Checked = True Then
                If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
                    ColRing(z, Enemy(1), True, -5, False)
                ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
                    For q = 1 To 2
                        ColRing(z, Enemy(q), True, -6, False)
                    Next
                ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
                    For q = 1 To 3
                        ColRing(z, Enemy(q), True, -5, False)
                    Next
                End If
            End If
        Next

        If SettingsForm.chkEnemies.Checked = True Then 'Freeze Collision
            If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
                ColFrz(SonicPB, Nothing, Freeze, 1, Enemy, 1, True, 40, 40)
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
                ColFrz(SonicPB, Nothing, Freeze, 1, Enemy, 2, True, 40, 40)
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
                ColFrz(SonicPB, Nothing, Freeze, 1, Enemy, 3, True, 40, 40)
            End If
        Else
            ColFrz(SonicPB, Nothing, Freeze, 1, Nothing, Nothing, False, 40, 40)
        End If

        ColSpd(SonicPB, Nothing, Lightning, 1, 40, 40)                       'Speed Up Collision

        If SettingsForm.chkEnemies.Checked = True Then 'Bomb Collision
            Dim a As Integer
            If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
                a = 1
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
                a = 2
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
                a = 3
            End If
            For o = 1 To a
                If SonicPB.Bounds.IntersectsWith(Bomb(o).Bounds) Then
                    GetBomb = True
                    Bomb(o).SetBounds(-100, -100, 35, 35)
                    lblscore(-50)
                End If
            Next
        End If
    End Sub

    'Key Control (Timers)

    Private Sub KeyCtrl_Tick(sender As Object, e As EventArgs) Handles KeyCtrl.Tick
        'Right Key

        If PressedRight = True Then
            If Not SonicPB.Location.X > FWidth - 80 Then
                SonicPB.Left = SonicPB.Left + (Speed)
            End If

            'Left Key

        ElseIf PressedLeft = True Then
            If Not SonicPB.Location.X <= 0 Then
                SonicPB.Left = SonicPB.Left - (Speed)
            End If
        End If
    End Sub

    'Jump Control

    Private Sub JumpCtrl_Tick(sender As Object, e As EventArgs) Handles JumpCtrl.Tick
        If PressedJump = False Then
            If Not SonicPB.Top = Temp1 Then
                SonicPB.Top = SonicPB.Top + 10
            End If
        ElseIf PressedJump = True Then
            If Not SonicPB.Location.Y <= 0 Then
                SonicPB.Top = SonicPB.Top - 10
            End If
        End If
    End Sub

    'Sound Control

    Private Sub SoundCtrl_Tick(sender As Object, e As EventArgs) Handles SoundCtrl.Tick
        If PressedJump = True Then
            mp3jump.Play()
            Dim a = 0.75
            If mp3jump.CurrentPosition >= mp3jump.Duration - a Then
                mp3jump.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
        End If

        If GetRing = True Then
            mp3ring.Play()
            Dim a = 1.75
            If mp3ring.CurrentPosition >= mp3ring.Duration - a Then
                mp3ring.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
            GetRing = False
        End If

        If GetSpd = True Then
            mp3spdup.Play()
            Dim a = 0.75
            If mp3spdup.CurrentPosition >= mp3spdup.Duration - a Then
                mp3spdup.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
            GetSpd = False
        End If

        If GetBomb = True Then
            mp3bomb.Play()
            Dim a = 2.75
            If mp3bomb.CurrentPosition >= mp3bomb.Duration - a Then
                mp3bomb.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
            mp3ringsout.Play()
            Dim b = 1.75
            If mp3ringsout.CurrentPosition >= mp3ringsout.Duration - b Then
                mp3ringsout.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
            GetBomb = False
        End If

        If GetFreeze = True Then
            mp3freeze.Play()
            Dim a = 0.75
            If mp3freeze.CurrentPosition >= mp3freeze.Duration - a Then
                mp3freeze.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
            GetFreeze = False
        End If

        If SettingsForm.comMusic.SelectedItem.ToString = "Greenhill Zone" Then
            midGreen.Play()
            If midGreen.CurrentPosition >= midGreen.Duration Then
                midGreen.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
        ElseIf SettingsForm.comMusic.SelectedItem.ToString = "Marble Zone" Then
            midMarb.Play()
            If midMarb.CurrentPosition >= midMarb.Duration Then
                midMarb.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
        ElseIf SettingsForm.comMusic.SelectedItem.ToString = "Starlight Zone" Then
            midStar.Play()
            If midStar.CurrentPosition >= midStar.Duration Then
                midStar.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If
        End If
    End Sub

    'Spawn Freeze

    Private Sub FreezeSpwn_Tick(sender As Object, e As EventArgs) Handles FreezeSpwn.Tick
        Dim x = CInt(Int(((FWidth - 100) - 0 + 1) * Rnd() + 0))
        Dim y = CInt(Int(((FHeight - 100) - 0 + 1) * Rnd() + 0))
        Freeze(1).SetBounds(x, y, 40, 40)
    End Sub

    'Freeze Duration

    Private Sub FreezeDur_Tick(sender As Object, e As EventArgs) Handles FreezeDur.Tick
        If Freezed = True Then
            Dim a As Integer
            Freezed = False
            FreezeSpwn.Start()
            FreezeDur.Stop()
            If SettingsForm.radTime.Checked = True Then
                TimeLapse.Start()
                lblSecs.ForeColor = Color.Black
                lblMins.ForeColor = Color.Black
            End If

            If SettingsForm.chkEnemies.Checked = True Then
                If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
                    a = 1
                ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
                    a = 2
                ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
                    a = 3
                End If
                For x = 1 To a
                    If Enemy(x).Tag.ToString = "left" Then
                        Enemy(x).Image = My.Resources.enemy_left
                    ElseIf Enemy(x).Tag.ToString = "right" Then
                        Enemy(x).Image = My.Resources.enemy_right
                    End If
                Next
            End If
        End If
    End Sub

    'Spawn Speed Up

    Private Sub SpeedUPSpwn_Tick(sender As Object, e As EventArgs) Handles SpeedUPSpwn.Tick
        Dim x = CInt(Int(((FWidth - 100) - 0 + 1) * Rnd() + 0))
        Dim y = CInt(Int(((FHeight - 100) - 0 + 1) * Rnd() + 0))
        Lightning(1).SetBounds(x, y, 40, 40)
    End Sub

    'Speed Up Duration

    Private Sub SpeedUPDur_Tick(sender As Object, e As EventArgs) Handles SpeedUPDur.Tick
        If SpeedUp = True Then
            SpeedUp = False
            If SonicPB.Tag.ToString = "sprint right" Then
                SonicPB.Image = sonic_run_right
                SonicPB.Tag = "run right"
                Speed = 5
            ElseIf SonicPB.Tag.ToString = "sprint left" Then
                SonicPB.Image = sonic_run_left
                SonicPB.Tag = "run left"
                Speed = 5
            End If
            SpeedUPSpwn.Start()
            SpeedUPDur.Stop()
        End If
    End Sub

    'Sub Ring Collision

    Sub ColRing(q As Integer, w As PictureBox, ByRef score As Boolean, i As Integer, ByRef sound As Boolean)
        Dim x = CInt(Int(((FWidth - 100) - 0 + 1) * Rnd() + 0))
        Dim y = CInt(Int(((FHeight - 100) - 0 + 1) * Rnd() + 0))

        If w.Bounds.IntersectsWith(Ring(q).Bounds) Then
            GetRing = sound
            Ring(q).SetBounds(x, y, 35, 35)

            If score = True Then
                lblscore(i)
            End If
        End If
    End Sub

    'Sub Speed Collision

    Sub ColSpd(obj As PictureBox, array1 As Integer, subj() As PictureBox, array2 As Integer, w As Integer, h As Integer)
        If obj.Bounds.IntersectsWith(subj(array2).Bounds) Then
            subj(array2).SetBounds(-100, -100, w, h)
            GetSpd = True
            SpeedUp = True
            If _
                obj.Tag.ToString = "run right" Or obj.Tag.ToString = "jump right run" Or
                obj.Tag.ToString = "jump right sprint" Then
                obj.Image = sonic_sprint_right
                obj.Tag = "sprint right"
                Speed = 10
            ElseIf _
                obj.Tag.ToString = "run left" Or obj.Tag.ToString = "jump left run" Or
                obj.Tag.ToString = "jump left sprint" Then
                obj.Image = sonic_sprint_left
                obj.Tag = "sprint left"
                Speed = 10
            End If
            SpeedUPDur.Start()
            SpeedUPSpwn.Stop()
        End If
    End Sub

    'Sub Freeze Collision

    Sub ColFrz(obj As PictureBox, array1 As Integer, subj() As PictureBox, array2 As Integer, target() As PictureBox _
               , count As Integer, ani As Boolean, w As Integer, h As Integer)

        If obj.Bounds.IntersectsWith(subj(array2).Bounds) Then
            subj(array2).SetBounds(-100, -100, w, h)
            GetFreeze = True
            Freezed = True
            If ani = True Then
                For a = 1 To count
                    If target(a).Tag.ToString = "left" Then
                        target(a).Image = My.Resources.enemy_left_freezed
                    ElseIf target(a).Tag.ToString = "right" Then
                        target(a).Image = My.Resources.enemy_right_freezed
                    End If
                Next
            End If

            If SettingsForm.radTime.Checked = True Then
                TimeLapse.Stop()
                lblSecs.ForeColor = Color.DodgerBlue
                lblMins.ForeColor = Color.DodgerBlue
            End If
            FreezeDur.Start()
            FreezeSpwn.Stop()
        End If
    End Sub

    'Sub Create PictureBoxes

    Sub Create(q As Integer, w() As PictureBox, e As Bitmap, r As Integer, t As Integer, d As PictureBoxSizeMode)
        For a = 1 To q
            Dim x = CInt(Int(((FWidth - 100) - 0 + 1) * Rnd() + 0))
            Dim y = CInt(Int(((FHeight - 100) - 0 + 1) * Rnd() + 0))
            w(a) = New PictureBox
            w(a).SetBounds(x, y, r, t)
            w(a).SizeMode = d
            w(a).BackColor = Color.Transparent
            w(a).Visible = True
            w(a).Image = e
            Me.Controls.Add(w(a))
            w(a).BringToFront()
            w(a).Parent = Background
        Next
    End Sub

    'Sub Label Score

    Sub lblscore(x As Integer)
        lblScored.Text = scoring(x)

        If SettingsForm.radScore.Checked = True Then
            If Convert.ToDouble(lblScored.Text) >= Convert.ToDouble(SettingsForm.txtScore.Text) Then
                TimeLapse.Stop()
                KeyCtrl.Stop()
                EnemyCtrl.Stop()
                JumpCtrl.Stop()
                CollisionCtrl.Stop()
                SoundCtrl.Stop()
                SpeedUPSpwn.Stop()
                SpeedUPDur.Stop()
                EnemyAtk.Stop()
                FreezeSpwn.Stop()
                FreezeDur.Stop()
                Dim result = MessageBox.Show("Score Challenge met!", "Score Challenge", MessageBoxButtons.OK,
                                             MessageBoxIcon.None)
                If result = DialogResult.OK Then
                    Me.Close()
                End If
            End If
        End If
    End Sub

    'Function Scoring

    Function scoring(x As Integer) As String
        Score = Score + x
        Return CStr(Score)
    End Function

    'Enemy Var

    Dim enLeftRight1 As String = "left"
    Dim enTopDown1 As String = "down"
    Dim enLeftRight2 As String = "left"
    Dim enTopDown2 As String = "down"
    Dim enLeftRight3 As String = "left"
    Dim enTopDown3 As String = "down"

    'Bounce Control

    Private Sub BounceCtrl_Tick(sender As Object, e As EventArgs) Handles EnemyCtrl.Tick
        'EnemyControl

        If Freezed = False Then
            If SettingsForm.comDify.Text = "Easy" Then
                BounceO(Enemy, 1, enLeftRight1, enTopDown1, True, My.Resources.enemy_left, My.Resources.enemy_right, 6)
            ElseIf SettingsForm.comDify.Text = "Hard" Then
                BounceO(Enemy, 1, enLeftRight1, enTopDown1, True, My.Resources.enemy_left, My.Resources.enemy_right, 7)
                BounceO(Enemy, 2, enLeftRight2, enTopDown2, True, My.Resources.enemy_left, My.Resources.enemy_right, 7)
            ElseIf SettingsForm.comDify.Text = "Insane" Then
                BounceO(Enemy, 1, enLeftRight1, enTopDown1, True, My.Resources.enemy_left, My.Resources.enemy_right, 9)
                BounceO(Enemy, 2, enLeftRight2, enTopDown2, True, My.Resources.enemy_left, My.Resources.enemy_right, 9)
                BounceO(Enemy, 3, enLeftRight3, enTopDown3, True, My.Resources.enemy_left, My.Resources.enemy_right, 9)
            End If
        End If
    End Sub

    'Sub Bounce

    Sub BounceO(q() As PictureBox, w As Integer, ByRef e As String, ByRef r As String, ByRef animation As Boolean,
                left As Bitmap, right As Bitmap, spd As Integer)
        If q(w).Location.X > FWidth - 100 Then
            e = "left"
            If animation = True Then
                If q(w).Tag.ToString = "right" Then
                    q(w).Tag = "left"
                    q(w).Image = left
                End If
            End If
        ElseIf q(w).Location.X < 0 Then
            e = "right"
            If animation = True Then
                If q(w).Tag.ToString = "left" Then
                    q(w).Tag = "right"
                    q(w).Image = right
                End If
            End If
        End If

        If e = "right" Then
            q(w).Left += spd
        ElseIf e = "left" Then
            q(w).Left -= spd
        End If

        If q(w).Location.Y > FHeight - 100 Then
            r = "up"
        ElseIf q(w).Location.Y < 0 Then
            r = "down"
        End If

        If r = "up" Then
            q(w).Top -= spd
        ElseIf r = "down" Then
            q(w).Top += spd
        End If
    End Sub

    'Time Lapse

    Private Sub TimeLapse_Tick(sender As Object, e As EventArgs) Handles TimeLapse.Tick
        Seconds += 1

        If Seconds > 9 Then
            lblSecs.Text = CStr(Seconds)
        ElseIf Seconds > 0 Then
            lblSecs.Text = "0" + CStr(Seconds)
        End If

        If Seconds > 59 Then
            Seconds = 0
            lblSecs.Text = "0" + CStr(Seconds)
            Minutes += 1
            lblMins.Text = CStr(Minutes) + ":"
            If Minutes > 59 Then
                Minutes = 0
                lblMins.Text = ""
            End If
        End If

        If SettingsForm.radTime.Checked = True Then
            If Minutes = Convert.ToDouble(SettingsForm.txtTime.Text) Then
                TimeLapse.Stop()
                KeyCtrl.Stop()
                EnemyCtrl.Stop()
                JumpCtrl.Stop()
                CollisionCtrl.Stop()
                SoundCtrl.Stop()
                SpeedUPSpwn.Stop()
                SpeedUPDur.Stop()
                EnemyAtk.Stop()
                FreezeSpwn.Stop()
                FreezeDur.Stop()
                Dim result = MessageBox.Show("Time's up!", "Time Challenge", MessageBoxButtons.OK, MessageBoxIcon.None)
                If result = DialogResult.OK Then
                    Me.Close()
                End If
            End If
        End If
    End Sub

    'Enemy Bomb Control

    Private Sub EnemyAtk_Tick(sender As Object, e As EventArgs) Handles EnemyAtk.Tick
        If SettingsForm.chkEnemies.Checked = True Then

            mp3laugh.Play()
            Dim b = 3.75
            If mp3laugh.CurrentPosition >= mp3laugh.Duration - b Then
                mp3laugh.SeekCurrentPosition(0, SeekPositionFlags.AbsolutePositioning)
            End If

            Dim a As Integer
            If SettingsForm.comDify.SelectedItem.ToString = "Easy" Then
                a = 1
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Hard" Then
                a = 2
            ElseIf SettingsForm.comDify.SelectedItem.ToString = "Insane" Then
                a = 3
            End If
            For x = 1 To a
                Bomb(x).SetBounds(Enemy(x).Location.X, Enemy(x).Location.Y, 35, 35)
            Next
        End If
    End Sub

    Private Sub Background_Click(sender As Object, e As EventArgs) Handles Background.Click
    End Sub
End Class

