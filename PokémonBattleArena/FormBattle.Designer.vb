<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBattle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBattle))
        Me.picP1Pokemon = New System.Windows.Forms.PictureBox()
        Me.lblP1Name = New System.Windows.Forms.Label()
        Me.barP1HP = New System.Windows.Forms.ProgressBar()
        Me.lblP1HPText = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.picP2Pokemon = New System.Windows.Forms.PictureBox()
        Me.lblP2HPText = New System.Windows.Forms.Label()
        Me.barP2HP = New System.Windows.Forms.ProgressBar()
        Me.lblP2Name = New System.Windows.Forms.Label()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.lblTurnInfo = New System.Windows.Forms.Label()
        Me.btnP1Attack = New System.Windows.Forms.Button()
        Me.btnP1SpecialAttack = New System.Windows.Forms.Button()
        Me.btnP1Defend = New System.Windows.Forms.Button()
        Me.btnP2Attack = New System.Windows.Forms.Button()
        Me.btnP2SpecialAttack = New System.Windows.Forms.Button()
        Me.btnP2Defend = New System.Windows.Forms.Button()
        CType(Me.picP1Pokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2Pokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picP1Pokemon
        '
        Me.picP1Pokemon.BackColor = System.Drawing.Color.Transparent
        Me.picP1Pokemon.Location = New System.Drawing.Point(155, 245)
        Me.picP1Pokemon.Name = "picP1Pokemon"
        Me.picP1Pokemon.Size = New System.Drawing.Size(120, 120)
        Me.picP1Pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picP1Pokemon.TabIndex = 0
        Me.picP1Pokemon.TabStop = False
        '
        'lblP1Name
        '
        Me.lblP1Name.AutoSize = True
        Me.lblP1Name.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Name.Location = New System.Drawing.Point(152, 101)
        Me.lblP1Name.Name = "lblP1Name"
        Me.lblP1Name.Size = New System.Drawing.Size(86, 16)
        Me.lblP1Name.TabIndex = 1
        Me.lblP1Name.Text = "lblP1Name"
        '
        'barP1HP
        '
        Me.barP1HP.Location = New System.Drawing.Point(155, 120)
        Me.barP1HP.Name = "barP1HP"
        Me.barP1HP.Size = New System.Drawing.Size(146, 23)
        Me.barP1HP.TabIndex = 2
        '
        'lblP1HPText
        '
        Me.lblP1HPText.AutoSize = True
        Me.lblP1HPText.Location = New System.Drawing.Point(152, 146)
        Me.lblP1HPText.Name = "lblP1HPText"
        Me.lblP1HPText.Size = New System.Drawing.Size(66, 13)
        Me.lblP1HPText.TabIndex = 3
        Me.lblP1HPText.Text = "lblP1HPText"
        '
        'picP2Pokemon
        '
        Me.picP2Pokemon.BackColor = System.Drawing.Color.Transparent
        Me.picP2Pokemon.Location = New System.Drawing.Point(596, 190)
        Me.picP2Pokemon.Name = "picP2Pokemon"
        Me.picP2Pokemon.Size = New System.Drawing.Size(120, 120)
        Me.picP2Pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picP2Pokemon.TabIndex = 4
        Me.picP2Pokemon.TabStop = False
        '
        'lblP2HPText
        '
        Me.lblP2HPText.AutoSize = True
        Me.lblP2HPText.Location = New System.Drawing.Point(650, 130)
        Me.lblP2HPText.Name = "lblP2HPText"
        Me.lblP2HPText.Size = New System.Drawing.Size(66, 13)
        Me.lblP2HPText.TabIndex = 5
        Me.lblP2HPText.Text = "lblP2HPText"
        '
        'barP2HP
        '
        Me.barP2HP.Location = New System.Drawing.Point(570, 104)
        Me.barP2HP.Name = "barP2HP"
        Me.barP2HP.Size = New System.Drawing.Size(146, 23)
        Me.barP2HP.TabIndex = 6
        '
        'lblP2Name
        '
        Me.lblP2Name.AutoSize = True
        Me.lblP2Name.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblP2Name.Location = New System.Drawing.Point(630, 85)
        Me.lblP2Name.Name = "lblP2Name"
        Me.lblP2Name.Size = New System.Drawing.Size(86, 16)
        Me.lblP2Name.TabIndex = 7
        Me.lblP2Name.Text = "lblP2Name"
        '
        'rtbLog
        '
        Me.rtbLog.Location = New System.Drawing.Point(772, 12)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(100, 190)
        Me.rtbLog.TabIndex = 8
        Me.rtbLog.Text = ""
        '
        'lblTurnInfo
        '
        Me.lblTurnInfo.AutoSize = True
        Me.lblTurnInfo.Location = New System.Drawing.Point(407, 37)
        Me.lblTurnInfo.Name = "lblTurnInfo"
        Me.lblTurnInfo.Size = New System.Drawing.Size(39, 13)
        Me.lblTurnInfo.TabIndex = 9
        Me.lblTurnInfo.Text = "Label1"
        '
        'btnP1Attack
        '
        Me.btnP1Attack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnP1Attack.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnP1Attack.Location = New System.Drawing.Point(118, 406)
        Me.btnP1Attack.Name = "btnP1Attack"
        Me.btnP1Attack.Size = New System.Drawing.Size(75, 33)
        Me.btnP1Attack.TabIndex = 10
        Me.btnP1Attack.Text = "Serang"
        Me.btnP1Attack.UseVisualStyleBackColor = False
        '
        'btnP1SpecialAttack
        '
        Me.btnP1SpecialAttack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnP1SpecialAttack.Location = New System.Drawing.Point(118, 445)
        Me.btnP1SpecialAttack.Name = "btnP1SpecialAttack"
        Me.btnP1SpecialAttack.Size = New System.Drawing.Size(100, 23)
        Me.btnP1SpecialAttack.TabIndex = 11
        Me.btnP1SpecialAttack.Text = "Serangan Khusus"
        Me.btnP1SpecialAttack.UseVisualStyleBackColor = False
        '
        'btnP1Defend
        '
        Me.btnP1Defend.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnP1Defend.Location = New System.Drawing.Point(118, 474)
        Me.btnP1Defend.Name = "btnP1Defend"
        Me.btnP1Defend.Size = New System.Drawing.Size(75, 23)
        Me.btnP1Defend.TabIndex = 12
        Me.btnP1Defend.Text = "Bertahan"
        Me.btnP1Defend.UseVisualStyleBackColor = False
        '
        'btnP2Attack
        '
        Me.btnP2Attack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnP2Attack.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnP2Attack.Location = New System.Drawing.Point(685, 406)
        Me.btnP2Attack.Name = "btnP2Attack"
        Me.btnP2Attack.Size = New System.Drawing.Size(75, 33)
        Me.btnP2Attack.TabIndex = 13
        Me.btnP2Attack.Text = "Serang"
        Me.btnP2Attack.UseVisualStyleBackColor = False
        '
        'btnP2SpecialAttack
        '
        Me.btnP2SpecialAttack.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnP2SpecialAttack.Location = New System.Drawing.Point(661, 445)
        Me.btnP2SpecialAttack.Name = "btnP2SpecialAttack"
        Me.btnP2SpecialAttack.Size = New System.Drawing.Size(99, 23)
        Me.btnP2SpecialAttack.TabIndex = 14
        Me.btnP2SpecialAttack.Text = "Serangan Khusus"
        Me.btnP2SpecialAttack.UseVisualStyleBackColor = False
        '
        'btnP2Defend
        '
        Me.btnP2Defend.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnP2Defend.Location = New System.Drawing.Point(685, 474)
        Me.btnP2Defend.Name = "btnP2Defend"
        Me.btnP2Defend.Size = New System.Drawing.Size(75, 23)
        Me.btnP2Defend.TabIndex = 15
        Me.btnP2Defend.Text = "Bertahan"
        Me.btnP2Defend.UseVisualStyleBackColor = False
        '
        'FormBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.btnP2Defend)
        Me.Controls.Add(Me.btnP2SpecialAttack)
        Me.Controls.Add(Me.btnP2Attack)
        Me.Controls.Add(Me.btnP1Defend)
        Me.Controls.Add(Me.btnP1SpecialAttack)
        Me.Controls.Add(Me.btnP1Attack)
        Me.Controls.Add(Me.lblTurnInfo)
        Me.Controls.Add(Me.rtbLog)
        Me.Controls.Add(Me.lblP2Name)
        Me.Controls.Add(Me.barP2HP)
        Me.Controls.Add(Me.lblP2HPText)
        Me.Controls.Add(Me.picP2Pokemon)
        Me.Controls.Add(Me.lblP1HPText)
        Me.Controls.Add(Me.barP1HP)
        Me.Controls.Add(Me.lblP1Name)
        Me.Controls.Add(Me.picP1Pokemon)
        Me.Name = "FormBattle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBattle"
        CType(Me.picP1Pokemon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2Pokemon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picP1Pokemon As PictureBox
    Friend WithEvents lblP1Name As Label
    Friend WithEvents barP1HP As ProgressBar
    Friend WithEvents lblP1HPText As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents picP2Pokemon As PictureBox
    Friend WithEvents lblP2HPText As Label
    Friend WithEvents barP2HP As ProgressBar
    Friend WithEvents lblP2Name As Label
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents lblTurnInfo As Label
    Friend WithEvents btnP1Attack As Button
    Friend WithEvents btnP1SpecialAttack As Button
    Friend WithEvents btnP1Defend As Button
    Friend WithEvents btnP2Attack As Button
    Friend WithEvents btnP2SpecialAttack As Button
    Friend WithEvents btnP2Defend As Button
End Class
