Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Module SQLConnectionEx

    '<Extension()> Public Sub Release(ByRef pConnection As System.Data.SqlClient.SqlConnection)
    '    Try
    '        If pConnection IsNot Nothing Then
    '            pConnection.Close()
    '            SqlClient.SqlConnection.ClearPool(pConnection)
    '            pConnection.Dispose()
    '            pConnection = Nothing
    '        End If
    '        SqlClient.SqlConnection.ClearAllPools()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    <Extension()> Public Function AppendToAppHistory(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pActionType As String, ByVal pActionDescription As String) As Boolean
        Return AppendToAppHistory(pConnection, pActionType, "UNKOWN", "UNKOWN", pActionDescription, "UNKOWN", Nothing)
    End Function
    <Extension()> Public Function AppendToAppHistory(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pActionType As String, ByVal pActionDescription As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Boolean
        Return AppendToAppHistory(pConnection, pActionType, "UNKOWN", "UNKOWN", pActionDescription, "UNKOWN", pTransaction)
    End Function
    <Extension()> Public Function AppendToAppHistory(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pActionType As String, ByVal pActionDescription As String, ByVal pUserName As String) As Boolean
        Return AppendToAppHistory(pConnection, pActionType, "UNKOWN", "UNKOWN", pActionDescription, pUserName, Nothing)
    End Function
    <Extension()> Public Function AppendToAppHistory(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pActionType As String, ByVal pActionDescription As String, ByVal pUserName As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Boolean
        Return AppendToAppHistory(pConnection, pActionType, "UNKOWN", "UNKOWN", pActionDescription, pUserName, pTransaction)
    End Function
    <Extension()> Public Function AppendToAppHistory(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pActionType As String, ByVal pFunctionRelate As String, ByVal pObjectRelate As String, ByVal pActionDescription As String, ByVal pUserName As String) As Boolean
        Return AppendToAppHistory(pConnection, pActionType, pFunctionRelate, pObjectRelate, pActionDescription, pUserName, Nothing)
    End Function
    <Extension()> Public Function AppendToAppHistory(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pActionType As String, ByVal pFunctionRelate As String, ByVal pObjectRelate As String, ByVal pActionDescription As String, ByVal pUserName As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Boolean
        Try
            Return Execute(pConnection, "INSERT INTO Sys_ActionHistory (ComputerName,UserName,ActionType,FunctionRelate,ObjectRelate,ActionDescription,ActionDate) SELECT HOST_NAME() as ComputerName,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pUserName, "") + "'UserName,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pActionType, "") + "' as ActionType,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pFunctionRelate, "") + "' as FunctionRelate,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pObjectRelate, "") + "' as ObjectRelate,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pActionDescription, "") + "' as ActionDescription,GETDATE() as ActionDate ", 0, pTransaction) > 0
        Catch ex As Exception
            Return False
        End Try
    End Function

    <Extension()> Public Function Execute(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String) As Integer
        Return Execute(pConnection, pSQLString, 0, Nothing)
    End Function
    <Extension()> Public Function Execute(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As Integer
        Return Execute(pConnection, pSQLString, pCommandTimeout, Nothing)
    End Function
    <Extension()> Public Function Execute(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Integer
        Return Execute(pConnection, pSQLString, 0, pTransaction)
    End Function
    <Extension()> Public Function Execute(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Integer
        Try
            Dim mResult As Integer
            Using cmd = pConnection.CreateCommand()
                If Not pTransaction Is Nothing Then cmd.Transaction = pTransaction
                cmd.CommandTimeout = pCommandTimeout
                cmd.CommandText = pSQLString
                cmd.CommandType = CommandType.Text
                If cmd.Connection.State <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If
                mResult = cmd.ExecuteNonQuery
                cmd.Release()
            End Using
            Return mResult
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function ExecuteReader(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String) As DbDataReader
        Return ExecuteReader(pConnection, pSQLString, 0, Nothing)
    End Function
    <Extension()> Public Function ExecuteReader(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As DbDataReader
        Return ExecuteReader(pConnection, pSQLString, pCommandTimeout, Nothing)
    End Function
    <Extension()> Public Function ExecuteReader(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As DbDataReader
        Return ExecuteReader(pConnection, pSQLString, 0, pTransaction)
    End Function
    <Extension()> Public Function ExecuteReader(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As DbDataReader
        Try
            Dim mResult As Object = Nothing
            Using cmd = pConnection.CreateCommand()
                If Not pTransaction Is Nothing Then cmd.Transaction = pTransaction
                cmd.CommandTimeout = pCommandTimeout
                cmd.CommandText = pSQLString
                cmd.CommandType = CommandType.Text
                If cmd.Connection.State <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If
                mResult = cmd.ExecuteReader()
                cmd.Release()
            End Using
            Return mResult
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function ExecuteScalar(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String) As Object
        Return ExecuteScalar(pConnection, pSQLString, 0, Nothing)
    End Function
    <Extension()> Public Function ExecuteScalar(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As Object
        Return ExecuteScalar(pConnection, pSQLString, pCommandTimeout, Nothing)
    End Function
    <Extension()> Public Function ExecuteScalar(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Object
        Return ExecuteScalar(pConnection, pSQLString, 0, pTransaction)
    End Function
    <Extension()> Public Function ExecuteScalar(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Object
        Try
            Dim mResult As Object = Nothing
            Using cmd = pConnection.CreateCommand()
                If Not pTransaction Is Nothing Then cmd.Transaction = pTransaction
                cmd.CommandTimeout = pCommandTimeout
                cmd.CommandText = pSQLString
                cmd.CommandType = CommandType.Text
                If cmd.Connection.State <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If
                mResult = cmd.ExecuteScalar()
                If Not cmd.Transaction Is Nothing Then cmd.Transaction = Nothing
                cmd.Release()
            End Using
            Return mResult
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function ExecuteDataTable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String) As DataTable
        Return ExecuteDataTable(pConnection, pSQLString, 0, Nothing)
    End Function
    <Extension()> Public Function ExecuteDataTable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As DataTable
        Return ExecuteDataTable(pConnection, pSQLString, pCommandTimeout, Nothing)
    End Function
    <Extension()> Public Function ExecuteDataTable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As DataTable
        Return ExecuteDataTable(pConnection, pSQLString, 0, pTransaction)
    End Function
    <Extension()> Public Function ExecuteDataTable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As DataTable
        Dim newdt = New DataTable()
        Try
            If pTransaction IsNot Nothing Then
                newdt.Load(pConnection.ExecuteReader(pSQLString, pCommandTimeout, pTransaction))
            Else
                newdt.Load(pConnection.ExecuteReader(pSQLString, pCommandTimeout))
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return newdt
    End Function

    <Extension()> Public Function ExecuteDataTableEditable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String) As DataTable
        Return ExecuteDataTableEditable(pConnection, pSQLString, 0, Nothing)
    End Function
    <Extension()> Public Function ExecuteDataTableEditable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer) As DataTable
        Return ExecuteDataTableEditable(pConnection, pSQLString, pCommandTimeout, Nothing)
    End Function
    <Extension()> Public Function ExecuteDataTableEditable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As DataTable
        Return ExecuteDataTableEditable(pConnection, pSQLString, 0, pTransaction)
    End Function
    <Extension()> Public Function ExecuteDataTableEditable(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pSQLString As String, ByVal pCommandTimeout As Integer, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As DataTable
        Dim mResult = New DataTable()
        mResult.Locale = System.Globalization.CultureInfo.InvariantCulture
        Try
            Using cmd = pConnection.CreateCommand()
                If pTransaction IsNot Nothing Then cmd.Transaction = pTransaction
                cmd.CommandTimeout = pCommandTimeout
                cmd.CommandText = pSQLString
                cmd.CommandType = CommandType.Text
                If cmd.Connection.State <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If
                Using mAdapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    mAdapter.Fill(mResult)
                    mAdapter.Release()
                End Using
                cmd.Release()
            End Using
            Return mResult
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DLookup(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DLookup(pConnection, pFieldName, pTableViewName, Nothing, Nothing)
    End Function
    <Extension()> Public Function DLookup(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Return DLookup(pConnection, pFieldName, pTableViewName, pWhere, Nothing)
    End Function
    <Extension()> Public Function DLookup(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select " & pFieldName & " as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            Else
                mSql = "Select " & pFieldName & " as Value From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            End If
            If pTransaction IsNot Nothing Then
                Return pConnection.ExecuteScalar(mSql, 15, pTransaction)
            Else
                Return pConnection.ExecuteScalar(mSql, 15)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DMin(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DMin(pConnection, pFieldName, pTableViewName, Nothing, Nothing)
    End Function
    <Extension()> Public Function DMin(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Return DMin(pConnection, pFieldName, pTableViewName, pWhere, Nothing)
    End Function
    <Extension()> Public Function DMin(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select MIN(" & pFieldName & ") as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            Else
                mSql = "Select MIN(" & pFieldName & ") as Value From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            End If
            If pTransaction IsNot Nothing Then
                Return pConnection.ExecuteScalar(mSql, 15, pTransaction)
            Else
                Return pConnection.ExecuteScalar(mSql, 15)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DMax(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DMax(pConnection, pFieldName, pTableViewName, Nothing, Nothing)
    End Function
    <Extension()> Public Function DMax(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Return DMax(pConnection, pFieldName, pTableViewName, pWhere, Nothing)
    End Function
    <Extension()> Public Function DMax(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select MAX(" & pFieldName & ") as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            Else
                mSql = "Select MAX(" & pFieldName & ") as Value From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            End If
            If pTransaction IsNot Nothing Then
                Return pConnection.ExecuteScalar(mSql, 15, pTransaction)
            Else
                Return pConnection.ExecuteScalar(mSql, 15)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DCount(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String) As Integer
        Return DCount(pConnection, pFieldName, pTableViewName, Nothing, Nothing)
    End Function
    <Extension()> Public Function DCount(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Integer
        Return DCount(pConnection, pFieldName, pTableViewName, pWhere, Nothing)
    End Function
    <Extension()> Public Function DCount(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Integer
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select COUNT(" & pFieldName & ") as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            Else
                mSql = "Select COUNT(" & pFieldName & ") as Value From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            End If
            If pTransaction IsNot Nothing Then
                Return CType(pConnection.ExecuteScalar(mSql, 15, pTransaction), Integer)
            Else
                Return CType(pConnection.ExecuteScalar(mSql, 15), Integer)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DCountDISTINCT(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String) As Integer
        Return DCountDISTINCT(pConnection, pFieldName, pTableViewName, Nothing, Nothing)
    End Function
    <Extension()> Public Function DCountDISTINCT(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Integer
        Return DCountDISTINCT(pConnection, pFieldName, pTableViewName, pWhere, Nothing)
    End Function
    <Extension()> Public Function DCountDISTINCT(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Integer
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select COUNT( DISTINCT " & pFieldName & ") as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            Else
                mSql = "Select COUNT( DISTINCT " & pFieldName & ") as Value From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            End If
            If pTransaction IsNot Nothing Then
                Return CType(pConnection.ExecuteScalar(mSql, 15, pTransaction), Integer)
            Else
                Return CType(pConnection.ExecuteScalar(mSql, 15), Integer)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DSum(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DSum(pConnection, pFieldName, pTableViewName, Nothing, Nothing)
    End Function
    <Extension()> Public Function DSum(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Return DSum(pConnection, pFieldName, pTableViewName, pWhere, Nothing)
    End Function
    <Extension()> Public Function DSum(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select SUM(ISNULL(" & pFieldName & ",0)) as Value From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            Else
                mSql = "Select SUM(ISNULL(" & pFieldName & ",0)) as Value From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "")
            End If
            If pTransaction IsNot Nothing Then
                Return pConnection.ExecuteScalar(mSql, 15, pTransaction)
            Else
                Return pConnection.ExecuteScalar(mSql, 15)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DExists(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pTableViewName As String) As Boolean
        Return DExists(pConnection, pTableViewName, Nothing, Nothing)
    End Function
    <Extension()> Public Function DExists(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pTableViewName As String, ByVal pWhere As String) As Boolean
        Return DExists(pConnection, pTableViewName, pWhere, Nothing)
    End Function
    <Extension()> Public Function DExists(ByVal pConnection As System.Data.SqlClient.SqlConnection, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pTransaction As System.Data.SqlClient.SqlTransaction) As Boolean
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "SELECT CASE WHEN EXISTS(Select NULL From (" & pTableViewName & ") as tblData " & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "") & ") THEN 1 ELSE 0 END as Value"
            Else
                mSql = "SELECT CASE WHEN EXISTS(Select NULL From " & pTableViewName & "" & If(Not HTLFW.HTLLib.HTLComFuncs.IsNoValue(pWhere), " WHERE " & pWhere, "") & ") THEN 1 ELSE 0 END as Value"
            End If
            If pTransaction IsNot Nothing Then
                If CType(pConnection.ExecuteScalar(mSql, 15, pTransaction), Integer) = 1 Then
                    Return True
                Else
                    Return False
                End If
            Else
                If CType(pConnection.ExecuteScalar(mSql, 15), Integer) = 1 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Module