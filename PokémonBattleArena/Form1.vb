' Form1.vb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GameState.MenuMusicPlayer.SoundLocation = "Audio\menu.wav"
            GameState.MenuMusicPlayer.PlayLooping()
        Catch ex As Exception
            Console.WriteLine("File musik menu tidak ditemukan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        GameState.InitializePokemonList()
        GameState.ResetScores()
        Dim selectForm As New FormSelect()
        selectForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Game PvP Pokémon sederhana buatanmu di VB.NET.", "Tentang Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class