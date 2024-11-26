Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Password.UseSystemPasswordChar = True

        Dim txt_login = "Mary"
        Dim txt_password = "qwerty12345"
    End Sub

    'Событие "Показать пароль"
    Private Sub Password_Visible_MouseDown(sender As Object, e As MouseEventArgs) Handles Password_Visible.MouseDown
        Password.UseSystemPasswordChar = False
    End Sub
    Private Sub Password_Visible_MouseUp(sender As Object, e As MouseEventArgs) Handles Password_Visible.MouseUp
        Password.UseSystemPasswordChar = True
    End Sub

    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click
        Dim txt_login = "Mary"
        Dim txt_password = "qwerty12345"
        'вход через логин и пароль
        If WindowsName.Checked Then
            frmMain.ToolStrip1.Visible = True
            frmMain.MenuStrip1.Visible = True
            frmMain.StatusStrip1.Visible = True
            Me.DialogResult = DialogResult.OK

            frmMain.UserName.Text = "Пользователь: " & Environment.UserName

            'авториризация через учетную запись windows
        ElseIf (login.Text = txt_login And Password.Text = txt_password) Then
            frmMain.ToolStrip1.Visible = True
            frmMain.MenuStrip1.Visible = True
            frmMain.StatusStrip1.Visible = True
            Me.DialogResult = DialogResult.OK

            frmMain.UserName.Text = "Пользователь: " & txt_login
        Else
            MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

