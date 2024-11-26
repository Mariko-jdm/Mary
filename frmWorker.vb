Public Class frmWorker
    'объявление свойства
    Public Property WorkerData As Worker

    Public Sub New()
        'инициализация компонентов формы
        InitializeComponent()
        WorkerData = New Worker()
    End Sub

    'событие надатие кнопки "добавить"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'заполнение введенных данных
        WorkerData = New Worker() With {
            .strFam = txtSurname.Text,
            .strImya = txtName.Text,
            .strOtch = txtMiddleName.Text,
            .strSeria = PassportSeries.Text,
            .strNumber = PassportNum.Text,
            .strBankNum = bankNum.Text,
            .strEndDate = endDate.Text
        }

        'определение пола
        WorkerData.DetermineGender()

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    'событие нажатие кнопки "отмена"
    Private Sub btnEscape_Click(sender As Object, e As EventArgs) Handles btnEscape.Click
        Me.Close()
    End Sub

    Private Sub frmWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

