<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.KeyCtrl = New System.Windows.Forms.Timer(Me.components)
        Me.CollisionCtrl = New System.Windows.Forms.Timer(Me.components)
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeedUPSpwn = New System.Windows.Forms.Timer(Me.components)
        Me.SpeedUPDur = New System.Windows.Forms.Timer(Me.components)
        Me.SonicPB = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JumpCtrl = New System.Windows.Forms.Timer(Me.components)
        Me.SoundCtrl = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLapse = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyCtrl = New System.Windows.Forms.Timer(Me.components)
        Me.lblDify = New System.Windows.Forms.Label()
        Me.lblEnemy = New System.Windows.Forms.Label()
        Me.lblScored = New System.Windows.Forms.Label()
        Me.FreezeSpwn = New System.Windows.Forms.Timer(Me.components)
        Me.FreezeDur = New System.Windows.Forms.Timer(Me.components)
        Me.lblSecs = New System.Windows.Forms.Label()
        Me.lblMins = New System.Windows.Forms.Label()
        Me.EnemyAtk = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SonicPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KeyCtrl
        '
        Me.KeyCtrl.Interval = 1
        '
        'CollisionCtrl
        '
        Me.CollisionCtrl.Interval = 20
        '
        'Background
        '
        Me.Background.Location = New System.Drawing.Point(-14, 12)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(1280, 598)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 7
        Me.Background.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1242, 28)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SpeedUPSpwn
        '
        Me.SpeedUPSpwn.Interval = 10000
        '
        'SpeedUPDur
        '
        Me.SpeedUPDur.Interval = 5000
        '
        'SonicPB
        '
        Me.SonicPB.BackColor = System.Drawing.Color.Transparent
        Me.SonicPB.Image = CType(resources.GetObject("SonicPB.Image"), System.Drawing.Image)
        Me.SonicPB.Location = New System.Drawing.Point(0, 486)
        Me.SonicPB.Name = "SonicPB"
        Me.SonicPB.Size = New System.Drawing.Size(100, 100)
        Me.SonicPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SonicPB.TabIndex = 22
        Me.SonicPB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1122, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 23
        '
        'JumpCtrl
        '
        Me.JumpCtrl.Interval = 15
        '
        'SoundCtrl
        '
        Me.SoundCtrl.Interval = 125
        '
        'TimeLapse
        '
        Me.TimeLapse.Interval = 1000
        '
        'EnemyCtrl
        '
        Me.EnemyCtrl.Interval = 1
        '
        'lblDify
        '
        Me.lblDify.AutoSize = True
        Me.lblDify.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblDify.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDify.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblDify.Location = New System.Drawing.Point(1183, 7)
        Me.lblDify.Name = "lblDify"
        Me.lblDify.Size = New System.Drawing.Size(55, 20)
        Me.lblDify.TabIndex = 24
        Me.lblDify.Text = "Label2"
        '
        'lblEnemy
        '
        Me.lblEnemy.AutoSize = True
        Me.lblEnemy.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblEnemy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEnemy.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblEnemy.Location = New System.Drawing.Point(1102, 7)
        Me.lblEnemy.Name = "lblEnemy"
        Me.lblEnemy.Size = New System.Drawing.Size(55, 20)
        Me.lblEnemy.TabIndex = 25
        Me.lblEnemy.Text = "Label2"
        '
        'lblScored
        '
        Me.lblScored.AutoSize = True
        Me.lblScored.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblScored.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScored.Location = New System.Drawing.Point(955, -2)
        Me.lblScored.Name = "lblScored"
        Me.lblScored.Size = New System.Drawing.Size(28, 29)
        Me.lblScored.TabIndex = 26
        Me.lblScored.Text = "0"
        '
        'FreezeSpwn
        '
        Me.FreezeSpwn.Interval = 10000
        '
        'FreezeDur
        '
        Me.FreezeDur.Interval = 5000
        '
        'lblSecs
        '
        Me.lblSecs.AutoSize = True
        Me.lblSecs.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblSecs.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecs.ForeColor = System.Drawing.Color.Black
        Me.lblSecs.Location = New System.Drawing.Point(558, -2)
        Me.lblSecs.Name = "lblSecs"
        Me.lblSecs.Size = New System.Drawing.Size(43, 29)
        Me.lblSecs.TabIndex = 27
        Me.lblSecs.Text = "00"
        '
        'lblMins
        '
        Me.lblMins.AutoSize = True
        Me.lblMins.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lblMins.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMins.ForeColor = System.Drawing.Color.Black
        Me.lblMins.Location = New System.Drawing.Point(526, -2)
        Me.lblMins.Name = "lblMins"
        Me.lblMins.Size = New System.Drawing.Size(28, 29)
        Me.lblMins.TabIndex = 28
        Me.lblMins.Text = "0"
        '
        'EnemyAtk
        '
        Me.EnemyAtk.Interval = 10000
        '
        'GameForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1242, 587)
        Me.Controls.Add(Me.lblMins)
        Me.Controls.Add(Me.lblSecs)
        Me.Controls.Add(Me.lblScored)
        Me.Controls.Add(Me.lblEnemy)
        Me.Controls.Add(Me.lblDify)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SonicPB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Background)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1260, 634)
        Me.MinimumSize = New System.Drawing.Size(1260, 634)
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sonic JUMP!"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SonicPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KeyCtrl As System.Windows.Forms.Timer
    Friend WithEvents CollisionCtrl As System.Windows.Forms.Timer
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeedUPSpwn As System.Windows.Forms.Timer
    Friend WithEvents SpdUP As System.Windows.Forms.PictureBox
    Friend WithEvents SpeedUPDur As System.Windows.Forms.Timer
    Friend WithEvents SonicPB As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents JumpCtrl As System.Windows.Forms.Timer
    Friend WithEvents SoundCtrl As System.Windows.Forms.Timer
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeLapse As System.Windows.Forms.Timer
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnemyCtrl As System.Windows.Forms.Timer
    Friend WithEvents lblDify As System.Windows.Forms.Label
    Friend WithEvents lblEnemy As System.Windows.Forms.Label
    Friend WithEvents lblScored As System.Windows.Forms.Label
    Friend WithEvents FreezeSpwn As System.Windows.Forms.Timer
    Friend WithEvents FreezeDur As System.Windows.Forms.Timer
    Friend WithEvents lblSecs As System.Windows.Forms.Label
    Friend WithEvents lblMins As System.Windows.Forms.Label
    Friend WithEvents EnemyAtk As System.Windows.Forms.Timer

End Class
