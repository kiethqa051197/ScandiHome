#Region "References"

Imports HTLFW

#End Region

Public Class frmBaseForReport
    Inherits HTLFW.frmBaseForReport

#Region "Declares"

    Private _DBContext As DBs.AppDbDataContext

#End Region

#Region "Subs"

    Public Sub ResetDBContext()
        If DesignMode Then Exit Sub
        If IsDisposed OrElse Disposing Then Exit Sub
        If Not AppIsReady() Then Exit Sub
        Try
            _DBContext.Release()
        Catch ex As Exception
        End Try

        Dim mConnection As SqlClient.SqlConnection = Nothing
        Try
            mConnection = AppBase.AppConnectionInfor.CreateConnection
        Catch ex As Exception
            Try
                mConnection = AppBase.AppConnectionInfor.CreateConnection
            Catch ex1 As Exception
                Try
                    mConnection = AppBase.AppConnectionInfor.CreateConnection
                Catch ex2 As Exception
                    Try
                        mConnection = AppBase.AppConnectionInfor.CreateConnection
                    Catch ex3 As Exception
                        Try
                            mConnection = AppBase.AppConnectionInfor.CreateConnection
                        Catch ex4 As Exception
                        End Try
                    End Try
                End Try
            End Try
        End Try

        If Not mConnection Is Nothing Then
            Try
                _DBContext = New DBs.AppDbDataContext(mConnection)
                _DBContext.CommandTimeout = 0 'AppBase.AppConnectionInfor.ConnectionTimeOut
            Catch ex As Exception
                System.Threading.Thread.Sleep(100)
                Try
                    _DBContext = New DBs.AppDbDataContext(mConnection)
                    _DBContext.CommandTimeout = 0 'AppBase.AppConnectionInfor.ConnectionTimeOut
                Catch ex1 As Exception
                    System.Threading.Thread.Sleep(100)
                    Try
                        _DBContext = New DBs.AppDbDataContext(mConnection)
                        _DBContext.CommandTimeout = 0 'AppBase.AppConnectionInfor.ConnectionTimeOut
                    Catch ex2 As Exception
                        System.Threading.Thread.Sleep(100)
                        Try
                            _DBContext = New DBs.AppDbDataContext(mConnection)
                            _DBContext.CommandTimeout = 0 'AppBase.AppConnectionInfor.ConnectionTimeOut
                        Catch ex3 As Exception
                            System.Threading.Thread.Sleep(100)
                            Try
                                _DBContext = New DBs.AppDbDataContext(mConnection)
                                _DBContext.CommandTimeout = 0 'AppBase.AppConnectionInfor.ConnectionTimeOut
                            Catch ex4 As Exception
                            End Try
                        End Try
                    End Try
                End Try
            End Try
        Else
            _DBContext = Nothing
        End If
        If _DBContext Is Nothing Then
            AppDevWaitingForm.Hide()
            HTLFW.MsgBox.ShowErrorStop(HTLFW.HTLLib.HTLStringFuncs.TranslateResource(HTLFW.My.Resources.MessageContent.infoErrorRUNTIMECONNECTFAILED, ""))
            RestartAppOnConnectionBroken()
            Exit Sub
        End If
    End Sub

#End Region

#Region "Functions"

    Public Function DBContext() As DBs.AppDbDataContext
        If AppBase.AppStatus <> eAppStatus.None And AppBase.AppStatus <> eAppStatus.RefreshConfig Then
            ResetDBContext()
        End If
        Return _DBContext
    End Function

    Public Function DBContextCreateNew() As DBs.AppDbDataContext
        Try
            Dim mDBContext = New DBs.AppDbDataContext(AppBase.AppConnectionInfor.CreateConnection)
            mDBContext.CommandTimeout = 0 'AppBase.AppConnectionInfor.ConnectionTimeOut
            Return mDBContext
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#Region "System Values"

    Public Function sysval_SOLESOLUONG() As Integer
        Return DBs.SystemValues.SOLESOLUONG
    End Function
    Public Function sysval_SOLEDONGIA() As Integer
        Return DBs.SystemValues.SOLEDONGIA
    End Function
    Public Function sysval_SOLESOTIEN() As Integer
        Return DBs.SystemValues.SOLESOTIEN
    End Function
    Public Function sysval_SOLETYLE() As Integer
        Return DBs.SystemValues.SOLETYLE
    End Function

#End Region

End Class
