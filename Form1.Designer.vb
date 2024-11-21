<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        MenuStrip1 = New MenuStrip()
        ФайлToolStripMenuItem = New ToolStripMenuItem()
        ОткрытьToolStripMenuItem = New ToolStripMenuItem()
        СохранитьToolStripMenuItem = New ToolStripMenuItem()
        ВыходToolStripMenuItem = New ToolStripMenuItem()
        ПравкаToolStripMenuItem = New ToolStripMenuItem()
        ВидToolStripMenuItem = New ToolStripMenuItem()
        ПанельИнструментовToolStripMenuItem = New ToolStripMenuItem()
        СтандартнаяToolStripMenuItem = New ToolStripMenuItem()
        СтрокаСостоянияToolStripMenuItem = New ToolStripMenuItem()
        ФорматToolStripMenuItem = New ToolStripMenuItem()
        ШрифтToolStripMenuItem = New ToolStripMenuItem()
        ЦветToolStripMenuItem = New ToolStripMenuItem()
        СправочникиToolStripMenuItem = New ToolStripMenuItem()
        СправкаToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        СоздатьToolStripButton = New ToolStripButton()
        ОткрытьToolStripButton = New ToolStripButton()
        СохранитьToolStripButton = New ToolStripButton()
        ПечатьToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        ВырезатьToolStripButton = New ToolStripButton()
        КопироватьToolStripButton = New ToolStripButton()
        ВставитьToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        СправкаToolStripButton = New ToolStripButton()
        StatusStrip1 = New StatusStrip()
        DateTime = New ToolStripStatusLabel()
        UserName = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ФайлToolStripMenuItem, ПравкаToolStripMenuItem, ВидToolStripMenuItem, ФорматToolStripMenuItem, СправочникиToolStripMenuItem, СправкаToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(905, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ФайлToolStripMenuItem
        ' 
        ФайлToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ОткрытьToolStripMenuItem, СохранитьToolStripMenuItem, ВыходToolStripMenuItem})
        ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        ФайлToolStripMenuItem.Size = New Size(51, 20)
        ФайлToolStripMenuItem.Text = " Файл"
        ' 
        ' ОткрытьToolStripMenuItem
        ' 
        ОткрытьToolStripMenuItem.Image = CType(resources.GetObject("ОткрытьToolStripMenuItem.Image"), Image)
        ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        ОткрытьToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ОткрытьToolStripMenuItem.Size = New Size(188, 22)
        ОткрытьToolStripMenuItem.Text = "Открыть..."
        ' 
        ' СохранитьToolStripMenuItem
        ' 
        СохранитьToolStripMenuItem.Image = CType(resources.GetObject("СохранитьToolStripMenuItem.Image"), Image)
        СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        СохранитьToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F2
        СохранитьToolStripMenuItem.Size = New Size(188, 22)
        СохранитьToolStripMenuItem.Text = "Сохранить..."
        ' 
        ' ВыходToolStripMenuItem
        ' 
        ВыходToolStripMenuItem.Image = CType(resources.GetObject("ВыходToolStripMenuItem.Image"), Image)
        ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        ВыходToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F3
        ВыходToolStripMenuItem.Size = New Size(188, 22)
        ВыходToolStripMenuItem.Text = "Выход"
        ' 
        ' ПравкаToolStripMenuItem
        ' 
        ПравкаToolStripMenuItem.Name = "ПравкаToolStripMenuItem"
        ПравкаToolStripMenuItem.Size = New Size(59, 20)
        ПравкаToolStripMenuItem.Text = "Правка"
        ' 
        ' ВидToolStripMenuItem
        ' 
        ВидToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ПанельИнструментовToolStripMenuItem, СтрокаСостоянияToolStripMenuItem})
        ВидToolStripMenuItem.Name = "ВидToolStripMenuItem"
        ВидToolStripMenuItem.Size = New Size(39, 20)
        ВидToolStripMenuItem.Text = "Вид"
        ' 
        ' ПанельИнструментовToolStripMenuItem
        ' 
        ПанельИнструментовToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {СтандартнаяToolStripMenuItem})
        ПанельИнструментовToolStripMenuItem.Image = CType(resources.GetObject("ПанельИнструментовToolStripMenuItem.Image"), Image)
        ПанельИнструментовToolStripMenuItem.Name = "ПанельИнструментовToolStripMenuItem"
        ПанельИнструментовToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F4
        ПанельИнструментовToolStripMenuItem.Size = New Size(242, 22)
        ПанельИнструментовToolStripMenuItem.Text = "Панель инструментов"
        ' 
        ' СтандартнаяToolStripMenuItem
        ' 
        СтандартнаяToolStripMenuItem.Checked = True
        СтандартнаяToolStripMenuItem.CheckState = CheckState.Checked
        СтандартнаяToolStripMenuItem.Name = "СтандартнаяToolStripMenuItem"
        СтандартнаяToolStripMenuItem.Size = New Size(180, 22)
        СтандартнаяToolStripMenuItem.Text = "Стандартная"
        ' 
        ' СтрокаСостоянияToolStripMenuItem
        ' 
        СтрокаСостоянияToolStripMenuItem.Checked = True
        СтрокаСостоянияToolStripMenuItem.CheckState = CheckState.Checked
        СтрокаСостоянияToolStripMenuItem.Image = CType(resources.GetObject("СтрокаСостоянияToolStripMenuItem.Image"), Image)
        СтрокаСостоянияToolStripMenuItem.Name = "СтрокаСостоянияToolStripMenuItem"
        СтрокаСостоянияToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F5
        СтрокаСостоянияToolStripMenuItem.Size = New Size(242, 22)
        СтрокаСостоянияToolStripMenuItem.Text = "Строка состояния"
        ' 
        ' ФорматToolStripMenuItem
        ' 
        ФорматToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ШрифтToolStripMenuItem, ЦветToolStripMenuItem})
        ФорматToolStripMenuItem.Name = "ФорматToolStripMenuItem"
        ФорматToolStripMenuItem.Size = New Size(62, 20)
        ФорматToolStripMenuItem.Text = "Формат"
        ' 
        ' ШрифтToolStripMenuItem
        ' 
        ШрифтToolStripMenuItem.Image = CType(resources.GetObject("ШрифтToolStripMenuItem.Image"), Image)
        ШрифтToolStripMenuItem.Name = "ШрифтToolStripMenuItem"
        ШрифтToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F6
        ШрифтToolStripMenuItem.Size = New Size(180, 22)
        ШрифтToolStripMenuItem.Text = "Шрифт..."
        ' 
        ' ЦветToolStripMenuItem
        ' 
        ЦветToolStripMenuItem.Image = CType(resources.GetObject("ЦветToolStripMenuItem.Image"), Image)
        ЦветToolStripMenuItem.Name = "ЦветToolStripMenuItem"
        ЦветToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F7
        ЦветToolStripMenuItem.Size = New Size(180, 22)
        ЦветToolStripMenuItem.Text = "Цвет..."
        ' 
        ' СправочникиToolStripMenuItem
        ' 
        СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        СправочникиToolStripMenuItem.Size = New Size(94, 20)
        СправочникиToolStripMenuItem.Text = "Справочники"
        ' 
        ' СправкаToolStripMenuItem
        ' 
        СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        СправкаToolStripMenuItem.Size = New Size(65, 20)
        СправкаToolStripMenuItem.Text = "Справка"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {СоздатьToolStripButton, ОткрытьToolStripButton, СохранитьToolStripButton, ПечатьToolStripButton, toolStripSeparator, ВырезатьToolStripButton, КопироватьToolStripButton, ВставитьToolStripButton, toolStripSeparator1, СправкаToolStripButton})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(905, 25)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' СоздатьToolStripButton
        ' 
        СоздатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        СоздатьToolStripButton.Image = CType(resources.GetObject("СоздатьToolStripButton.Image"), Image)
        СоздатьToolStripButton.ImageTransparentColor = Color.Magenta
        СоздатьToolStripButton.Name = "СоздатьToolStripButton"
        СоздатьToolStripButton.Size = New Size(23, 22)
        СоздатьToolStripButton.Text = "&Создать"
        ' 
        ' ОткрытьToolStripButton
        ' 
        ОткрытьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ОткрытьToolStripButton.Image = CType(resources.GetObject("ОткрытьToolStripButton.Image"), Image)
        ОткрытьToolStripButton.ImageTransparentColor = Color.Magenta
        ОткрытьToolStripButton.Name = "ОткрытьToolStripButton"
        ОткрытьToolStripButton.Size = New Size(23, 22)
        ОткрытьToolStripButton.Text = "&Открыть"
        ' 
        ' СохранитьToolStripButton
        ' 
        СохранитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        СохранитьToolStripButton.Image = CType(resources.GetObject("СохранитьToolStripButton.Image"), Image)
        СохранитьToolStripButton.ImageTransparentColor = Color.Magenta
        СохранитьToolStripButton.Name = "СохранитьToolStripButton"
        СохранитьToolStripButton.Size = New Size(23, 22)
        СохранитьToolStripButton.Text = "&Сохранить"
        ' 
        ' ПечатьToolStripButton
        ' 
        ПечатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ПечатьToolStripButton.Image = CType(resources.GetObject("ПечатьToolStripButton.Image"), Image)
        ПечатьToolStripButton.ImageTransparentColor = Color.Magenta
        ПечатьToolStripButton.Name = "ПечатьToolStripButton"
        ПечатьToolStripButton.Size = New Size(23, 22)
        ПечатьToolStripButton.Text = "&Печать"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 25)
        ' 
        ' ВырезатьToolStripButton
        ' 
        ВырезатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ВырезатьToolStripButton.Image = CType(resources.GetObject("ВырезатьToolStripButton.Image"), Image)
        ВырезатьToolStripButton.ImageTransparentColor = Color.Magenta
        ВырезатьToolStripButton.Name = "ВырезатьToolStripButton"
        ВырезатьToolStripButton.Size = New Size(23, 22)
        ВырезатьToolStripButton.Text = "Вы&резать"
        ' 
        ' КопироватьToolStripButton
        ' 
        КопироватьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        КопироватьToolStripButton.Image = CType(resources.GetObject("КопироватьToolStripButton.Image"), Image)
        КопироватьToolStripButton.ImageTransparentColor = Color.Magenta
        КопироватьToolStripButton.Name = "КопироватьToolStripButton"
        КопироватьToolStripButton.Size = New Size(23, 22)
        КопироватьToolStripButton.Text = "&Копировать"
        ' 
        ' ВставитьToolStripButton
        ' 
        ВставитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ВставитьToolStripButton.Image = CType(resources.GetObject("ВставитьToolStripButton.Image"), Image)
        ВставитьToolStripButton.ImageTransparentColor = Color.Magenta
        ВставитьToolStripButton.Name = "ВставитьToolStripButton"
        ВставитьToolStripButton.Size = New Size(23, 22)
        ВставитьToolStripButton.Text = "&Вставить"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' СправкаToolStripButton
        ' 
        СправкаToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        СправкаToolStripButton.Image = CType(resources.GetObject("СправкаToolStripButton.Image"), Image)
        СправкаToolStripButton.ImageTransparentColor = Color.Magenta
        СправкаToolStripButton.Name = "СправкаToolStripButton"
        СправкаToolStripButton.Size = New Size(23, 22)
        СправкаToolStripButton.Text = "С&правка"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {DateTime, UserName, ToolStripProgressBar1})
        StatusStrip1.Location = New Point(0, 526)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(905, 22)
        StatusStrip1.TabIndex = 4
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' DateTime
        ' 
        DateTime.Name = "DateTime"
        DateTime.Size = New Size(79, 17)
        DateTime.Text = "Дата и время"
        ' 
        ' UserName
        ' 
        UserName.Name = "UserName"
        UserName.Size = New Size(109, 17)
        UserName.Text = "Имя пользователя"
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(100, 16)
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(905, 548)
        Controls.Add(StatusStrip1)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПравкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВидToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФорматToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправочникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ОткрытьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DateTime As ToolStripStatusLabel
    Friend WithEvents UserName As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПанельИнструментовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СтандартнаяToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СтрокаСостоянияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ШрифтToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЦветToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СоздатьToolStripButton As ToolStripButton
    Friend WithEvents ОткрытьToolStripButton As ToolStripButton
    Friend WithEvents СохранитьToolStripButton As ToolStripButton
    Friend WithEvents ПечатьToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ВырезатьToolStripButton As ToolStripButton
    Friend WithEvents КопироватьToolStripButton As ToolStripButton
    Friend WithEvents ВставитьToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents СправкаToolStripButton As ToolStripButton

End Class
