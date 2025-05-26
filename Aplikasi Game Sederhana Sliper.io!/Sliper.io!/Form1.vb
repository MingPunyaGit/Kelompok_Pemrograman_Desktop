Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MODIFIKASI: Langsung muat gambar dari My.Resources
        ' Pastikan nama "logo" sesuai dengan nama resource yang Anda tambahkan
        picLogo.Image = My.Resources.logo
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class