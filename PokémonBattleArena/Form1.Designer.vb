<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnMulai = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMulai
        '
        Me.btnMulai.BackColor = System.Drawing.Color.Transparent
        Me.btnMulai.Font = New System.Drawing.Font("Noto Sans SC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulai.Location = New System.Drawing.Point(353, 202)
        Me.btnMulai.Name = "btnMulai"
        Me.btnMulai.Size = New System.Drawing.Size(90, 50)
        Me.btnMulai.TabIndex = 0
        Me.btnMulai.Text = "Mulai"
        Me.btnMulai.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Noto Sans SC", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnKeluar.Location = New System.Drawing.Point(353, 258)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(90, 48)
        Me.btnKeluar.TabIndex = 1
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Noto Sans SC", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAbout.Location = New System.Drawing.Point(353, 312)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(90, 41)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnMulai)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PokémonBattleArena"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMulai As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnAbout As Button
End Class
