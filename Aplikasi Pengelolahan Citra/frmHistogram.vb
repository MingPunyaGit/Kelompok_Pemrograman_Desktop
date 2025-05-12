Public Class frmHistogram
    Private Sub frmHistogram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Pastikan ada gambar yang diproses
        If frmUtama.PictureBox1.Image Is Nothing Then
            MessageBox.Show("Tidak ada gambar yang diproses!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' Inisialisasi
        Dim bmp = New Bitmap(frmUtama.PictureBox1.Image)
        Dim width = bmp.Width
        Dim height = bmp.Height
        Dim frekR(255), frekG(255), frekB(255) As Integer
        Dim maxFreq As Integer = 0

        ' Hitung frekuensi warna
        For y As Integer = 0 To height - 1
            For x As Integer = 0 To width - 1
                Dim pixel = bmp.GetPixel(x, y)
                frekR(pixel.R) += 1
                frekG(pixel.G) += 1
                frekB(pixel.B) += 1
            Next
        Next

        ' Cari nilai maksimum untuk normalisasi
        maxFreq = Math.Max(frekR.Max(), Math.Max(frekG.Max(), frekB.Max()))

        ' Buat gambar histogram
        Dim histoWidth As Integer = 256
        Dim histoHeight As Integer = 200
        Dim margin As Integer = 20
        Dim histo = New Bitmap(histoWidth + 2 * margin, histoHeight + 2 * margin)

        ' Gambar background putih dengan border
        Using g As Graphics = Graphics.FromImage(histo)
            g.Clear(Color.White)
            g.DrawRectangle(Pens.Black, 0, 0, histo.Width - 1, histo.Height - 1)

            ' Gambar sumbu
            g.DrawLine(Pens.Black, margin, margin, margin, histoHeight + margin)
            g.DrawLine(Pens.Black, margin, histoHeight + margin, histoWidth + margin, histoHeight + margin)

            ' Label sumbu
            For i As Integer = 0 To 255 Step 32
                g.DrawString(i.ToString(), Me.Font, Brushes.Black, margin + i - 5, histoHeight + margin + 5)
            Next
        End Using

        ' Gambar grafik histogram
        For i As Integer = 0 To 255
            Dim hR As Integer = CInt(frekR(i) / maxFreq * histoHeight)
            Dim hG As Integer = CInt(frekG(i) / maxFreq * histoHeight)
            Dim hB As Integer = CInt(frekB(i) / maxFreq * histoHeight)

            ' Gambar garis vertikal untuk setiap channel warna
            For h As Integer = 0 To Math.Max(hR, Math.Max(hG, hB))
                If h <= hR Then histo.SetPixel(i + margin, histoHeight + margin - h - 1, Color.FromArgb(128, Color.Red))
                If h <= hG Then histo.SetPixel(i + margin, histoHeight + margin - h - 1, Color.FromArgb(128, Color.Green))
                If h <= hB Then histo.SetPixel(i + margin, histoHeight + margin - h - 1, Color.FromArgb(128, Color.Blue))
            Next
        Next

        ' Tambahkan judul dan legenda
        Using g As Graphics = Graphics.FromImage(histo)
            g.DrawString("Histogram RGB", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, histoWidth / 2 - 40, 5)
            g.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Red)), histoWidth + margin - 70, 10, 15, 15)
            g.DrawString("Red", Me.Font, Brushes.Black, histoWidth + margin - 50, 10)
            g.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Green)), histoWidth + margin - 70, 30, 15, 15)
            g.DrawString("Green", Me.Font, Brushes.Black, histoWidth + margin - 50, 30)
            g.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Blue)), histoWidth + margin - 70, 50, 15, 15)
            g.DrawString("Blue", Me.Font, Brushes.Black, histoWidth + margin - 50, 50)
        End Using

        PictureBox1.Image = histo
        Me.Text = "Histogram - " & frmUtama.namafile
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class