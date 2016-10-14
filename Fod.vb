Module FoD_Database
    'Very strange content. High debug.
#Region "Vars"
    Public SelectedLesson() As String 'Register empty 1-type array
    Public PlayerRank As String = "Hatchling"
    Public PlayerLevel As Integer = 0
    Public PlayerEXP As Integer = 0
    Public NeededGems() As Integer '0 - small
#End Region
#Region "Schooling"
    Public Function Schooling_Global(ID As Integer, Optional getfunction As String = "Check") '-1 - Error, 0 - still locked, Request - success
        Dim Request() As String
        If (getfunction = "Check") Then
            Request = Schooling_Data(ID) 'receive information about lesson
            If (PlayerRank = Request(1) Or RankStrtoInt(PlayerRank) = RankStrtoInt(Request(1))) Then
                Return Request
            Else
                Return 0
            End If
            Return -1 'error
        ElseIf (getfunction = "Learn") Then

        Else
            main.ConsoleOut("Invalid function")
        End If
        main.ConsoleOut("Out of range")
        Return -1
    End Function

    Public Function RankStrtoInt(var1 As String) As Integer
        If (var1 = "null" Or var1 = "Error" Or var1 = "") Then
            Return 0
        End If
        If (var1 = "Hatchling") Then
            Return 1
        End If
        If (var1 = "Very Young") Then
            Return 2
        End If

        Return 0 'default
    End Function

    'A huge placeholder, nothing interesting here
    Public Function Schooling_Data(ID As Integer)
        Dim Answer() As String = {-1, "Rank", "Name", -1, -1} '{ID, Rank, Name, Days left, Gold Needed} (0 - free, lower than 24 hours; -1 - Error)
        Select Case (ID)
            Case 0
                Answer = {0, "null", "Test var", 0, 0}
            Case 1
                Answer = {1, "Hatchling", "Hatching", -1, 1000}
            Case 2
                Answer = {2, "Hatchling", "Burrowing", -1, 5000}
            Case 3
                Answer = {3, "Hatchling", "Flying", -1, 10000}
            Case 4
                Answer = {4, "Very Young", "Spell-Casting Attack", 1, 15000}
            Case 5
                Answer = {5, "Very Young", "Very Young Bite Attack", 7, 20000}
            Case 6
                Answer = {6, "Very Young", "Very Young Claws Attack", 7, 20000}
            Case 7
                Answer = {7, "Very Young", "Very Young Tail Attack", -1, 20000}
            Case 8
                Answer = {8, "Very Young", "Very Young Breath Attack", -1, 25000}
            Case 9
                Answer = {9, "Very Young", "Very Young Weapon Defence", 10, 25000}
            Case Else
                Answer = {-1, "Error", "Error", -1, 0}
        End Select
        If (Answer(0) <> -1) Then
            Return Answer
        Else
            Return -1
        End If
    End Function
#End Region
#Region "Leveling\Ranking"
    Public Sub EXPGain(days As Integer)
        Dim EXPMultiplier As Double = 0
        Dim EXPPlus As String = 0
        Dim BattleChance As Integer = Int(Rnd(0 * 6))

        'Empty (Error)
        If (PlayerRank = "") Then
            main.ConsoleOut("Unsuspectable Error: Rank is NULL (Function EXPGain)")
        End If
        'Hatchling
        '2
        '3.33
        If (PlayerRank = "Hatchling" And PlayerLevel < 6 And PlayerLevel > 0) Then
            EXPMultiplier = 1.33
            EXPPlus = 2
        ElseIf (PlayerRank = "Hatchling" And PlayerLevel > 6 And PlayerLevel < 0) Then
            main.ConsoleOut("Logical Error: Rank is Hatchling, but level not correct (Function EXPGain)." & vbNewLine & "Rank = " & PlayerRank & ", Level = " & PlayerLevel)
        End If
        'Very Young
        If (PlayerRank = "Very Young" And PlayerLevel < 10 And PlayerLevel >= 6) Then
            '

        ElseIf (PlayerRank = "Very Young" And PlayerLevel < 16 And PlayerLevel >= 10) Then
            '5.25, 5.333, 5.625, 5.875 
            '6, 6.222, 6.375, 6.444, 6.667, 6.75, 6.778 
            '7, 7.111, 7.222, 7.25, 7.5
            EXPMultiplier = 2.25
            EXPPlus = 5.25
        ElseIf (PlayerRank = "Very Young" And PlayerLevel > 16) Then
            EXPMultiplier = 0
            EXPPlus = 0
        End If
        'Unsuspectable Ranking (waiting)



        'Function
        Do Until BattleChance = 0
            BattleChance = BattleChance - 1
            If (BattleChance < 0) Then
                main.ConsoleOut("BattleChance is under zero. Loop exit.")
                Exit Do
            End If
            EXPChange(Int(Rnd() * EXPMultiplier) + EXPPlus, days)
        Loop
    End Sub
    Public Function EXPChange(var As Integer, days As Integer)
        PlayerEXP = PlayerEXP + var
        If (PlayerEXP >= 100) Then
            Return LevelUP(days)
        End If
    End Function
    Public Function LevelUP(days As Integer)
        If (PlayerLevel < 6 And PlayerLevel + 1 = 6) Then
            NeededGems(0) = NeededGems(0) + 1
        End If
        If (PlayerLevel < 16 And PlayerLevel + 1 = 16) Then
            NeededGems(0) = NeededGems(0) + 5
        End If
        PlayerLevel = PlayerLevel + 1
        If (main.language = "ru") Then
            Return "Вы подняли уровень до " & PlayerLevel & vbNewLine
        ElseIf (main.language = "en") Then
            Return "Your level growth to " & PlayerLevel & vbNewLine
        End If
    End Function
#End Region

End Module
