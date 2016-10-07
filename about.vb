Public Class about

    Public language = "ru"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (language = "ru") Then
            language = "en"
            RichTextBox1.Text = "This program will show you how many days you needed for reaching entered gold var." & vbNewLine & "This program give you approximate numbers and they may differ from those in game" & vbNewLine & vbNewLine & "License: by yourself, freeware" & vbNewLine & "Program can be used as is." & vbNewLine & "Program not have any malicious or ad code." & vbNewLine & "Program not for sale." & vbNewLine & vbNewLine & "Creator\Coder : Adenaka" & vbNewLine & vbNewLine & "23 september 2016"
            Button2.Text = "Русский"
        Else
            language = "ru"
            RichTextBox1.Text = "Программа для рассчитывания дней на то, чтобы получить введенную сумму золота." & vbNewLine & "Программа выдает лишь приблизительные числа и они могут отличаться от тех, что в игре" & vbNewLine & vbNewLine & "Лицензия: by yourself, freeware" & vbNewLine & "Программа используется как есть (as is)." & vbNewLine & "Не содержит вредоносного или рекламного кода." & vbNewLine & "Не подлежит продаже." & vbNewLine & vbNewLine & "Создатель\ Кодер : Adenaka" & vbNewLine & vbNewLine & "23 сентября 2016"
            Button2.Text = "English"
        End If
    End Sub
End Class