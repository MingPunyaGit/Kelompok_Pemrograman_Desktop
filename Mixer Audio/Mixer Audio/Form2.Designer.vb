<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJam = New Label()
        txtHour = New NumericUpDown()
        txtMinute = New NumericUpDown()
        lblMenit = New Label()
        btnAplly = New Button()
        btnReset = New Button()
        CType(txtHour, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtMinute, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.ForeColor = Color.White
        lblJam.Location = New Point(115, 96)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(27, 15)
        lblJam.TabIndex = 4
        lblJam.Tag = ""
        lblJam.Text = "jam"
        ' 
        ' txtHour
        ' 
        txtHour.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtHour.Location = New Point(57, 88)
        txtHour.Margin = New Padding(3, 2, 3, 2)
        txtHour.Name = "txtHour"
        txtHour.Size = New Size(52, 23)
        txtHour.TabIndex = 5
        ' 
        ' txtMinute
        ' 
        txtMinute.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtMinute.Location = New Point(57, 51)
        txtMinute.Margin = New Padding(3, 2, 3, 2)
        txtMinute.Name = "txtMinute"
        txtMinute.Size = New Size(52, 23)
        txtMinute.TabIndex = 6
        ' 
        ' lblMenit
        ' 
        lblMenit.AutoSize = True
        lblMenit.ForeColor = Color.White
        lblMenit.Location = New Point(115, 61)
        lblMenit.Name = "lblMenit"
        lblMenit.Size = New Size(38, 15)
        lblMenit.TabIndex = 7
        lblMenit.Tag = ""
        lblMenit.Text = "menit"
        ' 
        ' btnAplly
        ' 
        btnAplly.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnAplly.FlatAppearance.BorderSize = 0
        btnAplly.FlatStyle = FlatStyle.Flat
        btnAplly.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAplly.ForeColor = Color.Black
        btnAplly.Location = New Point(173, 52)
        btnAplly.Margin = New Padding(3, 2, 3, 2)
        btnAplly.Name = "btnAplly"
        btnAplly.Size = New Size(82, 24)
        btnAplly.TabIndex = 8
        btnAplly.Text = "Apply"
        btnAplly.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.Black
        btnReset.Location = New Point(173, 88)
        btnReset.Margin = New Padding(3, 2, 3, 2)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(82, 24)
        btnReset.TabIndex = 9
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepPink
        ClientSize = New Size(439, 159)
        Controls.Add(btnReset)
        Controls.Add(btnAplly)
        Controls.Add(lblMenit)
        Controls.Add(txtMinute)
        Controls.Add(txtHour)
        Controls.Add(lblJam)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "Timer"
        CType(txtHour, ComponentModel.ISupportInitialize).EndInit()
        CType(txtMinute, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJam As Label
    Friend WithEvents txtHour As NumericUpDown
    Friend WithEvents txtMinute As NumericUpDown
    Friend WithEvents lblMenit As Label
    Friend WithEvents btnAplly As Button
    Friend WithEvents btnReset As Button
End Class
