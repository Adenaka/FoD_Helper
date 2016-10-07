Module FoD_Database
    'Very strange content. High debug.
#Region "Vars"
    Public SelectedLesson() As String 'Register empty 1-type array
    Public PlayerRank As String
    Public PlayerLevel As Integer
    Public PlayerEXP As Integer
    Public NeededGems() As Integer '0 - small
#End Region
#Region "Schooling"
    Public Sub Schooling_Global(rank As String, ID As Integer, Optional getfunction As String = "Check")

    End Sub

    'A huge placeholder, nothing interesting here
    Public Function Schooling_Data(ID As Integer)
        Dim Answer() As String = {-1, "Rank", "Name", -1, -1} '{ID, Rank, Name, Days left (-1 - Error), Gold Needed}
        Select Case (ID)
            Case 0
                Answer = {0, "Hatchling", "The Beginning", -1, -1}
            Case 1
                Answer = {1, "", "", -1, -1}
            Case 2
                Answer = {2, "", "", -1, -1}
            Case 3
                Answer = {3, "", "", -1, -1}
            Case 4
                Answer = {4, "", "", -1, -1}
            Case 5
                Answer = {5, "", "", -1, -1}
            Case 6
                Answer = {6, "", "", -1, -1}
            Case 7
                Answer = {7, "", "", -1, -1}
            Case 8
                Answer = {8, "", "", -1, -1}
            Case 9
                Answer = {9, "", "", -1, -1}
            Case 10
                Answer = {10, "", "", -1, -1}
            Case 11
                Answer = {11, "", "", -1, -1}
            Case 12
                Answer = {12, "", "", -1, -1}
            Case 13
                Answer = {13, "", "", -1, -1}
            Case 14
                Answer = {14, "", "", -1, -1}
            Case Else
                Answer = {-1, "Error", "Error", -1}
        End Select

        Return -1
    End Function
#End Region
#Region "Leveling\Ranking"
    Public Sub EXPGain(rank As String)
        Dim EXPMultiplier As Double = 0
        Dim EXPPlus As String = 0
        Dim BattleChance As Integer = Int(Rnd(0 * 6))

        'Empty (Error)
        If (rank = "") Then
            main.ConsoleOut("Unsuspectable Error: Rank is NULL (Function EXPGain)")
        End If
        'Hatchling
        '2
        '3.33
        If (rank = "Hatchling" And PlayerLevel < 6 And PlayerLevel > 0) Then
            EXPMultiplier = 1.33
            EXPPlus = 2
        ElseIf (rank = "Hatchling" And PlayerLevel > 6 And PlayerLevel < 0) Then
            main.ConsoleOut("Logical Error: Rank is Hatchling, but level not correct (Function EXPGain)." & vbNewLine & "Rank = " & rank & ", Level = " & PlayerLevel)
        End If
        'Very Young
        If (rank = "Very Young" And PlayerLevel < 10 And PlayerLevel >= 6) Then
            '

        ElseIf (rank = "Very Young" And PlayerLevel < 16 And PlayerLevel >= 10) Then
            '5.25, 5.625, 5.875 
			'6, 6.222, 6.375, 6.444, 6.75, 6.778 
			'7, 7.111, 7.25
            EXPMultiplier = 2
            EXPPlus = 5.25
        ElseIf (rank = "Very Young" And PlayerLevel > 16 And PlayerLevel < 6) Then

        End If
        'Unsuspectable Ranking (waiting)



        'Function
        Do Until BattleChance = 0
            BattleChance = BattleChance - 1
            If (BattleChance < 0) Then
                main.ConsoleOut("BattleChance is under zero. Loop exit.")
                Exit Do
            End If
            EXPChange(Int(Rnd() * EXPMultiplier) + EXPPlus)
        Loop

    End Sub
    Public Sub EXPChange(var As Integer)
        PlayerEXP = PlayerEXP + var
        If (PlayerEXP >= 100) Then
            LevelUP()
        End If
    End Sub
    Public Sub LevelUP()
        If (PlayerLevel < 6 And PlayerLevel + 1 = 6) Then
            NeededGems(0) = NeededGems(0) + 1
        End If
        If (PlayerLevel < 16 And PlayerLevel + 1 = 16) Then
            NeededGems(0) = NeededGems(0) + 5
        End If
        PlayerLevel = PlayerLevel + 1
        If (main.language = "ru") Then
            main.output(main.days) = main.output(main.days) & "Вы подняли уровень до " & PlayerLevel & vbNewLine
        ElseIf (main.language = "en") Then
            main.output(main.days) = main.output(main.days) & "Your level growth to " & PlayerLevel & vbNewLine
        End If
    End Sub
#End Region

End Module
