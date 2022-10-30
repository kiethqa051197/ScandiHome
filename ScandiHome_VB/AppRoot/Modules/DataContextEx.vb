Imports Microsoft.VisualBasic
Imports System.Runtime.CompilerServices
Imports System.Data.Common
Imports System.Data.SqlClient

Module DataContextEx

    <Extension()> Public Sub Release(ByRef pDataContext As System.Data.Linq.DataContext)
        Try
            If pDataContext IsNot Nothing Then
                If pDataContext.Connection IsNot Nothing Then
                    pDataContext.Connection.Close()
                    SqlClient.SqlConnection.ClearPool(pDataContext.Connection)
                    pDataContext.Connection.Dispose()
                End If
                pDataContext.Dispose()
                pDataContext = Nothing
            End If
            SqlClient.SqlConnection.ClearAllPools()
        Catch ex As Exception
        End Try
    End Sub

    <Extension()> Public Function AppendToAppHistory(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pActionType As String, ByVal pActionDescription As String) As Boolean
        Return AppendToAppHistory(pDataContext, pActionType, "UNKOWN", "UNKOWN", pActionDescription, HTLFW.AppBase.AppUserLogin.UserName)
    End Function

    <Extension()> Public Function AppendToAppHistory(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pActionType As String, ByVal pActionDescription As String, ByVal pUserName As String) As Boolean
        Return AppendToAppHistory(pDataContext, pActionType, "UNKOWN", "UNKOWN", pActionDescription, pUserName)
    End Function

    <Extension()> Public Function AppendToAppHistory(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pActionType As String, ByVal pFunctionRelate As String, ByVal pObjectRelate As String, ByVal pActionDescription As String) As Boolean
        Return AppendToAppHistory(pDataContext, pActionType, pFunctionRelate, pObjectRelate, pActionDescription, HTLFW.AppBase.AppUserLogin.UserName)
    End Function

    <Extension()> Public Function AppendToAppHistory(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pActionType As String, ByVal pFunctionRelate As String, ByVal pObjectRelate As String, ByVal pActionDescription As String, ByVal pUserName As String) As Boolean
        Try
            Return pDataContext.Execute("INSERT INTO Sys_ActionHistory (ComputerName,UserName,ActionType,FunctionRelate,ObjectRelate,ActionDescription,ActionDate) SELECT HOST_NAME() as ComputerName,N'" + pUserName + "'UserName,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pActionType, "") + "' as ActionType,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pFunctionRelate, "") + "' as FunctionRelate,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pObjectRelate, "") + "' as ObjectRelate,N'" + HTLFW.HTLLib.HTLComFuncs.Nz(pActionDescription, "") + "' as ActionDescription,GETDATE() as ActionDate ") > 0
        Catch ex As Exception
            Return False
        End Try
    End Function

    <Extension()> Public Sub TransactionStart(ByVal pDataContext As System.Data.Linq.DataContext)
        pDataContext.Transaction = pDataContext.Connection.BeginTransaction
    End Sub

    <Extension()> Public Sub TransactionCommit(ByVal pDataContext As System.Data.Linq.DataContext)
        pDataContext.Transaction.Commit()
        pDataContext.Transaction = Nothing
    End Sub

    <Extension()> Public Sub TransactionRollback(ByVal pDataContext As System.Data.Linq.DataContext)
        pDataContext.Transaction.Rollback()
        pDataContext.Transaction = Nothing
    End Sub

    <Extension()> Public Function ExecuteReader(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pSQLString As String) As DbDataReader
        Try
            Dim cmd = pDataContext.Connection.CreateCommand()
            If Not pDataContext.Transaction Is Nothing Then cmd.Transaction = pDataContext.Transaction
            cmd.CommandText = pSQLString
            cmd.CommandType = CommandType.Text
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            Dim ret = cmd.ExecuteReader()
            Return ret
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function Execute(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pSQLString As String) As Integer
        Try
            Dim cmd = pDataContext.Connection.CreateCommand()
            If Not pDataContext.Transaction Is Nothing Then cmd.Transaction = pDataContext.Transaction
            cmd.CommandText = pSQLString
            cmd.CommandType = CommandType.Text
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            Return cmd.ExecuteNonQuery
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function ExecuteScalar(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pSQLString As String) As Object
        Try
            Dim cmd = pDataContext.Connection.CreateCommand()
            If Not pDataContext.Transaction Is Nothing Then cmd.Transaction = pDataContext.Transaction
            cmd.CommandText = pSQLString
            cmd.CommandType = CommandType.Text
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function ExecuteDataTable(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pSQLString As String) As DataTable
        Dim newdt = New DataTable()
        Try
            newdt.Load(pDataContext.ExecuteReader(pSQLString))
        Catch ex As Exception
            Throw ex
        End Try
        Return newdt
    End Function

    <Extension()> Public Function ExecuteDataTableEditable(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pSQLString As String) As DataTable
        Dim newdt = New DataTable()
        Try
            Dim cmd = pDataContext.Connection.CreateCommand()
            If Not pDataContext.Transaction Is Nothing Then cmd.Transaction = pDataContext.Transaction
            cmd.CommandText = pSQLString
            cmd.CommandType = CommandType.Text
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            Dim mAdapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            newdt.Locale = System.Globalization.CultureInfo.InvariantCulture
            mAdapter.Fill(newdt)
            Return newdt
        Catch ex As Exception
            Throw ex
        End Try
        Return newdt
    End Function

    <Extension()> Public Function DLookup(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DLookup(pDataContext, pFieldName, pTableViewName, "")
    End Function
    <Extension()> Public Function DLookup(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select [" & pFieldName & "] as Value From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            Else
                mSql = "Select [" & pFieldName & "] as Value From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            End If
            Return pDataContext.ExecuteScalar(mSql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '<Extension()> Public Function DLookup(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pValueOnError As Object) As Object
    '    Return DLookup(pDataContext, pFieldName, pTableViewName, "", pValueOnError)
    'End Function
    <Extension()> Public Function DLookup(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String, ByVal pValueOnError As Object) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select [" & pFieldName & "] as Value From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            Else
                mSql = "Select [" & pFieldName & "] as Value From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            End If
            Return pDataContext.ExecuteScalar(mSql)
        Catch ex As Exception
            Return pValueOnError
        End Try
    End Function

    <Extension()> Public Function DMin(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DMin(pDataContext, pFieldName, pTableViewName, "")
    End Function
    <Extension()> Public Function DMin(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select MIN([" & pFieldName & "]) as Value From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            Else
                mSql = "Select MIN([" & pFieldName & "]) as Value From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            End If
            Return pDataContext.ExecuteScalar(mSql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DMax(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DMax(pDataContext, pFieldName, pTableViewName, "")
    End Function
    <Extension()> Public Function DMax(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select MAX([" & pFieldName & "]) as Value From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            Else
                mSql = "Select MAX([" & pFieldName & "]) as Value From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            End If
            Return pDataContext.ExecuteScalar(mSql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DCount(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String) As Integer
        Return DCount(pDataContext, pFieldName, pTableViewName, "")
    End Function
    <Extension()> Public Function DCount(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Integer
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select COUNT([" & pFieldName & "]) as Value From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            Else
                mSql = "Select COUNT([" & pFieldName & "]) as Value From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            End If
            Return CType(pDataContext.ExecuteScalar(mSql), Integer)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DCountDISTINCT(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String) As Integer
        Return DCountDISTINCT(pDataContext, pFieldName, pTableViewName, "")
    End Function
    <Extension()> Public Function DCountDISTINCT(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Integer
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select COUNT( DISTINCT [" & pFieldName & "]) as Value From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            Else
                mSql = "Select COUNT( DISTINCT [" & pFieldName & "]) as Value From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            End If
            Return CType(pDataContext.ExecuteScalar(mSql), Integer)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DSum(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String) As Object
        Return DSum(pDataContext, pFieldName, pTableViewName, "")
    End Function
    <Extension()> Public Function DSum(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pFieldName As String, ByVal pTableViewName As String, ByVal pWhere As String) As Object
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "Select SUM(ISNULL([" & pFieldName & "],0)) as Value From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            Else
                mSql = "Select SUM(ISNULL([" & pFieldName & "],0)) as Value From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "")
            End If
            Return pDataContext.ExecuteScalar(mSql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <Extension()> Public Function DExists(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pTableViewName As String) As Boolean
        Return DExists(pDataContext, pTableViewName, "")
    End Function
    <Extension()> Public Function DExists(ByVal pDataContext As System.Data.Linq.DataContext, ByVal pTableViewName As String, ByVal pWhere As String) As Boolean
        Dim mSql As String = ""
        Try
            If InStr(pTableViewName.ToUpper, "SELECT") > 0 Then
                mSql = "SELECT CASE WHEN EXISTS(Select NULL From (" & pTableViewName & ") as tblData " & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "") & ") THEN 1 ELSE 0 END as Value"
            Else
                mSql = "SELECT CASE WHEN EXISTS(Select NULL From [" & pTableViewName & "]" & If(Len(pWhere.ToString) > 0, " WHERE " & pWhere, "") & ") THEN 1 ELSE 0 END as Value"
            End If
            If CType(pDataContext.ExecuteScalar(mSql), Integer) = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Module
