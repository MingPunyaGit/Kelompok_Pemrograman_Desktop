' Pokemon.vb
Public Enum PokemonType
    None
    Fire
    Water
    Grass
    Electric
    Psychic
    Dragon
    Flying
    Normal
    Fighting
End Enum

Public Class Pokemon
    Public Property Name As String
    Public Property MaxHP As Integer
    Public Property CurrentHP As Integer
    Public Property Attack As Integer
    Public Property Defense As Integer
    Public Property SpecialAttack As Integer
    Public Property P1_IdleImagePath As String
    Public Property P1_AttackImagePath As String
    Public Property P1_SpecialAttackImagePath As String
    Public Property P1_DefendImagePath As String
    Public Property P2_IdleImagePath As String
    Public Property P2_AttackImagePath As String
    Public Property P2_SpecialAttackImagePath As String
    Public Property P2_DefendImagePath As String
    Public Property PortraitImagePath As String
    Public Property Type1 As PokemonType
    Public Property Type2 As PokemonType

    Public Sub New(name As String, hp As Integer, attack As Integer, defense As Integer, spAttack As Integer,
                   p1Idle As String, p1Attack As String, p1Special As String, p1Defend As String,
                   p2Idle As String, p2Attack As String, p2Special As String, p2Defend As String,
                   portraitPath As String, type1 As PokemonType, Optional type2 As PokemonType = PokemonType.None)
        Me.Name = name
        Me.MaxHP = hp
        Me.CurrentHP = hp
        Me.Attack = attack
        Me.Defense = defense
        Me.SpecialAttack = spAttack
        Me.P1_IdleImagePath = p1Idle
        Me.P1_AttackImagePath = p1Attack
        Me.P1_SpecialAttackImagePath = p1Special
        Me.P1_DefendImagePath = p1Defend
        Me.P2_IdleImagePath = p2Idle
        Me.P2_AttackImagePath = p2Attack
        Me.P2_SpecialAttackImagePath = p2Special
        Me.P2_DefendImagePath = p2Defend
        Me.PortraitImagePath = portraitPath
        Me.Type1 = type1
        Me.Type2 = type2
    End Sub

    Public Function Clone() As Pokemon
        Return New Pokemon(Me.Name, Me.MaxHP, Me.Attack, Me.Defense, Me.SpecialAttack,
                           Me.P1_IdleImagePath, Me.P1_AttackImagePath, Me.P1_SpecialAttackImagePath, Me.P1_DefendImagePath,
                           Me.P2_IdleImagePath, Me.P2_AttackImagePath, Me.P2_SpecialAttackImagePath, Me.P2_DefendImagePath,
                           Me.PortraitImagePath, Me.Type1, Me.Type2)
    End Function

    Public Sub TakeDamage(damageAmount As Integer)
        Me.CurrentHP -= damageAmount
        If Me.CurrentHP < 0 Then Me.CurrentHP = 0
    End Sub
    Public Sub ResetHP()
        Me.CurrentHP = Me.MaxHP
    End Sub
End Class