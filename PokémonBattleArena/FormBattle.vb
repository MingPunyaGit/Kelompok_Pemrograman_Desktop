' FormBattle.vb
Public Class FormBattle
    Private isP1Turn As Boolean = True
    Private p1IsDefending As Boolean = False
    Private p2IsDefending As Boolean = False
    Private rand As New Random()

    Private Sub FormBattle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GameState.BattleMusicPlayer.SoundLocation = "Audio\battle.wav"
            GameState.BattleMusicPlayer.PlayLooping()
        Catch ex As Exception
            Console.WriteLine("File musik battle tidak ditemukan: " & ex.Message)
        End Try

        If GameState.Player1Pokemon Is Nothing OrElse GameState.Player2Pokemon Is Nothing Then
            MessageBox.Show("Data Pokémon tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        UpdateUI()
        LogMessage("Ronde " & (GameState.Player1Score + GameState.Player2Score + 1) & " Dimulai!")
        UpdateTurnInfo()
    End Sub

    Private Sub UpdateUI()
        lblP1Name.Text = GameState.Player1Pokemon.Name
        barP1HP.Maximum = GameState.Player1Pokemon.MaxHP
        barP1HP.Value = Math.Max(0, GameState.Player1Pokemon.CurrentHP)
        lblP1HPText.Text = $"{barP1HP.Value} / {barP1HP.Maximum} HP"
        Try
            If IO.File.Exists(GameState.Player1Pokemon.P1_IdleImagePath) Then picP1Pokemon.Image = Image.FromFile(GameState.Player1Pokemon.P1_IdleImagePath)
        Catch : End Try
        lblP2Name.Text = GameState.Player2Pokemon.Name
        barP2HP.Maximum = GameState.Player2Pokemon.MaxHP
        barP2HP.Value = Math.Max(0, GameState.Player2Pokemon.CurrentHP)
        lblP2HPText.Text = $"{barP2HP.Value} / {barP2HP.Maximum} HP"
        Try
            If IO.File.Exists(GameState.Player2Pokemon.P2_IdleImagePath) Then picP2Pokemon.Image = Image.FromFile(GameState.Player2Pokemon.P2_IdleImagePath)
        Catch : End Try
    End Sub

    Private Sub LogMessage(message As String)
        rtbLog.AppendText(message & vbCrLf)
        rtbLog.ScrollToCaret()
    End Sub

    Private Sub EnablePlayer1Buttons(enable As Boolean)
        btnP1Attack.Enabled = enable
        btnP1SpecialAttack.Enabled = enable
        btnP1Defend.Enabled = enable
    End Sub
    Private Sub EnablePlayer2Buttons(enable As Boolean)
        btnP2Attack.Enabled = enable
        btnP2SpecialAttack.Enabled = enable
        btnP2Defend.Enabled = enable
    End Sub

    Private Sub UpdateTurnInfo()
        If isP1Turn Then
            lblTurnInfo.Text = "Giliran: Player 1 (" & GameState.Player1Pokemon.Name & ")"
            EnablePlayer1Buttons(True)
            EnablePlayer2Buttons(False)
        Else
            lblTurnInfo.Text = "Giliran: Player 2 (" & GameState.Player2Pokemon.Name & ")"
            EnablePlayer1Buttons(False)
            EnablePlayer2Buttons(True)
        End If
    End Sub

    Private Sub btnP1Attack_Click(sender As Object, e As EventArgs) Handles btnP1Attack.Click
        If isP1Turn Then PerformAction("Attack")
    End Sub
    Private Sub btnP1SpecialAttack_Click(sender As Object, e As EventArgs) Handles btnP1SpecialAttack.Click
        If isP1Turn Then PerformAction("Special")
    End Sub
    Private Sub btnP1Defend_Click(sender As Object, e As EventArgs) Handles btnP1Defend.Click
        If isP1Turn Then PerformAction("Defend")
    End Sub
    Private Sub btnP2Attack_Click(sender As Object, e As EventArgs) Handles btnP2Attack.Click
        If Not isP1Turn Then PerformAction("Attack")
    End Sub
    Private Sub btnP2SpecialAttack_Click(sender As Object, e As EventArgs) Handles btnP2SpecialAttack.Click
        If Not isP1Turn Then PerformAction("Special")
    End Sub
    Private Sub btnP2Defend_Click(sender As Object, e As EventArgs) Handles btnP2Defend.Click
        If Not isP1Turn Then PerformAction("Defend")
    End Sub

    Private Async Sub PerformAction(actionType As String)
        Dim attacker, defender As Pokemon
        Dim attackerPictureBox As PictureBox
        Dim attackerName, originalImagePath, animationImagePath As String
        Dim defenderWasDefending As Boolean
        If isP1Turn Then
            attacker = GameState.Player1Pokemon : defender = GameState.Player2Pokemon
            attackerPictureBox = picP1Pokemon : attackerName = "Player 1 (" & attacker.Name & ")"
            defenderWasDefending = p2IsDefending : originalImagePath = attacker.P1_IdleImagePath
            Select Case actionType
                Case "Attack" : animationImagePath = attacker.P1_AttackImagePath
                Case "Special" : animationImagePath = attacker.P1_SpecialAttackImagePath
                Case "Defend" : animationImagePath = attacker.P1_DefendImagePath
            End Select
        Else
            attacker = GameState.Player2Pokemon : defender = GameState.Player1Pokemon
            attackerPictureBox = picP2Pokemon : attackerName = "Player 2 (" & attacker.Name & ")"
            defenderWasDefending = p1IsDefending : originalImagePath = attacker.P2_IdleImagePath
            Select Case actionType
                Case "Attack" : animationImagePath = attacker.P2_AttackImagePath
                Case "Special" : animationImagePath = attacker.P2_SpecialAttackImagePath
                Case "Defend" : animationImagePath = attacker.P2_DefendImagePath
            End Select
        End If
        EnablePlayer1Buttons(False) : EnablePlayer2Buttons(False)
        If IO.File.Exists(animationImagePath) AndAlso IO.File.Exists(originalImagePath) Then
            attackerPictureBox.Image = Image.FromFile(animationImagePath)
            Await Task.Delay(800)
            attackerPictureBox.Image = Image.FromFile(originalImagePath)
            If actionType <> "Defend" Then Await Task.Delay(200)
        End If
        If actionType = "Defend" Then
            If isP1Turn Then p1IsDefending = True Else p2IsDefending = True
            LogMessage($"{attackerName} bersiap untuk bertahan!")
        Else
            If isP1Turn Then p1IsDefending = False Else p2IsDefending = False
            Dim attackPower As Integer = If(actionType = "Attack", attacker.Attack, attacker.SpecialAttack)
            LogMessage($"{attackerName} menggunakan serangan {actionType.ToLower()}!")
            Dim damageDealt As Integer = CInt(Math.Max(1, attackPower - (defender.Defense / 2)))
            If defenderWasDefending Then
                damageDealt = CInt(Math.Max(1, damageDealt * 0.5))
                LogMessage($"{defender.Name} bertahan dan mengurangi damage!")
                If isP1Turn Then p2IsDefending = False Else p1IsDefending = False
            End If
            defender.TakeDamage(damageDealt)
            LogMessage($"{defender.Name} menerima {damageDealt} damage!")
        End If
        UpdateUI()
        CheckForWinner()
    End Sub

    Private Sub CheckForWinner()
        Dim roundWinnerName As String = ""
        Dim roundWinnerNumber As Integer = 0
        If GameState.Player2Pokemon.CurrentHP <= 0 Then
            roundWinnerName = "Player 1" : roundWinnerNumber = 1
            LogMessage($"{GameState.Player2Pokemon.Name} telah kalah!")
        ElseIf GameState.Player1Pokemon.CurrentHP <= 0 Then
            roundWinnerName = "Player 2" : roundWinnerNumber = 2
            LogMessage($"{GameState.Player1Pokemon.Name} telah kalah!")
        End If
        If roundWinnerNumber > 0 Then
            EnablePlayer1Buttons(False) : EnablePlayer2Buttons(False)
            lblTurnInfo.Text = $"Ronde Selesai! {roundWinnerName} menang."
            If roundWinnerNumber = 1 Then GameState.Player1Score += 1 Else GameState.Player2Score += 1
            Dim matchWinnerName As String = ""
            Dim matchWinnerPokemon As Pokemon = Nothing
            If GameState.Player1Score >= 2 Then
                matchWinnerName = "Player 1"
                matchWinnerPokemon = GameState.Player1Pokemon
            ElseIf GameState.Player2Score >= 2 Then
                matchWinnerName = "Player 2"
                matchWinnerPokemon = GameState.Player2Pokemon
            End If
            MessageBox.Show($"{roundWinnerName} memenangkan ronde ini!" & vbCrLf & $"Skor saat ini: Player 1 ({GameState.Player1Score}) - Player 2 ({GameState.Player2Score})", "Ronde Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Not String.IsNullOrEmpty(matchWinnerName) Then
                LogMessage($"Pertandingan Selesai! {matchWinnerName} adalah pemenang utama!")
                Dim formResult As New FormResult($"{matchWinnerName} MEMENANGKAN PERTANDINGAN!", matchWinnerPokemon)
                formResult.Show()
                Me.Close()
            Else
                LogMessage("Bersiap untuk ronde berikutnya...")
                Dim formSelect As New FormSelect()
                formSelect.Show()
                Me.Close()
            End If
        Else
            isP1Turn = Not isP1Turn
            UpdateTurnInfo()
        End If
    End Sub

    Private Sub FormBattle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GameState.BattleMusicPlayer.Stop()
    End Sub
End Class