Public Class Form2
    Private Sub btnAplly_Click(sender As Object, e As EventArgs) Handles btnAplly.Click
        ' Validate input
        Dim hours As Integer = CInt(txtHour.Value)
        Dim minutes As Integer = CInt(txtMinute.Value)

        If hours < 0 Or minutes < 0 Then
            MessageBox.Show("Please enter valid positive numbers for hours and minutes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Set the countdown time in Form1
        Form1.SetCountdownTime(hours, minutes)
        MessageBox.Show($"Timer set to {hours} hours and {minutes} minutes.", "Timer Set", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset the input fields
        txtHour.Value = 0
        txtMinute.Value = 0
        MessageBox.Show("Timer reset to 0 hours and 0 minutes.", "Timer Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set maximum values for hours and minutes to prevent unrealistic inputs
        txtHour.Maximum = 24
        txtMinute.Maximum = 59

        ' Ensure the form is centered on the screen
        Me.CenterToScreen()
    End Sub
End Class