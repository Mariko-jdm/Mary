<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        lblAbout = New Label()
        cmdClose = New Button()
        SuspendLayout()
        ' 
        ' lblAbout
        ' 
        lblAbout.Location = New Point(68, 134)
        lblAbout.Name = "lblAbout"
        lblAbout.Size = New Size(459, 50)
        lblAbout.TabIndex = 0
        lblAbout.Text = "Это программа является прикладным программным обеспечением деятельности отдела учета домовладений."
        lblAbout.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmdClose
        ' 
        cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), Image)
        cmdClose.ImageAlign = ContentAlignment.MiddleLeft
        cmdClose.Location = New Point(494, 319)
        cmdClose.Name = "cmdClose"
        cmdClose.Size = New Size(78, 30)
        cmdClose.TabIndex = 1
        cmdClose.Text = "Закрыть"
        cmdClose.TextAlign = ContentAlignment.MiddleRight
        cmdClose.UseVisualStyleBackColor = True
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(cmdClose)
        Controls.Add(lblAbout)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAbout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "О программе"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblAbout As Label
    Friend WithEvents cmdClose As Button
End Class
