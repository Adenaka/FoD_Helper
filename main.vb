Imports System.Math
Public Class main
#Region "PublicVars"
    Public days As Integer = 0
    Public checkedday As Integer = 0
    Public output(days) As String
    Public language As String = "ru"
    Public debugAdenakaLabel As Boolean = False

    Public guildvar1 As Integer = 0
    Public guildvar2 As Integer = 0
    Public guildcon(3, 5) As Integer
    Public guildgold As Integer = 0
#End Region
#Region "Function"
    Public Sub Start_Button_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        ' Получаем информацию для действий
        Dim oldgold As Integer = CInt(Gold_in_bank.Text)
        Dim newgold As Integer = CInt(gold_var.Text)
        Dim days_needed As Integer = 0
        Dim scavenging As Boolean = Scavenge_checker.Checked
        Dim schooling As Boolean = Schooling_checker.Checked
        Dim errors As Integer = 0 ' количество ошибок
        Dim hoard_type As Integer = 3 '0 - не нужно, 1 - уже есть, 2 - нужно приобрести
        Dim hoard_text As String = Hoard_Check.Text
        Dim GD_type As Integer = 0
        Dim GD_text As String = CheckGD.Text

        If (hoard_text = "Не требуется" Or hoard_text = "Not needed") Then
            hoard_type = 0
        ElseIf (hoard_text = "Уже есть" Or hoard_text = "Have already") Then
            hoard_type = 1
        ElseIf (hoard_text = "Нужно купить" Or hoard_text = "Needed") Then
            hoard_type = 2
        End If

        If (GD_text = "Золото" Or GD_text = "Gold") Then
            GD_type = 0
        ElseIf (GD_text = "Прирост" Or GD_text = "Growth") Then
            GD_type = 1
        End If

        ConsoleClear() 'очищаем консоль
        If (oldgold > 50000000) Then
            errors = errors + 1
            If (language = "ru") Then
                ConsoleOut("Ошибка: сумма в банке больше 50кк (50.000.000)")
            Else
                ConsoleOut("Error: gold in your bank is above 50kk (50.000.000)")
            End If
        End If
        If (newgold = 0) Then
            errors = errors + 1
            If (language = "ru") Then
                ConsoleOut("Ошибка: Не указано требуемое количество золота")
            Else
                ConsoleOut("Error: Needed gold is null")
            End If
        End If
        If (oldgold = newgold) Then
            errors = errors + 1
            If (language = "ru") Then
                ConsoleOut("Логическая ошибка: Аргументы совпадают")
            Else
                ConsoleOut("Logical Error: Arguments are the same")
            End If
        End If
        If (oldgold < 20 And scavenging = False) Then
            errors = errors + 1
            If (language = "ru") Then
                ConsoleOut("Логическая ошибка: сумма в банке не возрастает и не восполняется за счет изучения местности")
            Else
                ConsoleOut("Logical Error: your gold are not growing and not replenish by scavenging")
            End If
            If (hoard_type = 2) Then
                errors = errors + 1
                If (language = "ru") Then
                    ConsoleOut("Логическая ошибка: нет средств для покупки Сокровищницы (hoard_type = 2) [Buying needed]")
                Else
                    ConsoleOut("Logical Error: You can't buy a hoard, because your bank bonus are null (hoard_type = 2) [Buying needed]")
                End If
            End If
        End If
        If (newgold > 50000000 And hoard_type = 0) Then
            errors = errors + 1
            If (language = "ru") Then
                ConsoleOut("Логическая ошибка: нужное количество золота не умещается в банк. Проверьте опцию сокровищницы.")
            Else
                ConsoleOut("Logical Error: Required gold does not fit into the bank. Check hoard option")
            End If
        End If
        If (GD_type = 0 And oldgold > newgold) Then
            errors = errors + 1
            If (language = "ru") Then
                ConsoleOut("Логическая ошибка: аргумент требуемого золота ниже аргумента золота в банке")
            Else
                ConsoleOut("Logical Error: Needed gold argument are under gold in bank argument")
            End If
        End If
        If (GD_type = 1 And newgold > 980392) Then
            errors = errors + 1
            If (language = "ru") Then
                ConsoleOut("Логическая ошибка: Значение прироста не должно превышать 980392")
            Else
                ConsoleOut("Logical Error: Growth argument can't be above 980392")
            End If
        End If

        If (language = "ru") Then
            ConsoleOut("Найдено ошибок: " & errors)
        Else
            ConsoleOut("Errors find: " & errors)
        End If
        If (errors = 0) Then
            If (GD_type = 0) Then
                SummFunction(oldgold, newgold, scavenging, schooling, hoard_type)
            ElseIf (GD_type = 1) Then
                GrowFunction(oldgold, newgold, scavenging, schooling, hoard_type, GD_type)
            End If
        End If

        days_label.Text = days
    End Sub

    'Старт функции сбора золота
    Public Sub SummFunction(gold1 As Integer, gold2 As Integer, boolscav As Boolean, boolsch As Boolean, hoard_type As Integer)
        days = 0
        Dim rand_scav As Integer = 0
        Dim degree As Integer = 0
        Dim looper As Integer = 0
        Dim optifyeddegree As Integer = 980392
        Dim gethoard As Boolean = False
        ReDim Preserve output(days)
        If (hoard_type = 1) Then
            gethoard = True
        End If
        If (language = "ru") Then
            ConsoleOut("Начата задача: " & gold1 & " > " & gold2)
        Else
            ConsoleOut("Started Function: " & gold1 & " > " & gold2)
        End If
        Do Until gold1 >= gold2
            days = days + 1
            ReDim Preserve output(UBound(output) + 1)
            If (language = "ru") Then
                output(days) = output(days) & "---День " & days & "---" & vbNewLine
            Else
                output(days) = output(days) & "---Day " & days & "---" & vbNewLine
            End If
            looper = looper + 1
            degree = Math.Round(gold1 * 0.02)
            If (degree >= optifyeddegree) Then
                degree = optifyeddegree
            End If
            If (language = "ru") Then
                output(days) = output(days) & "Ежедневный приход: " & degree & vbNewLine
            Else
                output(days) = output(days) & "Everyday bank bonus: " & degree & vbNewLine
            End If
            gold1 = gold1 + guildgold
            If (language = "ru") Then
                output(days) = output(days) & "Прибыль с гильдии: " & guildgold & vbNewLine
            Else
                output(days) = output(days) & "Guild salary: " & guildgold & vbNewLine
            End If
            If (boolscav = True) Then
                rand_scav = Int(Rnd() * 15000) + 10000
                If (language = "ru") Then
                    output(days) = output(days) & "Найдено золота (рандом): " & rand_scav & vbNewLine
                Else
                    output(days) = output(days) & "Scavenging (random): " & rand_scav & vbNewLine
                End If
            End If
            If (boolsch = True And looper = 7 And gold1 > 20000) Then
                looper = 0
                gold1 = gold1 - 20000
                If (language = "ru") Then
                    output(days) = output(days) & "Вы потратили 20000 на обучение (каждую неделю)" & vbNewLine
                Else
                    output(days) = output(days) & "You payed 20000 for education (every week)" & vbNewLine
                End If
            End If
            gold1 = gold1 + degree + rand_scav
            If (hoard_type = 2 And gethoard = False And degree >= 500000) Then
                gold1 = gold1 - 500000
                gethoard = True
                If (language = "ru") Then
                    output(days) = output(days) & "Вы приобрели сокровищницу без потери золота (за счет ежедневного бонуса)" & vbNewLine
                Else
                    output(days) = output(days) & "You got a personal hoard without gold missing (everyday bank bonus)" & vbNewLine
                End If
            End If
            If (gold1 >= 50000000 And gethoard = False) Then
                If (language = "ru") Then
                    ConsoleOut("Выход из функции: количество золота не умещается в банке, а сокровищница не приобретена" & vbNewLine)
                Else
                    ConsoleOut("Function exit: your gold is not fit into bank and personal hoard is not buyed" & vbNewLine)
                End If
                Exit Do
            End If
            If (language = "ru") Then
                output(days) = output(days) & "Собрано золота: " & gold1 & vbNewLine
            Else
                output(days) = output(days) & "Gold collected: " & gold1 & vbNewLine
            End If
        Loop
        If (language = "ru") Then
            ConsoleOut("Дебаг: Функция завершена")
        Else
            ConsoleOut("Debug: Function complete")
        End If
    End Sub

    'Старт функции сбора прироста
    Public Sub GrowFunction(gold1 As Integer, gold2 As Integer, boolscav As Boolean, boolsch As Boolean, hoard_type As Integer, GD_type As Integer)
        days = 0
        Dim rand_scav As Integer = 0
        Dim degree As Integer = 0
        Dim looper As Integer = 0
        Dim optifyeddegree As Integer = 980392
        Dim gethoard As Boolean = False
        ReDim Preserve output(days)
        If (hoard_type = 1) Then
            gethoard = True
        End If
        If (language = "ru") Then
            ConsoleOut("Начата задача достижения прироста золота: > " & gold2)
        Else
            ConsoleOut("Started Function to achieve gold growth:  > " & gold2)
        End If
        Do Until degree >= gold2
            days = days + 1
            ReDim Preserve output(UBound(output) + 1)
            If (language = "ru") Then
                output(days) = output(days) & "---День " & days & "---" & vbNewLine
            Else
                output(days) = output(days) & "---Day " & days & "---" & vbNewLine
            End If
            looper = looper + 1
            degree = Math.Round(gold1 * 0.02)
            If (degree >= optifyeddegree) Then
                degree = optifyeddegree
            End If
            If (language = "ru") Then
                output(days) = output(days) & "Ежедневный приход: " & degree & vbNewLine
            Else
                output(days) = output(days) & "Everyday bank bonus: " & degree & vbNewLine
            End If
            gold1 = gold1 + guildgold
            If (language = "ru") Then
                output(days) = output(days) & "Прибыль с гильдии: " & guildgold & vbNewLine
            Else
                output(days) = output(days) & "Guild salary: " & guildgold & vbNewLine
            End If
            If (boolscav = True) Then
                rand_scav = Int(Rnd() * 15000) + 10000
                If (language = "ru") Then
                    output(days) = output(days) & "Найдено золота (рандом): " & rand_scav & vbNewLine
                Else
                    output(days) = output(days) & "Scavenging (random): " & rand_scav & vbNewLine
                End If
            End If
            If (boolsch = True And looper = 7 And gold1 > 20000) Then
                looper = 0
                gold1 = gold1 - 20000
                If (language = "ru") Then
                    output(days) = output(days) & "Вы потратили 20000 на обучение (каждую неделю)" & vbNewLine
                Else
                    output(days) = output(days) & "You payed 20000 for education (every week)" & vbNewLine
                End If
            End If
            gold1 = gold1 + degree + rand_scav
            If (hoard_type = 2 And gethoard = False And degree >= 500000) Then
                gold1 = gold1 - 500000
                gethoard = True
                If (language = "ru") Then
                    output(days) = output(days) & "Вы приобрели сокровищницу без потери золота (за счет ежедневного бонуса)" & vbNewLine
                Else
                    output(days) = output(days) & "You got a personal hoard without gold missing (everyday bank bonus)" & vbNewLine
                End If
            End If
            If (gold1 >= 50000000 And gethoard = False) Then
                If (language = "ru") Then
                    ConsoleOut("Выход из функции: количество золота не умещается в банке, а сокровищница не приобретена" & vbNewLine)
                Else
                    ConsoleOut("Function exit: your gold is not fit into bank and personal hoard is not buyed" & vbNewLine)
                End If
                Exit Do
            End If
            If (language = "ru") Then
                output(days) = output(days) & "Собрано золота: " & gold1 & vbNewLine
            Else
                output(days) = output(days) & "Gold collected: " & gold1 & vbNewLine
            End If
        Loop
        If (language = "ru") Then
            ConsoleOut("Дебаг: Функция завершена")
        Else
            ConsoleOut("Debug: Function complete")
        End If
    End Sub
#End Region
#Region "Zero Day\Debug"
    'Вывод на экран
    Public Sub ConsoleOut(Text As String)
        output(0) = output(0) & vbNewLine & Text
        checkedday = 0
        Console_out.Text = output(0)
    End Sub
    Public Sub ConsoleClear()
        If (language = "ru") Then
            output(0) = "Лог программы очищен."
        Else
            output(0) = "Log cleared."
        End If
    End Sub
#End Region
#Region "Using Buttons"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (checkedday = 0) Then
            Console_out.Text = output(0)
        Else
            checkedday = checkedday - 1
            Console_out.Text = output(checkedday)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        checkedday = 0
        Console_out.Text = output(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (checkedday = days) Then
            Console_out.Text = output(days)
        Else
            checkedday = checkedday + 1
            Console_out.Text = output(checkedday)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        checkedday = days
        Console_out.Text = output(days)
    End Sub

    Private Sub About_Button_Click(sender As Object, e As EventArgs) Handles About_Button.Click
        about.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If (debugAdenakaLabel = False) Then

            If (language = "ru") Then
                MsgBox("Что побудило тебя нажать на имя мое? Тебе не ведом страх и не терзает любопытство.")
            ElseIf (language = "en") Then
                MsgBox("What prompted you to click on my name? You should not guided by fear and tormented by curiosity.")
            Else
                MsgBox("Aware, mortal. Your next moves can create Space-time anomaly in your dimension. You be sure to have a time machine or restore point of your dimension" & vbNewLine & "Error: language var is corrupt")
            End If

        ElseIf (debugAdenakaLabel = True) Then
            MsgBox("Sorry, but ")
        Else
            MsgBox("I'll now behind you... Not turn around. You anyway not be able even a discern my silhouette.")
        End If
    End Sub
#End Region
#Region "Changing language"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (language = "ru") Then
            language = "en"
            Start_Button.Text = "Start"
            About_Button.Text = "About..."
            Button3.Text = "Русский"
            Now_in_bank_locked.Text = "How much gold in bank?"
            gold_label.Text = "How much gold needed?"
            Schooling_checker.Text = "Schooling?"
            days_needed.Text = "Days needed:"
            Label1.Text = "Hoard"
            Hoard_Check.Items(0) = "Not needed"
            Hoard_Check.Items(1) = "Have already"
            Hoard_Check.Items(2) = "Needed"
            Button4.Text = "Prev Day"
            Button5.Text = "Next Day"
            Button6.Text = "Last Day"
            Button7.Text = "First Day"
            CheckGD.Items(0) = "Gold"
            CheckGD.Items(1) = "Growth"
            guildlabel1.Text = "Guild's Name:"
            guildlabel2.Text = "Guild's Rank:"
            guildlabel3.Text = "Everyday salary"
            GuildCheck1.Items(0) = "Guard"
            GuildCheck1.Items(1) = "Scribe"
            GuildCheck1.Items(2) = "Mage"
            GuildCheck2.Items(0) = "Initiate"
            GuildCheck2.Items(1) = "Novice"
            GuildCheck2.Items(2) = "Jorneyman"
            GuildCheck2.Items(3) = "Expert"
            GuildCheck2.Items(4) = "Master"
        Else
            language = "ru"
            Start_Button.Text = "Старт"
            About_Button.Text = "О программе"
            Button3.Text = "English"
            Now_in_bank_locked.Text = "Сколько голды в банке?"
            gold_label.Text = "Сколько нужно?"
            Schooling_checker.Text = "Обучаешь?"
            days_needed.Text = "Нужно дней:"
            Label1.Text = "Сокровищница"
            Hoard_Check.Items(0) = "Не требуется"
            Hoard_Check.Items(1) = "Уже есть"
            Hoard_Check.Items(2) = "Нужно купить"
            Button4.Text = "День назад"
            Button5.Text = "День вперед"
            Button6.Text = "В самый конец"
            Button7.Text = "В самое начало"
            CheckGD.Items(0) = "Золото"
            CheckGD.Items(1) = "Прирост"
            guildlabel1.Text = "Название гильдии:"
            guildlabel2.Text = "Ранг в гильдии:"
            guildlabel3.Text = "Ежедневный доход"
            GuildCheck1.Items(0) = "Страж"
            GuildCheck1.Items(1) = "Книжник"
            GuildCheck1.Items(2) = "Маг"
            GuildCheck2.Items(0) = "Новобранец"
            GuildCheck2.Items(1) = "Новичок"
            GuildCheck2.Items(2) = "Подмастерье"
            GuildCheck2.Items(3) = "Эксперт"
            GuildCheck2.Items(4) = "Мастер"
        End If
    End Sub
#End Region
#Region "Guild"
    Public Sub GenerateGuildMoney()
        guildcon(0, 0) = 0 'default
        guildcon(0, 1) = 0
        guildcon(0, 2) = 0
        guildcon(0, 3) = 0
        guildcon(0, 4) = 0
        guildcon(0, 5) = 0
        guildcon(1, 1) = 2500
        guildcon(1, 2) = 5000
        guildcon(1, 3) = 10000
        guildcon(1, 4) = 50000
        guildcon(1, 5) = 250000
        guildcon(2, 1) = 3000
        guildcon(2, 2) = 7000
        guildcon(2, 3) = 20000
        guildcon(2, 4) = 100000
        guildcon(2, 5) = 500000
        guildcon(3, 1) = 5000
        guildcon(3, 2) = 15000
        guildcon(3, 3) = 30000
        guildcon(3, 4) = 100000
        guildcon(3, 5) = 575000
    End Sub
    Public Sub GetGuildSumm()
        If (guildvar1 <> 0 Or guildvar2 <> 0) Then
            guildgold = guildcon(guildvar1, guildvar2)
            label_guildmoney.Text = guildgold
        Else
            If (language = "ru") Then
                ConsoleOut("Ошибка: Функция GetGuildSumm была запущена без одного или обеих guildvar")
            ElseIf (language = "en") Then
                ConsoleOut("Error: GetGuildSumm function started without one or both guildvar's.")
            End If
        End If
        If (guildvar1 > 3 Or guildvar1 < 1 Or guildvar2 > 5 Or guildvar2 < 1) Then
            If (language = "ru") Then
                ConsoleOut("Ошибка: Код неисправен. (один или оба guildvar имеют неверное значение)")
            ElseIf (language = "en") Then
                ConsoleOut("Error: Code is corrupt. (one or both guildvars have invalid value)")
            End If
        End If
    End Sub
    Public Sub GuildCheck1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GuildCheck1.SelectedIndexChanged
        guildvar1 = GuildStringToInt(GuildCheck1.Text)
        If (guildvar2 <> 0) Then
            GetGuildSumm()
        End If
    End Sub
    Public Sub GuildCheck2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GuildCheck2.SelectedIndexChanged
        guildvar2 = GuildStringToInt(GuildCheck2.Text)
        If (guildvar1 <> 0) Then
            GetGuildSumm()
        End If
    End Sub
    Public Function GuildStringToInt(var As String) As Integer
        'NULL
        If (var = "") Then
            ConsoleOut("Error: Function get NULL guild. Continue")
            Return 0
        End If

        'GUILD
        If (var = "Страж" Or var = "Guard") Then
            Return 1
        End If
        If (var = "Книжник" Or var = "Scribe") Then
            Return 2
        End If
        If (var = "Маг" Or var = "Mage") Then
            Return 3
        End If

        'TITLE
        If (var = "Новобранец" Or var = "Initiate") Then
            Return 1
        End If
        If (var = "Новичок" Or var = "Novice") Then
            Return 2
        End If
        If (var = "Подмастерье" Or var = "Jorneyman") Then
            Return 3
        End If
        If (var = "Эксперт" Or var = "Expert") Then
            Return 4
        End If
        If (var = "Мастер" Or var = "Master") Then
            Return 5
        End If
        'ELSE?!
        ConsoleOut("Error: Unsuspectable var in Guild. var = " & var)
        Return 0
    End Function
#End Region
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateGuildMoney()
    End Sub
    'Schooling, EXP, Level and Player Rank in Fod (Fod_Database)
End Class
