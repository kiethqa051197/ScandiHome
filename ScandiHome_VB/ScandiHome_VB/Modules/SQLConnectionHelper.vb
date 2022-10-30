Imports HTLFW.HTLLib
Imports HTLFW.HTLLib.HTLComFuncs
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.IO

Namespace AppConfig

    Public Class AppConfigHelper

        Public Shared Property ServerName As String
        Public Shared Property DatabaseName As String
        Public Shared Property UserName As String
        Public Shared Property Pwd As String
        Public Shared Property TimeOut As Integer
        Public Shared Property Map As String

        Public Shared Function GetSQLConnection() As SqlConnection
            If (IsNoValue(ServerName) OrElse IsNoValue(DatabaseName) OrElse IsNoValue(UserName)) Then
                Dim mDataConfigFile As String = Path.Combine(HTLSystemOSFuncs.AppDir, "AppConfig.INI")
                If IsNoValue(mDataConfigFile) OrElse Not IO.File.Exists(mDataConfigFile) Then
                    Throw New Exception(My.Resources.DATACONFIGNOTFOUND)
                Else
                    ServerName = HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "ServerName") 'HTLSecurityFuncs.AppF_DeEncryptPWDEx2(HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "ServerName"), "-MYTSolution-")
                    DatabaseName = HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "DatabaseName") 'HTLSecurityFuncs.AppF_DeEncryptPWDEx2(HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "DatabaseName"), "-MYTSolution-")
                    UserName = HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "UserName") 'HTLSecurityFuncs.AppF_DeEncryptPWDEx2(HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "UserName"), "-MYTSolution-")
                    Pwd = HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "Pwd") 'HTLSecurityFuncs.AppF_DeEncryptPWDEx2(HTLFileFuncs.ReadINIFile(mDataConfigFile, "ConnectionInfor", "Pwd"), "-MYTSolution-")
                End If
            End If
            Return GetSQLConnection(ServerName, DatabaseName, UserName, Pwd, TimeOut)
        End Function
        Public Shared Function GetSQLConnection(pServerName As String, pDatabaseName As String, pUserName As String, pPwd As String) As SqlConnection
            Return GetSQLConnection(pServerName, pDatabaseName, pUserName, pPwd, 5)
        End Function
        Public Shared Function GetSQLConnection(pServerName As String, pDatabaseName As String, pUserName As String, pPwd As String, pTimeOut As Integer) As SqlConnection
            Try
                Dim mResult = HTLDBFuncs.ConnectToSQLServer(pServerName, pDatabaseName, pUserName, pPwd, pTimeOut)
                If mResult.ReturnObject Is Nothing Then
                    Throw New Exception(mResult.ErrDescription)
                Else
                    Return CType(mResult.ReturnObject, SqlConnection)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function AppendToAppHistory(ByVal pActionType As String, ByVal pActionDescription As String, ByVal pUserName As String) As Boolean
            Return AppendToAppHistory(pActionType, "UNKOWN", "UNKOWN", pActionDescription, Nothing, pUserName)
        End Function
        Public Shared Function AppendToAppHistory(ByVal pActionType As String, ByVal pActionDescription As String, ByVal pComputerInfo As String, ByVal pUserName As String) As Boolean
            Return AppendToAppHistory(pActionType, "UNKOWN", "UNKOWN", pActionDescription, pComputerInfo, pUserName)
        End Function
        Public Shared Function AppendToAppHistory(ByVal pActionType As String, ByVal pObjectRelate As String, ByVal pActionDescription As String, ByVal pComputerInfo As String, ByVal pUserName As String) As Boolean
            Return AppendToAppHistory(pActionType, "UNKOWN", pObjectRelate, pActionDescription, pComputerInfo, pUserName)
        End Function
        Public Shared Function AppendToAppHistory(ByVal pActionType As String, ByVal pFunctionRelate As String, ByVal pObjectRelate As String, ByVal pActionDescription As String, ByVal pComputerInfo As String, ByVal pUserName As String) As Boolean
            Try
                Return Execute("INSERT INTO dattbl_ApiTransaction (ComputerInfo,UserName,ActionType,FunctionRelate,ObjectRelate,ActionDescription,ActionDate) " &
                               "SELECT " &
                                   "N'" & Nz(pComputerInfo, "") & "' as ComputerInfo " &
                                   ",N'" + pUserName + "' as UserName " &
                                   ",N'" + Nz(pActionType, "") + "' as ActionType " &
                                   ",N'" + Nz(pFunctionRelate, "") + "' as FunctionRelate " &
                                   ",N'" + Nz(pObjectRelate, "") + "' as ObjectRelate " &
                                   ",N'" + Nz(pActionDescription, "") + "' as ActionDescription " &
                                   ",GETDATE() as ActionDate " &
                               "", CInt(Nz(TimeOut, 0))) > 0
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Shared Function Execute(ByVal pSQLString As String) As Integer
            Return Execute(pSQLString, 0, Nothing)
        End Function
        Public Shared Function Execute(ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As Integer
            Return Execute(pSQLString, pCommandTimeout, Nothing)
        End Function
        Public Shared Function Execute(ByVal pSQLString As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Integer
            Return Execute(pSQLString, 0, pTransaction)
        End Function
        Public Shared Function Execute(ByVal pSQLString As String, ByVal pCommandTimeout As Integer, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Integer
            Try
                Dim mResult As Integer
                Using mConnection As SqlConnection = GetSQLConnection()
                    Using cmd = mConnection.CreateCommand()
                        If pTransaction IsNot Nothing Then cmd.Transaction = pTransaction
                        cmd.CommandTimeout = pCommandTimeout
                        cmd.CommandText = pSQLString
                        cmd.CommandType = CommandType.Text
                        If cmd.Connection.State <> ConnectionState.Open Then cmd.Connection.Open()
                        mResult = cmd.ExecuteNonQuery()
                    End Using
                End Using
                Return mResult
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Shared Function ExecuteReader(ByVal pConnection As SqlConnection, ByVal pSQLString As String) As DbDataReader
            Return ExecuteReader(pConnection, pSQLString, 0, Nothing)
        End Function
        Private Shared Function ExecuteReader(ByVal pConnection As SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As DbDataReader
            Return ExecuteReader(pConnection, pSQLString, pCommandTimeout, Nothing)
        End Function
        Private Shared Function ExecuteReader(ByVal pConnection As SqlConnection, ByVal pSQLString As String, ByVal pTransaction As SqlTransaction) As DbDataReader
            Return ExecuteReader(pConnection, pSQLString, 0, pTransaction)
        End Function
        Private Shared Function ExecuteReader(ByVal pConnection As SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer, ByVal pTransaction As SqlTransaction) As DbDataReader
            Try
                Dim mResult As SqlDataReader
                Using cmd As SqlCommand = pConnection.CreateCommand()
                    If pTransaction IsNot Nothing Then cmd.Transaction = pTransaction
                    cmd.CommandTimeout = pCommandTimeout
                    cmd.CommandText = pSQLString
                    cmd.CommandType = CommandType.Text
                    If cmd.Connection.State <> ConnectionState.Open Then cmd.Connection.Open()
                    mResult = cmd.ExecuteReader()
                    Return mResult
                End Using
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function GetDataTable(ByVal pSQLString As String) As DataTable
            Return GetDataTable(pSQLString, 0)
        End Function
        Public Shared Function GetDataTable(ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As DataTable
            Dim mDataTableReturn As DataTable = New DataTable()
            Try
                Using mConnection As SqlConnection = GetSQLConnection()
                    mDataTableReturn.Load(ExecuteReader(mConnection, pSQLString, pCommandTimeout))
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return mDataTableReturn
        End Function

        Public Shared Function GetFirstDataRow(ByVal pSQLString As String) As DataRow
            Return GetFirstDataRow(pSQLString, 0)
        End Function
        Public Shared Function GetFirstDataRow(ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As DataRow
            Dim mDataTableReturn As DataTable = New DataTable()
            Try
                Using mConnection As SqlConnection = GetSQLConnection()
                    mDataTableReturn.Load(ExecuteReader(mConnection, pSQLString, pCommandTimeout))
                End Using
                If mDataTableReturn Is Nothing Then
                    Return Nothing
                Else
                    If mDataTableReturn.Rows.Count = 0 Then
                        Return Nothing
                    Else
                        Return mDataTableReturn.Rows(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function DMax(ByVal pFieldName As String, ByVal pTableViewName As String) As Object
            Return DMax(pFieldName, pTableViewName, Nothing)
        End Function
        Public Shared Function DMax(ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
            Dim mSql As String = ""
            Try
                If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                    mSql = "Select MAX(" & pFieldName & ") as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
                Else
                    mSql = "Select MAX(" & pFieldName & ") as Value From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
                End If
                Return ExecuteScalar(mSql)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function DLookup(ByVal pFieldName As String, ByVal pTableViewName As String) As Object
            Return DLookup(pFieldName, pTableViewName, Nothing)
        End Function
        Public Shared Function DLookup(ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
            Dim mSql As String = ""
            Try
                If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                    mSql = "Select " & pFieldName & " as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
                Else
                    mSql = "Select " & pFieldName & " as Value From " & pTableViewName & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
                End If
                Return ExecuteScalar(mSql)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function DExists(ByVal pTableViewName As String) As Boolean
            Return DExists(pTableViewName, "")
        End Function
        Public Shared Function DExists(ByVal pTableViewName As String, ByVal pWhere As String) As Boolean
            Dim mSql As String = ""
            Try
                If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                    mSql = "SELECT CASE WHEN EXISTS(Select NULL From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "") & ") THEN 1 ELSE 0 END as Value"
                Else
                    mSql = "SELECT CASE WHEN EXISTS(Select NULL From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "") & ") THEN 1 ELSE 0 END as Value"
                End If
                If CType(ExecuteScalar(mSql), Integer) = 1 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function ExecuteScalar(ByVal pSQLString As String) As Object
            Try
                Using mConnection As SqlConnection = GetSQLConnection()
                    Using cmd = mConnection.CreateCommand()
                        cmd.CommandText = pSQLString
                        cmd.CommandType = CommandType.Text
                        If cmd.Connection.State <> ConnectionState.Open Then
                            cmd.Connection.Open()
                        End If
                        Return cmd.ExecuteScalar()
                    End Using
                End Using
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

End Namespace
