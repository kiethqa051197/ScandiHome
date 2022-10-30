Imports HTLFW
Imports ScandiHome_VB.AppConfig

Public Class frmLogin
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            AppDevWaitingForm.Show()
            Using mData = AppConfigHelper.GetDataTable("exec dbo.SCH_proc_Login " &
                                                                    " N'" & txtUserName.Text & "' " &
                                                                    " , N'" & txtPass.Text & "' " &
                                                                "")

                If Boolean.Parse(mData.Rows(0).Item("Success")) Then
                    Me.Hide()
                    Dim mForm As New frmMain
                    mForm.ShowDialog(Me)
                    mForm.Release()
                    AppDevWaitingForm.Hide()
                    Me.Dispose()
                Else
                    AppDevWaitingForm.Hide()
                    ShowErrorStop(mData.Rows(0).Item("Message"))
                End If
            End Using
        Catch ex As Exception
            ShowErrorStop(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class
