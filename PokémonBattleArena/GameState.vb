' GameState.vb
Imports System.Media

Module GameState
    Public Player1Pokemon As Pokemon
    Public Player2Pokemon As Pokemon
    Public AvailablePokemon As New List(Of Pokemon)
    Public Player1Score As Integer = 0
    Public Player2Score As Integer = 0
    Public MenuMusicPlayer As New SoundPlayer()
    Public BattleMusicPlayer As New SoundPlayer()

    Public Sub ResetScores()
        Player1Score = 0
        Player2Score = 0
    End Sub

    Public Sub InitializePokemonList()
        AvailablePokemon.Clear()
        AvailablePokemon.Add(New Pokemon("Blaziken", 80, 120, 70, 110, "Images\Blaziken_P1_idle.gif", "Images\Blaziken_P1_attack.gif", "Images\Blaziken_P1_specialattack.gif", "Images\Blaziken_P1_defend.gif", "Images\Blaziken_P2_idle.gif", "Images\Blaziken_P2_attack.gif", "Images\Blaziken_P2_specialattack.gif", "Images\Blaziken_P2_defend.gif", "Images\Blaziken.png", PokemonType.Fire, PokemonType.Fighting))
        AvailablePokemon.Add(New Pokemon("Pikachu", 35, 55, 40, 50, "Images\Pikachu_P1_idle.gif", "Images\Pikachu_P1_attack.gif", "Images\Pikachu_P1_specialattack.gif", "Images\Pikachu_P1_defend.gif", "Images\Pikachu_P2_idle.gif", "Images\Pikachu_P2_attack.gif", "Images\Pikachu_P2_specialattack.gif", "Images\Pikachu_P2_defend.gif", "Images\Pikachu.png", PokemonType.Electric))
        AvailablePokemon.Add(New Pokemon("Charizard", 78, 84, 78, 109, "Images\Charizard_P1_idle.gif", "Images\Charizard_P1_attack.gif", "Images\Charizard_P1_specialattack.gif", "Images\Charizard_P1_defend.gif", "Images\Charizard_P2_idle.gif", "Images\Charizard_P2_attack.gif", "Images\Charizard_P2_specialattack.gif", "Images\Charizard_P2_defend.gif", "Images\Charizard.png", PokemonType.Fire, PokemonType.Flying))
        AvailablePokemon.Add(New Pokemon("Blastoise", 79, 83, 100, 85, "Images\Blastoise_P1_idle.gif", "Images\Blastoise_P1_attack.gif", "Images\Blastoise_P1_specialattack.gif", "Images\Blastoise_P1_defend.gif", "Images\Blastoise_P2_idle.gif", "Images\Blastoise_P2_attack.gif", "Images\Blastoise_P2_specialattack.gif", "Images\Blastoise_P2_defend.gif", "Images\Blastoise.png", PokemonType.Water))
        AvailablePokemon.Add(New Pokemon("Dragonite", 91, 134, 95, 100, "Images\Dragonite_P1_idle.gif", "Images\Dragonite_P1_attack.gif", "Images\Dragonite_P1_specialattack.gif", "Images\Dragonite_P1_defend.gif", "Images\Dragonite_P2_idle.gif", "Images\Dragonite_P2_attack.gif", "Images\Dragonite_P2_specialattack.gif", "Images\Dragonite_P2_defend.gif", "Images\Dragonite.png", PokemonType.Dragon, PokemonType.Flying))
        AvailablePokemon.Add(New Pokemon("Alakazam", 55, 50, 45, 135, "Images\Alakazam_P1_idle.gif", "Images\Alakazam_P1_attack.gif", "Images\Alakazam_P1_specialattack.gif", "Images\Alakazam_P1_defend.gif", "Images\Alakazam_P2_idle.gif", "Images\Alakazam_P2_attack.gif", "Images\Alakazam_P2_specialattack.gif", "Images\Alakazam_P2_defend.gif", "Images\Alakazam.png", PokemonType.Psychic))
    End Sub
End Module