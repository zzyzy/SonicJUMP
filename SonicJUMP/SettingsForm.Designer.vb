<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.chkEnemies = New System.Windows.Forms.CheckBox()
        Me.chkDify = New System.Windows.Forms.CheckBox()
        Me.comDify = New System.Windows.Forms.ComboBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.infoTime = New System.Windows.Forms.Button()
        Me.infoScore = New System.Windows.Forms.Button()
        Me.infoEnemy = New System.Windows.Forms.Button()
        Me.infoDify = New System.Windows.Forms.Button()
        Me.btnBackground = New System.Windows.Forms.Button()
        Me.comMusic = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radTime = New System.Windows.Forms.CheckBox()
        Me.radScore = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(163, 121)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(132, 22)
        Me.txtTime.TabIndex = 1
        Me.txtTime.Text = "1"
        Me.ToolTip1.SetToolTip(Me.txtTime, "Key in values in minutes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum value: 1")
        Me.txtTime.Visible = False
        '
        'chkEnemies
        '
        Me.chkEnemies.AutoSize = True
        Me.chkEnemies.Location = New System.Drawing.Point(16, 43)
        Me.chkEnemies.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEnemies.Name = "chkEnemies"
        Me.chkEnemies.Size = New System.Drawing.Size(92, 21)
        Me.chkEnemies.TabIndex = 2
        Me.chkEnemies.Text = "Enemies?"
        Me.ToolTip1.SetToolTip(Me.chkEnemies, "Enables enemy(ies) that will compete with you for the rings!")
        Me.chkEnemies.UseVisualStyleBackColor = True
        '
        'chkDify
        '
        Me.chkDify.AutoSize = True
        Me.chkDify.Checked = True
        Me.chkDify.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDify.Enabled = False
        Me.chkDify.Location = New System.Drawing.Point(16, 71)
        Me.chkDify.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDify.Name = "chkDify"
        Me.chkDify.Size = New System.Drawing.Size(179, 21)
        Me.chkDify.TabIndex = 3
        Me.chkDify.Text = "Difficulty (default: Easy)"
        Me.chkDify.UseVisualStyleBackColor = True
        '
        'comDify
        '
        Me.comDify.BackColor = System.Drawing.SystemColors.Control
        Me.comDify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comDify.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comDify.FormattingEnabled = True
        Me.comDify.Items.AddRange(New Object() {"Easy", "Hard", "Insane"})
        Me.comDify.Location = New System.Drawing.Point(36, 89)
        Me.comDify.Margin = New System.Windows.Forms.Padding(4)
        Me.comDify.Name = "comDify"
        Me.comDify.Size = New System.Drawing.Size(160, 24)
        Me.comDify.TabIndex = 4
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(163, 149)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(132, 22)
        Me.txtScore.TabIndex = 7
        Me.txtScore.Text = "1"
        Me.ToolTip1.SetToolTip(Me.txtScore, "Key in values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum value: 1")
        Me.txtScore.Visible = False
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(137, 273)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 34)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'infoTime
        '
        Me.infoTime.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.infoTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.infoTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.infoTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.infoTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoTime.Location = New System.Drawing.Point(308, 121)
        Me.infoTime.Margin = New System.Windows.Forms.Padding(4)
        Me.infoTime.Name = "infoTime"
        Me.infoTime.Size = New System.Drawing.Size(33, 25)
        Me.infoTime.TabIndex = 9
        Me.infoTime.Text = "?"
        Me.ToolTip1.SetToolTip(Me.infoTime, "Enables Time Challenge." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Key in values in minutes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum value: 1")
        Me.infoTime.UseVisualStyleBackColor = True
        '
        'infoScore
        '
        Me.infoScore.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.infoScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.infoScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.infoScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.infoScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoScore.Location = New System.Drawing.Point(308, 149)
        Me.infoScore.Margin = New System.Windows.Forms.Padding(4)
        Me.infoScore.Name = "infoScore"
        Me.infoScore.Size = New System.Drawing.Size(33, 25)
        Me.infoScore.TabIndex = 10
        Me.infoScore.Text = "?"
        Me.ToolTip1.SetToolTip(Me.infoScore, "Enables Score Challenge." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Key in values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum value: 1")
        Me.infoScore.UseVisualStyleBackColor = True
        '
        'infoEnemy
        '
        Me.infoEnemy.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.infoEnemy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.infoEnemy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.infoEnemy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.infoEnemy.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoEnemy.Location = New System.Drawing.Point(308, 43)
        Me.infoEnemy.Margin = New System.Windows.Forms.Padding(4)
        Me.infoEnemy.Name = "infoEnemy"
        Me.infoEnemy.Size = New System.Drawing.Size(33, 25)
        Me.infoEnemy.TabIndex = 11
        Me.infoEnemy.Text = "?"
        Me.ToolTip1.SetToolTip(Me.infoEnemy, "Enables enemy(ies) that will compete with you for the rings!")
        Me.infoEnemy.UseVisualStyleBackColor = True
        '
        'infoDify
        '
        Me.infoDify.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.infoDify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.infoDify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.infoDify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.infoDify.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoDify.Location = New System.Drawing.Point(308, 75)
        Me.infoDify.Margin = New System.Windows.Forms.Padding(4)
        Me.infoDify.Name = "infoDify"
        Me.infoDify.Size = New System.Drawing.Size(33, 25)
        Me.infoDify.TabIndex = 12
        Me.infoDify.Text = "?"
        Me.infoDify.UseVisualStyleBackColor = True
        '
        'btnBackground
        '
        Me.btnBackground.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackground.Location = New System.Drawing.Point(16, 181)
        Me.btnBackground.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBackground.Name = "btnBackground"
        Me.btnBackground.Size = New System.Drawing.Size(325, 30)
        Me.btnBackground.TabIndex = 13
        Me.btnBackground.Text = "Change Background"
        Me.btnBackground.UseVisualStyleBackColor = True
        '
        'comMusic
        '
        Me.comMusic.BackColor = System.Drawing.SystemColors.Control
        Me.comMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comMusic.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comMusic.FormattingEnabled = True
        Me.comMusic.Items.AddRange(New Object() {"Greenhill Zone", "Marble Zone", "Starlight Zone"})
        Me.comMusic.Location = New System.Drawing.Point(117, 222)
        Me.comMusic.Margin = New System.Windows.Forms.Padding(4)
        Me.comMusic.Name = "comMusic"
        Me.comMusic.Size = New System.Drawing.Size(224, 24)
        Me.comMusic.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.comMusic, "Change the BGM.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Change Music"
        '
        'radTime
        '
        Me.radTime.AutoSize = True
        Me.radTime.Location = New System.Drawing.Point(16, 123)
        Me.radTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radTime.Name = "radTime"
        Me.radTime.Size = New System.Drawing.Size(136, 21)
        Me.radTime.TabIndex = 16
        Me.radTime.Text = "Time Challenge?"
        Me.ToolTip1.SetToolTip(Me.radTime, "Enables Time Challenge.")
        Me.radTime.UseVisualStyleBackColor = True
        '
        'radScore
        '
        Me.radScore.AutoSize = True
        Me.radScore.Location = New System.Drawing.Point(16, 151)
        Me.radScore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radScore.Name = "radScore"
        Me.radScore.Size = New System.Drawing.Size(142, 21)
        Me.radScore.TabIndex = 17
        Me.radScore.Text = "Score Challenge?"
        Me.ToolTip1.SetToolTip(Me.radScore, "Enables Score Challenge.")
        Me.radScore.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 320)
        Me.Controls.Add(Me.radScore)
        Me.Controls.Add(Me.radTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comMusic)
        Me.Controls.Add(Me.btnBackground)
        Me.Controls.Add(Me.infoDify)
        Me.Controls.Add(Me.infoEnemy)
        Me.Controls.Add(Me.infoScore)
        Me.Controls.Add(Me.infoTime)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.comDify)
        Me.Controls.Add(Me.chkDify)
        Me.Controls.Add(Me.chkEnemies)
        Me.Controls.Add(Me.txtTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(390, 367)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(390, 367)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents chkEnemies As System.Windows.Forms.CheckBox
    Friend WithEvents chkDify As System.Windows.Forms.CheckBox
    Friend WithEvents comDify As System.Windows.Forms.ComboBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents infoTime As System.Windows.Forms.Button
    Friend WithEvents infoScore As System.Windows.Forms.Button
    Friend WithEvents infoEnemy As System.Windows.Forms.Button
    Friend WithEvents infoDify As System.Windows.Forms.Button
    Friend WithEvents btnBackground As System.Windows.Forms.Button
    Friend WithEvents comMusic As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radTime As System.Windows.Forms.CheckBox
    Friend WithEvents radScore As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
