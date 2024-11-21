
Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Бюро технической инвентаризации" ' заголовок формы
        Me.IsMdiContainer = True 'Установка формы frmMain родительской формой всего приложения


        UserName.Text = "Пользователь: " & Environment.UserName
        DateTime.Text = Date.Now.ToString("dd.MM.yyyy HH:mm:ss")
    End Sub

    'Событие нажатия кнопки "Открыть..."
    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog 'объявление диалогового окна открытия файла
        'фильтрация файлов
        openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
        openFileDialog.Title = "Открыть файл" 'заголовок окна

        'Отображение диалогового окна открытия файла
        If openFileDialog.ShowDialog = DialogResult.OK Then
            'Вывод сообщения о выбранном файле
            MessageBox.Show("Выбран файл: " & openFileDialog.FileName)
        End If
    End Sub

    'Событие нажатие кнопки "Сохранить..."
    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog 'объявление диалогового окна сохранения файла
        'фильтрацияфайлов
        saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
        saveFileDialog.Title = "Сохранить файл" 'заголовок окна

        'отображение диалогового окна сохранения файла
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            'Вывод сообщения о сохраненном файле
            MessageBox.Show("Файл сохранен: " & saveFileDialog.FileName)
        End If
    End Sub

    'Событие наличие/отсутствие галочки "Стандартная"
    Private Sub СтандартнаяToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СтандартнаяToolStripMenuItem.Click
        'Изменение видимости панели инструементов
        ToolStrip1.Visible = Not ToolStrip1.Visible

        'Изменение состояния кнопки "Стандартная"
        ПанельИнструментовToolStripMenuItem.Checked = ToolStrip1.Visible
    End Sub

    'Событие наличие/отсутствие галочки "Строка состояния"
    Private Sub СтрокаСостоянияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СтрокаСостоянияToolStripMenuItem.Click
        'Изменение видимости строки состояния
        StatusStrip1.Visible = Not StatusStrip1.Visible

        'изменение состояния кнопки "Строка состояния"
        СтрокаСостоянияToolStripMenuItem.Checked = StatusStrip1.Visible
    End Sub

    'Событие нажатия кнопки "Шрифт..."
    Private Sub ШрифтToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ШрифтToolStripMenuItem.Click
        Dim fontDialog As New FontDialog 'объявление диалогового окна выбора шрифта

        'отображение диалогового окна выбора шрифта
        If fontDialog.ShowDialog = DialogResult.OK Then
            'вывод сообщения о выбранном шрифте
            MessageBox.Show("Выбран шрифт: " & fontDialog.Font.ToString)
        End If
    End Sub

    'Событие нажатия кнопки "Цвет..."
    Private Sub ЦветToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЦветToolStripMenuItem.Click
        Dim colorDialog As New ColorDialog 'объявление диалогового окна выбора шрифта

        'отображение диалогового окна выбора цвета
        If colorDialog.ShowDialog = DialogResult.OK Then
            'вывод сообщени о выбранном цвете
            MessageBox.Show("Выбран цвет: " & colorDialog.Color.ToString)
        End If
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        'объявление диалогового окна закрытия программы с подтверждением
        Dim Exit_programm = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'обработка выбранного пользователем действия
        If Exit_programm = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'fggfgf
End Class
