<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Scavenge_checker = New System.Windows.Forms.CheckBox()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.About_Button = New System.Windows.Forms.Button()
        Me.Schooling_checker = New System.Windows.Forms.CheckBox()
        Me.Gold_in_bank = New System.Windows.Forms.TextBox()
        Me.gold_var = New System.Windows.Forms.TextBox()
        Me.Console_out = New System.Windows.Forms.RichTextBox()
        Me.gold_label = New System.Windows.Forms.Label()
        Me.Now_in_bank_locked = New System.Windows.Forms.Label()
        Me.days_needed = New System.Windows.Forms.Label()
        Me.days_label = New System.Windows.Forms.Label()
        Me.Hoard_Check = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CheckGD = New System.Windows.Forms.ComboBox()
        Me.ControlTab = New System.Windows.Forms.TabControl()
        Me.TaskMenu = New System.Windows.Forms.TabPage()
        Me.AdvMenu = New System.Windows.Forms.TabPage()
        Me.GuildMenu = New System.Windows.Forms.TabPage()
        Me.label_guildmoney = New System.Windows.Forms.Label()
        Me.guildlabel3 = New System.Windows.Forms.Label()
        Me.GuildCheck2 = New System.Windows.Forms.ComboBox()
        Me.guildlabel2 = New System.Windows.Forms.Label()
        Me.guildlabel1 = New System.Windows.Forms.Label()
        Me.GuildCheck1 = New System.Windows.Forms.ComboBox()
        Me.BonusMenu = New System.Windows.Forms.TabPage()
        Me.ResultMenu = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ControlTab.SuspendLayout()
        Me.TaskMenu.SuspendLayout()
        Me.AdvMenu.SuspendLayout()
        Me.GuildMenu.SuspendLayout()
        Me.ResultMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Scavenge_checker
        '
        Me.Scavenge_checker.AutoSize = True
        Me.Scavenge_checker.Location = New System.Drawing.Point(22, 20)
        Me.Scavenge_checker.Name = "Scavenge_checker"
        Me.Scavenge_checker.Size = New System.Drawing.Size(81, 17)
        Me.Scavenge_checker.TabIndex = 0
        Me.Scavenge_checker.Text = "Scavenge?"
        Me.Scavenge_checker.UseVisualStyleBackColor = True
        '
        'Start_Button
        '
        Me.Start_Button.Location = New System.Drawing.Point(499, 297)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(133, 46)
        Me.Start_Button.TabIndex = 1
        Me.Start_Button.Text = "Старт"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'About_Button
        '
        Me.About_Button.Location = New System.Drawing.Point(640, 297)
        Me.About_Button.Name = "About_Button"
        Me.About_Button.Size = New System.Drawing.Size(133, 46)
        Me.About_Button.TabIndex = 2
        Me.About_Button.Text = "О программе"
        Me.About_Button.UseVisualStyleBackColor = True
        '
        'Schooling_checker
        '
        Me.Schooling_checker.AutoSize = True
        Me.Schooling_checker.Location = New System.Drawing.Point(22, 43)
        Me.Schooling_checker.Name = "Schooling_checker"
        Me.Schooling_checker.Size = New System.Drawing.Size(82, 17)
        Me.Schooling_checker.TabIndex = 3
        Me.Schooling_checker.Text = "Обучаешь?"
        Me.Schooling_checker.UseVisualStyleBackColor = True
        '
        'Gold_in_bank
        '
        Me.Gold_in_bank.Location = New System.Drawing.Point(159, 53)
        Me.Gold_in_bank.Name = "Gold_in_bank"
        Me.Gold_in_bank.Size = New System.Drawing.Size(115, 20)
        Me.Gold_in_bank.TabIndex = 4
        Me.Gold_in_bank.Text = "0"
        '
        'gold_var
        '
        Me.gold_var.Location = New System.Drawing.Point(159, 82)
        Me.gold_var.Name = "gold_var"
        Me.gold_var.Size = New System.Drawing.Size(115, 20)
        Me.gold_var.TabIndex = 5
        Me.gold_var.Text = "0"
        '
        'Console_out
        '
        Me.Console_out.Enabled = False
        Me.Console_out.Location = New System.Drawing.Point(13, 297)
        Me.Console_out.Name = "Console_out"
        Me.Console_out.Size = New System.Drawing.Size(278, 150)
        Me.Console_out.TabIndex = 6
        Me.Console_out.Text = "Используйте кнопки после завершения функции" & Global.Microsoft.VisualBasic.ChrW(10) & "Use buttons after function ending"
        '
        'gold_label
        '
        Me.gold_label.AutoSize = True
        Me.gold_label.Location = New System.Drawing.Point(19, 85)
        Me.gold_label.Name = "gold_label"
        Me.gold_label.Size = New System.Drawing.Size(90, 13)
        Me.gold_label.TabIndex = 7
        Me.gold_label.Text = "Сколько нужно?"
        '
        'Now_in_bank_locked
        '
        Me.Now_in_bank_locked.AutoSize = True
        Me.Now_in_bank_locked.Location = New System.Drawing.Point(19, 53)
        Me.Now_in_bank_locked.Name = "Now_in_bank_locked"
        Me.Now_in_bank_locked.Size = New System.Drawing.Size(132, 13)
        Me.Now_in_bank_locked.TabIndex = 8
        Me.Now_in_bank_locked.Text = "Сколько голды в банке?"
        '
        'days_needed
        '
        Me.days_needed.AutoSize = True
        Me.days_needed.Location = New System.Drawing.Point(17, 13)
        Me.days_needed.Name = "days_needed"
        Me.days_needed.Size = New System.Drawing.Size(73, 13)
        Me.days_needed.TabIndex = 9
        Me.days_needed.Text = "Нужно дней: "
        '
        'days_label
        '
        Me.days_label.AutoSize = True
        Me.days_label.Location = New System.Drawing.Point(96, 13)
        Me.days_label.Name = "days_label"
        Me.days_label.Size = New System.Drawing.Size(16, 13)
        Me.days_label.TabIndex = 10
        Me.days_label.Text = "..."
        '
        'Hoard_Check
        '
        Me.Hoard_Check.FormattingEnabled = True
        Me.Hoard_Check.Items.AddRange(New Object() {"Не требуется", "Уже есть", "Нужно купить"})
        Me.Hoard_Check.Location = New System.Drawing.Point(280, 18)
        Me.Hoard_Check.Name = "Hoard_Check"
        Me.Hoard_Check.Size = New System.Drawing.Size(121, 21)
        Me.Hoard_Check.TabIndex = 13
        Me.Hoard_Check.Text = "Не требуется"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(640, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 46)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "English"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Сокровищница"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(710, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Adenaka (R)"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(297, 297)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 67)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "День назад"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(297, 380)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 67)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "День вперед"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(398, 380)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 67)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "В самый конец"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(398, 297)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 67)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "В самое начало"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'CheckGD
        '
        Me.CheckGD.FormattingEnabled = True
        Me.CheckGD.Items.AddRange(New Object() {"Золота", "Прирост"})
        Me.CheckGD.Location = New System.Drawing.Point(22, 18)
        Me.CheckGD.Name = "CheckGD"
        Me.CheckGD.Size = New System.Drawing.Size(69, 21)
        Me.CheckGD.TabIndex = 21
        Me.CheckGD.Text = "Золота"
        '
        'ControlTab
        '
        Me.ControlTab.Controls.Add(Me.TaskMenu)
        Me.ControlTab.Controls.Add(Me.AdvMenu)
        Me.ControlTab.Controls.Add(Me.GuildMenu)
        Me.ControlTab.Controls.Add(Me.BonusMenu)
        Me.ControlTab.Controls.Add(Me.ResultMenu)
        Me.ControlTab.Location = New System.Drawing.Point(13, 24)
        Me.ControlTab.Name = "ControlTab"
        Me.ControlTab.SelectedIndex = 0
        Me.ControlTab.Size = New System.Drawing.Size(760, 267)
        Me.ControlTab.TabIndex = 22
        '
        'TaskMenu
        '
        Me.TaskMenu.Controls.Add(Me.Now_in_bank_locked)
        Me.TaskMenu.Controls.Add(Me.CheckGD)
        Me.TaskMenu.Controls.Add(Me.Gold_in_bank)
        Me.TaskMenu.Controls.Add(Me.gold_label)
        Me.TaskMenu.Controls.Add(Me.gold_var)
        Me.TaskMenu.Location = New System.Drawing.Point(4, 22)
        Me.TaskMenu.Name = "TaskMenu"
        Me.TaskMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.TaskMenu.Size = New System.Drawing.Size(752, 241)
        Me.TaskMenu.TabIndex = 0
        Me.TaskMenu.Text = "Задача"
        Me.TaskMenu.UseVisualStyleBackColor = True
        '
        'AdvMenu
        '
        Me.AdvMenu.Controls.Add(Me.Scavenge_checker)
        Me.AdvMenu.Controls.Add(Me.Schooling_checker)
        Me.AdvMenu.Controls.Add(Me.Label1)
        Me.AdvMenu.Controls.Add(Me.Hoard_Check)
        Me.AdvMenu.Location = New System.Drawing.Point(4, 22)
        Me.AdvMenu.Name = "AdvMenu"
        Me.AdvMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.AdvMenu.Size = New System.Drawing.Size(752, 241)
        Me.AdvMenu.TabIndex = 1
        Me.AdvMenu.Text = "Дополнительно"
        Me.AdvMenu.UseVisualStyleBackColor = True
        '
        'GuildMenu
        '
        Me.GuildMenu.Controls.Add(Me.label_guildmoney)
        Me.GuildMenu.Controls.Add(Me.guildlabel3)
        Me.GuildMenu.Controls.Add(Me.GuildCheck2)
        Me.GuildMenu.Controls.Add(Me.guildlabel2)
        Me.GuildMenu.Controls.Add(Me.guildlabel1)
        Me.GuildMenu.Controls.Add(Me.GuildCheck1)
        Me.GuildMenu.Location = New System.Drawing.Point(4, 22)
        Me.GuildMenu.Name = "GuildMenu"
        Me.GuildMenu.Size = New System.Drawing.Size(752, 241)
        Me.GuildMenu.TabIndex = 2
        Me.GuildMenu.Text = "Гильдия"
        Me.GuildMenu.UseVisualStyleBackColor = True
        '
        'label_guildmoney
        '
        Me.label_guildmoney.AutoSize = True
        Me.label_guildmoney.Location = New System.Drawing.Point(143, 152)
        Me.label_guildmoney.Name = "label_guildmoney"
        Me.label_guildmoney.Size = New System.Drawing.Size(16, 13)
        Me.label_guildmoney.TabIndex = 6
        Me.label_guildmoney.Text = "..."
        '
        'guildlabel3
        '
        Me.guildlabel3.AutoSize = True
        Me.guildlabel3.Location = New System.Drawing.Point(18, 152)
        Me.guildlabel3.Name = "guildlabel3"
        Me.guildlabel3.Size = New System.Drawing.Size(110, 13)
        Me.guildlabel3.TabIndex = 5
        Me.guildlabel3.Text = "Ежедневный доход: "
        '
        'GuildCheck2
        '
        Me.GuildCheck2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GuildCheck2.FormattingEnabled = True
        Me.GuildCheck2.Items.AddRange(New Object() {"Новобранец", "Новичок", "Подмастерье", "Эксперт", "Мастер"})
        Me.GuildCheck2.Location = New System.Drawing.Point(143, 64)
        Me.GuildCheck2.Name = "GuildCheck2"
        Me.GuildCheck2.Size = New System.Drawing.Size(178, 21)
        Me.GuildCheck2.TabIndex = 4
        '
        'guildlabel2
        '
        Me.guildlabel2.AutoSize = True
        Me.guildlabel2.Location = New System.Drawing.Point(18, 64)
        Me.guildlabel2.Name = "guildlabel2"
        Me.guildlabel2.Size = New System.Drawing.Size(84, 13)
        Me.guildlabel2.TabIndex = 3
        Me.guildlabel2.Text = "Ранг в гильдии"
        '
        'guildlabel1
        '
        Me.guildlabel1.AutoSize = True
        Me.guildlabel1.Location = New System.Drawing.Point(18, 21)
        Me.guildlabel1.Name = "guildlabel1"
        Me.guildlabel1.Size = New System.Drawing.Size(101, 13)
        Me.guildlabel1.TabIndex = 2
        Me.guildlabel1.Text = "Название гильдии"
        '
        'GuildCheck1
        '
        Me.GuildCheck1.AutoCompleteCustomSource.AddRange(New String() {"Страж", "Книжник", "Маг"})
        Me.GuildCheck1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GuildCheck1.FormattingEnabled = True
        Me.GuildCheck1.Items.AddRange(New Object() {"Страж", "Книжник", "Маг"})
        Me.GuildCheck1.Location = New System.Drawing.Point(143, 18)
        Me.GuildCheck1.Name = "GuildCheck1"
        Me.GuildCheck1.Size = New System.Drawing.Size(178, 21)
        Me.GuildCheck1.TabIndex = 1
        '
        'BonusMenu
        '
        Me.BonusMenu.Location = New System.Drawing.Point(4, 22)
        Me.BonusMenu.Name = "BonusMenu"
        Me.BonusMenu.Size = New System.Drawing.Size(752, 241)
        Me.BonusMenu.TabIndex = 3
        Me.BonusMenu.Text = "Бонусы"
        Me.BonusMenu.UseVisualStyleBackColor = True
        '
        'ResultMenu
        '
        Me.ResultMenu.Controls.Add(Me.days_needed)
        Me.ResultMenu.Controls.Add(Me.days_label)
        Me.ResultMenu.Location = New System.Drawing.Point(4, 22)
        Me.ResultMenu.Name = "ResultMenu"
        Me.ResultMenu.Size = New System.Drawing.Size(752, 241)
        Me.ResultMenu.TabIndex = 4
        Me.ResultMenu.Text = "Результат"
        Me.ResultMenu.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(610, 434)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(94, 13)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "flightofdragons.net"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 459)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ControlTab)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Console_out)
        Me.Controls.Add(Me.About_Button)
        Me.Controls.Add(Me.Start_Button)
        Me.Name = "main"
        Me.Text = "Adenaka's Gold Helper  v.1.1 (Beg for more free time for yourself, little reptile" &
    ") "
        Me.ControlTab.ResumeLayout(False)
        Me.TaskMenu.ResumeLayout(False)
        Me.TaskMenu.PerformLayout()
        Me.AdvMenu.ResumeLayout(False)
        Me.AdvMenu.PerformLayout()
        Me.GuildMenu.ResumeLayout(False)
        Me.GuildMenu.PerformLayout()
        Me.ResultMenu.ResumeLayout(False)
        Me.ResultMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scavenge_checker As System.Windows.Forms.CheckBox
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents About_Button As System.Windows.Forms.Button
    Friend WithEvents Schooling_checker As System.Windows.Forms.CheckBox
    Friend WithEvents Gold_in_bank As System.Windows.Forms.TextBox
    Friend WithEvents gold_var As System.Windows.Forms.TextBox
    Friend WithEvents Console_out As System.Windows.Forms.RichTextBox
    Friend WithEvents gold_label As System.Windows.Forms.Label
    Friend WithEvents Now_in_bank_locked As System.Windows.Forms.Label
    Friend WithEvents days_needed As System.Windows.Forms.Label
    Friend WithEvents days_label As System.Windows.Forms.Label
    Friend WithEvents Hoard_Check As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents CheckGD As ComboBox
    Friend WithEvents ControlTab As TabControl
    Friend WithEvents TaskMenu As TabPage
    Friend WithEvents AdvMenu As TabPage
    Friend WithEvents GuildMenu As TabPage
    Friend WithEvents BonusMenu As TabPage
    Friend WithEvents ResultMenu As TabPage
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents label_guildmoney As Label
    Friend WithEvents guildlabel3 As Label
    Friend WithEvents GuildCheck2 As ComboBox
    Friend WithEvents guildlabel2 As Label
    Friend WithEvents guildlabel1 As Label
    Friend WithEvents GuildCheck1 As ComboBox
End Class
