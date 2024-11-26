<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListWorkers
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListWorkers))
        WorkersCount = New Label()
        HScrollBar1 = New HScrollBar()
        VScrollBar1 = New VScrollBar()
        btnAdd = New Button()
        btnDelete = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtSurname = New TextBox()
        txtName = New TextBox()
        txtMiddleName = New TextBox()
        PassportSeries = New TextBox()
        PassportNum = New TextBox()
        bankNum = New TextBox()
        endDate = New TextBox()
        Accrual = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Button1 = New Button()
        Label14 = New Label()
        btnSave = New Button()
        btnExit = New Button()
        btnLockPersonalData = New Button()
        btnLockBankData = New Button()
        TreeView1 = New TreeView()
        ImageList1 = New ImageList(components)
        SuspendLayout()
        ' 
        ' WorkersCount
        ' 
        WorkersCount.AutoSize = True
        WorkersCount.Location = New Point(23, 26)
        WorkersCount.Name = "WorkersCount"
        WorkersCount.Size = New Size(121, 15)
        WorkersCount.TabIndex = 0
        WorkersCount.Text = "Сотрудники (Всего: )"
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(20, 428)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(299, 17)
        HScrollBar1.TabIndex = 2
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(317, 44)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(17, 401)
        VScrollBar1.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.ImageAlign = ContentAlignment.MiddleLeft
        btnAdd.Location = New Point(23, 451)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 26)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Добавить..."
        btnAdd.TextAlign = ContentAlignment.MiddleRight
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(123, 450)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(97, 26)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Удалить"
        btnDelete.TextAlign = ContentAlignment.MiddleRight
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(378, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 15)
        Label2.TabIndex = 6
        Label2.Text = "Персональные данные"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(378, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 7
        Label3.Text = "Фамилия"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(378, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 8
        Label4.Text = "Имя"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(378, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 9
        Label5.Text = "Отчество"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(459, 77)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(213, 23)
        txtSurname.TabIndex = 10
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(459, 106)
        txtName.Name = "txtName"
        txtName.Size = New Size(213, 23)
        txtName.TabIndex = 11
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(459, 135)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(213, 23)
        txtMiddleName.TabIndex = 12
        ' 
        ' PassportSeries
        ' 
        PassportSeries.Location = New Point(445, 212)
        PassportSeries.Name = "PassportSeries"
        PassportSeries.Size = New Size(64, 23)
        PassportSeries.TabIndex = 13
        ' 
        ' PassportNum
        ' 
        PassportNum.Location = New Point(581, 212)
        PassportNum.Name = "PassportNum"
        PassportNum.Size = New Size(70, 23)
        PassportNum.TabIndex = 14
        ' 
        ' bankNum
        ' 
        bankNum.Location = New Point(538, 288)
        bankNum.Name = "bankNum"
        bankNum.Size = New Size(134, 23)
        bankNum.TabIndex = 15
        ' 
        ' endDate
        ' 
        endDate.Location = New Point(538, 319)
        endDate.Name = "endDate"
        endDate.Size = New Size(134, 23)
        endDate.TabIndex = 16
        ' 
        ' Accrual
        ' 
        Accrual.Location = New Point(568, 410)
        Accrual.Name = "Accrual"
        Accrual.Size = New Size(83, 23)
        Accrual.TabIndex = 17
        Accrual.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(378, 185)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 15)
        Label6.TabIndex = 18
        Label6.Text = "Паспортные данные"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(398, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 19
        Label7.Text = "Серия"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(530, 215)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 20
        Label8.Text = "Номер"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(378, 262)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 15)
        Label9.TabIndex = 21
        Label9.Text = "Банковская карта"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(398, 291)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 15)
        Label10.TabIndex = 22
        Label10.Text = "Номер счета"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(398, 319)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 15)
        Label11.TabIndex = 23
        Label11.Text = "Срок действия"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(378, 369)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 15)
        Label12.TabIndex = 24
        Label12.Text = "Начислено"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(378, 413)
        Label13.Name = "Label13"
        Label13.Size = New Size(181, 15)
        Label13.TabIndex = 25
        Label13.Text = "Сумма последнего начисления"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(568, 381)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 23)
        Button1.TabIndex = 26
        Button1.Text = "Все начисления..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(655, 413)
        Label14.Name = "Label14"
        Label14.Size = New Size(30, 15)
        Label14.TabIndex = 27
        Label14.Text = "руб."
        ' 
        ' btnSave
        ' 
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(504, 452)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(92, 25)
        btnSave.TabIndex = 28
        btnSave.Text = "Сохранить"
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(602, 451)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(92, 25)
        btnExit.TabIndex = 29
        btnExit.Text = "Выход"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLockPersonalData
        ' 
        btnLockPersonalData.Image = CType(resources.GetObject("btnLockPersonalData.Image"), Image)
        btnLockPersonalData.Location = New Point(340, 135)
        btnLockPersonalData.Name = "btnLockPersonalData"
        btnLockPersonalData.Size = New Size(24, 23)
        btnLockPersonalData.TabIndex = 30
        btnLockPersonalData.UseVisualStyleBackColor = True
        ' 
        ' btnLockBankData
        ' 
        btnLockBankData.Image = CType(resources.GetObject("btnLockBankData.Image"), Image)
        btnLockBankData.Location = New Point(340, 291)
        btnLockBankData.Name = "btnLockBankData"
        btnLockBankData.Size = New Size(24, 23)
        btnLockBankData.TabIndex = 32
        btnLockBankData.UseVisualStyleBackColor = True
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(20, 44)
        TreeView1.Name = "TreeView1"
        TreeView1.Size = New Size(299, 384)
        TreeView1.TabIndex = 33
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "male")
        ImageList1.Images.SetKeyName(1, "female")
        ImageList1.Images.SetKeyName(2, "edit")
        ' 
        ' frmListWorkers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 489)
        Controls.Add(TreeView1)
        Controls.Add(btnLockBankData)
        Controls.Add(btnLockPersonalData)
        Controls.Add(btnExit)
        Controls.Add(btnSave)
        Controls.Add(Label14)
        Controls.Add(Button1)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Accrual)
        Controls.Add(endDate)
        Controls.Add(bankNum)
        Controls.Add(PassportNum)
        Controls.Add(PassportSeries)
        Controls.Add(txtMiddleName)
        Controls.Add(txtName)
        Controls.Add(txtSurname)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(VScrollBar1)
        Controls.Add(HScrollBar1)
        Controls.Add(WorkersCount)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmListWorkers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Сотрудники"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WorkersCount As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents PassportSeries As TextBox
    Friend WithEvents PassportNum As TextBox
    Friend WithEvents bankNum As TextBox
    Friend WithEvents endDate As TextBox
    Friend WithEvents Accrual As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLockPersonalData As Button
    Friend WithEvents btnLockBankData As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ImageList1 As ImageList
End Class
