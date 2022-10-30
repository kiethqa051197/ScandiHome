Imports HTLFW

Public Class frmMain

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.Modal Then Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Me_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ReleaseMemory()
    End Sub

    Private Sub mnuSanPham_Click(sender As Object, e As EventArgs) Handles mnuSanPham.Click
        Try
            AppDevWaitingForm.Show()
            Using mForm As New frmLST_Product()
                mForm.ShowDialog(Me)
                mForm.Release()
            End Using
            AppDevWaitingForm.Hide()
        Catch ex As Exception
            AppDevWaitingForm.Hide()
            ShowErrorStop(ex.Message)
        End Try
    End Sub

    Private Sub mnuDonHang_Click(sender As Object, e As EventArgs) Handles mnuDonHang.Click
        Try
            AppDevWaitingForm.Show()
            Using mForm As New frmENT_Order()
                mForm.ShowDialog(Me)
                mForm.Release()
            End Using
            AppDevWaitingForm.Hide()
        Catch ex As Exception
            AppDevWaitingForm.Hide()
            ShowErrorStop(ex.Message)
        End Try
    End Sub
End Class