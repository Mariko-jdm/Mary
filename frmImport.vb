Public Class frmImport
    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Импорт данных"
    End Sub

    'событие нажатие кнопки выбора файла
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog 'объявление диалогового окна открытия файла
        'фильтрация файлов
        openFileDialog.Filter = "Базы данных (*.accdb)|*.accdb|Все файлы (*.*)|*.*"
        openFileDialog.Title = "Открыть файл" 'заголовок окна

        'Отображение диалогового окна открытия файла
        If openFileDialog.ShowDialog = DialogResult.OK Then
            'присвоение выбранного пути элементу TextBox1
            TextBox1.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class


