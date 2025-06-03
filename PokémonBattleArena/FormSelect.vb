' FormSelect.vb
Public Class FormSelect
    Private isPlayer1Turn As Boolean = True

    Private Sub FormSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "Player 1, pilih Pokémon kamu!"
        btnLanjut.Enabled = False
        lblScore.Text = $"Skor: Player 1 ({GameState.Player1Score}) - Player 2 ({GameState.Player2Score})"
        lblScore.Font = New Font(lblScore.Font.FontFamily, 12, FontStyle.Bold)
        SetupPokemonPictureBox(pbBlaziken, "Blaziken")
        SetupPokemonPictureBox(pbPikachu, "Pikachu")
        SetupPokemonPictureBox(pbCharizard, "Charizard")
        SetupPokemonPictureBox(pbBlastoise, "Blastoise")
        SetupPokemonPictureBox(pbDragonite, "Dragonite")
        SetupPokemonPictureBox(pbAlakazam, "Alakazam")
    End Sub

    Private Sub SetupPokemonPictureBox(pb As PictureBox, pokemonName As String)
        Dim pkmData As Pokemon = GameState.AvailablePokemon.Find(Function(p) p.Name.Equals(pokemonName, StringComparison.OrdinalIgnoreCase))
        If pkmData IsNot Nothing Then
            pb.Tag = pkmData
            Try
                If IO.File.Exists(pkmData.PortraitImagePath) Then pb.Image = Image.FromFile(pkmData.PortraitImagePath)
            Catch
                pb.Image = Nothing
            End Try
            pb.SizeMode = PictureBoxSizeMode.Zoom
            pb.BorderStyle = BorderStyle.None
            pb.Cursor = Cursors.Hand
            pb.Width = 120
            pb.Height = 120
        Else
            pb.Visible = False
        End If
    End Sub

    Private Sub Pokemon_Click(sender As Object, e As EventArgs) Handles _
        pbBlaziken.Click, pbPikachu.Click, pbCharizard.Click,
        pbBlastoise.Click, pbDragonite.Click, pbAlakazam.Click

        Dim clickedPb As PictureBox = CType(sender, PictureBox)
        Dim selectedPokemon As Pokemon = CType(clickedPb.Tag, Pokemon)
        If selectedPokemon Is Nothing Then Return
        For Each pb As PictureBox In Me.Controls.OfType(Of PictureBox)().Where(Function(ctrl) TypeOf ctrl.Tag Is Pokemon)
            pb.BorderStyle = BorderStyle.None
        Next
        clickedPb.BorderStyle = BorderStyle.Fixed3D
        If isPlayer1Turn Then
            GameState.Player1Pokemon = selectedPokemon.Clone()
            lblStatus.Text = "Player 2, pilih Pokémon kamu!"
            isPlayer1Turn = False
        Else
            GameState.Player2Pokemon = selectedPokemon.Clone()
            lblStatus.Text = "Kedua pemain telah memilih Pokémon. Klik Lanjut!"
            btnLanjut.Enabled = True
        End If
    End Sub

    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        If GameState.Player1Pokemon Is Nothing OrElse GameState.Player2Pokemon Is Nothing Then
            MessageBox.Show("Pastikan kedua pemain sudah memilih Pokémon mereka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        GameState.MenuMusicPlayer.Stop()
        Dim battleForm As New FormBattle()
        battleForm.Show()
        Me.Hide()
    End Sub

    Private Sub FormSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Application.OpenForms.Cast(Of Form)().Any(Function(f) TypeOf f Is FormBattle Or TypeOf f Is FormResult) Then
            GameState.MenuMusicPlayer.Stop()
            Dim startForm = Application.OpenForms("Form1")
            If startForm IsNot Nothing Then startForm.Show()
        End If
    End Sub
End Class