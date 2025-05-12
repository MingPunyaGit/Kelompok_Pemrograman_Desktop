Public Class Watermark
    Public Property WatermarkText As String
    Public Property WatermarkFont As Font = New Font("Arial", 24, FontStyle.Bold Or FontStyle.Italic) ' Default font keren
    Public Property WatermarkColor As Color = Color.FromArgb(50, Color.White) ' Semi-transparan

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtWatermark.Text) Then
            MessageBox.Show("Masukkan teks watermark!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        WatermarkText = txtWatermark.Text
        WatermarkFont = New Font("Arial", 24, FontStyle.Bold) ' Font tetap
        WatermarkColor = Color.FromArgb(50, Color.White) ' Warna tetap transparan
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class