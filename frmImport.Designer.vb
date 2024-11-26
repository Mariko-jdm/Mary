<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImport))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label6 = New Label()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton8 = New RadioButton()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 0
        Label1.Text = "Файл с данными"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 15)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(305, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(435, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 23)
        Button1.TabIndex = 2
        Button1.Text = "..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 3
        Label2.Text = "Способ импорта"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(36, 75)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(274, 19)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Импортировать данные в новый справочник"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(36, 100)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(342, 19)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Text = "Добавить копию данных к существующему справочнику"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 15)
        Label3.TabIndex = 6
        Label3.Text = "Параметры импорта"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(221, 15)
        Label4.TabIndex = 7
        Label4.Text = "Имя справочника (куда импортируем)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(51, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(192, 15)
        Label5.TabIndex = 8
        Label5.Text = "Имя листа (откуда импортируем)"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(51, 173)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(248, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(51, 230)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(248, 23)
        ComboBox2.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(334, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 11
        Label6.Text = "Разделители"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(334, 180)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(83, 19)
        RadioButton3.TabIndex = 12
        RadioButton3.TabStop = True
        RadioButton3.Text = "Табуляция"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(334, 205)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(132, 19)
        RadioButton4.TabIndex = 13
        RadioButton4.TabStop = True
        RadioButton4.Text = "Точка с запятой ( ; )"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(334, 230)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(88, 19)
        RadioButton5.TabIndex = 14
        RadioButton5.TabStop = True
        RadioButton5.Text = "Запятая ( , )"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(334, 255)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(77, 19)
        RadioButton6.TabIndex = 15
        RadioButton6.TabStop = True
        RadioButton6.Text = "Точка ( . )"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(334, 281)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(68, 19)
        RadioButton7.TabIndex = 16
        RadioButton7.TabStop = True
        RadioButton7.Text = "Пробел"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(334, 306)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(65, 19)
        RadioButton8.TabIndex = 17
        RadioButton8.TabStop = True
        RadioButton8.Text = "Другой"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(439, 302)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(30, 23)
        TextBox2.TabIndex = 18
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(36, 336)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(263, 19)
        CheckBox1.TabIndex = 19
        CheckBox1.Text = "Первая строка содержит заголоки стобцов"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(36, 361)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(323, 19)
        CheckBox2.TabIndex = 20
        CheckBox2.Text = "Проверять типы данных и структуру перед импортом"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(302, 401)
        Button2.Name = "Button2"
        Button2.Size = New Size(76, 23)
        Button2.TabIndex = 21
        Button2.Text = "Импорт"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(391, 401)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 22
        Button3.Text = "Отмена"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmImport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 436)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(RadioButton8)
        Controls.Add(RadioButton7)
        Controls.Add(RadioButton6)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(Label6)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "frmImport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Импорт данных"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
