<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbRefresh = New PictureBox()
        pbMole2 = New PictureBox()
        pbMole3 = New PictureBox()
        pbMole1 = New PictureBox()
        pbMole4 = New PictureBox()
        pbMole5 = New PictureBox()
        pbMole6 = New PictureBox()
        pbMole7 = New PictureBox()
        lblScore = New Label()
        lblTime = New Label()
        lblHighScore = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        CType(pbRefresh, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbRefresh
        ' 
        pbRefresh.BackColor = Color.Transparent
        pbRefresh.BackgroundImage = My.Resources.Resources.Refresh
        pbRefresh.BackgroundImageLayout = ImageLayout.Stretch
        pbRefresh.Location = New Point(607, 22)
        pbRefresh.Name = "pbRefresh"
        pbRefresh.Size = New Size(65, 62)
        pbRefresh.TabIndex = 0
        pbRefresh.TabStop = False
        ' 
        ' pbMole2
        ' 
        pbMole2.BackColor = Color.Transparent
        pbMole2.BackgroundImageLayout = ImageLayout.Stretch
        pbMole2.Image = My.Resources.Resources.Mole
        pbMole2.Location = New Point(315, 225)
        pbMole2.Name = "pbMole2"
        pbMole2.Size = New Size(134, 127)
        pbMole2.SizeMode = PictureBoxSizeMode.StretchImage
        pbMole2.TabIndex = 2
        pbMole2.TabStop = False
        pbMole2.Visible = False
        ' 
        ' pbMole3
        ' 
        pbMole3.BackColor = Color.Transparent
        pbMole3.BackgroundImageLayout = ImageLayout.Stretch
        pbMole3.Image = My.Resources.Resources.Mole
        pbMole3.Location = New Point(468, 365)
        pbMole3.Name = "pbMole3"
        pbMole3.Size = New Size(134, 127)
        pbMole3.SizeMode = PictureBoxSizeMode.StretchImage
        pbMole3.TabIndex = 3
        pbMole3.TabStop = False
        pbMole3.Visible = False
        ' 
        ' pbMole1
        ' 
        pbMole1.BackColor = Color.Transparent
        pbMole1.BackgroundImageLayout = ImageLayout.Stretch
        pbMole1.Image = My.Resources.Resources.Mole
        pbMole1.Location = New Point(67, 293)
        pbMole1.Name = "pbMole1"
        pbMole1.Size = New Size(134, 127)
        pbMole1.SizeMode = PictureBoxSizeMode.StretchImage
        pbMole1.TabIndex = 1
        pbMole1.TabStop = False
        pbMole1.Visible = False
        ' 
        ' pbMole4
        ' 
        pbMole4.BackColor = Color.Transparent
        pbMole4.BackgroundImageLayout = ImageLayout.Stretch
        pbMole4.Image = My.Resources.Resources.Mole
        pbMole4.Location = New Point(187, 426)
        pbMole4.Name = "pbMole4"
        pbMole4.Size = New Size(134, 127)
        pbMole4.SizeMode = PictureBoxSizeMode.StretchImage
        pbMole4.TabIndex = 4
        pbMole4.TabStop = False
        pbMole4.Visible = False
        ' 
        ' pbMole5
        ' 
        pbMole5.BackColor = Color.Transparent
        pbMole5.BackgroundImageLayout = ImageLayout.Stretch
        pbMole5.Image = CType(resources.GetObject("pbMole5.Image"), Image)
        pbMole5.Location = New Point(490, 512)
        pbMole5.Name = "pbMole5"
        pbMole5.Size = New Size(134, 127)
        pbMole5.SizeMode = PictureBoxSizeMode.StretchImage
        pbMole5.TabIndex = 5
        pbMole5.TabStop = False
        pbMole5.Visible = False
        ' 
        ' pbMole6
        ' 
        pbMole6.BackColor = Color.Transparent
        pbMole6.BackgroundImageLayout = ImageLayout.Stretch
        pbMole6.Image = My.Resources.Resources.Mole
        pbMole6.Location = New Point(52, 575)
        pbMole6.Name = "pbMole6"
        pbMole6.Size = New Size(134, 127)
        pbMole6.SizeMode = PictureBoxSizeMode.StretchImage
        pbMole6.TabIndex = 6
        pbMole6.TabStop = False
        pbMole6.Visible = False
        ' 
        ' pbMole7
        ' 
        pbMole7.BackColor = Color.Transparent
        pbMole7.BackgroundImageLayout = ImageLayout.Stretch
        pbMole7.Image = My.Resources.Resources.Mole
        pbMole7.Location = New Point(332, 670)
        pbMole7.Name = "pbMole7"
        pbMole7.Size = New Size(134, 127)
        pbMole7.SizeMode = PictureBoxSizeMode.StretchImage
        pbMole7.TabIndex = 7
        pbMole7.TabStop = False
        pbMole7.Visible = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Microsoft Sans Serif", 40.0F, FontStyle.Bold)
        lblScore.Location = New Point(332, 114)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(58, 63)
        lblScore.TabIndex = 8
        lblScore.Text = "0"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Microsoft Sans Serif", 35.0F, FontStyle.Bold)
        lblTime.Location = New Point(587, 180)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(50, 54)
        lblTime.TabIndex = 9
        lblTime.Text = "0"
        ' 
        ' lblHighScore
        ' 
        lblHighScore.AutoSize = True
        lblHighScore.BackColor = Color.Transparent
        lblHighScore.Font = New Font("Microsoft Sans Serif", 40.0F, FontStyle.Bold)
        lblHighScore.Location = New Point(67, 180)
        lblHighScore.Name = "lblHighScore"
        lblHighScore.Size = New Size(58, 63)
        lblHighScore.TabIndex = 10
        lblHighScore.Text = "0"
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.MapMole
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(684, 845)
        Controls.Add(lblHighScore)
        Controls.Add(lblTime)
        Controls.Add(lblScore)
        Controls.Add(pbMole7)
        Controls.Add(pbMole6)
        Controls.Add(pbMole5)
        Controls.Add(pbMole4)
        Controls.Add(pbMole3)
        Controls.Add(pbMole2)
        Controls.Add(pbMole1)
        Controls.Add(pbRefresh)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Whack a Mole!"
        CType(pbRefresh, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents pbMole2 As PictureBox
    Friend WithEvents pbMole3 As PictureBox
    Friend WithEvents pbMole1 As PictureBox
    Friend WithEvents pbMole4 As PictureBox
    Friend WithEvents pbMole5 As PictureBox
    Friend WithEvents pbMole6 As PictureBox
    Friend WithEvents pbMole7 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
