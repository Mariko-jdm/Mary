Imports System.IO
Imports System.Text.Json

Public Class frmListWorkers
    Private workers As New List(Of Worker) 'создание списка работников

    Private isPersonalDataLocked As Boolean = True
    Private isBankDataLocked As Boolean = True

    'константа для указания пути загрузки и сохранения данных о работниках
    Private Const workersFile As String = "workers.json"

    Private Sub frmListWorkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.ImageList = ImageList1

        'загрузка данных сотрудников из файла
        If File.Exists(workersFile) Then 'проверка на существование файла7
            Try 'чтение данных из файла
                Dim json As String = File.ReadAllText(workersFile) 'считывание содержимого в строковом формате
                workers = JsonSerializer.Deserialize(Of List(Of Worker))(json) 'преобразование строки в список объектов Worker
            Catch ex As Exception 'обработка исключений
                MessageBox.Show("Ошибка загрузки данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        'очистка узлов в ThreeView1
        TreeView1.Nodes.Clear()
        'проход по каждому элементу (сотруднику) коллекции workers
        For Each worker As Worker In workers
            worker.DetermineGender() 'определение гендера
            'создание узла с указанием ФИО
            Dim node As New TreeNode(worker.FullName) With {
                .Tag = worker, 'хранение ссылки на объект
                .ImageIndex = If(worker.Gender = "Male", 0, 1) 'выбор картинки в зависимости от пола
            }
            TreeView1.Nodes.Add(node) 'добавление нового узла
        Next
        'отображение количества сотрудников
        WorkersCount.Text = $"Сотрудники (Всего: {workers.Count} )"
    End Sub

    'событие нажатие кнопки "Выход"
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'блокировка/разрлокировка полей персональных данных
    Private Sub btnLockPersonalData_Click(sender As Object, e As EventArgs) Handles btnLockPersonalData.Click
        isPersonalDataLocked = Not isPersonalDataLocked
        LockPersonalData(isPersonalDataLocked)
    End Sub
    Private Sub LockPersonalData(lock As Boolean)
        txtSurname.Enabled = Not lock
        txtName.Enabled = Not lock
        txtMiddleName.Enabled = Not lock
        PassportSeries.Enabled = Not lock
        PassportNum.Enabled = Not lock
    End Sub

    'блокировка/разблокировка полей банковских данных
    Private Sub btnLockBankData_Click(sender As Object, e As EventArgs) Handles btnLockBankData.Click
        isBankDataLocked = Not isBankDataLocked
        LockBankData(isBankDataLocked)
    End Sub
    Private Sub LockBankData(lock As Boolean)
        bankNum.Enabled = Not lock
        endDate.Enabled = Not lock
    End Sub

    'Событие нажатия кнопки "Сохранить"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TreeView1.SelectedNode IsNot Nothing Then 'проверка выбран ли узел
            'извлечение объекта worker и приведение его типа к Worker
            Dim selectedWorker As Worker = CType(TreeView1.SelectedNode.Tag, Worker)
            selectedWorker.strFam = txtSurname.Text
            selectedWorker.strImya = txtName.Text
            selectedWorker.strOtch = txtMiddleName.Text
            selectedWorker.strSeria = PassportSeries.Text
            selectedWorker.strNumber = PassportNum.Text
            selectedWorker.strBankNum = bankNum.Text
            selectedWorker.strEndDate = endDate.Text
            selectedWorker.DetermineGender() 'опеределение пола

            UpdateNodes(TreeView1.SelectedNode, selectedWorker)
        End If
    End Sub

    Private Sub UpdateNodes(node As TreeNode, worker As Worker)
        'обновление узла (текста и картинки)
        node.Text = worker.FullName
        node.ImageIndex = If(worker.Gender = "Male", 0, 1)
    End Sub


    'событие нажатие кнопки "Добавить"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmWorker As New frmWorker() 'ототбражение формы для добавления сотрудника
        If frmWorker.ShowDialog() = DialogResult.OK Then
            'из формы frmWorker извлекаем объект Worker с данными сотрудника
            Dim newWorker As Worker = frmWorker.WorkerData
            workers.Add(newWorker) 'добавляем нового сотрудника в список
            'создание нового узла 
            Dim node As New TreeNode(newWorker.FullName) With {
                .Tag = newWorker,
                .ImageIndex = If(newWorker.Gender = "Male", 0, 1)
            }
            'добавление узла в TreeView1
            TreeView1.Nodes.Add(node)
            'обновление количества сотрудников
            WorkersCount.Text = $"Сотрудники (Всего: {workers.Count} )"
        End If
    End Sub

    'событие нажатия кнопки "Удалить"
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If TreeView1.SelectedNode IsNot Nothing Then 'проверка выбран ли узел
            workers.Remove(TreeView1.SelectedNode.Tag) 'извлечение объекта и последующее его удаление
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            WorkersCount.Text = $"Сотрудники (Всего: {workers.Count} )" 'обновление количества сотрудников
            ClearFields() 'очистка полей ввода
        End If
    End Sub

    'метод, очищающий все поля ввода
    Private Sub ClearFields()
        txtSurname.Clear()
        txtName.Clear()
        txtMiddleName.Clear()
        PassportSeries.Clear()
        PassportNum.Clear()
        bankNum.Clear()
        endDate.Clear()
    End Sub

    'обработка события выбора конкретного работника в TreeView
    Private Sub TreeViewWorkers_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node IsNot Nothing Then 'проверка выбран ли узел
            'извлечение объекта worker и преобразование к типу Worker
            Dim selectedWorker As Worker = CType(e.Node.Tag, Worker)
            Dim Node As New TreeNode(selectedWorker.FullName) With {
                .ImageIndex = If(selectedWorker.Gender = "Male", 2, 2)
            }
            'заполнение текстовых полей данными сотрудника
            txtSurname.Text = selectedWorker.strFam
            txtName.Text = selectedWorker.strImya
            txtMiddleName.Text = selectedWorker.strOtch
            PassportSeries.Text = selectedWorker.strSeria
            PassportNum.Text = selectedWorker.strNumber
            bankNum.Text = selectedWorker.strBankNum
            endDate.Text = selectedWorker.strEndDate
        End If
    End Sub
    'привязка изображений к TreeView1
    Public Sub linkingPhotos()
        InitializeComponent()
        'TreeView1.ImageList = ImageList1
    End Sub

    'сохранение данных работников в файл
    Private Sub SaveWorkerData()
        Try
            ' объект, который содержит настройки для сериализации jcon
            Dim options As New JsonSerializerOptions With {
                .WriteIndented = True 'форматирования для лучшей чистаемости
            }
            'список сотрудников предвращается в строку json
            Dim json As String = JsonSerializer.Serialize(workers, options)
            File.WriteAllText(workersFile, json) 'запись в файл
        Catch ex As Exception 'обработка исключения
            MessageBox.Show("Ошибка сохраненения данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmListWorkers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveWorkerData()
    End Sub
End Class






