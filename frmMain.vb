
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True 'Установка формы frmMain родительской формой всего приложения

        ToolStrip1.Visible = False
        MenuStrip1.Visible = False
        StatusStrip1.Visible = False

        Dim frmLogin As New frmLogin()
        If frmLogin.ShowDialog() = DialogResult.OK Then
            frmLogin.Close()
            Date_and_Time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")
            Timer1.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Date_and_Time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")
    End Sub

    'Событие нажатия кнопки "Открыть..."
    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog 'объявление диалогового окна открытия файла
        'фильтрация файлов
        openFileDialog.Filter = "Все файлы (*.*)|*.*"
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
        saveFileDialog.Filter = "Все файлы (*.*)|*.*"
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

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        Dim frmAbout As New frmAbout()
        frmAbout.ShowDialog()
    End Sub

    Private Sub ИмпортToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИмпортToolStripMenuItem.Click
        Dim frmImport As New frmImport()
        frmImport.ShowDialog()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        Dim frmListWorkers As New frmListWorkers()
        frmListWorkers.ShowDialog()
    End Sub

    Private Sub ДобавитьЗаписьToolStripButton_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripButton.Click
        Dim frmWorker As New frmWorker()
        frmWorker.ShowDialog()
    End Sub

    Private Sub ИзменитьЗаписьToolStripButton_Click(sender As Object, e As EventArgs) Handles ИзменитьЗаписьToolStripButton.Click
        Dim frmListWorkers As New frmListWorkers()
        frmListWorkers.ShowDialog()
    End Sub

    Private Sub УдалитьЗаписьToolStripButton_Click(sender As Object, e As EventArgs) Handles УдалитьЗаписьToolStripButton.Click
        Dim frmListWorkers As New frmListWorkers()
        frmListWorkers.ShowDialog()
    End Sub
End Class
