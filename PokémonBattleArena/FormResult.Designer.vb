<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormResult))
        Me.lblWinnerInfo = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.wmpMVP = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.wmpMVP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWinnerInfo
        '
        Me.lblWinnerInfo.AutoSize = True
        Me.lblWinnerInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblWinnerInfo.Font = New System.Drawing.Font("MV Boli", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnerInfo.Location = New System.Drawing.Point(134, 69)
        Me.lblWinnerInfo.Name = "lblWinnerInfo"
        Me.lblWinnerInfo.Size = New System.Drawing.Size(75, 28)
        Me.lblWinnerInfo.TabIndex = 0
        Me.lblWinnerInfo.Text = "Label1"
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(66, 357)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(143, 43)
        Me.btnPlayAgain.TabIndex = 1
        Me.btnPlayAgain.Text = "> Lanjut"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(350, 357)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 46)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "> Keluar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'wmpMVP
        '
        Me.wmpMVP.Enabled = True
        Me.wmpMVP.Location = New System.Drawing.Point(66, 110)
        Me.wmpMVP.Name = "wmpMVP"
        Me.wmpMVP.OcxState = CType(resources.GetObject("wmpMVP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpMVP.Size = New System.Drawing.Size(448, 224)
        Me.wmpMVP.TabIndex = 3
        '
        'FormResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.wmpMVP)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblWinnerInfo)
        Me.Name = "FormResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormResult"
        CType(Me.wmpMVP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWinnerInfo As Label
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents wmpMVP As AxWMPLib.AxWindowsMediaPlayer
End Class
