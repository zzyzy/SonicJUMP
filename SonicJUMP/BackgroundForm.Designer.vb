<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackgroundForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backgroundform))
        Me.chkSpring = New System.Windows.Forms.RadioButton()
        Me.chkIce = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkSpring
        '
        Me.chkSpring.AutoSize = True
        Me.chkSpring.Checked = True
        Me.chkSpring.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.chkSpring.FlatAppearance.CheckedBackColor = System.Drawing.Color.SkyBlue
        Me.chkSpring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.chkSpring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.chkSpring.Location = New System.Drawing.Point(48, 79)
        Me.chkSpring.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSpring.Name = "chkSpring"
        Me.chkSpring.Size = New System.Drawing.Size(98, 21)
        Me.chkSpring.TabIndex = 0
        Me.chkSpring.TabStop = True
        Me.chkSpring.Text = "Springyard"
        Me.chkSpring.UseVisualStyleBackColor = True
        '
        'chkIce
        '
        Me.chkIce.AutoSize = True
        Me.chkIce.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.chkIce.FlatAppearance.CheckedBackColor = System.Drawing.Color.SkyBlue
        Me.chkIce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.chkIce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.chkIce.Location = New System.Drawing.Point(48, 257)
        Me.chkIce.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIce.Name = "chkIce"
        Me.chkIce.Size = New System.Drawing.Size(81, 21)
        Me.chkIce.TabIndex = 1
        Me.chkIce.Text = "Ice Field"
        Me.chkIce.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(220, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(220, 206)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(212, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'BackgroundForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 372)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkIce)
        Me.Controls.Add(Me.chkSpring)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(493, 419)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(493, 419)
        Me.Name = "backgroundform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Background"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkSpring As System.Windows.Forms.RadioButton
    Friend WithEvents chkIce As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
