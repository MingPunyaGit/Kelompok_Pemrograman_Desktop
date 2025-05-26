Imports System.IO
Imports System.Drawing

Public Class Form2
    '--- Asset Loading ---
    ' Pastikan file-file ini ada di dalam folder 'asset' di direktori output aplikasi Anda
    Dim Lingkaran As Image = Image.FromFile(Application.StartupPath & "\asset\lingkaran.png")
    Dim persegiMerah As Image = Image.FromFile(Application.StartupPath & "\asset\persegi.png")
    Dim persegiHijau As Image = Image.FromFile(Application.StartupPath & "\asset\persegiHijau.png")
    Dim persegiPink As Image = Image.FromFile(Application.StartupPath & "\asset\persegiPink.png")
    Dim assetPath As String = Application.StartupPath & "\asset\"

    '--- Game Configuration ---
    Dim gridSize As Integer = 20
    Dim gridWidth As Integer
    Dim gridHeight As Integer

    '--- Game Data ---
    Dim playerSnake As New List(Of Point)
    Dim botSnake1 As New List(Of Point)
    Dim botSnake2 As New List(Of Point)
    Dim foodList As New List(Of Point)
    Dim random As New Random()

    '--- Snake Directions ---
    Dim playerDir As Point = New Point(1, 0)
    Dim bot1Dir As Point = New Point(0, 1)
    Dim bot2Dir As Point = New Point(0, -1)

    '--- Game State ---
    Dim timerGame As New Timer()
    Dim score As Integer = 0
    Dim highScore As Integer = 0
    Dim isGameOver As Boolean = False
    Dim isGameStarted As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Atur ukuran form
        Me.Size = New Size(800, 800)
        Me.Text = "Snake IO Game"

        ' 2. Hitung jumlah grid berdasarkan ukuran form
        gridWidth = Me.ClientSize.Width \ gridSize
        gridHeight = (Me.ClientSize.Height - 40) \ gridSize ' Area game adalah tinggi form dikurangi 40px untuk skor

        ' 3. Aktifkan DoubleBuffered untuk grafis yang lebih halus
        Me.DoubleBuffered = True

        ' 4. Siapkan game
        StartNewGame()
        timerGame.Interval = 120
        AddHandler timerGame.Tick, AddressOf GameLoop
        Me.Focus()
    End Sub

    Sub StartNewGame()
        timerGame.Stop()

        playerSnake.Clear()
        botSnake1.Clear()
        botSnake2.Clear()
        foodList.Clear()

        playerDir = New Point(1, 0)
        bot1Dir = New Point(0, 1)
        bot2Dir = New Point(0, -1)

        ' Pastikan ular tidak muncul di luar area grid
        playerSnake.Add(New Point(5, 5))
        botSnake1.Add(New Point(gridWidth - 5, 5))
        botSnake2.Add(New Point(gridWidth \ 2, gridHeight - 5))

        score = 0
        isGameOver = False
        isGameStarted = False

        For i = 1 To 10 ' Menambah jumlah makanan agar lebih mirip dengan Slither.io
            foodList.Add(GetRandomEmptyCell())
        Next

        Dim hsPath As String = Application.StartupPath & "\asset\highscore.txt"

        If File.Exists(hsPath) Then
            Integer.TryParse(File.ReadAllText(hsPath), highScore)
        Else
            highScore = 0
        End If

        Me.Invalidate()
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Return
        End If

        If Not isGameStarted Then
            If e.KeyCode = Keys.Enter Then
                isGameStarted = True
                timerGame.Start()
                Me.Invalidate()
            End If
            Return
        End If

        If isGameOver Then
            If e.KeyCode = Keys.Enter Then
                StartNewGame()
            End If
            Return
        End If

        Select Case e.KeyCode
            Case Keys.Left
                If playerDir.X <> 1 Then playerDir = New Point(-1, 0)
            Case Keys.Right
                If playerDir.X <> -1 Then playerDir = New Point(1, 0)
            Case Keys.Up
                If playerDir.Y <> 1 Then playerDir = New Point(0, -1)
            Case Keys.Down
                If playerDir.Y <> -1 Then playerDir = New Point(0, 1)
        End Select
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' --- GAMBAR ELEMEN GAME (Selalu digambar) ---
        ' Gambar makanan
        For Each food In foodList
            e.Graphics.DrawImage(Lingkaran, food.X * gridSize, food.Y * gridSize, gridSize, gridSize)
        Next

        ' Gambar ular pemain
        For Each pt In playerSnake
            e.Graphics.DrawImage(persegiHijau, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next

        ' Gambar ular bot
        For Each pt In botSnake1
            e.Graphics.DrawImage(persegiMerah, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next
        For Each pt In botSnake2
            e.Graphics.DrawImage(persegiPink, pt.X * gridSize, pt.Y * gridSize, gridSize, gridSize)
        Next

        ' Gambar Skor dan High Score
        e.Graphics.DrawString("Score: " & score, New Font("Arial", 12), Brushes.White, 5, gridHeight * gridSize + 5)
        e.Graphics.DrawString("High Score: " & highScore, New Font("Arial", 12), Brushes.Yellow, 120, gridHeight * gridSize + 5)
        ' ----------------------------------------------------

        If Not isGameStarted Then
            ' --- GAMBAR LAYAR AWAL (Welcome Screen) ---
            Dim fontJudul As New Font("Arial", 24, FontStyle.Bold)
            Dim fontMulai As New Font("Arial", 12)
            Dim fontKet As New Font("Arial", 9, FontStyle.Regular) ' Font lebih kecil dan reguler
            Dim sf As New StringFormat With {.Alignment = StringAlignment.Center}

            Dim msgJudul = "Selamat Datang di Sliper.IO"
            Dim msgMulai = "Mulai (Tekan Enter)"
            Dim msgKet = "Jalankan ular HIJAU milikmu dengan gesit menggunakan tombol panah!" & vbCrLf & "Manuver lincah untuk mengelabui lawan."

            ' Penyesuaian posisi vertikal agar lebih ke tengah
            Dim startY As Single = (Me.ClientSize.Height / 2) - 80 ' Sesuaikan nilai 80 jika perlu

            e.Graphics.DrawString(msgJudul, fontJudul, Brushes.White, New RectangleF(0, startY, Me.ClientSize.Width, 50), sf)
            e.Graphics.DrawString(msgMulai, fontMulai, Brushes.White, New RectangleF(0, startY + 60, Me.ClientSize.Width, 30), sf)

            ' Mengukur teks untuk penempatan yang presisi
            Dim sizeKet As SizeF = e.Graphics.MeasureString(msgKet, fontKet, Me.ClientSize.Width)
            Dim totalTextWidth As Single = sizeKet.Width
            Dim startTextX As Single = (Me.ClientSize.Width - totalTextWidth) / 2

            ' Gambar kotak merah kecil di sebelah kiri teks keterangan
            e.Graphics.FillRectangle(Brushes.Red, startTextX - 25, startY + 105, 10, 10) ' Kotak merah kecil

            ' Menggambar teks keterangan dengan warna abu-abu terang
            e.Graphics.DrawString(msgKet, fontKet, Brushes.LightGray, New RectangleF(0, startY + 100, Me.ClientSize.Width, 50), sf)

        ElseIf isGameOver Then
            ' --- GAMBAR LAYAR GAME OVER ---
            Dim msg = "Game Over!"
            Dim msgKeterangan = "Tekan Enter untuk restart" & vbCrLf & "Tekan Esc untuk exit"
            Dim fontMsg As New Font("Arial", 22)
            Dim fontKet As New Font("Arial", 15)
            Dim sizeMsg = e.Graphics.MeasureString(msg, fontMsg)
            Dim sizeKet = e.Graphics.MeasureString(msgKeterangan, fontKet)
            Dim totalHeight As Single = sizeMsg.Height + 10 + sizeKet.Height
            Dim startY As Single = (Me.ClientSize.Height - totalHeight) / 2
            Dim centerX As Single = (Me.ClientSize.Width - sizeMsg.Width) / 2
            e.Graphics.DrawString(msg, fontMsg, Brushes.White, centerX, startY)
            Dim ketX As Single = (Me.ClientSize.Width - sizeKet.Width) / 2
            e.Graphics.DrawString(msgKeterangan, fontKet, Brushes.White, ketX, startY + sizeMsg.Height + 10)
        End If
    End Sub


    Private Sub GameLoop(sender As Object, e As EventArgs)
        Dim lastTailPlayer As Point = playerSnake.Last
        Dim lastTailBot1 As Point = botSnake1.Last
        Dim lastTailBot2 As Point = botSnake2.Last

        If playerSnake(0) = botSnake1(0) OrElse playerSnake(0) = botSnake2(0) Then
            isGameOver = True
            timerGame.Stop()
        End If

        MoveSnake(playerSnake, playerDir)

        bot1Dir = GetBotDirection(botSnake1, bot1Dir)
        MoveSnake(botSnake1, bot1Dir)

        bot2Dir = GetBotDirection(botSnake2, bot2Dir)
        MoveSnake(botSnake2, bot2Dir)

        Dim eatIdx As Integer = foodList.FindIndex(Function(f) f = playerSnake(0))
        If eatIdx >= 0 Then
            GrowSnake(playerSnake, lastTailPlayer)
            score += 10
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        eatIdx = foodList.FindIndex(Function(f) f = botSnake1(0))
        If eatIdx >= 0 Then
            GrowSnake(botSnake1, lastTailBot1)
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        eatIdx = foodList.FindIndex(Function(f) f = botSnake2(0))
        If eatIdx >= 0 Then
            GrowSnake(botSnake2, lastTailBot2)
            foodList(eatIdx) = GetRandomEmptyCell()
        End If

        If playerSnake.Skip(1).Any(Function(pt) pt = playerSnake(0)) Then
            isGameOver = True
            timerGame.Stop()
        End If

        If botSnake1.Skip(1).Any(Function(pt) pt = botSnake1(0)) Then
            ResetBot(botSnake1, New Point(gridWidth - 5, 5))
        End If

        If botSnake2.Skip(1).Any(Function(pt) pt = botSnake2(0)) Then
            ResetBot(botSnake2, New Point(gridWidth \ 2, gridHeight - 5))
        End If

        If botSnake2.Any(Function(pt) pt = botSnake1(0)) Then
            ResetBot(botSnake1, New Point(gridWidth - 5, 5))
        End If

        If botSnake1.Any(Function(pt) pt = botSnake2(0)) Then
            ResetBot(botSnake2, New Point(gridWidth \ 2, gridHeight - 5))
        End If

        If botSnake1.Skip(1).Any(Function(pt) pt = playerSnake(0)) Then
            ResetBot(botSnake1, New Point(gridWidth - 5, 5))
            score += 50
        End If

        If botSnake2.Skip(1).Any(Function(pt) pt = playerSnake(0)) Then
            ResetBot(botSnake2, New Point(gridWidth \ 2, gridHeight - 5))
            score += 50
        End If

        Me.Invalidate()

        If isGameOver Then
            timerGame.Stop()
            If score > highScore Then
                highScore = score
                File.WriteAllText(assetPath & "highscore.txt", highScore.ToString())
            End If
            Me.Invalidate()
            Return
        End If
    End Sub

    Sub MoveSnake(ByRef snake As List(Of Point), dir As Point)
        Dim newHead As Point = New Point((snake(0).X + dir.X + gridWidth) Mod gridWidth, (snake(0).Y + dir.Y + gridHeight) Mod gridHeight)
        snake.Insert(0, newHead)
        snake.RemoveAt(snake.Count - 1)
    End Sub

    Sub GrowSnake(ByRef snake As List(Of Point), tailPos As Point)
        snake.Add(tailPos)
    End Sub

    Function GetBotDirection(ByVal snake As List(Of Point), ByVal currentDir As Point) As Point
        Dim detectionRadius As Integer = 10
        Dim head As Point = snake(0)
        Dim closestFood As Point = Point.Empty
        Dim minDistance As Integer = Integer.MaxValue

        For Each food As Point In foodList
            Dim distance As Integer = Math.Abs(head.X - food.X) + Math.Abs(head.Y - food.Y)
            If distance < minDistance AndAlso distance <= detectionRadius Then
                minDistance = distance
                closestFood = food
            End If
        Next

        If Not closestFood.IsEmpty Then
            Dim possibleDirs As New List(Of Point)
            If closestFood.X < head.X Then
                possibleDirs.Add(New Point(-1, 0))
            ElseIf closestFood.X > head.X Then
                possibleDirs.Add(New Point(1, 0))
            End If
            If closestFood.Y < head.Y Then
                possibleDirs.Add(New Point(0, -1))
            ElseIf closestFood.Y > head.Y Then
                possibleDirs.Add(New Point(0, 1))
            End If
            Dim validDirs = possibleDirs.Where(Function(d) d <> New Point(-currentDir.X, -currentDir.Y)).ToList()
            If validDirs.Count > 0 Then
                Return validDirs(random.Next(validDirs.Count))
            End If
        End If

        Return GetRandomDirection(snake, currentDir)
    End Function

    Function GetRandomDirection(snake As List(Of Point), lastDir As Point) As Point
        Dim dirs As New List(Of Point) From {New Point(0, -1), New Point(0, 1), New Point(-1, 0), New Point(1, 0)}
        Dim currDir As Point = lastDir

        If random.Next(0, 10) > 8 Then ' Menambah sedikit kemungkinan berbelok acak
            Dim filtered = dirs.Where(Function(d) d <> New Point(-currDir.X, -currDir.Y)).ToList()
            If filtered.Count > 0 Then
                Return filtered(random.Next(filtered.Count))
            End If
        End If
        Return lastDir ' Sebagian besar waktu, terus lurus
    End Function

    Sub ResetBot(ByRef bot As List(Of Point), startPos As Point)
        bot.Clear()
        bot.Add(startPos)
    End Sub

    Private Function GetRandomEmptyCell() As Point
        Dim pt As Point
        Do
            pt = New Point(random.Next(0, gridWidth), random.Next(0, gridHeight))
        Loop While playerSnake.Contains(pt) OrElse botSnake1.Contains(pt) OrElse botSnake2.Contains(pt) OrElse foodList.Contains(pt)
        Return pt
    End Function
End Class