Public Class Worker
    'прописываем свойства класса
    Public Property strFam As String
    Public Property strImya As String
    Public Property strOtch As String
    Public Property bolSex As Boolean
    Public Property strSeria As String
    Public Property strNumber As String
    Public Property strBankNum As String
    Public Property strEndDate As String
    Public Property Gender As String

    'конструктор по умолчанию
    Public Sub New()
        'инициализация полей значениями по умолчанию
        strFam = " "
        strImya = " "
        strOtch = " "
        bolSex = False
        strSeria = " "
        strNumber = " "
    End Sub

    'конструктор с параметрами
    Public Sub New(fam As String, name As String, otch As String, sex As Boolean, seria As String, number As String)
        Me.strFam = fam
        Me.strImya = name
        Me.strOtch = otch
        Me.bolSex = sex
        Me.strSeria = seria
        Me.strNumber = number
    End Sub

    'свойство, которое доступно только для чтения. Объединяет ФИО
    Public ReadOnly Property FullName As String
        Get
            Return $"{strFam} {strImya} {strOtch}"
        End Get
    End Property

    'метод, определяющий пол сотрудника на основе его отчества
    Public Sub DetermineGender()
        If strOtch.EndsWith("а") Then 'если отчество заканчивается на "а", то это женщина
            Gender = "Female"
        Else
            Gender = "Male"
        End If
    End Sub

    Public Sub AddWorker()

    End Sub
End Class




