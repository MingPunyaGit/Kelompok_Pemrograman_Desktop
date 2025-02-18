Imports System.IO
Imports System.Media
Public Class Form2
    Private rand As New Random()
    Private score As Integer = 0
    Private timeLeft As Integer = 30
    Private highScore As Integer = 0
    Private moles As PictureBox()
    Private highScoreFile As String = "highscore.txt"


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHighScore()
        InitializeGame()
        StartGame()
    End Sub

    Private Sub InitializeGame()

        moles = New PictureBox() {pbMole1, pbMole2, pbMole3, pbMole4, pbMole5, pbMole6, pbMole7}


        For Each mole In moles
            AddHandler mole.Click, AddressOf Mole_Click
            mole.Visible = False
        Next

        Timer1.Interval = 1000
        Timer2.Interval = 1000


        lblHighScore.Text = highScore
    End Sub

    Private Sub StartGame()
        score = 0
        timeLeft = 30
        lblScore.Text = score
        lblTime.Text = timeLeft

        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLeft -= 1
        lblTime.Text = timeLeft

        If timeLeft = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            MessageBox.Show($"Waktu habis! Skor Anda: {score}")


            If score > highScore Then
                highScore = score
                MessageBox.Show($"Selamat! Highscore baru: {highScore}")
                SaveHighScore()
            End If

            Me.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        For Each mole In moles
            mole.Visible = False
        Next


        Dim numMoles As Integer = rand.Next(1, 4)
        For i As Integer = 0 To numMoles - 1
            Dim index As Integer = rand.Next(moles.Length)
            moles(index).Visible = True
        Next
    End Sub

    Private Sub Mole_Click(sender As Object, e As EventArgs)
        Dim clickedMole As PictureBox = CType(sender, PictureBox)
        clickedMole.Visible = False

        'Dim sound As New System.Media.SoundPlayer("D:\pemograman destop\WHACK A MOLE\Asset\Kena.wav")
        'sound.Play()

        score += 1
        lblScore.Text = score



    End Sub


    Private Sub SaveHighScore()
        Try
            File.WriteAllText(highScoreFile, highScore.ToString())
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan High Score!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadHighScore()
        Try
            If File.Exists(highScoreFile) Then
                Dim savedScore As String = File.ReadAllText(highScoreFile)
                Integer.TryParse(savedScore, highScore)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat High Score!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        ResetGame()
    End Sub

    Private Sub ResetGame()

        Timer1.Stop()
        Timer2.Stop()


        score = 0
        timeLeft = 30
        lblScore.Text = score
        lblTime.Text = timeLeft


        For Each mole In moles
            mole.Visible = False
        Next


        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub pbMole5_Click(sender As Object, e As EventArgs) Handles pbMole5.Click

    End Sub
End Class