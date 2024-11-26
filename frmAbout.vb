Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "О программе" 'заголовок формы
        Me.MdiParent = frmMain 'определение родительской формы
        'Me.LayoutMdi(MdiLayout.Cascade) 'Расположение дочерней формы  

        lblAbout.Text = $"Это программа является прикладным программным обеспечением 
                        деятельности отдела учета домовладений."
        cmdClose.Text = "Закрыть"
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class


