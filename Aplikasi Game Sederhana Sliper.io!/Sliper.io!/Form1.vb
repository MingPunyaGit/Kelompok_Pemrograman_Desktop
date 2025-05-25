Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1

    ' MODIFIKASI: Menggunakan path absolut sesuai permintaan
    Dim assetPath As String = "D:\Pemerograman Dekstop Kelompok\Aplikasi Game Sederhana Sliper.io!\Sliper.io!\asset\"
    Dim imageHome As Image

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Memuat gambar logo dari path yang baru
        imageHome = Image.FromFile(assetPath & "logo.jpg")
        picLogo.Image = New Bitmap(picLogo.Width, picLogo.Height)

        Using g As Graphics = Graphics.FromImage(picLogo.Image)
            g.DrawImage(imageHome, 0, 0, picLogo.Width, picLogo.Height)
        End Using
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class