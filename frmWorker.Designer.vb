<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorker))
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        endDate = New TextBox()
        bankNum = New TextBox()
        PassportNum = New TextBox()
        PassportSeries = New TextBox()
        txtMiddleName = New TextBox()
        txtName = New TextBox()
        txtSurname = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnAdd = New Button()
        btnEscape = New Button()
        SuspendLayout()
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(53, 297)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 15)
        Label11.TabIndex = 40
        Label11.Text = "Срок действия"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(53, 269)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 15)
        Label10.TabIndex = 39
        Label10.Text = "Номер счета"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(33, 240)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 15)
        Label9.TabIndex = 38
        Label9.Text = "Банковская карта"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(185, 193)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 37
        Label8.Text = "Номер"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 193)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 36
        Label7.Text = "Серия"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 163)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 15)
        Label6.TabIndex = 35
        Label6.Text = "Паспортные данные"
        ' 
        ' endDate
        ' 
        endDate.Location = New Point(175, 297)
        endDate.Name = "endDate"
        endDate.Size = New Size(152, 23)
        endDate.TabIndex = 34
        ' 
        ' bankNum
        ' 
        bankNum.Location = New Point(175, 266)
        bankNum.Name = "bankNum"
        bankNum.Size = New Size(152, 23)
        bankNum.TabIndex = 33
        ' 
        ' PassportNum
        ' 
        PassportNum.Location = New Point(236, 190)
        PassportNum.Name = "PassportNum"
        PassportNum.Size = New Size(91, 23)
        PassportNum.TabIndex = 32
        ' 
        ' PassportSeries
        ' 
        PassportSeries.Location = New Point(100, 190)
        PassportSeries.Name = "PassportSeries"
        PassportSeries.Size = New Size(64, 23)
        PassportSeries.TabIndex = 31
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(114, 113)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(228, 23)
        txtMiddleName.TabIndex = 30
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(114, 84)
        txtName.Name = "txtName"
        txtName.Size = New Size(228, 23)
        txtName.TabIndex = 29
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(114, 55)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(228, 23)
        txtSurname.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 27
        Label5.Text = "Отчество"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 26
        Label4.Text = "Имя"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 25
        Label3.Text = "Фамилия"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 15)
        Label2.TabIndex = 24
        Label2.Text = "Персональные данные"
        ' 
        ' btnAdd
        ' 
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.ImageAlign = ContentAlignment.MiddleLeft
        btnAdd.Location = New Point(168, 345)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 26)
        btnAdd.TabIndex = 41
        btnAdd.Text = "Добавить..."
        btnAdd.TextAlign = ContentAlignment.MiddleRight
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEscape
        ' 
        btnEscape.Image = CType(resources.GetObject("btnEscape.Image"), Image)
        btnEscape.ImageAlign = ContentAlignment.MiddleLeft
        btnEscape.Location = New Point(268, 345)
        btnEscape.Name = "btnEscape"
        btnEscape.Size = New Size(97, 26)
        btnEscape.TabIndex = 42
        btnEscape.Text = "Отмена"
        btnEscape.TextAlign = ContentAlignment.MiddleRight
        btnEscape.UseVisualStyleBackColor = True
        ' 
        ' frmWorker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(377, 377)
        Controls.Add(btnEscape)
        Controls.Add(btnAdd)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
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
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmWorker"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Новый сотрудник"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents endDate As TextBox
    Friend WithEvents bankNum As TextBox
    Friend WithEvents PassportNum As TextBox
    Friend WithEvents PassportSeries As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEscape As Button
End Class
