' FormResult.vb
Imports WMPLib ' Pastikan Imports ini ada di bagian atas

Public Class FormResult
    Private winnerMessage As String
    Private mvpPokemon As Pokemon

    Public Sub New(message As String, mvp As Pokemon)
        InitializeComponent()
        Me.winnerMessage = message
        Me.mvpPokemon = mvp
    End Sub

    Private Sub FormResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWinnerInfo.Text = winnerMessage.ToUpper()

        Dim videoPath As String = ""
        Dim fullVideoPath As String = "" ' Untuk debugging

        If mvpPokemon IsNot Nothing Then
            Select Case mvpPokemon.Name
                Case "Dragonite"
                    videoPath = "Videos\Dragonite_mvp.mp4"
                Case "Pikachu"
                    videoPath = "Videos\Pikachu_mvp.mp4"
                Case "Charizard"
                    videoPath = "Videos\Charizard_mvp.mp4"
                Case "Blastoise"
                    videoPath = "Videos\Blastoise_mvp.mp4"
                Case "Blaziken"
                    videoPath = "Videos\Blaziken_mvp.mp4"
                Case "Alakazam"
                    videoPath = "Videos\Alakazam_mvp.mp4"
                Case Else
                    Console.WriteLine("Nama MVP Pokemon tidak cocok dengan case manapun: " & mvpPokemon.Name)
            End Select
        Else
            Console.WriteLine("mvpPokemon adalah Nothing saat FormResult_Load.")
        End If

        ' --- Debugging Path ---
        If Not String.IsNullOrEmpty(videoPath) Then
            ' Mendapatkan path absolut dari lokasi eksekusi aplikasi
            fullVideoPath = System.IO.Path.Combine(Application.StartupPath, videoPath)
            Console.WriteLine("Mencoba memuat video dari (relatif): " & videoPath)
            Console.WriteLine("Path absolut yang dicari: " & fullVideoPath)
        Else
            Console.WriteLine("videoPath kosong, tidak ada video yang akan dimuat.")
        End If
        ' --- Akhir Debugging Path ---

        Try
            If Not String.IsNullOrEmpty(videoPath) AndAlso IO.File.Exists(fullVideoPath) Then 'Gunakan fullVideoPath untuk IO.File.Exists
                Console.WriteLine("File video DITEMUKAN di: " & fullVideoPath)
                wmpMVP.uiMode = "none"
                '' wmpMVP.settings.setMode("loop", True)
                wmpMVP.URL = fullVideoPath ' Gunakan fullVideoPath untuk URL
                '' wmpMVP.Ctlcontrols.play()
            Else
                Console.WriteLine("File video TIDAK DITEMUKAN atau videoPath kosong.")
                If Not String.IsNullOrEmpty(fullVideoPath) Then
                    Console.WriteLine("IO.File.Exists(" & fullVideoPath & ") mengembalikan False.")
                End If
                wmpMVP.Visible = False ' Sembunyikan jika tidak ada video
            End If
        Catch ex As Exception
            Console.WriteLine("Error saat mencoba memutar video: " & ex.Message)
            wmpMVP.Visible = False ' Sembunyikan jika ada error
        End Try
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Dim startForm As Form = Application.OpenForms("Form1")

        ' Tutup semua form lain KECUALI form awal (jika ada)
        For Each frm As Form In Application.OpenForms.Cast(Of Form)().ToList()
            If frm IsNot startForm Then
                frm.Close()
            End If
        Next

        ' Tampilkan atau buat baru form awal
        If startForm Is Nothing OrElse startForm.IsDisposed Then
            startForm = New Form1() ' Pastikan Form1 adalah nama form awal Anda
            startForm.Show()
        Else
            startForm.Show()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class