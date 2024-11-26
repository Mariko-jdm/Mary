<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Label1 = New Label()
        Label2 = New Label()
        WindowsName = New CheckBox()
        Password_Visible = New Button()
        login = New TextBox()
        Password = New TextBox()
        log_in = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 15)
        Label1.TabIndex = 0
        Label1.Text = "Имя пользователя"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 1
        Label2.Text = "Пароль"
        ' 
        ' WindowsName
        ' 
        WindowsName.AutoSize = True
        WindowsName.Location = New Point(12, 108)
        WindowsName.Name = "WindowsName"
        WindowsName.Size = New Size(245, 19)
        WindowsName.TabIndex = 4
        WindowsName.Text = "Использовать учетную запись Windows"
        WindowsName.UseVisualStyleBackColor = True
        ' 
        ' Password_Visible
        ' 
        Password_Visible.Image = CType(resources.GetObject("Password_Visible.Image"), Image)
        Password_Visible.Location = New Point(295, 66)
        Password_Visible.Name = "Password_Visible"
        Password_Visible.Size = New Size(30, 23)
        Password_Visible.TabIndex = 5
        Password_Visible.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        login.Location = New Point(127, 22)
        login.Name = "login"
        login.Size = New Size(198, 23)
        login.TabIndex = 1
        ' 
        ' Password
        ' 
        Password.Location = New Point(127, 66)
        Password.Name = "Password"
        Password.Size = New Size(170, 23)
        Password.TabIndex = 2
        ' 
        ' log_in
        ' 
        log_in.Image = CType(resources.GetObject("log_in.Image"), Image)
        log_in.ImageAlign = ContentAlignment.MiddleLeft
        log_in.Location = New Point(256, 130)
        log_in.Name = "log_in"
        log_in.Size = New Size(69, 23)
        log_in.TabIndex = 3
        log_in.Text = "Войти"
        log_in.TextAlign = ContentAlignment.MiddleRight
        log_in.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(341, 165)
        Controls.Add(log_in)
        Controls.Add(Password)
        Controls.Add(login)
        Controls.Add(Password_Visible)
        Controls.Add(WindowsName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Авторизация в системе"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WindowsName As CheckBox
    Friend WithEvents Password_Visible As Button
    Friend WithEvents login As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents log_in As Button
End Class
